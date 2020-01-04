/*
==============================================================================
Copyright © Jason Drawdy (CloneMerge)

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
    public partial class frmDetails : Form
    {
        ScanObject mod { get; set; }
        ObjectListView n { get; set; }
        public frmDetails(ScanObject original, ObjectListView list)
        {
            InitializeComponent();
            mod = original;
            n = list;
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            txtDetails.Text += "IP: " + mod.Address + Environment.NewLine;
            txtDetails.Text += "Hostname: " + mod.Hostname + Environment.NewLine;
            txtDetails.Text += "MAC: " + mod.MAC + Environment.NewLine;
            txtDetails.Text += "Ping: " + mod.Ping + Environment.NewLine;
            txtDetails.Text += "Online: " + mod.Online + Environment.NewLine;
            txtDetails.Text += "Comments: " + mod.Comments;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtComments.Text.Trim(null) == "")
                MessageBox.Show("Please enter a comment to add.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                mod.Comments = txtComments.Text;
                RefreshDetails();
                n.RebuildColumns();
                txtComments.Text = "";
            }
        }

        private void RefreshDetails()
        {
            txtDetails.Text = "";
            txtDetails.Text += "IP: " + mod.Address + Environment.NewLine;
            txtDetails.Text += "Hostname: " + mod.Hostname + Environment.NewLine;
            txtDetails.Text += "MAC: " + mod.MAC + Environment.NewLine;
            txtDetails.Text += "Ping: " + mod.Ping + Environment.NewLine;
            txtDetails.Text += "Online: " + mod.Online + Environment.NewLine;
            txtDetails.Text += "Comments: " + mod.Comments;
        }

        private void txtComments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                btnAdd.PerformClick();
        }
    }
}
