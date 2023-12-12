using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace iaforms
{
    public class ExifToolObject
    {
        private string enabled;
        private string exifMapFile;
        private string exifMapPath;
        private string exifTool;
        private string exifToolPath;
        private string commandLine;
        private string exifFileDelim;

        public string Enabled { get => enabled; set => enabled = value; }
        public string ExifMapFile { get => exifMapFile; set => exifMapFile = value; }
        public string ExifMapPath { get => exifMapPath; set => exifMapPath = value; }
        public string ExifTool { get => exifTool; set => exifTool = value; }
        public string ExifToolPath { get => exifToolPath; set => exifToolPath = value; }
        public string ExifFileDelim { get => exifFileDelim; set => exifFileDelim = value; }
        public string CommandLine { get => commandLine; set => commandLine = value; }
    }

    public class XMLExifTool
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        ExifToolObject exifToolObject = null;
        public XMLExifTool(string xmlString)
        {
            //reader = new XmlTextReader(fileName);
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            exifToolObject = new ExifToolObject();
        }

        public ExifToolObject ExifToolObject { get => exifToolObject; }
        public void Process()
        {

            /*
     <Enabled>False</Enabled>
 <ExifMapFile>exiftool.ini</ExifMapFile>
 <ExifMapPath>C:\ProgramData/IDK-Software/ImgArchive/config</ExifMapPath>
 <ExifTool>exiftool.exe</ExifTool>
 <ExifToolPath>C:\ProgramData/IDK-Software/ImgArchive/config</ExifToolPath>
 <ExifCommandLine>[source]</ExifCommandLine>
 <ExifFileDelim>:</ExifFileDelim>
     */

            XmlNodeList rootList = document.GetElementsByTagName("ExternalExifTool");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNode node = rootList.Item(i); // Image node
                if (node.HasChildNodes)
                {

                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Enabled")
                        {
                            exifToolObject.Enabled = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifTool")
                        {
                            exifToolObject.ExifTool = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifToolPath")
                        {
                            exifToolObject.ExifToolPath = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifCommandLine")
                        {
                            exifToolObject.CommandLine = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifMapFile")
                        {
                            exifToolObject.ExifMapFile = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifMapPath")
                        {
                            exifToolObject.ExifMapPath = childNode.InnerText;
                        }
                        if (childNode.Name == "ExifFileDelim")
                        {
                            exifToolObject.ExifFileDelim = childNode.InnerText;
                        }
                    }
                }
            }
        }
    }
}
