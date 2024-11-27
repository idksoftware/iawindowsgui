using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iaforms;

namespace iaimport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string folder = "";
            bool single = FileArg(args, ref folder);
            if (folder.Length == 0)
            {
                string box_msg = "No arguments";
                string box_title = "Image Archive";
                MessageBox.Show(box_msg, box_title);

            }
            if (!System.IO.Directory.Exists(folder))
            {
                MessageBox.Show("Path is not valid please check if this path exists", "Path Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            Application.Run(new ImportForm(folder, exePath, workPath));
            

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
