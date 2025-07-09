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
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEditFileRename = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxImageFileRename = new System.Windows.Forms.CheckBox();
            this.textBoxImageFileRenamingTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonEditFileRename);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label2);
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(91, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(840, 51);
            this.label7.TabIndex = 91;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // buttonEditFileRename
            // 
            this.buttonEditFileRename.Location = new System.Drawing.Point(781, 281);
            this.buttonEditFileRename.Name = "buttonEditFileRename";
            this.buttonEditFileRename.Size = new System.Drawing.Size(90, 32);
            this.buttonEditFileRename.TabIndex = 89;
            this.buttonEditFileRename.Text = "Edit";
            this.buttonEditFileRename.UseVisualStyleBackColor = true;
            this.buttonEditFileRename.Click += new System.EventHandler(this.buttonEditFileRename_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(258, 236);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(205, 20);
            this.label43.TabIndex = 88;
            this.label43.Text = "This sets the rename mode.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = global::iaadmingui.Properties.Resources.ImgArchive;
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
            // checkBoxImageFileRename
            // 
            this.checkBoxImageFileRename.AutoSize = true;
            this.checkBoxImageFileRename.Location = new System.Drawing.Point(48, 236);
            this.checkBoxImageFileRename.Name = "checkBoxImageFileRename";
            this.checkBoxImageFileRename.Size = new System.Drawing.Size(162, 24);
            this.checkBoxImageFileRename.TabIndex = 53;
            this.checkBoxImageFileRename.Text = "Image file rename";
            this.checkBoxImageFileRename.UseVisualStyleBackColor = true;
            // 
            // textBoxImageFileRenamingTemplate
            // 
            this.textBoxImageFileRenamingTemplate.Location = new System.Drawing.Point(296, 281);
            this.textBoxImageFileRenamingTemplate.Name = "textBoxImageFileRenamingTemplate";
            this.textBoxImageFileRenamingTemplate.Size = new System.Drawing.Size(456, 26);
            this.textBoxImageFileRenamingTemplate.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Image File Renaming template:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 790);
            this.label3.MaximumSize = new System.Drawing.Size(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1540, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // FileNamingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FileNamingUC";
            this.Size = new System.Drawing.Size(1157, 923);
            this.Load += new System.EventHandler(this.FileNamingUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditFileRename;
        private System.Windows.Forms.Label label7;
    }
}
