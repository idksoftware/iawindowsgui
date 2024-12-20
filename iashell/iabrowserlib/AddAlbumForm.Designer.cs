namespace iabrowserlib
{
    partial class AddAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlbumForm));
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            groupBox1 = new GroupBox();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.Highlight;
            labelTitle.Location = new Point(101, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(240, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Create a new album";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 198);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(22, 139);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(447, 31);
            textBoxDescription.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(105, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(364, 31);
            textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 102);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(403, 321);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(260, 321);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddAlbumForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 364);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(groupBox1);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAlbumForm";
            Text = "New album";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTitle;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button buttonOk;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Button buttonCancel;
    }
}