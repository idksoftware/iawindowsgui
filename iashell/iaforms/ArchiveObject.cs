using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iaforms
{
    public class ArchiveObject
    {
        public class Backup
        {
            string enabled;
            string location;
            string path;

            public string Enabled { get => enabled; set => enabled = value; }
            public string Location { get => location; set => location = value; }
            public string Path { get => path; set => path = value; }
        }
        public class Repository
        {
            string location;
            string path;
            Backup backupOne;
            Backup backupTwo;

            public Repository()
            {
                backupOne = new Backup();
                backupTwo = new Backup();
            }
            public string Location { get => location; set => location = value; }
            public string Path { get => path; set => path = value; }
            public Backup BackupOne { get => backupOne; }
            public Backup BackupTwo { get => backupTwo; }

        }

        public class VaultObject
        {
            Repository master;
            Repository derivative;
            public Repository Master { get => master; }
            public Repository Derivative { get => derivative; }

            public VaultObject()
            {
                master = new Repository();
                derivative = new Repository();
            }
        }

        public class ImageSpace
        {
            string autoView;
            string location;
            string path;

            public string AutoView { get => autoView; set => autoView = value; }
            public string Location { get => location; set => location = value; }
            public string Path { get => path; set => path = value; }

        }

        public class Workspace : ImageSpace
        {
            string autoCheckout;
            public string AutoCheckout { get => autoCheckout; set => autoCheckout = value; }
        }
        public class UserSpaceObject
        {
            string location;
            string path;
            Workspace workspace;
            ImageSpace pictures;
            ImageSpace wwwImages;
            ImageSpace metadata;

            public string Location { get => location; set => location = value; }
            public string Path { get => path; set => path = value; }
            public Workspace Workspace { get => workspace; }
            public ImageSpace Pictures { get => pictures; }
            public ImageSpace WWWImages { get => wwwImages; }
            public ImageSpace Metadata { get => metadata; }

            public UserSpaceObject()
            {
                workspace = new Workspace();
                pictures = new ImageSpace();
                wwwImages = new ImageSpace();
                metadata = new ImageSpace();
            }

        }

        string homePath;
        VaultObject vault;
        UserSpaceObject userSpace;
        public string HomePath { get => homePath; set => homePath = value; }
        public VaultObject Vault { get => vault;}
        public UserSpaceObject UserSpace { get => userSpace; }
        public ArchiveObject()
        {
            vault = new VaultObject();
            userSpace = new UserSpaceObject();
        }
    
        static bool isEnabled(string e)
        {
            if (string.Compare(e, "True") == 0)
            {
                return true;
            }
            return false;
        }

        static bool isAutoCheckout(string e)
        {
            if (string.Compare(e, "On") == 0)
            {
                return true;
            }
            return false;
        }
        static bool isAutoView(string e)
        {
            if (string.Compare(e, "On") == 0)
            {
                return true;
            }
            return false;
        }
    }
}
