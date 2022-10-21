using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDK.Gui
{
    public class ChangesList
    {
        bool masterPathChanged;
        bool masterBackup1EnabledChanged;
        bool masterBackup1PathChanged;
        bool masterBackup2EnabledChanged;
        bool masterBackup2PathChanged;
        bool derivativePathChanged;
        bool deivativeBackup1EnabledChanged;
        bool derivativeBackup1PathChanged;
        bool deivativeBackup2EnabledChanged;
        bool derivativeBackup2PathChanged;
        bool userSpaceLocationChanged;
        bool workspaceEnabledChanged;
        bool workspaceCheckoutChanged;
        bool wwwEnabledChanged;
        bool picturesEnabledChanged;

        public bool MasterPathChanged { get { return masterPathChanged; } set { masterPathChanged = value; } }

        public bool MasterBackup1PathChanged { get { return masterBackup1PathChanged; } set { masterBackup1PathChanged = value; } }
        public bool MasterBackup2PathChanged { get { return masterBackup2PathChanged; } set { masterBackup2PathChanged = value; } }
        public bool MasterBackup1EnabledChanged { get { return masterBackup1EnabledChanged; } set { masterBackup1EnabledChanged = value; } }
        public bool MasterBackup2EnabledChanged { get { return masterBackup2EnabledChanged; } set { masterBackup2EnabledChanged = value; } }

        public bool DerivativePathChanged { get { return derivativePathChanged; } set { derivativePathChanged = value; } }
        public bool DerivativeBackup1PathChanged { get { return derivativeBackup1PathChanged; } set { derivativeBackup1PathChanged = value; } }
        public bool DerivativeBackup2PathChanged { get { return derivativeBackup2PathChanged; } set { derivativeBackup2PathChanged = value; } }
        public bool DeivativeBackup1EnabledChanged { get { return deivativeBackup1EnabledChanged; } set { deivativeBackup1EnabledChanged = value; } }
        public bool DeivativeBackup2EnabledChanged { get { return deivativeBackup2EnabledChanged; } set { deivativeBackup2EnabledChanged = value; } }

        public bool UserSpaceLocationChanged { get { return userSpaceLocationChanged; } set { userSpaceLocationChanged = value; } }
        public bool WorkspaceEnabledChanged { get { return workspaceEnabledChanged; } set { workspaceEnabledChanged = value; } }
        public bool WorkspaceCheckoutChanged { get { return workspaceCheckoutChanged; } set { workspaceCheckoutChanged = value; } }
        public bool WWWEnabledChanged { get { return wwwEnabledChanged; } set { wwwEnabledChanged = value; } }
        public bool PicturesEnabledChanged { get { return picturesEnabledChanged; } set { picturesEnabledChanged = value; } }

    }
}
