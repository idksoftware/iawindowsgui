using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace iaforms
{
    public class CSVLogFileReader
    {
        private ImageLog m_ImageLog = null;
        public CSVLogFileReader() { }

        public bool read(string filename)
        {
           
            if (!File.Exists(filename))
            {
                return false;
            }
            m_ImageLog = new ImageLog();

            string line;
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] fields = line.Split(':').Select(str => str.Trim()).ToArray();
                    ImageEvent imageEvent = new ImageEvent();
                    imageEvent.dateAdded = fields[0];
                    imageEvent.comment = fields[5];
                    imageEvent.version = int.Parse(fields[3]);
                    imageEvent.evt = int.Parse(fields[4]);
                    m_ImageLog.events.Add(imageEvent);
                }
            }

            return false;
        }
        public ImageLog getImageLog() { return m_ImageLog; }
    }
}
