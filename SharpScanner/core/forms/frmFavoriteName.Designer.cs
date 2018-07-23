namespace SharpScanner
{
    partial class frmFavoriteName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavoriteName));
            this.lblFavoriteName = new System.Windows.Forms.Label();
            this.txtFavoriteName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFavoriteName
            // 
            this.lblFavoriteName.AutoSize = true;
            this.lblFavoriteName.Location = new System.Drawing.Point(12, 15);
            this.lblFavoriteName.Name = "lblFavoriteName";
            this.lblFavoriteName.Size = new System.Drawing.Size(79, 13);
            this.lblFavoriteName.TabIndex = 0;
            this.lblFavoriteName.Text = "Favorite Name:";
            // 
            // txtFavoriteName
            // 
            this.txtFavoriteName.Location = new System.Drawing.Point(97, 12);
            this.txtFavoriteName.Name = "txtFavoriteName";
            this.txtFavoriteName.Size = new System.Drawing.Size(244, 20);
            this.txtFavoriteName.TabIndex = 1;
            this.txtFavoriteName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFavoriteName_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFavoriteName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 72);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFavoriteName);
            this.Controls.Add(this.lblFavoriteName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavoriteName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFavoriteName;
        private System.Windows.Forms.TextBox txtFavoriteName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}