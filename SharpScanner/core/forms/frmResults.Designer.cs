namespace SharpScanner
{
    partial class frmResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.lvResults = new BrightIdeasSoftware.ObjectListView();
            this.colHost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHostname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMAC = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colOnline = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.conMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.conSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.conCopyIP = new System.Windows.Forms.ToolStripMenuItem();
            this.conCopyDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.conSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.conOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.conWebBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.conPing = new System.Windows.Forms.ToolStripMenuItem();
            this.conTraceRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.conWhois = new System.Windows.Forms.ToolStripMenuItem();
            this.imgResults = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lvResults)).BeginInit();
            this.conMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvResults
            // 
            this.lvResults.AllColumns.Add(this.colHost);
            this.lvResults.AllColumns.Add(this.colHostname);
            this.lvResults.AllColumns.Add(this.colMAC);
            this.lvResults.AllColumns.Add(this.colPing);
            this.lvResults.AllColumns.Add(this.colOnline);
            this.lvResults.AlternateRowBackColor = System.Drawing.SystemColors.ControlLight;
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHost,
            this.colHostname,
            this.colMAC,
            this.colPing,
            this.colOnline});
            this.lvResults.ContextMenuStrip = this.conMain;
            this.lvResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResults.EmptyListMsg = "No Results";
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.LargeImageList = this.imgResults;
            this.lvResults.Location = new System.Drawing.Point(0, 0);
            this.lvResults.Name = "lvResults";
            this.lvResults.SelectColumnsOnRightClick = false;
            this.lvResults.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.lvResults.ShowFilterMenuOnRightClick = false;
            this.lvResults.ShowGroups = false;
            this.lvResults.ShowHeaderInAllViews = false;
            this.lvResults.Size = new System.Drawing.Size(761, 445);
            this.lvResults.SmallImageList = this.imgResults;
            this.lvResults.TabIndex = 1;
            this.lvResults.UseAlternatingBackColors = true;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.UseFiltering = true;
            this.lvResults.UseHotItem = true;
            this.lvResults.View = System.Windows.Forms.View.SmallIcon;
            this.lvResults.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.lvResults_ItemsChanged);
            // 
            // colHost
            // 
            this.colHost.Sortable = false;
            this.colHost.Text = "IP";
            this.colHost.Width = 112;
            // 
            // colHostname
            // 
            this.colHostname.Sortable = false;
            this.colHostname.Text = "Hostname";
            this.colHostname.Width = 118;
            // 
            // colMAC
            // 
            this.colMAC.Sortable = false;
            this.colMAC.Text = "MAC";
            this.colMAC.Width = 128;
            // 
            // colPing
            // 
            this.colPing.Sortable = false;
            this.colPing.Text = "Ping";
            this.colPing.Width = 105;
            // 
            // colOnline
            // 
            this.colOnline.Sortable = false;
            this.colOnline.Text = "Online";
            this.colOnline.Width = 116;
            // 
            // conMain
            // 
            this.conMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conShowDetails,
            this.conSep2,
            this.conCopyIP,
            this.conCopyDetails,
            this.conSep3,
            this.conOpen});
            this.conMain.Name = "contextMenuStrip1";
            this.conMain.Size = new System.Drawing.Size(142, 104);
            // 
            // conShowDetails
            // 
            this.conShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("conShowDetails.Image")));
            this.conShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conShowDetails.Name = "conShowDetails";
            this.conShowDetails.Size = new System.Drawing.Size(141, 22);
            this.conShowDetails.Text = "Show Details";
            this.conShowDetails.Click += new System.EventHandler(this.conShowDetails_Click);
            // 
            // conSep2
            // 
            this.conSep2.Name = "conSep2";
            this.conSep2.Size = new System.Drawing.Size(138, 6);
            // 
            // conCopyIP
            // 
            this.conCopyIP.Image = ((System.Drawing.Image)(resources.GetObject("conCopyIP.Image")));
            this.conCopyIP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conCopyIP.Name = "conCopyIP";
            this.conCopyIP.Size = new System.Drawing.Size(141, 22);
            this.conCopyIP.Text = "Copy IP";
            this.conCopyIP.Click += new System.EventHandler(this.conCopyIP_Click);
            // 
            // conCopyDetails
            // 
            this.conCopyDetails.Image = ((System.Drawing.Image)(resources.GetObject("conCopyDetails.Image")));
            this.conCopyDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conCopyDetails.Name = "conCopyDetails";
            this.conCopyDetails.Size = new System.Drawing.Size(141, 22);
            this.conCopyDetails.Text = "Copy Details";
            this.conCopyDetails.Click += new System.EventHandler(this.conCopyDetails_Click);
            // 
            // conSep3
            // 
            this.conSep3.Name = "conSep3";
            this.conSep3.Size = new System.Drawing.Size(138, 6);
            // 
            // conOpen
            // 
            this.conOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conWebBrowser,
            this.conPing,
            this.conTraceRoute,
            this.conWhois});
            this.conOpen.Name = "conOpen";
            this.conOpen.Size = new System.Drawing.Size(141, 22);
            this.conOpen.Text = "Open";
            // 
            // conWebBrowser
            // 
            this.conWebBrowser.Image = ((System.Drawing.Image)(resources.GetObject("conWebBrowser.Image")));
            this.conWebBrowser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conWebBrowser.Name = "conWebBrowser";
            this.conWebBrowser.Size = new System.Drawing.Size(143, 22);
            this.conWebBrowser.Text = "Web Browser";
            this.conWebBrowser.Click += new System.EventHandler(this.conWebBrowser_Click);
            // 
            // conPing
            // 
            this.conPing.Image = ((System.Drawing.Image)(resources.GetObject("conPing.Image")));
            this.conPing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conPing.Name = "conPing";
            this.conPing.Size = new System.Drawing.Size(143, 22);
            this.conPing.Text = "Ping";
            this.conPing.Click += new System.EventHandler(this.conPing_Click);
            // 
            // conTraceRoute
            // 
            this.conTraceRoute.Image = ((System.Drawing.Image)(resources.GetObject("conTraceRoute.Image")));
            this.conTraceRoute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conTraceRoute.Name = "conTraceRoute";
            this.conTraceRoute.Size = new System.Drawing.Size(143, 22);
            this.conTraceRoute.Text = "Trace Route";
            this.conTraceRoute.Click += new System.EventHandler(this.conTraceRoute_Click);
            // 
            // conWhois
            // 
            this.conWhois.Image = ((System.Drawing.Image)(resources.GetObject("conWhois.Image")));
            this.conWhois.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conWhois.Name = "conWhois";
            this.conWhois.Size = new System.Drawing.Size(143, 22);
            this.conWhois.Text = "Whois";
            this.conWhois.Click += new System.EventHandler(this.conWhois_Click);
            // 
            // imgResults
            // 
            this.imgResults.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgResults.ImageStream")));
            this.imgResults.TransparentColor = System.Drawing.Color.Transparent;
            this.imgResults.Images.SetKeyName(0, "unknown.png");
            this.imgResults.Images.SetKeyName(1, "offline.png");
            this.imgResults.Images.SetKeyName(2, "online.png");
            this.imgResults.Images.SetKeyName(3, "high.png");
            this.imgResults.Images.SetKeyName(4, "medium.png");
            this.imgResults.Images.SetKeyName(5, "low.png");
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 445);
            this.Controls.Add(this.lvResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.lvResults)).EndInit();
            this.conMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView lvResults;
        private BrightIdeasSoftware.OLVColumn colHost;
        private BrightIdeasSoftware.OLVColumn colHostname;
        private BrightIdeasSoftware.OLVColumn colMAC;
        private BrightIdeasSoftware.OLVColumn colPing;
        private BrightIdeasSoftware.OLVColumn colOnline;
        private System.Windows.Forms.ImageList imgResults;
        private System.Windows.Forms.ContextMenuStrip conMain;
        private System.Windows.Forms.ToolStripMenuItem conShowDetails;
        private System.Windows.Forms.ToolStripSeparator conSep2;
        private System.Windows.Forms.ToolStripMenuItem conCopyIP;
        private System.Windows.Forms.ToolStripMenuItem conCopyDetails;
        private System.Windows.Forms.ToolStripSeparator conSep3;
        private System.Windows.Forms.ToolStripMenuItem conOpen;
        private System.Windows.Forms.ToolStripMenuItem conWebBrowser;
        private System.Windows.Forms.ToolStripMenuItem conPing;
        private System.Windows.Forms.ToolStripMenuItem conTraceRoute;
        private System.Windows.Forms.ToolStripMenuItem conWhois;
    }
}