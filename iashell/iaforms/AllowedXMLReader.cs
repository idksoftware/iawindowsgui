using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace iaforms
{
    
    
    /*
    public class AllowedXMLReader
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        AllowItems allowItems = null;

        public static AllowItem.AllowItemType GetAllowItemType(string s)
        {
            if (string.Compare("Picture", s) == 0) {
                return AllowItem.AllowItemType.Picture;
            }
            if (string.Compare("RAW", s) == 0) {
                return AllowItem.AllowItemType.Raw;
            }
            return AllowItem.AllowItemType.Unknown;
        }

        public AllowItems AllowItems
        {
            get
            {
                return allowItems;
            }
        }


        public AllowedXMLReader(string xmlString)
        {
            //XmlTextReader reader = new XmlTextReader(fileName);
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            allowItems = new AllowItems();
        }
        
        
        public void Process()
        {
            XmlNodeList rootList = document.GetElementsByTagName("AllowedTypes");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNodeList nodeList = document.GetElementsByTagName("Type");
                for (int type = 0; type < nodeList.Count; ++type)
                {
                    AllowItem allowItem = new AllowItem();
                    allowItems.Add(allowItem);
                    XmlNode node = nodeList.Item(type); // Image node
                    if (node.HasChildNodes)
                    {
                        //AllowItem allowItem = new AllowItem();
                        //allowItems.Add(allowItem);
                        XmlNodeList childImageList = node.ChildNodes;
                        for (int j = 0; j < childImageList.Count; j++)
                        {
                            XmlNode childNode = childImageList.Item(j);

                            if (childNode.Name == "Ext")
                            {
                                allowItem.ext = childNode.InnerText;
                                continue;
                            }
                            if (childNode.Name == "ImageType")
                            {
                                allowItem.type = GetAllowItemType(childNode.InnerText);
                                continue;
                            }
                            if (childNode.Name == "Mime")
                            {
                                allowItem.mime = childNode.InnerText;
                                continue;
                            }
                            if (childNode.Name == "Description")
                            {
                                allowItem.description = childNode.InnerText;
                                continue;
                            }

                         
                        }
                    }
                }
            }
           

        }

        
    }
*/
}

