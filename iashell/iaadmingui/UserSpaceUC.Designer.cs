using System;

namespace iaadmingui
{
    partial class UserSpaceUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSpaceUC));
            this.Titlelabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonWebPicturesLocation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWebPicturesLocation = new System.Windows.Forms.TextBox();
            this.buttonPicturesLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPicturesLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWorkspaceLocation = new System.Windows.Forms.Button();
            this.textBoxWorkspaceLocation = new System.Windows.Forms.TextBox();
            this.buttonUserSpaceLocation = new System.Windows.Forms.Button();
            this.checkBoxWorkspaceCheckout = new System.Windows.Forms.CheckBox();
            this.checkBoxWorkspaceEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxWWWEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxPicturesEnabled = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUserSpaceLocation = new System.Windows.Forms.TextBox();
            this.CancalButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(59, 29);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(195, 20);
            this.Titlelabel.TabIndex = 22;
            this.Titlelabel.Text = "User Space  Properties";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonWebPicturesLocation);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxWebPicturesLocation);
            this.groupBox5.Controls.Add(this.buttonPicturesLocation);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBoxPicturesLocation);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.buttonWorkspaceLocation);
            this.groupBox5.Controls.Add(this.textBoxWorkspaceLocation);
            this.groupBox5.Controls.Add(this.buttonUserSpaceLocation);
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceCheckout);
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceEnabled);
            this.groupBox5.Controls.Add(this.checkBoxWWWEnabled);
            this.groupBox5.Controls.Add(this.checkBoxPicturesEnabled);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBoxUserSpaceLocation);
            this.groupBox5.Location = new System.Drawing.Point(12, 84);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(740, 420);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Space";
            // 
            // buttonWebPicturesLocation
            // 
            this.buttonWebPicturesLocation.Location = new System.Drawing.Point(661, 371);
            this.buttonWebPicturesLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWebPicturesLocation.Name = "buttonWebPicturesLocation";
            this.buttonWebPicturesLocation.Size = new System.Drawing.Size(60, 21);
            this.buttonWebPicturesLocation.TabIndex = 77;
            this.buttonWebPicturesLocation.Text = "Browse";
            this.buttonWebPicturesLocation.UseVisualStyleBackColor = true;
            this.buttonWebPicturesLocation.Click += new System.EventHandler(this.buttonWebPicturesLocation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Web Pictures location:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWebPicturesLocation
            // 
            this.textBoxWebPicturesLocation.Location = new System.Drawing.Point(138, 347);
            this.textBoxWebPicturesLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWebPicturesLocation.Name = "textBoxWebPicturesLocation";
            this.textBoxWebPicturesLocation.ReadOnly = true;
            this.textBoxWebPicturesLocation.Size = new System.Drawing.Size(583, 20);
            this.textBoxWebPicturesLocation.TabIndex = 75;
            // 
            // buttonPicturesLocation
            // 
            this.buttonPicturesLocation.Location = new System.Drawing.Point(661, 249);
            this.buttonPicturesLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPicturesLocation.Name = "buttonPicturesLocation";
            this.buttonPicturesLocation.Size = new System.Drawing.Size(60, 21);
            this.buttonPicturesLocation.TabIndex = 74;
            this.buttonPicturesLocation.Text = "Browse";
            this.buttonPicturesLocation.UseVisualStyleBackColor = true;
            this.buttonPicturesLocation.Click += new System.EventHandler(this.buttonPicturesLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Pictures location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPicturesLocation
            // 
            this.textBoxPicturesLocation.Location = new System.Drawing.Point(138, 225);
            this.textBoxPicturesLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPicturesLocation.Name = "textBoxPicturesLocation";
            this.textBoxPicturesLocation.ReadOnly = true;
            this.textBoxPicturesLocation.Size = new System.Drawing.Size(583, 20);
            this.textBoxPicturesLocation.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Work space location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonWorkspaceLocation
            // 
            this.buttonWorkspaceLocation.Location = new System.Drawing.Point(661, 164);
            this.buttonWorkspaceLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWorkspaceLocation.Name = "buttonWorkspaceLocation";
            this.buttonWorkspaceLocation.Size = new System.Drawing.Size(60, 21);
            this.buttonWorkspaceLocation.TabIndex = 70;
            this.buttonWorkspaceLocation.Text = "Browse";
            this.buttonWorkspaceLocation.UseVisualStyleBackColor = true;
            this.buttonWorkspaceLocation.Click += new System.EventHandler(this.buttonWorkspaceLocation_Click);
            // 
            // textBoxWorkspaceLocation
            // 
            this.textBoxWorkspaceLocation.Location = new System.Drawing.Point(138, 140);
            this.textBoxWorkspaceLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkspaceLocation.Name = "textBoxWorkspaceLocation";
            this.textBoxWorkspaceLocation.ReadOnly = true;
            this.textBoxWorkspaceLocation.Size = new System.Drawing.Size(583, 20);
            this.textBoxWorkspaceLocation.TabIndex = 69;
            // 
            // buttonUserSpaceLocation
            // 
            this.buttonUserSpaceLocation.Location = new System.Drawing.Point(661, 77);
            this.buttonUserSpaceLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserSpaceLocation.Name = "buttonUserSpaceLocation";
            this.buttonUserSpaceLocation.Size = new System.Drawing.Size(60, 21);
            this.buttonUserSpaceLocation.TabIndex = 68;
            this.buttonUserSpaceLocation.Text = "Browse";
            this.buttonUserSpaceLocation.UseVisualStyleBackColor = true;
            this.buttonUserSpaceLocation.Click += new System.EventHandler(this.buttonUserSpaceLocation_Click);
            // 
            // checkBoxWorkspaceCheckout
            // 
            this.checkBoxWorkspaceCheckout.AutoSize = true;
            this.checkBoxWorkspaceCheckout.Location = new System.Drawing.Point(327, 174);
            this.checkBoxWorkspaceCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxWorkspaceCheckout.Name = "checkBoxWorkspaceCheckout";
            this.checkBoxWorkspaceCheckout.Size = new System.Drawing.Size(132, 17);
            this.checkBoxWorkspaceCheckout.TabIndex = 53;
            this.checkBoxWorkspaceCheckout.Text = "Enable Auto checkout";
            this.checkBoxWorkspaceCheckout.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkspaceEnabled
            // 
            this.checkBoxWorkspaceEnabled.AutoSize = true;
            this.checkBoxWorkspaceEnabled.Location = new System.Drawing.Point(138, 174);
            this.checkBoxWorkspaceEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxWorkspaceEnabled.Name = "checkBoxWorkspaceEnabled";
            this.checkBoxWorkspaceEnabled.Size = new System.Drawing.Size(123, 17);
            this.checkBoxWorkspaceEnabled.TabIndex = 52;
            this.checkBoxWorkspaceEnabled.Text = "Workspace Enabled";
            this.checkBoxWorkspaceEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxWWWEnabled
            // 
            this.checkBoxWWWEnabled.AutoSize = true;
            this.checkBoxWWWEnabled.Location = new System.Drawing.Point(141, 375);
            this.checkBoxWWWEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxWWWEnabled.Name = "checkBoxWWWEnabled";
            this.checkBoxWWWEnabled.Size = new System.Drawing.Size(101, 17);
            this.checkBoxWWWEnabled.TabIndex = 51;
            this.checkBoxWWWEnabled.Text = "WWW Enabled";
            this.checkBoxWWWEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxPicturesEnabled
            // 
            this.checkBoxPicturesEnabled.AutoSize = true;
            this.checkBoxPicturesEnabled.Location = new System.Drawing.Point(138, 253);
            this.checkBoxPicturesEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPicturesEnabled.Name = "checkBoxPicturesEnabled";
            this.checkBoxPicturesEnabled.Size = new System.Drawing.Size(106, 17);
            this.checkBoxPicturesEnabled.TabIndex = 50;
            this.checkBoxPicturesEnabled.Text = "Pictures Enabled";
            this.checkBoxPicturesEnabled.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 56);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "User space location:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUserSpaceLocation
            // 
            this.textBoxUserSpaceLocation.Location = new System.Drawing.Point(138, 53);
            this.textBoxUserSpaceLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserSpaceLocation.Name = "textBoxUserSpaceLocation";
            this.textBoxUserSpaceLocation.ReadOnly = true;
            this.textBoxUserSpaceLocation.Size = new System.Drawing.Size(583, 20);
            this.textBoxUserSpaceLocation.TabIndex = 48;
            // 
            // CancalButton
            // 
            this.CancalButton.Location = new System.Drawing.Point(579, 547);
            this.CancalButton.Name = "CancalButton";
            this.CancalButton.Size = new System.Drawing.Size(75, 23);
            this.CancalButton.TabIndex = 47;
            this.CancalButton.Text = "Cancal";
            this.CancalButton.UseVisualStyleBackColor = true;
            this.CancalButton.Click += new System.EventHandler(this.CancalButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(670, 547);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 46;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // UserSpaceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancalButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserSpaceUC";
            this.Size = new System.Drawing.Size(780, 600);
            this.Load += new System.EventHandler(this.UserSpaceUC_Load);
            this.Leave += new System.EventHandler(this.UserSpaceUC_Leave);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonWebPicturesLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWebPicturesLocation;
        private System.Windows.Forms.Button buttonPicturesLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPicturesLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWorkspaceLocation;
        private System.Windows.Forms.TextBox textBoxWorkspaceLocation;
        private System.Windows.Forms.Button buttonUserSpaceLocation;
        private System.Windows.Forms.CheckBox checkBoxWorkspaceCheckout;
        private System.Windows.Forms.CheckBox checkBoxWorkspaceEnabled;
        private System.Windows.Forms.CheckBox checkBoxWWWEnabled;
        private System.Windows.Forms.CheckBox checkBoxPicturesEnabled;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUserSpaceLocation;
        private System.Windows.Forms.Button CancalButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private String pathLocation = null;
    }
}
