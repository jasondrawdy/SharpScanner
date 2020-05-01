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
    public partial class frmSearch : Form
    {
        IModelFilter ogFilter { get; set; }
        ObjectListView reference { get; set; }
        public frmSearch(ObjectListView list)
        {
            InitializeComponent();
            reference = list;
            ogFilter = list.ModelFilter;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (reference.Items.Count > 0)
            {
                // Check if there are any matches.
                List<ScanObject> objects = new List<ScanObject>();
                bool matchFound = false;
                string search = txtSearch.Text.ToLower();
                foreach (ScanObject so in reference.Objects)
                {
                    // Add all results to the list, exact and partial.
                    if (so.Address.ToLower().Contains(search))
                    {
                        matchFound = true;
                        objects.Add(so);
                    }
                    else if (so.Hostname.ToLower().Contains(search))
                    {
                        matchFound = true;
                        objects.Add(so);
                    }
                    else if (so.MAC.ToLower().Contains(search))
                    {
                        matchFound = true;
                        objects.Add(so);
                    }
                    else if (so.Ping.ToLower().Contains(search))
                    {
                        matchFound = true;
                        objects.Add(so);
                    }
                    else if (so.Online.ToLower().Contains(search))
                    {
                        matchFound = true;
                        objects.Add(so);
                    }
                }

                // Display a message if no matches were found.
                if (!matchFound) { MessageBox.Show("No matches were found.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                {
                    // Open a new form with all of the search results.
                    if (objects.Count > 1)
                    {
                        frmResults results = new frmResults(objects);
                        results.ShowDialog();
                    }
                    else
                    {
                        // Just hightlight the only result we got.
                        if (objects.Count == 1)
                        {
                            reference.SelectedObject = objects[0];
                            reference.EnsureModelVisible(reference.SelectedObject);
                        }
                        Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                btnFind.PerformClick();
        }
    }
}
