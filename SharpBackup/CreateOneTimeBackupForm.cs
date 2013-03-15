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

            foreach (Backup backup in backups)
            {
                // Check if the path is a directory or file.
                // If it's a directory, get all directories and files within it.
                if (Directory.Exists(backup.MainPath))
                {
                    Console.WriteLine(backup.MainPath);
                    Console.WriteLine("backup mainpath is a directory");

                    String[] directoriesPaths = Directory.GetDirectories(backup.MainPath, "*", SearchOption.AllDirectories);
                    String[] filePaths = Directory.GetFiles(backup.MainPath, "*", SearchOption.AllDirectories);

                    // Create directories in backup path
                    foreach (String directoryPath in directoriesPaths)
                    {
                        String newBackupPath = directoryPath.Replace(backup.MainPath, txtBackupPath.Text);
                        Directory.CreateDirectory(newBackupPath);
                        Console.WriteLine(newBackupPath);
                    }

                    // Copy files over to the backup path
                    foreach (String filePath in filePaths)
                    {
                        String newBackupPath = filePath.Replace(backup.MainPath, txtBackupPath.Text);
                        File.Copy(filePath, newBackupPath);
                        Console.WriteLine(filePath);
                    }
                
                }
                // If it's a file, just create a copy of the file to the backup path.
                else if (File.Exists(backup.MainPath)) 
                {
                    File.Copy(backup.MainPath, txtBackupPath.Text + "\\" + Path.GetFileName(backup.MainPath));
                }
            }

        }

        private void processTargets(Backup backup)
        {
        }
    }
}
