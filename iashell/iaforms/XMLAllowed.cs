using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace iaforms
{
    public class XMLAllowed
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        AllowedObject allowedObject = null;
        public XMLAllowed(string xmlString)
        {
            //reader = new XmlTextReader(fileName);
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            allowedObject = new AllowedObject();
        }
        public AllowedObject Allowed { get => allowedObject; }
        public void Process()
        {
            XmlNodeList rootList = document.GetElementsByTagName("AllowedTypes");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNodeList nodeList = document.GetElementsByTagName("Type");
                for (int image = 0; image < nodeList.Count; ++image)
                {
                    XmlNode node = nodeList.Item(image); // Image node
                    if (node.HasChildNodes)
                    {
                        AllowedItem item = new AllowedItem();
                        allowedObject.Add(item);
                        XmlNodeList childNodeList = node.ChildNodes;
                        for (int j = 0; j < childNodeList.Count; j++)
                        {
                            XmlNode childNode = childNodeList.Item(j);
                            if (childNode.Name == "Ext")
                            {
                                //archiveObject.HomePath = childNode.InnerText;
                                Trace.WriteLine(childNode.InnerText);
                                item.Extention = childNode.InnerText;
                            }
                            if (childNode.Name == "ImageType")
                            {
                                //archiveObject.HomePath = childNode.InnerText;
                                Trace.WriteLine(childNode.InnerText);
                                item.ImageType = AllowedItem.GetAllowItemType(childNode.InnerText);
                            }
                            if (childNode.Name == "Mime")
                            {
                                //archiveObject.HomePath = childNode.InnerText;
                                Trace.WriteLine(childNode.InnerText);
                                item.Mime = childNode.InnerText;
                            }
                            if (childNode.Name == "Description")
                            {
                                //archiveObject.HomePath = childNode.InnerText;
                                Trace.WriteLine(childNode.InnerText);
                                item.Description = childNode.InnerText;
                            }
                        }
                    }
                }
            }
        }
    }
}
