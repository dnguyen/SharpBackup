using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpBackup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
