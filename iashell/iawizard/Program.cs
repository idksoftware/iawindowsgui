using System;
using System.Collections.Generic;

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
            WizardForm form = new WizardForm();
            form.ExePath = exePath;
            form.WorkingPath = workPath;
            Application.Run(form);
        }
    }
}
