﻿
namespace iaexport
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.listViewImportFiles = new System.Windows.Forms.ListView();
            this.columnHeaderImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxImport.Controls.Add(this.listViewImportFiles);
            this.groupBoxImport.Controls.Add(this.buttonImport);
            this.groupBoxImport.Controls.Add(this.buttonCancel);
            this.groupBoxImport.Controls.Add(this.buttonProperties);
            this.groupBoxImport.Location = new System.Drawing.Point(44, 122);
            this.groupBoxImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxImport.Size = new System.Drawing.Size(1520, 818);
            this.groupBoxImport.TabIndex = 16;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "Selected items for Import";
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
            this.listViewImportFiles.Location = new System.Drawing.Point(36, 54);
            this.listViewImportFiles.Margin = new System.Windows.Forms.Padding(45, 31, 45, 46);
            this.listViewImportFiles.Name = "listViewImportFiles";
            this.listViewImportFiles.Size = new System.Drawing.Size(1432, 658);
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
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImport.Location = new System.Drawing.Point(1341, 743);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(129, 45);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(1160, 743);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 45);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonProperties
            // 
            this.buttonProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProperties.Location = new System.Drawing.Point(36, 743);
            this.buttonProperties.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(142, 45);
            this.buttonProperties.TabIndex = 8;
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(113, 60);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(180, 29);
            this.Titlelabel.TabIndex = 21;
            this.Titlelabel.Text = "Export Images";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 1022);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExportForm";
            this.Text = "Export - ImgArchive";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxImport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.ListView listViewImportFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderDateModified;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderFolder;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Label Titlelabel;
    }
}

