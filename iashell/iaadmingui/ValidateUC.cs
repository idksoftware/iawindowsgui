using iaforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iaforms.ArchiveObject;

namespace iaadmingui
{
    public partial class ValidateUC : UserControl, IViewPage
    {
        XMLArchive m_xmlArchive = null;
        ArchiveObject.VaultObject m_vaultObject = null;
        XMLValidate m_xmlValidate = null;
        ValidateObject m_ValidateObject = null;
        bool isAppled = false;

        bool mb1Enabled;
        bool mb2Enabled;

        public ValidateUC()
        {
            InitializeComponent();
            GetProperties();
            mb1Enabled = m_vaultObject.Master.BackupOne.Enabled.Equals("true", StringComparison.OrdinalIgnoreCase);
            mb2Enabled = m_vaultObject.Master.BackupTwo.Enabled.Equals("true", StringComparison.OrdinalIgnoreCase);
            if (mb1Enabled)
            {
                labelNotEnabledMB1.Visible = false;
            } else
            {
                checkBoxBackupOne.Enabled = false;
                checkBoxScrubMB1.Enabled = false;
            }
            if (mb2Enabled)
            {
                labelNotEnabledMB2.Visible = false;
            }
            else
            {
                checkBoxBackupTwo.Enabled = false;
                checkBoxScrubMB2.Enabled = false;
            }
        }

        public void Reset()
        {

        }
        public void Apply()
        {

        }
        public bool isChanged()
        {
            return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async void GetProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "show --silent --setting=archive --format-type=xml";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }

            m_xmlArchive = new XMLArchive(output);
            m_xmlArchive.Process();
            ArchiveObject archiveObject = m_xmlArchive.Archive;

            m_vaultObject = archiveObject.Vault;
            //Trace.WriteLine(output);
            Reset();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Text = "Running...";
            try
            {
                var validateSummaryForm = new ValidateSummaryForm();

                validateSummaryForm.Show();


                


            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "validate --scope=master --silent";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }

            m_xmlValidate = new XMLValidate(output);
            m_xmlValidate.Process();
            m_ValidateObject = m_xmlValidate.ValidateObject;




            

                validateSummaryForm.Dispose();
            }
            finally
            {
                buttonStart.BackColor = Color.Red;
                StartValidite();
                buttonStart.Text = "Start";
                buttonStart.BackColor = Color.Transparent;
            }
        }
        

        private async void StartValidite()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "validate --scope=master --silent";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }

            m_xmlValidate = new XMLValidate(output);
            m_xmlValidate.Process();
            m_ValidateObject = m_xmlValidate.ValidateObject;

            
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
