namespace iabrowsergui
{
    partial class MainBrowserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBrowserForm));
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
            treeViewPictures = new TreeView();
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            largeIconToolStripMenuItem = new ToolStripMenuItem();
            smallIconToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            statusStripBottom = new StatusStrip();
            toolStripStatusLabelCurrentPath = new ToolStripStatusLabel();
            toolStripStatusCurrentPath = new ToolStripStatusLabel();
            imageList = new ImageList(components);
            imageListPictures = new ImageList(components);
            responsivePictureBox1 = new IAControlLibrary.ResponsivePictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            contextMenuStripPictures.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)responsivePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 35);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1237, 870);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewPictures);
            tabPage1.Controls.Add(treeViewPictures);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(1229, 832);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pictures";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewPictures
            // 
            listViewPictures.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderModified, columnHeaderType, columnHeaderSize });
            listViewPictures.ContextMenuStrip = contextMenuStripPictures;
            listViewPictures.Dock = DockStyle.Fill;
            listViewPictures.Location = new Point(248, 5);
            listViewPictures.Margin = new Padding(4, 5, 4, 5);
            listViewPictures.Name = "listViewPictures";
            listViewPictures.Size = new Size(977, 822);
            listViewPictures.TabIndex = 1;
            listViewPictures.UseCompatibleStateImageBehavior = false;
            listViewPictures.View = View.Details;
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
            contextMenuStripPictures.Items.AddRange(new ToolStripItem[] { toolStripMenuItemExplorer, ToolStripMenuItemProperties, toolStripMenuItemPreview });
            contextMenuStripPictures.Name = "contextMenuStripPictures";
            contextMenuStripPictures.Size = new Size(165, 100);
            contextMenuStripPictures.Text = "Explorer";
            contextMenuStripPictures.ItemClicked += contextMenuStripPictures_ItemClicked;
            // 
            // toolStripMenuItemExplorer
            // 
            toolStripMenuItemExplorer.Name = "toolStripMenuItemExplorer";
            toolStripMenuItemExplorer.Size = new Size(164, 32);
            toolStripMenuItemExplorer.Text = "Explorer";
            // 
            // ToolStripMenuItemProperties
            // 
            ToolStripMenuItemProperties.Name = "ToolStripMenuItemProperties";
            ToolStripMenuItemProperties.Size = new Size(164, 32);
            ToolStripMenuItemProperties.Text = "Properties";
            // 
            // toolStripMenuItemPreview
            // 
            toolStripMenuItemPreview.Name = "toolStripMenuItemPreview";
            toolStripMenuItemPreview.Size = new Size(164, 32);
            toolStripMenuItemPreview.Text = "Preview";
            // 
            // treeViewPictures
            // 
            treeViewPictures.Dock = DockStyle.Left;
            treeViewPictures.Location = new Point(4, 5);
            treeViewPictures.Margin = new Padding(4, 5, 4, 5);
            treeViewPictures.Name = "treeViewPictures";
            treeViewPictures.Size = new Size(244, 822);
            treeViewPictures.TabIndex = 0;
            treeViewPictures.AfterSelect += treeViewPictures_AfterSelect;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(1229, 832);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Workspace";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
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
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { largeIconToolStripMenuItem, smallIconToolStripMenuItem, detailsToolStripMenuItem, listToolStripMenuItem, tileToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            largeIconToolStripMenuItem.Size = new Size(196, 34);
            largeIconToolStripMenuItem.Text = "Large Icon";
            largeIconToolStripMenuItem.Click += largeIconToolStripMenuItem_Click;
            // 
            // smallIconToolStripMenuItem
            // 
            smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            smallIconToolStripMenuItem.Size = new Size(196, 34);
            smallIconToolStripMenuItem.Text = "Small Icon";
            smallIconToolStripMenuItem.Click += smallIconToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(196, 34);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(196, 34);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(196, 34);
            tileToolStripMenuItem.Text = "Tile";
            tileToolStripMenuItem.Click += tileToolStripMenuItem_Click;
            // 
            // statusStripBottom
            // 
            statusStripBottom.ImageScalingSize = new Size(24, 24);
            statusStripBottom.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCurrentPath, toolStripStatusCurrentPath });
            statusStripBottom.Location = new Point(0, 873);
            statusStripBottom.Name = "statusStripBottom";
            statusStripBottom.Padding = new Padding(1, 0, 20, 0);
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
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "BrowserUp.png");
            // 
            // imageListPictures
            // 
            imageListPictures.ColorDepth = ColorDepth.Depth24Bit;
            imageListPictures.ImageSize = new Size(256, 256);
            imageListPictures.TransparentColor = Color.Transparent;
            // 
            // responsivePictureBox1
            // 
            responsivePictureBox1.Location = new Point(0, 0);
            responsivePictureBox1.Name = "responsivePictureBox1";
            responsivePictureBox1.Size = new Size(150, 75);
            responsivePictureBox1.TabIndex = 3;
            responsivePictureBox1.TabStop = false;
            // 
            // MainBrowserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 905);
            Controls.Add(responsivePictureBox1);
            Controls.Add(statusStripBottom);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainBrowserForm";
            Text = "Image Archive - Image browser";
            Load += MainBrowserForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            contextMenuStripPictures.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStripBottom.ResumeLayout(false);
            statusStripBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)responsivePictureBox1).EndInit();
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
        private ImageList imageList;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderModified;
        private ColumnHeader columnHeaderType;
        private ColumnHeader columnHeaderSize;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem largeIconToolStripMenuItem;
        private ToolStripMenuItem smallIconToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ImageList imageListPictures;
        private ToolStripStatusLabel toolStripStatusCurrentPath;
        private ContextMenuStrip contextMenuStripPictures;
        private ToolStripMenuItem toolStripMenuItemExplorer;
        private ToolStripMenuItem ToolStripMenuItemProperties;
        private ToolStripMenuItem toolStripMenuItemPreview;
        private IAControlLibrary.ResponsivePictureBox responsivePictureBox1;
    }
}