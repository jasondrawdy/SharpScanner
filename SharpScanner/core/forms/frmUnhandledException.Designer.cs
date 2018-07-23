namespace SharpScanner
{
    partial class frmUnhandledException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnhandledException));
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.sep1 = new MonoFlat.MonoFlat_Separator();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionValue = new System.Windows.Forms.Label();
            this.lblTimestampValue = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(343, 117);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(262, 117);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(25, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(96, 96);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(146, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(272, 46);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Sharp Scanner has encountered a bug which has caused it to crash. If you would li" +
    "ke, you may restart Sharp Scanner or close the application completely.";
            // 
            // sep1
            // 
            this.sep1.Location = new System.Drawing.Point(149, 61);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(269, 10);
            this.sep1.TabIndex = 4;
            this.sep1.Text = "monoFlat_Separator1";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(146, 74);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version:";
            // 
            // lblVersionValue
            // 
            this.lblVersionValue.AutoSize = true;
            this.lblVersionValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVersionValue.Location = new System.Drawing.Point(205, 74);
            this.lblVersionValue.Name = "lblVersionValue";
            this.lblVersionValue.Size = new System.Drawing.Size(23, 13);
            this.lblVersionValue.TabIndex = 5;
            this.lblVersionValue.Text = "null";
            // 
            // lblTimestampValue
            // 
            this.lblTimestampValue.AutoSize = true;
            this.lblTimestampValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTimestampValue.Location = new System.Drawing.Point(205, 89);
            this.lblTimestampValue.Name = "lblTimestampValue";
            this.lblTimestampValue.Size = new System.Drawing.Size(23, 13);
            this.lblTimestampValue.TabIndex = 6;
            this.lblTimestampValue.Text = "null";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(146, 89);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(61, 13);
            this.lblTimestamp.TabIndex = 7;
            this.lblTimestamp.Text = "Timestamp:";
            // 
            // frmUnhandledException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 152);
            this.Controls.Add(this.lblTimestampValue);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.lblVersionValue);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnhandledException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnhandledException_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblInfo;
        private MonoFlat.MonoFlat_Separator sep1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionValue;
        private System.Windows.Forms.Label lblTimestampValue;
        private System.Windows.Forms.Label lblTimestamp;
    }
}