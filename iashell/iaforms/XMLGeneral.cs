using iaforms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace iaforms
{
    public class GeneralObject
    {
        public string m_loglevel;
        public string m_consolelevel;
        public string m_sqlDatabase;
        public string m_silentOn;
        public string m_quietOn;
    }


    public class XMLGeneral
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        GeneralObject generalObject = null;
        public XMLGeneral(string xmlString)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            generalObject = new GeneralObject();
        }
        public GeneralObject General { get => generalObject; }

        public void Process()
        {
            XmlNodeList rootList = document.GetElementsByTagName("GeneralSettings");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNode node = rootList.Item(i); // Image node
                if (node.HasChildNodes)
                {

                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "Loglevel")
                        {
                            generalObject.m_loglevel = childNode.InnerText;
                        }
                        if (childNode.Name == "Consolelevel")
                        {
                            generalObject.m_consolelevel = childNode.InnerText;
                        }
                        if (childNode.Name == "SQLDatabase")
                        {
                            generalObject.m_sqlDatabase = childNode.InnerText;
                        }
                        if (childNode.Name == "SilentOn")
                        {
                            generalObject.m_silentOn = childNode.InnerText;
                        }
                        if (childNode.Name == "QuietOn")
                        {
                            generalObject.m_quietOn = childNode.InnerText;
                        }

                        
                    }
                }
            }
        }
    }
    public class FoldersObject
    {

        public string m_configurationPath;
        public string m_systemPath;
        public string m_logPath;
        public string m_toolsPath;
        public string m_hookPath;
        public string m_historyPath;
        public string m_sqlDatabasePath;
        public string m_templatesPath;
        public string m_tempPath;
    }

    public class XMLFolders
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        FoldersObject foldersObject = null;
        public XMLFolders(string xmlString)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            foldersObject = new FoldersObject();
        }

        public FoldersObject Folders { get => foldersObject; }

        public void Process()
        {
            XmlNodeList rootList = document.GetElementsByTagName("ApplicationPaths");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNode node = rootList.Item(i); // Image node
                if (node.HasChildNodes)
                {

                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "ConfigurationPath")
                        {
                            foldersObject.m_configurationPath = childNode.InnerText;
                        }
                        if (childNode.Name == "SystemPath")
                        {
                            foldersObject.m_systemPath = childNode.InnerText;
                        }
                        if (childNode.Name == "LogPath")
                        {
                            foldersObject.m_logPath = childNode.InnerText;
                        }
                        if (childNode.Name == "ToolsPath")
                        {
                            foldersObject.m_toolsPath = childNode.InnerText;
                        }
                        if (childNode.Name == "HookPath")
                        {
                            foldersObject.m_hookPath = childNode.InnerText;
                        }
                        if (childNode.Name == "HistoryPath")
                        {
                            foldersObject.m_historyPath = childNode.InnerText;
                        }
                        if (childNode.Name == "SQLDatabasePath")
                        {
                            foldersObject.m_sqlDatabasePath = childNode.InnerText;
                        }
                        if (childNode.Name == "TemplatesPath")
                        {
                            foldersObject.m_templatesPath = childNode.InnerText;
                        }
                        if (childNode.Name == "TempPath")
                        {
                            foldersObject.m_tempPath = childNode.InnerText;
                        }

                    }
                }
            }
        }
    }
    
    public class NetworkObject
    {
      
        public string m_EventsOn;
        public string m_EventPort;
        public string m_EventAddress;
        public string m_CommandOn;
        public string m_CommandPort;
     
    }

    public class XMLNetwork
    {
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        NetworkObject networkObject = null;
        public XMLNetwork(string xmlString)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

            MemoryStream stream = new MemoryStream(byteArray);
            document.Load(stream);
            networkObject = new NetworkObject();
        }

        public NetworkObject Network { get => networkObject; }

        public void Process()
        {
            XmlNodeList rootList = document.GetElementsByTagName("NetworkSettings");
            for (int i = 0; i < rootList.Count; ++i)
            {
                XmlNode node = rootList.Item(i); // Image node
                if (node.HasChildNodes)
                {

                    XmlNodeList childNodeList = node.ChildNodes;
                    for (int j = 0; j < childNodeList.Count; j++)
                    {
                         
                        XmlNode childNode = childNodeList.Item(j);
                        if (childNode.Name == "EventsOn")
                        {
                            networkObject.m_EventsOn = childNode.InnerText;
                        }
                        if (childNode.Name == "EventPort")
                        {
                            networkObject.m_EventPort = childNode.InnerText;
                        }
                        if (childNode.Name == "EventAddress")
                        {
                            networkObject.m_EventAddress = childNode.InnerText;
                        }
                        if (childNode.Name == "CommandOn")
                        {
                            networkObject.m_CommandOn = childNode.InnerText;
                        }
                        if (childNode.Name == "CommandPort")
                        {
                            networkObject.m_CommandPort = childNode.InnerText;
                        }
                        

                    }
                }
            }
        }
    }
}
