using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iaforms;

namespace iachkin
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
            //#if DEBUG
            //System.Diagnostics.Debugger.Break();
            //#endif
            RegSetting regSetting = new RegSetting();
            regSetting.ReadRegister();
            String workPath = regSetting.TempPath;
            String exePath = regSetting.IaexePath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int noArgs = FileArg(args, ref file);
            if (noArgs == 0) {
                var form = new NoFileForm();
                form.FormClosed += new FormClosedEventHandler(FormClosed);
                Application.Run(form);

            } else if (noArgs == 1) {
                var form = new CheckInSingleForm(file);
                form.FormClosed += new FormClosedEventHandler(FormClosed);
                Application.Run(form);
            } else { 
                var form = new CheckInMultiForm(file, exePath, workPath);
                form.FormClosed += new FormClosedEventHandler(FormClosed);
                Application.Run(form);
            }
        }

        static int FileArg(string[] args, ref string file)
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
                    
                }
            }
            return args.Length;
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += FormClosed;
            }
        }
    }
}
