using iaadmingui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaadmingui
{
    public interface IViewPage
    {
        bool CanClose();
    }

    public class UnSavedChanges
    {
        public static bool m_UnSavedChanges;
    }
   
}

