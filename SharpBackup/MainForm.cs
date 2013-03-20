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
using Newtonsoft.Json.Linq;

namespace SharpBackup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // TODO: Remove from form class
            string settingsJson = System.IO.File.ReadAllText("settings.js");
            JObject settingsObject = JObject.Parse(settingsJson);

            JArray backupsJArray = (JArray) settingsObject["backups"];
            foreach (JToken backupJson in backupsJArray)
            {
                var backup = new Backup(backupJson["name"].ToString(), backupJson["mainPath"].ToString(), backupJson["backupPath"].ToString());
                Console.WriteLine(backup.MainPath);

                var watcher = new FileSystemWatcher(backup.MainPath);
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;
                // Wizardry to pass the backup to the fileCreated event.
                watcher.Created += (s, e) => fileCreated(watcher, e, backup);
            }
        }

        private void fileCreated(object sender, FileSystemEventArgs e, Backup backup)
        {
            Console.WriteLine("created " + e.FullPath);
            String newBackupPath = e.FullPath.Replace(backup.MainPath, backup.BackupPath);
            Console.WriteLine("Write backup to " + newBackupPath);
        }

        private void lblOneTimeBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateOneTimeBackup_Click(object sender, EventArgs e)
        {
            var createBackupForm = new CreateOneTimeBackupForm();
            createBackupForm.Show();
        }

        private void btnAddSync_Click(object sender, EventArgs e)
        {
            var addSyncedBackupForm = new AddSyncedBackupForm();
            addSyncedBackupForm.AddSyncedBackupEvent += AddSyncedBackup;
            addSyncedBackupForm.Show();
        }

        private void AddSyncedBackup(List<Backup> backups, EventArgs e)
        {
            Console.WriteLine("Synced backup added");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
