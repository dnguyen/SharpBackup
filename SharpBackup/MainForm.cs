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
                backup.SetFilePaths();
                backup.CopyFilesToBackupPath();

                Console.WriteLine(backup.MainPath);

                var watcher = new FileSystemWatcher(backup.MainPath);
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;

                // Lambda expression to pass the backup to the watcher events.
                watcher.Created += (s, e) => watcherCreated(watcher, e, backup);
                watcher.Changed += (s, e) => watcherChanged(watcher, e, backup);
                watcher.Deleted += (s, e) => watcherDeleted(watcher, e, backup);
            }
        }

        private void watcherCreated(object sender, FileSystemEventArgs e, Backup backup)
        {
            String fullBackupPath = e.FullPath.Replace(backup.MainPath, backup.BackupPath);
            if (File.Exists(e.FullPath))
            {
                Console.WriteLine("created file" + e.FullPath);
                File.Copy(e.FullPath, fullBackupPath, true);
            }
            else if (Directory.Exists(e.FullPath))
            {
                Console.WriteLine("create directory: " + e.FullPath);
                Directory.CreateDirectory(fullBackupPath);
            }
        }

        private void watcherChanged(object sender, FileSystemEventArgs e, Backup backup)
        {
            var watcher = (FileSystemWatcher) sender;

            // Work-around for the bug/feature in FileSystemWatcher that will fire the event multiple times.
            try
            {
                String fullBackupPath = e.FullPath.Replace(backup.MainPath, backup.BackupPath);
                watcher.EnableRaisingEvents = false;
                if (File.Exists(e.FullPath))
                {
                    Console.WriteLine("changed file: " + e.FullPath);
                    File.Copy(e.FullPath, fullBackupPath, true);
                }
                else if (Directory.Exists(e.FullPath))
                {
                    Console.WriteLine("directory changed: " + e.FullPath);
                }
            }
            finally
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        private void watcherDeleted(FileSystemWatcher watcher, FileSystemEventArgs e, Backup backup)
        {
            String fullBackupPath = e.FullPath.Replace(backup.MainPath, backup.BackupPath);
            if (File.Exists(e.FullPath))
            {
                Console.WriteLine("deleted file: " + e.FullPath);
                File.Delete(fullBackupPath);
            }
            else if (Directory.Exists(e.FullPath))
            {
                Console.WriteLine("delete directory: " + e.FullPath);
                Directory.CreateDirectory(fullBackupPath);
            }
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }
    }
}
