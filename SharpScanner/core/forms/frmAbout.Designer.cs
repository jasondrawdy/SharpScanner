namespace SharpScanner
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(160, 31);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(128, 128);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(425, 14);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Sharp Scanner";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBuild
            // 
            this.lblBuild.Location = new System.Drawing.Point(12, 190);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(425, 14);
            this.lblBuild.TabIndex = 1;
            this.lblBuild.Text = "Version: 1.0.0 - Pumpkin (Build 0001)";
            this.lblBuild.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(12, 204);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(425, 14);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "© 2017 Jason Tanner. All Rights Reserved.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 258);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Label lblCopyright;
    }
}