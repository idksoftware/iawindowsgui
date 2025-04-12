namespace ProgressDialog
{
    partial class ImportProressDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportProressDialog));
            this.ProcessingLabel = new System.Windows.Forms.Label();
            this.labelStageText = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWarnings = new System.Windows.Forms.Label();
            this.labelImageIncluded = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.outputList = new System.Windows.Forms.ListBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.CurrentLineText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessingLabel
            // 
            this.ProcessingLabel.AutoSize = true;
            this.ProcessingLabel.Location = new System.Drawing.Point(220, 178);
            this.ProcessingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessingLabel.Name = "ProcessingLabel";
            this.ProcessingLabel.Size = new System.Drawing.Size(125, 20);
            this.ProcessingLabel.TabIndex = 1;
            this.ProcessingLabel.Text = "Processing item:";
            // 
            // labelStageText
            // 
            this.labelStageText.AutoSize = true;
            this.labelStageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStageText.Location = new System.Drawing.Point(84, 30);
            this.labelStageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStageText.Name = "labelStageText";
            this.labelStageText.Size = new System.Drawing.Size(116, 29);
            this.labelStageText.TabIndex = 25;
            this.labelStageText.Text = " ------      ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 105);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1442, 35);
            this.progressBar.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1266, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Errors: ";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(1401, 212);
            this.labelErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(52, 20);
            this.labelErrors.TabIndex = 34;
            this.labelErrors.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1266, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Warnings: ";
            // 
            // labelWarnings
            // 
            this.labelWarnings.AutoSize = true;
            this.labelWarnings.Location = new System.Drawing.Point(1401, 178);
            this.labelWarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarnings.Name = "labelWarnings";
            this.labelWarnings.Size = new System.Drawing.Size(52, 20);
            this.labelWarnings.TabIndex = 32;
            this.labelWarnings.Text = "About";
            // 
            // labelImageIncluded
            // 
            this.labelImageIncluded.AutoSize = true;
            this.labelImageIncluded.Location = new System.Drawing.Point(580, 212);
            this.labelImageIncluded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImageIncluded.Name = "labelImageIncluded";
            this.labelImageIncluded.Size = new System.Drawing.Size(75, 20);
            this.labelImageIncluded.TabIndex = 30;
            this.labelImageIncluded.Text = "XXXXXX";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Location = new System.Drawing.Point(23, 178);
            this.timeRemainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(177, 20);
            this.timeRemainingLabel.TabIndex = 27;
            this.timeRemainingLabel.Text = "Paused - 68% complete";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(580, 266);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Name:";
            // 
            // outputList
            // 
            this.outputList.BackColor = System.Drawing.Color.Black;
            this.outputList.FormattingEnabled = true;
            this.outputList.ItemHeight = 20;
            this.outputList.Location = new System.Drawing.Point(18, 302);
            this.outputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputList.Name = "outputList";
            this.outputList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.outputList.Size = new System.Drawing.Size(1442, 384);
            this.outputList.TabIndex = 36;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(1340, 712);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(129, 45);
            this.buttonDone.TabIndex = 37;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            // 
            // CurrentLineText
            // 
            this.CurrentLineText.AutoSize = true;
            this.CurrentLineText.Location = new System.Drawing.Point(67, 724);
            this.CurrentLineText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentLineText.Name = "CurrentLineText";
            this.CurrentLineText.Size = new System.Drawing.Size(75, 20);
            this.CurrentLineText.TabIndex = 38;
            this.CurrentLineText.Text = "XXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 724);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Item:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // ImportProressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentLineText);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWarnings);
            this.Controls.Add(this.labelImageIncluded);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.labelStageText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ProcessingLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportProressDialog";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportProressDialog_FormClosing);
            this.Load += new System.EventHandler(this.ImportProressDialog_Load);
            this.Shown += new System.EventHandler(this.ImportProressDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcessingLabel;
        private System.Windows.Forms.Label labelStageText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWarnings;
        private System.Windows.Forms.Label labelImageIncluded;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label CurrentLineText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}