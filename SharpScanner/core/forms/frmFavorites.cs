/*
==============================================================================
Copyright © Jason Drawdy 

All rights reserved.

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Except as contained in this notice, the name of the above copyright holder
shall not be used in advertising or otherwise to promote the sale, use or
other dealings in this Software without prior written authorization.
==============================================================================
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace SharpScanner
{
    public partial class frmFavorites : Form
    {
        public frmFavorites()
        {
            InitializeComponent();

            // Create text overlays with colors to match our theme.
            TextOverlay queueOverlay = lvFavorites.EmptyListMsgOverlay as TextOverlay;
            queueOverlay.BorderWidth = 0f;
            queueOverlay.Font = new Font(Font.FontFamily, 12);
            queueOverlay.TextColor = Color.DimGray;
            queueOverlay.BackColor = Color.FromArgb(255, 255, 255);
            queueOverlay.BorderColor = Color.FromArgb(40, 146, 255);

            // Create our HotTracking decoration.
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(64, Color.White), 0);
            rbd.FillBrush = new SolidBrush(Color.FromArgb(64, SystemColors.Highlight));
            rbd.BoundsPadding = new Size(0, 0);
            rbd.CornerRounding = 0.0f;
            lvFavorites.HotItemStyle = new HotItemStyle();
            lvFavorites.HotItemStyle.Decoration = rbd;

            // Setup aspect getters programatically in case we decide to encrypt our executable.
            colName.AspectGetter += delegate (object x) { return ((FavoriteObject)x).Name; };
        }

        private void frmFavorites_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lvFavorites.Items.Count > 0)
            {
                if (lvFavorites.SelectedObject != null)
                    MoveItem(-1);
                else
                    MessageBox.Show("There isn't a selected favorite to move up.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no favorites. Try adding some.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lvFavorites.Items.Count > 0)
            {
                if (lvFavorites.SelectedObject != null)
                    MoveItem(1);
                else
                    MessageBox.Show("There isn't a selected favorite to move down.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no favorites. Try adding some.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvFavorites.Items.Count > 0)
            {
                if (lvFavorites.SelectedObject != null)
                {
                    FavoriteObject f = lvFavorites.SelectedObject as FavoriteObject;
                    frmEdit edit = new frmEdit(f, lvFavorites);
                    edit.ShowDialog();
                }
                else
                    MessageBox.Show("There isn't a selected favorite to edit.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no favorites. Try adding some.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFavorites.Items.Count > 0)
            {
                if (lvFavorites.SelectedObjects.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you would like to delete?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        lvFavorites.RemoveObjects(lvFavorites.SelectedObjects);
                }
                else
                    MessageBox.Show("There are no selected favorites to delete.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no favorites. Try adding some.", " Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> favorites = new Dictionary<string, string>();
            if (lvFavorites.Items.Count > 0)
            {
                foreach (FavoriteObject f in lvFavorites.Objects)
                    favorites.Add(f.Name, f.Data);

                SettingsManager.favorites = favorites;
                SettingsManager.SaveSettings();
                Close();
            }
            else
            {
                SettingsManager.favorites = favorites;
                SettingsManager.SaveSettings();
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvResults_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            // Refresh our list objects and it's view.
            if (lvFavorites.Items.Count == 0)
                lvFavorites.View = View.SmallIcon;
            else
                lvFavorites.View = View.Details;
        }

        private void PopulateList()
        {
            List<FavoriteObject> favorites = new List<FavoriteObject>();
            for (int i = 0; i < SettingsManager.favorites.Count; i++)
            {
                string name = SettingsManager.favorites.ElementAt(i).Key;
                string data = SettingsManager.favorites.ElementAt(i).Value;
                FavoriteObject f = new FavoriteObject(name, data);
                favorites.Add(f);
            }
            lvFavorites.AddObjects(favorites);
        }

        private void MoveItem(int direction)
        {
            // Calculate new index using our direction.
            int index = lvFavorites.SelectedIndex + direction;

            // Check if we can move in that direction.
            if (index < 0 || index > lvFavorites.Items.Count)
                return;

            // Add our object to an ICollection.
            List<FavoriteObject> f = new List<FavoriteObject>();
            FavoriteObject fo = lvFavorites.SelectedObject as FavoriteObject;
            f.Add(fo);

            // Remove our collection.
            lvFavorites.RemoveObjects(f);

            // Insert our collection at the new index.
            lvFavorites.InsertObjects(index, f);
            
            // Set the focus to the new index.
            foreach (FavoriteObject x in lvFavorites.Objects)
            {
                if (fo.Name == x.Name)
                {
                    lvFavorites.SelectedObject = x;
                    break;
                }
            }
            lvFavorites.Focus();
            //lvFavorites.SetObjects(f);
        }
    }
}
