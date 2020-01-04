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

#region Imports

using System;
using System.Xml;
using System.IO;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Xml.Linq;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.AccessControl;

#endregion
namespace SharpScanner
{
    static class SettingsManager
    {
        #region Variables

        internal static int maxThreads = 100;
        internal static int threadDelay = 0;
        internal static int pingProbes = 3;
        internal static int pingTimeout = 1000;
        internal static bool skipUnassaigned = true;
        internal static bool askForConfirmation = true;
        internal static bool showStatisticsDialog = true;
        internal static Fetchers fetchers = new Fetchers(true, true, true, true);
        internal static Dictionary<string, string> favorites = new Dictionary<string, string>();
        internal static string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Sharp Scanner\settings.xml";

        #endregion
        #region Methods

        internal static void SaveSettings()
        {
            // Check if the save path exists and create it if it doesn't.
            if (!Directory.Exists(Path.GetDirectoryName(settingsPath))) { Directory.CreateDirectory(Path.GetDirectoryName(settingsPath)); }

            // Save our settings file.
            XDocument doc = SettingsData();
            doc.Save(settingsPath);
        }

        internal static void LoadSettings()
        {
            // Check if a settings file exists.
            if (File.Exists(settingsPath))
            {
                try
                {
                    // Create a list of objects to update the list with.
                    List<ScanObject> objects = new List<ScanObject>();

                    // Create a node to obtain our settings from.
                    XDocument doc = XDocument.Load(settingsPath);

                    // Get the values for settings.
                    var data = from item in doc.Descendants("settings")
                               select new
                               {
                                   threads = item.TryGetElementValue("MaxThreads"),
                                   delay = item.TryGetElementValue("ThreadDelay"),
                                   probes = item.TryGetElementValue("PingProbes"),
                                   timeout = item.TryGetElementValue("PingTimeout"),
                                   skip = item.TryGetElementValue("SkipUnassigned"),
                                   ask = item.TryGetElementValue("AskForConfirmation"),
                                   show = item.TryGetElementValue("ShowStatisticsDialog"),
                                   f = item.TryGetElementValue("Fetchers")
                               };

                    // Set our settings to our xml values.
                    foreach (var item in data)
                    {
                        int.TryParse(item.threads, out maxThreads);
                        int.TryParse(item.delay, out threadDelay);
                        int.TryParse(item.probes, out pingProbes);
                        int.TryParse(item.timeout, out pingTimeout);
                        bool.TryParse(item.skip, out skipUnassaigned);
                        bool.TryParse(item.ask, out askForConfirmation);
                        bool.TryParse(item.show, out showStatisticsDialog);
                        bool hostname = true, mac = true, ping = true, online = true;
                        try
                        {
                            string[] split = item.f.Split('|');
                            if (split[0] == "False") { hostname = false; }
                            if (split[1] == "False") { mac = false; }
                            if (split[2] == "False") { ping = false; }
                            if (split[3] == "False") { online = false; }
                        }
                        catch { } // Let the default fetchers roll.
                        fetchers = new Fetchers(hostname, mac, ping, online);
                    }

                    // Get values for favorites.
                    var favs = from item in doc.Descendants("favorite")
                               select new
                               {
                                   name = item.TryGetElementValue("Name"),
                                   data = item.TryGetElementValue("Data")
                               };

                    // Setup a new dictionary.
                    foreach (var item in favs)
                    {
                        if (item.name != null && item.data != null)
                            favorites.Add(item.name, item.data);
                    }
                }
                catch (Exception) { MessageBox.Show("Sharp Scanner couldn't load settings due to file corruption.", "Sharp Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private static XDocument SettingsData()
        {
            // Create the root node.
            XElement root = new XElement("SharpScanner");

            // Create nodes for settings.
            XElement row = new XElement("settings");
            XElement col = new XElement("MaxThreads", maxThreads.ToString());
            row.Add(col);
            col = new XElement("ThreadDelay", threadDelay.ToString());
            row.Add(col);
            col = new XElement("PingProbes", pingProbes.ToString());
            row.Add(col);
            col = new XElement("PingTimeout", pingTimeout.ToString());
            row.Add(col);
            col = new XElement("SkipUnassigned", skipUnassaigned.ToString());
            row.Add(col);
            col = new XElement("AskForConfirmation", askForConfirmation.ToString());
            row.Add(col);
            col = new XElement("ShowStatisticsDialog", showStatisticsDialog.ToString());
            row.Add(col);
            col = new XElement("Fetchers", fetchers.Hostname + "|" +
                                           fetchers.MAC + "|" +
                                           fetchers.Ping + "|" +
                                           fetchers.Online);
            row.Add(col);
            root.Add(row);

            // Create nodes for favorites.
            row = new XElement("favorites");
            for (int i = 0; i < favorites.Count; i++)
            {
                XElement newRow = new XElement("favorite");
                row.Add(newRow);
                col = new XElement("Name", favorites.ElementAt(i).Key);
                newRow.Add(col);
                col = new XElement("Data", favorites.ElementAt(i).Value);
                newRow.Add(col);
            }
            root.Add(row);

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Generated by Sharp Scanner 1.0.0"),
                new XComment("Website: https://github.com/CloneMerge/sharpscanner"),
                root);

            return doc;
        }

        #endregion
    }
}
