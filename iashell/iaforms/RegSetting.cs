using System;
using System.Collections.Generic;
using System.Text;

namespace iaforms
{
    public class RegSetting : RegInitalise
    {
        String tempPath = null;
        String exePath = null;
        
        private string installPath = null;
        private string workspacePath = null;
        private string picturePath = null;
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
                installPath = (String)regSubKey.GetValue("InstallPath");
                isInstalled = true;
                if (installPath == null)
                {
                    return;
                }
                workspacePath = (String)regSubKey.GetValue("WorkspacePath");
                isInstalled = true;
                if (workspacePath == null)
                {
                    return;
                }
                picturePath = (String)regSubKey.GetValue("PicturePath");
                isInstalled = true;
                if (picturePath == null)
                {
                    return;
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
            get { return installPath; }
            set { installPath = value; }
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
            get { return exePath; }
            set { exePath = value; }
        }

        public String WorkspacePath
        {
            get { return workspacePath; }
            set { workspacePath = value; }
        }

        public String PicturePath
        {
            get { return picturePath; }
            set { picturePath = value; }
        }
    }
}
