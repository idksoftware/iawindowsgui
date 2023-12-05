namespace iaadmingui
{
    partial class VaultUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaultUC));
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMasterBrowse = new System.Windows.Forms.Button();
            this.checkBoxMasterBackup1Enabled = new System.Windows.Forms.CheckBox();
            this.checkBoxMasterBackup2Enabled = new System.Windows.Forms.CheckBox();
            this.textBoxMasterPath = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancalButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMasterBackup2 = new System.Windows.Forms.TextBox();
            this.buttonMasterPBackup2Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMasterBackup1 = new System.Windows.Forms.TextBox();
            this.buttonMasterPBackup1Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDerivativeBackup2 = new System.Windows.Forms.TextBox();
            this.buttonDerivativeBackup2Browse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDerivativeBackup1 = new System.Windows.Forms.TextBox();
            this.buttonDerivativeBackup1Browse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDerivativeLocation = new System.Windows.Forms.TextBox();
            this.buttonDerivativeBrowse = new System.Windows.Forms.Button();
            this.checkBoxDerivativeBackup1 = new System.Windows.Forms.CheckBox();
            this.checkBoxDerivativeBackup2 = new System.Windows.Forms.CheckBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(59, 29);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(138, 20);
            this.Titlelabel.TabIndex = 20;
            this.Titlelabel.Text = "Vault Properties";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMasterBrowse
            // 
            this.buttonMasterBrowse.Location = new System.Drawing.Point(644, 115);
            this.buttonMasterBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMasterBrowse.Name = "buttonMasterBrowse";
            this.buttonMasterBrowse.Size = new System.Drawing.Size(60, 21);
            this.buttonMasterBrowse.TabIndex = 67;
            this.buttonMasterBrowse.Text = "Browse";
            this.buttonMasterBrowse.UseVisualStyleBackColor = true;
            this.buttonMasterBrowse.Click += new System.EventHandler(this.buttonMasterBrowse_Click);
            // 
            // checkBoxMasterBackup1Enabled
            // 
            this.checkBoxMasterBackup1Enabled.AutoSize = true;
            this.checkBoxMasterBackup1Enabled.Location = new System.Drawing.Point(31, 278);
            this.checkBoxMasterBackup1Enabled.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMasterBackup1Enabled.Name = "checkBoxMasterBackup1Enabled";
            this.checkBoxMasterBackup1Enabled.Size = new System.Drawing.Size(114, 17);
            this.checkBoxMasterBackup1Enabled.TabIndex = 64;
            this.checkBoxMasterBackup1Enabled.Text = "Backup 1 Enabled";
            this.checkBoxMasterBackup1Enabled.UseVisualStyleBackColor = true;
            this.checkBoxMasterBackup1Enabled.CheckedChanged += new System.EventHandler(this.checkBoxMasterBackup1Enabled_CheckedChanged);
            // 
            // checkBoxMasterBackup2Enabled
            // 
            this.checkBoxMasterBackup2Enabled.AutoSize = true;
            this.checkBoxMasterBackup2Enabled.Location = new System.Drawing.Point(25, 376);
            this.checkBoxMasterBackup2Enabled.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMasterBackup2Enabled.Name = "checkBoxMasterBackup2Enabled";
            this.checkBoxMasterBackup2Enabled.Size = new System.Drawing.Size(114, 17);
            this.checkBoxMasterBackup2Enabled.TabIndex = 63;
            this.checkBoxMasterBackup2Enabled.Text = "Backup 2 Enabled";
            this.checkBoxMasterBackup2Enabled.UseVisualStyleBackColor = true;
            this.checkBoxMasterBackup2Enabled.CheckedChanged += new System.EventHandler(this.checkBoxMasterBackup2Enabled_CheckedChanged);
            // 
            // textBoxMasterPath
            // 
            this.textBoxMasterPath.Location = new System.Drawing.Point(25, 91);
            this.textBoxMasterPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMasterPath.Name = "textBoxMasterPath";
            this.textBoxMasterPath.ReadOnly = true;
            this.textBoxMasterPath.Size = new System.Drawing.Size(679, 20);
            this.textBoxMasterPath.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 64);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Master Vault path:";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(670, 547);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 22;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancalButton
            // 
            this.CancalButton.Location = new System.Drawing.Point(579, 547);
            this.CancalButton.Name = "CancalButton";
            this.CancalButton.Size = new System.Drawing.Size(75, 23);
            this.CancalButton.TabIndex = 23;
            this.CancalButton.Text = "Cancal";
            this.CancalButton.UseVisualStyleBackColor = true;
            this.CancalButton.Click += new System.EventHandler(this.CancalButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 446);
            this.tabControl1.TabIndex = 69;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxMasterBackup2);
            this.tabPage1.Controls.Add(this.buttonMasterPBackup2Browse);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxMasterBackup1);
            this.tabPage1.Controls.Add(this.buttonMasterPBackup1Browse);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.textBoxMasterPath);
            this.tabPage1.Controls.Add(this.buttonMasterBrowse);
            this.tabPage1.Controls.Add(this.checkBoxMasterBackup1Enabled);
            this.tabPage1.Controls.Add(this.checkBoxMasterBackup2Enabled);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Master Repository";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "This sets the propertiest for the master repository backups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Backup 2  path:";
            // 
            // textBoxMasterBackup2
            // 
            this.textBoxMasterBackup2.Location = new System.Drawing.Point(25, 349);
            this.textBoxMasterBackup2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMasterBackup2.Name = "textBoxMasterBackup2";
            this.textBoxMasterBackup2.ReadOnly = true;
            this.textBoxMasterBackup2.Size = new System.Drawing.Size(685, 20);
            this.textBoxMasterBackup2.TabIndex = 72;
            // 
            // buttonMasterPBackup2Browse
            // 
            this.buttonMasterPBackup2Browse.Location = new System.Drawing.Point(650, 373);
            this.buttonMasterPBackup2Browse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMasterPBackup2Browse.Name = "buttonMasterPBackup2Browse";
            this.buttonMasterPBackup2Browse.Size = new System.Drawing.Size(60, 21);
            this.buttonMasterPBackup2Browse.TabIndex = 73;
            this.buttonMasterPBackup2Browse.Text = "Browse";
            this.buttonMasterPBackup2Browse.UseVisualStyleBackColor = true;
            this.buttonMasterPBackup2Browse.Click += new System.EventHandler(this.buttonBackup2Browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Backup 1  path:";
            // 
            // textBoxMasterBackup1
            // 
            this.textBoxMasterBackup1.Location = new System.Drawing.Point(25, 250);
            this.textBoxMasterBackup1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMasterBackup1.Name = "textBoxMasterBackup1";
            this.textBoxMasterBackup1.ReadOnly = true;
            this.textBoxMasterBackup1.Size = new System.Drawing.Size(685, 20);
            this.textBoxMasterBackup1.TabIndex = 69;
            // 
            // buttonMasterPBackup1Browse
            // 
            this.buttonMasterPBackup1Browse.Location = new System.Drawing.Point(650, 274);
            this.buttonMasterPBackup1Browse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMasterPBackup1Browse.Name = "buttonMasterPBackup1Browse";
            this.buttonMasterPBackup1Browse.Size = new System.Drawing.Size(60, 21);
            this.buttonMasterPBackup1Browse.TabIndex = 70;
            this.buttonMasterPBackup1Browse.Text = "Browse";
            this.buttonMasterPBackup1Browse.UseVisualStyleBackColor = true;
            this.buttonMasterPBackup1Browse.Click += new System.EventHandler(this.buttonBackup1Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "This sets the propertiest for the master repository";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxDerivativeBackup2);
            this.tabPage2.Controls.Add(this.buttonDerivativeBackup2Browse);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxDerivativeBackup1);
            this.tabPage2.Controls.Add(this.buttonDerivativeBackup1Browse);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxDerivativeLocation);
            this.tabPage2.Controls.Add(this.buttonDerivativeBrowse);
            this.tabPage2.Controls.Add(this.checkBoxDerivativeBackup1);
            this.tabPage2.Controls.Add(this.checkBoxDerivativeBackup2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Derivative Repository";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "This sets the propertiest for the derivative repository backups";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Backup 2  path:";
            // 
            // textBoxDerivativeBackup2
            // 
            this.textBoxDerivativeBackup2.Location = new System.Drawing.Point(29, 348);
            this.textBoxDerivativeBackup2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDerivativeBackup2.Name = "textBoxDerivativeBackup2";
            this.textBoxDerivativeBackup2.ReadOnly = true;
            this.textBoxDerivativeBackup2.Size = new System.Drawing.Size(685, 20);
            this.textBoxDerivativeBackup2.TabIndex = 85;
            // 
            // buttonDerivativeBackup2Browse
            // 
            this.buttonDerivativeBackup2Browse.Location = new System.Drawing.Point(654, 372);
            this.buttonDerivativeBackup2Browse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDerivativeBackup2Browse.Name = "buttonDerivativeBackup2Browse";
            this.buttonDerivativeBackup2Browse.Size = new System.Drawing.Size(60, 21);
            this.buttonDerivativeBackup2Browse.TabIndex = 86;
            this.buttonDerivativeBackup2Browse.Text = "Browse";
            this.buttonDerivativeBackup2Browse.UseVisualStyleBackColor = true;
            this.buttonDerivativeBackup2Browse.Click += new System.EventHandler(this.buttonDerivativeBackup2Browse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Backup 1  path:";
            // 
            // textBoxDerivativeBackup1
            // 
            this.textBoxDerivativeBackup1.Location = new System.Drawing.Point(29, 249);
            this.textBoxDerivativeBackup1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDerivativeBackup1.Name = "textBoxDerivativeBackup1";
            this.textBoxDerivativeBackup1.ReadOnly = true;
            this.textBoxDerivativeBackup1.Size = new System.Drawing.Size(685, 20);
            this.textBoxDerivativeBackup1.TabIndex = 82;
            // 
            // buttonDerivativeBackup1Browse
            // 
            this.buttonDerivativeBackup1Browse.Location = new System.Drawing.Point(654, 273);
            this.buttonDerivativeBackup1Browse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDerivativeBackup1Browse.Name = "buttonDerivativeBackup1Browse";
            this.buttonDerivativeBackup1Browse.Size = new System.Drawing.Size(60, 21);
            this.buttonDerivativeBackup1Browse.TabIndex = 83;
            this.buttonDerivativeBackup1Browse.Text = "Browse";
            this.buttonDerivativeBackup1Browse.UseVisualStyleBackColor = true;
            this.buttonDerivativeBackup1Browse.Click += new System.EventHandler(this.buttonDerivativeBackup1Browse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "This sets the propertiest for the derivative  repository";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Derivative  Vault path:";
            // 
            // textBoxDerivativeLocation
            // 
            this.textBoxDerivativeLocation.Location = new System.Drawing.Point(29, 90);
            this.textBoxDerivativeLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDerivativeLocation.Name = "textBoxDerivativeLocation";
            this.textBoxDerivativeLocation.ReadOnly = true;
            this.textBoxDerivativeLocation.Size = new System.Drawing.Size(679, 20);
            this.textBoxDerivativeLocation.TabIndex = 77;
            // 
            // buttonDerivativeBrowse
            // 
            this.buttonDerivativeBrowse.Location = new System.Drawing.Point(648, 114);
            this.buttonDerivativeBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDerivativeBrowse.Name = "buttonDerivativeBrowse";
            this.buttonDerivativeBrowse.Size = new System.Drawing.Size(60, 21);
            this.buttonDerivativeBrowse.TabIndex = 80;
            this.buttonDerivativeBrowse.Text = "Browse";
            this.buttonDerivativeBrowse.UseVisualStyleBackColor = true;
            this.buttonDerivativeBrowse.Click += new System.EventHandler(this.buttonDerivativeBrowse_Click);
            // 
            // checkBoxDerivativeBackup1
            // 
            this.checkBoxDerivativeBackup1.AutoSize = true;
            this.checkBoxDerivativeBackup1.Location = new System.Drawing.Point(35, 277);
            this.checkBoxDerivativeBackup1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDerivativeBackup1.Name = "checkBoxDerivativeBackup1";
            this.checkBoxDerivativeBackup1.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDerivativeBackup1.TabIndex = 79;
            this.checkBoxDerivativeBackup1.Text = "Backup 1 Enabled";
            this.checkBoxDerivativeBackup1.UseVisualStyleBackColor = true;
            // 
            // checkBoxDerivativeBackup2
            // 
            this.checkBoxDerivativeBackup2.AutoSize = true;
            this.checkBoxDerivativeBackup2.Location = new System.Drawing.Point(29, 375);
            this.checkBoxDerivativeBackup2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDerivativeBackup2.Name = "checkBoxDerivativeBackup2";
            this.checkBoxDerivativeBackup2.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDerivativeBackup2.TabIndex = 78;
            this.checkBoxDerivativeBackup2.Text = "Backup 2 Enabled";
            this.checkBoxDerivativeBackup2.UseVisualStyleBackColor = true;
            // 
            // VaultUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CancalButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VaultUC";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.VaultUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMasterBrowse;
        private System.Windows.Forms.CheckBox checkBoxMasterBackup1Enabled;
        private System.Windows.Forms.CheckBox checkBoxMasterBackup2Enabled;
        private System.Windows.Forms.TextBox textBoxMasterPath;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancalButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMasterBackup2;
        private System.Windows.Forms.Button buttonMasterPBackup2Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMasterBackup1;
        private System.Windows.Forms.Button buttonMasterPBackup1Browse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDerivativeBackup2;
        private System.Windows.Forms.Button buttonDerivativeBackup2Browse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDerivativeBackup1;
        private System.Windows.Forms.Button buttonDerivativeBackup1Browse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDerivativeLocation;
        private System.Windows.Forms.Button buttonDerivativeBrowse;
        private System.Windows.Forms.CheckBox checkBoxDerivativeBackup1;
        private System.Windows.Forms.CheckBox checkBoxDerivativeBackup2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}
