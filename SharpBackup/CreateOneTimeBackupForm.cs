using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpBackup
{
    public partial class CreateOneTimeBackupForm : Form
    {
        struct FileBackup
        {
            public String originalPath;
            public String newBackupPath;
        }

        List<Backup> backups = new List<Backup>();
        List<String> filePaths = new List<String>();
        List<String> directoryPaths = new List<String>();

        public CreateOneTimeBackupForm()
        {
            InitializeComponent();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (addFolderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                String folderPath = addFolderBrowser.SelectedPath;
                if (folderPath != "")
                {
                    Backup backup = new Backup("", addFolderBrowser.SelectedPath, txtBackupPath.Text, true);
                    backups.Add(backup);
                    oneTimeBackupFoldersListView.Items.Add(addFolderBrowser.SelectedPath);
                }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                String filePath = addFileDialog.InitialDirectory + addFileDialog.FileName;
                if (filePath != "")
                {
                    Backup backup = new Backup("", filePath, txtBackupPath.Text, false);
                    backups.Add(backup);
                    oneTimeBackupFoldersListView.Items.Add(filePath);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (oneTimeBackupFoldersListView.SelectedItems.Count > 0)
            {
                oneTimeBackupFoldersListView.Items.RemoveAt(oneTimeBackupFoldersListView.SelectedIndices[0]);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (addBackupDestDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtBackupPath.Text = addBackupDestDialog.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtBackupPath.Text == "")
            {
                MessageBox.Show("Invalid backup path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (oneTimeBackupFoldersListView.Items.Count <= 0)
            {
                MessageBox.Show("No backups have been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnStart.Enabled = false;

            createBackupsWorker.RunWorkerAsync();
        }

        private void createBackupsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var paths = new List<FileBackup>();

            // Add all files from backup targets to a list to calculate progress percentage for progress bar.
            foreach (Backup backup in backups)
            {
                // Check if the path is a directory or file.
                // If it's a directory, get all directories and files within it.
                if (Directory.Exists(backup.MainPath))
                {
                    String[] directoriesPaths = Directory.GetDirectories(backup.MainPath, "*", SearchOption.AllDirectories);
                    String[] filePaths = Directory.GetFiles(backup.MainPath, "*", SearchOption.AllDirectories);

                    // Create directories in backup path
                    foreach (String directoryPath in directoriesPaths)
                    {
                        String newBackupPath = directoryPath.Replace(backup.MainPath, txtBackupPath.Text);
                        Directory.CreateDirectory(newBackupPath);
                    }
                    // Copy files over to the backup path
                    foreach (String filePath in filePaths)
                    {
                        String newBackupPath = filePath.Replace(backup.MainPath, txtBackupPath.Text);

                        var fileBackup = new FileBackup {
                            originalPath = filePath, 
                            newBackupPath = newBackupPath
                        };

                        paths.Add(fileBackup);
                    }
                }
                // If it's a file, just create a copy of the file to the backup path.
                else if (File.Exists(backup.MainPath))
                {
                    var fileBackup = new FileBackup() {
                        originalPath = backup.MainPath,
                        newBackupPath = txtBackupPath.Text + "\\" + Path.GetFileName(backup.MainPath)
                   };
                    paths.Add(fileBackup);
                }
            }

            Console.WriteLine("Total files to create backups for: " + paths.Count);

            int backupCount = 0;
            foreach (FileBackup fileBackup in paths)
            {
                File.Copy(fileBackup.originalPath, fileBackup.newBackupPath, true);
                Console.WriteLine("#" + fileBackup.newBackupPath);

                backupCount++;
                double percentage = ((double)backupCount / (double)paths.Count) * 100;
                createBackupsWorker.ReportProgress((int)percentage, fileBackup);
            }
        }

        private void createBackupsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage);
            FileBackup fileBackup = (FileBackup)e.UserState;
            progressBar1.Value = e.ProgressPercentage;
            lblPercentage.Text = e.ProgressPercentage + "%";
            lblFileCreation.Text = "Creating: " + fileBackup.newBackupPath;
        }

        private void createBackupsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Completed worker");
            MessageBox.Show("Backup complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnStart.Enabled = true;
        }
    }
}
