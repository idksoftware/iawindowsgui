using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace iaforms
{
    public class AllowedXMLWriter
    {
        public static bool write(AllowItems allowItems)
        {
            var xmlTextWriter = new XmlTextWriter("products.xml", Encoding.UTF8) { Formatting = Formatting.Indented };
            //start the xml document
            xmlTextWriter.WriteStartDocument();
            //start the element
            xmlTextWriter.WriteStartElement("AllowedTypes");
            foreach (var item in allowItems)
            {
                
                xmlTextWriter.WriteStartElement("Type");
                xmlTextWriter.WriteElementString("Ext", item.ext);
                if (item.type == AllowItem.AllowItemType.Picture)
                {
                    xmlTextWriter.WriteElementString("ImageType", "Picture");
                } else
                {
                    xmlTextWriter.WriteElementString("ImageType", "RAW");
                }
                
                xmlTextWriter.WriteElementString("Mime", item.mime);
                xmlTextWriter.WriteElementString("Description", item.description);
                xmlTextWriter.WriteEndElement();
            }
            
            //end xml element
            xmlTextWriter.WriteEndElement();
            //end the xml document
            xmlTextWriter.WriteEndDocument();
            //close this as well as the underlying stream
            xmlTextWriter.Close();
            return true;
        }
    }

}
