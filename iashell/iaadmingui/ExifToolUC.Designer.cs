namespace iaadmingui
{
    partial class ExifToolUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExifToolUC));
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWebPicturesLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPicturesLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExifMapPath = new System.Windows.Forms.TextBox();
            this.checkBoxWorkspaceEnabled = new System.Windows.Forms.CheckBox();
            this.buttonMasterPBackup2Browse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExifMapFilename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(93, 42);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(241, 29);
            this.Titlelabel.TabIndex = 24;
            this.Titlelabel.Text = "EXIF Tool  Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxExifMapFilename);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.buttonMasterPBackup2Browse);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxWebPicturesLocation);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBoxPicturesLocation);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBoxExifMapPath);
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceEnabled);
            this.groupBox5.Location = new System.Drawing.Point(30, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1110, 646);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EXIF Tool Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Exif Command Line:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWebPicturesLocation
            // 
            this.textBoxWebPicturesLocation.Location = new System.Drawing.Point(207, 534);
            this.textBoxWebPicturesLocation.Name = "textBoxWebPicturesLocation";
            this.textBoxWebPicturesLocation.ReadOnly = true;
            this.textBoxWebPicturesLocation.Size = new System.Drawing.Size(872, 26);
            this.textBoxWebPicturesLocation.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Exif Tool location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPicturesLocation
            // 
            this.textBoxPicturesLocation.Location = new System.Drawing.Point(207, 309);
            this.textBoxPicturesLocation.Name = "textBoxPicturesLocation";
            this.textBoxPicturesLocation.ReadOnly = true;
            this.textBoxPicturesLocation.Size = new System.Drawing.Size(872, 26);
            this.textBoxPicturesLocation.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Exif Map location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExifMapPath
            // 
            this.textBoxExifMapPath.Location = new System.Drawing.Point(207, 151);
            this.textBoxExifMapPath.Name = "textBoxExifMapPath";
            this.textBoxExifMapPath.ReadOnly = true;
            this.textBoxExifMapPath.Size = new System.Drawing.Size(872, 26);
            this.textBoxExifMapPath.TabIndex = 69;
            // 
            // checkBoxWorkspaceEnabled
            // 
            this.checkBoxWorkspaceEnabled.AutoSize = true;
            this.checkBoxWorkspaceEnabled.Location = new System.Drawing.Point(50, 60);
            this.checkBoxWorkspaceEnabled.Name = "checkBoxWorkspaceEnabled";
            this.checkBoxWorkspaceEnabled.Size = new System.Drawing.Size(169, 24);
            this.checkBoxWorkspaceEnabled.TabIndex = 52;
            this.checkBoxWorkspaceEnabled.Text = "EXIF Tool Enabled";
            this.checkBoxWorkspaceEnabled.UseVisualStyleBackColor = true;
            // 
            // buttonMasterPBackup2Browse
            // 
            this.buttonMasterPBackup2Browse.Location = new System.Drawing.Point(989, 190);
            this.buttonMasterPBackup2Browse.Name = "buttonMasterPBackup2Browse";
            this.buttonMasterPBackup2Browse.Size = new System.Drawing.Size(90, 32);
            this.buttonMasterPBackup2Browse.TabIndex = 77;
            this.buttonMasterPBackup2Browse.Text = "Browse";
            this.buttonMasterPBackup2Browse.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 78;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Exif Tool File name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExifMapFilename
            // 
            this.textBoxExifMapFilename.Location = new System.Drawing.Point(207, 202);
            this.textBoxExifMapFilename.Name = "textBoxExifMapFilename";
            this.textBoxExifMapFilename.ReadOnly = true;
            this.textBoxExifMapFilename.Size = new System.Drawing.Size(155, 26);
            this.textBoxExifMapFilename.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Exif Map File name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Exif File Delimiter: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 430);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(82, 26);
            this.textBox3.TabIndex = 84;
            // 
            // ExifToolUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExifToolUC";
            this.Size = new System.Drawing.Size(1170, 923);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWebPicturesLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPicturesLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExifMapPath;
        private System.Windows.Forms.CheckBox checkBoxWorkspaceEnabled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMasterPBackup2Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxExifMapFilename;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}
