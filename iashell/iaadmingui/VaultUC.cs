using iaforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iaforms.ArchiveObject;

namespace iaadmingui
{
    public partial class VaultUC : IAUserControl, IViewPage
    {
        XMLArchive m_xmlArchive = null;
        ArchiveObject.VaultObject m_vaultObject = null;
        bool isAppled = false;

        public VaultUC()
        {
            InitializeComponent();
        }
        private String pathLocation = null;
        public void Reset()
        {
            textBoxMasterPath.Text = m_vaultObject.Master.Path;
            textBoxMasterBackup1.Text = m_vaultObject.Master.BackupOne.Path;
            textBoxMasterBackup2.Text = m_vaultObject.Master.BackupTwo.Path;

            textBoxDerivativeLocation.Text = m_vaultObject.Derivative.Path;
            textBoxDerivativeBackup1.Text = m_vaultObject.Derivative.BackupOne.Path;
            textBoxDerivativeBackup2.Text = m_vaultObject.Derivative.BackupTwo.Path;

            checkBoxMasterBackup2Enabled.Checked = isEnabled(m_vaultObject.Master.BackupOne.Enabled);
            checkBoxMasterBackup2Enabled.Checked = isEnabled(m_vaultObject.Master.BackupOne.Enabled);

            checkBoxDerivativeBackup1.Checked = isEnabled(m_vaultObject.Derivative.BackupOne.Enabled);
            checkBoxDerivativeBackup2.Checked = isEnabled(m_vaultObject.Derivative.BackupOne.Enabled);
        }
        public void Apply()
        {
            if (textBoxMasterPath.Text != m_vaultObject.Master.Path)
            {
                UpdateArchive("config --folders MasterPath=" + textBoxMasterPath.Text + " --format-type=xml");
                Trace.WriteLine("MasterPathChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (textBoxMasterBackup1.Text != m_vaultObject.Master.BackupOne.Path)
            {
                UpdateArchive("config --master BackupOne=" + textBoxMasterBackup1.Text + " --format-type=xml");
                Trace.WriteLine("MasterBackup1PathChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (textBoxMasterBackup2.Text != m_vaultObject.Master.BackupTwo.Path)
            {
                UpdateArchive("config --master BackupTwo=" + textBoxMasterBackup2.Text + " --format-type=xml");
                Trace.WriteLine("MasterBackup2PathChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxDerivativeLocation.Text != m_vaultObject.Derivative.Path)
            {
                UpdateArchive("config --folders DerivativePath=" + textBoxDerivativeLocation.Text + " --format-type=xml");
                Trace.WriteLine("DerivativePathChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (textBoxDerivativeBackup1.Text != m_vaultObject.Derivative.BackupOne.Path)
            {
                UpdateArchive("config --derivative BackupOne=" + textBoxDerivativeBackup1.Text + " --format-type=xml");
                Trace.WriteLine("DerivativeBackup1PathChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (textBoxDerivativeBackup2.Text != m_vaultObject.Derivative.BackupTwo.Path)
            {
                UpdateArchive("config --derivative BackupTwo=" + textBoxDerivativeBackup1.Text + " --format-type=xml");
                Trace.WriteLine("DerivativeBackup2PathChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (checkBoxMasterBackup2Enabled.Checked != isEnabled(m_vaultObject.Master.BackupOne.Enabled))
            {
                UpdateArchive("config --master BackupOneEnabled=" + ((checkBoxMasterBackup2Enabled.Checked) ? "True" : "false")
                                                                                                + " --format-type=xml");
                Trace.WriteLine("MasterBackup1EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (checkBoxMasterBackup2Enabled.Checked != isEnabled(m_vaultObject.Master.BackupOne.Enabled))
            {
                UpdateArchive("config --master BackupTwoEnabled=" + ((checkBoxMasterBackup2Enabled.Checked) ? "True" : "false")
                                                                                                + " --format-type=xml");
                Trace.WriteLine("MasterBackup2EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (checkBoxDerivativeBackup1.Checked != isEnabled(m_vaultObject.Derivative.BackupOne.Enabled))
            {
                UpdateArchive("config --derivative BackupOneEnabled=" + ((checkBoxDerivativeBackup1.Checked) ? "True" : "false")
                                                                                                + " --format-type=xml");
                Trace.WriteLine("DeivativeBackup1EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (checkBoxDerivativeBackup2.Checked != isEnabled(m_vaultObject.Derivative.BackupOne.Enabled))
            {
                UpdateArchive("config --derivative BackupTwoEnabled=" + ((checkBoxDerivativeBackup2.Checked) ? "True" : "false")
                                                                                                + " --format-type=xml");
                Trace.WriteLine("DeivativeBackup2EnabledChanged");
                if (!returned)
                {
                    return;
                }
            }
        }
        public bool isChanged()
        {
            if (textBoxMasterPath.Text != m_vaultObject.Master.Path)
            {
                return true;
            }
            if (textBoxMasterBackup1.Text != m_vaultObject.Master.BackupOne.Path)
            {
                return true;
            }
            if (textBoxMasterBackup2.Text != m_vaultObject.Master.BackupTwo.Path)
            {
                return true;
            }

            if (textBoxDerivativeLocation.Text != m_vaultObject.Derivative.Path)
            {
                return true;
            }
            if (textBoxDerivativeBackup1.Text != m_vaultObject.Derivative.BackupOne.Path)
            {
                return true;
            }
            if (textBoxDerivativeBackup2.Text != m_vaultObject.Derivative.BackupTwo.Path)
            {
                return true;
            }

            if (checkBoxMasterBackup2Enabled.Checked != isEnabled(m_vaultObject.Master.BackupOne.Enabled))
            {
                return true;
            }
            if (checkBoxMasterBackup2Enabled.Checked != isEnabled(m_vaultObject.Master.BackupOne.Enabled))
            {
                return true;
            }

            if (checkBoxDerivativeBackup1.Checked != isEnabled(m_vaultObject.Derivative.BackupOne.Enabled))
            {
                return true;
            }
            if (checkBoxDerivativeBackup2.Checked != isEnabled(m_vaultObject.Derivative.BackupOne.Enabled))
            {
                return true;
            }
            return false;
        }

        private void buttonMasterBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxMasterPath.Text;
                textBoxMasterPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxMasterPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonBackup1Browse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxMasterBackup1.Text;
                textBoxMasterBackup1.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxMasterBackup1.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonBackup2Browse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxMasterBackup2.Text;
                textBoxMasterBackup2.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxMasterBackup2.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void CancalButton_Click(object sender, EventArgs e)
        {
            GetProperties();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxMasterBackup1Enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMasterBackup2Enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDerivativeBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxDerivativeLocation.Text;
                textBoxDerivativeLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxDerivativeLocation.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonDerivativeBackup1Browse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxDerivativeBackup1.Text;
                textBoxDerivativeBackup1.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxDerivativeBackup1.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonDerivativeBackup2Browse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxDerivativeBackup2.Text;
                textBoxDerivativeBackup2.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxDerivativeBackup2.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
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
            Trace.WriteLine(output);
            Reset();
        }

        private void VaultUC_Load(object sender, EventArgs e)
        {
            GetProperties();
        }
    }
}
