using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string imageaddress;
        public List<ImageEvent> events;

        public ImageLog()
        {
            events = new List<ImageEvent>();
        }
    }

    public class ImageLogs : List<ImageLog> { }
    
}
