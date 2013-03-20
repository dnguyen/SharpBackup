using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SharpBackup
{
    public partial class CreateOneTimeBackupForm : Form
    {
        List<Backup> backups = new List<Backup>();

        int totalBackupCount = 0;
        private int backupCount = 0;

        public CreateOneTimeBackupForm()
        {
            InitializeComponent();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (addFolderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                if (addFolderBrowser.SelectedPath == "") return;

                var backup = new Backup("", addFolderBrowser.SelectedPath, txtBackupPath.Text, true);
                backup.OnFileCopied += FileCopied;
                backups.Add(backup);

                oneTimeBackupFoldersListView.Items.Add(addFolderBrowser.SelectedPath);
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                String filePath = addFileDialog.InitialDirectory + addFileDialog.FileName;

                if (filePath == "") return;

                var backup = new Backup("", filePath, txtBackupPath.Text, false);
                backup.OnFileCopied += FileCopied;
                backups.Add(backup);

                oneTimeBackupFoldersListView.Items.Add(filePath);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (oneTimeBackupFoldersListView.SelectedItems.Count > 0)
            {
                backups.RemoveAt(oneTimeBackupFoldersListView.SelectedIndices[0]);
                oneTimeBackupFoldersListView.Items.RemoveAt(oneTimeBackupFoldersListView.SelectedIndices[0]);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (addBackupDestDialog.ShowDialog(this) == DialogResult.OK)
            {
                txtBackupPath.Text = addBackupDestDialog.SelectedPath;
                btnAddFolder.Enabled = true;
                btnAddFile.Enabled = true;
                btnRemove.Enabled = true;
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

        private void FileCopied(FileBackup fileBackup)
        {
            backupCount++;
            double percentage = ((double)backupCount / (double)totalBackupCount) * 100;
            createBackupsWorker.ReportProgress((int)percentage, fileBackup);
        }

        private void createBackupsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Add all files from backup targets to a list to calculate progress percentage for progress bar.
            foreach (Backup backup in backups)
            {
                backup.SetFilePaths();
                totalBackupCount += backup.FileCount;
            }

            Console.WriteLine("Total files to create backups for: " + backupCount);

            foreach (Backup backup in backups)
            {
                backup.CopyFilesToBackupPath();
            }
        }

        private void createBackupsWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Progress: " + e.ProgressPercentage);
            FileBackup fileBackup = (FileBackup)e.UserState;
            progressBar1.Value = e.ProgressPercentage;
            lblPercentage.Text = e.ProgressPercentage + "%";
            lblFileCreation.Text = "Creating: " + fileBackup.NewBackupPath;
        }

        private void createBackupsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Completed worker");
            MessageBox.Show("Backup complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnStart.Enabled = true;
            lblPercentage.Text = "Backup complete!";
            backupCount = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
