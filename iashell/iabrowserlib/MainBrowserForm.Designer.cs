namespace iabrowserlib
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
            tabControlMain = new TabControl();
            tabPageCameraRoll = new TabPage();
            splitContainer2 = new SplitContainer();
            treeViewPictures = new TreeView();
            contextMenuPicuresTree = new ContextMenuStrip(components);
            Explorer = new ToolStripMenuItem();
            StateImageList = new ImageList(components);
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
            tabPageAlbums = new TabPage();
            splitContainer1 = new SplitContainer();
            listViewAlbum = new ListView();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderNumberOfImages = new ColumnHeader();
            columnHeaderDateUpdated = new ColumnHeader();
            listViewAlbumImages = new ListView();
            imageListAlbumLarge = new ImageList(components);
            tabPageGalleries = new TabPage();
            splitContainer3 = new SplitContainer();
            listViewGalleries = new ListView();
            columnHeaderTitleGallery = new ColumnHeader();
            columnHeaderGallerySize = new ColumnHeader();
            columnHeaderGalleryDateUpdated = new ColumnHeader();
            listViewGalleriesImages = new ListView();
            imageListPicturesLarge = new ImageList(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemNew = new ToolStripMenuItem();
            toolStripMenuItemAddAlbum = new ToolStripMenuItem();
            toolStripMenuItemNewGallery = new ToolStripMenuItem();
            toolStripMenuItemSave = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            largeIconToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemCheckBox = new ToolStripMenuItem();
            toolStripMenuItemAlbumAction = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            statusStripBottom = new StatusStrip();
            toolStripStatusLabelCurrentPath = new ToolStripStatusLabel();
            toolStripStatusCurrentPath = new ToolStripStatusLabel();
            toolStripStatusCurrentAlbum = new ToolStripStatusLabel();
            toolStripStatusCurrentGallery = new ToolStripStatusLabel();
            toolStripMenuItemAlbumOther = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            tabPageCameraRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            contextMenuPicuresTree.SuspendLayout();
            contextMenuStripPictures.SuspendLayout();
            tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabPageGalleries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStripBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageCameraRoll);
            tabControlMain.Controls.Add(tabPageAlbums);
            tabControlMain.Controls.Add(tabPageGalleries);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 35);
            tabControlMain.Margin = new Padding(5);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1237, 1018);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPageCameraRoll
            // 
            tabPageCameraRoll.Controls.Add(splitContainer2);
            tabPageCameraRoll.Location = new Point(4, 34);
            tabPageCameraRoll.Margin = new Padding(5);
            tabPageCameraRoll.Name = "tabPageCameraRoll";
            tabPageCameraRoll.Padding = new Padding(5);
            tabPageCameraRoll.Size = new Size(1229, 980);
            tabPageCameraRoll.TabIndex = 0;
            tabPageCameraRoll.Text = "Camera Roll";
            tabPageCameraRoll.UseVisualStyleBackColor = true;
            tabPageCameraRoll.Click += tabPage1_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(5, 5);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(treeViewPictures);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listViewPictures);
            splitContainer2.Size = new Size(1219, 970);
            splitContainer2.SplitterDistance = 446;
            splitContainer2.TabIndex = 2;
            // 
            // treeViewPictures
            // 
            treeViewPictures.BackColor = SystemColors.WindowFrame;
            treeViewPictures.ContextMenuStrip = contextMenuPicuresTree;
            treeViewPictures.Dock = DockStyle.Fill;
            treeViewPictures.ForeColor = SystemColors.ControlLightLight;
            treeViewPictures.Location = new Point(0, 0);
            treeViewPictures.Margin = new Padding(5);
            treeViewPictures.Name = "treeViewPictures";
            treeViewPictures.Size = new Size(446, 970);
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
            // StateImageList
            // 
            StateImageList.ColorDepth = ColorDepth.Depth32Bit;
            StateImageList.ImageStream = (ImageListStreamer)resources.GetObject("StateImageList.ImageStream");
            StateImageList.TransparentColor = Color.Transparent;
            StateImageList.Images.SetKeyName(0, "");
            StateImageList.Images.SetKeyName(1, "");
            // 
            // listViewPictures
            // 
            listViewPictures.BackColor = SystemColors.WindowFrame;
            listViewPictures.CheckBoxes = true;
            listViewPictures.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderModified, columnHeaderType, columnHeaderSize });
            listViewPictures.ContextMenuStrip = contextMenuStripPictures;
            listViewPictures.Dock = DockStyle.Fill;
            listViewPictures.ForeColor = SystemColors.ControlLightLight;
            listViewPictures.FullRowSelect = true;
            listViewPictures.Location = new Point(0, 0);
            listViewPictures.Margin = new Padding(5);
            listViewPictures.Name = "listViewPictures";
            listViewPictures.ShowItemToolTips = true;
            listViewPictures.Size = new Size(769, 970);
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
            // tabPageAlbums
            // 
            tabPageAlbums.Controls.Add(splitContainer1);
            tabPageAlbums.Location = new Point(4, 34);
            tabPageAlbums.Margin = new Padding(5);
            tabPageAlbums.Name = "tabPageAlbums";
            tabPageAlbums.Padding = new Padding(5);
            tabPageAlbums.Size = new Size(1229, 980);
            tabPageAlbums.TabIndex = 1;
            tabPageAlbums.Text = "Albums";
            tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewAlbum);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewAlbumImages);
            splitContainer1.Size = new Size(1219, 970);
            splitContainer1.SplitterDistance = 403;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // listViewAlbum
            // 
            listViewAlbum.AllowColumnReorder = true;
            listViewAlbum.BackColor = SystemColors.GrayText;
            listViewAlbum.Columns.AddRange(new ColumnHeader[] { columnHeaderTitle, columnHeaderNumberOfImages, columnHeaderDateUpdated });
            listViewAlbum.Dock = DockStyle.Fill;
            listViewAlbum.ForeColor = SystemColors.HighlightText;
            listViewAlbum.Location = new Point(0, 0);
            listViewAlbum.Margin = new Padding(2);
            listViewAlbum.Name = "listViewAlbum";
            listViewAlbum.Size = new Size(403, 970);
            listViewAlbum.TabIndex = 0;
            listViewAlbum.UseCompatibleStateImageBehavior = false;
            listViewAlbum.View = View.Details;
            listViewAlbum.ItemSelectionChanged += listViewAlbum_ItemSelectionChanged;
            listViewAlbum.SelectedIndexChanged += listViewAlbum_SelectedIndexChanged;
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Title";
            columnHeaderTitle.Width = 150;
            // 
            // columnHeaderNumberOfImages
            // 
            columnHeaderNumberOfImages.Text = "Size";
            columnHeaderNumberOfImages.Width = 80;
            // 
            // columnHeaderDateUpdated
            // 
            columnHeaderDateUpdated.Text = "Updated";
            columnHeaderDateUpdated.Width = 100;
            // 
            // listViewAlbumImages
            // 
            listViewAlbumImages.BackColor = SystemColors.WindowText;
            listViewAlbumImages.Dock = DockStyle.Fill;
            listViewAlbumImages.ForeColor = SystemColors.HighlightText;
            listViewAlbumImages.LargeImageList = imageListAlbumLarge;
            listViewAlbumImages.Location = new Point(0, 0);
            listViewAlbumImages.Margin = new Padding(2);
            listViewAlbumImages.Name = "listViewAlbumImages";
            listViewAlbumImages.Size = new Size(813, 970);
            listViewAlbumImages.TabIndex = 0;
            listViewAlbumImages.UseCompatibleStateImageBehavior = false;
            // 
            // imageListAlbumLarge
            // 
            imageListAlbumLarge.ColorDepth = ColorDepth.Depth8Bit;
            imageListAlbumLarge.ImageSize = new Size(384, 384);
            imageListAlbumLarge.TransparentColor = Color.Transparent;
            // 
            // tabPageGalleries
            // 
            tabPageGalleries.Controls.Add(splitContainer3);
            tabPageGalleries.Location = new Point(4, 34);
            tabPageGalleries.Margin = new Padding(2);
            tabPageGalleries.Name = "tabPageGalleries";
            tabPageGalleries.Size = new Size(1229, 980);
            tabPageGalleries.TabIndex = 2;
            tabPageGalleries.Text = "Galleries";
            tabPageGalleries.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(2);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(listViewGalleries);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(listViewGalleriesImages);
            splitContainer3.Size = new Size(1229, 980);
            splitContainer3.SplitterDistance = 408;
            splitContainer3.SplitterWidth = 3;
            splitContainer3.TabIndex = 0;
            // 
            // listViewGalleries
            // 
            listViewGalleries.BackColor = SystemColors.GrayText;
            listViewGalleries.Columns.AddRange(new ColumnHeader[] { columnHeaderTitleGallery, columnHeaderGallerySize, columnHeaderGalleryDateUpdated });
            listViewGalleries.Dock = DockStyle.Fill;
            listViewGalleries.ForeColor = SystemColors.InfoText;
            listViewGalleries.Location = new Point(0, 0);
            listViewGalleries.Name = "listViewGalleries";
            listViewGalleries.Size = new Size(408, 980);
            listViewGalleries.TabIndex = 0;
            listViewGalleries.UseCompatibleStateImageBehavior = false;
            listViewGalleries.View = View.Details;
            // 
            // columnHeaderTitleGallery
            // 
            columnHeaderTitleGallery.Text = "Title";
            // 
            // columnHeaderGallerySize
            // 
            columnHeaderGallerySize.Text = "Size";
            // 
            // columnHeaderGalleryDateUpdated
            // 
            columnHeaderGalleryDateUpdated.Text = "Date Updated";
            // 
            // listViewGalleriesImages
            // 
            listViewGalleriesImages.BackColor = SystemColors.InfoText;
            listViewGalleriesImages.Dock = DockStyle.Fill;
            listViewGalleriesImages.ForeColor = SystemColors.HighlightText;
            listViewGalleriesImages.Location = new Point(0, 0);
            listViewGalleriesImages.Name = "listViewGalleriesImages";
            listViewGalleriesImages.Size = new Size(818, 980);
            listViewGalleriesImages.TabIndex = 0;
            listViewGalleriesImages.UseCompatibleStateImageBehavior = false;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolStripMenuItemAlbumAction });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1237, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem, toolStripMenuItemNew, toolStripMenuItemSave });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(270, 34);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // toolStripMenuItemNew
            // 
            toolStripMenuItemNew.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddAlbum, toolStripMenuItemNewGallery });
            toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            toolStripMenuItemNew.Size = new Size(270, 34);
            toolStripMenuItemNew.Text = "New";
            // 
            // toolStripMenuItemAddAlbum
            // 
            toolStripMenuItemAddAlbum.Name = "toolStripMenuItemAddAlbum";
            toolStripMenuItemAddAlbum.Size = new Size(270, 34);
            toolStripMenuItemAddAlbum.Text = "Album";
            toolStripMenuItemAddAlbum.Click += toolStripMenuItemAddAlbum_Click;
            // 
            // toolStripMenuItemNewGallery
            // 
            toolStripMenuItemNewGallery.Name = "toolStripMenuItemNewGallery";
            toolStripMenuItemNewGallery.Size = new Size(270, 34);
            toolStripMenuItemNewGallery.Text = "Gallery";
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.Size = new Size(270, 34);
            toolStripMenuItemSave.Text = "Save";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { largeIconToolStripMenuItem, detailsToolStripMenuItem, toolStripMenuItemCheckBox });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            largeIconToolStripMenuItem.Size = new Size(270, 34);
            largeIconToolStripMenuItem.Text = "Thumbnails";
            largeIconToolStripMenuItem.Click += largeIconToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(270, 34);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItemCheckBox
            // 
            toolStripMenuItemCheckBox.Checked = true;
            toolStripMenuItemCheckBox.CheckState = CheckState.Checked;
            toolStripMenuItemCheckBox.Name = "toolStripMenuItemCheckBox";
            toolStripMenuItemCheckBox.Size = new Size(270, 34);
            toolStripMenuItemCheckBox.Text = "Selection Boxes";
            toolStripMenuItemCheckBox.Click += toolStripMenuItemCheckBox_Click;
            // 
            // toolStripMenuItemAlbumAction
            // 
            toolStripMenuItemAlbumAction.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            toolStripMenuItemAlbumAction.Name = "toolStripMenuItemAlbumAction";
            toolStripMenuItemAlbumAction.Size = new Size(81, 29);
            toolStripMenuItemAlbumAction.Text = "Album";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItemAlbumOther });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(270, 34);
            toolStripMenuItem1.Text = "Add to";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(270, 34);
            toolStripMenuItem2.Text = "Current Album";
            // 
            // statusStripBottom
            // 
            statusStripBottom.ImageScalingSize = new Size(24, 24);
            statusStripBottom.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCurrentPath, toolStripStatusCurrentPath, toolStripStatusCurrentAlbum, toolStripStatusCurrentGallery });
            statusStripBottom.Location = new Point(0, 1021);
            statusStripBottom.Name = "statusStripBottom";
            statusStripBottom.Padding = new Padding(2, 0, 20, 0);
            statusStripBottom.Size = new Size(1237, 32);
            statusStripBottom.TabIndex = 2;
            statusStripBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCurrentPath
            // 
            toolStripStatusLabelCurrentPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabelCurrentPath.Name = "toolStripStatusLabelCurrentPath";
            toolStripStatusLabelCurrentPath.Size = new Size(0, 25);
            // 
            // toolStripStatusCurrentPath
            // 
            toolStripStatusCurrentPath.Name = "toolStripStatusCurrentPath";
            toolStripStatusCurrentPath.Size = new Size(179, 25);
            toolStripStatusCurrentPath.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusCurrentAlbum
            // 
            toolStripStatusCurrentAlbum.Name = "toolStripStatusCurrentAlbum";
            toolStripStatusCurrentAlbum.Size = new Size(179, 25);
            toolStripStatusCurrentAlbum.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusCurrentGallery
            // 
            toolStripStatusCurrentGallery.Name = "toolStripStatusCurrentGallery";
            toolStripStatusCurrentGallery.Size = new Size(179, 25);
            toolStripStatusCurrentGallery.Text = "toolStripStatusLabel2";
            // 
            // toolStripMenuItemAlbumOther
            // 
            toolStripMenuItemAlbumOther.Name = "toolStripMenuItemAlbumOther";
            toolStripMenuItemAlbumOther.Size = new Size(270, 34);
            toolStripMenuItemAlbumOther.Text = "Other ...";
            // 
            // MainBrowserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 1053);
            Controls.Add(statusStripBottom);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainBrowserForm";
            Text = "Image Archive - Image browser";
            Load += MainBrowserForm_Load;
            tabControlMain.ResumeLayout(false);
            tabPageCameraRoll.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            contextMenuPicuresTree.ResumeLayout(false);
            contextMenuStripPictures.ResumeLayout(false);
            tabPageAlbums.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabPageGalleries.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStripBottom.ResumeLayout(false);
            statusStripBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageCameraRoll;
        private TabPage tabPageAlbums;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private StatusStrip statusStripBottom;
        private ToolStripStatusLabel toolStripStatusLabelCurrentPath;
        private TreeView treeViewPictures;
        private ImageList StateImageList;
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
        private SplitContainer splitContainer1;
        private ListView listViewAlbum;
        private ListView listViewAlbumImages;
        private ColumnHeader columnHeaderTitle;
        private ColumnHeader columnHeaderNumberOfImages;
        private ColumnHeader columnHeaderDateUpdated;
        private ImageList imageListAlbumLarge;
        private ListView listViewPictures;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderModified;
        private ColumnHeader columnHeaderType;
        private ColumnHeader columnHeaderSize;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem toolStripMenuItemCheckBox;
        private TabPage tabPageGalleries;
        private SplitContainer splitContainer3;
        private ListView listViewGalleries;
        private ListView listViewGalleriesImages;
        private ColumnHeader columnHeaderTitleGallery;
        private ColumnHeader columnHeaderGallerySize;
        private ColumnHeader columnHeaderGalleryDateUpdated;
        private ToolStripStatusLabel toolStripStatusCurrentAlbum;
        private ToolStripStatusLabel toolStripStatusCurrentGallery;
        private TreeView treeView1;
        private ToolStripMenuItem toolStripMenuItemNew;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripMenuItem toolStripMenuItemEditAlbum;
        private ToolStripMenuItem toolStripMenuItemEditGallery;
        private ToolStripMenuItem toolStripMenuItemAddAlbum;
        private ToolStripMenuItem toolStripMenuItemNewGallery;
        private ToolStripMenuItem toolStripMenuItemAlbumAction;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItemAlbumOther;
    }
}