/*
==============================================================================
Copyright © Jason Tanner (Antebyte)

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
using System.IO;
using System.Net;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using BrightIdeasSoftware;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Networking;

#endregion
namespace SharpScanner
{
    public enum ScanType { Single, Range, List, Rescan }
    public partial class frmMain : Form
    {
        #region Variables

        bool isScanning = false;
        bool isStatsShowing = false;
        private ScanType type = new ScanType();
        private double average = 0; // Average time per host to scan.
        private int progress = 0; // Progress percentage of scan.
        private int complete = 0; // Number of compelted threads.
        private long threads = 0; // Number of running threads.
        private int total = 0; // Number of hosts to be scanned.
        private int online = 0; // Number of online hosts.
        private int open = 0; // Number of hosts with open ports.
        private Stopwatch time; // Stopwatch to track time of scans.
        private StatsObject stats = null; // Keep the scan results in an object.

        #endregion
        #region Initialization

        public frmMain()
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
        }

        #endregion
        #region Controls

        #region Form

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set the default scan type.
            cmbScan.SelectedIndex = 0;

            // Load our settings.
            SettingsManager.LoadSettings();

            // Show columns based on our fetchers.
            if (!SettingsManager.fetchers.Hostname) { colHostname.IsVisible = false; }
            if (!SettingsManager.fetchers.MAC) { colMAC.IsVisible = false; }
            if (!SettingsManager.fetchers.Ping) { colPing.IsVisible = false; }
            if (!SettingsManager.fetchers.Online) { colOnline.IsVisible = false; }
            lvResults.RebuildColumns(); // Make sure our changes are reflected.
        }

        private void cmbScan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbScan.SelectedIndex)
            {
                case 0:
                    cmbScan.SelectedIndex = 0;
                    panSingleIP.Visible = true;
                    panIPRange.Visible = false;
                    panIPList.Visible = false;
                    break;
                case 1:
                    cmbScanRange.SelectedIndex = 1;
                    panSingleIP.Visible = false;
                    panIPRange.Visible = true;
                    panIPList.Visible = false;
                    break;
                case 2:
                    cmbScanList.SelectedIndex = 2;
                    panSingleIP.Visible = false;
                    panIPRange.Visible = false;
                    panIPList.Visible = true;
                    break;
                default:
                    cmbScan.SelectedIndex = 0;
                    panSingleIP.Visible = true;
                    panIPRange.Visible = false;
                    panIPList.Visible = false;
                    break;
            }
        }

        private void cmbScanRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbScanRange.SelectedIndex)
            {
                case 0:
                    cmbScan.SelectedIndex = 0;
                    panSingleIP.Visible = true;
                    panIPRange.Visible = false;
                    panIPList.Visible = false;
                    break;
                case 1:
                    cmbScanRange.SelectedIndex = 1;
                    panSingleIP.Visible = false;
                    panIPRange.Visible = true;
                    panIPList.Visible = false;
                    break;
                case 2:
                    cmbScanList.SelectedIndex = 2;
                    panSingleIP.Visible = false;
                    panIPRange.Visible = false;
                    panIPList.Visible = true;
                    break;
                default:
                    cmbScan.SelectedIndex = 0;
                    panSingleIP.Visible = true;
                    panIPRange.Visible = false;
                    panIPList.Visible = false;
                    break;
            }
        }

        private void cmbScanList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbScanList.SelectedIndex)
            {
                case 0:
                    cmbScan.SelectedIndex = 0;
                    panSingleIP.Visible = true;
                    panIPRange.Visible = false;
                    panIPList.Visible = false;
                    break;
                case 1:
                    cmbScanRange.SelectedIndex = 1;
                    panSingleIP.Visible = false;
                    panIPRange.Visible = true;
                    panIPList.Visible = false;
                    break;
                case 2:
                    cmbScanList.SelectedIndex = 2;
                    panSingleIP.Visible = false;
                    panIPRange.Visible = false;
                    panIPList.Visible = true;
                    break;
                default:
                    cmbScan.SelectedIndex = 0;
                    panSingleIP.Visible = true;
                    panIPRange.Visible = false;
                    panIPList.Visible = false;
                    break;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            // Check if we should ask before clearing results.
            if (SettingsManager.askForConfirmation)
            {
                // Check if there are results displayed already.
                if (lvResults.Items.Count > 0)
                {
                    if (MessageBox.Show("Would you like to discard the current scan results?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lvResults.ClearObjects();
                    }
                    else { goto DontDiscard; }
                }
            }
            else { lvResults.ClearObjects(); }

            // Try to start our single IP scan.
            try
            {
                // Check if our input is a valid IP.
                IPAddress ip;
                IPAddress.TryParse(txtIP.Text, out ip);

                // Check if our IP object is null our not.
                if (ip == null) { throw new NullReferenceException("You must enter a valid IP address to scan."); }
                else
                {
                    // Start our scan if we have valid input.
                    type = ScanType.Single;
                    Thread t = new Thread(() => BeginScan(ip)); t.Start();
                    LockControls();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            // A goto statement to avoid spaghetti code.
            DontDiscard: { };
        }

        private void btnScanRange_Click(object sender, EventArgs e)
        {
            // Check if we should ask before clearing results.
            if (SettingsManager.askForConfirmation)
            {
                // Check if there are results displayed already.
                if (lvResults.Items.Count > 0)
                {
                    if (MessageBox.Show("Would you like to discard the current scan results?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lvResults.ClearObjects();
                    }
                    else { goto DontDiscard; }
                }
            }
            else { lvResults.ClearObjects(); }

            try
            {
                // Check if we have valid IP addresses.
                IPAddress begin, end;
                IPAddressRange range;
                IPAddress.TryParse(txtBeginningIP.Text, out begin);
                IPAddress.TryParse(txtEndingIP.Text, out end);
                if (begin == null && end == null) { throw new NullReferenceException("You must enter a valid beginning and ending IP address to scan."); }
                else if (begin == null) { throw new NullReferenceException("You must enter a valid beginning IP address to scan."); }
                else if (end == null) { throw new NullReferenceException("You must enter a valid ending IP address to scan."); }
                else { range = new IPAddressRange(begin, end); } // Check if we can create a valid range.

                if (range == null)
                {
                    throw new NullReferenceException("The range of IP addresses is invalid.");
                }

                // Start our scan if we have a valid range.
                type = ScanType.Range;
                Thread t = new Thread(() => BeginScanRange(range)); t.Start();
                LockControls();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            // A goto statement to avoid spaghetti code.
            DontDiscard: { };
        }

        private void btnScanList_Click(object sender, EventArgs e)
        {
            // Check if we should ask before clearing results.
            if (SettingsManager.askForConfirmation)
            {
                // Check if there are results displayed already.
                if (lvResults.Items.Count > 0)
                {
                    if (MessageBox.Show("Would you like to discard the current scan results?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lvResults.ClearObjects();
                    }
                    else { goto DontDiscard; }
                }
            }
            else { lvResults.ClearObjects(); }

            try
            {
                // Try to find IP addresses by parsing the list using regex.
                if (File.Exists(txtFile.Text))
                {
                    List<IPAddress> ips = ParseList(txtFile.Text);
                    type = ScanType.List;
                    Thread t = new Thread(() => BeginScanList(ips)); t.Start();
                    LockControls();
                }
                else
                    throw new Exception("Please select a valid file to scan.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            // A goto statement to avoid spaghetti code.
            DontDiscard: { };
        }

        private void btnBrowseList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open IP file to scan";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Text file (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
                txtFile.Text = ofd.FileName;
        }

        private void lvResults_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            // Refresh our list objects and it's view.
            if (lvResults.Items.Count == 0)
                lvResults.View = View.SmallIcon;
            else
                lvResults.View = View.Details;
        }

        #endregion
        #region MenuStrip

        #region File

        private void menImportScan_Click(object sender, EventArgs e)
        {
            // Check if we should ask before clearing results.
            if (SettingsManager.askForConfirmation)
            {
                // Check if there are results displayed already.
                if (lvResults.Items.Count > 0)
                {
                    if (MessageBox.Show("Would you like to discard the current scan results?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lvResults.ClearObjects();
                    }
                    else { goto DontDiscard; }
                }
            }
            else { lvResults.ClearObjects(); }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Import scan results";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "XML Document (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
                ImportResults(ofd.FileName);

            DontDiscard: { };
        }

        private void menExportScan_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Export all scan results";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Filter = "XML Document (*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XDocument results = AllResults();
                    results.Save(sfd.FileName);
                }
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menExportSelection_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedObjects.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "Export selected scan results";
                    sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    sfd.Filter = "XML Document (*.xml)|*.xml";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        XDocument results = SelectedResults();
                        results.Save(sfd.FileName);
                    }
                }
                else
                    MessageBox.Show("There are no selected scan results to export.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menFetchers_Click(object sender, EventArgs e)
        {
            frmFetchers fetchers = new frmFetchers(this, lvResults);
            fetchers.ShowDialog();
        }

        private XDocument SelectedResults()
        {
            XElement xeRoot = new XElement("Results");
            foreach (ScanObject item in lvResults.SelectedObjects)
            {
                XElement xeRow = new XElement("result");
                XElement xeCol = new XElement("IP", item.IP);
                xeRow.Add(xeCol);
                xeCol = new XElement("Hostname", item.Hostname);
                xeRow.Add(xeCol);
                xeCol = new XElement("MAC", item.MAC);
                xeRow.Add(xeCol);
                xeCol = new XElement("Ping", item.Ping);
                xeRow.Add(xeCol);
                xeCol = new XElement("Online", item.Online);
                xeRow.Add(xeCol);
                xeCol = new XElement("Comments", item.Comments);
                xeRow.Add(xeCol);
                xeRoot.Add(xeRow);
            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Generated by Sharp Scanner 1.0.0"),
                new XComment("Website: https://github.com/antebyte/sharpscanner"),
                xeRoot);

            return doc;
        }

        private XDocument AllResults()
        {
            XElement xeRoot = new XElement("Results");
            foreach (ScanObject item in lvResults.Objects)
            {
                XElement xeRow = new XElement("result");
                XElement xeCol = new XElement("IP", item.IP);
                xeRow.Add(xeCol);
                xeCol = new XElement("Hostname", item.Hostname);
                xeRow.Add(xeCol);
                xeCol = new XElement("MAC", item.MAC);
                xeRow.Add(xeCol);
                xeCol = new XElement("Ping", item.Ping);
                xeRow.Add(xeCol);
                xeCol = new XElement("Online", item.Online);
                xeRow.Add(xeCol);
                xeCol = new XElement("Comments", item.Comments);
                xeRow.Add(xeCol);
                xeRoot.Add(xeRow);
            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Generated by Sharp Scanner 1.0.0"),
                new XComment("Website: https://github.com/antebyte/sharpscanner"),
                xeRoot);

            return doc;
        }

        private void menScanStatistics_Click(object sender, EventArgs e)
        {
            if (stats != null)
            {
                frmStatistics statistics = new frmStatistics(stats.ScanType, stats.TotalTime, stats.AverageTime,
                                                                 stats.TotalHosts, stats.OnlineHosts, stats.OpenHosts);
                statistics.ShowDialog();
            }
            else
                MessageBox.Show("There are no scan statistics to show. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion
        #region Edit

        private void menShowDetails_Click(object sender, EventArgs e)
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
                    MessageBox.Show("There isn't a selected host with details to show.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menCopyDetails_Click(object sender, EventArgs e)
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
                    MessageBox.Show("There isn't a selected host with details to copy.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //ScanObject so = lvResults.SelectedObject as ScanObject;
            //try
            //{
            //    Clipboard.SetText("Hello");
            //    //Clipboard.SetText(
            //    //    "IP: " + so.Address + Environment.NewLine +
            //    //    "Hostname: " + so.Hostname + Environment.NewLine +
            //    //    "MAC: " + so.MAC + Environment.NewLine +
            //    //    "Ping: " + so.Ping + Environment.NewLine +
            //    //    "Online: " + so.Online + Environment.NewLine +
            //    //    "Comments: " + so.Comments + Environment.NewLine
            //    //    );
            //    MessageBox.Show("The selected host's details have been copied!", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch
            //{
            //    MessageBox.Show("The selected host's details could not be copied.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //} 
        }

        private void menRescanSelected_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedObjects.Count > 0)
                {
                    // Reset each selected object.
                    List<IPAddress> rescans = new List<IPAddress>();
                    foreach (ScanObject so in lvResults.SelectedObjects)
                    {
                        so.Hostname = "";
                        so.MAC = "";
                        so.Ping = "";
                        so.Online = "";
                        so.Status = ScanStatus.Unknown;
                        rescans.Add(so.IP);
                        lvResults.UpdateObject(so);
                    }

                    // Begin scanning our selected IPs.
                    type = ScanType.Rescan;
                    Thread t = new Thread(() => BeginScanList(rescans)); t.Start();
                    LockControls();
                }
                else
                    MessageBox.Show("There aren't any selected hosts to rescan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedObjects.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you would like to delete?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        lvResults.RemoveObjects(lvResults.SelectedObjects);
                }
                else
                    MessageBox.Show("There aren't any selected hosts to delete.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menCopyIP_Click(object sender, EventArgs e)
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

        #endregion
        #region View

        private void menAllScannedHosts_Click(object sender, EventArgs e)
        {
            if (menAllScannedHosts.Checked == false) { menAllScannedHosts.Checked = true; }
        }

        private void menAliveHosts_Click(object sender, EventArgs e)
        {
            if (menAliveHosts.Checked == false) { menAliveHosts.Checked = true; }
        }

        private void menDeadHosts_Click(object sender, EventArgs e)
        {
            if (menDeadHosts.Checked == false) { menDeadHosts.Checked = true; }
        }

        private void menOpenPorts_Click(object sender, EventArgs e)
        {
            if (menOpenPorts.Checked == false) { menOpenPorts.Checked = true; }
        }

        private void menAllScannedHosts_CheckedChanged(object sender, EventArgs e)
        {
            if (menAllScannedHosts.Checked == true)
            {
                // Flip some switches.
                menAliveHosts.Checked = false;
                menDeadHosts.Checked = false;
                menOpenPorts.Checked = false;

                // Reset our model filter to show all results.
                if (lvResults.ModelFilter != null) { lvResults.ModelFilter = null; }

                // Refresh our list objects and it's view.
                lvResults.RebuildColumns();
                if (lvResults.Items.Count == 0)
                    lvResults.View = View.SmallIcon;
                else
                    lvResults.View = View.Details;
            }
        }

        private void menAliveHosts_CheckedChanged(object sender, EventArgs e)
        {
            if (menAliveHosts.Checked == true)
            {
                // Flip some switches.
                menAllScannedHosts.Checked = false;
                menDeadHosts.Checked = false;
                menOpenPorts.Checked = false;

                // Install a new model filter.
                lvResults.ModelFilter = new ModelFilter(delegate (object x)
                {
                    // Cast our delegate's parameter to our scan object.
                    ScanObject s = x as ScanObject;

                    // Check how the object should be filtered.
                    if (s.Online == "True") { return true; }
                    else { return false; }
                });

                // Refresh our list objects and it's view.
                lvResults.RebuildColumns();
                if (lvResults.Items.Count == 0)
                    lvResults.View = View.SmallIcon;
                else
                    lvResults.View = View.Details;
            }
        }

        private void menDeadHosts_CheckedChanged(object sender, EventArgs e)
        {
            if (menDeadHosts.Checked == true)
            {
                // Flip some switches.
                menAllScannedHosts.Checked = false;
                menAliveHosts.Checked = false;
                menOpenPorts.Checked = false;

                // Install a new model filter.
                lvResults.ModelFilter = new ModelFilter(delegate (object x)
                {
                    // Cast our delegate's parameter to our scan object.
                    ScanObject s = x as ScanObject;

                    // Check how the object should be filtered.
                    if (s.Online == "False") { return true; }
                    else { return false; }
                });

                // Refresh our list objects and it's view.
                lvResults.RebuildColumns();
                if (lvResults.Items.Count == 0)
                    lvResults.View = View.SmallIcon;
                else
                    lvResults.View = View.Details;
            }
        }

        private void menOpenPorts_CheckedChanged(object sender, EventArgs e)
        {
            if (menOpenPorts.Checked == true)
            {
                // Flip some switches.
                menAllScannedHosts.Checked = false;
                menAliveHosts.Checked = false;
                menDeadHosts.Checked = false;

                // Install a new model filter.
                lvResults.ModelFilter = new ModelFilter(delegate (object x)
                {
                    return false; // TODO: Include port knock results in scan.
                });

                // Refresh our list objects and it's view.
                lvResults.RebuildColumns();
                if (lvResults.Items.Count == 0)
                    lvResults.View = View.SmallIcon;
                else
                    lvResults.View = View.Details;
            }
        }

        #endregion
        #region Search

        private void menNextAliveHost_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                // Get all objects in the listview model.
                ScanObject current = lvResults.SelectedObject as ScanObject;
                List<ScanObject> alive = new List<ScanObject>();
                List<ScanObject> objects = new List<ScanObject>();
                foreach (ScanObject s in lvResults.Objects)
                {
                    // Add the object to the general list and to the online one if conditions are met.
                    objects.Add(s);
                    if (s.Online == "True") { alive.Add(s); }
                }

                // Check if we're at the end of the list.
                if (alive.Count == 0 || current == alive[alive.Count - 1])
                    MessageBox.Show("There are no more alive hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // Get our currently selected index.
                    int index = 0;
                    if (current != null)
                    {
                        for (int i = 0; i < objects.Count; i++)
                        {
                            if (objects[i] == current)
                                index = i;
                        }
                    }

                    // Select the next online host.
                    for (int i = index; i < objects.Count; i++)
                    {
                        if (objects[i] != current)
                        {
                            if (objects[i].Online == "True")
                            {
                                lvResults.SelectedObject = objects[i];
                                lvResults.EnsureModelVisible(objects[i]);

                                // Check if we set a null object.
                                if (lvResults.SelectedObject == null)
                                {
                                    lvResults.SelectedObject = objects[index];
                                    MessageBox.Show("There are no more alive hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            }

                            // There are no more online hosts to select.
                            if (i == objects.Count || i == objects.Count - 1)
                                MessageBox.Show("There are no more alive hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menNextDeadHost_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                // Get all objects in the listview model.
                ScanObject current = lvResults.SelectedObject as ScanObject;
                List<ScanObject> dead = new List<ScanObject>();
                List<ScanObject> objects = new List<ScanObject>();
                foreach (ScanObject s in lvResults.Objects)
                {
                    // Add the object to the general list and to the dead one if conditions are met.
                    objects.Add(s);
                    if (s.Online == "False") { dead.Add(s); }
                }

                // Check if we're at the end of the list.
                if (dead.Count == 0 || current == dead[dead.Count - 1])
                    MessageBox.Show("There are no more dead hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // Get our currently selected index.
                    int index = 0;
                    if (current != null)
                    {
                        for (int i = 0; i < objects.Count; i++)
                        {
                            if (objects[i] == current)
                                index = i;
                        }
                    }

                    // Select the next dead host.
                    for (int i = index; i < objects.Count; i++)
                    {
                        if (objects[i] != current)
                        {
                            if (objects[i].Online == "False")
                            {
                                lvResults.SelectedObject = objects[i];
                                lvResults.EnsureModelVisible(objects[i]);

                                // Check if we set a null object.
                                if (lvResults.SelectedObject == null)
                                {
                                    lvResults.SelectedObject = objects[index];
                                    MessageBox.Show("There are no more dead hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            }

                            // There are no more dead hosts to select.
                            if (i == objects.Count || i == objects.Count - 1)
                                MessageBox.Show("There are no more dead hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menNextOpenPort_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                // Nothing is supposed to be here.
                MessageBox.Show("There are no known open ports.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menPreviousAliveHost_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                // Get all objects in the listview model.
                ScanObject current = lvResults.SelectedObject as ScanObject;
                List<ScanObject> alive = new List<ScanObject>();
                List<ScanObject> objects = new List<ScanObject>();
                foreach (ScanObject s in lvResults.Objects)
                {
                    // Add the object to the general list and to the online one if conditions are met.
                    objects.Add(s);
                    if (s.Online == "True") { alive.Add(s); }
                }

                // Check if we're at the beginning of the list.
                if (alive.Count == 0 || current == alive[0])
                    MessageBox.Show("There are no more alive hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // Get our previously selected index.
                    int index = 0;
                    if (current != null)
                    {
                        for (int i = 0; i < objects.Count; i++)
                        {
                            if (objects[i] == current)
                                index = i;
                        }
                    }

                    // Select the previous online host.
                    for (int i = index; i >= 0; i--)
                    {
                        if (objects[i] != current)
                        {
                            if (objects[i].Online == "True")
                            {
                                lvResults.SelectedObject = objects[i];
                                lvResults.EnsureModelVisible(objects[i]);

                                // Check if we set a null object.
                                if (lvResults.SelectedObject == null)
                                {
                                    lvResults.SelectedObject = objects[index];
                                    MessageBox.Show("There are no more alive hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            }

                            // There are no more online hosts to select.
                            if (i == 0)
                                MessageBox.Show("There are no more alive hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menPreviousDeadHost_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                // Get all objects in the listview model.
                ScanObject current = lvResults.SelectedObject as ScanObject;
                List<ScanObject> dead = new List<ScanObject>();
                List<ScanObject> objects = new List<ScanObject>();
                foreach (ScanObject s in lvResults.Objects)
                {
                    // Add the object to the general list and to the dead one if conditions are met.
                    objects.Add(s);
                    if (s.Online == "False") { dead.Add(s); }
                }

                // Check if we're at the beginning of the list.
                if (dead.Count == 0 || current == dead[0])
                    MessageBox.Show("There are no more dead hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    // Get our previously selected index.
                    int index = 0;
                    if (current != null)
                    {
                        for (int i = 0; i < objects.Count; i++)
                        {
                            if (objects[i] == current)
                                index = i;
                        }
                    }

                    // Select the previous dead host.
                    for (int i = index; i >= 0; i--)
                    {
                        if (objects[i] != current)
                        {
                            if (objects[i].Online == "False")
                            {
                                lvResults.SelectedObject = objects[i];
                                lvResults.EnsureModelVisible(objects[i]);

                                // Check if we set a null object.
                                if (lvResults.SelectedObject == null)
                                {
                                    lvResults.SelectedObject = objects[index];
                                    MessageBox.Show("There are no more dead hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            }

                            // There are no more dead hosts to select.
                            if (i == 0)
                                MessageBox.Show("There are no more dead hosts.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menPreviousOpenPort_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                // Nothing is supposed to be here.
                MessageBox.Show("There are no known open ports.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void menFind_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                frmSearch search = new frmSearch(lvResults);
                search.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
        #region Favorites

        private void menFavorites_DropDownOpening(object sender, EventArgs e)
        {
            // Clear the favorites.
            List<object> items = new List<object>();
            for (int i = 0; i < 3; i++)
            {
                if (i >= 3)
                    break;
                else
                    items.Add(menFavorites.DropDownItems[i]);
            }
            menFavorites.DropDownItems.Clear();

            foreach (ToolStripItem t in items) { menFavorites.DropDownItems.Add(t); }
            if (SettingsManager.favorites.Count > 0)
            {
                menSep9.Visible = true;

                for (int i = 0; i < SettingsManager.favorites.Count; i++)
                {
                    bool containsElement = false;
                    string name = SettingsManager.favorites.ElementAt(i).Key;
                    string data = SettingsManager.favorites.ElementAt(i).Value;
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = name;
                    item.Tag = data;
                    item.Click += new EventHandler(Favorite_Click);
                    for (int x = 0; x < menFavorites.DropDownItems.Count; x++)
                    {
                        if (menFavorites.DropDownItems[x].Text == name)
                        {
                            if (isScanning) { menFavorites.DropDownItems[x].Enabled = false; }
                            else { menFavorites.DropDownItems[x].Enabled = true; }
                            containsElement = true;
                            break;
                        }
                    }

                    if (!containsElement)
                    {
                        if (isScanning) { item.Enabled = false; }
                        else { item.Enabled = true; }
                        menFavorites.DropDownItems.Add(item);
                    }
                }
            }
            else
                menSep9.Visible = false;
        }


        private void menAddCurrentScan_Click(object sender, EventArgs e)
        {
            Exception error = null;
            string favoriteName = "";
            string tagData = "";
            ScanType scanType = ScanType.Single;
            if (panSingleIP.Visible)
            {
                if (txtIP.Text == "")
                    error = new ApplicationException("You must specify an IP to favorite this scan.");
                else
                {
                    favoriteName = "Single: (" + txtIP.Text + ")";
                    tagData = txtIP.Text;
                    scanType = ScanType.Single;
                }
            }
            else if (panIPRange.Visible)
            {
                if (txtBeginningIP.Text == "" && txtEndingIP.Text == "")
                    error = new ApplicationException("You must specify a beginning and ending IP to favorite this scan.");
                else if (txtBeginningIP.Text == "")
                    error = new ApplicationException("You must specify a beginning IP to favorite this scan.");
                else if (txtEndingIP.Text == "")
                    error = new ApplicationException("You must specify an ending IP to favorite this scan.");
                else
                {
                    favoriteName = "Range: (" + txtBeginningIP.Text + " - " + txtEndingIP.Text + ")";
                    tagData = txtBeginningIP.Text + "|" + txtEndingIP.Text;
                    scanType = ScanType.Range;
                }
            }
            else if (panIPList.Visible)
            {
                if (txtFile.Text == "")
                    error = new ApplicationException("A file must be selected in order to favorite this scan.");
                else
                {
                    favoriteName = "List: " + Path.GetFileName(txtFile.Text);
                    tagData = txtFile.Text;
                    scanType = ScanType.List;
                }
            }

            if (error != null)
                MessageBox.Show(error.Message, "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                frmFavoriteName adding = new frmFavoriteName(favoriteName, tagData, scanType);
                adding.ShowDialog();
            }
        }

        private void menManageFavorites_Click(object sender, EventArgs e)
        {
            frmFavorites favorites = new frmFavorites();
            favorites.ShowDialog();
        }

        #endregion
        #region Settings

        private void menSettings_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.ShowDialog();
        }

        #endregion
        #region Help

        private void menViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no help documentation available at this time.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menVisitWebsite_Click(object sender, EventArgs e)
        {
            // Visit the project's website.
            Process.Start("https://www.github.com/antebyte/sharpscanner");
        }

        private void menAboutSharpScanner_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        #endregion

        #endregion
        #region ContextMenu

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
                    MessageBox.Show("There isn't a selected host with details to show.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conRescanSelected_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedObjects.Count > 0)
                {
                    // Reset each selected object.
                    List<IPAddress> rescans = new List<IPAddress>();
                    foreach (ScanObject so in lvResults.SelectedObjects)
                    {
                        so.Hostname = "";
                        so.MAC = "";
                        so.Ping = "";
                        so.Online = "";
                        so.Status = ScanStatus.Unknown;
                        rescans.Add(so.IP);
                        lvResults.UpdateObject(so);
                    }

                    // Begin scanning our selected IPs.
                    type = ScanType.Rescan;
                    Thread t = new Thread(() => BeginScanList(rescans)); t.Start();
                    LockControls();
                }
                else
                    MessageBox.Show("There aren't any selected hosts to rescan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("There are no hosts. Please run a scan.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void conDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lvResults.Items.Count > 0)
            {
                if (lvResults.SelectedObjects.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you would like to delete?", "Sharp Scanner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        lvResults.RemoveObjects(lvResults.SelectedObjects);
                }
                else
                    MessageBox.Show("There aren't any selected hosts to delete.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("There isn't a selected host with details to copy.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        #endregion

        #endregion
        #region Methods

        private void BeginScan(IPAddress ip)
        {
            isScanning = true;

            // Create a new stopwatch in order to track elapsed time.
            time = Stopwatch.StartNew();

            // Check if we should skip the address.
            string[] split = ip.ToString().Split('.');
            if (split[3] == "0" || split[3] == "255")
                if (SettingsManager.skipUnassaigned)
                {
                    isScanning = false;
                    time.Stop();
                    time.Reset();
                    UnlockControls();
                    MessageBox.Show("The input IP will not be scanned since it's skippable.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto SkipIP;
                }

            // Create a blank scan object and add it to our listview.
            ScanObject x = new ScanObject(ip, ip.ToString(), "", "", "", null, "");
            lvResults.AddObject(x);

            // Setup our scan object.
            Scanner s = new Scanner();
            s.ScanComplete += new ScanCompleteHandler(ScanComplete);
            s.ScanProgressChanged += new ScanProgressChangedHandler(ScanProgressChanged);
            
            // Start a new scan.
            Invoke(new Action(() => lblStatus.Text = "Starting scan for: " + ip.ToString()));
            Thread t = new Thread(() => s.Scan(ip.ToString()));
            t.Start();

            // Update our progressbar and thread count.
            total++;
            threads++;
            UpdateUI();

            SkipIP: { } // Don't scan the input IP.
        }

        private void BeginScanRange(IPAddressRange range)
        {
            isScanning = true;

            // Create a new stopwatch in order to track elapsed time.
            time = Stopwatch.StartNew();

            // Start a new thread for each address.
            foreach (IPAddress address in range) { total++; } // Get total amount of addresses.
            foreach (IPAddress address in range)
            {
                // Check if we should skip the address.
                bool skipPartial = false;
                string[] split = address.ToString().Split('.');
                if (split[3] == "0" || split[3] == "255")
                {
                    if (SettingsManager.skipUnassaigned)
                    {
                        if (total == 1)
                        {
                            isScanning = false;
                            total = 0;
                            time.Stop();
                            time.Reset();
                            UnlockControls();
                            MessageBox.Show("The input range will not be scanned since it's skippable.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            goto SkipIPComplete;
                        }

                        // Just skip the current IP and keep going.
                        skipPartial = true;
                        goto SkipIPPartial;
                    }
                }

                // Goto statement for lazy looping. // TODO: Change method of waiting for threads to clear.
                WaitForQueue: if (threads == SettingsManager.maxThreads) { goto WaitForQueue; }
                else
                {
                    // Add the address to the listview.
                    ScanObject x = new ScanObject(address, address.ToString(), "", "", "", null, "");
                    lvResults.AddObject(x);

                    // Setup our scanner object.
                    Scanner s = new Scanner();
                    s.ScanComplete += new ScanCompleteHandler(ScanComplete);

                    // Start a new scan.
                    Invoke(new Action(() => lblStatus.Text = "Starting scan for: " + address.ToString()));
                    Thread t = new Thread(() => s.Scan(address.ToString()));
                    t.Start();

                    // Update our status.
                    threads++;
                    UpdateUI();
                }

                // Let the thread sleep if specified.
                if (SettingsManager.threadDelay > 0) { Thread.Sleep(SettingsManager.threadDelay); }

                // Since the address is skippable decrement from the total and update the UI.
                SkipIPPartial: { if (skipPartial) { total--; UpdateUI(); } }
            }

            // Wait for all threads to terminate.
            if (threads > 0)
                Invoke(new Action(() => lblStatus.Text = "Waiting for all threads to terminate..."));

            // Don't start the scan at all.
            SkipIPComplete:;
        }

        private void BeginScanList(List<IPAddress> range)
        {
            isScanning = true;

            // Create a new stopwatch in order to track elapsed time.
            time = Stopwatch.StartNew();

            // Start a new thread for each address.
            total = range.Count; // Get total amount of addresses.
            foreach (IPAddress address in range)
            {
                // Goto statement for lazy looping. // TODO: Change method of waiting for threads to clear.
                WaitForQueue: if (threads == SettingsManager.maxThreads) { goto WaitForQueue; }
                else
                {
                    // Add the address to the listview.
                    bool containsAddress = false;
                    ScanObject x = new ScanObject(address, address.ToString(), "", "", "", null, "");
                    if (lvResults.Items.Count > 0)
                    {
                        foreach (ScanObject y in lvResults.Objects)
                            if (x.IP == y.IP) { containsAddress = true; }
                    }
                    if (!containsAddress) { lvResults.AddObject(x); }

                    // Setup our scanner object.
                    Scanner s = new Scanner();
                    s.ScanComplete += new ScanCompleteHandler(ScanComplete);

                    // Start a new scan.
                    Invoke(new Action(() => lblStatus.Text = "Starting scan for: " + address.ToString()));
                    Thread t = new Thread(() => s.Scan(address.ToString()));
                    t.Start();

                    // Update our status.
                    threads++;
                    UpdateUI();
                }

                // Let the thread sleep if specified.
                if (SettingsManager.threadDelay > 0) { Thread.Sleep(SettingsManager.threadDelay); }
            }

            // Wait for all threads to terminate.
            if (threads > 0)
                Invoke(new Action(() => lblStatus.Text = "Waiting for all threads to terminate..."));
        }

        private void ScanProgressChanged(object sender, ScanProgressChangedEventArgs e)
        {
            Invoke(new Action(() => pbMain.Value = e.Progress));
        }

        private void ScanComplete(object sender, ScanCompleteEventArgs e)
        {
            try
            {
                // Get some statistics.
                average += e.Result.Elapsed;
                if (e.Result.isOnline) { online++; }
                if (e.Result.Ports != null)
                    if (e.Result.Ports.Services.Count > 0) { open++; }

                ScanObject x = new ScanObject(e.Result.IP, e.Result.Address, e.Result.Hostname, e.Result.MAC,
                                              e.Result.Ping.ToString() + " ms", e.Result.Ports, e.Result.isOnline.ToString());
                //lvResults.AddObject(x);

                // Update our scan results in our listview.
                foreach (ScanObject s in lvResults.Objects)
                {
                    string expected = s.IP.ToString();
                    string actual = e.Result.IP.ToString();
                     
                    if (actual == expected)
                    {
                        s.Hostname = e.Result.Hostname;
                        s.MAC = e.Result.MAC;
                        s.Ping = e.Result.Ping + " ms";
                        s.Online = e.Result.isOnline.ToString();
                        if (e.Result.isOnline) { s.Status = ScanStatus.Alive; }
                        else { s.Status = ScanStatus.Dead; }
                        lvResults.RefreshObject(s);
                        break;
                    }
                }


                // Make sure our updates are reflected.
                threads--;
                complete++;
                UpdateUI();
            }
            catch (ObjectDisposedException) { } // The form has closed.
        }

        private void UpdateUI()
        {
            // Update our thread count.
            if (threads == SettingsManager.maxThreads)
            {
                Invoke(new Action(() => lblThreadCount.ForeColor = Color.Red));
                Invoke(new Action(() => lblThreadCount.Text = threads.ToString() + " (Max)"));
            }
            else
            {
                Invoke(new Action(() => lblThreadCount.ForeColor = Color.Black));
                Invoke(new Action(() => lblThreadCount.Text = threads.ToString()));
            }

            // Update our progress.
            progress = (int)(((double)complete / (double)total) * 100);
            if (progress == 100)
            {
                isScanning = false;

                // Get our stats.
                time.Stop();
                double x =  Math.Round(time.Elapsed.TotalSeconds, 2);
                double y = Math.Round((average / total), 1);
                int a = total;
                int b = online;
                int c = open;

                // Reset everything.
                time.Reset();
                average = 0;
                progress = 0;
                complete = 0;
                total = 0;
                online = 0;
                open = 0;

                // Create a stats object even if we don't use it.
                string scanType = "";
                switch (type)
                {
                    case ScanType.Single:
                        scanType = "(Single) " + txtIP.Text;
                        break;
                    case ScanType.Range:
                        scanType = "(IP Range) " + txtBeginningIP.Text + " - " + txtEndingIP.Text;
                        break;
                    case ScanType.List:
                        scanType = "(IP List) " + a.ToString();
                        break;
                    case ScanType.Rescan:
                        scanType = "(Rescan) " + a.ToString();
                        break;
                }
                string totalTime = x.ToString() + " sec";
                string averageTime = y.ToString() + " sec";
                string totalHosts = a.ToString();
                string onlineHosts = b.ToString();
                string openHosts = c.ToString();
                stats = new StatsObject(scanType, totalTime, averageTime, totalHosts, onlineHosts, openHosts);
                
                // Update our form.
                Invoke(new Action(() => Text = "Sharp Scanner"));
                Invoke(new Action(() => lblStatus.Text = "Idle"));
                Invoke(new Action(() => pbMain.Value = 0));
                UnlockControls();
                Invoke(new Action(() => lvResults.RebuildColumns()));
                if (lvResults.Items.Count == 0)
                    Invoke(new Action(() => lvResults.View = View.SmallIcon));
                else
                    Invoke(new Action(() => lvResults.View = View.Details));

                // Show a scan statistics dialog if specified.
                if (SettingsManager.showStatisticsDialog)
                {
                    if (!isScanning)
                    {
                        if (!isStatsShowing)
                        {
                            isStatsShowing = true;
                            frmStatistics statistics = new frmStatistics(stats.ScanType, stats.TotalTime, stats.AverageTime,
                                                                         stats.TotalHosts, stats.OnlineHosts, stats.OpenHosts);
                            if (statistics.ShowDialog() == DialogResult.OK)
                                isStatsShowing = false;
                        }
                    }
                }

            }
            else
            {
                if (progress >= 0)
                {
                    Invoke(new Action(() => Text = "Sharp Scanner - " + progress.ToString() + "%"));
                    Invoke(new Action(() => pbMain.Value = progress));
                }
            }
        }

        private List<IPAddress> ParseList(string list)
        {
            // Create an empty collection of IPs.
            List<IPAddress> ips = new List<IPAddress>();

            try
            {
                // Get the contents of the provided file.
                string content = null;
                using (StreamReader reader = new StreamReader(list))
                {
                    content = reader.ReadToEnd();
                }

                // Parse the contents into individual IPs.
                MatchCollection matches = Regex.Matches(content, @"\b(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\b");
                if (matches.Count > 0)
                {
                    // Populate our collection if we have matches.
                    foreach (Match match in matches)
                    {
                        string address = match.Captures[0].Value;
                        IPAddress ip = IPAddress.Parse(address);
                        bool containsIP = false;
                        foreach (IPAddress x in ips)
                        {
                            if (ip.ToString() == x.ToString())
                                containsIP = true;
                        }

                        // Check if we should skip the address.
                        string[] split = address.ToString().Split('.');
                        if (split[3] == "0" || split[3] == "255")
                        {
                            if (!SettingsManager.skipUnassaigned)
                                if (!containsIP)
                                    ips.Add(ip);
                        }
                        else
                        {
                            if (!containsIP)
                                ips.Add(ip);
                        }
                    }
                }
                else { throw new ApplicationException("No IPs could be found in the file."); }

                // Check if we have any ips at all; useful if we have a list of addresses containing *.0 and *.255.
                if (ips.Count == 0) { throw new ApplicationException("No IPs could be found in the file."); }
            }
            catch (ApplicationException ex) { throw new Exception(ex.Message.ToString()); }
            catch { throw new Exception("The provided file could not read."); }

            return ips;
        }

        private void LockControls()
        {
            Invoke(new Action(() => txtIP.Enabled = false));
            Invoke(new Action(() => txtBeginningIP.Enabled = false));
            Invoke(new Action(() => txtEndingIP.Enabled = false));
            Invoke(new Action(() => txtFile.Enabled = false));
            Invoke(new Action(() => cmbScan.Enabled = false));
            Invoke(new Action(() => cmbScanRange.Enabled = false));
            Invoke(new Action(() => cmbScanList.Enabled = false));
            Invoke(new Action(() => btnScan.Enabled = false));
            Invoke(new Action(() => btnScanRange.Enabled = false));
            Invoke(new Action(() => btnScanList.Enabled = false));
            Invoke(new Action(() => btnBrowseList.Enabled = false));
            Invoke(new Action(() => menRescanSelected.Enabled = false));
            Invoke(new Action(() => menDeleteSelected.Enabled = false));
            Invoke(new Action(() => menImportScan.Enabled = false));
        }

        private void UnlockControls()
        {
            Invoke(new Action(() => txtIP.Enabled = true));
            Invoke(new Action(() => txtBeginningIP.Enabled = true));
            Invoke(new Action(() => txtEndingIP.Enabled = true));
            Invoke(new Action(() => txtFile.Enabled = true));
            Invoke(new Action(() => cmbScan.Enabled = true));
            Invoke(new Action(() => cmbScanRange.Enabled = true));
            Invoke(new Action(() => cmbScanList.Enabled = true));
            Invoke(new Action(() => btnScan.Enabled = true));
            Invoke(new Action(() => btnScanRange.Enabled = true));
            Invoke(new Action(() => btnScanList.Enabled = true));
            Invoke(new Action(() => btnBrowseList.Enabled = true));
            Invoke(new Action(() => menRescanSelected.Enabled = true));
            Invoke(new Action(() => menDeleteSelected.Enabled = true));
            Invoke(new Action(() => menImportScan.Enabled = true));
        }

        private void ImportResults(string file)
        {
            if (File.Exists(file))
            {
                try
                {
                    // Create a list of objects to update the list with.
                    List<ScanObject> objects = new List<ScanObject>();

                    // Create a node to obtain our settings from.
                    XDocument doc = XDocument.Load(file);

                    // Get our values from our XML file.
                    var data = from item in doc.Descendants("result")
                               select new
                               {
                                   ip = item.TryGetElementValue("IP"),
                                   hostname = item.TryGetElementValue("Hostname"),
                                   mac = item.TryGetElementValue("MAC"),
                                   ping = item.TryGetElementValue("Ping"),
                                   online = item.TryGetElementValue("Online"),
                                   comments = item.TryGetElementValue("Comments"),
                               };

                    // Set each XML node to their corresponding variable.
                    foreach (var item in data)
                    {
                        string ip = item.ip;
                        string hostname = item.hostname;
                        string mac = item.mac;
                        string ping = item.ping;
                        string online = item.online;
                        IPAddress address = IPAddress.Parse(ip);
                        ScanStatus status = ScanStatus.Unknown;
                        if (online == "True") { status = ScanStatus.Alive; }
                        else { status = ScanStatus.Dead; }
                        ScanObject so = new ScanObject(address, ip, hostname, mac, ping, null, online, status);
                        so.Comments = item.comments;
                        objects.Add(so);
                    }

                    // Update the list with our objects.
                    lvResults.AddObjects(objects);
                }
                catch (Exception) { MessageBox.Show("Sharp Scanner is unable to import this file.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void Favorite_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem x = sender as ToolStripMenuItem;

            try
            {
                string[] split = x.Tag.ToString().Split('|');
                ScanType type;
                Enum.TryParse(split[0], out type);
                switch (type)
                {
                    case ScanType.Single:
                        if (panSingleIP.Visible)
                        {
                            txtIP.Text = split[1];
                            btnScan.PerformClick();
                        }
                        else if (panIPRange.Visible)
                        {
                            cmbScanRange.SelectedIndex = 0;
                            txtIP.Text = split[1];
                            btnScan.PerformClick();
                        }
                        else if (panIPList.Visible)
                        {
                            cmbScanList.SelectedIndex = 0;
                            txtIP.Text = split[1];
                            btnScan.PerformClick();
                        }
                        break;
                    case ScanType.Range:
                        if (panSingleIP.Visible)
                        {
                            cmbScan.SelectedIndex = 1;
                            txtBeginningIP.Text = split[1];
                            txtEndingIP.Text = split[2];
                            btnScanRange.PerformClick();
                        }
                        else if (panIPRange.Visible)
                        {
                            txtBeginningIP.Text = split[1];
                            txtEndingIP.Text = split[2];
                            btnScanRange.PerformClick();
                        }
                        else if (panIPList.Visible)
                        {
                            cmbScanList.SelectedIndex = 1;
                            txtBeginningIP.Text = split[1];
                            txtEndingIP.Text = split[2];
                            btnScanRange.PerformClick();
                        }
                        break;
                    case ScanType.List:
                        if (panSingleIP.Visible)
                        {
                            cmbScan.SelectedIndex = 2;
                            txtFile.Text = split[1];
                            btnScanList.PerformClick();
                        }
                        else if (panIPRange.Visible)
                        {
                            cmbScanRange.SelectedIndex = 2;
                            txtFile.Text = split[1];
                            btnScanList.PerformClick();
                        }
                        else if (panIPList.Visible)
                        {
                            txtFile.Text = split[1];
                            btnScanList.PerformClick();
                        }
                        break;
                }
            }
            catch { MessageBox.Show("The selected favorite couldn't be run due to corruption.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion
    }
}
