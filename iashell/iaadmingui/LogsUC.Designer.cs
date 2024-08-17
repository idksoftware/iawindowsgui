namespace iaadmingui
{
    partial class LogsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsUC));
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlLogs = new System.Windows.Forms.TabControl();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.listViewAdmin = new System.Windows.Forms.ListView();
            this.columnHeaderAdminItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdminDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdminIdent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdminSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageVault = new System.Windows.Forms.TabPage();
            this.listViewVault = new System.Windows.Forms.ListView();
            this.columnHeaderVaultItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVaultDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVaultIdent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVaultSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlLogs.SuspendLayout();
            this.tabPageAdmin.SuspendLayout();
            this.tabPageVault.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(96, 55);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(181, 29);
            this.Titlelabel.TabIndex = 26;
            this.Titlelabel.Text = "View Log Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlLogs
            // 
            this.tabControlLogs.Controls.Add(this.tabPageAdmin);
            this.tabControlLogs.Controls.Add(this.tabPageVault);
            this.tabControlLogs.Location = new System.Drawing.Point(18, 129);
            this.tabControlLogs.Name = "tabControlLogs";
            this.tabControlLogs.SelectedIndex = 0;
            this.tabControlLogs.Size = new System.Drawing.Size(1010, 661);
            this.tabControlLogs.TabIndex = 27;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.listViewAdmin);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdmin.Size = new System.Drawing.Size(1002, 628);
            this.tabPageAdmin.TabIndex = 0;
            this.tabPageAdmin.Text = "Admin Logs";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // listViewAdmin
            // 
            this.listViewAdmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAdminItem,
            this.columnHeaderAdminDate,
            this.columnHeaderAdminIdent,
            this.columnHeaderAdminSize});
            this.listViewAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAdmin.FullRowSelect = true;
            this.listViewAdmin.HideSelection = false;
            this.listViewAdmin.Location = new System.Drawing.Point(3, 3);
            this.listViewAdmin.Name = "listViewAdmin";
            this.listViewAdmin.Size = new System.Drawing.Size(996, 622);
            this.listViewAdmin.TabIndex = 0;
            this.listViewAdmin.UseCompatibleStateImageBehavior = false;
            this.listViewAdmin.View = System.Windows.Forms.View.Details;
            this.listViewAdmin.Click += new System.EventHandler(this.listViewAdmin_Click);
            // 
            // columnHeaderAdminItem
            // 
            this.columnHeaderAdminItem.Text = "Item";
            // 
            // columnHeaderAdminDate
            // 
            this.columnHeaderAdminDate.Text = "Date";
            // 
            // columnHeaderAdminIdent
            // 
            this.columnHeaderAdminIdent.Text = "Ident";
            // 
            // columnHeaderAdminSize
            // 
            this.columnHeaderAdminSize.Text = "Size";
            // 
            // tabPageVault
            // 
            this.tabPageVault.Controls.Add(this.listViewVault);
            this.tabPageVault.Location = new System.Drawing.Point(4, 29);
            this.tabPageVault.Name = "tabPageVault";
            this.tabPageVault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVault.Size = new System.Drawing.Size(1002, 628);
            this.tabPageVault.TabIndex = 1;
            this.tabPageVault.Text = "Vault Logs";
            this.tabPageVault.UseVisualStyleBackColor = true;
            // 
            // listViewVault
            // 
            this.listViewVault.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderVaultItem,
            this.columnHeaderVaultDate,
            this.columnHeaderVaultIdent,
            this.columnHeaderVaultSize});
            this.listViewVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVault.FullRowSelect = true;
            this.listViewVault.HideSelection = false;
            this.listViewVault.Location = new System.Drawing.Point(3, 3);
            this.listViewVault.Name = "listViewVault";
            this.listViewVault.Size = new System.Drawing.Size(996, 622);
            this.listViewVault.TabIndex = 0;
            this.listViewVault.UseCompatibleStateImageBehavior = false;
            this.listViewVault.View = System.Windows.Forms.View.Details;
            this.listViewVault.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewVault.Click += new System.EventHandler(this.listViewVault_Click);
            // 
            // columnHeaderVaultItem
            // 
            this.columnHeaderVaultItem.Text = "Item";
            this.columnHeaderVaultItem.Width = 167;
            // 
            // columnHeaderVaultDate
            // 
            this.columnHeaderVaultDate.Text = "Date";
            this.columnHeaderVaultDate.Width = 192;
            // 
            // columnHeaderVaultIdent
            // 
            this.columnHeaderVaultIdent.Text = "Ident";
            this.columnHeaderVaultIdent.Width = 332;
            // 
            // columnHeaderVaultSize
            // 
            this.columnHeaderVaultSize.Text = "Size";
            // 
            // LogsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlLogs);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogsUC";
            this.Size = new System.Drawing.Size(1170, 923);
            this.Load += new System.EventHandler(this.LogsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlLogs.ResumeLayout(false);
            this.tabPageAdmin.ResumeLayout(false);
            this.tabPageVault.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlLogs;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.TabPage tabPageVault;
        private System.Windows.Forms.ListView listViewAdmin;
        private System.Windows.Forms.ListView listViewVault;
        private System.Windows.Forms.ColumnHeader columnHeaderVaultItem;
        private System.Windows.Forms.ColumnHeader columnHeaderVaultDate;
        private System.Windows.Forms.ColumnHeader columnHeaderVaultIdent;
        private System.Windows.Forms.ColumnHeader columnHeaderVaultSize;
        private System.Windows.Forms.ColumnHeader columnHeaderAdminItem;
        private System.Windows.Forms.ColumnHeader columnHeaderAdminDate;
        private System.Windows.Forms.ColumnHeader columnHeaderAdminIdent;
        private System.Windows.Forms.ColumnHeader columnHeaderAdminSize;
    }
}
