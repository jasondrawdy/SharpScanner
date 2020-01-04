namespace SharpScanner
{
    partial class frmFetchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFetchers));
            this.lstActiveFetchers = new System.Windows.Forms.ListBox();
            this.btnActivateFetcher = new System.Windows.Forms.Button();
            this.btnDeactivateFetcher = new System.Windows.Forms.Button();
            this.lstAvailableFetchers = new System.Windows.Forms.ListBox();
            this.lblActiveFetchers = new System.Windows.Forms.Label();
            this.lblAvailableFetchers = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActiveFetchers
            // 
            this.lstActiveFetchers.FormattingEnabled = true;
            this.lstActiveFetchers.Location = new System.Drawing.Point(12, 72);
            this.lstActiveFetchers.Name = "lstActiveFetchers";
            this.lstActiveFetchers.Size = new System.Drawing.Size(179, 160);
            this.lstActiveFetchers.TabIndex = 0;
            this.lstActiveFetchers.SelectedIndexChanged += new System.EventHandler(this.lstActiveFetchers_SelectedIndexChanged);
            this.lstActiveFetchers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstActiveFetchers_MouseDoubleClick);
            // 
            // btnActivateFetcher
            // 
            this.btnActivateFetcher.Location = new System.Drawing.Point(197, 128);
            this.btnActivateFetcher.Name = "btnActivateFetcher";
            this.btnActivateFetcher.Size = new System.Drawing.Size(73, 23);
            this.btnActivateFetcher.TabIndex = 1;
            this.btnActivateFetcher.Text = "←";
            this.btnActivateFetcher.UseVisualStyleBackColor = true;
            this.btnActivateFetcher.Click += new System.EventHandler(this.btnActivateFetcher_Click);
            // 
            // btnDeactivateFetcher
            // 
            this.btnDeactivateFetcher.Location = new System.Drawing.Point(197, 157);
            this.btnDeactivateFetcher.Name = "btnDeactivateFetcher";
            this.btnDeactivateFetcher.Size = new System.Drawing.Size(73, 23);
            this.btnDeactivateFetcher.TabIndex = 2;
            this.btnDeactivateFetcher.Text = "→";
            this.btnDeactivateFetcher.UseVisualStyleBackColor = true;
            this.btnDeactivateFetcher.Click += new System.EventHandler(this.btnDeactivateFetcher_Click);
            // 
            // lstAvailableFetchers
            // 
            this.lstAvailableFetchers.FormattingEnabled = true;
            this.lstAvailableFetchers.Location = new System.Drawing.Point(276, 72);
            this.lstAvailableFetchers.Name = "lstAvailableFetchers";
            this.lstAvailableFetchers.Size = new System.Drawing.Size(179, 160);
            this.lstAvailableFetchers.TabIndex = 0;
            this.lstAvailableFetchers.SelectedIndexChanged += new System.EventHandler(this.lstAvailableFetchers_SelectedIndexChanged);
            this.lstAvailableFetchers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAvailableFetchers_MouseDoubleClick);
            // 
            // lblActiveFetchers
            // 
            this.lblActiveFetchers.AutoSize = true;
            this.lblActiveFetchers.Location = new System.Drawing.Point(9, 56);
            this.lblActiveFetchers.Name = "lblActiveFetchers";
            this.lblActiveFetchers.Size = new System.Drawing.Size(84, 13);
            this.lblActiveFetchers.TabIndex = 3;
            this.lblActiveFetchers.Text = "Active Fetchers:";
            // 
            // lblAvailableFetchers
            // 
            this.lblAvailableFetchers.AutoSize = true;
            this.lblAvailableFetchers.Location = new System.Drawing.Point(273, 56);
            this.lblAvailableFetchers.Name = "lblAvailableFetchers";
            this.lblAvailableFetchers.Size = new System.Drawing.Size(94, 13);
            this.lblAvailableFetchers.TabIndex = 3;
            this.lblAvailableFetchers.Text = "Available Fetchers";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(443, 41);
            this.grpInfo.TabIndex = 4;
            this.grpInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoEllipsis = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(437, 22);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Select your desired fetchers for scanning. Fetchers are represented by listview c" +
    "olumns.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(369, 247);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFetchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 284);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblAvailableFetchers);
            this.Controls.Add(this.lblActiveFetchers);
            this.Controls.Add(this.btnDeactivateFetcher);
            this.Controls.Add(this.btnActivateFetcher);
            this.Controls.Add(this.lstAvailableFetchers);
            this.Controls.Add(this.lstActiveFetchers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFetchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.Load += new System.EventHandler(this.frmFetchers_Load);
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstActiveFetchers;
        private System.Windows.Forms.Button btnActivateFetcher;
        private System.Windows.Forms.Button btnDeactivateFetcher;
        private System.Windows.Forms.ListBox lstAvailableFetchers;
        private System.Windows.Forms.Label lblActiveFetchers;
        private System.Windows.Forms.Label lblAvailableFetchers;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}