using System;

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
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.textBoxExifFileDelimiter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxExifMapFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExifToolFilename = new System.Windows.Forms.TextBox();
            this.buttonExifToolPathBrowse = new System.Windows.Forms.Button();
            this.buttonExifMapPathBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExifCommandLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExifToolPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExifMapPath = new System.Windows.Forms.TextBox();
            this.checkBoxExternalEXIFToolEnabled = new System.Windows.Forms.CheckBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
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
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.buttonDefault);
            this.groupBox5.Controls.Add(this.textBoxExifFileDelimiter);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxExifMapFilename);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBoxExifToolFilename);
            this.groupBox5.Controls.Add(this.buttonExifToolPathBrowse);
            this.groupBox5.Controls.Add(this.buttonExifMapPathBrowse);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxExifCommandLine);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBoxExifToolPath);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBoxExifMapPath);
            this.groupBox5.Controls.Add(this.checkBoxExternalEXIFToolEnabled);
            this.groupBox5.Location = new System.Drawing.Point(30, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1110, 646);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EXIF Tool Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Use default settings for exiftool.exe";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(979, 569);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(90, 32);
            this.buttonDefault.TabIndex = 85;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // textBoxExifFileDelimiter
            // 
            this.textBoxExifFileDelimiter.Location = new System.Drawing.Point(207, 435);
            this.textBoxExifFileDelimiter.Name = "textBoxExifFileDelimiter";
            this.textBoxExifFileDelimiter.Size = new System.Drawing.Size(82, 26);
            this.textBoxExifFileDelimiter.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Exif File Delimiter: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Exif Map File name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExifMapFilename
            // 
            this.textBoxExifMapFilename.Location = new System.Drawing.Point(207, 222);
            this.textBoxExifMapFilename.Name = "textBoxExifMapFilename";
            this.textBoxExifMapFilename.Size = new System.Drawing.Size(155, 26);
            this.textBoxExifMapFilename.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Exif Tool File name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExifToolFilename
            // 
            this.textBoxExifToolFilename.Location = new System.Drawing.Point(206, 364);
            this.textBoxExifToolFilename.Name = "textBoxExifToolFilename";
            this.textBoxExifToolFilename.Size = new System.Drawing.Size(155, 26);
            this.textBoxExifToolFilename.TabIndex = 79;
            // 
            // buttonExifToolPathBrowse
            // 
            this.buttonExifToolPathBrowse.Location = new System.Drawing.Point(989, 324);
            this.buttonExifToolPathBrowse.Name = "buttonExifToolPathBrowse";
            this.buttonExifToolPathBrowse.Size = new System.Drawing.Size(90, 32);
            this.buttonExifToolPathBrowse.TabIndex = 78;
            this.buttonExifToolPathBrowse.Text = "Browse";
            this.buttonExifToolPathBrowse.UseVisualStyleBackColor = true;
            this.buttonExifToolPathBrowse.Click += new System.EventHandler(this.buttonExifToolPathBrowse_Click);
            // 
            // buttonExifMapPathBrowse
            // 
            this.buttonExifMapPathBrowse.Location = new System.Drawing.Point(989, 190);
            this.buttonExifMapPathBrowse.Name = "buttonExifMapPathBrowse";
            this.buttonExifMapPathBrowse.Size = new System.Drawing.Size(90, 32);
            this.buttonExifMapPathBrowse.TabIndex = 77;
            this.buttonExifMapPathBrowse.Text = "Browse";
            this.buttonExifMapPathBrowse.UseVisualStyleBackColor = true;
            this.buttonExifMapPathBrowse.Click += new System.EventHandler(this.buttonExifMapPathBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Exif Command Line:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExifCommandLine
            // 
            this.textBoxExifCommandLine.Location = new System.Drawing.Point(206, 506);
            this.textBoxExifCommandLine.Name = "textBoxExifCommandLine";
            this.textBoxExifCommandLine.Size = new System.Drawing.Size(328, 26);
            this.textBoxExifCommandLine.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Exif Tool location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxExifToolPath
            // 
            this.textBoxExifToolPath.Location = new System.Drawing.Point(207, 293);
            this.textBoxExifToolPath.Name = "textBoxExifToolPath";
            this.textBoxExifToolPath.Size = new System.Drawing.Size(872, 26);
            this.textBoxExifToolPath.TabIndex = 72;
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
            this.textBoxExifMapPath.Size = new System.Drawing.Size(872, 26);
            this.textBoxExifMapPath.TabIndex = 69;
            // 
            // checkBoxExternalEXIFToolEnabled
            // 
            this.checkBoxExternalEXIFToolEnabled.AutoSize = true;
            this.checkBoxExternalEXIFToolEnabled.Location = new System.Drawing.Point(50, 60);
            this.checkBoxExternalEXIFToolEnabled.Name = "checkBoxExternalEXIFToolEnabled";
            this.checkBoxExternalEXIFToolEnabled.Size = new System.Drawing.Size(231, 24);
            this.checkBoxExternalEXIFToolEnabled.TabIndex = 52;
            this.checkBoxExternalEXIFToolEnabled.Text = "External EXIF Tool Enabled";
            this.checkBoxExternalEXIFToolEnabled.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.ExifToolUC_Load);
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
        private System.Windows.Forms.TextBox textBoxExifCommandLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExifToolPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExifMapPath;
        private System.Windows.Forms.CheckBox checkBoxExternalEXIFToolEnabled;
        private System.Windows.Forms.Button buttonExifToolPathBrowse;
        private System.Windows.Forms.Button buttonExifMapPathBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExifToolFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxExifMapFilename;
        private System.Windows.Forms.TextBox textBoxExifFileDelimiter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Label label7;
        private String pathLocation = null;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}
