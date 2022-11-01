using System;
using System.IO;

using System.Windows.Forms;
using IDK.Gui;
using iaforms;

namespace iawizard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
            Application.Run(form);
        }
    }
}
