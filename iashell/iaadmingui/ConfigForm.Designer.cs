namespace iaadmingui
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxWorkspaceCheckout = new System.Windows.Forms.CheckBox();
            this.checkBoxWorkspaceEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxWWWEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxPicturesEnabled = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUserSpaceLocation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDerivative = new System.Windows.Forms.Button();
            this.buttonMasterBrowse = new System.Windows.Forms.Button();
            this.checkBoxDeivativeBackup1Enabled = new System.Windows.Forms.CheckBox();
            this.checkBoxDeivativeBackup2Enabled = new System.Windows.Forms.CheckBox();
            this.checkBoxMasterBackup1Enabled = new System.Windows.Forms.CheckBox();
            this.checkBoxMasterBackup2Enabled = new System.Windows.Forms.CheckBox();
            this.buttonShowDerivativeBackups = new System.Windows.Forms.Button();
            this.buttonShowMasterBackups = new System.Windows.Forms.Button();
            this.textBoxDerivativePath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMasterPath = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.tabExif = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxExifFileDelimiter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxExifToolMapPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExifToolMapFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxExifToolAppCommandLine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxExifToolAppPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxExifToolApplication = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxExifTool = new System.Windows.Forms.CheckBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabMainControl.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAllowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabExif.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMainControl.Controls.Add(this.tabGeneral);
            this.tabMainControl.Controls.Add(this.tabConfig);
            this.tabMainControl.Controls.Add(this.tabAllowed);
            this.tabMainControl.Controls.Add(this.tabEnviroment);
            this.tabMainControl.Controls.Add(this.tabValidates);
            this.tabMainControl.Controls.Add(this.tabExif);
            this.tabMainControl.Location = new System.Drawing.Point(19, 128);
            this.tabMainControl.Margin = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(1105, 806);
            this.tabMainControl.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(1097, 773);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.groupBox5);
            this.tabConfig.Controls.Add(this.groupBox1);
            this.tabConfig.Location = new System.Drawing.Point(4, 29);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1097, 773);
            this.tabConfig.TabIndex = 1;
            this.tabConfig.Text = "Config";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceCheckout);
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceEnabled);
            this.groupBox5.Controls.Add(this.checkBoxWWWEnabled);
            this.groupBox5.Controls.Add(this.checkBoxPicturesEnabled);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBoxUserSpaceLocation);
            this.groupBox5.Location = new System.Drawing.Point(540, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 548);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Space";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 32);
            this.button4.TabIndex = 77;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Web Pictures location:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 459);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(484, 26);
            this.textBox3.TabIndex = 75;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 74;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Pictures location:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(484, 26);
            this.textBox2.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Work space location:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 70;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(484, 26);
            this.textBox1.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 68;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkspaceCheckout
            // 
            this.checkBoxWorkspaceCheckout.AutoSize = true;
            this.checkBoxWorkspaceCheckout.Location = new System.Drawing.Point(195, 267);
            this.checkBoxWorkspaceCheckout.Name = "checkBoxWorkspaceCheckout";
            this.checkBoxWorkspaceCheckout.Size = new System.Drawing.Size(192, 24);
            this.checkBoxWorkspaceCheckout.TabIndex = 53;
            this.checkBoxWorkspaceCheckout.Text = "Enable Auto checkout";
            this.checkBoxWorkspaceCheckout.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkspaceEnabled
            // 
            this.checkBoxWorkspaceEnabled.AutoSize = true;
            this.checkBoxWorkspaceEnabled.Location = new System.Drawing.Point(15, 267);
            this.checkBoxWorkspaceEnabled.Name = "checkBoxWorkspaceEnabled";
            this.checkBoxWorkspaceEnabled.Size = new System.Drawing.Size(178, 24);
            this.checkBoxWorkspaceEnabled.TabIndex = 52;
            this.checkBoxWorkspaceEnabled.Text = "Workspace Enabled";
            this.checkBoxWorkspaceEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxWWWEnabled
            // 
            this.checkBoxWWWEnabled.AutoSize = true;
            this.checkBoxWWWEnabled.Location = new System.Drawing.Point(15, 501);
            this.checkBoxWWWEnabled.Name = "checkBoxWWWEnabled";
            this.checkBoxWWWEnabled.Size = new System.Drawing.Size(143, 24);
            this.checkBoxWWWEnabled.TabIndex = 51;
            this.checkBoxWWWEnabled.Text = "WWW Enabled";
            this.checkBoxWWWEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxPicturesEnabled
            // 
            this.checkBoxPicturesEnabled.AutoSize = true;
            this.checkBoxPicturesEnabled.Location = new System.Drawing.Point(15, 393);
            this.checkBoxPicturesEnabled.Name = "checkBoxPicturesEnabled";
            this.checkBoxPicturesEnabled.Size = new System.Drawing.Size(155, 24);
            this.checkBoxPicturesEnabled.TabIndex = 50;
            this.checkBoxPicturesEnabled.Text = "Pictures Enabled";
            this.checkBoxPicturesEnabled.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "User space location:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUserSpaceLocation
            // 
            this.textBoxUserSpaceLocation.Location = new System.Drawing.Point(15, 82);
            this.textBoxUserSpaceLocation.Name = "textBoxUserSpaceLocation";
            this.textBoxUserSpaceLocation.ReadOnly = true;
            this.textBoxUserSpaceLocation.Size = new System.Drawing.Size(484, 26);
            this.textBoxUserSpaceLocation.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDerivative);
            this.groupBox1.Controls.Add(this.buttonMasterBrowse);
            this.groupBox1.Controls.Add(this.checkBoxDeivativeBackup1Enabled);
            this.groupBox1.Controls.Add(this.checkBoxDeivativeBackup2Enabled);
            this.groupBox1.Controls.Add(this.checkBoxMasterBackup1Enabled);
            this.groupBox1.Controls.Add(this.checkBoxMasterBackup2Enabled);
            this.groupBox1.Controls.Add(this.buttonShowDerivativeBackups);
            this.groupBox1.Controls.Add(this.buttonShowMasterBackups);
            this.groupBox1.Controls.Add(this.textBoxDerivativePath);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxMasterPath);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vault";
            // 
            // buttonDerivative
            // 
            this.buttonDerivative.Location = new System.Drawing.Point(403, 284);
            this.buttonDerivative.Name = "buttonDerivative";
            this.buttonDerivative.Size = new System.Drawing.Size(90, 32);
            this.buttonDerivative.TabIndex = 68;
            this.buttonDerivative.Text = "Browse";
            this.buttonDerivative.UseVisualStyleBackColor = true;
            // 
            // buttonMasterBrowse
            // 
            this.buttonMasterBrowse.Location = new System.Drawing.Point(403, 108);
            this.buttonMasterBrowse.Name = "buttonMasterBrowse";
            this.buttonMasterBrowse.Size = new System.Drawing.Size(90, 32);
            this.buttonMasterBrowse.TabIndex = 67;
            this.buttonMasterBrowse.Text = "Browse";
            this.buttonMasterBrowse.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeivativeBackup1Enabled
            // 
            this.checkBoxDeivativeBackup1Enabled.AutoSize = true;
            this.checkBoxDeivativeBackup1Enabled.Location = new System.Drawing.Point(18, 292);
            this.checkBoxDeivativeBackup1Enabled.Name = "checkBoxDeivativeBackup1Enabled";
            this.checkBoxDeivativeBackup1Enabled.Size = new System.Drawing.Size(165, 24);
            this.checkBoxDeivativeBackup1Enabled.TabIndex = 66;
            this.checkBoxDeivativeBackup1Enabled.Text = "Backup 1 Enabled";
            this.checkBoxDeivativeBackup1Enabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeivativeBackup2Enabled
            // 
            this.checkBoxDeivativeBackup2Enabled.AutoSize = true;
            this.checkBoxDeivativeBackup2Enabled.Location = new System.Drawing.Point(18, 326);
            this.checkBoxDeivativeBackup2Enabled.Name = "checkBoxDeivativeBackup2Enabled";
            this.checkBoxDeivativeBackup2Enabled.Size = new System.Drawing.Size(165, 24);
            this.checkBoxDeivativeBackup2Enabled.TabIndex = 65;
            this.checkBoxDeivativeBackup2Enabled.Text = "Backup 2 Enabled";
            this.checkBoxDeivativeBackup2Enabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasterBackup1Enabled
            // 
            this.checkBoxMasterBackup1Enabled.AutoSize = true;
            this.checkBoxMasterBackup1Enabled.Location = new System.Drawing.Point(18, 116);
            this.checkBoxMasterBackup1Enabled.Name = "checkBoxMasterBackup1Enabled";
            this.checkBoxMasterBackup1Enabled.Size = new System.Drawing.Size(165, 24);
            this.checkBoxMasterBackup1Enabled.TabIndex = 64;
            this.checkBoxMasterBackup1Enabled.Text = "Backup 1 Enabled";
            this.checkBoxMasterBackup1Enabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasterBackup2Enabled
            // 
            this.checkBoxMasterBackup2Enabled.AutoSize = true;
            this.checkBoxMasterBackup2Enabled.Location = new System.Drawing.Point(18, 150);
            this.checkBoxMasterBackup2Enabled.Name = "checkBoxMasterBackup2Enabled";
            this.checkBoxMasterBackup2Enabled.Size = new System.Drawing.Size(165, 24);
            this.checkBoxMasterBackup2Enabled.TabIndex = 63;
            this.checkBoxMasterBackup2Enabled.Text = "Backup 2 Enabled";
            this.checkBoxMasterBackup2Enabled.UseVisualStyleBackColor = true;
            // 
            // buttonShowDerivativeBackups
            // 
            this.buttonShowDerivativeBackups.Location = new System.Drawing.Point(198, 338);
            this.buttonShowDerivativeBackups.Name = "buttonShowDerivativeBackups";
            this.buttonShowDerivativeBackups.Size = new System.Drawing.Size(192, 34);
            this.buttonShowDerivativeBackups.TabIndex = 62;
            this.buttonShowDerivativeBackups.Text = "Show Backups";
            this.buttonShowDerivativeBackups.UseVisualStyleBackColor = true;
            // 
            // buttonShowMasterBackups
            // 
            this.buttonShowMasterBackups.Location = new System.Drawing.Point(189, 162);
            this.buttonShowMasterBackups.Name = "buttonShowMasterBackups";
            this.buttonShowMasterBackups.Size = new System.Drawing.Size(192, 34);
            this.buttonShowMasterBackups.TabIndex = 61;
            this.buttonShowMasterBackups.Text = "Show Backups";
            this.buttonShowMasterBackups.UseVisualStyleBackColor = true;
            // 
            // textBoxDerivativePath
            // 
            this.textBoxDerivativePath.Location = new System.Drawing.Point(22, 242);
            this.textBoxDerivativePath.Name = "textBoxDerivativePath";
            this.textBoxDerivativePath.ReadOnly = true;
            this.textBoxDerivativePath.Size = new System.Drawing.Size(471, 26);
            this.textBoxDerivativePath.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 20);
            this.label15.TabIndex = 59;
            this.label15.Text = "Derivative Vailt path:";
            // 
            // textBoxMasterPath
            // 
            this.textBoxMasterPath.Location = new System.Drawing.Point(15, 71);
            this.textBoxMasterPath.Name = "textBoxMasterPath";
            this.textBoxMasterPath.ReadOnly = true;
            this.textBoxMasterPath.Size = new System.Drawing.Size(478, 26);
            this.textBoxMasterPath.TabIndex = 58;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 20);
            this.label16.TabIndex = 57;
            this.label16.Text = "Master Vault path:";
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
            this.tabAllowed.Size = new System.Drawing.Size(1097, 773);
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
            this.tabEnviroment.Size = new System.Drawing.Size(1097, 773);
            this.tabEnviroment.TabIndex = 3;
            this.tabEnviroment.Text = "Enviroment";
            this.tabEnviroment.UseVisualStyleBackColor = true;
            // 
            // tabValidates
            // 
            this.tabValidates.Location = new System.Drawing.Point(4, 29);
            this.tabValidates.Name = "tabValidates";
            this.tabValidates.Padding = new System.Windows.Forms.Padding(3);
            this.tabValidates.Size = new System.Drawing.Size(1097, 773);
            this.tabValidates.TabIndex = 4;
            this.tabValidates.Text = "Validate";
            this.tabValidates.UseVisualStyleBackColor = true;
            // 
            // tabExif
            // 
            this.tabExif.Controls.Add(this.groupBox3);
            this.tabExif.Controls.Add(this.groupBox2);
            this.tabExif.Location = new System.Drawing.Point(4, 29);
            this.tabExif.Name = "tabExif";
            this.tabExif.Size = new System.Drawing.Size(1097, 773);
            this.tabExif.TabIndex = 5;
            this.tabExif.Text = "Exif Tool";
            this.tabExif.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxExifFileDelimiter);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxExifToolMapPath);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxExifToolMapFile);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(534, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 381);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exif Tool Mapping";
            // 
            // textBoxExifFileDelimiter
            // 
            this.textBoxExifFileDelimiter.Location = new System.Drawing.Point(201, 264);
            this.textBoxExifFileDelimiter.Name = "textBoxExifFileDelimiter";
            this.textBoxExifFileDelimiter.Size = new System.Drawing.Size(105, 26);
            this.textBoxExifFileDelimiter.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Exif File delimiter:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxExifToolMapPath
            // 
            this.textBoxExifToolMapPath.Location = new System.Drawing.Point(201, 176);
            this.textBoxExifToolMapPath.Name = "textBoxExifToolMapPath";
            this.textBoxExifToolMapPath.Size = new System.Drawing.Size(282, 26);
            this.textBoxExifToolMapPath.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Exif Tool Map Path:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Exif Tool Application:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxExifToolMapFile
            // 
            this.textBoxExifToolMapFile.Location = new System.Drawing.Point(201, 109);
            this.textBoxExifToolMapFile.Name = "textBoxExifToolMapFile";
            this.textBoxExifToolMapFile.Size = new System.Drawing.Size(105, 26);
            this.textBoxExifToolMapFile.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Exif Tool Map file:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxExifToolAppCommandLine);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxExifToolAppPath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxExifToolApplication);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBoxExifTool);
            this.groupBox2.Location = new System.Drawing.Point(7, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 381);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Exif Tool";
            // 
            // textBoxExifToolAppCommandLine
            // 
            this.textBoxExifToolAppCommandLine.Location = new System.Drawing.Point(296, 248);
            this.textBoxExifToolAppCommandLine.Name = "textBoxExifToolAppCommandLine";
            this.textBoxExifToolAppCommandLine.Size = new System.Drawing.Size(176, 26);
            this.textBoxExifToolAppCommandLine.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(266, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Exif Tool Application Command Line:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxExifToolAppPath
            // 
            this.textBoxExifToolAppPath.Location = new System.Drawing.Point(296, 179);
            this.textBoxExifToolAppPath.Name = "textBoxExifToolAppPath";
            this.textBoxExifToolAppPath.Size = new System.Drawing.Size(176, 26);
            this.textBoxExifToolAppPath.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Exif Tool Application Path:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Exif Tool Application:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxExifToolApplication
            // 
            this.textBoxExifToolApplication.Location = new System.Drawing.Point(296, 115);
            this.textBoxExifToolApplication.Name = "textBoxExifToolApplication";
            this.textBoxExifToolApplication.Size = new System.Drawing.Size(176, 26);
            this.textBoxExifToolApplication.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Exif Tool Application:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxExifTool
            // 
            this.checkBoxExifTool.AutoSize = true;
            this.checkBoxExifTool.Location = new System.Drawing.Point(28, 42);
            this.checkBoxExifTool.Name = "checkBoxExifTool";
            this.checkBoxExifTool.Size = new System.Drawing.Size(181, 24);
            this.checkBoxExifTool.TabIndex = 0;
            this.checkBoxExifTool.Text = "Enable External Tool";
            this.checkBoxExifTool.UseVisualStyleBackColor = true;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titlelabel.Location = new System.Drawing.Point(119, 56);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(169, 29);
            this.Titlelabel.TabIndex = 21;
            this.Titlelabel.Text = "Configuration";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 46);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(436, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "This dialog allows you to configure all aspects of ImgArchive..";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 993);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.tabMainControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "ImgArchive - Configuration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.tabMainControl.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAllowed.ResumeLayout(false);
            this.tabAllowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabExif.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxWorkspaceCheckout;
        private System.Windows.Forms.CheckBox checkBoxWorkspaceEnabled;
        private System.Windows.Forms.CheckBox checkBoxWWWEnabled;
        private System.Windows.Forms.CheckBox checkBoxPicturesEnabled;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxUserSpaceLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDerivative;
        private System.Windows.Forms.Button buttonMasterBrowse;
        private System.Windows.Forms.CheckBox checkBoxDeivativeBackup1Enabled;
        private System.Windows.Forms.CheckBox checkBoxDeivativeBackup2Enabled;
        private System.Windows.Forms.CheckBox checkBoxMasterBackup1Enabled;
        private System.Windows.Forms.CheckBox checkBoxMasterBackup2Enabled;
        private System.Windows.Forms.Button buttonShowDerivativeBackups;
        private System.Windows.Forms.Button buttonShowMasterBackups;
        private System.Windows.Forms.TextBox textBoxDerivativePath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxMasterPath;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabAllowed;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listAllowedView;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnExt;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnMime;
        private System.Windows.Forms.ColumnHeader columnDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabEnviroment;
        private System.Windows.Forms.TabPage tabValidates;
        private System.Windows.Forms.TabPage tabExif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxExifFileDelimiter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxExifToolMapPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxExifToolMapFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxExifToolAppCommandLine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxExifToolAppPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxExifToolApplication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxExifTool;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
    }
}