namespace SharpScanner
{
    partial class frmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblAveragePerHost = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblScanType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHostsScanned = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHostsOnline = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblHostsOpen = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.sep2 = new MonoFlat.MonoFlat_Separator();
            this.sep1 = new MonoFlat.MonoFlat_Separator();
            this.lblHeader = new MonoFlat.MonoFlat_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(128, 128);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(382, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(151, 102);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(71, 13);
            this.lblTotalTime.TabIndex = 4;
            this.lblTotalTime.Text = "Total Time:";
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(220, 102);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(23, 13);
            this.lblElapsed.TabIndex = 5;
            this.lblElapsed.Text = "null";
            // 
            // lblAveragePerHost
            // 
            this.lblAveragePerHost.AutoSize = true;
            this.lblAveragePerHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveragePerHost.Location = new System.Drawing.Point(151, 117);
            this.lblAveragePerHost.Name = "lblAveragePerHost";
            this.lblAveragePerHost.Size = new System.Drawing.Size(111, 13);
            this.lblAveragePerHost.TabIndex = 6;
            this.lblAveragePerHost.Text = "Average Per Host:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(260, 117);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(23, 13);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "null";
            // 
            // lblScanType
            // 
            this.lblScanType.AutoSize = true;
            this.lblScanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanType.Location = new System.Drawing.Point(151, 73);
            this.lblScanType.Name = "lblScanType";
            this.lblScanType.Size = new System.Drawing.Size(72, 13);
            this.lblScanType.TabIndex = 8;
            this.lblScanType.Text = "Scan Type:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(221, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(23, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "null";
            // 
            // lblHostsScanned
            // 
            this.lblHostsScanned.AutoSize = true;
            this.lblHostsScanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostsScanned.Location = new System.Drawing.Point(151, 132);
            this.lblHostsScanned.Name = "lblHostsScanned";
            this.lblHostsScanned.Size = new System.Drawing.Size(97, 13);
            this.lblHostsScanned.TabIndex = 10;
            this.lblHostsScanned.Text = "Hosts Scanned:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(246, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "null";
            // 
            // lblHostsOnline
            // 
            this.lblHostsOnline.AutoSize = true;
            this.lblHostsOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostsOnline.Location = new System.Drawing.Point(151, 147);
            this.lblHostsOnline.Name = "lblHostsOnline";
            this.lblHostsOnline.Size = new System.Drawing.Size(83, 13);
            this.lblHostsOnline.TabIndex = 12;
            this.lblHostsOnline.Text = "Hosts Online:";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(232, 147);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(23, 13);
            this.lblOnline.TabIndex = 13;
            this.lblOnline.Text = "null";
            // 
            // lblHostsOpen
            // 
            this.lblHostsOpen.AutoSize = true;
            this.lblHostsOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostsOpen.Location = new System.Drawing.Point(151, 162);
            this.lblHostsOpen.Name = "lblHostsOpen";
            this.lblHostsOpen.Size = new System.Drawing.Size(77, 13);
            this.lblHostsOpen.TabIndex = 14;
            this.lblHostsOpen.Text = "Hosts Open:";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(226, 162);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(23, 13);
            this.lblOpen.TabIndex = 15;
            this.lblOpen.Text = "null";
            // 
            // sep2
            // 
            this.sep2.Location = new System.Drawing.Point(154, 89);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(319, 10);
            this.sep2.TabIndex = 2;
            this.sep2.Text = "monoFlat_Separator1";
            // 
            // sep1
            // 
            this.sep1.Location = new System.Drawing.Point(154, 60);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(319, 10);
            this.sep1.TabIndex = 2;
            this.sep1.Text = "monoFlat_Separator1";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(146, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(246, 45);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Scan Complete!";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 236);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblHostsOpen);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lblHostsOnline);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHostsScanned);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblScanType);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblAveragePerHost);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.sep2);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatistics_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private MonoFlat.MonoFlat_HeaderLabel lblHeader;
        private MonoFlat.MonoFlat_Separator sep1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblAveragePerHost;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblScanType;
        private System.Windows.Forms.Label lblType;
        private MonoFlat.MonoFlat_Separator sep2;
        private System.Windows.Forms.Label lblHostsScanned;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHostsOnline;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblHostsOpen;
        private System.Windows.Forms.Label lblOpen;
    }
}