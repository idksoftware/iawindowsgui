﻿using iaforms;
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
    public partial class GeneralUC : IAUserControl, IViewPage
    {
        XMLGeneral m_xmlGeneral = null;
        GeneralObject m_GeneralObject = null;
        XMLFolders m_xmlFolders = null;
        FoldersObject m_foldersObject = null;
        XMLNetwork m_xmlNetwork = null;
        NetworkObject m_networkObject = null;
        bool isAppled = false;
        private String pathLocation = null;

        public GeneralUC()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            //ResetGeneral();
        }
        public void Apply()
        {

        }
        public bool isChanged()
        {
            return false;
        }
        public void ResetGeneral()
        {
            checkBoxEnabledQuiet.Checked = (m_GeneralObject.m_quietOn == "true");
            checkBoxEnabledSilent.Checked = (m_GeneralObject.m_silentOn == "true");
            comboBoxLoggingLevel.Text = m_GeneralObject.m_loglevel;
            comboBoxConsoleLevel.Text = m_GeneralObject.m_consolelevel;
            //checkBoxEnableCommandsLink.Text = m_GeneralObject.
            checkBoxEnableSQL.Checked = (m_GeneralObject.m_sqlDatabase == "true");
        }

        public void ResetFolders()
        {
            textBoxConfigPath.Text = m_foldersObject.m_configurationPath;
            textBoxSystemPath.Text = m_foldersObject.m_systemPath;
            textBoxLogPath.Text = m_foldersObject.m_logPath;
            textBoxToolsPath.Text = m_foldersObject.m_toolsPath;
            textBoxHookScripsPath.Text = m_foldersObject.m_hookPath;
            textBoxHistoryPath.Text = m_foldersObject.m_historyPath;
            textBoxSQLPath.Text = m_foldersObject.m_sqlDatabasePath;
            textBoxTemplatesPath.Text = m_foldersObject.m_templatesPath;
            textBoxTempPath.Text = m_foldersObject.m_tempPath;
        }

        public void ResetNetwork()
        {
            checkBoxEnableEventsLink.Checked = (m_networkObject.m_EventsOn == "true");
            textBoxEventPort.Text = m_networkObject.m_EventPort;
            textBoxEventAddess.Text = m_networkObject.m_EventAddress;
            checkBoxEnableCommandsLink.Checked = (m_networkObject.m_CommandOn == "true"); 
            textBoxCommandPort.Text = m_networkObject.m_CommandPort;

        }
        private async void GetGeneralProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "show --silent --setting=general --format-type=xml";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                //System.Windows.Forms.Application.Exit();
            }


            m_xmlGeneral = new XMLGeneral(output);
            m_xmlGeneral.Process();
            m_GeneralObject = m_xmlGeneral.General;

            
            
            Trace.WriteLine(output);
            ResetGeneral();
        }

        private void GetFoldersProperties()
        {

            string arguments = "show --setting=folders --format-type=xml --silent";
            PropertiesCommand(arguments);


            m_xmlFolders = new XMLFolders(Output);
            m_xmlFolders.Process();
            m_foldersObject = m_xmlFolders.Folders;



            Trace.WriteLine(Output);
            ResetFolders();
        }

        private void GetNetworkProperties()
        {

            string arguments = "show --setting=network --format-type=xml --silent";
            PropertiesCommand(arguments);


            m_xmlNetwork = new XMLNetwork(Output);
            m_xmlNetwork.Process();
            m_networkObject = m_xmlNetwork.Network;



            Trace.WriteLine(Output);
            ResetNetwork();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GeneralUC_Load(object sender, EventArgs e)
        {
            GetGeneralProperties();
            GetFoldersProperties();
            GetNetworkProperties();
        }

        private void buttonConfigPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxConfigPath.Text;
                textBoxConfigPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxConfigPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonToolsPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxToolsPath.Text;
                textBoxToolsPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxToolsPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonHookScripsPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxHookScripsPath.Text;
                textBoxHookScripsPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxHookScripsPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonTempPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxTempPath.Text;
                textBoxTempPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxTempPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonLogPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxLogPath.Text;
                textBoxLogPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxLogPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonSystemPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxSystemPath.Text;
                textBoxSystemPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxSystemPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonHistoryPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxHistoryPath.Text;
                textBoxHistoryPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxHistoryPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonTemplatesPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxTemplatesPath.Text;
                textBoxTemplatesPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxTemplatesPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }

        private void buttonSQLPathBrowse_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("buttonMasterBackup2_Click");
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (pathLocation != null)
                {
                    folderBrowser.SelectedPath = pathLocation;
                }
                string temp = textBoxSQLPath.Text;
                textBoxSQLPath.Text = folderBrowser.SelectedPath;
                if (string.Compare(temp, textBoxSQLPath.Text) != 0)
                {
                    //changesList.MasterBackup2PathChanged = true;
                }
            }
        }
    }
}
