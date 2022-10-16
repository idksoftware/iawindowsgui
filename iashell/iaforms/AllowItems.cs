using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iaforms
{
    public class AllowItem
    {
        public enum AllowItemType
        {
            Picture,
            Raw,
            Unknown
        }
        public string ext;
        public AllowItemType type;
        public string mime;
        public string description;
    }

    public class AllowItems : List<AllowItem> { }
}
