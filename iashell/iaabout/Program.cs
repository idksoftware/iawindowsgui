﻿using System;
using iaforms;
using System.Windows.Forms;

namespace iaabout
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
            Application.Run(new AboutForm());
        }

        
    }
}
