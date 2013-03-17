namespace SharpBackup
{
    partial class CreateOneTimeBackupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneTimeBackupFoldersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lblBackups = new System.Windows.Forms.Label();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.addFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.addFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.addBackupDestDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.createBackupsWorker = new System.ComponentModel.BackgroundWorker();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblFileCreation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneTimeBackupFoldersListView
            // 
            this.oneTimeBackupFoldersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.oneTimeBackupFoldersListView.FullRowSelect = true;
            this.oneTimeBackupFoldersListView.GridLines = true;
            this.oneTimeBackupFoldersListView.Location = new System.Drawing.Point(12, 85);
            this.oneTimeBackupFoldersListView.MultiSelect = false;
            this.oneTimeBackupFoldersListView.Name = "oneTimeBackupFoldersListView";
            this.oneTimeBackupFoldersListView.Size = new System.Drawing.Size(340, 140);
            this.oneTimeBackupFoldersListView.TabIndex = 0;
            this.oneTimeBackupFoldersListView.UseCompatibleStateImageBehavior = false;
            this.oneTimeBackupFoldersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 340;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Enabled = false;
            this.btnAddFolder.Location = new System.Drawing.Point(358, 85);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblBackups
            // 
            this.lblBackups.AutoSize = true;
            this.lblBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackups.Location = new System.Drawing.Point(12, 65);
            this.lblBackups.Name = "lblBackups";
            this.lblBackups.Size = new System.Drawing.Size(62, 17);
            this.lblBackups.TabIndex = 2;
            this.lblBackups.Text = "Backups";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Location = new System.Drawing.Point(358, 114);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(358, 143);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 244);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(277, 273);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // addFileDialog
            // 
            this.addFileDialog.FileName = "openFileDialog1";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupPath.Location = new System.Drawing.Point(12, 41);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(340, 21);
            this.txtBackupPath.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(358, 41);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 21);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupPath.Location = new System.Drawing.Point(12, 21);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(130, 17);
            this.lblBackupPath.TabIndex = 2;
            this.lblBackupPath.Text = "Backup Destination";
            // 
            // createBackupsWorker
            // 
            this.createBackupsWorker.WorkerReportsProgress = true;
            this.createBackupsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.createBackupsWorker_DoWork);
            this.createBackupsWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.createBackupsWorker_ProgressChanged);
            this.createBackupsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.createBackupsWorker_RunWorkerCompleted);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(399, 249);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(21, 13);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "0%";
            // 
            // lblFileCreation
            // 
            this.lblFileCreation.AutoSize = true;
            this.lblFileCreation.Location = new System.Drawing.Point(12, 228);
            this.lblFileCreation.Name = "lblFileCreation";
            this.lblFileCreation.Size = new System.Drawing.Size(0, 13);
            this.lblFileCreation.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(358, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateOneTimeBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 304);
            this.Controls.Add(this.lblFileCreation);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblBackupPath);
            this.Controls.Add(this.lblBackups);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.oneTimeBackupFoldersListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CreateOneTimeBackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create One-time Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView oneTimeBackupFoldersListView;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Label lblBackups;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog addFolderBrowser;
        private System.Windows.Forms.OpenFileDialog addFileDialog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.FolderBrowserDialog addBackupDestDialog;
        private System.ComponentModel.BackgroundWorker createBackupsWorker;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblFileCreation;
        private System.Windows.Forms.Button btnCancel;
    }
}