using iaforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iaforms.ArchiveObject;

namespace iaadmingui
{
    public partial class TemplateUC : IAUserControl, IViewPage
    {
        //public String PathLocation { get { return pathLocation; } }
        int level = 2; // 0 = all 1 = current 2 = base
        XMLTemplate m_xmlTemplate = null;
        TemplateObject m_templateObject = null;
        bool isAppled = false;
        public TemplateUC()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            textBoxDescription.Text = m_templateObject.Description;
            textBoxLabel.Text = m_templateObject.Label;
            textBoxTitle.Text = m_templateObject.Title;

            textBoxSubject.Text = m_templateObject.Subject;
            textBoxRating.Text = m_templateObject.Rating;
            textBoxRatingPercent.Text = m_templateObject.RatingPercent;
            textBoxComment.Text = m_templateObject.Comment;
            textBoxAuthor.Text = m_templateObject.Author;
            textBoxCopyright.Text = m_templateObject.Copyright;
            //m_templateObject.Tags;
            //m_templateObject.Keywords;
            // Origin
            

            // Cammara
            
            textBoxMake.Text = m_templateObject.Maker;
            textBoxModel.Text = m_templateObject.Model;

            // Location
            textBoxLatitude.Text = m_templateObject.Latitude;
            textBoxLongitude.Text = m_templateObject.Longitude;
            textBoxLocation.Text = m_templateObject.Location;
            textBoxScene.Text = m_templateObject.Scene;

        // IPTC
            textBoxSourceUrl.Text = m_templateObject.SourceURL;
            textBoxUsageRights.Text = m_templateObject.UsageRights;
            textBoxCopyrightUrl.Text = m_templateObject.CopyrightURL;
            textBoxHeadline.Text = m_templateObject.Headline;
            textBoxCategory.Text = m_templateObject.Category;
            textBoxSource.Text = m_templateObject.Source;
            textBoxInstructions.Text = m_templateObject.Instructions;

            textBoxCreator.Text = m_templateObject.Creator;
            textBoxJobTitle.Text = m_templateObject.JobTitle;
            textBoxAddress.Text = m_templateObject.Address;
            textBoxCity.Text = m_templateObject.City;
            textBoxState.Text = m_templateObject.State;
            textBoxPostalCode.Text = m_templateObject.PostalCode;
            textBoxCountry.Text = m_templateObject.Country;
            textBoxPhone.Text = m_templateObject.Phone;
            textBoxEmail.Text = m_templateObject.Email;
            textBoxWebsite.Text = m_templateObject.Website;
       
        }
        public void Apply()
        {
            if (textBoxDescription.Text != m_templateObject.Description)
			{
                updateProperty("Description", textBoxDescription.Text);

            }
            if (textBoxLabel.Text != m_templateObject.Label)
			{
			}
            if (textBoxTitle.Text != m_templateObject.Title)
			{
			}
            if (textBoxSubject.Text != m_templateObject.Subject)
			{
			}
            if (textBoxRating.Text != m_templateObject.Rating)
			{
			}
            if (textBoxRatingPercent.Text != m_templateObject.RatingPercent)
			{
			}
            if (textBoxComment.Text != m_templateObject.Comment)
			{
			}
            if (textBoxAuthor.Text != m_templateObject.Author)
			{
			}
            if (textBoxCopyright.Text != m_templateObject.Copyright)
			{
			}
            
            //m_templateObject.Tags;
            //m_templateObject.Keywords;
            // Origin


            // Cammara

            if (textBoxMake.Text != m_templateObject.Maker)
			{
			}
            if (textBoxModel.Text != m_templateObject.Model)
			{
			}
            

            // Location
			if (textBoxLatitude.Text != m_templateObject.Latitude)
			{
			}
            if (textBoxLongitude.Text != m_templateObject.Longitude)
			{
			}
            if (textBoxLocation.Text != m_templateObject.Location)
			{
			}
			if (textBoxScene.Text != m_templateObject.Scene)
			{
			}

            // IPTC
            if (textBoxSourceUrl.Text != m_templateObject.SourceURL)
			{
			}
            if (textBoxUsageRights.Text != m_templateObject.UsageRights)
			{
			}
            if (textBoxCopyrightUrl.Text != m_templateObject.CopyrightURL)
			{
			}
            if (textBoxHeadline.Text != m_templateObject.Headline)
			{
			}
            if (textBoxCategory.Text != m_templateObject.Category)
			{
			}
            if (textBoxSource.Text != m_templateObject.Source)
			{
			}
            if (textBoxInstructions.Text != m_templateObject.Instructions)
			{
			}
            if (textBoxCreator.Text != m_templateObject.Creator)
			{
			}
            if (textBoxJobTitle.Text != m_templateObject.JobTitle)
			{
			}
            if (textBoxAddress.Text != m_templateObject.Address)
			{
			}
            if (textBoxCity.Text != m_templateObject.City)
			{
			}
            if (textBoxState.Text != m_templateObject.State)
			{
			}
            if (textBoxPostalCode.Text != m_templateObject.PostalCode)
			{
			}
            if (textBoxCountry.Text != m_templateObject.Country)
			{
			}
            if (textBoxPhone.Text != m_templateObject.Phone)
			{
			}
            if (textBoxEmail.Text != m_templateObject.Email)
			{
			}
            if (textBoxWebsite.Text != m_templateObject.Website)
			{
			}
           
        }
        public bool isChanged()
        {
			if (textBoxDescription.Text != m_templateObject.Description)
			{
				return true;
			}
            if (textBoxLabel.Text != m_templateObject.Label)
			{
				return true;
			}
            if (textBoxTitle.Text != m_templateObject.Title)
			{
				return true;
			}
            if (textBoxSubject.Text != m_templateObject.Subject)
			{
				return true;
			}
            if (textBoxRating.Text != m_templateObject.Rating)
			{
				return true;
			}
            if (textBoxRatingPercent.Text != m_templateObject.RatingPercent)
			{
				return true;
			}
            if (textBoxComment.Text != m_templateObject.Comment)
			{
				return true;
			}
            if (textBoxAuthor.Text != m_templateObject.Author)
			{
				return true;
			}
            if (textBoxCopyright.Text != m_templateObject.Copyright)
			{
				return true;
			}
            
            //m_templateObject.Tags;
            //m_templateObject.Keywords;
            // Origin


            // Cammara

            if (textBoxMake.Text != m_templateObject.Maker)
			{
				return true;
			}
            if (textBoxModel.Text != m_templateObject.Model)
			{
				return true;
			}
            

            // Location
			if (textBoxLatitude.Text != m_templateObject.Latitude)
			{
				return true;
			}
            if (textBoxLongitude.Text != m_templateObject.Longitude)
			{
				return true;
			}
            if (textBoxLocation.Text != m_templateObject.Location)
			{
				return true;
			}
			if (textBoxScene.Text != m_templateObject.Scene)
			{
				return true;
			}

            // IPTC
            if (textBoxSourceUrl.Text != m_templateObject.SourceURL)
			{
				return true;
			}
            if (textBoxUsageRights.Text != m_templateObject.UsageRights)
			{
				return true;
			}
            if (textBoxCopyrightUrl.Text != m_templateObject.CopyrightURL)
			{
				return true;
			}
            if (textBoxHeadline.Text != m_templateObject.Headline)
			{
				return true;
			}
            if (textBoxCategory.Text != m_templateObject.Category)
			{
				return true;
			}
            if (textBoxSource.Text != m_templateObject.Source)
			{
				return true;
			}
            if (textBoxInstructions.Text != m_templateObject.Instructions)
			{
				return true;
			}
            if (textBoxCreator.Text != m_templateObject.Creator)
			{
				return true;
			}
            if (textBoxJobTitle.Text != m_templateObject.JobTitle)
			{
				return true;
			}
            if (textBoxAddress.Text != m_templateObject.Address)
			{
				return true;
			}
            if (textBoxCity.Text != m_templateObject.City)
			{
				return true;
			}
            if (textBoxState.Text != m_templateObject.State)
			{
				return true;
			}
            if (textBoxPostalCode.Text != m_templateObject.PostalCode)
			{
				return true;
			}
            if (textBoxCountry.Text != m_templateObject.Country)
			{
				return true;
			}
            if (textBoxPhone.Text != m_templateObject.Phone)
			{
				return true;
			}
            if (textBoxEmail.Text != m_templateObject.Email)
			{
				return true;
			}
            if (textBoxWebsite.Text != m_templateObject.Website)
			{
				return true;
			}
            return false;
        }

        private async void GetProperties()
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            switch (level)
            {
                case 0:
                    launchCommand.Arguments = "template --level=all --format-type=xml --silent";
                    break;
                case 1:
                    launchCommand.Arguments = "template --level=current --format-type=xml --silent";
                    break;
                case 2:
                    launchCommand.Arguments = "template --level=base --format-type=xml --silent";
                    break;
            }
            //launchCommand.Arguments = "template --level=all --format-type=xml --silent";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            
            m_xmlTemplate = new XMLTemplate(output);
            m_xmlTemplate.Process();
            m_templateObject = m_xmlTemplate.TemplateObject;

            
            Trace.WriteLine(output);
            Reset();
        }

        private async void updateProperty(string prop, string value)
        {
            IDK.Gui.LaunchAdmin launchCommand = IDK.Gui.LaunchAdmin.Instance;
            launchCommand.ExePath = UpdateChanges.ExePath;
            launchCommand.Path = UpdateChanges.WorkingPath;
            launchCommand.Arguments = "template --level=current --set " + prop + "=\"" + value + "\" --format-type=xml --silent";
            launchCommand.FilePath = UpdateChanges.FilePath;

            await launchCommand.LaunchCommand();
            string output = launchCommand.Output;
            if (launchCommand.ProcessExitCode == IDK.Gui.LaunchAdmin.ExitCode.Fatal)
            {
                string box_msg = output;

                string box_title = "ImgArchive Error";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }

            

            Trace.WriteLine(output);
            GetProperties();
        }

        private void TemplateUC_Load(object sender, EventArgs e)
        {
            Trace.WriteLine("TemplateUC_Load");
            GetProperties();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            groupBoxSelectedTemplete.Text = "All Properties";
            level = 0;
            GetProperties();
        }

        private void buttonCurrent_Click(object sender, EventArgs e)
        {
            groupBoxSelectedTemplete.Text = "Current Properties";
            level = 1;
            GetProperties();
        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            groupBoxSelectedTemplete.Text = "Base Properties";
            level = 2;
            GetProperties();
        }

        

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            Trace.WriteLine("tabControl_Selected");
            //int idx = tabControl.SelectedIndex;
            TabPage idx = tabControl.SelectedTab;
            
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Apply();
        }
    }
}
