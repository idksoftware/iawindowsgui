﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iaadmingui
{
    public partial class SyncUC : UserControl, IViewPage
    {
        public SyncUC()
        {
            InitializeComponent();
        }

        public void Reset()
        {

        }
        public void Apply()
        {

        }
        public bool isChanged()
        {
            return false;
        }

    }
}
