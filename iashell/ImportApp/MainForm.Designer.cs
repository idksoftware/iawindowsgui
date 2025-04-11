namespace ImportApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonLocal = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            buttonDownloads = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 58);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(83, 52);
            label1.Name = "label1";
            label1.Size = new Size(22, 29);
            label1.TabIndex = 1;
            label1.Text = " ";
            // 
            // buttonLocal
            // 
            buttonLocal.Location = new Point(30, 57);
            buttonLocal.Name = "buttonLocal";
            buttonLocal.Size = new Size(233, 34);
            buttonLocal.TabIndex = 2;
            buttonLocal.Text = "From Local source";
            buttonLocal.UseVisualStyleBackColor = true;
            buttonLocal.Click += buttonLocal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(83, 23);
            label2.Name = "label2";
            label2.Size = new Size(205, 29);
            label2.TabIndex = 3;
            label2.Text = "Import Images";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 56);
            label3.Name = "label3";
            label3.Size = new Size(376, 25);
            label3.TabIndex = 4;
            label3.Text = "Use this diaglog to add images to imgArchive";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDownloads);
            groupBox1.Controls.Add(buttonLocal);
            groupBox1.Location = new Point(25, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 190);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add to Library";
            // 
            // buttonDownloads
            // 
            buttonDownloads.Location = new Point(30, 106);
            buttonDownloads.Name = "buttonDownloads";
            buttonDownloads.Size = new Size(233, 34);
            buttonDownloads.TabIndex = 3;
            buttonDownloads.Text = "Downloads";
            buttonDownloads.UseVisualStyleBackColor = true;
            buttonDownloads.Click += buttonDownloads_Click;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.SelectedPath = "                                                                                                                                        ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 364);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ImgArchive - Import                                                                                                                                     ";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonLocal;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button buttonDownloads;
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog1;
    }
}