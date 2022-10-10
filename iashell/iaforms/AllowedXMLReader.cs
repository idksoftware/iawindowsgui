using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iaforms
{
    class AllowedXMLReader
    {
        public class AllowItem
        {
            public enum AllowItemType
            {
                Picture,
                Raw,
                Unknown
            }
            public string Ext;
            public AllowItemType type;
            public string mime;
            public string discription;
        }


    }
}
