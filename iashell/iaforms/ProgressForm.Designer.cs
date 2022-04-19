
namespace iaforms
{
    partial class ProgressForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.selectedItems = new System.Windows.Forms.ListView();
            this.ItemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonDone = new System.Windows.Forms.Button();
            this.timerStartProcess = new System.Windows.Forms.Timer(this.components);
            this.labelProcess = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Time remaining: ";
            // 
            // buttonPause
            // 
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(362, 22);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(32, 32);
            this.buttonPause.TabIndex = 31;
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(410, 22);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(32, 32);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Process:";
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Location = new System.Drawing.Point(152, 170);
            this.timeRemainingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(52, 20);
            this.timeRemainingLabel.TabIndex = 27;
            this.timeRemainingLabel.Text = "About";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Location = new System.Drawing.Point(20, 132);
            this.name3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(55, 20);
            this.name3.TabIndex = 26;
            this.name3.Text = "Name:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(24, 75);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(422, 35);
            this.progressBar.TabIndex = 25;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.Location = new System.Drawing.Point(19, 29);
            this.ActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(220, 25);
            this.ActionLabel.TabIndex = 24;
            this.ActionLabel.Text = "Paused - 68% complete";
            // 
            // selectedItems
            // 
            this.selectedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemColumn,
            this.nameColumn});
            this.selectedItems.HideSelection = false;
            this.selectedItems.Location = new System.Drawing.Point(22, 261);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.Size = new System.Drawing.Size(420, 373);
            this.selectedItems.SmallImageList = this.imageList;
            this.selectedItems.TabIndex = 33;
            this.selectedItems.UseCompatibleStateImageBehavior = false;
            this.selectedItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemColumn
            // 
            this.ItemColumn.Text = "Item";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Image";
            this.nameColumn.Width = 350;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pending.bmp");
            this.imageList.Images.SetKeyName(1, "success.bmp");
            this.imageList.Images.SetKeyName(2, "warnings.bmp");
            this.imageList.Images.SetKeyName(3, "errors.bmp");
            this.imageList.Images.SetKeyName(4, "fatal.bmp");
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.Location = new System.Drawing.Point(326, 665);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(118, 45);
            this.buttonDone.TabIndex = 34;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // timerStartProcess
            // 
            this.timerStartProcess.Interval = 500;
            this.timerStartProcess.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(108, 210);
            this.labelProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(52, 20);
            this.labelProcess.TabIndex = 35;
            this.labelProcess.Text = "About";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(89, 132);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 30);
            this.nameLabel.TabIndex = 36;
            // 
            // CheckoutProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 725);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.selectedItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ActionLabel);
            this.Name = "CheckoutProgressForm";
            this.Text = "Check-Out";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeRemainingLabel;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.ListView selectedItems;
        private System.Windows.Forms.ColumnHeader ItemColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timerStartProcess;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label nameLabel;
    }
}