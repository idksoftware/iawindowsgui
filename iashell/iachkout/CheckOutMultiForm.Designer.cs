
namespace iachkout
{
    partial class CheckOutMultiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutMultiForm));
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
            this.groupBoxImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxImport.Controls.Add(this.listViewImportFiles);
            this.groupBoxImport.Location = new System.Drawing.Point(12, 12);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxImport.Size = new System.Drawing.Size(651, 509);
            this.groupBoxImport.TabIndex = 9;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "Selected items for Check-out";
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
            this.listViewImportFiles.Location = new System.Drawing.Point(15, 27);
            this.listViewImportFiles.Margin = new System.Windows.Forms.Padding(30, 20, 30, 30);
            this.listViewImportFiles.Name = "listViewImportFiles";
            this.listViewImportFiles.Size = new System.Drawing.Size(622, 458);
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
            this.buttonImport.Location = new System.Drawing.Point(577, 539);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(86, 29);
            this.buttonImport.TabIndex = 6;
            this.buttonImport.Text = "Check-out";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(477, 539);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 29);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Done";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonProperties
            // 
            this.buttonProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProperties.Location = new System.Drawing.Point(12, 539);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(95, 29);
            this.buttonProperties.TabIndex = 8;
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // CheckOutMultiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 580);
            this.Controls.Add(this.groupBoxImport);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOutMultiForm";
            this.Text = "Check-out - ImgArchive";
            this.groupBoxImport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.ListView listViewImportFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader columnHeaderDateModified;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderFolder;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonImport;
    }
}

