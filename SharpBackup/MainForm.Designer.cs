namespace SharpBackup
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.syncedBackupsListView = new System.Windows.Forms.ListView();
            this.lblBackups = new System.Windows.Forms.Label();
            this.btnAddSync = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOneTimeBackup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateOneTimeBackup = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // syncedBackupsListView
            // 
            this.syncedBackupsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.syncedBackupsListView.FullRowSelect = true;
            this.syncedBackupsListView.GridLines = true;
            this.syncedBackupsListView.Location = new System.Drawing.Point(12, 31);
            this.syncedBackupsListView.MultiSelect = false;
            this.syncedBackupsListView.Name = "syncedBackupsListView";
            this.syncedBackupsListView.ShowGroups = false;
            this.syncedBackupsListView.Size = new System.Drawing.Size(259, 170);
            this.syncedBackupsListView.TabIndex = 0;
            this.syncedBackupsListView.UseCompatibleStateImageBehavior = false;
            this.syncedBackupsListView.View = System.Windows.Forms.View.Details;
            // 
            // lblBackups
            // 
            this.lblBackups.AutoSize = true;
            this.lblBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackups.Location = new System.Drawing.Point(8, 4);
            this.lblBackups.Name = "lblBackups";
            this.lblBackups.Size = new System.Drawing.Size(128, 20);
            this.lblBackups.TabIndex = 1;
            this.lblBackups.Text = "Synced Backups";
            // 
            // btnAddSync
            // 
            this.btnAddSync.Location = new System.Drawing.Point(277, 31);
            this.btnAddSync.Name = "btnAddSync";
            this.btnAddSync.Size = new System.Drawing.Size(107, 23);
            this.btnAddSync.TabIndex = 2;
            this.btnAddSync.Text = "Add";
            this.btnAddSync.UseVisualStyleBackColor = true;
            this.btnAddSync.Click += new System.EventHandler(this.btnAddSync_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(277, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.syncedBackupsListView);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblBackups);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAddSync);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 213);
            this.panel1.TabIndex = 3;
            // 
            // lblOneTimeBackup
            // 
            this.lblOneTimeBackup.AutoSize = true;
            this.lblOneTimeBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneTimeBackup.Location = new System.Drawing.Point(8, 9);
            this.lblOneTimeBackup.Name = "lblOneTimeBackup";
            this.lblOneTimeBackup.Size = new System.Drawing.Size(132, 20);
            this.lblOneTimeBackup.TabIndex = 1;
            this.lblOneTimeBackup.Text = "One-time Backup";
            this.lblOneTimeBackup.Click += new System.EventHandler(this.lblOneTimeBackup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateOneTimeBackup);
            this.panel2.Controls.Add(this.lblOneTimeBackup);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 64);
            this.panel2.TabIndex = 4;
            // 
            // btnCreateOneTimeBackup
            // 
            this.btnCreateOneTimeBackup.Location = new System.Drawing.Point(12, 32);
            this.btnCreateOneTimeBackup.Name = "btnCreateOneTimeBackup";
            this.btnCreateOneTimeBackup.Size = new System.Drawing.Size(124, 23);
            this.btnCreateOneTimeBackup.TabIndex = 5;
            this.btnCreateOneTimeBackup.Text = "Create";
            this.btnCreateOneTimeBackup.UseVisualStyleBackColor = true;
            this.btnCreateOneTimeBackup.Click += new System.EventHandler(this.btnCreateOneTimeBackup_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 255;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Test notification";
            this.notifyIcon1.BalloonTipTitle = "test title";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SharpBackup";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpBackup";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView syncedBackupsListView;
        private System.Windows.Forms.Label lblBackups;
        private System.Windows.Forms.Button btnAddSync;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOneTimeBackup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateOneTimeBackup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

