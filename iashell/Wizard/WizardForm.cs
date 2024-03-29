using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using iaforms;

namespace IDK.Gui
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class WizardForm : System.Windows.Forms.Form
	{
		private IDK.Gui.Wizard.Wizard ImgArchiveWizard;
        private IDK.Gui.Wizard.WizardPage WelcomePage;
        private IDK.Gui.Wizard.InfoContainer infoContainer1;
        private System.Windows.Forms.Label label7;
		private IDK.Gui.Wizard.WizardPage wpFinish;
		private IDK.Gui.Wizard.InfoContainer infoContainerOptionsPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private IDK.Gui.Wizard.WizardPage FMMRegistration;
        private Button buttonShareware;
        private Label label26;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private Label label25;
        private IDK.Gui.Wizard.Header header9;
		private System.ComponentModel.IContainer components;
        private bool continueOn = false;
        private FolderBrowserDialog folderBrowser;
        private String shutdownOption = null;
        private Wizard.WizardPage wizardPage1;
        private Wizard.WizardPage wpMasterBackups;
        private Wizard.WizardPage wpUserSpace;
        private Wizard.WizardPage wpDerivativeBackups;
        private Wizard.Header header5;
        private Button buttonDerivativeBackup2;
        private Button buttonDerivativeBackup1;
        private TextBox textBoxDerivativeBackup2;
        private Label label3;
        private TextBox textBoxDerivativeBackup1;
        private Label label4;
        private Wizard.Header header3;
        private Button buttonMasterBackup2;
        private Button buttonMasterBackup1;
        private TextBox textBoxMasterBackup2;
        private Label label1;
        private TextBox textBoxMasterBackup1;
        private Label label2;
        private CheckBox checkBoxMasterEnableBackup2;
        private CheckBox checkBoxMasterEnableBackup1;
        private CheckBox checkBoxDerivativeBackup2;
        private CheckBox checkBoxDerivativeBackup1;
        private Label label5;
        private Button buttonUserspace;
        private TextBox textBoxUserSpacePath;
        private Wizard.Header header6;
        private CheckBox checkBoxEnableAutoCheckout;
        private CheckBox checkBoxWorkspaceOn;
        private CheckBox checkBoxWWWOn;
        private CheckBox checkBoxPicturesOn;
        private String location = null;
        private String m_exePath;
        private String m_workingPath;
        private Timer timerProcess;
        private String m_output;
        private Wizard.WizardPage wpSummary;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label10;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label6;
        private TextBox textBox1;
        private Wizard.Header header1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox5;
        private Label label13;
        private Wizard.WizardPage wpApply;
        private Wizard.Header header7;
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonApply;
        private CtrlCheckBoxReadOnly checkBoxWorkspaceCheckout;
        private CtrlCheckBoxReadOnly checkBoxWorkspaceEnabled;
        private CtrlCheckBoxReadOnly checkBoxWWWEnabled;
        private CtrlCheckBoxReadOnly checkBoxPicturesEnabled;
        private Label label14;
        private TextBox textBoxUserSpaceLocation;
        private CtrlCheckBoxReadOnly checkBoxDeivativeBackup1Enabled;
        private CtrlCheckBoxReadOnly checkBoxDeivativeBackup2Enabled;
        private CtrlCheckBoxReadOnly checkBoxMasterBackup1Enabled;
        private CtrlCheckBoxReadOnly checkBoxMasterBackup2Enabled;
        private Button buttonShowDerivativeBackups;
        private Button buttonShowMasterBackups;
        private TextBox textBoxDerivativePath;
        private Label label15;
        private TextBox textBoxMasterPath;
        private Label label16;
        private Button buttonDerivativePathBrowse;
        private TextBox textBoxDerivativeLocation;
        private Label label18;
        private Button buttonMasterLocation;
        private TextBox textBoxMasterLocation;
        private Label label17;
        DefaultParameters m_defaultParameters = new DefaultParameters();

        
       
        string filePath;

        ChangesList changesList = null;
        public WizardForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.TopMost = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            changesList = new ChangesList(); 

        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardForm));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.ImgArchiveWizard = new IDK.Gui.Wizard.Wizard();
            this.WelcomePage = new IDK.Gui.Wizard.WizardPage();
            this.infoContainer1 = new IDK.Gui.Wizard.InfoContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wpMasterBackups = new IDK.Gui.Wizard.WizardPage();
            this.buttonMasterLocation = new System.Windows.Forms.Button();
            this.textBoxMasterLocation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBoxMasterEnableBackup2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMasterEnableBackup1 = new System.Windows.Forms.CheckBox();
            this.header3 = new IDK.Gui.Wizard.Header();
            this.buttonMasterBackup2 = new System.Windows.Forms.Button();
            this.buttonMasterBackup1 = new System.Windows.Forms.Button();
            this.textBoxMasterBackup2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMasterBackup1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wpDerivativeBackups = new IDK.Gui.Wizard.WizardPage();
            this.buttonDerivativePathBrowse = new System.Windows.Forms.Button();
            this.textBoxDerivativeLocation = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBoxDerivativeBackup2 = new System.Windows.Forms.CheckBox();
            this.checkBoxDerivativeBackup1 = new System.Windows.Forms.CheckBox();
            this.header5 = new IDK.Gui.Wizard.Header();
            this.buttonDerivativeBackup2 = new System.Windows.Forms.Button();
            this.buttonDerivativeBackup1 = new System.Windows.Forms.Button();
            this.textBoxDerivativeBackup2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDerivativeBackup1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wpUserSpace = new IDK.Gui.Wizard.WizardPage();
            this.checkBoxEnableAutoCheckout = new System.Windows.Forms.CheckBox();
            this.checkBoxWorkspaceOn = new System.Windows.Forms.CheckBox();
            this.checkBoxWWWOn = new System.Windows.Forms.CheckBox();
            this.checkBoxPicturesOn = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUserspace = new System.Windows.Forms.Button();
            this.textBoxUserSpacePath = new System.Windows.Forms.TextBox();
            this.header6 = new IDK.Gui.Wizard.Header();
            this.wpApply = new IDK.Gui.Wizard.WizardPage();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxWorkspaceCheckout = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.checkBoxWorkspaceEnabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.checkBoxWWWEnabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.checkBoxPicturesEnabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxUserSpaceLocation = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxDeivativeBackup1Enabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.checkBoxDeivativeBackup2Enabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.checkBoxMasterBackup1Enabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.checkBoxMasterBackup2Enabled = new IDK.Gui.CtrlCheckBoxReadOnly();
            this.buttonShowDerivativeBackups = new System.Windows.Forms.Button();
            this.buttonShowMasterBackups = new System.Windows.Forms.Button();
            this.textBoxDerivativePath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMasterPath = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.header7 = new IDK.Gui.Wizard.Header();
            this.wpFinish = new IDK.Gui.Wizard.WizardPage();
            this.infoContainerOptionsPage = new IDK.Gui.Wizard.InfoContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.wpSummary = new IDK.Gui.Wizard.WizardPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header1 = new IDK.Gui.Wizard.Header();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FMMRegistration = new IDK.Gui.Wizard.WizardPage();
            this.wizardPage1 = new IDK.Gui.Wizard.WizardPage();
            this.buttonShareware = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.header9 = new IDK.Gui.Wizard.Header();
            this.ImgArchiveWizard.SuspendLayout();
            this.WelcomePage.SuspendLayout();
            this.infoContainer1.SuspendLayout();
            this.wpMasterBackups.SuspendLayout();
            this.wpDerivativeBackups.SuspendLayout();
            this.wpUserSpace.SuspendLayout();
            this.wpApply.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.wpFinish.SuspendLayout();
            this.infoContainerOptionsPage.SuspendLayout();
            this.wpSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.header1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.FMMRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerProcess
            // 
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // ImgArchiveWizard
            // 
            this.ImgArchiveWizard.Controls.Add(this.WelcomePage);
            this.ImgArchiveWizard.Controls.Add(this.wpFinish);
            this.ImgArchiveWizard.Controls.Add(this.wpApply);
            this.ImgArchiveWizard.Controls.Add(this.wpUserSpace);
            this.ImgArchiveWizard.Controls.Add(this.wpDerivativeBackups);
            this.ImgArchiveWizard.Controls.Add(this.wpMasterBackups);
            this.ImgArchiveWizard.Controls.Add(this.wpSummary);
            this.ImgArchiveWizard.Controls.Add(this.FMMRegistration);
            this.ImgArchiveWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgArchiveWizard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgArchiveWizard.Location = new System.Drawing.Point(0, 0);
            this.ImgArchiveWizard.Name = "ImgArchiveWizard";
            this.ImgArchiveWizard.Pages.AddRange(new IDK.Gui.Wizard.WizardPage[] {
            this.WelcomePage,
            this.wpMasterBackups,
            this.wpDerivativeBackups,
            this.wpUserSpace,
            this.wpApply,
            this.wpFinish});
            this.ImgArchiveWizard.Size = new System.Drawing.Size(916, 545);
            this.ImgArchiveWizard.TabIndex = 0;
            this.ImgArchiveWizard.CloseFromCancel += new System.ComponentModel.CancelEventHandler(this.wizard1_CloseFromCancel);
            this.ImgArchiveWizard.Load += new System.EventHandler(this.ImgArchiveWizard_Load);
            // 
            // WelcomePage
            // 
            this.WelcomePage.Controls.Add(this.infoContainer1);
            this.WelcomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomePage.IsFinishPage = false;
            this.WelcomePage.Location = new System.Drawing.Point(0, 0);
            this.WelcomePage.Name = "WelcomePage";
            this.WelcomePage.Size = new System.Drawing.Size(916, 475);
            this.WelcomePage.TabIndex = 1;
            // 
            // infoContainer1
            // 
            this.infoContainer1.BackColor = System.Drawing.Color.White;
            this.infoContainer1.Controls.Add(this.label11);
            this.infoContainer1.Controls.Add(this.label7);
            this.infoContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoContainer1.Image = global::IDK.Gui.Properties.Resources.disks;
            this.infoContainer1.Location = new System.Drawing.Point(0, 0);
            this.infoContainer1.Name = "infoContainer1";
            this.infoContainer1.PageTitle = "Welcome to the ImgArchive 1.0 Setup Wizard";
            this.infoContainer1.Size = new System.Drawing.Size(916, 475);
            this.infoContainer1.TabIndex = 0;
            this.infoContainer1.Leave += new System.EventHandler(this.infoContainer1_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Location = new System.Drawing.Point(275, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(638, 45);
            this.label11.TabIndex = 8;
            this.label11.Text = "This wizard helps you setup ImgArchive on your system. ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(197, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(569, 68);
            this.label7.TabIndex = 10;
            this.label7.Text = "This settup Wizard will take you through the steps required to setup ImgArchive. " +
    "Cclick next to continue.";
            // 
            // wpMasterBackups
            // 
            this.wpMasterBackups.Controls.Add(this.buttonMasterLocation);
            this.wpMasterBackups.Controls.Add(this.textBoxMasterLocation);
            this.wpMasterBackups.Controls.Add(this.label17);
            this.wpMasterBackups.Controls.Add(this.checkBoxMasterEnableBackup2);
            this.wpMasterBackups.Controls.Add(this.checkBoxMasterEnableBackup1);
            this.wpMasterBackups.Controls.Add(this.header3);
            this.wpMasterBackups.Controls.Add(this.buttonMasterBackup2);
            this.wpMasterBackups.Controls.Add(this.buttonMasterBackup1);
            this.wpMasterBackups.Controls.Add(this.textBoxMasterBackup2);
            this.wpMasterBackups.Controls.Add(this.label1);
            this.wpMasterBackups.Controls.Add(this.textBoxMasterBackup1);
            this.wpMasterBackups.Controls.Add(this.label2);
            this.wpMasterBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpMasterBackups.IsFinishPage = false;
            this.wpMasterBackups.Location = new System.Drawing.Point(0, 0);
            this.wpMasterBackups.Name = "wpMasterBackups";
            this.wpMasterBackups.Size = new System.Drawing.Size(912, 474);
            this.wpMasterBackups.TabIndex = 19;
            this.wpMasterBackups.ShowFromBack += new System.EventHandler(this.wpMasterBackups_ShowFromBack);
            this.wpMasterBackups.ShowFromNext += new System.EventHandler(this.wpMasterBackups_ShowFromNext);
            // 
            // buttonMasterLocation
            // 
            this.buttonMasterLocation.Location = new System.Drawing.Point(798, 190);
            this.buttonMasterLocation.Name = "buttonMasterLocation";
            this.buttonMasterLocation.Size = new System.Drawing.Size(92, 31);
            this.buttonMasterLocation.TabIndex = 44;
            this.buttonMasterLocation.Text = "Browse";
            this.buttonMasterLocation.UseVisualStyleBackColor = true;
            this.buttonMasterLocation.Click += new System.EventHandler(this.buttonMasterLocation_Click);
            // 
            // textBoxMasterLocation
            // 
            this.textBoxMasterLocation.Location = new System.Drawing.Point(14, 151);
            this.textBoxMasterLocation.Name = "textBoxMasterLocation";
            this.textBoxMasterLocation.Size = new System.Drawing.Size(876, 27);
            this.textBoxMasterLocation.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 21);
            this.label17.TabIndex = 42;
            this.label17.Text = "Master Vault path:";
            // 
            // checkBoxMasterEnableBackup2
            // 
            this.checkBoxMasterEnableBackup2.AutoSize = true;
            this.checkBoxMasterEnableBackup2.Location = new System.Drawing.Point(14, 436);
            this.checkBoxMasterEnableBackup2.Name = "checkBoxMasterEnableBackup2";
            this.checkBoxMasterEnableBackup2.Size = new System.Drawing.Size(158, 25);
            this.checkBoxMasterEnableBackup2.TabIndex = 41;
            this.checkBoxMasterEnableBackup2.Text = "Enable Backup 2";
            this.checkBoxMasterEnableBackup2.UseVisualStyleBackColor = true;
            this.checkBoxMasterEnableBackup2.CheckedChanged += new System.EventHandler(this.checkBoxMasterEnableBackup2_CheckedChanged);
            // 
            // checkBoxMasterEnableBackup1
            // 
            this.checkBoxMasterEnableBackup1.AutoSize = true;
            this.checkBoxMasterEnableBackup1.Location = new System.Drawing.Point(13, 314);
            this.checkBoxMasterEnableBackup1.Name = "checkBoxMasterEnableBackup1";
            this.checkBoxMasterEnableBackup1.Size = new System.Drawing.Size(158, 25);
            this.checkBoxMasterEnableBackup1.TabIndex = 40;
            this.checkBoxMasterEnableBackup1.Text = "Enable Backup 1";
            this.checkBoxMasterEnableBackup1.UseVisualStyleBackColor = true;
            this.checkBoxMasterEnableBackup1.CheckedChanged += new System.EventHandler(this.checkBoxMasterEnableBackup1_CheckedChanged);
            // 
            // header3
            // 
            this.header3.BackColor = System.Drawing.SystemColors.Control;
            this.header3.CausesValidation = false;
            this.header3.Description = "This will be where the master or original images will be stored for save heeping." +
    " These image will be stored in the Master Vault, plus two optional back-ups for " +
    "extra safety.";
            this.header3.Dock = System.Windows.Forms.DockStyle.Top;
            this.header3.Image = ((System.Drawing.Image)(resources.GetObject("header3.Image")));
            this.header3.Location = new System.Drawing.Point(0, 0);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(912, 94);
            this.header3.TabIndex = 39;
            this.header3.Title = "Master Vault";
            // 
            // buttonMasterBackup2
            // 
            this.buttonMasterBackup2.Location = new System.Drawing.Point(794, 436);
            this.buttonMasterBackup2.Name = "buttonMasterBackup2";
            this.buttonMasterBackup2.Size = new System.Drawing.Size(96, 30);
            this.buttonMasterBackup2.TabIndex = 38;
            this.buttonMasterBackup2.Text = "Browse";
            this.buttonMasterBackup2.UseVisualStyleBackColor = true;
            this.buttonMasterBackup2.Click += new System.EventHandler(this.buttonMasterBackup2_Click);
            // 
            // buttonMasterBackup1
            // 
            this.buttonMasterBackup1.Location = new System.Drawing.Point(794, 316);
            this.buttonMasterBackup1.Name = "buttonMasterBackup1";
            this.buttonMasterBackup1.Size = new System.Drawing.Size(96, 30);
            this.buttonMasterBackup1.TabIndex = 37;
            this.buttonMasterBackup1.Text = "Browse";
            this.buttonMasterBackup1.UseVisualStyleBackColor = true;
            this.buttonMasterBackup1.Click += new System.EventHandler(this.buttonMasterBackup1_Click);
            // 
            // textBoxMasterBackup2
            // 
            this.textBoxMasterBackup2.Location = new System.Drawing.Point(13, 398);
            this.textBoxMasterBackup2.Name = "textBoxMasterBackup2";
            this.textBoxMasterBackup2.Size = new System.Drawing.Size(877, 27);
            this.textBoxMasterBackup2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Backup 2 path:";
            // 
            // textBoxMasterBackup1
            // 
            this.textBoxMasterBackup1.Location = new System.Drawing.Point(13, 273);
            this.textBoxMasterBackup1.Name = "textBoxMasterBackup1";
            this.textBoxMasterBackup1.Size = new System.Drawing.Size(877, 27);
            this.textBoxMasterBackup1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Backup 1 path:";
            // 
            // wpDerivativeBackups
            // 
            this.wpDerivativeBackups.Controls.Add(this.buttonDerivativePathBrowse);
            this.wpDerivativeBackups.Controls.Add(this.textBoxDerivativeLocation);
            this.wpDerivativeBackups.Controls.Add(this.label18);
            this.wpDerivativeBackups.Controls.Add(this.checkBoxDerivativeBackup2);
            this.wpDerivativeBackups.Controls.Add(this.checkBoxDerivativeBackup1);
            this.wpDerivativeBackups.Controls.Add(this.header5);
            this.wpDerivativeBackups.Controls.Add(this.buttonDerivativeBackup2);
            this.wpDerivativeBackups.Controls.Add(this.buttonDerivativeBackup1);
            this.wpDerivativeBackups.Controls.Add(this.textBoxDerivativeBackup2);
            this.wpDerivativeBackups.Controls.Add(this.label3);
            this.wpDerivativeBackups.Controls.Add(this.textBoxDerivativeBackup1);
            this.wpDerivativeBackups.Controls.Add(this.label4);
            this.wpDerivativeBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpDerivativeBackups.IsFinishPage = false;
            this.wpDerivativeBackups.Location = new System.Drawing.Point(0, 0);
            this.wpDerivativeBackups.Name = "wpDerivativeBackups";
            this.wpDerivativeBackups.Size = new System.Drawing.Size(912, 474);
            this.wpDerivativeBackups.TabIndex = 20;
            this.wpDerivativeBackups.ShowFromNext += new System.EventHandler(this.wpDerivativeBackups_ShowFromNext);
            // 
            // buttonDerivativePathBrowse
            // 
            this.buttonDerivativePathBrowse.Location = new System.Drawing.Point(802, 190);
            this.buttonDerivativePathBrowse.Name = "buttonDerivativePathBrowse";
            this.buttonDerivativePathBrowse.Size = new System.Drawing.Size(84, 31);
            this.buttonDerivativePathBrowse.TabIndex = 46;
            this.buttonDerivativePathBrowse.Text = "Browse";
            this.buttonDerivativePathBrowse.UseVisualStyleBackColor = true;
            this.buttonDerivativePathBrowse.Click += new System.EventHandler(this.buttonDerivativePathBrowse_Click);
            // 
            // textBoxDerivativeLocation
            // 
            this.textBoxDerivativeLocation.Location = new System.Drawing.Point(22, 148);
            this.textBoxDerivativeLocation.Name = "textBoxDerivativeLocation";
            this.textBoxDerivativeLocation.Size = new System.Drawing.Size(869, 27);
            this.textBoxDerivativeLocation.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 21);
            this.label18.TabIndex = 44;
            this.label18.Text = "Derivative Vailt path:";
            // 
            // checkBoxDerivativeBackup2
            // 
            this.checkBoxDerivativeBackup2.AutoSize = true;
            this.checkBoxDerivativeBackup2.Location = new System.Drawing.Point(22, 425);
            this.checkBoxDerivativeBackup2.Name = "checkBoxDerivativeBackup2";
            this.checkBoxDerivativeBackup2.Size = new System.Drawing.Size(158, 25);
            this.checkBoxDerivativeBackup2.TabIndex = 43;
            this.checkBoxDerivativeBackup2.Text = "Enable Backup 2";
            this.checkBoxDerivativeBackup2.UseVisualStyleBackColor = true;
            this.checkBoxDerivativeBackup2.CheckedChanged += new System.EventHandler(this.checkBoxDerivativeBackup2_CheckedChanged);
            // 
            // checkBoxDerivativeBackup1
            // 
            this.checkBoxDerivativeBackup1.AutoSize = true;
            this.checkBoxDerivativeBackup1.Location = new System.Drawing.Point(22, 314);
            this.checkBoxDerivativeBackup1.Name = "checkBoxDerivativeBackup1";
            this.checkBoxDerivativeBackup1.Size = new System.Drawing.Size(158, 25);
            this.checkBoxDerivativeBackup1.TabIndex = 42;
            this.checkBoxDerivativeBackup1.Text = "Enable Backup 1";
            this.checkBoxDerivativeBackup1.UseVisualStyleBackColor = true;
            this.checkBoxDerivativeBackup1.CheckedChanged += new System.EventHandler(this.checkBoxDerivativeBackup1_CheckedChanged);
            // 
            // header5
            // 
            this.header5.BackColor = System.Drawing.SystemColors.Control;
            this.header5.CausesValidation = false;
            this.header5.Description = "This will be where derivatived (new versions of the originals) images will be sto" +
    "red. Like the master vault, two optional back-ups are available.  ";
            this.header5.Dock = System.Windows.Forms.DockStyle.Top;
            this.header5.Image = ((System.Drawing.Image)(resources.GetObject("header5.Image")));
            this.header5.Location = new System.Drawing.Point(0, 0);
            this.header5.Name = "header5";
            this.header5.Size = new System.Drawing.Size(912, 94);
            this.header5.TabIndex = 39;
            this.header5.Title = "Derivative Vault";
            // 
            // buttonDerivativeBackup2
            // 
            this.buttonDerivativeBackup2.Location = new System.Drawing.Point(802, 425);
            this.buttonDerivativeBackup2.Name = "buttonDerivativeBackup2";
            this.buttonDerivativeBackup2.Size = new System.Drawing.Size(89, 30);
            this.buttonDerivativeBackup2.TabIndex = 38;
            this.buttonDerivativeBackup2.Text = "Browse";
            this.buttonDerivativeBackup2.UseVisualStyleBackColor = true;
            this.buttonDerivativeBackup2.Click += new System.EventHandler(this.buttonDerivativeBackup2_Click);
            // 
            // buttonDerivativeBackup1
            // 
            this.buttonDerivativeBackup1.Location = new System.Drawing.Point(797, 313);
            this.buttonDerivativeBackup1.Name = "buttonDerivativeBackup1";
            this.buttonDerivativeBackup1.Size = new System.Drawing.Size(94, 30);
            this.buttonDerivativeBackup1.TabIndex = 37;
            this.buttonDerivativeBackup1.Text = "Browse";
            this.buttonDerivativeBackup1.UseVisualStyleBackColor = true;
            this.buttonDerivativeBackup1.Click += new System.EventHandler(this.buttonDerivativeBackup1_Click);
            // 
            // textBoxDerivativeBackup2
            // 
            this.textBoxDerivativeBackup2.Location = new System.Drawing.Point(19, 386);
            this.textBoxDerivativeBackup2.Name = "textBoxDerivativeBackup2";
            this.textBoxDerivativeBackup2.Size = new System.Drawing.Size(872, 27);
            this.textBoxDerivativeBackup2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Backup 2 path:";
            // 
            // textBoxDerivativeBackup1
            // 
            this.textBoxDerivativeBackup1.Location = new System.Drawing.Point(22, 273);
            this.textBoxDerivativeBackup1.Name = "textBoxDerivativeBackup1";
            this.textBoxDerivativeBackup1.Size = new System.Drawing.Size(869, 27);
            this.textBoxDerivativeBackup1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Backup 1 path:";
            // 
            // wpUserSpace
            // 
            this.wpUserSpace.Controls.Add(this.checkBoxEnableAutoCheckout);
            this.wpUserSpace.Controls.Add(this.checkBoxWorkspaceOn);
            this.wpUserSpace.Controls.Add(this.checkBoxWWWOn);
            this.wpUserSpace.Controls.Add(this.checkBoxPicturesOn);
            this.wpUserSpace.Controls.Add(this.label5);
            this.wpUserSpace.Controls.Add(this.buttonUserspace);
            this.wpUserSpace.Controls.Add(this.textBoxUserSpacePath);
            this.wpUserSpace.Controls.Add(this.header6);
            this.wpUserSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpUserSpace.IsFinishPage = false;
            this.wpUserSpace.Location = new System.Drawing.Point(0, 0);
            this.wpUserSpace.Name = "wpUserSpace";
            this.wpUserSpace.Size = new System.Drawing.Size(912, 474);
            this.wpUserSpace.TabIndex = 22;
            this.wpUserSpace.ShowFromNext += new System.EventHandler(this.wpUserSpace_ShowFromNext);
            // 
            // checkBoxEnableAutoCheckout
            // 
            this.checkBoxEnableAutoCheckout.AutoSize = true;
            this.checkBoxEnableAutoCheckout.Location = new System.Drawing.Point(229, 270);
            this.checkBoxEnableAutoCheckout.Name = "checkBoxEnableAutoCheckout";
            this.checkBoxEnableAutoCheckout.Size = new System.Drawing.Size(197, 25);
            this.checkBoxEnableAutoCheckout.TabIndex = 47;
            this.checkBoxEnableAutoCheckout.Text = "Enable Auto checkout";
            this.checkBoxEnableAutoCheckout.UseVisualStyleBackColor = true;
            this.checkBoxEnableAutoCheckout.CheckedChanged += new System.EventHandler(this.checkBoxEnableAutoCheckout_CheckedChanged);
            // 
            // checkBoxWorkspaceOn
            // 
            this.checkBoxWorkspaceOn.AutoSize = true;
            this.checkBoxWorkspaceOn.Location = new System.Drawing.Point(26, 270);
            this.checkBoxWorkspaceOn.Name = "checkBoxWorkspaceOn";
            this.checkBoxWorkspaceOn.Size = new System.Drawing.Size(143, 25);
            this.checkBoxWorkspaceOn.TabIndex = 46;
            this.checkBoxWorkspaceOn.Text = "Workspace On";
            this.checkBoxWorkspaceOn.UseVisualStyleBackColor = true;
            this.checkBoxWorkspaceOn.CheckedChanged += new System.EventHandler(this.checkBoxWorkspaceOn_CheckedChanged);
            // 
            // checkBoxWWWOn
            // 
            this.checkBoxWWWOn.AutoSize = true;
            this.checkBoxWWWOn.Location = new System.Drawing.Point(26, 304);
            this.checkBoxWWWOn.Name = "checkBoxWWWOn";
            this.checkBoxWWWOn.Size = new System.Drawing.Size(107, 25);
            this.checkBoxWWWOn.TabIndex = 45;
            this.checkBoxWWWOn.Text = "WWW On";
            this.checkBoxWWWOn.UseVisualStyleBackColor = true;
            this.checkBoxWWWOn.CheckedChanged += new System.EventHandler(this.checkBoxWWWOn_CheckedChanged);
            // 
            // checkBoxPicturesOn
            // 
            this.checkBoxPicturesOn.AutoSize = true;
            this.checkBoxPicturesOn.Location = new System.Drawing.Point(26, 339);
            this.checkBoxPicturesOn.Name = "checkBoxPicturesOn";
            this.checkBoxPicturesOn.Size = new System.Drawing.Size(121, 25);
            this.checkBoxPicturesOn.TabIndex = 44;
            this.checkBoxPicturesOn.Text = "Pictures On";
            this.checkBoxPicturesOn.UseVisualStyleBackColor = true;
            this.checkBoxPicturesOn.CheckedChanged += new System.EventHandler(this.checkBoxPicturesOn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "User space location:";
            // 
            // buttonUserspace
            // 
            this.buttonUserspace.Location = new System.Drawing.Point(542, 219);
            this.buttonUserspace.Name = "buttonUserspace";
            this.buttonUserspace.Size = new System.Drawing.Size(120, 34);
            this.buttonUserspace.TabIndex = 42;
            this.buttonUserspace.Text = "Browse";
            this.buttonUserspace.UseVisualStyleBackColor = true;
            this.buttonUserspace.Click += new System.EventHandler(this.buttonUserspace_Click);
            // 
            // textBoxUserSpacePath
            // 
            this.textBoxUserSpacePath.Location = new System.Drawing.Point(26, 180);
            this.textBoxUserSpacePath.Name = "textBoxUserSpacePath";
            this.textBoxUserSpacePath.Size = new System.Drawing.Size(636, 27);
            this.textBoxUserSpacePath.TabIndex = 41;
            // 
            // header6
            // 
            this.header6.BackColor = System.Drawing.SystemColors.Control;
            this.header6.CausesValidation = false;
            this.header6.Description = "This page allows you to set the action FMM carry out when FMM is reached.";
            this.header6.Dock = System.Windows.Forms.DockStyle.Top;
            this.header6.Image = ((System.Drawing.Image)(resources.GetObject("header6.Image")));
            this.header6.Location = new System.Drawing.Point(0, 0);
            this.header6.Name = "header6";
            this.header6.Size = new System.Drawing.Size(912, 94);
            this.header6.TabIndex = 40;
            this.header6.Title = "User Space";
            // 
            // wpApply
            // 
            this.wpApply.Controls.Add(this.buttonApply);
            this.wpApply.Controls.Add(this.groupBox5);
            this.wpApply.Controls.Add(this.groupBox3);
            this.wpApply.Controls.Add(this.header7);
            this.wpApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpApply.IsFinishPage = false;
            this.wpApply.Location = new System.Drawing.Point(0, 0);
            this.wpApply.Name = "wpApply";
            this.wpApply.Size = new System.Drawing.Size(912, 474);
            this.wpApply.TabIndex = 24;
            this.wpApply.CloseFromNext += new IDK.Gui.Wizard.PageEventHandler(this.wpApply_CloseFromNext);
            this.wpApply.ShowFromNext += new System.EventHandler(this.wpApply_ShowFromNext);
            this.wpApply.Leave += new System.EventHandler(this.wpApply_Leave);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(768, 453);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(120, 35);
            this.buttonApply.TabIndex = 44;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceCheckout);
            this.groupBox5.Controls.Add(this.checkBoxWorkspaceEnabled);
            this.groupBox5.Controls.Add(this.checkBoxWWWEnabled);
            this.groupBox5.Controls.Add(this.checkBoxPicturesEnabled);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBoxUserSpaceLocation);
            this.groupBox5.Location = new System.Drawing.Point(467, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(426, 322);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Space";
            // 
            // checkBoxWorkspaceCheckout
            // 
            this.checkBoxWorkspaceCheckout.AutoSize = true;
            this.checkBoxWorkspaceCheckout.Location = new System.Drawing.Point(195, 172);
            this.checkBoxWorkspaceCheckout.Name = "checkBoxWorkspaceCheckout";
            this.checkBoxWorkspaceCheckout.ReadOnly = false;
            this.checkBoxWorkspaceCheckout.Size = new System.Drawing.Size(197, 25);
            this.checkBoxWorkspaceCheckout.TabIndex = 53;
            this.checkBoxWorkspaceCheckout.Text = "Enable Auto checkout";
            this.checkBoxWorkspaceCheckout.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkspaceEnabled
            // 
            this.checkBoxWorkspaceEnabled.AutoSize = true;
            this.checkBoxWorkspaceEnabled.Location = new System.Drawing.Point(14, 172);
            this.checkBoxWorkspaceEnabled.Name = "checkBoxWorkspaceEnabled";
            this.checkBoxWorkspaceEnabled.ReadOnly = false;
            this.checkBoxWorkspaceEnabled.Size = new System.Drawing.Size(143, 25);
            this.checkBoxWorkspaceEnabled.TabIndex = 52;
            this.checkBoxWorkspaceEnabled.Text = "Workspace On";
            this.checkBoxWorkspaceEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxWWWEnabled
            // 
            this.checkBoxWWWEnabled.AutoSize = true;
            this.checkBoxWWWEnabled.Location = new System.Drawing.Point(14, 206);
            this.checkBoxWWWEnabled.Name = "checkBoxWWWEnabled";
            this.checkBoxWWWEnabled.ReadOnly = false;
            this.checkBoxWWWEnabled.Size = new System.Drawing.Size(107, 25);
            this.checkBoxWWWEnabled.TabIndex = 51;
            this.checkBoxWWWEnabled.Text = "WWW On";
            this.checkBoxWWWEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxPicturesEnabled
            // 
            this.checkBoxPicturesEnabled.AutoSize = true;
            this.checkBoxPicturesEnabled.Location = new System.Drawing.Point(14, 243);
            this.checkBoxPicturesEnabled.Name = "checkBoxPicturesEnabled";
            this.checkBoxPicturesEnabled.ReadOnly = false;
            this.checkBoxPicturesEnabled.Size = new System.Drawing.Size(121, 25);
            this.checkBoxPicturesEnabled.TabIndex = 50;
            this.checkBoxPicturesEnabled.Text = "Pictures On";
            this.checkBoxPicturesEnabled.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 21);
            this.label14.TabIndex = 49;
            this.label14.Text = "User space location:";
            // 
            // textBoxUserSpaceLocation
            // 
            this.textBoxUserSpaceLocation.Location = new System.Drawing.Point(14, 82);
            this.textBoxUserSpaceLocation.Name = "textBoxUserSpaceLocation";
            this.textBoxUserSpaceLocation.ReadOnly = true;
            this.textBoxUserSpaceLocation.Size = new System.Drawing.Size(399, 27);
            this.textBoxUserSpaceLocation.TabIndex = 48;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.checkBoxDeivativeBackup1Enabled);
            this.groupBox3.Controls.Add(this.checkBoxDeivativeBackup2Enabled);
            this.groupBox3.Controls.Add(this.checkBoxMasterBackup1Enabled);
            this.groupBox3.Controls.Add(this.checkBoxMasterBackup2Enabled);
            this.groupBox3.Controls.Add(this.buttonShowDerivativeBackups);
            this.groupBox3.Controls.Add(this.buttonShowMasterBackups);
            this.groupBox3.Controls.Add(this.textBoxDerivativePath);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBoxMasterPath);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(16, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 367);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vault";
            // 
            // checkBoxDeivativeBackup1Enabled
            // 
            this.checkBoxDeivativeBackup1Enabled.AutoSize = true;
            this.checkBoxDeivativeBackup1Enabled.Location = new System.Drawing.Point(19, 300);
            this.checkBoxDeivativeBackup1Enabled.Name = "checkBoxDeivativeBackup1Enabled";
            this.checkBoxDeivativeBackup1Enabled.ReadOnly = false;
            this.checkBoxDeivativeBackup1Enabled.Size = new System.Drawing.Size(167, 25);
            this.checkBoxDeivativeBackup1Enabled.TabIndex = 56;
            this.checkBoxDeivativeBackup1Enabled.Text = "Backup 1 Enabled";
            this.checkBoxDeivativeBackup1Enabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeivativeBackup2Enabled
            // 
            this.checkBoxDeivativeBackup2Enabled.AutoSize = true;
            this.checkBoxDeivativeBackup2Enabled.Location = new System.Drawing.Point(19, 335);
            this.checkBoxDeivativeBackup2Enabled.Name = "checkBoxDeivativeBackup2Enabled";
            this.checkBoxDeivativeBackup2Enabled.ReadOnly = false;
            this.checkBoxDeivativeBackup2Enabled.Size = new System.Drawing.Size(167, 25);
            this.checkBoxDeivativeBackup2Enabled.TabIndex = 55;
            this.checkBoxDeivativeBackup2Enabled.Text = "Backup 2 Enabled";
            this.checkBoxDeivativeBackup2Enabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasterBackup1Enabled
            // 
            this.checkBoxMasterBackup1Enabled.AutoSize = true;
            this.checkBoxMasterBackup1Enabled.Location = new System.Drawing.Point(19, 124);
            this.checkBoxMasterBackup1Enabled.Name = "checkBoxMasterBackup1Enabled";
            this.checkBoxMasterBackup1Enabled.ReadOnly = false;
            this.checkBoxMasterBackup1Enabled.Size = new System.Drawing.Size(167, 25);
            this.checkBoxMasterBackup1Enabled.TabIndex = 54;
            this.checkBoxMasterBackup1Enabled.Text = "Backup 1 Enabled";
            this.checkBoxMasterBackup1Enabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasterBackup2Enabled
            // 
            this.checkBoxMasterBackup2Enabled.AutoSize = true;
            this.checkBoxMasterBackup2Enabled.Location = new System.Drawing.Point(19, 158);
            this.checkBoxMasterBackup2Enabled.Name = "checkBoxMasterBackup2Enabled";
            this.checkBoxMasterBackup2Enabled.ReadOnly = false;
            this.checkBoxMasterBackup2Enabled.Size = new System.Drawing.Size(167, 25);
            this.checkBoxMasterBackup2Enabled.TabIndex = 53;
            this.checkBoxMasterBackup2Enabled.Text = "Backup 2 Enabled";
            this.checkBoxMasterBackup2Enabled.UseVisualStyleBackColor = true;
            // 
            // buttonShowDerivativeBackups
            // 
            this.buttonShowDerivativeBackups.Location = new System.Drawing.Point(235, 300);
            this.buttonShowDerivativeBackups.Name = "buttonShowDerivativeBackups";
            this.buttonShowDerivativeBackups.Size = new System.Drawing.Size(192, 35);
            this.buttonShowDerivativeBackups.TabIndex = 49;
            this.buttonShowDerivativeBackups.Text = "Show Backups";
            this.buttonShowDerivativeBackups.UseVisualStyleBackColor = true;
            this.buttonShowDerivativeBackups.Click += new System.EventHandler(this.buttonShowDerivativeBackups_Click);
            // 
            // buttonShowMasterBackups
            // 
            this.buttonShowMasterBackups.Location = new System.Drawing.Point(235, 117);
            this.buttonShowMasterBackups.Name = "buttonShowMasterBackups";
            this.buttonShowMasterBackups.Size = new System.Drawing.Size(192, 34);
            this.buttonShowMasterBackups.TabIndex = 48;
            this.buttonShowMasterBackups.Text = "Show Backups";
            this.buttonShowMasterBackups.UseVisualStyleBackColor = true;
            this.buttonShowMasterBackups.Click += new System.EventHandler(this.buttonShowMasterBackups_Click);
            // 
            // textBoxDerivativePath
            // 
            this.textBoxDerivativePath.Location = new System.Drawing.Point(19, 253);
            this.textBoxDerivativePath.Name = "textBoxDerivativePath";
            this.textBoxDerivativePath.ReadOnly = true;
            this.textBoxDerivativePath.Size = new System.Drawing.Size(408, 27);
            this.textBoxDerivativePath.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 21);
            this.label15.TabIndex = 46;
            this.label15.Text = "Derivative Vailt path:";
            // 
            // textBoxMasterPath
            // 
            this.textBoxMasterPath.Location = new System.Drawing.Point(18, 79);
            this.textBoxMasterPath.Name = "textBoxMasterPath";
            this.textBoxMasterPath.ReadOnly = true;
            this.textBoxMasterPath.Size = new System.Drawing.Size(409, 27);
            this.textBoxMasterPath.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 21);
            this.label16.TabIndex = 44;
            this.label16.Text = "Master Vault path:";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(458, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 367);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // header7
            // 
            this.header7.BackColor = System.Drawing.SystemColors.Control;
            this.header7.CausesValidation = false;
            this.header7.Description = "Review Archive settup and apply of satified";
            this.header7.Dock = System.Windows.Forms.DockStyle.Top;
            this.header7.Image = ((System.Drawing.Image)(resources.GetObject("header7.Image")));
            this.header7.Location = new System.Drawing.Point(0, 0);
            this.header7.Name = "header7";
            this.header7.Size = new System.Drawing.Size(912, 94);
            this.header7.TabIndex = 41;
            this.header7.Title = "Summary and Apply";
            // 
            // wpFinish
            // 
            this.wpFinish.Controls.Add(this.infoContainerOptionsPage);
            this.wpFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpFinish.IsFinishPage = true;
            this.wpFinish.Location = new System.Drawing.Point(0, 0);
            this.wpFinish.Name = "wpFinish";
            this.wpFinish.Size = new System.Drawing.Size(912, 474);
            this.wpFinish.TabIndex = 8;
            // 
            // infoContainerOptionsPage
            // 
            this.infoContainerOptionsPage.BackColor = System.Drawing.Color.White;
            this.infoContainerOptionsPage.Controls.Add(this.label9);
            this.infoContainerOptionsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoContainerOptionsPage.Image = global::IDK.Gui.Properties.Resources.Bitmap3;
            this.infoContainerOptionsPage.Location = new System.Drawing.Point(0, 0);
            this.infoContainerOptionsPage.Name = "infoContainerOptionsPage";
            this.infoContainerOptionsPage.PageTitle = "Final Setup Completed Successfully!";
            this.infoContainerOptionsPage.Size = new System.Drawing.Size(912, 474);
            this.infoContainerOptionsPage.TabIndex = 0;
            this.infoContainerOptionsPage.Load += new System.EventHandler(this.FinalPage_Load);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(190, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(677, 107);
            this.label9.TabIndex = 12;
            // 
            // wpSummary
            // 
            this.wpSummary.Controls.Add(this.groupBox1);
            this.wpSummary.Controls.Add(this.checkBox1);
            this.wpSummary.Controls.Add(this.checkBox2);
            this.wpSummary.Controls.Add(this.checkBox3);
            this.wpSummary.Controls.Add(this.checkBox4);
            this.wpSummary.Controls.Add(this.label6);
            this.wpSummary.Controls.Add(this.textBox1);
            this.wpSummary.Controls.Add(this.header1);
            this.wpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpSummary.IsFinishPage = false;
            this.wpSummary.Location = new System.Drawing.Point(0, 0);
            this.wpSummary.Name = "wpSummary";
            this.wpSummary.Size = new System.Drawing.Size(916, 545);
            this.wpSummary.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(16, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 372);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vault";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 35);
            this.button2.TabIndex = 59;
            this.button2.Text = "Show Backups";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 35);
            this.button1.TabIndex = 58;
            this.button1.Text = "Show Backups";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 27);
            this.textBox2.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Derivative Vailt path:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(366, 27);
            this.textBox3.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 21);
            this.label10.TabIndex = 54;
            this.label10.Text = "Master Vault path:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(672, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 25);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Enable Auto checkout";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(467, 297);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 25);
            this.checkBox2.TabIndex = 52;
            this.checkBox2.Text = "Workspace On";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(467, 330);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 25);
            this.checkBox3.TabIndex = 51;
            this.checkBox3.Text = "WWW On";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(467, 365);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 25);
            this.checkBox4.TabIndex = 50;
            this.checkBox4.Text = "Pictures On";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 49;
            this.label6.Text = "User space location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 27);
            this.textBox1.TabIndex = 48;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.Control;
            this.header1.CausesValidation = false;
            this.header1.Controls.Add(this.groupBox2);
            this.header1.Description = "This page allows you to set the action FMM carry out when FMM is reached.";
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Image = ((System.Drawing.Image)(resources.GetObject("header1.Image")));
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(916, 94);
            this.header1.TabIndex = 41;
            this.header1.Title = "Summary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(251, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 371);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vault";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 35);
            this.button3.TabIndex = 59;
            this.button3.Text = "Show Backups";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 35);
            this.button4.TabIndex = 58;
            this.button4.Text = "Show Backups";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(364, 27);
            this.textBox4.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Derivative Vailt path:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(366, 27);
            this.textBox5.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Master Vault path:";
            // 
            // FMMRegistration
            // 
            this.FMMRegistration.Controls.Add(this.wizardPage1);
            this.FMMRegistration.Controls.Add(this.buttonShareware);
            this.FMMRegistration.Controls.Add(this.label26);
            this.FMMRegistration.Controls.Add(this.textBox19);
            this.FMMRegistration.Controls.Add(this.textBox18);
            this.FMMRegistration.Controls.Add(this.textBox17);
            this.FMMRegistration.Controls.Add(this.textBox16);
            this.FMMRegistration.Controls.Add(this.textBox15);
            this.FMMRegistration.Controls.Add(this.label25);
            this.FMMRegistration.Controls.Add(this.header9);
            this.FMMRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FMMRegistration.IsFinishPage = false;
            this.FMMRegistration.Location = new System.Drawing.Point(0, 0);
            this.FMMRegistration.Name = "FMMRegistration";
            this.FMMRegistration.Size = new System.Drawing.Size(916, 545);
            this.FMMRegistration.TabIndex = 14;
            // 
            // wizardPage1
            // 
            this.wizardPage1.IsFinishPage = false;
            this.wizardPage1.Location = new System.Drawing.Point(51, 387);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(202, 101);
            this.wizardPage1.TabIndex = 32;
            // 
            // buttonShareware
            // 
            this.buttonShareware.Location = new System.Drawing.Point(542, 330);
            this.buttonShareware.Name = "buttonShareware";
            this.buttonShareware.Size = new System.Drawing.Size(120, 34);
            this.buttonShareware.TabIndex = 31;
            this.buttonShareware.Text = "Shareware";
            this.buttonShareware.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(75, 241);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 21);
            this.label26.TabIndex = 30;
            this.label26.Text = "Registration:";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(392, 265);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(94, 27);
            this.textBox19.TabIndex = 29;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(288, 265);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(94, 27);
            this.textBox18.TabIndex = 28;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(184, 265);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(94, 27);
            this.textBox17.TabIndex = 27;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(80, 265);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(94, 27);
            this.textBox16.TabIndex = 26;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(184, 152);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(189, 27);
            this.textBox15.TabIndex = 23;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(75, 156);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 21);
            this.label25.TabIndex = 22;
            this.label25.Text = "User name:";
            // 
            // header9
            // 
            this.header9.BackColor = System.Drawing.SystemColors.Control;
            this.header9.CausesValidation = false;
            this.header9.Description = "This wizard page is used to setup the ImgArchive License. This License code may b" +
    "e foundIf you are trying out the product as shareware click thethe Shareware but" +
    "ton.";
            this.header9.Dock = System.Windows.Forms.DockStyle.Top;
            this.header9.Image = ((System.Drawing.Image)(resources.GetObject("header9.Image")));
            this.header9.Location = new System.Drawing.Point(0, 0);
            this.header9.Name = "header9";
            this.header9.Size = new System.Drawing.Size(916, 94);
            this.header9.TabIndex = 4;
            this.header9.Title = "FMM Registration";
            // 
            // WizardForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(916, 545);
            this.Controls.Add(this.ImgArchiveWizard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(938, 601);
            this.MinimumSize = new System.Drawing.Size(938, 601);
            this.Name = "WizardForm";
            this.Text = "ImgArchive 1.0 - Setup Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ImgArchiveWizard.ResumeLayout(false);
            this.WelcomePage.ResumeLayout(false);
            this.infoContainer1.ResumeLayout(false);
            this.wpMasterBackups.ResumeLayout(false);
            this.wpMasterBackups.PerformLayout();
            this.wpDerivativeBackups.ResumeLayout(false);
            this.wpDerivativeBackups.PerformLayout();
            this.wpUserSpace.ResumeLayout(false);
            this.wpUserSpace.PerformLayout();
            this.wpApply.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.wpFinish.ResumeLayout(false);
            this.infoContainerOptionsPage.ResumeLayout(false);
            this.wpSummary.ResumeLayout(false);
            this.wpSummary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.header1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.FMMRegistration.ResumeLayout(false);
            this.FMMRegistration.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
            Application.Run(new WizardForm());
		}

        public String Location { get { return location; } }

        public string ExePath { get => m_exePath; set => m_exePath = value; }
        public string WorkingPath { get => m_workingPath; set => m_workingPath = value; }

        XMLArchive m_xmlArchive = null;

        private void wizard1_CloseFromCancel(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (MessageBox.Show(this, 
				"Are you sure you want to close this?",
				"Wizard Cancelled", MessageBoxButtons.YesNo
				) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

       
		private void wpLicenceValidate_CloseFromBack(object sender, IDK.Gui.Wizard.PageEventArgs e)
		{
			//e.Page = OptionsPage;
		}

        private async void Form1_Load(object sender, EventArgs e)
        {

            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.ExePath = ExePath;
            launchCommand.Path = m_workingPath;
            launchCommand.Arguments = "show --silent --setting=archive --format-type=xml";
            launchCommand.FilePath = filePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            m_xmlArchive = new XMLArchive(output);
            m_xmlArchive.Process();
            ArchiveObject archiveObject = m_xmlArchive.Archive;
            
            ArchiveObject.VaultObject vault = archiveObject.Vault;
            /*
            m_defaultParameters.MasterPath = Vault.MasterArchive.ArchiveLocation.LocationPath;
            m_defaultParameters.MasterBackup1Enable = Vault.MasterArchive.Backup1.Enabled;
            m_defaultParameters.MasterBackup1Path = Vault.MasterArchive.Backup1.BackupLocation.LocationPath;
            m_defaultParameters.MasterBackup2Enable = Vault.MasterArchive.Backup2.Enabled;
            m_defaultParameters.MasterBackup2Path = Vault.MasterArchive.Backup2.BackupLocation.LocationPath;
            
            m_defaultParameters.DerivertivePath = Vault.DerivativeArchive.ArchiveLocation.LocationPath;
            m_defaultParameters.DerivertiveBackup1Enable = Vault.DerivativeArchive.Backup1.Enabled;
            m_defaultParameters.DerivertiveBackup1Path = Vault.DerivativeArchive.Backup1.BackupLocation.LocationPath;
            m_defaultParameters.DerivertiveBackup2Enable = Vault.DerivativeArchive.Backup2.Enabled;
            m_defaultParameters.DerivertiveBackup2Path = Vault.DerivativeArchive.Backup2.BackupLocation.LocationPath;

            Userspace Userspace = ArchiveProperties.Userspace;
            m_defaultParameters.UserspacePath = Userspace.UserspaceLocation.LocationPath;
            m_defaultParameters.WorkspaceOn = Userspace.Workspace.AutoView;
            m_defaultParameters.PicturesOn = Userspace.Picture.AutoView;
            m_defaultParameters.WWWOn = Userspace.WWWImages.AutoView;
            */
        }

       
        
        

        

        public async Task<int> ProgressData()
        {

            m_exePath = "C:\\Program Files\\IDK-Software\\imgarchive";
            m_workingPath = "C:\\TEMP";
            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.ExePath = m_exePath;
            launchCommand.Path = m_workingPath;

            launchCommand.Arguments = "Help";
            await launchCommand.LaunchCommand();

            LaunchAdmin.ExitCode exitCode = launchCommand.ProcessExitCode;
                
                switch (exitCode)
                {
                    case LaunchAdmin.ExitCode.Success:
                        
                        break;
                    case LaunchAdmin.ExitCode.Warnings:
                        
                        break;
                    case LaunchAdmin.ExitCode.Errors:
                        
                        break;
                    case LaunchAdmin.ExitCode.Fatal:
                        
                        break;
                    default:
                        
                        break;
                }

            //ProgressChanged();
            m_output = launchCommand.Output;

            return 42;
        }

        

       

       

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                textBoxUserSpacePath.Text = folderBrowser.SelectedPath;
                location = folderBrowser.SelectedPath;
                
            }
        }

        private void textBoxLibraryLocalion_TextChanged(object sender, EventArgs e)
        {
            //location = textBoxLibraryocalion.Text;
        }

        

        private void wdPageReposities_ShowFromNext(object sender, EventArgs e)
        {
            Trace.WriteLine("wdPageReposities_ShowFromNext");

            

            //textBoxMasterFolder.Text = m_defaultParameters.MasterPath;
            //textBoxDerivativeFolder.Text = m_defaultParameters.DerivertivePath;
        }

        private void masterBrowseButtton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("masterBrowseButtton_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                //textBoxMasterFolder.Text = folderBrowser.SelectedPath;
            }
        }

       

        private void wpMasterBackups_ShowFromBack(object sender, EventArgs e)
        {

        }

        private async void wpMasterBackups_ShowFromNext(object sender, EventArgs e)
        {
            Trace.WriteLine("wpMasterBackups_ShowFromNext"); // here
           
            ArchiveObject archiveObject = m_xmlArchive.Archive;

            // Master
            textBoxMasterLocation.Text = archiveObject.Vault.Master.Path;

            bool masterBackupOneEnabled = ArchiveObject.isEnabled(archiveObject.Vault.Master.BackupOne.Enabled);
            checkBoxMasterEnableBackup1.Checked = masterBackupOneEnabled;
            textBoxMasterBackup1.Text = archiveObject.Vault.Master.BackupOne.Path; //m_defaultParameters.MasterBackup1Path;
            bool masterBackupTwoEnabled = ArchiveObject.isEnabled(archiveObject.Vault.Master.BackupTwo.Enabled);
            checkBoxMasterEnableBackup2.Checked = masterBackupTwoEnabled;
            textBoxMasterBackup2.Text = archiveObject.Vault.Master.BackupTwo.Path;
        }

        private void buttonMasterLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                
                string temp = textBoxMasterLocation.Text;
                textBoxMasterLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxMasterLocation.Text) != 0)
                {
                    changesList.MasterPathChanged = true;
                }
            }
        }

        private void buttonMasterBackup1_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup1_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                string temp = textBoxMasterBackup1.Text;
                textBoxMasterBackup1.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxMasterBackup1.Text) != 0)
                {
                    changesList.MasterBackup1PathChanged = true;
                }
            }
        }

        private void buttonMasterBackup2_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                string temp = textBoxMasterBackup2.Text;
                textBoxMasterBackup2.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxMasterBackup2.Text) != 0)
                {
                    changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void checkBoxMasterEnableBackup1_CheckedChanged(object sender, EventArgs e)
        {
            changesList.MasterBackup1EnabledChanged = true;
        }

        private void checkBoxMasterEnableBackup2_CheckedChanged(object sender, EventArgs e)
        {
            changesList.MasterBackup2EnabledChanged = true;
        }
        private void wpDerivativeBackups_ShowFromNext(object sender, EventArgs e)
        {
            ArchiveObject archiveObject = m_xmlArchive.Archive;

            Trace.WriteLine("wpDerivativeBackups_ShowFromNext");
            textBoxDerivativeLocation.Text = archiveObject.Vault.Derivative.Path;

            bool derivativeBackupOneEnabled = ArchiveObject.isEnabled(archiveObject.Vault.Derivative.BackupOne.Enabled);
            checkBoxDerivativeBackup1.Checked = derivativeBackupOneEnabled;
            textBoxDerivativeBackup1.Text = archiveObject.Vault.Derivative.BackupOne.Path; //m_defaultParameters.MasterBackup1Path;
            bool derivativeBackupTwoEnabled = ArchiveObject.isEnabled(archiveObject.Vault.Derivative.BackupTwo.Enabled);
            checkBoxDerivativeBackup2.Checked = derivativeBackupTwoEnabled;
            textBoxDerivativeBackup2.Text = archiveObject.Vault.Derivative.BackupTwo.Path;
        }

        /*
        private void DerivativeBrowsebutton_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("DerivativeBrowsebutton_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                textBoxDerivativeLocation.Text = folderBrowser.SelectedPath;
            }
        }
        */
        
        private void buttonDerivativePathBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                string temp = textBoxDerivativeLocation.Text;
                textBoxDerivativeLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxDerivativeLocation.Text) != 0)
                {
                    changesList.DerivativePathChanged = true;
                }

            }
        }

        private void buttonDerivativeBackup1_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                string temp = textBoxDerivativeBackup1.Text;
                textBoxDerivativeBackup1.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxDerivativeBackup1.Text) != 0)
                {
                    changesList.DerivativeBackup1PathChanged = true;
                }
            }
        }

        private void buttonDerivativeBackup2_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                string temp = textBoxDerivativeBackup2.Text;
                textBoxDerivativeBackup2.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxDerivativeBackup2.Text) != 0)
                {
                    changesList.DerivativeBackup2PathChanged = true;
                }
            }
        }

        private void checkBoxDerivativeBackup1_CheckedChanged(object sender, EventArgs e)
        {
            changesList.DeivativeBackup1EnabledChanged = true;
        }

        private void checkBoxDerivativeBackup2_CheckedChanged(object sender, EventArgs e)
        {
            changesList.DeivativeBackup2EnabledChanged = true;
        }
        private void wpUserSpace_ShowFromNext(object sender, EventArgs e)
        {
            ArchiveObject archiveObject = m_xmlArchive.Archive;
            textBoxUserSpacePath.Text = archiveObject.UserSpace.Path;
            Trace.WriteLine("wpDerivativeBackups_ShowFromNext");
            //bool WorkspaceOn = true;
            checkBoxWorkspaceOn.Checked = ArchiveObject.isAutoView(archiveObject.UserSpace.Workspace.AutoView);
            //bool EnableAutoCheckout = true;
            checkBoxEnableAutoCheckout.Checked = ArchiveObject.isAutoCheckout(archiveObject.UserSpace.Workspace.AutoCheckout);
            //bool WWWOn = true;
            checkBoxWWWOn.Checked = ArchiveObject.isAutoView(archiveObject.UserSpace.WWWImages.AutoView); ;
            //bool PicturesOn = true;
            checkBoxPicturesOn.Checked = ArchiveObject.isAutoView(archiveObject.UserSpace.Pictures.AutoView); ;
            textBoxUserSpacePath.Text = archiveObject.UserSpace.Path;
           
        }

        private void buttonUserspace_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (location != null)
                {
                    folderBrowser.SelectedPath = location;
                }
                
                string temp = textBoxUserSpacePath.Text;
                textBoxUserSpacePath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxUserSpacePath.Text) != 0)
                {
                    changesList.UserSpaceLocationChanged = true;
                }
            }
        }

        private void checkBoxWorkspaceOn_CheckedChanged(object sender, EventArgs e)
        {
            changesList.WorkspaceEnabledChanged = true;
        }

        

        private void checkBoxPicturesOn_CheckedChanged(object sender, EventArgs e)
        {
            changesList.PicturesEnabledChanged = true;
        }

        private void checkBoxEnableAutoCheckout_CheckedChanged(object sender, EventArgs e)
        {
            changesList.WorkspaceCheckoutChanged = true;
        }
        private void checkBoxWWWOn_CheckedChanged(object sender, EventArgs e)
        {
            changesList.WWWEnabledChanged = true;
        }
        private async void timerProcess_Tick(object sender, EventArgs e)
        {
            timerProcess.Stop();
            await ProgressData();
            Trace.WriteLine(m_output);
        }

        private void infoContainerOptionsPage_Load(object sender, EventArgs e)
        {

        }

        private void infoContainer1_Leave(object sender, EventArgs e)
        {
            Trace.WriteLine("infoContainer1_Leave");
        }

        
        bool ischanged = false;
        bool isApplied = false;
        private void wpApply_ShowFromNext(object sender, EventArgs e)
        {
            //if (isChanges()) {
            //    ischanged = true;
            //}

            
            textBoxMasterPath.Text = textBoxMasterLocation.Text;
            checkBoxMasterBackup1Enabled.Checked = checkBoxMasterEnableBackup1.Checked;
            //textBoxMasterBackup1.Text;
            checkBoxMasterBackup2Enabled.Checked = checkBoxMasterEnableBackup2.Checked;
            //textBoxMasterBackup2.Text;

            textBoxDerivativePath.Text = textBoxDerivativeLocation.Text;

            checkBoxDeivativeBackup1Enabled.Checked = checkBoxDerivativeBackup1.Checked;
            //textBoxDerivativeBackup1.Text;

            checkBoxDeivativeBackup2Enabled.Checked = checkBoxDerivativeBackup2.Checked;
            //textBoxDerivativeBackup2.Text;
            textBoxUserSpaceLocation.Text = textBoxUserSpacePath.Text;
            checkBoxWorkspaceEnabled.Checked = checkBoxWorkspaceOn.Checked;
            checkBoxWorkspaceEnabled.ReadOnly = true;

            checkBoxWorkspaceCheckout.Checked = checkBoxEnableAutoCheckout.Checked;
            checkBoxWorkspaceCheckout.ReadOnly = true;
            checkBoxWWWEnabled.Checked = checkBoxWWWOn.Checked;
            checkBoxWWWEnabled.ReadOnly = true;
            checkBoxPicturesEnabled.Checked = checkBoxPicturesOn.Checked;
            checkBoxPicturesEnabled.ReadOnly = true;
        }

        private void buttonShowMasterBackups_Click(object sender, EventArgs e)
        {
           
            (new BackupsForm("Master Backups", textBoxMasterBackup1.Text, textBoxMasterBackup2.Text)).Show();
        }

        private void buttonShowDerivativeBackups_Click(object sender, EventArgs e)
        {
            (new BackupsForm("Derivative Backups", textBoxDerivativeBackup1.Text, textBoxDerivativeBackup2.Text)).Show();
        }

        bool returned = true;
        private async void UpdateArchive(string arg)
        {
            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.ExePath = ExePath;
            launchCommand.Path = m_workingPath;
            launchCommand.Arguments = arg;
            launchCommand.FilePath = filePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            LaunchAdmin.ExitCode exitCode = launchCommand.ProcessExitCode;
            string exitText = "Ok";
            bool fatal = false;
            switch (exitCode)
            {
                case LaunchAdmin.ExitCode.Success:
                    return;
                case LaunchAdmin.ExitCode.Warnings:
                    exitText = "Command returned Warning";
                    break;
                case LaunchAdmin.ExitCode.Errors:
                    exitText = "Command returned Errors";
                    break;
                case LaunchAdmin.ExitCode.Fatal:
                    exitText = "Command returned Fatal";
                    fatal = true;
                    break;
                default:
                    
                    break;
            }
            int pos = 0;
            
            pos = output.IndexOf('-');
            string returnString = output.Substring(pos + 2, output.Length - (pos + 2));
            
            if (MessageBox.Show(this,
                    returnString + " Continue (Yes/No)",
                    exitText, MessageBoxButtons.YesNo
                    ) == DialogResult.Yes)
            {
                returned = true;
            }
            returned = false;
           
            
        }

        string isChecked(bool b)
        {
            return ((b) ? "True" : "False"); 
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (changesList.MasterPathChanged)
            {
                UpdateArchive("config --folders MasterPath=" + textBoxMasterPath.Text);
                Trace.WriteLine("MasterPathChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (changesList.MasterBackup1EnabledChanged)
            {
                UpdateArchive("config --master BackupOneEnabled=" + isChecked(checkBoxMasterBackup1Enabled.Checked));
                Trace.WriteLine("MasterBackup1EnabledChanged");
                if (!returned)
                {
                    return;
                }
                
            }
            if (changesList.MasterBackup2EnabledChanged)
            {
                UpdateArchive("config --master BackupTwoEnabled=" + isChecked(checkBoxMasterBackup2Enabled.Checked));
                Trace.WriteLine("MasterBackup2EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (changesList.MasterBackup1PathChanged)
            {
                UpdateArchive("config --master BackupOne=" + textBoxMasterBackup1.Text);
                Trace.WriteLine("MasterBackup1PathChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (changesList.MasterBackup2PathChanged)
            {
                UpdateArchive("config --master BackupTwo=" + textBoxMasterBackup2.Text);
                Trace.WriteLine("MasterBackup2PathChanged");
                if (!returned)
                {
                    return;
                }
            }
            //textBoxMasterBackup2.Text;
            // changesList.MasterBackup2Path = true;


            if (changesList.DerivativePathChanged)
            {
                UpdateArchive("config --folders DerivativePath=" + textBoxDerivativePath.Text);
                Trace.WriteLine("DerivativePathChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (changesList.DeivativeBackup1EnabledChanged)
            {
                UpdateArchive("config --derivative BackupOneEnabled=" + isChecked(checkBoxDeivativeBackup1Enabled.Checked));
                Trace.WriteLine("DeivativeBackup1EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            //textBoxDerivativeBackup1.Text;
            //changesList.DerivativeBackup1Path = true;
            if (changesList.DerivativeBackup1PathChanged)
            {
                UpdateArchive("config --derivative BackupOne=" + textBoxDerivativeBackup1.Text);
                Trace.WriteLine("DerivativeBackup1PathChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (changesList.DeivativeBackup2EnabledChanged)
            {
                UpdateArchive("config --derivative BackupTwoEnabled=" + isChecked(checkBoxDeivativeBackup2Enabled.Checked));
                Trace.WriteLine("DeivativeBackup2EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            //textBoxDerivativeBackup2.Text;
            //changesList.DerivativeBackup2Path = true;
            if (changesList.DerivativeBackup2PathChanged)
            {
                UpdateArchive("config --derivative BackupTwo=" + textBoxDerivativeBackup2.Text);
                Trace.WriteLine("DerivativeBackup2PathChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (changesList.UserSpaceLocationChanged)
            {
                UpdateArchive("config --folders UserspacePath=" + textBoxUserSpaceLocation.Text);
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (changesList.WorkspaceEnabledChanged)
            {
                
                UpdateArchive("config --general WorkspaceOn=" + isChecked(checkBoxWorkspaceOn.Checked));
                Trace.WriteLine("WorkspaceEnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (changesList.WorkspaceCheckoutChanged)
            {
                UpdateArchive("config --general AutoCheckoutOn=" + isChecked(checkBoxEnableAutoCheckout.Checked));
                Trace.WriteLine("WorkspaceCheckoutChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (changesList.WWWEnabledChanged)
            {
                UpdateArchive("config --general WWWCatalogue=" + isChecked(checkBoxWWWOn.Checked));
                Trace.WriteLine("WWWEnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (changesList.PicturesEnabledChanged)
            {
                UpdateArchive("config --general FileCatalogue=" + isChecked(checkBoxPicturesOn.Checked));
                Trace.WriteLine("PicturesEnabledChanged");
                if (!returned)
                {
                    return;
                }
                
            }
        }

            private void FinalPage_Load(object sender, EventArgs e)
        {
            Trace.WriteLine("FinalPage_Load");
        }

        private void wpApply_Leave(object sender, EventArgs e)
        {
            /*
            Trace.WriteLine("wpApply_Leave");
            if (MessageBox.Show(this,
                "Unapplied changes? Are you sure you want to close this?",
                "Wizard Cancelled", MessageBoxButtons.YesNo
                ) == DialogResult.Yes)
            {
                ImgArchiveWizard.Next();
                //e.Cancel = true;
            }
            */
        }

        

        private void wpApply_CloseFromNext(object sender, Wizard.PageEventArgs e)
        {
            Trace.WriteLine("wpApply_CloseFromNext");
            if (isChanges()) {
                if (MessageBox.Show(this,
                    "Unapplied changes? Are you sure you want to close this?",
                    "Unsaved Changes", MessageBoxButtons.YesNo
                    ) == DialogResult.No)
                {
                    e.Page = wpApply;
                }
            }
          
        }

        private bool isChanges()
        {
            bool res = false;
            if (string.Compare(textBoxMasterPath.Text, textBoxMasterLocation.Text) != 0)
            {
                changesList.MasterPathChanged = true;
                res = true;
            }
            if (checkBoxMasterBackup1Enabled.Checked != checkBoxMasterEnableBackup1.Checked)
            {
                changesList.MasterBackup1EnabledChanged = true;   
                res = true;
            }
            //textBoxMasterBackup1.Text;
            // changesList.MasterBackup1Path = true;
            if (checkBoxMasterBackup2Enabled.Checked != checkBoxMasterEnableBackup2.Checked)
            {
                changesList.MasterBackup2EnabledChanged = true;
                res = true;
            }
            //textBoxMasterBackup2.Text;
            // changesList.MasterBackup2Path = true;

            if (string.Compare(textBoxDerivativePath.Text, textBoxDerivativeLocation.Text) != 0)
            { 
                changesList.DerivativePathChanged = true;
                res = true;
            }

            if (checkBoxDeivativeBackup1Enabled.Checked != checkBoxDerivativeBackup1.Checked)
            {
                changesList.DeivativeBackup1EnabledChanged = true;
                res = true; 
            }
            //textBoxDerivativeBackup1.Text;
            //changesList.DerivativeBackup1Path = true;
            
           
            if (checkBoxDeivativeBackup2Enabled.Checked != checkBoxDerivativeBackup2.Checked)
            {
                changesList.DeivativeBackup2EnabledChanged = true;
                res = true;
            }
            //textBoxDerivativeBackup2.Text;
            //changesList.DerivativeBackup2Path = true;

            if (string.Compare(textBoxUserSpaceLocation.Text, textBoxUserSpacePath.Text) != 0)
            {
                changesList.UserSpaceLocationChanged = true;
                res = true;
            }
            if (checkBoxWorkspaceEnabled.Checked != checkBoxWorkspaceOn.Checked)
            {
                changesList.WorkspaceEnabledChanged = true;
                res = true;
            }


            if (checkBoxWorkspaceCheckout.Checked != checkBoxEnableAutoCheckout.Checked)
            {
                changesList.WorkspaceCheckoutChanged = true;
                res = true;
            }

            if (checkBoxWWWEnabled.Checked != checkBoxWWWOn.Checked)
            {
                changesList.WWWEnabledChanged = true;
                res = true;
            }

            if (checkBoxPicturesEnabled.Checked != checkBoxPicturesOn.Checked)
            {
                changesList.PicturesEnabledChanged = true;
                res = true;
            }
            return res;
        }

        private void ImgArchiveWizard_Load(object sender, EventArgs e)
        {

        }
    }
}
