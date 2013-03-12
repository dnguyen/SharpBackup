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
            CreateOneTimeBackupForm createBackupForm = new CreateOneTimeBackupForm();
            createBackupForm.Show();
        }
    }
}
