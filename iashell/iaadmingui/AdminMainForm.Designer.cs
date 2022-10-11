namespace iaadmingui
{
    partial class AdminMainForm
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
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabAllowed = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listAllowedView = new System.Windows.Forms.ListView();
            this.columnItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tabEnviroment = new System.Windows.Forms.TabPage();
            this.tabValidates = new System.Windows.Forms.TabPage();
            this.tabMainControl.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabAllowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabGeneral);
            this.tabMainControl.Controls.Add(this.tabConfig);
            this.tabMainControl.Controls.Add(this.tabAllowed);
            this.tabMainControl.Controls.Add(this.tabEnviroment);
            this.tabMainControl.Controls.Add(this.tabValidates);
            this.tabMainControl.Location = new System.Drawing.Point(1, 12);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1078, 678);
            this.tabMainControl.TabIndex = 0;
            this.tabMainControl.SelectedIndexChanged += new System.EventHandler(this.tabMainControl_SelectedIndexChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1070, 645);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox1);
            this.tabConfig.Location = new System.Drawing.Point(4, 29);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1070, 645);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabAllowed
            // 
            this.tabAllowed.Controls.Add(this.buttonDelete);
            this.tabAllowed.Controls.Add(this.buttonEdit);
            this.tabAllowed.Controls.Add(this.pictureBox1);
            this.tabAllowed.Controls.Add(this.buttonAdd);
            this.tabAllowed.Controls.Add(this.listAllowedView);
            this.tabAllowed.Controls.Add(this.label1);
            this.tabAllowed.Location = new System.Drawing.Point(4, 29);
            this.tabAllowed.Name = "tabAllowed";
            this.tabAllowed.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllowed.Size = new System.Drawing.Size(1070, 645);
            this.tabAllowed.TabIndex = 2;
            this.tabAllowed.Text = "Allowed";
            this.tabAllowed.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(946, 196);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 32);
            this.buttonDelete.TabIndex = 81;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(946, 142);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 32);
            this.buttonEdit.TabIndex = 80;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iaadmingui.Properties.Resources.ImgArchive;
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 54);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(946, 94);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 32);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listAllowedView
            // 
            this.listAllowedView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItem,
            this.columnExt,
            this.columnType,
            this.columnMime,
            this.columnDest});
            this.listAllowedView.FullRowSelect = true;
            this.listAllowedView.HideSelection = false;
            this.listAllowedView.Location = new System.Drawing.Point(17, 94);
            this.listAllowedView.Name = "listAllowedView";
            this.listAllowedView.Size = new System.Drawing.Size(912, 503);
            this.listAllowedView.TabIndex = 1;
            this.listAllowedView.UseCompatibleStateImageBehavior = false;
            this.listAllowedView.View = System.Windows.Forms.View.Details;
            this.listAllowedView.Click += new System.EventHandler(this.listAllowedView_Click);
            // 
            // columnItem
            // 
            this.columnItem.Text = "Item";
            // 
            // columnExt
            // 
            this.columnExt.Text = "Extention";
            this.columnExt.Width = 95;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            // 
            // columnMime
            // 
            this.columnMime.Text = "Mime";
            this.columnMime.Width = 161;
            // 
            // columnDest
            // 
            this.columnDest.Text = "Description ";
            this.columnDest.Width = 350;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allow which ";
            // 
            // tabEnviroment
            // 
            this.tabEnviroment.Location = new System.Drawing.Point(4, 29);
            this.tabEnviroment.Name = "tabEnviroment";
            this.tabEnviroment.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnviroment.Size = new System.Drawing.Size(1070, 645);
            this.tabEnviroment.TabIndex = 3;
            this.tabEnviroment.Text = "Enviroment";
            this.tabEnviroment.UseVisualStyleBackColor = true;
            // 
            // tabValidates
            // 
            this.tabValidates.Location = new System.Drawing.Point(4, 29);
            this.tabValidates.Name = "tabValidates";
            this.tabValidates.Padding = new System.Windows.Forms.Padding(3);
            this.tabValidates.Size = new System.Drawing.Size(1070, 645);
            this.tabValidates.TabIndex = 4;
            this.tabValidates.Text = "Validate";
            this.tabValidates.UseVisualStyleBackColor = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 763);
            this.Controls.Add(this.tabMainControl);
            this.Name = "AdminMainForm";
            this.Text = "Image Archive -Adminatrator";
            this.tabMainControl.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabAllowed.ResumeLayout(false);
            this.tabAllowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabAllowed;
        private System.Windows.Forms.TabPage tabEnviroment;
        private System.Windows.Forms.TabPage tabValidates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listAllowedView;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnExt;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnMime;
        private System.Windows.Forms.ColumnHeader columnDest;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}

