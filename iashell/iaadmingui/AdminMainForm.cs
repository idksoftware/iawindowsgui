using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iaforms;
using IDK.Gui;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace iaadmingui
{

    


    public partial class AdminMainForm : Form
    {
        string exePath;
        string workingPath;
        ExifToolObject m_exifTool = null;

        private IViewPage m_currentView = null;
        public AdminMainForm(string workingFolder, string exeFolder)
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            UpdateChanges.WorkingPath = workPath;
            UpdateChanges.ExePath = exePath;
            UpdateChanges.FilePath = workPath;

            IAAdminInfo.WorkingPath = workPath;
            IAAdminInfo.ExePath = exePath;
            IAAdminInfo.FilePath = workPath;
            //string projFiles = Environment.GetEnvironmentVariable("ProgramFiles");
            //workPath = Environment.GetEnvironmentVariable("Temp");
            if (workPath == null)
            {
                workPath = Environment.GetEnvironmentVariable("Tmp");
            }
            //projFiles += "\\IDK-Software\\imgarchive";
            string test = exePath + "\\iaadmin.exe";
            if (File.Exists(test) == false)
            {
                MessageBox.Show(
                        "Fatal - Cannot find ImgArchive tools: " + test,
                        "ImgArchive", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }


            exePath = exeFolder;
            workingPath = workingFolder;
            InitializeComponent();

        }
        int itemNumber = 1;
        //AllowItems allowItems = null;
        private string workingFolder;
        private string exeFolder;

        private void tabMainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           Debug.WriteLine("Send to debug output.");
         
        }
        
        

        
        
        // ExifTool

        private async void LoadExifToolItems()
        {
            /*
            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.ExePath = exePath;
            launchCommand.Path = workingPath;
            launchCommand.Arguments = "show --setting=exiftool --out=xml";
            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            XMLExifTool xmlExifTool = new XMLExifTool(output);
            xmlExifTool.Process();
            m_exifTool = xmlExifTool.ExifTool;
            textBoxExifToolApplication.Text = m_exifTool.ExifTool;
            textBoxExifToolAppPath.Text = m_exifTool.ExifToolPath;
            textBoxExifToolAppCommandLine.Text = m_exifTool.CommandLine;
            */
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            
        }

        private void configationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ConfigForm(workingFolder, exeFolder)).Show();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }

        private void wizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;

            //string projFiles = Environment.GetEnvironmentVariable("ProgramFiles");
            //workPath = Environment.GetEnvironmentVariable("Temp");
            if (workPath == null)
            {
                workPath = Environment.GetEnvironmentVariable("Tmp");
            }
            //projFiles += "\\IDK-Software\\imgarchive";
            string test = exePath + "\\iaadmin.exe";
            if (File.Exists(test) == false)
            {
                MessageBox.Show(
                        "Fatal - Cannot find ImgArchive tools: " + test,
                        "ImgArchive", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            WizardForm form = new WizardForm();
            form.ExePath = exePath;
            form.WorkingPath = workPath;
            form.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            SwitchView(new GeneralUC());
            
            UpdateChanges.UnSavedChanges = false;
        }

        private void userSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new UserSpaceUC();
            // Further initialization of v here

            SwitchView(v);
            
        }

        private void SwitchView(UserControl newView)
        {
            if (groupBoxMain.Controls.Count > 0)
            {
                UserControl oldView = groupBoxMain.Controls[0] as UserControl;
                groupBoxMain.Controls.Remove(oldView);
                if (UpdateChanges.UnSavedChanges == true)
                {
                    groupBoxMain.Controls.Add(oldView);
                    return;
                }
                oldView.Dispose();
            }
            groupBoxMain.Controls.Add(newView);
            m_currentView = (IViewPage)newView;
        }

       
            
        

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new GeneralUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void vaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl v = new VaultUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void userSpaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl v = new UserSpaceUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void allowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new AllowedUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void eXIFToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new ExifToolUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void metadataTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new TemplateUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void fileNameFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new FileNamingUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new SyncUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void purgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new PurgeUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new ValidateUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new ArchiveUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl v = new LogsUC();
            // Further initialization of v here

            SwitchView(v);
        }

        private void CancalButton_Click(object sender, EventArgs e)
        {
            m_currentView.Reset();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            m_currentView.Apply();
        }



        // Debug.WriteLine("Send to debug output.");
    }
}
