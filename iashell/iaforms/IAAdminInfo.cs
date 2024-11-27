using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iaforms
{
    public class IAAdminInfo
    {
        public static bool UnSavedChanges { get; set; }
        public static string ExePath { get; set; }
        public static string WorkingPath { get; set; }
        public static string FilePath { get; set; }

        //public static bool UnSavedChanges
        //{
        //    get { return m_UnSavedChanges; }
        //    set { m_UnSavedChanges = value; }
        //}
    }
}
