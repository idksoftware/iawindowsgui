using iaforms;

namespace iaupdate
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            String picturePath = regSetting.PicturePath;
            string installPath = regSetting.InstallPath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            ApplicationConfiguration.Initialize();
            Application.Run(new UpdateForm(installPath, picturePath));
        }
    }
}