using iaforms;
using IDK.Gui;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace iaadmingui
{


    public partial class UserSpaceUC : IAUserControl, IViewPage
    {
        public String PathLocation
        {
            get { return pathLocation; }
        }

        XMLArchive m_xmlArchive = null;
        ArchiveObject.UserSpaceObject m_userSpace = null;
        bool isAppled = false;

        public UserSpaceUC()
        {
            InitializeComponent();
        }

        private void UserSpaceUC_Leave(object sender, EventArgs e)
        {
            if (isChanged())
            {
                UpdateChanges.UnSavedChanges = true;
                MessageBox.Show("Current View can not close!");
            }
        }

        private void buttonUserSpaceLocation_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }

                string temp = textBoxUserSpaceLocation.Text;
                textBoxUserSpaceLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxUserSpaceLocation.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonWorkspaceLocation_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }

                string temp = textBoxWorkspaceLocation.Text;
                textBoxWorkspaceLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxWorkspaceLocation.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonPicturesLocation_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }

                string temp = textBoxPicturesLocation.Text;
                textBoxPicturesLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxPicturesLocation.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonWebPicturesLocation_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }

                string temp = textBoxWebPicturesLocation.Text;
                textBoxWebPicturesLocation.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxWebPicturesLocation.Text) != 0)
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

            m_userSpace = archiveObject.UserSpace;
            Trace.WriteLine(output);
            Reset();
        }

        private async void UserSpaceUC_Load(object sender, EventArgs e)
        {
            Trace.WriteLine("UserSpaceUC_Load");

            GetProperties();
        }

        public void Reset()
        {
            textBoxUserSpaceLocation.Text = m_userSpace.Path;
            textBoxWorkspaceLocation.Text = m_userSpace.Workspace.Path;
            textBoxPicturesLocation.Text = m_userSpace.Pictures.Path;
            textBoxWebPicturesLocation.Text = m_userSpace.WWWImages.Path;
            checkBoxWorkspaceCheckout.Checked = ArchiveObject.isAutoCheckout(m_userSpace.Workspace.AutoCheckout);
            checkBoxWorkspaceEnabled.Checked = ArchiveObject.isAutoView(m_userSpace.Workspace.AutoView);
            checkBoxWWWEnabled.Checked = ArchiveObject.isAutoView(m_userSpace.WWWImages.AutoView);
            checkBoxPicturesEnabled.Checked = ArchiveObject.isAutoView(m_userSpace.Pictures.AutoView);
        }

        public void Apply()
        {
            if (textBoxUserSpaceLocation.Text != m_userSpace.Path)
            {
                UpdateArchive("config --folders UserspacePath=" + textBoxUserSpaceLocation.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxWorkspaceLocation.Text != m_userSpace.Workspace.Path)
            {
                UpdateArchive("config --folders UserspacePath=" + textBoxUserSpaceLocation.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxPicturesLocation.Text != m_userSpace.Pictures.Path)
            {
                UpdateArchive("config --folders UserspacePath=" + textBoxUserSpaceLocation.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxWebPicturesLocation.Text != m_userSpace.WWWImages.Path)
            {
                UpdateArchive("config --folders UserspacePath=" + textBoxUserSpaceLocation.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (checkBoxWorkspaceCheckout.Checked != ArchiveObject.isAutoCheckout(m_userSpace.Workspace.AutoCheckout))
            {
                UpdateArchive("config --general AutoCheckoutOn=" +
                              ((checkBoxWorkspaceCheckout.Checked) ? "True" : "false") + " --format-type=xml");
                Trace.WriteLine("WorkspaceCheckoutChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (checkBoxWorkspaceEnabled.Checked != ArchiveObject.isAutoView(m_userSpace.Workspace.AutoView))
            {

                UpdateArchive("config --general WorkspaceOn=" +
                              ((checkBoxWorkspaceEnabled.Checked) ? "True" : "false") + " --format-type=xml");
                Trace.WriteLine("WorkspaceEnabledChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (checkBoxPicturesEnabled.Checked != ArchiveObject.isAutoView(m_userSpace.Pictures.AutoView))
            {
                UpdateArchive("config --general PicturesOn=" + ((checkBoxPicturesEnabled.Checked) ? "True" : "false") +
                              " --format-type=xml");
                Trace.WriteLine("WorkspaceEnabledChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (checkBoxWWWEnabled.Checked != ArchiveObject.isAutoView(m_userSpace.WWWImages.AutoView))
            {
                UpdateArchive("config --general WWWOn=" + ((checkBoxWWWEnabled.Checked) ? "True" : "false") +
                              " --format-type=xml");
                Trace.WriteLine("WorkspaceEnabledChanged");
                if (!returned)
                {
                    return;
                }
            }

            GetProperties();
            UpdateChanges.UnSavedChanges = false;
        }

        public bool isChanged()
        {
            if (textBoxUserSpaceLocation.Text != m_userSpace.Path)
            {
                return true;
            }

            if (textBoxWorkspaceLocation.Text != m_userSpace.Workspace.Path)
            {
                return true;
            }

            if (textBoxPicturesLocation.Text != m_userSpace.Pictures.Path)
            {
                return true;
            }

            if (textBoxWebPicturesLocation.Text != m_userSpace.WWWImages.Path)
            {
                return true;
            }

            if (checkBoxWorkspaceCheckout.Checked != ArchiveObject.isAutoCheckout(m_userSpace.Workspace.AutoCheckout))
            {
                return true;
            }

            if (checkBoxWorkspaceEnabled.Checked != ArchiveObject.isAutoView(m_userSpace.Workspace.AutoView))
            {
                return true;

            }

            if (checkBoxPicturesEnabled.Checked != ArchiveObject.isAutoView(m_userSpace.Pictures.AutoView))
            {
                return true;
            }

            if (checkBoxWWWEnabled.Checked != ArchiveObject.isAutoView(m_userSpace.WWWImages.AutoView))
            {
                return true;
            }

            return false;
        }

       

    }
}
