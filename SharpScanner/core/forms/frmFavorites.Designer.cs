namespace SharpScanner
{
    partial class frmFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavorites));
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lvFavorites = new BrightIdeasSoftware.ObjectListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.lvFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(452, 311);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(12, 311);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(29, 23);
            this.btnMoveUp.TabIndex = 1;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(47, 311);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(29, 23);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(82, 311);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(163, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Manage your favorite scans below:";
            // 
            // lvFavorites
            // 
            this.lvFavorites.AllColumns.Add(this.colName);
            this.lvFavorites.AlternateRowBackColor = System.Drawing.SystemColors.ControlLight;
            this.lvFavorites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.lvFavorites.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvFavorites.EmptyListMsg = "No Favorites";
            this.lvFavorites.FullRowSelect = true;
            this.lvFavorites.GridLines = true;
            this.lvFavorites.Location = new System.Drawing.Point(12, 25);
            this.lvFavorites.Name = "lvFavorites";
            this.lvFavorites.SelectColumnsOnRightClick = false;
            this.lvFavorites.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.lvFavorites.ShowFilterMenuOnRightClick = false;
            this.lvFavorites.ShowGroups = false;
            this.lvFavorites.ShowHeaderInAllViews = false;
            this.lvFavorites.Size = new System.Drawing.Size(515, 280);
            this.lvFavorites.TabIndex = 6;
            this.lvFavorites.UseCompatibleStateImageBehavior = false;
            this.lvFavorites.UseFiltering = true;
            this.lvFavorites.UseHotItem = true;
            this.lvFavorites.View = System.Windows.Forms.View.SmallIcon;
            this.lvFavorites.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.lvResults_ItemsChanged);
            // 
            // colName
            // 
            this.colName.Sortable = false;
            this.colName.Text = "Name";
            this.colName.Width = 500;
            // 
            // frmFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 346);
            this.Controls.Add(this.lvFavorites);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavorites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Scanner";
            this.Load += new System.EventHandler(this.frmFavorites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvFavorites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInfo;
        private BrightIdeasSoftware.ObjectListView lvFavorites;
        private BrightIdeasSoftware.OLVColumn colName;
    }
}