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

#region Imports

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BrightIdeasSoftware;

#endregion
namespace SharpScanner
{
    public partial class frmResults : Form
    {
        public frmResults(List<ScanObject> results)
        {
            InitializeComponent();

            // Create text overlays with colors to match our theme.
            TextOverlay queueOverlay = lvResults.EmptyListMsgOverlay as TextOverlay;
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
            lvResults.HotItemStyle = new HotItemStyle();
            lvResults.HotItemStyle.Decoration = rbd;

            // Setup aspect getters programatically in case we decide to encrypt our executable.
            colHost.AspectGetter += delegate (object x) { return ((ScanObject)x).IP; };
            colHostname.AspectGetter += delegate (object x) { return ((ScanObject)x).Hostname; };
            colMAC.AspectGetter += delegate (object x) { return ((ScanObject)x).MAC; };
            colPing.AspectGetter += delegate (object x) { return ((ScanObject)x).Ping; };
            colOnline.AspectGetter += delegate (object x) { return ((ScanObject)x).Online; };

            // Set our image selection delegates for both of our listviews.
            colHost.ImageGetter += delegate (object rowObject)
            {
                int imageIndex = 0;
                ScanObject fo = (ScanObject)rowObject;
                if (fo.Status == ScanStatus.Unknown) { imageIndex = 0; }
                else if (fo.Status == ScanStatus.Dead) { imageIndex = 1; }
                else if (fo.Status == ScanStatus.Alive)
                {
                    int ping = 0;
                    string parse = fo.Ping;
                    parse = parse.Replace("ms", "");
                    parse = parse.Trim(null);
                    int.TryParse(parse, out ping);
                    if (ping > 0 && ping < 70)
                        imageIndex = 3;
                    else if (ping > 70 && ping < 200)
                        imageIndex = 4;
                    else if (ping >= 200)
                        imageIndex = 5;
                    else
                        imageIndex = 2;
                }
                else { imageIndex = 0; }
                return imageIndex;
            };

            // Set our objects.
            lvResults.AddObjects(results);
            Text += " - " + lvResults.Items.Count.ToString() + " Results";
        }

        private void lvResults_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            // Refresh our list objects and it's view.
            if (lvResults.Items.Count == 0)
                lvResults.View = View.SmallIcon;
            else
                lvResults.View = View.Details;
        }

        private void conShowDetails_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedItem != null)
                {
                    ScanObject so = lvResults.SelectedObject as ScanObject;
                    frmDetails details = new frmDetails(so, lvResults);
                    details.ShowDialog();
                }
                else
                    MessageBox.Show("There isn't a selected item with details to show.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conCopyIP_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedObject != null)
                {
                    try
                    {
                        ScanObject so = lvResults.SelectedObject as ScanObject;
                        Clipboard.SetText(so.Address);
                        MessageBox.Show("The selected IP has been copied to the clipboard!", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("The selected IP could not be copied to the clipboard.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                    MessageBox.Show("There isn't a selected host to copy the IP from.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conCopyDetails_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedItem != null)
                {
                    try
                    {
                        ScanObject so = lvResults.SelectedObject as ScanObject;
                        Clipboard.SetText(
                            "IP: " + so.Address + Environment.NewLine +
                            "Hostname: " + so.Hostname + Environment.NewLine +
                            "MAC: " + so.MAC + Environment.NewLine +
                            "Ping: " + so.Ping + Environment.NewLine +
                            "Online: " + so.Online + Environment.NewLine +
                            "Comments: " + so.Comments + Environment.NewLine
                            );
                        MessageBox.Show("The selected host details have been copied to the clipboard!", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { MessageBox.Show("The selected host details could not be copied to the clipboard.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                    MessageBox.Show("There isn't a selected item with details to copy.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conWebBrowser_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedItem != null)
                {
                    try
                    {
                        ScanObject so = lvResults.SelectedObject as ScanObject;
                        Process.Start("http://" + so.Address);
                    }
                    catch { MessageBox.Show("The selected host could not be opened.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                    MessageBox.Show("There isn't a selected host to open with a web browser.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conPing_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedItem != null)
                {
                    try
                    {
                        ScanObject so = lvResults.SelectedObject as ScanObject;
                        ProcessStartInfo proc = new ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = "/c ping " + so.Address;
                        Process.Start(proc);
                    }
                    catch { MessageBox.Show("The selected host could not be pinged.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                    MessageBox.Show("There isn't a selected host to ping.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conTraceRoute_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedItem != null)
                {
                    try
                    {
                        ScanObject so = lvResults.SelectedObject as ScanObject;
                        ProcessStartInfo proc = new ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = "/c tracert " + so.Address;
                        Process.Start(proc);
                    }
                    catch { MessageBox.Show("A traceroute could not be run on the selected host.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                    MessageBox.Show("There isn't a selected host to traceroute.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conWhois_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedItem != null)
                {
                    try
                    {
                        ScanObject so = lvResults.SelectedObject as ScanObject;
                        ProcessStartInfo proc = new ProcessStartInfo();
                        proc.FileName = @"C:\windows\system32\cmd.exe";
                        proc.Arguments = "/c nslookup " + so.Address;
                        Process.Start(proc);
                    }
                    catch { MessageBox.Show("A whois could not be run on the selected host.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                    MessageBox.Show("There isn't a selected host to whois.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
