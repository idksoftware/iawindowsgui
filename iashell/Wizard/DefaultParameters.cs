using System;
using System.Collections.Generic;
using System.Text;

namespace IDK.Gui
{
    class DefaultParameters
    {
        private String m_name;
        private String m_company;
        private String m_lic1;
        private String m_lic2;
        private bool m_freeversion;
        private String m_masterPath;
        private String m_masterBackup1Path;
        private String m_masterBackup2Path;
        private bool m_masterBackup1Enable;
        private bool m_masterBackup2Enable;
        private String m_derivertivePath;
        private String m_derivertiveBackup1Path;
        private String m_derivertiveBackup2Path;
        private bool m_derivertiveBackup1Enable;
        private bool m_derivertiveBackup2Enable;
        private String m_userspacePath;
        private bool m_workspaceAutocheckout;
        private bool m_workspaceOn;
        private bool m_picturesOn;
        private bool m_WWWOn;

        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public String Company
        {
            get { return m_company; }
            set { m_company = value; }
        }

        public String Lic1
        {
            get { return m_lic1; }
            set { m_lic1 = value; }
        }

        public String Lic2
        {
            get { return m_lic2; }
            set { m_lic2 = value; }
        }

        public bool Freeversion
        {
            get { return m_freeversion; }
            set { m_freeversion = value; }
        }
        
        public String MasterPath
        {
            get { return m_masterPath; }
            set { m_masterPath = value; }
        }

        public String MasterBackup1Path
        {
            get { return m_masterBackup1Path; }
            set { m_masterBackup1Path = value; }
        }

        public String MasterBackup2Path
        {
            get { return m_masterBackup2Path; }
            set { m_masterBackup2Path = value; }
        }

        public bool MasterBackup1Enable
        {
            get { return m_masterBackup1Enable; }
            set { m_masterBackup1Enable = value; }
        }

        public bool MasterBackup2Enable
        {
            get { return m_masterBackup2Enable; }
            set { m_masterBackup2Enable = value; }
        }

        public String DerivertivePath
        {
            get { return m_derivertivePath; }
            set { m_derivertivePath = value; }
        }


        public String DerivertiveBackup1Path
        {
            get { return m_derivertiveBackup1Path; }
            set { m_derivertiveBackup1Path = value; }
        }

        public String DerivertiveBackup2Path
        {
            get { return m_derivertiveBackup2Path; }
            set { m_derivertiveBackup2Path = value; }
        }

        public bool DerivertiveBackup1Enable
        {
            get { return m_derivertiveBackup1Enable; }
            set { m_derivertiveBackup1Enable = value; }
        }

        public bool DerivertiveBackup2Enable
        {
            get { return m_derivertiveBackup2Enable; }
            set { m_derivertiveBackup2Enable = value; }
        }

        public String UserspacePath
        {
            get { return m_userspacePath; }
            set { m_userspacePath = value; }
        }

        public bool WorkspaceAutocheckout
        {
            get { return m_workspaceAutocheckout; }
            set { m_workspaceAutocheckout = value; }
        }

        public bool WorkspaceOn
        {
            get { return m_workspaceOn; }
            set { m_workspaceOn = value; }
        }

        public bool PicturesOn
        {
            get { return m_picturesOn; }
            set { m_picturesOn = value; }
        }

        public bool WWWOn
        {
            get { return m_WWWOn; }
            set { m_WWWOn = value; }
        }
    }
}
