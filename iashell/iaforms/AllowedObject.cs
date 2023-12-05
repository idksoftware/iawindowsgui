using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace iaforms
{
    public enum AllowItemType
    {
        Picture,
        Raw,
        Unknown
    }
    public class AllowedItem
    {
        string extention;
        AllowItemType imageType;
        string mime;
        string description;

        public string Extention { get => extention; set => extention = value; }
        public AllowItemType ImageType { get => imageType; set => imageType = value; }
        public string Mime { get => mime; set => mime = value; }
        public string Description { get => description; set => description = value; }

        public static AllowItemType GetAllowItemType(string s)
        {
            if (string.Compare("Picture", s) == 0)
            {
                return AllowItemType.Picture;
            }
            if (string.Compare("Raw", s) == 0)
            {
                return AllowItemType.Raw;
            }
            if (string.Compare("RAW", s) == 0)
            {
                return AllowItemType.Raw;
            }
            return AllowItemType.Unknown;
        }

        
    }
    public class AllowedObject : List<AllowedItem>
    {
        public AllowedItem findExtention(string ext)
        {
            foreach (AllowedItem item in this)
            {
                if (item.Extention == ext)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
