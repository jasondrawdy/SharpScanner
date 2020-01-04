namespace SharpScanner
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menMain = new System.Windows.Forms.MenuStrip();
            this.menFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menImportScan = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menExportScan = new System.Windows.Forms.ToolStripMenuItem();
            this.menExportSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menFetchers = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.menScanStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.menEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.menRescanSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.menDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.menCopyIP = new System.Windows.Forms.ToolStripMenuItem();
            this.menCopyDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menView = new System.Windows.Forms.ToolStripMenuItem();
            this.menAllScannedHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep6 = new System.Windows.Forms.ToolStripSeparator();
            this.menAliveHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.menDeadHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.menOpenPorts = new System.Windows.Forms.ToolStripMenuItem();
            this.menSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menNextAliveHost = new System.Windows.Forms.ToolStripMenuItem();
            this.menNextDeadHost = new System.Windows.Forms.ToolStripMenuItem();
            this.menNextOpenPort = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep7 = new System.Windows.Forms.ToolStripSeparator();
            this.menPreviousAliveHost = new System.Windows.Forms.ToolStripMenuItem();
            this.menPreviousDeadHost = new System.Windows.Forms.ToolStripMenuItem();
            this.menPreviousOpenPort = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep8 = new System.Windows.Forms.ToolStripSeparator();
            this.menFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.menAddCurrentScan = new System.Windows.Forms.ToolStripMenuItem();
            this.menManageFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep9 = new System.Windows.Forms.ToolStripSeparator();
            this.menSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menVisitWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.menSep10 = new System.Windows.Forms.ToolStripSeparator();
            this.menAboutSharpScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThreadCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.conMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.conSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.conRescanSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.conDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.conSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.conCopyIP = new System.Windows.Forms.ToolStripMenuItem();
            this.conCopyDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.conSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.conOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.conWebBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.conPing = new System.Windows.Forms.ToolStripMenuItem();
            this.conTraceRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.conWhois = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cmbScan = new System.Windows.Forms.ComboBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.panSingleIP = new System.Windows.Forms.Panel();
            this.panIPRange = new System.Windows.Forms.Panel();
            this.btnScanRange = new System.Windows.Forms.Button();
            this.cmbScanRange = new System.Windows.Forms.ComboBox();
            this.lblEndingIP = new System.Windows.Forms.Label();
            this.txtBeginningIP = new System.Windows.Forms.TextBox();
            this.txtEndingIP = new System.Windows.Forms.TextBox();
            this.lblBeginningIP = new System.Windows.Forms.Label();
            this.panIPList = new System.Windows.Forms.Panel();
            this.btnBrowseList = new System.Windows.Forms.Button();
            this.btnScanList = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.cmbScanList = new System.Windows.Forms.ComboBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lvResults = new BrightIdeasSoftware.ObjectListView();
            this.colHost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colHostname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colMAC = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPing = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colOnline = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imgResults = new System.Windows.Forms.ImageList(this.components);
            this.menMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.conMain.SuspendLayout();
            this.panSingleIP.SuspendLayout();
            this.panIPRange.SuspendLayout();
            this.panIPList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menMain
            // 
            this.menMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menFile,
            this.menEdit,
            this.menView,
            this.menSearch,
            this.menFavorites,
            this.menSettings,
            this.menHelp});
            this.menMain.Location = new System.Drawing.Point(0, 0);
            this.menMain.Name = "menMain";
            this.menMain.Size = new System.Drawing.Size(1103, 24);
            this.menMain.TabIndex = 0;
            this.menMain.Text = "menuStrip1";
            // 
            // menFile
            // 
            this.menFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menImportScan,
            this.menSep1,
            this.menExportScan,
            this.menExportSelection,
            this.menSep2,
            this.menFetchers,
            this.menSep3,
            this.menScanStatistics});
            this.menFile.Name = "menFile";
            this.menFile.Size = new System.Drawing.Size(37, 20);
            this.menFile.Text = "File";
            // 
            // menImportScan
            // 
            this.menImportScan.Image = ((System.Drawing.Image)(resources.GetObject("menImportScan.Image")));
            this.menImportScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menImportScan.Name = "menImportScan";
            this.menImportScan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menImportScan.Size = new System.Drawing.Size(188, 22);
            this.menImportScan.Text = "Import Scan";
            this.menImportScan.Click += new System.EventHandler(this.menImportScan_Click);
            // 
            // menSep1
            // 
            this.menSep1.Name = "menSep1";
            this.menSep1.Size = new System.Drawing.Size(185, 6);
            // 
            // menExportScan
            // 
            this.menExportScan.Image = ((System.Drawing.Image)(resources.GetObject("menExportScan.Image")));
            this.menExportScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menExportScan.Name = "menExportScan";
            this.menExportScan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menExportScan.Size = new System.Drawing.Size(188, 22);
            this.menExportScan.Text = "Export Scan";
            this.menExportScan.Click += new System.EventHandler(this.menExportScan_Click);
            // 
            // menExportSelection
            // 
            this.menExportSelection.Name = "menExportSelection";
            this.menExportSelection.Size = new System.Drawing.Size(188, 22);
            this.menExportSelection.Text = "Export Selection";
            this.menExportSelection.Click += new System.EventHandler(this.menExportSelection_Click);
            // 
            // menSep2
            // 
            this.menSep2.Name = "menSep2";
            this.menSep2.Size = new System.Drawing.Size(185, 6);
            // 
            // menFetchers
            // 
            this.menFetchers.Name = "menFetchers";
            this.menFetchers.Size = new System.Drawing.Size(188, 22);
            this.menFetchers.Text = "Fetchers...";
            this.menFetchers.Click += new System.EventHandler(this.menFetchers_Click);
            // 
            // menSep3
            // 
            this.menSep3.Name = "menSep3";
            this.menSep3.Size = new System.Drawing.Size(185, 6);
            // 
            // menScanStatistics
            // 
            this.menScanStatistics.Image = ((System.Drawing.Image)(resources.GetObject("menScanStatistics.Image")));
            this.menScanStatistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menScanStatistics.Name = "menScanStatistics";
            this.menScanStatistics.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menScanStatistics.Size = new System.Drawing.Size(188, 22);
            this.menScanStatistics.Text = "Scan Statistics";
            this.menScanStatistics.Click += new System.EventHandler(this.menScanStatistics_Click);
            // 
            // menEdit
            // 
            this.menEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menShowDetails,
            this.menSep4,
            this.menRescanSelected,
            this.menDeleteSelected,
            this.menSep5,
            this.menCopyIP,
            this.menCopyDetails});
            this.menEdit.Name = "menEdit";
            this.menEdit.Size = new System.Drawing.Size(39, 20);
            this.menEdit.Text = "Edit";
            // 
            // menShowDetails
            // 
            this.menShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("menShowDetails.Image")));
            this.menShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menShowDetails.Name = "menShowDetails";
            this.menShowDetails.Size = new System.Drawing.Size(199, 22);
            this.menShowDetails.Text = "Show Details";
            this.menShowDetails.Click += new System.EventHandler(this.menShowDetails_Click);
            // 
            // menSep4
            // 
            this.menSep4.Name = "menSep4";
            this.menSep4.Size = new System.Drawing.Size(196, 6);
            // 
            // menRescanSelected
            // 
            this.menRescanSelected.Image = ((System.Drawing.Image)(resources.GetObject("menRescanSelected.Image")));
            this.menRescanSelected.Name = "menRescanSelected";
            this.menRescanSelected.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menRescanSelected.Size = new System.Drawing.Size(199, 22);
            this.menRescanSelected.Text = "Rescan Selected";
            this.menRescanSelected.Click += new System.EventHandler(this.menRescanSelected_Click);
            // 
            // menDeleteSelected
            // 
            this.menDeleteSelected.Image = ((System.Drawing.Image)(resources.GetObject("menDeleteSelected.Image")));
            this.menDeleteSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menDeleteSelected.Name = "menDeleteSelected";
            this.menDeleteSelected.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menDeleteSelected.Size = new System.Drawing.Size(199, 22);
            this.menDeleteSelected.Text = "Delete Selected";
            this.menDeleteSelected.Click += new System.EventHandler(this.menDeleteSelected_Click);
            // 
            // menSep5
            // 
            this.menSep5.Name = "menSep5";
            this.menSep5.Size = new System.Drawing.Size(196, 6);
            // 
            // menCopyIP
            // 
            this.menCopyIP.Image = ((System.Drawing.Image)(resources.GetObject("menCopyIP.Image")));
            this.menCopyIP.Name = "menCopyIP";
            this.menCopyIP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menCopyIP.Size = new System.Drawing.Size(199, 22);
            this.menCopyIP.Text = "Copy IP";
            this.menCopyIP.Click += new System.EventHandler(this.menCopyIP_Click);
            // 
            // menCopyDetails
            // 
            this.menCopyDetails.Image = ((System.Drawing.Image)(resources.GetObject("menCopyDetails.Image")));
            this.menCopyDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menCopyDetails.Name = "menCopyDetails";
            this.menCopyDetails.Size = new System.Drawing.Size(199, 22);
            this.menCopyDetails.Text = "Copy Details";
            this.menCopyDetails.Click += new System.EventHandler(this.menCopyDetails_Click);
            // 
            // menView
            // 
            this.menView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAllScannedHosts,
            this.menSep6,
            this.menAliveHosts,
            this.menDeadHosts,
            this.menOpenPorts});
            this.menView.Name = "menView";
            this.menView.Size = new System.Drawing.Size(44, 20);
            this.menView.Text = "View";
            // 
            // menAllScannedHosts
            // 
            this.menAllScannedHosts.Checked = true;
            this.menAllScannedHosts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menAllScannedHosts.Name = "menAllScannedHosts";
            this.menAllScannedHosts.Size = new System.Drawing.Size(169, 22);
            this.menAllScannedHosts.Text = "All Scanned Hosts";
            this.menAllScannedHosts.CheckedChanged += new System.EventHandler(this.menAllScannedHosts_CheckedChanged);
            this.menAllScannedHosts.Click += new System.EventHandler(this.menAllScannedHosts_Click);
            // 
            // menSep6
            // 
            this.menSep6.Name = "menSep6";
            this.menSep6.Size = new System.Drawing.Size(166, 6);
            // 
            // menAliveHosts
            // 
            this.menAliveHosts.Name = "menAliveHosts";
            this.menAliveHosts.Size = new System.Drawing.Size(169, 22);
            this.menAliveHosts.Text = "Alive Hosts";
            this.menAliveHosts.CheckedChanged += new System.EventHandler(this.menAliveHosts_CheckedChanged);
            this.menAliveHosts.Click += new System.EventHandler(this.menAliveHosts_Click);
            // 
            // menDeadHosts
            // 
            this.menDeadHosts.Name = "menDeadHosts";
            this.menDeadHosts.Size = new System.Drawing.Size(169, 22);
            this.menDeadHosts.Text = "Dead Hosts";
            this.menDeadHosts.CheckedChanged += new System.EventHandler(this.menDeadHosts_CheckedChanged);
            this.menDeadHosts.Click += new System.EventHandler(this.menDeadHosts_Click);
            // 
            // menOpenPorts
            // 
            this.menOpenPorts.Name = "menOpenPorts";
            this.menOpenPorts.Size = new System.Drawing.Size(169, 22);
            this.menOpenPorts.Text = "Open Ports";
            this.menOpenPorts.CheckedChanged += new System.EventHandler(this.menOpenPorts_CheckedChanged);
            this.menOpenPorts.Click += new System.EventHandler(this.menOpenPorts_Click);
            // 
            // menSearch
            // 
            this.menSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNextAliveHost,
            this.menNextDeadHost,
            this.menNextOpenPort,
            this.menSep7,
            this.menPreviousAliveHost,
            this.menPreviousDeadHost,
            this.menPreviousOpenPort,
            this.menSep8,
            this.menFind});
            this.menSearch.Name = "menSearch";
            this.menSearch.Size = new System.Drawing.Size(54, 20);
            this.menSearch.Text = "Search";
            // 
            // menNextAliveHost
            // 
            this.menNextAliveHost.Name = "menNextAliveHost";
            this.menNextAliveHost.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menNextAliveHost.Size = new System.Drawing.Size(252, 22);
            this.menNextAliveHost.Text = "Next Alive Host";
            this.menNextAliveHost.Click += new System.EventHandler(this.menNextAliveHost_Click);
            // 
            // menNextDeadHost
            // 
            this.menNextDeadHost.Name = "menNextDeadHost";
            this.menNextDeadHost.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menNextDeadHost.Size = new System.Drawing.Size(252, 22);
            this.menNextDeadHost.Text = "Next Dead Host";
            this.menNextDeadHost.Click += new System.EventHandler(this.menNextDeadHost_Click);
            // 
            // menNextOpenPort
            // 
            this.menNextOpenPort.Name = "menNextOpenPort";
            this.menNextOpenPort.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menNextOpenPort.Size = new System.Drawing.Size(252, 22);
            this.menNextOpenPort.Text = "Next Open Port";
            this.menNextOpenPort.Click += new System.EventHandler(this.menNextOpenPort_Click);
            // 
            // menSep7
            // 
            this.menSep7.Name = "menSep7";
            this.menSep7.Size = new System.Drawing.Size(249, 6);
            // 
            // menPreviousAliveHost
            // 
            this.menPreviousAliveHost.Name = "menPreviousAliveHost";
            this.menPreviousAliveHost.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.menPreviousAliveHost.Size = new System.Drawing.Size(252, 22);
            this.menPreviousAliveHost.Text = "Previous Alive Host";
            this.menPreviousAliveHost.Click += new System.EventHandler(this.menPreviousAliveHost_Click);
            // 
            // menPreviousDeadHost
            // 
            this.menPreviousDeadHost.Name = "menPreviousDeadHost";
            this.menPreviousDeadHost.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menPreviousDeadHost.Size = new System.Drawing.Size(252, 22);
            this.menPreviousDeadHost.Text = "Previous Dead Host";
            this.menPreviousDeadHost.Click += new System.EventHandler(this.menPreviousDeadHost_Click);
            // 
            // menPreviousOpenPort
            // 
            this.menPreviousOpenPort.Name = "menPreviousOpenPort";
            this.menPreviousOpenPort.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menPreviousOpenPort.Size = new System.Drawing.Size(252, 22);
            this.menPreviousOpenPort.Text = "Previous Open Port";
            this.menPreviousOpenPort.Click += new System.EventHandler(this.menPreviousOpenPort_Click);
            // 
            // menSep8
            // 
            this.menSep8.Name = "menSep8";
            this.menSep8.Size = new System.Drawing.Size(249, 6);
            // 
            // menFind
            // 
            this.menFind.Image = ((System.Drawing.Image)(resources.GetObject("menFind.Image")));
            this.menFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menFind.Name = "menFind";
            this.menFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menFind.Size = new System.Drawing.Size(252, 22);
            this.menFind.Text = "Find...";
            this.menFind.Click += new System.EventHandler(this.menFind_Click);
            // 
            // menFavorites
            // 
            this.menFavorites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAddCurrentScan,
            this.menManageFavorites,
            this.menSep9});
            this.menFavorites.Name = "menFavorites";
            this.menFavorites.Size = new System.Drawing.Size(66, 20);
            this.menFavorites.Text = "Favorites";
            this.menFavorites.DropDownOpening += new System.EventHandler(this.menFavorites_DropDownOpening);
            // 
            // menAddCurrentScan
            // 
            this.menAddCurrentScan.Image = global::SharpScanner.Properties.Resources.favorites;
            this.menAddCurrentScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menAddCurrentScan.Name = "menAddCurrentScan";
            this.menAddCurrentScan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.menAddCurrentScan.Size = new System.Drawing.Size(208, 22);
            this.menAddCurrentScan.Text = "Add Current Scan";
            this.menAddCurrentScan.Click += new System.EventHandler(this.menAddCurrentScan_Click);
            // 
            // menManageFavorites
            // 
            this.menManageFavorites.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menManageFavorites.Name = "menManageFavorites";
            this.menManageFavorites.Size = new System.Drawing.Size(208, 22);
            this.menManageFavorites.Text = "Manage Favorites...";
            this.menManageFavorites.Click += new System.EventHandler(this.menManageFavorites_Click);
            // 
            // menSep9
            // 
            this.menSep9.Name = "menSep9";
            this.menSep9.Size = new System.Drawing.Size(205, 6);
            this.menSep9.Visible = false;
            // 
            // menSettings
            // 
            this.menSettings.Name = "menSettings";
            this.menSettings.Size = new System.Drawing.Size(61, 20);
            this.menSettings.Text = "Settings";
            this.menSettings.Click += new System.EventHandler(this.menSettings_Click);
            // 
            // menHelp
            // 
            this.menHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menViewHelp,
            this.menVisitWebsite,
            this.menSep10,
            this.menAboutSharpScanner});
            this.menHelp.Name = "menHelp";
            this.menHelp.Size = new System.Drawing.Size(44, 20);
            this.menHelp.Text = "Help";
            // 
            // menViewHelp
            // 
            this.menViewHelp.Image = ((System.Drawing.Image)(resources.GetObject("menViewHelp.Image")));
            this.menViewHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menViewHelp.Name = "menViewHelp";
            this.menViewHelp.Size = new System.Drawing.Size(185, 22);
            this.menViewHelp.Text = "View Help";
            this.menViewHelp.Click += new System.EventHandler(this.menViewHelp_Click);
            // 
            // menVisitWebsite
            // 
            this.menVisitWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menVisitWebsite.Image = ((System.Drawing.Image)(resources.GetObject("menVisitWebsite.Image")));
            this.menVisitWebsite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menVisitWebsite.Name = "menVisitWebsite";
            this.menVisitWebsite.Size = new System.Drawing.Size(185, 22);
            this.menVisitWebsite.Text = "Visit Website";
            this.menVisitWebsite.Click += new System.EventHandler(this.menVisitWebsite_Click);
            // 
            // menSep10
            // 
            this.menSep10.Name = "menSep10";
            this.menSep10.Size = new System.Drawing.Size(182, 6);
            // 
            // menAboutSharpScanner
            // 
            this.menAboutSharpScanner.Image = ((System.Drawing.Image)(resources.GetObject("menAboutSharpScanner.Image")));
            this.menAboutSharpScanner.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menAboutSharpScanner.Name = "menAboutSharpScanner";
            this.menAboutSharpScanner.Size = new System.Drawing.Size(185, 22);
            this.menAboutSharpScanner.Text = "About Sharp Scanner";
            this.menAboutSharpScanner.Click += new System.EventHandler(this.menAboutSharpScanner_Click);
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblStatusSpring,
            this.lblThreads,
            this.lblThreadCount,
            this.pbMain});
            this.stsMain.Location = new System.Drawing.Point(0, 594);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(1103, 22);
            this.stsMain.TabIndex = 1;
            this.stsMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // lblStatusSpring
            // 
            this.lblStatusSpring.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusSpring.Name = "lblStatusSpring";
            this.lblStatusSpring.Size = new System.Drawing.Size(892, 17);
            this.lblStatusSpring.Spring = true;
            this.lblStatusSpring.Text = " ";
            // 
            // lblThreads
            // 
            this.lblThreads.BackColor = System.Drawing.Color.Transparent;
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(55, 17);
            this.lblThreads.Text = "Threads: ";
            // 
            // lblThreadCount
            // 
            this.lblThreadCount.BackColor = System.Drawing.Color.Transparent;
            this.lblThreadCount.Name = "lblThreadCount";
            this.lblThreadCount.Size = new System.Drawing.Size(13, 17);
            this.lblThreadCount.Text = "0";
            // 
            // pbMain
            // 
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(100, 16);
            // 
            // conMain
            // 
            this.conMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conShowDetails,
            this.conSep1,
            this.conRescanSelected,
            this.conDeleteSelected,
            this.conSep2,
            this.conCopyIP,
            this.conCopyDetails,
            this.conSep3,
            this.conOpen});
            this.conMain.Name = "contextMenuStrip1";
            this.conMain.Size = new System.Drawing.Size(159, 154);
            // 
            // conShowDetails
            // 
            this.conShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("conShowDetails.Image")));
            this.conShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conShowDetails.Name = "conShowDetails";
            this.conShowDetails.Size = new System.Drawing.Size(158, 22);
            this.conShowDetails.Text = "Show Details";
            this.conShowDetails.Click += new System.EventHandler(this.conShowDetails_Click);
            // 
            // conSep1
            // 
            this.conSep1.Name = "conSep1";
            this.conSep1.Size = new System.Drawing.Size(155, 6);
            // 
            // conRescanSelected
            // 
            this.conRescanSelected.Image = ((System.Drawing.Image)(resources.GetObject("conRescanSelected.Image")));
            this.conRescanSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conRescanSelected.Name = "conRescanSelected";
            this.conRescanSelected.Size = new System.Drawing.Size(158, 22);
            this.conRescanSelected.Text = "Rescan Selected";
            this.conRescanSelected.Click += new System.EventHandler(this.conRescanSelected_Click);
            // 
            // conDeleteSelected
            // 
            this.conDeleteSelected.Image = ((System.Drawing.Image)(resources.GetObject("conDeleteSelected.Image")));
            this.conDeleteSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conDeleteSelected.Name = "conDeleteSelected";
            this.conDeleteSelected.Size = new System.Drawing.Size(158, 22);
            this.conDeleteSelected.Text = "Delete Selected";
            this.conDeleteSelected.Click += new System.EventHandler(this.conDeleteSelected_Click);
            // 
            // conSep2
            // 
            this.conSep2.Name = "conSep2";
            this.conSep2.Size = new System.Drawing.Size(155, 6);
            // 
            // conCopyIP
            // 
            this.conCopyIP.Image = ((System.Drawing.Image)(resources.GetObject("conCopyIP.Image")));
            this.conCopyIP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conCopyIP.Name = "conCopyIP";
            this.conCopyIP.Size = new System.Drawing.Size(158, 22);
            this.conCopyIP.Text = "Copy IP";
            this.conCopyIP.Click += new System.EventHandler(this.conCopyIP_Click);
            // 
            // conCopyDetails
            // 
            this.conCopyDetails.Image = ((System.Drawing.Image)(resources.GetObject("conCopyDetails.Image")));
            this.conCopyDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conCopyDetails.Name = "conCopyDetails";
            this.conCopyDetails.Size = new System.Drawing.Size(158, 22);
            this.conCopyDetails.Text = "Copy Details";
            this.conCopyDetails.Click += new System.EventHandler(this.conCopyDetails_Click);
            // 
            // conSep3
            // 
            this.conSep3.Name = "conSep3";
            this.conSep3.Size = new System.Drawing.Size(155, 6);
            // 
            // conOpen
            // 
            this.conOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conWebBrowser,
            this.conPing,
            this.conTraceRoute,
            this.conWhois});
            this.conOpen.Name = "conOpen";
            this.conOpen.Size = new System.Drawing.Size(158, 22);
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
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(3, 8);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(29, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(256, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.1.1";
            // 
            // cmbScan
            // 
            this.cmbScan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScan.FormattingEnabled = true;
            this.cmbScan.Items.AddRange(new object[] {
            "Single IP",
            "IP Range",
            "IP List"});
            this.cmbScan.Location = new System.Drawing.Point(291, 5);
            this.cmbScan.Name = "cmbScan";
            this.cmbScan.Size = new System.Drawing.Size(87, 21);
            this.cmbScan.TabIndex = 2;
            this.cmbScan.SelectedIndexChanged += new System.EventHandler(this.cmbScan_SelectedIndexChanged);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(384, 3);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // panSingleIP
            // 
            this.panSingleIP.BackColor = System.Drawing.SystemColors.Control;
            this.panSingleIP.Controls.Add(this.btnScan);
            this.panSingleIP.Controls.Add(this.txtIP);
            this.panSingleIP.Controls.Add(this.cmbScan);
            this.panSingleIP.Controls.Add(this.lblIP);
            this.panSingleIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSingleIP.Location = new System.Drawing.Point(0, 82);
            this.panSingleIP.Name = "panSingleIP";
            this.panSingleIP.Size = new System.Drawing.Size(1103, 29);
            this.panSingleIP.TabIndex = 5;
            // 
            // panIPRange
            // 
            this.panIPRange.BackColor = System.Drawing.SystemColors.Control;
            this.panIPRange.Controls.Add(this.btnScanRange);
            this.panIPRange.Controls.Add(this.cmbScanRange);
            this.panIPRange.Controls.Add(this.lblEndingIP);
            this.panIPRange.Controls.Add(this.txtBeginningIP);
            this.panIPRange.Controls.Add(this.txtEndingIP);
            this.panIPRange.Controls.Add(this.lblBeginningIP);
            this.panIPRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panIPRange.Location = new System.Drawing.Point(0, 53);
            this.panIPRange.Name = "panIPRange";
            this.panIPRange.Size = new System.Drawing.Size(1103, 29);
            this.panIPRange.TabIndex = 6;
            this.panIPRange.Visible = false;
            // 
            // btnScanRange
            // 
            this.btnScanRange.Location = new System.Drawing.Point(502, 3);
            this.btnScanRange.Name = "btnScanRange";
            this.btnScanRange.Size = new System.Drawing.Size(75, 23);
            this.btnScanRange.TabIndex = 7;
            this.btnScanRange.Text = "Scan";
            this.btnScanRange.UseVisualStyleBackColor = true;
            this.btnScanRange.Click += new System.EventHandler(this.btnScanRange_Click);
            // 
            // cmbScanRange
            // 
            this.cmbScanRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanRange.FormattingEnabled = true;
            this.cmbScanRange.Items.AddRange(new object[] {
            "Single IP",
            "IP Range",
            "IP List"});
            this.cmbScanRange.Location = new System.Drawing.Point(409, 5);
            this.cmbScanRange.Name = "cmbScanRange";
            this.cmbScanRange.Size = new System.Drawing.Size(87, 21);
            this.cmbScanRange.TabIndex = 6;
            this.cmbScanRange.SelectedIndexChanged += new System.EventHandler(this.cmbScanRange_SelectedIndexChanged);
            // 
            // lblEndingIP
            // 
            this.lblEndingIP.AutoSize = true;
            this.lblEndingIP.Location = new System.Drawing.Point(213, 8);
            this.lblEndingIP.Name = "lblEndingIP";
            this.lblEndingIP.Size = new System.Drawing.Size(56, 13);
            this.lblEndingIP.TabIndex = 4;
            this.lblEndingIP.Text = "Ending IP:";
            // 
            // txtBeginningIP
            // 
            this.txtBeginningIP.Location = new System.Drawing.Point(79, 5);
            this.txtBeginningIP.Name = "txtBeginningIP";
            this.txtBeginningIP.Size = new System.Drawing.Size(128, 20);
            this.txtBeginningIP.TabIndex = 4;
            this.txtBeginningIP.Text = "192.168.1.1";
            // 
            // txtEndingIP
            // 
            this.txtEndingIP.Location = new System.Drawing.Point(275, 5);
            this.txtEndingIP.Name = "txtEndingIP";
            this.txtEndingIP.Size = new System.Drawing.Size(128, 20);
            this.txtEndingIP.TabIndex = 5;
            this.txtEndingIP.Text = "192.168.1.255";
            // 
            // lblBeginningIP
            // 
            this.lblBeginningIP.AutoSize = true;
            this.lblBeginningIP.Location = new System.Drawing.Point(3, 8);
            this.lblBeginningIP.Name = "lblBeginningIP";
            this.lblBeginningIP.Size = new System.Drawing.Size(70, 13);
            this.lblBeginningIP.TabIndex = 0;
            this.lblBeginningIP.Text = "Beginning IP:";
            // 
            // panIPList
            // 
            this.panIPList.BackColor = System.Drawing.SystemColors.Control;
            this.panIPList.Controls.Add(this.btnBrowseList);
            this.panIPList.Controls.Add(this.btnScanList);
            this.panIPList.Controls.Add(this.txtFile);
            this.panIPList.Controls.Add(this.cmbScanList);
            this.panIPList.Controls.Add(this.lblFile);
            this.panIPList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panIPList.Location = new System.Drawing.Point(0, 24);
            this.panIPList.Name = "panIPList";
            this.panIPList.Size = new System.Drawing.Size(1103, 29);
            this.panIPList.TabIndex = 8;
            this.panIPList.Visible = false;
            // 
            // btnBrowseList
            // 
            this.btnBrowseList.Location = new System.Drawing.Point(228, 3);
            this.btnBrowseList.Name = "btnBrowseList";
            this.btnBrowseList.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseList.TabIndex = 9;
            this.btnBrowseList.Text = "Browse";
            this.btnBrowseList.UseVisualStyleBackColor = true;
            this.btnBrowseList.Click += new System.EventHandler(this.btnBrowseList_Click);
            // 
            // btnScanList
            // 
            this.btnScanList.Location = new System.Drawing.Point(402, 3);
            this.btnScanList.Name = "btnScanList";
            this.btnScanList.Size = new System.Drawing.Size(75, 23);
            this.btnScanList.TabIndex = 11;
            this.btnScanList.Text = "Scan";
            this.btnScanList.UseVisualStyleBackColor = true;
            this.btnScanList.Click += new System.EventHandler(this.btnScanList_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(35, 5);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(187, 20);
            this.txtFile.TabIndex = 8;
            // 
            // cmbScanList
            // 
            this.cmbScanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanList.FormattingEnabled = true;
            this.cmbScanList.Items.AddRange(new object[] {
            "Single IP",
            "IP Range",
            "IP List"});
            this.cmbScanList.Location = new System.Drawing.Point(309, 5);
            this.cmbScanList.Name = "cmbScanList";
            this.cmbScanList.Size = new System.Drawing.Size(87, 21);
            this.cmbScanList.TabIndex = 10;
            this.cmbScanList.SelectedIndexChanged += new System.EventHandler(this.cmbScanList_SelectedIndexChanged);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(3, 8);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(26, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File:";
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
            this.lvResults.Location = new System.Drawing.Point(0, 111);
            this.lvResults.Name = "lvResults";
            this.lvResults.SelectColumnsOnRightClick = false;
            this.lvResults.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.lvResults.ShowFilterMenuOnRightClick = false;
            this.lvResults.ShowGroups = false;
            this.lvResults.ShowHeaderInAllViews = false;
            this.lvResults.Size = new System.Drawing.Size(1103, 483);
            this.lvResults.SmallImageList = this.imgResults;
            this.lvResults.TabIndex = 0;
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
            this.colOnline.Text = "Online";
            this.colOnline.Width = 116;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 616);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.panSingleIP);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.panIPRange);
            this.Controls.Add(this.panIPList);
            this.Controls.Add(this.menMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menMain.ResumeLayout(false);
            this.menMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.conMain.ResumeLayout(false);
            this.panSingleIP.ResumeLayout(false);
            this.panSingleIP.PerformLayout();
            this.panIPRange.ResumeLayout(false);
            this.panIPRange.PerformLayout();
            this.panIPList.ResumeLayout(false);
            this.panIPList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menMain;
        private System.Windows.Forms.ToolStripMenuItem menFile;
        private System.Windows.Forms.ToolStripMenuItem menImportScan;
        private System.Windows.Forms.ToolStripSeparator menSep1;
        private System.Windows.Forms.ToolStripMenuItem menExportScan;
        private System.Windows.Forms.ToolStripMenuItem menExportSelection;
        private System.Windows.Forms.ToolStripSeparator menSep2;
        private System.Windows.Forms.ToolStripMenuItem menFetchers;
        private System.Windows.Forms.ToolStripSeparator menSep3;
        private System.Windows.Forms.ToolStripMenuItem menScanStatistics;
        private System.Windows.Forms.ToolStripMenuItem menEdit;
        private System.Windows.Forms.ToolStripMenuItem menShowDetails;
        private System.Windows.Forms.ToolStripSeparator menSep4;
        private System.Windows.Forms.ToolStripMenuItem menRescanSelected;
        private System.Windows.Forms.ToolStripMenuItem menDeleteSelected;
        private System.Windows.Forms.ToolStripSeparator menSep5;
        private System.Windows.Forms.ToolStripMenuItem menCopyIP;
        private System.Windows.Forms.ToolStripMenuItem menCopyDetails;
        private System.Windows.Forms.ToolStripMenuItem menSearch;
        private System.Windows.Forms.ToolStripMenuItem menNextAliveHost;
        private System.Windows.Forms.ToolStripMenuItem menNextOpenPort;
        private System.Windows.Forms.ToolStripMenuItem menNextDeadHost;
        private System.Windows.Forms.ToolStripSeparator menSep7;
        private System.Windows.Forms.ToolStripMenuItem menPreviousAliveHost;
        private System.Windows.Forms.ToolStripMenuItem menPreviousOpenPort;
        private System.Windows.Forms.ToolStripMenuItem menPreviousDeadHost;
        private System.Windows.Forms.ToolStripSeparator menSep8;
        private System.Windows.Forms.ToolStripMenuItem menFind;
        private System.Windows.Forms.ToolStripMenuItem menFavorites;
        private System.Windows.Forms.ToolStripMenuItem menAddCurrentScan;
        private System.Windows.Forms.ToolStripMenuItem menManageFavorites;
        private System.Windows.Forms.ToolStripSeparator menSep9;
        private System.Windows.Forms.ToolStripMenuItem menSettings;
        private System.Windows.Forms.ToolStripMenuItem menHelp;
        private System.Windows.Forms.ToolStripMenuItem menViewHelp;
        private System.Windows.Forms.ToolStripMenuItem menVisitWebsite;
        private System.Windows.Forms.ToolStripSeparator menSep10;
        private System.Windows.Forms.ToolStripMenuItem menAboutSharpScanner;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbScan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.ContextMenuStrip conMain;
        private System.Windows.Forms.ToolStripMenuItem conShowDetails;
        private System.Windows.Forms.ToolStripSeparator conSep1;
        private System.Windows.Forms.ToolStripMenuItem conRescanSelected;
        private System.Windows.Forms.ToolStripMenuItem conDeleteSelected;
        private System.Windows.Forms.ToolStripSeparator conSep2;
        private System.Windows.Forms.ToolStripMenuItem conCopyIP;
        private System.Windows.Forms.ToolStripMenuItem conCopyDetails;
        private System.Windows.Forms.ToolStripSeparator conSep3;
        private System.Windows.Forms.ToolStripMenuItem conOpen;
        private System.Windows.Forms.ToolStripMenuItem conWebBrowser;
        private System.Windows.Forms.ToolStripMenuItem conPing;
        private System.Windows.Forms.ToolStripMenuItem conTraceRoute;
        private System.Windows.Forms.ToolStripMenuItem conWhois;
        private System.Windows.Forms.Panel panSingleIP;
        private System.Windows.Forms.Panel panIPRange;
        private System.Windows.Forms.TextBox txtEndingIP;
        private System.Windows.Forms.Label lblEndingIP;
        private System.Windows.Forms.Button btnScanRange;
        private System.Windows.Forms.TextBox txtBeginningIP;
        private System.Windows.Forms.ComboBox cmbScanRange;
        private System.Windows.Forms.Label lblBeginningIP;
        private System.Windows.Forms.ToolStripMenuItem menView;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSpring;
        private System.Windows.Forms.ToolStripStatusLabel lblThreads;
        private System.Windows.Forms.ToolStripStatusLabel lblThreadCount;
        private System.Windows.Forms.ToolStripProgressBar pbMain;
        private System.Windows.Forms.ToolStripMenuItem menAllScannedHosts;
        private System.Windows.Forms.ToolStripSeparator menSep6;
        private System.Windows.Forms.ToolStripMenuItem menAliveHosts;
        private System.Windows.Forms.ToolStripMenuItem menDeadHosts;
        private System.Windows.Forms.ToolStripMenuItem menOpenPorts;
        private System.Windows.Forms.Panel panIPList;
        private System.Windows.Forms.Button btnBrowseList;
        private System.Windows.Forms.Button btnScanList;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ComboBox cmbScanList;
        private System.Windows.Forms.Label lblFile;
        private BrightIdeasSoftware.ObjectListView lvResults;
        private BrightIdeasSoftware.OLVColumn colHost;
        internal BrightIdeasSoftware.OLVColumn colHostname;
        internal BrightIdeasSoftware.OLVColumn colMAC;
        internal BrightIdeasSoftware.OLVColumn colPing;
        internal BrightIdeasSoftware.OLVColumn colOnline;
        private System.Windows.Forms.ImageList imgResults;
    }
}

