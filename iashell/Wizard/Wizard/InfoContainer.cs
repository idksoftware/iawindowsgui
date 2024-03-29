using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IDK.Gui.Wizard
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	[Designer(typeof(InfoContainerDesigner))]
	public class InfoContainer: System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.Label lblTitle;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// 
		/// </summary>
		public InfoContainer()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoContainer));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(172, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 107);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Welcome to the ImgArchive  Setup wizard";
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(186, 415);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // InfoContainer
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picImage);
            this.Name = "InfoContainer";
            this.Size = new System.Drawing.Size(480, 415);
            this.Load += new System.EventHandler(this.InfoContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void InfoContainer_Load(object sender, System.EventArgs e)
		{
			//Handle really irating resize that doesn't take account of Anchor
			lblTitle.Left = picImage.Width+8;
			lblTitle.Width = (this.Width-4)-lblTitle.Left;
		}

		/// <summary>
		/// Get/Set the title for the info page
		/// </summary>
		[Category("Appearance")]
		public string PageTitle
		{
			get
			{
				return lblTitle.Text;
			}
			set
			{
				lblTitle.Text = value;
			}
		}

		
		/// <summary>
		/// Gets/Sets the Icon
		/// </summary>
		[Category("Appearance")]
		public Image Image
		{
			get
			{
				return picImage.Image;
			}
			set
			{
				picImage.Image = value;
			}
		}


	}
}
