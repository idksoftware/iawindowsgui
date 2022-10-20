using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using iaforms;

namespace IDK.Gui
{

    public class CtrlCheckBoxReadOnly : System.Windows.Forms.CheckBox
    {
        [Category("Appearance")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public bool ReadOnly { get; set; }

        protected override void OnClick(EventArgs e)
        {
            if (!ReadOnly) base.OnClick(e);
        }
    }
}