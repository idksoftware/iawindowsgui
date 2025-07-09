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

namespace iaadmingui
{
    public partial class FileNamingUC : IAUserControl, IViewPage
    {
        //public String PathLocation { get { return pathLocation; } }
        XMLFileRename m_XMLFileRename = null;
        XMLFileRenameObject m_XMLFileRenameObject = null;
        bool isAppled = false;
        public FileNamingUC()
        {
            InitializeComponent();
        }
        private async void GetProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "show --setting=rename --format-type=xml --silent";
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

            m_XMLFileRename = new XMLFileRename(output);
            m_XMLFileRename.Process();
            m_XMLFileRenameObject = m_XMLFileRename.FileRenameObject;
            // Scotland{sequence-base10}[base10]
            textBoxImageFileRenamingTemplate.Text = m_XMLFileRenameObject.PreName + "{" + m_XMLFileRenameObject.RenameType + "-" + m_XMLFileRenameObject.RenameBase + "}[" + m_XMLFileRenameObject.Version + "]";
            checkBoxImageFileRename.Checked = m_XMLFileRenameObject.isEnabled();
            Trace.WriteLine(output);
            Reset();
        }
        public void Reset()
        {
           
            //textBoxImageFileRenamingTemplate.Text = string.Empty;
            //textBoxSequenceNumber.Text = string.Empty;

            //TextBox textBoxOriginalImageFile;


            //TextBox textBoxDate;

            //TextBox textBoxSequenceNumber;
            //TextBox textBoxRenamedImageFile;
    }
        public void Apply()
        {

        }
        public bool isChanged()
        {
            return false;
        }

        private void buttonEditFileRename_Click(object sender, EventArgs e)
        {
            RenameEditForm form = new RenameEditForm(m_XMLFileRenameObject);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string version = form.FileRenameObject.Version;
                m_XMLFileRenameObject = form.FileRenameObject;
                setRenameString();
            }
        }

       

        private void FileNamingUC_Load(object sender, EventArgs e)
        {
            GetProperties();
        }

        void setRenameString()
        {
            textBoxImageFileRenamingTemplate.Text = m_XMLFileRenameObject.PreName + "{" + m_XMLFileRenameObject.RenameType + "-" + m_XMLFileRenameObject.RenameBase + "}[" + m_XMLFileRenameObject.Version + "]";
        }
    }
}
