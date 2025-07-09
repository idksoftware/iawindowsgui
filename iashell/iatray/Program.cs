using iaforms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iatray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(workPath,exePath));
        }
    }
}