using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iaforms;

/*
  iaarc checkout [--target-path=<path>]
        [--comment=<comment text>]
        [--scope=<scope-address]
        [--force=<yes|No>]
        [--version=<vesion-num>
 */



namespace iaprop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           
            string file = "";
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool single = FileArg(args, ref file);
            if (file.Length == 0)
            {
                string box_msg = "No arguments";
                string box_title = "Image Archive";
                MessageBox.Show(box_msg, box_title);

            }
            if (FileArg(args, ref file))
            {
                
                Application.Run(new PropertiesForm(file));
            }
            else
            {
                //string box_msg = file;
                //string box_title = "Image Archive";
                // MessageBox.Show(box_msg, box_title);
                
                Application.Run(new MainPropertiesForm(file, exePath, workPath));
            }
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
