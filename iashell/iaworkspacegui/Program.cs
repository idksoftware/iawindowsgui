using iaforms;
using System.Configuration;
using System.Collections.Specialized;
using static System.Windows.Forms.AxHost;

namespace iaworkspacegui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string sAttr = ConfigurationManager.AppSettings.Get("PicturesLocation");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            String installPath = regSetting.InstallPath;

            Application.Run(new MainWorkspaceForm(workPath, exePath, installPath));
        }


    }
}