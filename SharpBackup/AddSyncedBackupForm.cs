using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SharpBackup
{
    public delegate void AddSyncedBackupHandler(List<Backup> backups_, EventArgs e);

    public partial class AddSyncedBackupForm : Form
    {
        public event AddSyncedBackupHandler AddSyncedBackupEvent;

        private List<Backup> backups = new List<Backup>();

        public AddSyncedBackupForm()
        {
            InitializeComponent();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (addFolderDialog.ShowDialog() == DialogResult.OK)
            {
                if (addFolderDialog.SelectedPath == "") return;

                var backup = new Backup(txtName.Text, addFolderDialog.SelectedPath, txtBackupPath.Text);
                backups.Add(backup);
                listView1.Items.Add(addFolderDialog.SelectedPath);
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (addFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = addFileDialog.InitialDirectory + addFileDialog.FileName;

                if (filePath == "") return;

                var backup = new Backup(txtName.Text, filePath, txtBackupPath.Text);
                backups.Add(backup);
                listView1.Items.Add(filePath);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                backups.RemoveAt(listView1.SelectedIndices[0]);
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (backupFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = backupFolderDialog.SelectedPath;
                btnAddFolder.Enabled = true;
                btnAddFile.Enabled = true;
                btnRemove.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Invalid backup name.", "Add backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBackupPath.Text == "")
            {
                MessageBox.Show("Invalid backup path.", "Add backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listView1.Items.Count <= 0)
            {
                MessageBox.Show("No backups chosen.", "Add backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Create initial backup files/directories.
            foreach (Backup backup in backups)
            {
                backup.SetFilePaths();
                backup.CopyFilesToBackupPath();
            }

            if (AddSyncedBackupEvent != null)
                AddSyncedBackupEvent(backups, EventArgs.Empty);
        }
    }
}
