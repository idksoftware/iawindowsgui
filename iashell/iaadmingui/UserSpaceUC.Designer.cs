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
            this.Titlelabel.Location = new System.Drawing.Point(88, 45);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(285, 29);
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
            this.groupBox5.Location = new System.Drawing.Point(18, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1110, 646);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Space";
            // 
            // buttonWebPicturesLocation
            // 
            this.buttonWebPicturesLocation.Location = new System.Drawing.Point(992, 571);
            this.buttonWebPicturesLocation.Name = "buttonWebPicturesLocation";
            this.buttonWebPicturesLocation.Size = new System.Drawing.Size(90, 32);
            this.buttonWebPicturesLocation.TabIndex = 77;
            this.buttonWebPicturesLocation.Text = "Browse";
            this.buttonWebPicturesLocation.UseVisualStyleBackColor = true;
            this.buttonWebPicturesLocation.Click += new System.EventHandler(this.buttonWebPicturesLocation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Web Pictures location:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxWebPicturesLocation
            // 
            this.textBoxWebPicturesLocation.Location = new System.Drawing.Point(207, 534);
            this.textBoxWebPicturesLocation.Name = "textBoxWebPicturesLocation";
            this.textBoxWebPicturesLocation.ReadOnly = true;
            this.textBoxWebPicturesLocation.Size = new System.Drawing.Size(872, 26);
            this.textBoxWebPicturesLocation.TabIndex = 75;
            // 
            // buttonPicturesLocation
            // 
            this.buttonPicturesLocation.Location = new System.Drawing.Point(992, 383);
            this.buttonPicturesLocation.Name = "buttonPicturesLocation";
            this.buttonPicturesLocation.Size = new System.Drawing.Size(90, 32);
            this.buttonPicturesLocation.TabIndex = 74;
            this.buttonPicturesLocation.Text = "Browse";
            this.buttonPicturesLocation.UseVisualStyleBackColor = true;
            this.buttonPicturesLocation.Click += new System.EventHandler(this.buttonPicturesLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Pictures location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPicturesLocation
            // 
            this.textBoxPicturesLocation.Location = new System.Drawing.Point(207, 346);
            this.textBoxPicturesLocation.Name = "textBoxPicturesLocation";
            this.textBoxPicturesLocation.ReadOnly = true;
            this.textBoxPicturesLocation.Size = new System.Drawing.Size(872, 26);
            this.textBoxPicturesLocation.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Work space location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonWorkspaceLocation
            // 
            this.buttonWorkspaceLocation.Location = new System.Drawing.Point(992, 252);
            this.buttonWorkspaceLocation.Name = "buttonWorkspaceLocation";
            this.buttonWorkspaceLocation.Size = new System.Drawing.Size(90, 32);
            this.buttonWorkspaceLocation.TabIndex = 70;
            this.buttonWorkspaceLocation.Text = "Browse";
            this.buttonWorkspaceLocation.UseVisualStyleBackColor = true;
            this.buttonWorkspaceLocation.Click += new System.EventHandler(this.buttonWorkspaceLocation_Click);
            // 
            // textBoxWorkspaceLocation
            // 
            this.textBoxWorkspaceLocation.Location = new System.Drawing.Point(207, 215);
            this.textBoxWorkspaceLocation.Name = "textBoxWorkspaceLocation";
            this.textBoxWorkspaceLocation.ReadOnly = true;
            this.textBoxWorkspaceLocation.Size = new System.Drawing.Size(872, 26);
            this.textBoxWorkspaceLocation.TabIndex = 69;
            // 
            // buttonUserSpaceLocation
            // 
            this.buttonUserSpaceLocation.Location = new System.Drawing.Point(992, 118);
            this.buttonUserSpaceLocation.Name = "buttonUserSpaceLocation";
            this.buttonUserSpaceLocation.Size = new System.Drawing.Size(90, 32);
            this.buttonUserSpaceLocation.TabIndex = 68;
            this.buttonUserSpaceLocation.Text = "Browse";
            this.buttonUserSpaceLocation.UseVisualStyleBackColor = true;
            this.buttonUserSpaceLocation.Click += new System.EventHandler(this.buttonUserSpaceLocation_Click);
            // 
            // checkBoxWorkspaceCheckout
            // 
            this.checkBoxWorkspaceCheckout.AutoSize = true;
            this.checkBoxWorkspaceCheckout.Location = new System.Drawing.Point(490, 268);
            this.checkBoxWorkspaceCheckout.Name = "checkBoxWorkspaceCheckout";
            this.checkBoxWorkspaceCheckout.Size = new System.Drawing.Size(192, 24);
            this.checkBoxWorkspaceCheckout.TabIndex = 53;
            this.checkBoxWorkspaceCheckout.Text = "Enable Auto checkout";
            this.checkBoxWorkspaceCheckout.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkspaceEnabled
            // 
            this.checkBoxWorkspaceEnabled.AutoSize = true;
            this.checkBoxWorkspaceEnabled.Location = new System.Drawing.Point(207, 268);
            this.checkBoxWorkspaceEnabled.Name = "checkBoxWorkspaceEnabled";
            this.checkBoxWorkspaceEnabled.Size = new System.Drawing.Size(178, 24);
            this.checkBoxWorkspaceEnabled.TabIndex = 52;
            this.checkBoxWorkspaceEnabled.Text = "Workspace Enabled";
            this.checkBoxWorkspaceEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxWWWEnabled
            // 
            this.checkBoxWWWEnabled.AutoSize = true;
            this.checkBoxWWWEnabled.Location = new System.Drawing.Point(212, 577);
            this.checkBoxWWWEnabled.Name = "checkBoxWWWEnabled";
            this.checkBoxWWWEnabled.Size = new System.Drawing.Size(143, 24);
            this.checkBoxWWWEnabled.TabIndex = 51;
            this.checkBoxWWWEnabled.Text = "WWW Enabled";
            this.checkBoxWWWEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxPicturesEnabled
            // 
            this.checkBoxPicturesEnabled.AutoSize = true;
            this.checkBoxPicturesEnabled.Location = new System.Drawing.Point(207, 389);
            this.checkBoxPicturesEnabled.Name = "checkBoxPicturesEnabled";
            this.checkBoxPicturesEnabled.Size = new System.Drawing.Size(155, 24);
            this.checkBoxPicturesEnabled.TabIndex = 50;
            this.checkBoxPicturesEnabled.Text = "Pictures Enabled";
            this.checkBoxPicturesEnabled.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "User space location:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUserSpaceLocation
            // 
            this.textBoxUserSpaceLocation.Location = new System.Drawing.Point(207, 82);
            this.textBoxUserSpaceLocation.Name = "textBoxUserSpaceLocation";
            this.textBoxUserSpaceLocation.ReadOnly = true;
            this.textBoxUserSpaceLocation.Size = new System.Drawing.Size(872, 26);
            this.textBoxUserSpaceLocation.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // UserSpaceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserSpaceUC";
            this.Size = new System.Drawing.Size(1170, 923);
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private String pathLocation = null;
    }
}
