namespace iawizard
{
    partial class ShowBackupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBackupsForm));
            this.groupBoxBackups = new System.Windows.Forms.GroupBox();
            this.textBoxBackup2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBackup1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxBackups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBackups
            // 
            this.groupBoxBackups.Controls.Add(this.textBoxBackup2);
            this.groupBoxBackups.Controls.Add(this.label3);
            this.groupBoxBackups.Controls.Add(this.textBoxBackup1);
            this.groupBoxBackups.Controls.Add(this.label4);
            this.groupBoxBackups.Location = new System.Drawing.Point(22, 79);
            this.groupBoxBackups.Name = "groupBoxBackups";
            this.groupBoxBackups.Size = new System.Drawing.Size(918, 258);
            this.groupBoxBackups.TabIndex = 0;
            this.groupBoxBackups.TabStop = false;
            this.groupBoxBackups.Text = "Master Backups";
            // 
            // textBoxBackup2
            // 
            this.textBoxBackup2.Location = new System.Drawing.Point(29, 193);
            this.textBoxBackup2.Name = "textBoxBackup2";
            this.textBoxBackup2.Size = new System.Drawing.Size(871, 26);
            this.textBoxBackup2.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Backup 2 path:";
            // 
            // textBoxBackup1
            // 
            this.textBoxBackup1.Location = new System.Drawing.Point(31, 81);
            this.textBoxBackup1.Name = "textBoxBackup1";
            this.textBoxBackup1.Size = new System.Drawing.Size(869, 26);
            this.textBoxBackup1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Backup 1 path:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(828, 345);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(112, 35);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "&Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // ShowBackupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 399);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxBackups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowBackupsForm";
            this.Text = "ImgArchive 1.0 - Backups";
            this.Load += new System.EventHandler(this.ShowBackupsForm_Load);
            this.groupBoxBackups.ResumeLayout(false);
            this.groupBoxBackups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBackups;
        private System.Windows.Forms.TextBox textBoxBackup2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBackup1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDone;
    }
}