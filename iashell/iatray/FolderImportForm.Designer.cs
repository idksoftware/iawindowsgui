﻿namespace iatray
{
    partial class FolderImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderImportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.importFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.checkBoxSubFolders = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancal = new System.Windows.Forms.Button();
            this.importSourceBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMetadata = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source import folder:";
            // 
            // importFolder
            // 
            this.importFolder.Location = new System.Drawing.Point(37, 107);
            this.importFolder.Name = "importFolder";
            this.importFolder.Size = new System.Drawing.Size(623, 26);
            this.importFolder.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(568, 147);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(92, 40);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // checkBoxSubFolders
            // 
            this.checkBoxSubFolders.AutoSize = true;
            this.checkBoxSubFolders.Checked = true;
            this.checkBoxSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSubFolders.Location = new System.Drawing.Point(37, 147);
            this.checkBoxSubFolders.Name = "checkBoxSubFolders";
            this.checkBoxSubFolders.Size = new System.Drawing.Size(164, 24);
            this.checkBoxSubFolders.TabIndex = 3;
            this.checkBoxSubFolders.Text = "Import sub-folders";
            this.checkBoxSubFolders.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(484, 227);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 38);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancal
            // 
            this.buttonCancal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancal.Location = new System.Drawing.Point(585, 227);
            this.buttonCancal.Name = "buttonCancal";
            this.buttonCancal.Size = new System.Drawing.Size(75, 38);
            this.buttonCancal.TabIndex = 5;
            this.buttonCancal.Text = "&Cancel";
            this.buttonCancal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Use this form to select the folder you wish to import into ImgArchive.";
            // 
            // buttonMetadata
            // 
            this.buttonMetadata.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonMetadata.Location = new System.Drawing.Point(37, 227);
            this.buttonMetadata.Name = "buttonMetadata";
            this.buttonMetadata.Size = new System.Drawing.Size(164, 38);
            this.buttonMetadata.TabIndex = 17;
            this.buttonMetadata.Text = "&Metadata";
            this.buttonMetadata.UseVisualStyleBackColor = true;
            this.buttonMetadata.Click += new System.EventHandler(this.buttonMetadata_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FolderImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 295);
            this.Controls.Add(this.buttonMetadata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCancal);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxSubFolders);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.importFolder);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderImportForm";
            this.Text = "Folder Import";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox importFolder;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.CheckBox checkBoxSubFolders;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancal;
        private System.Windows.Forms.FolderBrowserDialog importSourceBrowserDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMetadata;
    }
}