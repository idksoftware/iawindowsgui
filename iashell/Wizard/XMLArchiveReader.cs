using System;
using System.Collections.Generic;
using System.Xml;
using System.Diagnostics;

public class Location
{
    public String LocationPath { get; set; }
    public bool LocationFound { get; set; }

    public void read(XmlNodeList childNodeList)
    {
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Location")
            {
                LocationFound = (childNode.InnerText == "Valid");
            }
            if (childNode.Name == "Path")
            {
                LocationPath = childNode.InnerText;
            }
        }
    }

    public void Print()
    {
        Trace.WriteLine("Location Found = " + LocationFound + " Path = " + LocationPath); 
    }
}

public class Backup
{
    public bool Enabled { get; set; }
    public Location BackupLocation { get; set; } = new Location();
    
    public void read(XmlNode node)
    {
        XmlNodeList childNodeList = node.ChildNodes;
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Enabled")
            {
                Enabled = (childNode.InnerText == "True");
            }
            if (childNode.Name == "Location")
            {
                BackupLocation.LocationFound = (childNode.InnerText == "Valid");
            }
            if (childNode.Name == "Path")
            {
                BackupLocation.LocationPath = childNode.InnerText;
            }
        }
    }
    public void Print(int num)
    {
        Trace.WriteLine("Backup" + num);
        BackupLocation.Print();
        Trace.WriteLine("Enabled: " + Enabled);
    }
}
public class ArchiveBase
{
    //Location m_archiveLocation;
    public Location ArchiveLocation { get; set; } = new Location();
    public Backup Backup1 { get; set; } = new Backup();
    public Backup Backup2 { get; set; } = new Backup();

    public ArchiveBase()
    {}

    public void read(XmlNode node)
    {
        
        XmlNodeList childNodeList = node.ChildNodes;
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Location")
            {
                ArchiveLocation.read(childNodeList);
            }
            if (childNode.Name == "BackupOne")
            {
                Backup1.read(childNode);
            }
            if (childNode.Name == "BackupTwo")
            {
                Backup2.read(childNode);
            }

        }
    }
    public void Print()
    {   
        ArchiveLocation.Print();
        Backup1.Print(1);
        Backup1.Print(2);
    }

}

public class MasterArchive : ArchiveBase
{
    public void Print()
    {
        Trace.WriteLine("Master Archive");
        base.Print();

    }
}

public class DerivativeArchive : ArchiveBase
{
    public void Print()
    {
        Trace.WriteLine("Derivative Archive");
        base.Print();

    }
}

public class Vault
{
    public MasterArchive MasterArchive { get; set; } = new MasterArchive();
    public DerivativeArchive DerivativeArchive { get; set; } = new DerivativeArchive();

    public Vault()
    {}

    public void read(XmlNode node)
    {
        XmlNodeList childNodeList2 = node.ChildNodes;
        for (int c = 0; c < childNodeList2.Count; c++)
        {
            XmlNode childNode2 = childNodeList2.Item(c);
            if (childNode2.Name == "MasterArchive")
            {

                MasterArchive.read(childNode2);
            }
            if (childNode2.Name == "DerivativeArchive")
            {

                DerivativeArchive.read(childNode2);
            }
        }
    }

    public void Print()
    {
        Trace.WriteLine("Vault");
        MasterArchive.Print();
        DerivativeArchive.Print();
    }
}

public class Workspace
{
    public Location WorkspaceLocation { get; set; } = new Location();
    public bool AutoView { get; set; }
    public bool AutoCheckout { get; set; }
    public Workspace()
    {}

    public void read(XmlNode node)
    {
        XmlNodeList childNodeList = node.ChildNodes;
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Location")
            {
                WorkspaceLocation.read(childNodeList);
            }
            if (childNode.Name == "AutoView")
            {
                AutoView = (childNode.InnerText == "On");
            }
            if (childNode.Name == "AutoCheckout")
            {
                AutoCheckout = (childNode.InnerText == "On");
            }
        }
    }
    public void Print()
    {
        WorkspaceLocation.Print();
        Trace.WriteLine("AutoView: " + AutoView);
        Trace.WriteLine("AutoCheckout: " + AutoView);
    }
}

public class Picture
{
    public Location PictureLocation { get; set; } = new Location();
    public bool AutoView { get; set; }
    public Picture()
    {}

    public void read(XmlNode node)
    {
        XmlNodeList childNodeList = node.ChildNodes;
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Location")
            {
                PictureLocation.read(childNodeList);
            }
            if (childNode.Name == "AutoView")
            {
                AutoView = (childNode.InnerText == "On");
            }
            
        }
    }
    public void Print()
    {
        Trace.WriteLine("Picture");
        PictureLocation.Print();
        Trace.WriteLine("AutoView: " + AutoView);
    }
}

public class WWWImages
{
    public Location WWWImagesLocation { get; set; } = new Location();
    public bool AutoView { get; set; }
    public WWWImages()
    {}

    public void read(XmlNode node)
    {
        XmlNodeList childNodeList = node.ChildNodes;
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Location")
            {
                WWWImagesLocation.read(childNodeList);
            }
            if (childNode.Name == "AutoView")
            {
                AutoView = (childNode.InnerText == "On");
            }

        }
    }
    public void Print()
    {
        Trace.WriteLine("WWWImages");
        WWWImagesLocation.Print();
        Trace.WriteLine("AutoView: " + AutoView);
    }
}

public class Metadata
{
    public Location MetadataLocation { get; set; } = new Location();
    public Metadata()
    {}

    public void read(XmlNode node)
    {
        XmlNodeList childNodeList = node.ChildNodes;
        for (int c = 0; c < childNodeList.Count; c++)
        {
            XmlNode childNode = childNodeList.Item(c);
            if (childNode.Name == "Location")
            {
                MetadataLocation.read(childNodeList);
            }
        }
    }
    public void Print()
    {
        Trace.WriteLine("Metadata");
        MetadataLocation.Print();
    }
}

public class Userspace
{
    public Location UserspaceLocation { get; set; } = new Location();
    public Workspace Workspace { get; set; } = new Workspace();
    public Picture Picture { get; set; } = new Picture();
    public WWWImages WWWImages { get; set; } = new WWWImages();
    public Metadata Metadata { get; set; } = new Metadata();

    public Userspace()
    {}

    public void read(XmlNode node)
    {
        XmlNodeList childNodeList2 = node.ChildNodes;
        for (int c = 0; c < childNodeList2.Count; c++)
        {
            XmlNode childNode2 = childNodeList2.Item(c);
            if (childNode2.Name == "Location")
            {
                UserspaceLocation.LocationFound = (childNode2.InnerText == "Valid"); ;
            }
            if (childNode2.Name == "Path")
            {
                UserspaceLocation.LocationPath = childNode2.InnerText;
            }
            if (childNode2.Name == "Workspace")
            {

                Workspace.read(childNode2);
            }
            if (childNode2.Name == "Picture")
            {

                Picture.read(childNode2);
            }
            if (childNode2.Name == "WWWImages")
            {

                WWWImages.read(childNode2);
            }
            if (childNode2.Name == "Metadata")
            {
                Metadata.read(childNode2);
            }
        } 
    }
    public void Print()
    {
        Trace.WriteLine("Userspace");
        UserspaceLocation.Print();
        Workspace.Print();
        Picture.Print();
        WWWImages.Print();
        Metadata.Print();
    }
}

public class ArchiveProperties
{
    public Vault Vault { get; set; } = new Vault();
    public Userspace Userspace { get; set; } = new Userspace();

    public ArchiveProperties()
    {}

    public void read(XmlNodeList nodeList)
    {
        for (int a = 0; a < nodeList.Count; ++a)
        {
            //Debug.Write(nodeList.Item(i).Name);
            XmlNode node = nodeList.Item(a);
            if (node.HasChildNodes)
            {

                XmlNodeList childNodeList1 = node.ChildNodes;
                for (int b = 0; b < childNodeList1.Count; b++)
                {
                    XmlNode childNode1 = childNodeList1.Item(b);
                    if (childNode1.Name == "Vault")
                    {
                        Vault.read(childNode1);
                    }
                    if (childNode1.Name == "Userspace")
                    {
                        Userspace.read(childNode1);
                    }
                }
            }
        }
    }
    public void Print()
    {
        Vault.Print();
        Userspace.Print();
    }
}

namespace IDK.Gui
{
    internal class XMLArchiveReader
    {
        public ArchiveProperties ArchiveProperties { get; set; } = new ArchiveProperties();

        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        public XMLArchiveReader(string fileName)
        {
            
            reader = new XmlTextReader(fileName);
            //document.Load(fileName);

        }

        public XMLArchiveReader()
        {
        }

        public void read()
        {
            reader.Read();
            document.Load(reader);
            
            XmlNodeList nodeList = document.GetElementsByTagName("Archive");
            ArchiveProperties.read(nodeList);
            ArchiveProperties.Print();
        }
        
    }
}
