using iaforms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ImportQueueApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
     
        [STAThread]
        static void Main(string[] args)
        {
            string file = "";
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            String userPath = regSetting.UserPath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            bool single = FileArg(args, ref file);
            if (file.Length == 0)
            {
                string box_msg = "No arguments";
                string box_title = "Image Archive";
                MessageBox.Show(box_msg, box_title);

            }
            if (!System.IO.File.Exists(file))
            {
                MessageBox.Show("Path is not valid please check if this path exists", "Path Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new ImportQueueForm(file, exePath, workPath, userPath));


        }

        static bool FileArg(string[] args, ref string file)
        {
            bool single = true;
            file = "";
            if (args.Length == 1)
            {
                file = args[0];
            }
            else if (args.Length == 2)
            {
                if (args[0] == "-f")
                {
                    file = args[1];
                    single = false;
                }
            }
            return single;
        }
            
            
    }
}
