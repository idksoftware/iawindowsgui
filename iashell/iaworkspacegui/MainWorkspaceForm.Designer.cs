namespace iaworkspacegui
{
    partial class MainWorkspaceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWorkspaceForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listViewPictures = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderModified = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            columnHeaderSize = new ColumnHeader();
            contextMenuStripPictures = new ContextMenuStrip(components);
            toolStripMenuItemExplorer = new ToolStripMenuItem();
            ToolStripMenuItemProperties = new ToolStripMenuItem();
            toolStripMenuItemPreview = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            checkInOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemExport = new ToolStripMenuItem();
            StateImageList = new ImageList(components);
            treeViewPictures = new TreeView();
            contextMenuPicuresTree = new ContextMenuStrip(components);
            Explorer = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            imageListPicturesLarge = new ImageList(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            largeIconToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            statusStripBottom = new StatusStrip();
            toolStripStatusLabelCurrentPath = new ToolStripStatusLabel();
            toolStripStatusCurrentPath = new ToolStripStatusLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            contextMenuStripPictures.SuspendLayout();
            contextMenuPicuresTree.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStripBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1237, 1018);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewPictures);
            tabPage1.Controls.Add(treeViewPictures);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1229, 980);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Workspace";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // listViewPictures
            // 
            listViewPictures.BackColor = SystemColors.WindowFrame;
            listViewPictures.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderModified, columnHeaderType, columnHeaderSize });
            listViewPictures.ContextMenuStrip = contextMenuStripPictures;
            listViewPictures.Dock = DockStyle.Fill;
            listViewPictures.ForeColor = SystemColors.ControlLightLight;
            listViewPictures.FullRowSelect = true;
            listViewPictures.Location = new Point(249, 5);
            listViewPictures.Margin = new Padding(5);
            listViewPictures.Name = "listViewPictures";
            listViewPictures.ShowItemToolTips = true;
            listViewPictures.Size = new Size(975, 970);
            listViewPictures.StateImageList = StateImageList;
            listViewPictures.TabIndex = 1;
            listViewPictures.TileSize = new Size(1000, 1000);
            listViewPictures.UseCompatibleStateImageBehavior = false;
            listViewPictures.View = View.Details;
            listViewPictures.SelectedIndexChanged += listViewPictures_SelectedIndexChanged;
            listViewPictures.MouseClick += listViewPictures_MouseClick;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 250;
            // 
            // columnHeaderModified
            // 
            columnHeaderModified.Text = "Date Modified";
            columnHeaderModified.Width = 150;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Type";
            // 
            // columnHeaderSize
            // 
            columnHeaderSize.Text = "Size";
            columnHeaderSize.Width = 100;
            // 
            // contextMenuStripPictures
            // 
            contextMenuStripPictures.ImageScalingSize = new Size(24, 24);
            contextMenuStripPictures.Items.AddRange(new ToolStripItem[] { toolStripMenuItemExplorer, ToolStripMenuItemProperties, toolStripMenuItemPreview, toolStripSeparator1, checkInOutToolStripMenuItem, toolStripMenuItemExport });
            contextMenuStripPictures.Name = "contextMenuStripPictures";
            contextMenuStripPictures.Size = new Size(189, 170);
            contextMenuStripPictures.Text = "Explorer";
            contextMenuStripPictures.Opening += contextMenuStripPictures_Opening;
            contextMenuStripPictures.ItemClicked += contextMenuStripPictures_ItemClicked;
            // 
            // toolStripMenuItemExplorer
            // 
            toolStripMenuItemExplorer.Name = "toolStripMenuItemExplorer";
            toolStripMenuItemExplorer.Size = new Size(188, 32);
            toolStripMenuItemExplorer.Text = "Explorer";
            toolStripMenuItemExplorer.Click += toolStripMenuItemExplorer_Click;
            // 
            // ToolStripMenuItemProperties
            // 
            ToolStripMenuItemProperties.Name = "ToolStripMenuItemProperties";
            ToolStripMenuItemProperties.Size = new Size(188, 32);
            ToolStripMenuItemProperties.Text = "Properties";
            // 
            // toolStripMenuItemPreview
            // 
            toolStripMenuItemPreview.Name = "toolStripMenuItemPreview";
            toolStripMenuItemPreview.Size = new Size(188, 32);
            toolStripMenuItemPreview.Text = "Preview";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(185, 6);
            // 
            // checkInOutToolStripMenuItem
            // 
            checkInOutToolStripMenuItem.Name = "checkInOutToolStripMenuItem";
            checkInOutToolStripMenuItem.Size = new Size(188, 32);
            checkInOutToolStripMenuItem.Text = "Check In/Out";
            // 
            // toolStripMenuItemExport
            // 
            toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            toolStripMenuItemExport.Size = new Size(188, 32);
            toolStripMenuItemExport.Text = "Export";
            // 
            // StateImageList
            // 
            StateImageList.ColorDepth = ColorDepth.Depth8Bit;
            StateImageList.ImageStream = (ImageListStreamer)resources.GetObject("StateImageList.ImageStream");
            StateImageList.TransparentColor = Color.Transparent;
            StateImageList.Images.SetKeyName(0, "chkedin.bmp");
            StateImageList.Images.SetKeyName(1, "chkedout.bmp");
            // 
            // treeViewPictures
            // 
            treeViewPictures.BackColor = SystemColors.WindowFrame;
            treeViewPictures.ContextMenuStrip = contextMenuPicuresTree;
            treeViewPictures.Dock = DockStyle.Left;
            treeViewPictures.ForeColor = SystemColors.ControlLightLight;
            treeViewPictures.Location = new Point(5, 5);
            treeViewPictures.Margin = new Padding(5);
            treeViewPictures.Name = "treeViewPictures";
            treeViewPictures.Size = new Size(244, 970);
            treeViewPictures.StateImageList = StateImageList;
            treeViewPictures.TabIndex = 0;
            treeViewPictures.AfterSelect += treeViewPictures_AfterSelect;
            // 
            // contextMenuPicuresTree
            // 
            contextMenuPicuresTree.ImageScalingSize = new Size(24, 24);
            contextMenuPicuresTree.Items.AddRange(new ToolStripItem[] { Explorer });
            contextMenuPicuresTree.Name = "contextMenuPicuresTree";
            contextMenuPicuresTree.Size = new Size(149, 36);
            // 
            // Explorer
            // 
            Explorer.Name = "Explorer";
            Explorer.Size = new Size(148, 32);
            Explorer.Text = "Explorer";
            Explorer.Click += Explorer_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1229, 980);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Checked-out";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageListPicturesLarge
            // 
            imageListPicturesLarge.ColorDepth = ColorDepth.Depth24Bit;
            imageListPicturesLarge.ImageSize = new Size(384, 384);
            imageListPicturesLarge.TransparentColor = Color.Transparent;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1237, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(148, 34);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { largeIconToolStripMenuItem, detailsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            largeIconToolStripMenuItem.Size = new Size(205, 34);
            largeIconToolStripMenuItem.Text = "Thumbnails";
            largeIconToolStripMenuItem.Click += largeIconToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(205, 34);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // statusStripBottom
            // 
            statusStripBottom.ImageScalingSize = new Size(24, 24);
            statusStripBottom.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCurrentPath, toolStripStatusCurrentPath });
            statusStripBottom.Location = new Point(0, 1021);
            statusStripBottom.Name = "statusStripBottom";
            statusStripBottom.Padding = new Padding(2, 0, 20, 0);
            statusStripBottom.Size = new Size(1237, 32);
            statusStripBottom.TabIndex = 2;
            statusStripBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCurrentPath
            // 
            toolStripStatusLabelCurrentPath.Name = "toolStripStatusLabelCurrentPath";
            toolStripStatusLabelCurrentPath.Size = new Size(0, 25);
            // 
            // toolStripStatusCurrentPath
            // 
            toolStripStatusCurrentPath.Name = "toolStripStatusCurrentPath";
            toolStripStatusCurrentPath.Size = new Size(179, 25);
            toolStripStatusCurrentPath.Text = "toolStripStatusLabel1";
            // 
            // MainWorkspaceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 1053);
            Controls.Add(statusStripBottom);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainWorkspaceForm";
            Text = "Image Archive - Image browser";
            Load += MainBrowserForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            contextMenuStripPictures.ResumeLayout(false);
            contextMenuPicuresTree.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStripBottom.ResumeLayout(false);
            statusStripBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private StatusStrip statusStripBottom;
        private ToolStripStatusLabel toolStripStatusLabelCurrentPath;
        private TreeView treeViewPictures;
        private ListView listViewPictures;
        private ImageList StateImageList;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderModified;
        private ColumnHeader columnHeaderType;
        private ColumnHeader columnHeaderSize;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem largeIconToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ImageList imageListPicturesLarge;
        private ToolStripStatusLabel toolStripStatusCurrentPath;
        private ContextMenuStrip contextMenuStripPictures;
        private ToolStripMenuItem toolStripMenuItemExplorer;
        private ToolStripMenuItem ToolStripMenuItemProperties;
        private ToolStripMenuItem toolStripMenuItemPreview;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem checkInOutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemExport;
        private ContextMenuStrip contextMenuPicuresTree;
        private ToolStripMenuItem Explorer;
    }
}