using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Diagnostics;

namespace iaforms
{

    public class ImageEvent
    {
        public string dateAdded;
        public int version;
        public int evt;
        public string comment;
    }
    public class ImageLog
    {
        public string filename;
        public string path;
        public List<ImageEvent> events;

        public ImageLog()
        {
            events = new List<ImageEvent>();
        }
    }

    public class ImageLogs : List<ImageLog> {}


    public class XMLLogReader
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        ImageLogs imageLogs = null;

        public ImageLogs ImageLogs
        {
            get
            {
                return imageLogs;
            }
        }

        public XMLLogReader(string fileName)
        {
            reader = new XmlTextReader(fileName);
            document.Load(fileName);
            imageLogs = new ImageLogs();
        }

        public void Process()
        {
            //reader.Read();
            //document.Load(reader);
            
            XmlNodeList rootList = document.GetElementsByTagName("Images");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNodeList nodeList = document.GetElementsByTagName("Image");
                for (int image = 0; image < nodeList.Count; ++image)
                {
                    XmlNode node = nodeList.Item(i);
                    if (node.HasChildNodes)
                    {
                        XmlNodeList childImageList = node.ChildNodes;
                        for (int j = 0; j < childImageList.Count; j++)
                        {
                            ImageLog imageLog = new ImageLog();
                            imageLogs.Add(imageLog);
                            XmlNode childNode = childImageList.Item(j);
                            if (childNode.Name == "Address")
                            {
                                XmlNodeList childFileListList = childNode.ChildNodes;
                                for (int k = 0; k < childFileListList.Count; k++)
                                {
                                    XmlNode childFileNode = childFileListList.Item(j);
                                    if (childFileNode.Name == "Filename")
                                    {
                                        imageLog.filename = childNode.InnerText;
                                        continue;
                                    }
                                    if (childFileNode.Name == "Filepath")
                                    {
                                        imageLog.filename = childNode.InnerText;
                                        continue;
                                    }
                                }
                                continue;
                            }
                            if (childNode.Name == "EventList")
                            {
                                XmlNodeList nodeEventList = document.GetElementsByTagName("Event");
                                for (int evt = 0; evt < nodeEventList.Count; ++evt)
                                {
                                    XmlNode evtNode = nodeEventList.Item(evt);
                                    if (evtNode.HasChildNodes)
                                    {
                                        XmlNodeList childEventItemList = evtNode.ChildNodes;
                                        for (int k = 0; k < childEventItemList.Count; k++)
                                        {
                                            ImageEvent Evt = new ImageEvent();

                                            imageLog.events.Add(Evt);
                                            XmlNode evtNodeItem = childEventItemList.Item(k);
                                            if (evtNodeItem.Name == "DateAdded")
                                            {
                                                Evt.dateAdded = evtNodeItem.InnerText;
                                                continue;
                                            }
                                            if (evtNodeItem.Name == "Version")
                                            {
                                                Evt.version = Int16.Parse(evtNodeItem.InnerText);
                                                continue;
                                            }
                                            if (evtNodeItem.Name == "Event")
                                            {
                                                Evt.evt = Int16.Parse(evtNodeItem.InnerText);
                                                continue;
                                            }
                                            if (evtNodeItem.Name == "Comment")
                                            {
                                                Evt.comment = evtNodeItem.InnerText;
                                                continue;
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
    }
}
