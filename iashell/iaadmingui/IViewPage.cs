using iaadmingui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaadmingui
{
    public interface IViewPage
    {
        //bool CanClose();
        void Reset();
        void Apply();
        bool isChanged();
    }
    
    public class IAUserControl : UserControl
    {
        public bool returned = true;
        public string m_output;
        public bool m_updated = false;
        public string Output {  get { return m_output; } }
        public async void UpdateArchive(string arg)
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.Arguments = arg;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            IDK.Gui.LaunchAdmin.ExitCode exitCode = launchCommand.ProcessExitCode;
            string exitText = "Ok";
            bool fatal = false;
            switch (exitCode)
            {
                case IDK.Gui.LaunchAdmin.ExitCode.Success:
                    return;
                case IDK.Gui.LaunchAdmin.ExitCode.Warnings:
                    exitText = "Command returned Warning";
                    break;
                case IDK.Gui.LaunchAdmin.ExitCode.Errors:
                    exitText = "Command returned Errors";
                    break;
                case IDK.Gui.LaunchAdmin.ExitCode.Fatal:
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

        public async void PropertiesCommand(String args)
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = args;
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            m_output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = m_output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                //System.Windows.Forms.Application.Exit();
            }


        }
    }

    
    public class UpdateChanges
    {
        public static bool UnSavedChanges {  get; set; }
        public static string ExePath {  get; set; }
        public static string WorkingPath { get; set; }
        public static string FilePath {  get; set; }

        //public static bool UnSavedChanges
        //{
        //    get { return m_UnSavedChanges; }
        //    set { m_UnSavedChanges = value; }
        //}
    }
   
}

