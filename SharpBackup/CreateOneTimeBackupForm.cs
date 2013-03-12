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
    public partial class CreateOneTimeBackupForm : Form
    {
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
                    oneTimeBackupFoldersListView.Items.Add(filePath);
                }
            }
        }
    }
}
