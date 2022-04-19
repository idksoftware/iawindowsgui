using System;
using System.Collections.Generic;
using System.Text;

namespace iaforms
{
    public class RegSetting : RegInitalise
    {
        String tempPath = null;
        String exePath = null;
        String iaexePath = null;
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
                iaexePath = (String)regSubKey.GetValue("ImgaPath");
                isInstalled = true;
                if (exePath == null)
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
    }
}
