﻿
namespace iachkin
{
    partial class CheckInMultiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInMultiForm));
            this.buttonDone = new System.Windows.Forms.Button();
            this.listViewImportFiles = new System.Windows.Forms.ListView();
            this.columnHeaderImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.groupBoxImport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.Location = new System.Drawing.Point(488, 738);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(118, 45);
            this.buttonDone.TabIndex = 11;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone);
            // 
            // listViewImportFiles
            // 
            this.listViewImportFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewImportFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImage,
            this.columnHeaderDateModified,
            this.columnHeaderType,
            this.columnHeaderSize,
            this.columnHeaderFolder});
            this.listViewImportFiles.HideSelection = false;
            this.listViewImportFiles.Location = new System.Drawing.Point(39, 55);
            this.listViewImportFiles.Margin = new System.Windows.Forms.Padding(45, 31, 45, 46);
            this.listViewImportFiles.Name = "listViewImportFiles";
            this.listViewImportFiles.Size = new System.Drawing.Size(760, 426);
            this.listViewImportFiles.SmallImageList = this.imageListStatus;
            this.listViewImportFiles.TabIndex = 0;
            this.listViewImportFiles.UseCompatibleStateImageBehavior = false;
            this.listViewImportFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderImage
            // 
            this.columnHeaderImage.Text = "Image";
            this.columnHeaderImage.Width = 150;
            // 
            // columnHeaderDateModified
            // 
            this.columnHeaderDateModified.Text = "Date modified";
            this.columnHeaderDateModified.Width = 150;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 120;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 100;
            // 
            // columnHeaderFolder
            // 
            this.columnHeaderFolder.Text = "Folder";
            this.columnHeaderFolder.Width = 250;
            // 
            // imageListStatus
            // 
            this.imageListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatus.ImageStream")));
            this.imageListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatus.Images.SetKeyName(0, "chkedin.bmp");
            this.imageListStatus.Images.SetKeyName(1, "chkedout.bmp");
            this.imageListStatus.Images.SetKeyName(2, "changed.bmp");
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxImport.Controls.Add(this.groupBox1);
            this.groupBoxImport.Controls.Add(this.listViewImportFiles);
            this.groupBoxImport.Controls.Add(this.buttonDone);
            this.groupBoxImport.Controls.Add(this.buttonProperties);
            this.groupBoxImport.Controls.Add(this.buttonCheckIn);
            this.groupBoxImport.Location = new System.Drawing.Point(38, 114);
            this.groupBoxImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxImport.Size = new System.Drawing.Size(848, 817);
            this.groupBoxImport.TabIndex = 13;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "Selected items to be  checked in to the Archive.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 182);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version Properties";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(630, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // buttonProperties
            // 
            this.buttonProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProperties.Location = new System.Drawing.Point(36, 738);
            this.buttonProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(142, 45);
            this.buttonProperties.TabIndex = 12;
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckIn.Location = new System.Drawing.Point(669, 738);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(129, 45);
            this.buttonCheckIn.TabIndex = 10;
            this.buttonCheckIn.Text = "Check-in";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(104, 54);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(195, 29);
            this.Titlelabel.TabIndex = 20;
            this.Titlelabel.Text = "Check-in Image";
            // 
            // CheckInMultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 971);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckInMultiForm";
            this.Text = "Check-in - ImgArchive";
            this.groupBoxImport.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.ListView listViewImportFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderDateModified;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderFolder;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListStatus;
        private System.Windows.Forms.Label Titlelabel;
    }
}

