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
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion
namespace SharpScanner
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            numMaxThreads.Value = SettingsManager.maxThreads;
            numThreadCreationDelay.Value = SettingsManager.threadDelay;
            numPingProbes.Value = SettingsManager.pingProbes;
            numPingTimeout.Value = SettingsManager.pingTimeout;
            chkSkipUnassignedAddresses.Checked = SettingsManager.skipUnassaigned;
            chkAskForConfirmation.Checked = SettingsManager.askForConfirmation;
            chkDisplayStatisticsDialog.Checked = SettingsManager.showStatisticsDialog;
        }

        private void btnGeneralOK_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnGeneralClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save()
        {
            SettingsManager.maxThreads = Convert.ToInt32(numMaxThreads.Value);
            SettingsManager.threadDelay = Convert.ToInt32(numThreadCreationDelay.Value);
            SettingsManager.pingProbes = Convert.ToInt32(numPingProbes.Value);
            SettingsManager.pingTimeout = Convert.ToInt32(numPingTimeout.Value);
            SettingsManager.skipUnassaigned = chkSkipUnassignedAddresses.Checked;
            SettingsManager.askForConfirmation = chkAskForConfirmation.Checked;
            SettingsManager.showStatisticsDialog = chkDisplayStatisticsDialog.Checked;
            SettingsManager.SaveSettings();
        }
    }
}
