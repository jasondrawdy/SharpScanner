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

#region Import

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

#endregion
namespace SharpScanner
{
    public partial class frmFetchers : Form
    {
        frmMain reference { get; set; }
        ObjectListView mod { get; set; }
        public frmFetchers(frmMain original, ObjectListView vanilla)
        {
            InitializeComponent();
            reference = original;
            mod = vanilla;
        }

        private void frmFetchers_Load(object sender, EventArgs e)
        {
            if (SettingsManager.fetchers.Hostname) { lstActiveFetchers.Items.Add("Hostname"); }
            else { lstAvailableFetchers.Items.Add("Hostname"); }
            if (SettingsManager.fetchers.MAC) { lstActiveFetchers.Items.Add("MAC"); }
            else { lstAvailableFetchers.Items.Add("MAC"); }
            if (SettingsManager.fetchers.Ping) { lstActiveFetchers.Items.Add("Ping"); }
            else { lstAvailableFetchers.Items.Add("Ping"); }
            if (SettingsManager.fetchers.Online) { lstActiveFetchers.Items.Add("Online"); }
            else { lstAvailableFetchers.Items.Add("Online"); }
        }

        private void btnActivateFetcher_Click(object sender, EventArgs e)
        {
            if (lstAvailableFetchers.SelectedItem != null)
            {
                lstActiveFetchers.Items.Add(lstAvailableFetchers.SelectedItem);
                lstAvailableFetchers.Items.Remove(lstAvailableFetchers.SelectedItem);
            }
            else
                MessageBox.Show("Please select an available fetcher to activate.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeactivateFetcher_Click(object sender, EventArgs e)
        {
            if (lstActiveFetchers.SelectedItem != null)
            {
                lstAvailableFetchers.Items.Add(lstActiveFetchers.SelectedItem);
                lstActiveFetchers.Items.Remove(lstActiveFetchers.SelectedItem);
            }
            else
                MessageBox.Show("Please a select an active fetcher to deactivate.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool hostname = false, mac = false, ping = false, online = false;

            // Set our activated fetcher flags.
            foreach (string x in lstActiveFetchers.Items)
            {
                if (x == "Hostname")
                {
                    hostname = true;
                    reference.colHostname.IsVisible = true;
                }
                if (x == "MAC")
                {
                    mac = true;
                    reference.colMAC.IsVisible = true;
                }
                if (x == "Ping")
                {
                    ping = true;
                    reference.colPing.IsVisible = true;
                }
                if (x == "Online")
                {
                    online = true;
                    reference.colOnline.IsVisible = true;
                }
            }

            // Set our available fetcher flags.
            foreach (string x in lstAvailableFetchers.Items)
            {
                if (x == "Hostname")
                {
                    hostname = false;
                    reference.colHostname.IsVisible = false;
                }
                if (x == "MAC")
                {
                    mac = false;
                    reference.colMAC.IsVisible = false;
                }
                if (x == "Ping")
                {
                    ping = false;
                    reference.colPing.IsVisible = false;
                }
                if (x == "Online")
                {
                    online = false;
                    reference.colOnline.IsVisible = false;
                }
            }

            // Save our settings.
            SettingsManager.fetchers = new Fetchers(hostname, mac, ping, online);
            SettingsManager.SaveSettings();

            // Rebuild our columns to reflect changes.
            mod.RebuildColumns();

            // Close the form.
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstActiveFetchers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActiveFetchers.SelectedItem != null) { lstAvailableFetchers.SelectedItem = null; }
        }

        private void lstAvailableFetchers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvailableFetchers.SelectedItem != null) { lstActiveFetchers.SelectedItem = null; }
        }

        private void lstActiveFetchers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstActiveFetchers.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                if (lstActiveFetchers.SelectedItem != null)
                {
                    lstAvailableFetchers.Items.Add(lstActiveFetchers.SelectedItem);
                    lstActiveFetchers.Items.Remove(lstActiveFetchers.SelectedItem);
                }
            }
        }

        private void lstAvailableFetchers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstAvailableFetchers.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                if (lstAvailableFetchers.SelectedItem != null)
                {
                    lstActiveFetchers.Items.Add(lstAvailableFetchers.SelectedItem);
                    lstAvailableFetchers.Items.Remove(lstAvailableFetchers.SelectedItem);
                }
            }
        }
    }
}
