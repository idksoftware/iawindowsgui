using System;
using System.Collections.Generic;
using System.Text;

namespace on_picture
{
    public class RegSetting : RegInitalise
    {
        String tempPath = null;
        String exePath = null;
        String iaexePath = null;
        private string iaInstallPath = null;
        string workspacePath = null;
        public void ReadRegister()
        {
            isSetup = false;
            if (InitReg() == true)
            {
                tempPath = (String)regSubKey.GetValue("TempPath");
                isInstalled = true;
                if (tempPath == null)
                {
                    return;
                }
                exePath = (String)regSubKey.GetValue("ExePath");
                isInstalled = true;
                if (exePath == null)
                {
                    return;
                }
                // This is the ImgArchive path i.e. iaarc.exe
                iaInstallPath = (String)regSubKey.GetValue("InstallPath");
                isInstalled = true;
                if (iaInstallPath == null)
                {
                    return;
                }

                workspacePath = (String)regSubKey.GetValue("WorkspacePath");
                isInstalled = true;
                if (workspacePath == null)
                {
                //    return;
                }
                isSetup = true;
            }   
        }

        public void WriteRegistory()
        {
            if (tempPath != null)
            {
                regSubKey.SetValue("LibraryLocationPath", tempPath);
            }
        }

        public String InstallPath
        {
            get { return iaInstallPath; }
            set { iaInstallPath = value; }
        }
        public String TempPath
        {
            get { return tempPath; }
            set { tempPath = value; }
        }

        public String ExePath
        {
            get { return exePath; }
            set { exePath = value; }
        }

        public String IaexePath
        {
            get { return iaexePath; }
            set { iaexePath = value; }
        }

        public String WorkspacePath
        {
            get { return workspacePath; }
            set { workspacePath = value; }
        }
    }
}
