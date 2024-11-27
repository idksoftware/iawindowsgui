using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaforms
{
    public partial class SyncArchiveForm : Form
    {
        private bool returned;
        public SyncArchiveForm(string archive, string backup)
        {
            InitializeComponent();

            labelDestinationBackup.Text = backup;
            labelSourceArchive.Text = archive;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (labelDestinationBackup.Text != null && labelSourceArchive.Text != null)
            {
                //MessageBox()
            }

            // Derivative
            // example - sync --master-with=backup2
            string sourceArchive;
            if (string.Compare("Master", labelSourceArchive.Text) == 0)
            {
                sourceArchive = "master";
            } else if (string.Compare("Derivative", labelSourceArchive.Text) == 0)
            {
                sourceArchive = "derivative";
            }
            else
            {
                sourceArchive = "both";
            }
            string destinationBackup;
            if (string.Compare("BackupOne", labelDestinationBackup.Text) == 0)
            {
                destinationBackup = "backup1";
            }
            else if (string.Compare("BackupTwo", labelDestinationBackup.Text) == 0)
            {
                destinationBackup = "backup2";
            }
            else
            {
                destinationBackup = "both";
            }
            DoSync("sync --" + sourceArchive + "-with=" + destinationBackup
                                   + " --format-type=xml");
        }

        private void CancalButton_Click(object sender, EventArgs e)
        {

        }

        public async void DoSync(string arg)
        {
            LaunchAdmin launchCommand = LaunchAdmin.Instance;
            launchCommand.Arguments = arg;
            launchCommand.ExePath = IAAdminInfo.ExePath;
            launchCommand.Path = launchCommand.ExePath = IAAdminInfo.WorkingPath;
            launchCommand.FilePath = IAAdminInfo.FilePath;

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
            if (output != null && output.Length != 0)
            {
                pos = output.IndexOf('-');
                string returnString = output.Substring(pos + 2, output.Length - (pos + 2));

                if (MessageBox.Show(this,
                        returnString + " Continue (Yes/No)",
                        exitText, MessageBoxButtons.YesNo
                    ) == DialogResult.Yes)
                {
                    returned = true;
                }
            }
            else
            {
                if (MessageBox.Show(this,
                         exitText + " Continue (Yes/No)", "", MessageBoxButtons.YesNo ) == DialogResult.Yes)
                {
                    returned = true;
                }
            }

            returned = false;


        }
    }
}
