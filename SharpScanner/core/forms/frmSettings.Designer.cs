namespace SharpScanner
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.lblVersion = new System.Windows.Forms.Label();
            this.chkDisplayStatisticsDialog = new System.Windows.Forms.CheckBox();
            this.chkAskForConfirmation = new System.Windows.Forms.CheckBox();
            this.chkSkipUnassignedAddresses = new System.Windows.Forms.CheckBox();
            this.numPingTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblPingTimeout = new System.Windows.Forms.Label();
            this.numPingProbes = new System.Windows.Forms.NumericUpDown();
            this.lblPingProbes = new System.Windows.Forms.Label();
            this.numThreadCreationDelay = new System.Windows.Forms.NumericUpDown();
            this.lblThreadCreationDelay = new System.Windows.Forms.Label();
            this.numMaxThreads = new System.Windows.Forms.NumericUpDown();
            this.lblMaxThreads = new System.Windows.Forms.Label();
            this.btnGeneralClose = new System.Windows.Forms.Button();
            this.btnGeneralOK = new System.Windows.Forms.Button();
            this.lblGeneral = new MonoFlat.MonoFlat_HeaderLabel();
            this.sepGeneral2 = new MonoFlat.MonoFlat_Separator();
            this.sepGeneral1 = new MonoFlat.MonoFlat_Separator();
            this.tabMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProbes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreadCreationDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpGeneral);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(453, 474);
            this.tabMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.lblVersion);
            this.tpGeneral.Controls.Add(this.chkDisplayStatisticsDialog);
            this.tpGeneral.Controls.Add(this.chkAskForConfirmation);
            this.tpGeneral.Controls.Add(this.chkSkipUnassignedAddresses);
            this.tpGeneral.Controls.Add(this.numPingTimeout);
            this.tpGeneral.Controls.Add(this.lblPingTimeout);
            this.tpGeneral.Controls.Add(this.numPingProbes);
            this.tpGeneral.Controls.Add(this.lblPingProbes);
            this.tpGeneral.Controls.Add(this.numThreadCreationDelay);
            this.tpGeneral.Controls.Add(this.lblThreadCreationDelay);
            this.tpGeneral.Controls.Add(this.numMaxThreads);
            this.tpGeneral.Controls.Add(this.lblMaxThreads);
            this.tpGeneral.Controls.Add(this.btnGeneralClose);
            this.tpGeneral.Controls.Add(this.btnGeneralOK);
            this.tpGeneral.Controls.Add(this.lblGeneral);
            this.tpGeneral.Controls.Add(this.sepGeneral2);
            this.tpGeneral.Controls.Add(this.sepGeneral1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(445, 448);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVersion.Location = new System.Drawing.Point(22, 271);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(178, 13);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "Version 1.0.0 - Pumpkin (Build 0001)";
            // 
            // chkDisplayStatisticsDialog
            // 
            this.chkDisplayStatisticsDialog.AutoSize = true;
            this.chkDisplayStatisticsDialog.Checked = true;
            this.chkDisplayStatisticsDialog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayStatisticsDialog.Location = new System.Drawing.Point(25, 235);
            this.chkDisplayStatisticsDialog.Name = "chkDisplayStatisticsDialog";
            this.chkDisplayStatisticsDialog.Size = new System.Drawing.Size(249, 17);
            this.chkDisplayStatisticsDialog.TabIndex = 15;
            this.chkDisplayStatisticsDialog.Text = "Display the statistics dialog box after each scan";
            this.chkDisplayStatisticsDialog.UseVisualStyleBackColor = true;
            // 
            // chkAskForConfirmation
            // 
            this.chkAskForConfirmation.AutoSize = true;
            this.chkAskForConfirmation.Checked = true;
            this.chkAskForConfirmation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAskForConfirmation.Location = new System.Drawing.Point(25, 212);
            this.chkAskForConfirmation.Name = "chkAskForConfirmation";
            this.chkAskForConfirmation.Size = new System.Drawing.Size(247, 17);
            this.chkAskForConfirmation.TabIndex = 14;
            this.chkAskForConfirmation.Text = "Ask for confirmation before starting a new scan";
            this.chkAskForConfirmation.UseVisualStyleBackColor = true;
            // 
            // chkSkipUnassignedAddresses
            // 
            this.chkSkipUnassignedAddresses.AutoSize = true;
            this.chkSkipUnassignedAddresses.Checked = true;
            this.chkSkipUnassignedAddresses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipUnassignedAddresses.Location = new System.Drawing.Point(25, 189);
            this.chkSkipUnassignedAddresses.Name = "chkSkipUnassignedAddresses";
            this.chkSkipUnassignedAddresses.Size = new System.Drawing.Size(358, 17);
            this.chkSkipUnassignedAddresses.TabIndex = 13;
            this.chkSkipUnassignedAddresses.Text = "Skip potentially unassinged IP addresses during scan (ex: *0 and *255)";
            this.chkSkipUnassignedAddresses.UseVisualStyleBackColor = true;
            // 
            // numPingTimeout
            // 
            this.numPingTimeout.Location = new System.Drawing.Point(166, 163);
            this.numPingTimeout.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numPingTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPingTimeout.Name = "numPingTimeout";
            this.numPingTimeout.Size = new System.Drawing.Size(252, 20);
            this.numPingTimeout.TabIndex = 12;
            this.numPingTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblPingTimeout
            // 
            this.lblPingTimeout.AutoSize = true;
            this.lblPingTimeout.Location = new System.Drawing.Point(22, 165);
            this.lblPingTimeout.Name = "lblPingTimeout";
            this.lblPingTimeout.Size = new System.Drawing.Size(94, 13);
            this.lblPingTimeout.TabIndex = 11;
            this.lblPingTimeout.Text = "Ping Timeout (ms):";
            // 
            // numPingProbes
            // 
            this.numPingProbes.Location = new System.Drawing.Point(166, 137);
            this.numPingProbes.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numPingProbes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPingProbes.Name = "numPingProbes";
            this.numPingProbes.Size = new System.Drawing.Size(252, 20);
            this.numPingProbes.TabIndex = 10;
            this.numPingProbes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblPingProbes
            // 
            this.lblPingProbes.AutoSize = true;
            this.lblPingProbes.Location = new System.Drawing.Point(22, 139);
            this.lblPingProbes.Name = "lblPingProbes";
            this.lblPingProbes.Size = new System.Drawing.Size(114, 13);
            this.lblPingProbes.TabIndex = 9;
            this.lblPingProbes.Text = "Ping Probes (packets):";
            // 
            // numThreadCreationDelay
            // 
            this.numThreadCreationDelay.Location = new System.Drawing.Point(166, 111);
            this.numThreadCreationDelay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numThreadCreationDelay.Name = "numThreadCreationDelay";
            this.numThreadCreationDelay.Size = new System.Drawing.Size(252, 20);
            this.numThreadCreationDelay.TabIndex = 8;
            // 
            // lblThreadCreationDelay
            // 
            this.lblThreadCreationDelay.AutoSize = true;
            this.lblThreadCreationDelay.Location = new System.Drawing.Point(22, 113);
            this.lblThreadCreationDelay.Name = "lblThreadCreationDelay";
            this.lblThreadCreationDelay.Size = new System.Drawing.Size(138, 13);
            this.lblThreadCreationDelay.TabIndex = 7;
            this.lblThreadCreationDelay.Text = "Thread Creation Delay (ms):";
            // 
            // numMaxThreads
            // 
            this.numMaxThreads.Location = new System.Drawing.Point(166, 85);
            this.numMaxThreads.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numMaxThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxThreads.Name = "numMaxThreads";
            this.numMaxThreads.Size = new System.Drawing.Size(252, 20);
            this.numMaxThreads.TabIndex = 6;
            this.numMaxThreads.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblMaxThreads
            // 
            this.lblMaxThreads.AutoSize = true;
            this.lblMaxThreads.Location = new System.Drawing.Point(22, 87);
            this.lblMaxThreads.Name = "lblMaxThreads";
            this.lblMaxThreads.Size = new System.Drawing.Size(75, 13);
            this.lblMaxThreads.TabIndex = 5;
            this.lblMaxThreads.Text = "Max Threads: ";
            // 
            // btnGeneralClose
            // 
            this.btnGeneralClose.Location = new System.Drawing.Point(281, 417);
            this.btnGeneralClose.Name = "btnGeneralClose";
            this.btnGeneralClose.Size = new System.Drawing.Size(75, 23);
            this.btnGeneralClose.TabIndex = 3;
            this.btnGeneralClose.Text = "Close";
            this.btnGeneralClose.UseVisualStyleBackColor = true;
            this.btnGeneralClose.Click += new System.EventHandler(this.btnGeneralClose_Click);
            // 
            // btnGeneralOK
            // 
            this.btnGeneralOK.Location = new System.Drawing.Point(362, 417);
            this.btnGeneralOK.Name = "btnGeneralOK";
            this.btnGeneralOK.Size = new System.Drawing.Size(75, 23);
            this.btnGeneralOK.TabIndex = 4;
            this.btnGeneralOK.Text = "OK";
            this.btnGeneralOK.UseVisualStyleBackColor = true;
            this.btnGeneralOK.Click += new System.EventHandler(this.btnGeneralOK_Click);
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.BackColor = System.Drawing.Color.Transparent;
            this.lblGeneral.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.ForeColor = System.Drawing.Color.Black;
            this.lblGeneral.Location = new System.Drawing.Point(17, 18);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(258, 45);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "General Settings";
            // 
            // sepGeneral2
            // 
            this.sepGeneral2.BackColor = System.Drawing.Color.White;
            this.sepGeneral2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sepGeneral2.Location = new System.Drawing.Point(25, 258);
            this.sepGeneral2.Name = "sepGeneral2";
            this.sepGeneral2.Size = new System.Drawing.Size(393, 10);
            this.sepGeneral2.TabIndex = 2;
            this.sepGeneral2.Text = "monoFlat_Separator1";
            // 
            // sepGeneral1
            // 
            this.sepGeneral1.BackColor = System.Drawing.Color.White;
            this.sepGeneral1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sepGeneral1.Location = new System.Drawing.Point(25, 62);
            this.sepGeneral1.Name = "sepGeneral1";
            this.sepGeneral1.Size = new System.Drawing.Size(393, 10);
            this.sepGeneral1.TabIndex = 2;
            this.sepGeneral1.Text = "monoFlat_Separator1";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 474);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPingTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPingProbes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreadCreationDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private MonoFlat.MonoFlat_Separator sepGeneral1;
        private MonoFlat.MonoFlat_HeaderLabel lblGeneral;
        private System.Windows.Forms.Button btnGeneralClose;
        private System.Windows.Forms.Button btnGeneralOK;
        private System.Windows.Forms.NumericUpDown numPingProbes;
        private System.Windows.Forms.Label lblPingProbes;
        private System.Windows.Forms.NumericUpDown numThreadCreationDelay;
        private System.Windows.Forms.Label lblThreadCreationDelay;
        private System.Windows.Forms.NumericUpDown numMaxThreads;
        private System.Windows.Forms.Label lblMaxThreads;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.CheckBox chkDisplayStatisticsDialog;
        private System.Windows.Forms.CheckBox chkAskForConfirmation;
        private System.Windows.Forms.CheckBox chkSkipUnassignedAddresses;
        private System.Windows.Forms.NumericUpDown numPingTimeout;
        private System.Windows.Forms.Label lblPingTimeout;
        private MonoFlat.MonoFlat_Separator sepGeneral2;
    }
}