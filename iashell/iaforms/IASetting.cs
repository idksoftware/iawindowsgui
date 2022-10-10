using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace iaforms
{
    
    internal class IASetting
    {
        string m_exePath;
        string m_workingPath; public delegate void ProgressEventHandler();
        XmlTextReader reader = null;
        XmlDocument document = new XmlDocument();

        public static ProgressEventHandler ProgressChanged;
        async Task<bool> readAsync(string exePath, string workingPath)
        {
            m_exePath = exePath;
            m_workingPath = workingPath;
            
            LaunchCommandLine readIAAdmin = LaunchCommandLine.Instance;
            readIAAdmin.ExePath = m_exePath;
            readIAAdmin.Path = m_workingPath;

            LaunchCommandLine.StatusChanged += OnStatusChanged;
            ProgressChanged += OnProgressChanged;
            readIAAdmin.Arguments = "checkin --scope=\"";
            await readIAAdmin.LaunchCommand();

            return true;
        }

        private void OnProgressChanged()
        {
            throw new NotImplementedException();
        }

        private void OnStatusChanged(LaunchCommandLine.Status param)
        {
            throw new NotImplementedException();
        }
    }
}
