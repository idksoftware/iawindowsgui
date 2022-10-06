namespace iatray
{
    partial class ImportQueueForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImportFromFolder = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSetupTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(18, 71);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(787, 373);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tracking No";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 304;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "View and Track Imports";
            // 
            // buttonImportFromFolder
            // 
            this.buttonImportFromFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportFromFolder.Location = new System.Drawing.Point(18, 472);
            this.buttonImportFromFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonImportFromFolder.Name = "buttonImportFromFolder";
            this.buttonImportFromFolder.Size = new System.Drawing.Size(189, 35);
            this.buttonImportFromFolder.TabIndex = 42;
            this.buttonImportFromFolder.Text = "&Import from folder";
            this.buttonImportFromFolder.UseVisualStyleBackColor = true;
            this.buttonImportFromFolder.Click += new System.EventHandler(this.buttonImportFromFolder_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(695, 472);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 35);
            this.buttonClose.TabIndex = 44;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Location = new System.Drawing.Point(560, 472);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(110, 35);
            this.buttonStart.TabIndex = 45;
            this.buttonStart.Text = "&Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonSetupTemplate
            // 
            this.buttonSetupTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetupTemplate.Location = new System.Drawing.Point(232, 472);
            this.buttonSetupTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSetupTemplate.Name = "buttonSetupTemplate";
            this.buttonSetupTemplate.Size = new System.Drawing.Size(189, 35);
            this.buttonSetupTemplate.TabIndex = 46;
            this.buttonSetupTemplate.Text = "&Setup Template";
            this.buttonSetupTemplate.UseVisualStyleBackColor = true;
            this.buttonSetupTemplate.Click += new System.EventHandler(this.buttonSetupTemplate_Click);
            // 
            // ImportQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 521);
            this.Controls.Add(this.buttonSetupTemplate);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonImportFromFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "ImportQueueForm";
            this.Text = "Import Queue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportQueueForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImportFromFolder;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSetupTemplate;
    }
}