namespace iaadmingui
{
    partial class FileNamingUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileNamingUC));
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTestRenamedImageFile = new System.Windows.Forms.Button();
            this.textBoxRenamedImageFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOriginalImageFile = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelKeyword = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSequenceNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditFileRename = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.checkBoxImageFileRename = new System.Windows.Forms.CheckBox();
            this.textBoxImageFileRenamingTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(92, 46);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(260, 29);
            this.Titlelabel.TabIndex = 24;
            this.Titlelabel.Text = "File Naming  Options";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonEditFileRename);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.checkBoxImageFileRename);
            this.groupBox1.Controls.Add(this.textBoxImageFileRenamingTemplate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 656);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image File Renaming";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonTestRenamedImageFile);
            this.groupBox2.Controls.Add(this.textBoxRenamedImageFile);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxOriginalImageFile);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelVersion);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.labelKeyword);
            this.groupBox2.Controls.Add(this.textBoxDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxSequenceNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(33, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 373);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing Rename template";
            // 
            // buttonTestRenamedImageFile
            // 
            this.buttonTestRenamedImageFile.Location = new System.Drawing.Point(765, 237);
            this.buttonTestRenamedImageFile.Name = "buttonTestRenamedImageFile";
            this.buttonTestRenamedImageFile.Size = new System.Drawing.Size(90, 32);
            this.buttonTestRenamedImageFile.TabIndex = 100;
            this.buttonTestRenamedImageFile.Text = "Test";
            this.buttonTestRenamedImageFile.UseVisualStyleBackColor = true;
            this.buttonTestRenamedImageFile.Click += new System.EventHandler(this.buttonTestRenamedImageFile_Click);
            // 
            // textBoxRenamedImageFile
            // 
            this.textBoxRenamedImageFile.Location = new System.Drawing.Point(258, 300);
            this.textBoxRenamedImageFile.Name = "textBoxRenamedImageFile";
            this.textBoxRenamedImageFile.Size = new System.Drawing.Size(597, 26);
            this.textBoxRenamedImageFile.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 98;
            this.label10.Text = "Renamed Image File:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxOriginalImageFile
            // 
            this.textBoxOriginalImageFile.Location = new System.Drawing.Point(258, 113);
            this.textBoxOriginalImageFile.Name = "textBoxOriginalImageFile";
            this.textBoxOriginalImageFile.Size = new System.Drawing.Size(262, 26);
            this.textBoxOriginalImageFile.TabIndex = 93;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 26);
            this.textBox3.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "Original Image File:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(94, 243);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(67, 20);
            this.labelVersion.TabIndex = 96;
            this.labelVersion.Text = "Version:";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(258, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 26);
            this.textBox2.TabIndex = 95;
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Location = new System.Drawing.Point(94, 211);
            this.labelKeyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(73, 20);
            this.labelKeyword.TabIndex = 94;
            this.labelKeyword.Text = "Keyword:";
            this.labelKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(258, 179);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(262, 26);
            this.textBoxDate.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSequenceNumber
            // 
            this.textBoxSequenceNumber.Location = new System.Drawing.Point(258, 147);
            this.textBoxSequenceNumber.Name = "textBoxSequenceNumber";
            this.textBoxSequenceNumber.Size = new System.Drawing.Size(262, 26);
            this.textBoxSequenceNumber.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Sequence number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(91, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(840, 51);
            this.label4.TabIndex = 89;
            this.label4.Text = "This enables you to test how the renamed Image files will look after renaming usi" +
    "ng different parameters using the current rename template";
            // 
            // buttonEditFileRename
            // 
            this.buttonEditFileRename.Location = new System.Drawing.Point(977, 178);
            this.buttonEditFileRename.Name = "buttonEditFileRename";
            this.buttonEditFileRename.Size = new System.Drawing.Size(90, 32);
            this.buttonEditFileRename.TabIndex = 89;
            this.buttonEditFileRename.Text = "Edit";
            this.buttonEditFileRename.UseVisualStyleBackColor = true;
            this.buttonEditFileRename.Click += new System.EventHandler(this.buttonEditFileRename_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "This sets the base metadata to be included in imported images";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(216, 131);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(205, 20);
            this.label43.TabIndex = 88;
            this.label43.Text = "This sets the rename mode.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(17, 38);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 54);
            this.pictureBox3.TabIndex = 87;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(90, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Renaming On";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label44.Location = new System.Drawing.Point(112, 67);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(88, 25);
            this.label44.TabIndex = 86;
            this.label44.Text = "General";
            // 
            // checkBoxImageFileRename
            // 
            this.checkBoxImageFileRename.AutoSize = true;
            this.checkBoxImageFileRename.Location = new System.Drawing.Point(17, 127);
            this.checkBoxImageFileRename.Name = "checkBoxImageFileRename";
            this.checkBoxImageFileRename.Size = new System.Drawing.Size(162, 24);
            this.checkBoxImageFileRename.TabIndex = 53;
            this.checkBoxImageFileRename.Text = "Image file rename";
            this.checkBoxImageFileRename.UseVisualStyleBackColor = true;
            // 
            // textBoxImageFileRenamingTemplate
            // 
            this.textBoxImageFileRenamingTemplate.Location = new System.Drawing.Point(352, 184);
            this.textBoxImageFileRenamingTemplate.Name = "textBoxImageFileRenamingTemplate";
            this.textBoxImageFileRenamingTemplate.Size = new System.Drawing.Size(594, 26);
            this.textBoxImageFileRenamingTemplate.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Image File Renaming template:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FileNamingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FileNamingUC";
            this.Size = new System.Drawing.Size(1170, 923);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxImageFileRenamingTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxImageFileRename;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditFileRename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOriginalImageFile;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelKeyword;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSequenceNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTestRenamedImageFile;
        private System.Windows.Forms.TextBox textBoxRenamedImageFile;
        private System.Windows.Forms.Label label10;
    }
}
