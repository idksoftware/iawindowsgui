namespace ProgressDialog
{
    partial class ProgressDialogForm
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
            this.ProcessingLabel = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.nameLabel = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputList = new System.Windows.Forms.ListBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelItemText = new System.Windows.Forms.Label();
            this.labelImageName = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWarnings = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProcessingLabel
            // 
            this.ProcessingLabel.AutoSize = true;
            this.ProcessingLabel.Location = new System.Drawing.Point(18, 14);
            this.ProcessingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessingLabel.Name = "ProcessingLabel";
            this.ProcessingLabel.Size = new System.Drawing.Size(125, 20);
            this.ProcessingLabel.TabIndex = 0;
            this.ProcessingLabel.Text = "Processing item:";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.Location = new System.Drawing.Point(18, 46);
            this.ActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(220, 25);
            this.ActionLabel.TabIndex = 1;
            this.ActionLabel.Text = "Paused - 68% complete";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 92);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1442, 35);
            this.progressBar.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(585, 256);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Location = new System.Drawing.Point(19, 234);
            this.timeRemainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(177, 20);
            this.timeRemainingLabel.TabIndex = 4;
            this.timeRemainingLabel.Text = "Paused - 68% complete";
            this.timeRemainingLabel.Click += new System.EventHandler(this.timeRemainingLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Action:";
            // 
            // outputList
            // 
            this.outputList.BackColor = System.Drawing.Color.Black;
            this.outputList.FormattingEnabled = true;
            this.outputList.ItemHeight = 20;
            this.outputList.Location = new System.Drawing.Point(23, 317);
            this.outputList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputList.Name = "outputList";
            this.outputList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.outputList.Size = new System.Drawing.Size(1442, 384);
            this.outputList.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::ProgressDialog.Properties.Resources.cancel;
            this.buttonCancel.Location = new System.Drawing.Point(1425, 46);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(32, 32);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelItemText
            // 
            this.labelItemText.AutoSize = true;
            this.labelItemText.Location = new System.Drawing.Point(152, 14);
            this.labelItemText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemText.Name = "labelItemText";
            this.labelItemText.Size = new System.Drawing.Size(75, 20);
            this.labelItemText.TabIndex = 8;
            this.labelItemText.Text = "XXXXXX";
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Location = new System.Drawing.Point(19, 155);
            this.labelImageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(75, 20);
            this.labelImageName.TabIndex = 9;
            this.labelImageName.Text = "XXXXXX";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(19, 190);
            this.labelAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(75, 20);
            this.labelAction.TabIndex = 10;
            this.labelAction.Text = "XXXXXX";
            // 
            // buttonPause
            // 
            this.buttonPause.Image = global::ProgressDialog.Properties.Resources.running;
            this.buttonPause.Location = new System.Drawing.Point(1385, 46);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(32, 32);
            this.buttonPause.TabIndex = 11;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(895, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time remaining: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1271, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Warnings: ";
            // 
            // labelWarnings
            // 
            this.labelWarnings.AutoSize = true;
            this.labelWarnings.Location = new System.Drawing.Point(1406, 169);
            this.labelWarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarnings.Name = "labelWarnings";
            this.labelWarnings.Size = new System.Drawing.Size(52, 20);
            this.labelWarnings.TabIndex = 13;
            this.labelWarnings.Text = "About";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1271, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Errors: ";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(1406, 202);
            this.labelErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(52, 20);
            this.labelErrors.TabIndex = 15;
            this.labelErrors.Text = "About";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1146, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stage:";
            // 
            // labelStageText
            // 
            this.labelStageText.AutoSize = true;
            this.labelStageText.Location = new System.Drawing.Point(1223, 14);
            this.labelStageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStageText.Name = "labelStageText";
            this.labelStageText.Size = new System.Drawing.Size(103, 20);
            this.labelStageText.TabIndex = 18;
            this.labelStageText.Text = " Initalising      ";
            // 
            // ProgressDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 758);
            this.Controls.Add(this.labelStageText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWarnings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.labelImageName);
            this.Controls.Add(this.labelItemText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.ProcessingLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProgressDialogForm";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProcessingLabel;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelItemText;
        private System.Windows.Forms.Label labelImageName;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWarnings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStageText;
    }
}

