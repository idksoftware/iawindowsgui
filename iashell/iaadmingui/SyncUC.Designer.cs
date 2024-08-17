namespace iaadmingui
{
    partial class SyncUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncUC));
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlSync = new System.Windows.Forms.TabControl();
            this.tabPageRepository = new System.Windows.Forms.TabPage();
            this.checkBoxBothBackups = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupTwo = new System.Windows.Forms.CheckBox();
            this.checkBoxBackupOne = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxBothRepositories = new System.Windows.Forms.CheckBox();
            this.checkBoxDerivative = new System.Windows.Forms.CheckBox();
            this.checkBoxMaster = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUserspace = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlSync.SuspendLayout();
            this.tabPageRepository.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(88, 45);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(162, 29);
            this.Titlelabel.TabIndex = 24;
            this.Titlelabel.Text = "Sync Archive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlSync
            // 
            this.tabControlSync.Controls.Add(this.tabPageRepository);
            this.tabControlSync.Controls.Add(this.tabPageUserspace);
            this.tabControlSync.Location = new System.Drawing.Point(18, 129);
            this.tabControlSync.Name = "tabControlSync";
            this.tabControlSync.SelectedIndex = 0;
            this.tabControlSync.Size = new System.Drawing.Size(1110, 646);
            this.tabControlSync.TabIndex = 25;
            // 
            // tabPageRepository
            // 
            this.tabPageRepository.Controls.Add(this.checkBoxBothBackups);
            this.tabPageRepository.Controls.Add(this.checkBoxBackupTwo);
            this.tabPageRepository.Controls.Add(this.checkBoxBackupOne);
            this.tabPageRepository.Controls.Add(this.label2);
            this.tabPageRepository.Controls.Add(this.checkBoxBothRepositories);
            this.tabPageRepository.Controls.Add(this.checkBoxDerivative);
            this.tabPageRepository.Controls.Add(this.checkBoxMaster);
            this.tabPageRepository.Controls.Add(this.label1);
            this.tabPageRepository.Location = new System.Drawing.Point(4, 29);
            this.tabPageRepository.Name = "tabPageRepository";
            this.tabPageRepository.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRepository.Size = new System.Drawing.Size(1102, 613);
            this.tabPageRepository.TabIndex = 0;
            this.tabPageRepository.Text = "Repository";
            this.tabPageRepository.UseVisualStyleBackColor = true;
            // 
            // checkBoxBothBackups
            // 
            this.checkBoxBothBackups.AutoSize = true;
            this.checkBoxBothBackups.Location = new System.Drawing.Point(777, 360);
            this.checkBoxBothBackups.Name = "checkBoxBothBackups";
            this.checkBoxBothBackups.Size = new System.Drawing.Size(133, 24);
            this.checkBoxBothBackups.TabIndex = 7;
            this.checkBoxBothBackups.Text = "Both backups";
            this.checkBoxBothBackups.UseVisualStyleBackColor = true;
            this.checkBoxBothBackups.CheckedChanged += new System.EventHandler(this.checkBoxBothBackups_CheckedChanged);
            // 
            // checkBoxBackupTwo
            // 
            this.checkBoxBackupTwo.AutoSize = true;
            this.checkBoxBackupTwo.Location = new System.Drawing.Point(468, 360);
            this.checkBoxBackupTwo.Name = "checkBoxBackupTwo";
            this.checkBoxBackupTwo.Size = new System.Drawing.Size(122, 24);
            this.checkBoxBackupTwo.TabIndex = 6;
            this.checkBoxBackupTwo.Text = "Backup Two";
            this.checkBoxBackupTwo.UseVisualStyleBackColor = true;
            this.checkBoxBackupTwo.CheckedChanged += new System.EventHandler(this.checkBoxBackupTwo_CheckedChanged);
            // 
            // checkBoxBackupOne
            // 
            this.checkBoxBackupOne.AutoSize = true;
            this.checkBoxBackupOne.Location = new System.Drawing.Point(155, 360);
            this.checkBoxBackupOne.Name = "checkBoxBackupOne";
            this.checkBoxBackupOne.Size = new System.Drawing.Size(123, 24);
            this.checkBoxBackupOne.TabIndex = 5;
            this.checkBoxBackupOne.Text = "Backup One";
            this.checkBoxBackupOne.UseVisualStyleBackColor = true;
            this.checkBoxBackupOne.CheckedChanged += new System.EventHandler(this.checkBoxBackupOne_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination backup";
            // 
            // checkBoxBothRepositories
            // 
            this.checkBoxBothRepositories.AutoSize = true;
            this.checkBoxBothRepositories.Location = new System.Drawing.Point(771, 158);
            this.checkBoxBothRepositories.Name = "checkBoxBothRepositories";
            this.checkBoxBothRepositories.Size = new System.Drawing.Size(155, 24);
            this.checkBoxBothRepositories.TabIndex = 3;
            this.checkBoxBothRepositories.Text = "Both repositories";
            this.checkBoxBothRepositories.UseVisualStyleBackColor = true;
            this.checkBoxBothRepositories.CheckedChanged += new System.EventHandler(this.checkBoxBothRepositories_CheckedChanged);
            // 
            // checkBoxDerivative
            // 
            this.checkBoxDerivative.AutoSize = true;
            this.checkBoxDerivative.Location = new System.Drawing.Point(462, 158);
            this.checkBoxDerivative.Name = "checkBoxDerivative";
            this.checkBoxDerivative.Size = new System.Drawing.Size(108, 24);
            this.checkBoxDerivative.TabIndex = 2;
            this.checkBoxDerivative.Text = "Derivative ";
            this.checkBoxDerivative.UseVisualStyleBackColor = true;
            this.checkBoxDerivative.CheckedChanged += new System.EventHandler(this.checkBoxDerivative_CheckedChanged);
            // 
            // checkBoxMaster
            // 
            this.checkBoxMaster.AutoSize = true;
            this.checkBoxMaster.Location = new System.Drawing.Point(149, 158);
            this.checkBoxMaster.Name = "checkBoxMaster";
            this.checkBoxMaster.Size = new System.Drawing.Size(84, 24);
            this.checkBoxMaster.TabIndex = 1;
            this.checkBoxMaster.Text = "Master";
            this.checkBoxMaster.UseVisualStyleBackColor = true;
            this.checkBoxMaster.CheckedChanged += new System.EventHandler(this.checkBoxMaster_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Repository";
            // 
            // tabPageUserspace
            // 
            this.tabPageUserspace.Location = new System.Drawing.Point(4, 29);
            this.tabPageUserspace.Name = "tabPageUserspace";
            this.tabPageUserspace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserspace.Size = new System.Drawing.Size(1102, 613);
            this.tabPageUserspace.TabIndex = 1;
            this.tabPageUserspace.Text = "Userspace";
            this.tabPageUserspace.UseVisualStyleBackColor = true;
            // 
            // SyncUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlSync);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SyncUC";
            this.Size = new System.Drawing.Size(1170, 923);
            this.Load += new System.EventHandler(this.SyncUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlSync.ResumeLayout(false);
            this.tabPageRepository.ResumeLayout(false);
            this.tabPageRepository.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlSync;
        private System.Windows.Forms.TabPage tabPageRepository;
        private System.Windows.Forms.TabPage tabPageUserspace;
        private System.Windows.Forms.CheckBox checkBoxBothRepositories;
        private System.Windows.Forms.CheckBox checkBoxDerivative;
        private System.Windows.Forms.CheckBox checkBoxMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBothBackups;
        private System.Windows.Forms.CheckBox checkBoxBackupTwo;
        private System.Windows.Forms.CheckBox checkBoxBackupOne;
        private System.Windows.Forms.Label label2;
    }
}
