using iaforms;
using System;
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
        private string m_archive;
        private string m_backup;    
        public SyncUC()
        {
            InitializeComponent();
        }

        public void Reset()
        {

        }
        public void Apply()
        {
            
            switch (tabControlSync.SelectedTab.TabIndex)
            {
                case 0:
                    if ((m_archive == null) || (m_backup == null))
                    {
                        const string message =
                            "Archive or backup not defined";
                        const string caption = "ImgArchive - error";
                        var result = MessageBox.Show(message, caption,
                            MessageBoxButtons.OK);
                        return;
                    }
                    (new SyncArchiveForm(m_archive, m_backup)).Show();
                    break;
                case 1:
                    (new SyncArchiveForm(m_archive, m_backup)).Show();
                    break;
            }
        }
        public bool isChanged()
        {
            return false;
        }

        private void SyncUC_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaster.Checked == true)
            {
                m_archive = "Master";
                checkBoxBothRepositories.Checked = false;
                checkBoxDerivative.Checked = false;
            }
           
        }

        private void checkBoxDerivative_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDerivative.Checked == true)
            {
                m_archive = "Derivative";
                checkBoxBothRepositories.Checked = false;
                checkBoxMaster.Checked = false;
            }
            
        }

        private void checkBoxBothRepositories_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBothRepositories.Checked == true)
            {
                m_archive = "both";
                checkBoxDerivative.Checked = false;
                checkBoxMaster.Checked = false;
            }
            
        }

        private void checkBoxBackupOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackupOne.Checked == true)
            {
                m_backup = "BackupOne";
                checkBoxBackupTwo.Checked = false;
                checkBoxBothBackups.Checked = false;
            }
        }

        private void checkBoxBackupTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackupTwo.Checked == true)
            {
                m_backup = "BackupTwo";
                checkBoxBackupOne.Checked = false;
                checkBoxBothBackups.Checked = false;
            }
        }

        private void checkBoxBothBackups_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBothBackups.Checked == true)
            {
                m_backup = "Both";
                checkBoxBackupOne.Checked = false;
                checkBoxBackupTwo.Checked = false;
            }
        }
    }
}
