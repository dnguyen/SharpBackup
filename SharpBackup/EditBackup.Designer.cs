namespace SharpBackup
{
    partial class EditBackupForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblMainPaths = new System.Windows.Forms.Label();
            this.btnAddTarget = new System.Windows.Forms.Button();
            this.btnDeleteTarget = new System.Windows.Forms.Button();
            this.lblDestinations = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSync = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 21);
            this.textBox1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblMainPaths
            // 
            this.lblMainPaths.AutoSize = true;
            this.lblMainPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPaths.Location = new System.Drawing.Point(12, 68);
            this.lblMainPaths.Name = "lblMainPaths";
            this.lblMainPaths.Size = new System.Drawing.Size(108, 17);
            this.lblMainPaths.TabIndex = 1;
            this.lblMainPaths.Text = "Backup Targets";
            // 
            // btnAddTarget
            // 
            this.btnAddTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTarget.Location = new System.Drawing.Point(250, 88);
            this.btnAddTarget.Name = "btnAddTarget";
            this.btnAddTarget.Size = new System.Drawing.Size(28, 28);
            this.btnAddTarget.TabIndex = 3;
            this.btnAddTarget.Text = "+";
            this.btnAddTarget.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTarget
            // 
            this.btnDeleteTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTarget.Location = new System.Drawing.Point(250, 122);
            this.btnDeleteTarget.Name = "btnDeleteTarget";
            this.btnDeleteTarget.Size = new System.Drawing.Size(28, 28);
            this.btnDeleteTarget.TabIndex = 3;
            this.btnDeleteTarget.Text = "-";
            this.btnDeleteTarget.UseVisualStyleBackColor = true;
            // 
            // lblDestinations
            // 
            this.lblDestinations.AutoSize = true;
            this.lblDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinations.Location = new System.Drawing.Point(12, 202);
            this.lblDestinations.Name = "lblDestinations";
            this.lblDestinations.Size = new System.Drawing.Size(130, 17);
            this.lblDestinations.TabIndex = 1;
            this.lblDestinations.Text = "Backup Destination";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 21);
            this.textBox2.TabIndex = 0;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(250, 222);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(28, 21);
            this.btnBrowseDestination.TabIndex = 4;
            this.btnBrowseDestination.Text = "...";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(12, 259);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(57, 17);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Options";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save backup";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chkSync
            // 
            this.chkSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSync.Location = new System.Drawing.Point(15, 279);
            this.chkSync.MaximumSize = new System.Drawing.Size(260, 0);
            this.chkSync.Name = "chkSync";
            this.chkSync.Size = new System.Drawing.Size(260, 40);
            this.chkSync.TabIndex = 7;
            this.chkSync.Text = "Sync (Automatically create a backup when the file or directory is modified)";
            this.chkSync.UseVisualStyleBackColor = true;
            // 
            // EditBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 378);
            this.Controls.Add(this.chkSync);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.btnDeleteTarget);
            this.Controls.Add(this.btnAddTarget);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblDestinations);
            this.Controls.Add(this.lblMainPaths);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "EditBackupForm";
            this.Text = "Edit Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblMainPaths;
        private System.Windows.Forms.Button btnAddTarget;
        private System.Windows.Forms.Button btnDeleteTarget;
        private System.Windows.Forms.Label lblDestinations;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkSync;
    }
}