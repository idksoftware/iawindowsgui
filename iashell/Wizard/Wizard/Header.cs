using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace IDK.Gui.Wizard
{
	/// <summary>
	/// Summary description for WizardHeader.
	/// </summary>
	[Designer(typeof(HeaderDesigner))]
	public class Header : UserControl
	{
		private System.Windows.Forms.Panel pnlDockPadding;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Panel pnl3dDark;
		private System.Windows.Forms.Panel pnl3dBright;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Constructor for Header
		/// </summary>
		public Header()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.pnlDockPadding = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnl3dDark = new System.Windows.Forms.Panel();
            this.pnl3dBright = new System.Windows.Forms.Panel();
            this.pnlDockPadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDockPadding
            // 
            this.pnlDockPadding.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDockPadding.Controls.Add(this.lblDescription);
            this.pnlDockPadding.Controls.Add(this.lblTitle);
            this.pnlDockPadding.Controls.Add(this.picIcon);
            this.pnlDockPadding.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDockPadding.Location = new System.Drawing.Point(0, 0);
            this.pnlDockPadding.Name = "pnlDockPadding";
            this.pnlDockPadding.Padding = new System.Windows.Forms.Padding(8, 6, 4, 4);
            this.pnlDockPadding.Size = new System.Drawing.Size(918, 96);
            this.pnlDockPadding.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDescription.Location = new System.Drawing.Point(8, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(841, 51);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(841, 35);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.Location = new System.Drawing.Point(849, 6);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(65, 86);
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // pnl3dDark
            // 
            this.pnl3dDark.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl3dDark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3dDark.Location = new System.Drawing.Point(0, 62);
            this.pnl3dDark.Name = "pnl3dDark";
            this.pnl3dDark.Size = new System.Drawing.Size(397, 1);
            this.pnl3dDark.TabIndex = 7;
            // 
            // pnl3dBright
            // 
            this.pnl3dBright.BackColor = System.Drawing.Color.White;
            this.pnl3dBright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3dBright.Location = new System.Drawing.Point(0, 63);
            this.pnl3dBright.Name = "pnl3dBright";
            this.pnl3dBright.Size = new System.Drawing.Size(397, 1);
            this.pnl3dBright.TabIndex = 8;
            // 
            // Header
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.Controls.Add(this.pnl3dDark);
            this.Controls.Add(this.pnl3dBright);
            this.Controls.Add(this.pnlDockPadding);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(397, 64);
            this.SizeChanged += new System.EventHandler(this.Header_SizeChanged);
            this.pnlDockPadding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ResizeImageAndText()
		{
			//Resize image 
			picIcon.Size= picIcon.Image.Size;
			//Relocate image according to its size
			picIcon.Top = (this.Height - picIcon.Height)/2;
			picIcon.Left = this.Width - picIcon.Width - 8;
			//Fit text around picture
			lblTitle.Width = picIcon.Left - lblTitle.Left;
			lblDescription.Width = picIcon.Left - (lblDescription.Left + 20);
		}

		private void Header_SizeChanged(object sender, System.EventArgs e)
		{
			ResizeImageAndText();
		}

		/// <summary>
		/// Get/Set the title for the wizard page
		/// </summary>
		[Category("Appearance")]
		public string Title
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
		/// Gets/Sets the
		/// </summary>
		[Category("Appearance")]
		public string Description
		{
			get
			{
				return lblDescription.Text;
			}
			set
			{
				lblDescription.Text = value;
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
				return picIcon.Image;
			}
			set
			{
				picIcon.Image = value;
				ResizeImageAndText();
			}
		}
    }
}
