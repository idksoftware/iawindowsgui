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
    public partial class ExifToolUC : IAUserControl, IViewPage
    {
        public String PathLocation { get { return pathLocation; } }
        XMLExifTool m_xmlExifTool = null;
        ExifToolObject m_exifToolObject = null;
        bool isAppled = false;
        public ExifToolUC()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            checkBoxExternalEXIFToolEnabled.Checked = (m_exifToolObject.Enabled == "True") ? true : false;
            textBoxExifMapPath.Text = m_exifToolObject.ExifMapPath;
            textBoxExifMapFilename.Text = m_exifToolObject.ExifMapFile;
            textBoxExifToolPath.Text = m_exifToolObject.ExifToolPath;
            textBoxExifToolFilename.Text = m_exifToolObject.ExifTool;
            textBoxExifFileDelimiter.Text = m_exifToolObject.ExifFileDelim;
            textBoxExifCommandLine.Text = m_exifToolObject.CommandLine;
    }
        public void Apply()
        {
            if (textBoxExifMapPath.Text != m_exifToolObject.ExifMapPath)
            {
                UpdateArchive("config --exiftool ExifMapPath=" + textBoxExifMapPath.Text);
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }
            if (textBoxExifToolPath.Text != m_exifToolObject.ExifToolPath)
            {
                UpdateArchive("config --exiftool ExifToolPath=" + textBoxExifToolPath.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxExifMapFilename.Text != m_exifToolObject.ExifMapFile)
            {
                UpdateArchive("config --exiftool ExifMapFile=" + textBoxExifMapFilename.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxExifToolFilename.Text != m_exifToolObject.ExifToolPath)
            {
                UpdateArchive("config --exiftool ExifToolFile=" + textBoxExifToolFilename.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxExifCommandLine.Text != m_exifToolObject.CommandLine)
            {
                UpdateArchive("config --exiftool ExifCommandLine=" + textBoxExifToolFilename.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }

            if (textBoxExifFileDelimiter.Text != m_exifToolObject.ExifFileDelim)
            {
                UpdateArchive("config --exiftool ExifFileDelim=" + textBoxExifFileDelimiter.Text + " --format-type=xml");
                Trace.WriteLine("UserSpaceLocationChanged");
                if (!returned)
                {
                    return;
                }
            }
            /*
             
#define EXIF_MAP_FILE_LABEL				"ExifMapFile"
#define EXIF_TOOL_LABEL					"ExifToolFile"
#define EXIF_TOOL_PATH_LABEL		    "ExifToolPath"
#define EXIF_COMMANDLINE_LABEL			"ExifCommandLine"
#define EXIF_FILE_DELIM_LABEL			"ExifFileDelim"
#define EXIF_ENABLE_LABEL				"ExternalExif"
             */
        }
        public bool isChanged()
        {
            return false;
        }

        private void ExifToolUC_Load(object sender, EventArgs e)
        {
            GetProperties();
        }

        private async void GetProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "show --silent --setting=exiftool --format-type=xml";
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

            m_xmlExifTool = new XMLExifTool(output);
            m_xmlExifTool.Process();
            m_exifToolObject = m_xmlExifTool.ExifToolObject;

            Trace.WriteLine(output);
            Reset();
        }

        private void buttonExifMapPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxExifMapPath.Text;
                textBoxExifMapPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxExifMapPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonExifToolPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxExifToolPath.Text;
                textBoxExifToolPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxExifToolPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            string programData = Environment.GetEnvironmentVariable("ProgramData");
            checkBoxExternalEXIFToolEnabled.Checked = true;
            textBoxExifMapPath.Text = programData + "\\config";
            textBoxExifMapFilename.Text = "exiftool.ini";
            textBoxExifToolPath.Text = programData + "\\tools";
            textBoxExifToolFilename.Text = "exiftool.exe";
            textBoxExifFileDelimiter.Text = ":";
            textBoxExifCommandLine.Text = "[source]";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void CancalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
