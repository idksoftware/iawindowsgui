using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace iaforms
{
    public class XMLArchive
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        ArchiveObject archiveObject = null;
        public XMLArchive(string xmlString)
        {
            //reader = new XmlTextReader(fileName);
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            archiveObject = new ArchiveObject();
        }

        public ArchiveObject Archive { get => archiveObject; }
        public void Process()
        {
            XmlNodeList rootList = document.GetElementsByTagName("Archive");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNodeList nodeList = document.GetElementsByTagName("Home");
                for (int image = 0; image < nodeList.Count; ++image)
                {
                    XmlNode node = nodeList.Item(i); // Image node
                    if (node.HasChildNodes)
                    {

                        XmlNodeList childNodeList = node.ChildNodes;
                        for (int j = 0; j < childNodeList.Count; j++)
                        {
                            XmlNode childNode = childNodeList.Item(j);
                            if (childNode.Name == "Path")
                            {
                                archiveObject.HomePath = childNode.InnerText;
                            }
                        }
                    }
                }
                nodeList = document.GetElementsByTagName("Vault");
                for (int image = 0; image < nodeList.Count; ++image)
                {
                    ArchiveObject.VaultObject  vault = archiveObject.Vault;
                    XmlNode node = nodeList.Item(i); // Image node
                    if (node.HasChildNodes)
                    {

                        XmlNodeList childNodeList = node.ChildNodes;
                        for (int j = 0; j < childNodeList.Count; j++)
                        {
                            XmlNode childNode = childNodeList.Item(j);
                            if (childNode.Name == "MasterArchive")
                            {
                                ArchiveObject.Repository master = vault.Master;
                                if (childNode.HasChildNodes)
                                {
                                    XmlNodeList masterNodeList = childNode.ChildNodes;
                                    for (int m = 0; m < masterNodeList.Count; m++)
                                    {
                                        XmlNode childMasterNode = masterNodeList.Item(m);
                                        if (childMasterNode.Name == "Location")
                                        {
                                            master.Location = childMasterNode.InnerText;
                                        }
                                        if (childMasterNode.Name == "Path")
                                        {
                                            master.Path = childMasterNode.InnerText;
                                        }
                                        if (childMasterNode.Name == "BackupOne")
                                        {
                                            ArchiveObject.Backup backupOne = master.BackupOne;
                                            if (childMasterNode.HasChildNodes)
                                            {
                                                XmlNodeList masterBakupOneNodeList = childMasterNode.ChildNodes;
                                                for (int b1 = 0; b1 < masterBakupOneNodeList.Count; b1++)
                                                {
                                                    XmlNode childMasterBackup1Node = masterBakupOneNodeList.Item(b1);
                                                    if (childMasterBackup1Node.Name == "Enabled")
                                                    {
                                                        backupOne.Enabled = childMasterBackup1Node.InnerText;
                                                    }
                                                    if (childMasterBackup1Node.Name == "Location")
                                                    {
                                                        backupOne.Location = childMasterBackup1Node.InnerText;
                                                    }
                                                    if (childMasterBackup1Node.Name == "Path")
                                                    {
                                                        backupOne.Path = childMasterBackup1Node.InnerText;
                                                    }
                                                }
                                            }
                                        }
                                        if (childMasterNode.Name == "BackupTwo")
                                        {
                                            if (childMasterNode.HasChildNodes)
                                            {
                                                ArchiveObject.Backup backupTwo = master.BackupTwo;
                                                XmlNodeList masterBakupNodeList = childMasterNode.ChildNodes;
                                                for (int b = 0; b < masterBakupNodeList.Count; b++)
                                                {
                                                    XmlNode childMasterBackupNode = masterBakupNodeList.Item(b);
                                                    if (childMasterBackupNode.Name == "Enabled")
                                                    {
                                                        backupTwo.Enabled = childMasterBackupNode.InnerText;
                                                    }
                                                    if (childMasterBackupNode.Name == "Location")
                                                    {
                                                        backupTwo.Location = childMasterBackupNode.InnerText;
                                                    }
                                                    if (childMasterBackupNode.Name == "Path")
                                                    {
                                                        backupTwo.Path = childMasterBackupNode.InnerText;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (childNode.Name == "DerivativeArchive")
                            {
                                if (childNode.HasChildNodes)
                                {
                                    ArchiveObject.Repository derivative = vault.Derivative;
                                    XmlNodeList derivativeNodeList = childNode.ChildNodes;
                                    for (int m = 0; m < derivativeNodeList.Count; m++)
                                    {
                                        XmlNode childDerivativeNode = derivativeNodeList.Item(m);
                                        if (childDerivativeNode.Name == "Location")
                                        {
                                            derivative.Location = childDerivativeNode.InnerText;
                                        }
                                        if (childDerivativeNode.Name == "Path")
                                        {
                                            derivative.Path = childDerivativeNode.InnerText;
                                        }
                                        if (childDerivativeNode.Name == "BackupOne")
                                        {
                                            ArchiveObject.Backup backupOne = derivative.BackupOne;
                                            if (childDerivativeNode.HasChildNodes)
                                            {
                                                XmlNodeList derivativeBakupOneNodeList = childDerivativeNode.ChildNodes;
                                                for (int b1 = 0; b1 < derivativeBakupOneNodeList.Count; b1++)
                                                {
                                                    XmlNode childDerivativeBackup1Node = derivativeBakupOneNodeList.Item(b1);
                                                    if (childDerivativeBackup1Node.Name == "Enabled")
                                                    {
                                                        backupOne.Enabled = childDerivativeBackup1Node.InnerText;
                                                    }
                                                    if (childDerivativeBackup1Node.Name == "Location")
                                                    {
                                                        backupOne.Location = childDerivativeBackup1Node.InnerText;
                                                    }
                                                    if (childDerivativeBackup1Node.Name == "Path")
                                                    {
                                                        backupOne.Path = childDerivativeBackup1Node.InnerText;
                                                    }
                                                }
                                            }
                                        }
                                        if (childDerivativeNode.Name == "BackupTwo")
                                        {
                                            ArchiveObject.Backup backupTwo = derivative.BackupTwo;
                                            if (childDerivativeNode.HasChildNodes)
                                            {
                                                XmlNodeList derivativeBakupOneNodeList = childDerivativeNode.ChildNodes;
                                                for (int b1 = 0; b1 < derivativeBakupOneNodeList.Count; b1++)
                                                {
                                                    XmlNode childDerivativeBackup2Node = derivativeBakupOneNodeList.Item(b1);
                                                    if (childDerivativeBackup2Node.Name == "Enabled")
                                                    {
                                                        backupTwo.Enabled = childDerivativeBackup2Node.InnerText;
                                                    }
                                                    if (childDerivativeBackup2Node.Name == "Location")
                                                    {
                                                        backupTwo.Location = childDerivativeBackup2Node.InnerText;
                                                    }
                                                    if (childDerivativeBackup2Node.Name == "Path")
                                                    {
                                                        backupTwo.Path = childDerivativeBackup2Node.InnerText;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    nodeList = document.GetElementsByTagName("Userspace");
                    for (int userSpace = 0; userSpace < nodeList.Count; ++userSpace)
                    {
                        ArchiveObject.UserSpaceObject userspace = archiveObject.UserSpace;
                        XmlNode userSpaceNodes = nodeList.Item(i); // Image node
                        if (userSpaceNodes.HasChildNodes)
                        {

                            XmlNodeList childNodeList = userSpaceNodes.ChildNodes;
                            for (int j = 0; j < childNodeList.Count; j++)
                            {
                                XmlNode childNode = childNodeList.Item(j);
                                if (childNode.Name == "Location")
                                {
                                    userspace.Location = childNode.InnerText;
                                }
                                if (childNode.Name == "Path")
                                {
                                    userspace.Path = childNode.InnerText;
                                }
                                if (childNode.Name == "Workspace")
                                {
                                    ArchiveObject.Workspace workspace = userspace.Workspace;
                                    if (childNode.HasChildNodes)
                                    {
                                        XmlNodeList masterNodeList = childNode.ChildNodes;
                                        for (int m = 0; m < masterNodeList.Count; m++)
                                        {
                                            XmlNode childMasterNode = masterNodeList.Item(m);
                                            if (childMasterNode.Name == "Location")
                                            {
                                                workspace.Location = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "Path")
                                            {
                                                workspace.Path = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "AutoView")
                                            {
                                                workspace.AutoView = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "AutoCheckout")
                                            {
                                                workspace.AutoCheckout = childMasterNode.InnerText;
                                            }
                                        }
                                    }

                                }

                                if (childNode.Name == "Picture")
                                {
                                    if (childNode.HasChildNodes)
                                    {
                                        ArchiveObject.ImageSpace pictures = userspace.Pictures;
                                        XmlNodeList masterNodeList = childNode.ChildNodes;
                                        for (int m = 0; m < masterNodeList.Count; m++)
                                        {
                                            XmlNode childMasterNode = masterNodeList.Item(m);
                                            if (childMasterNode.Name == "Location")
                                            {
                                                pictures.Location = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "Path")
                                            {
                                                pictures.Path = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "AutoView")
                                            {
                                                pictures.AutoView = childMasterNode.InnerText;
                                            }
                                            
                                        }
                                    }
                                }
                                if (childNode.Name == "wwwImagePath")
                                {
                                    if (childNode.HasChildNodes)
                                    {
                                        ArchiveObject.ImageSpace wwwImages = userspace.WWWImages;
                                        XmlNodeList masterNodeList = childNode.ChildNodes;
                                        for (int m = 0; m < masterNodeList.Count; m++)
                                        {
                                            XmlNode childMasterNode = masterNodeList.Item(m);
                                            if (childMasterNode.Name == "Location")
                                            {
                                                wwwImages.Location = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "Path")
                                            {
                                                wwwImages.Path = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "AutoView")
                                            {
                                                wwwImages.AutoView = childMasterNode.InnerText;
                                            }
                                           
                                        }
                                    }
                                }
                                if (childNode.Name == "Metadata")
                                {
                                    if (childNode.HasChildNodes)
                                    {
                                        ArchiveObject.ImageSpace metadata = userspace.Metadata;
                                        XmlNodeList masterNodeList = childNode.ChildNodes;
                                        for (int m = 0; m < masterNodeList.Count; m++)
                                        {
                                            XmlNode childMasterNode = masterNodeList.Item(m);
                                            if (childMasterNode.Name == "Location")
                                            {
                                                metadata.Location = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "Path")
                                            {
                                                metadata.Path = childMasterNode.InnerText;
                                            }
                                            if (childMasterNode.Name == "AutoView")
                                            {
                                                metadata.AutoView = childMasterNode.InnerText;
                                            }

                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

            /*
            Archive
            Home
                Path           C:\ProgramData\IDK - Software\ImgArchive </ Path >
            Home
     < Vault >
     < MasterArchive >
     < Location > Valid </ Location >
     < Path > d:/ ia / master </ Path >
        < BackupOne >
        < Enabled > False </ Enabled >
        < Location > Not found </ Location >
           < Path > C:\ProgramData\IDK - Software\ImgArchive / backup / MasterBackup1 </ Path >
                </ BackupOne >
                < BackupTwo >
                < Enabled > False </ Enabled >
                < Location > Not found </ Location >
                   < Path > C:\ProgramData\IDK - Software\ImgArchive / backup / MasterBackup2 </ Path >
                        </ BackupTwo >
                        </ MasterArchive >
                        < DerivativeArchive >
                        < Location > Not found </ Location >
                           < Path > d:/ ia / derivative </ Path >
                              < BackupOne >
                              < Enabled > False </ Enabled >
                              < Location > Not found </ Location >
                                 < Path > C:\ProgramData\IDK - Software\ImgArchive / backup / DerivativeBackup1 </ Path >
                                      </ BackupOne >
                                      < BackupTwo >
                                      < Enabled > False </ Enabled >
                                      < Location > Not found </ Location >
                                         < Path > C:\ProgramData\IDK - Software\ImgArchive / backup / DerivativeBackup2 </ Path >
                                              </ BackupTwo >
                                              </ DerivativeArchive >
                                              </ Vault >
                                              < Userspace >
                                              < Location > Not found </ Location >
                                                 < Path > C:\Users\H497222\ImgArchive </ Path >
                                                    < Workspace >
                                                    < Location > Not found </ Location >
                                                       < Path > C:\Users\H497222\ImgArchive\Workspace </ Path >
                                                          < AutoView > On </ AutoView >
                                                          < AutoCheckout > Off </ AutoCheckout >
                                                          </ Workspace >
                                                          < Picture >
                                                          < Location > Not found </ Location >
                                                             < Path > C:\Users\H497222\ImgArchive / Pictures </ Path >
                                                                < AutoView > On </ AutoView >
                                                                </ Picture >
                                                                < wwwImagePath >
                                                                < Location > Not found </ Location >
                                                                   < Path > C:\Users\H497222\ImgArchive / WWWPictures </ Path >
                                                                      < AutoView > Off </ AutoView >
                                                                      </ wwwImagePath >
                                                                      < Metadata >
                                                                      < Location > Not found </ Location >
                                                                         < Path > C:\Users\H497222\ImgArchive /.imga / history </ Path >
                                                                            < AutoView > On </ AutoView >
                                                                            </ Metadata >
                                                                            </ Userspace >
                                                                            </ Archive >
                                                                            0000:Success
                                                                            wpDerivativeBackups_ShowFromNext
            */

        
    }
}
