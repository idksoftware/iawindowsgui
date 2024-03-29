﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using iaforms;

namespace iatray
{
    public partial class FolderImportForm : Form
    {
        public FolderImportForm()
        {
            InitializeComponent();
        }
        
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.importSourceBrowserDialog.ShowDialog();
            if (result==DialogResult.OK)
            {
                string foldername = this.importSourceBrowserDialog.SelectedPath;
                //foreach (string f in Directory.GetFiles(foldername))
                //    this.listBox1.Items.Add(f); 
                Debug.Print(
                    "folder name:{0, 15}",
                    foldername);
                this.importFolder.Text = foldername;
            }
            


        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ImportQueue.Instance.Add(this.importFolder.Text, this.checkBoxSubFolders.Checked);
            
        }

        private void buttonMetadata_Click(object sender, EventArgs e)
        {
            (new MetadataForm()).Show();
        }
    }
}
