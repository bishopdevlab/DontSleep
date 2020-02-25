// Copyright Bishop(LEE YONG IL). All rights reserved.
// Licensed under the Apache license.
// See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Don_tSleep
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // auto start
            AutoStart();

            // operation
            var operation = string.Empty;
            if (PreventScreenSaver.Checked) operation = "PreventScreenSaver";
            else if (PreventSleep.Checked) operation = "PreventSleep";
            else if (PreventScreenSaverAndSleep.Checked) operation = "PreventScreenSaverAndSleep";
            else if (AllowScreenSaverAndSleep.Checked) operation = "AllowScreenSaverAndSleep";

            SelectOperation(operation);

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void checkBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart();
        }

        private void PowerSaver_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = (sender as RadioButton);

            if (selectedRadioButton.Checked == true)
            {
                SelectOperation(selectedRadioButton.Name);
            }
        }
        
        private void AutoStart()
        {
            if (checkBoxAutoStart.Checked)
            {
                var exePath = Environment.GetCommandLineArgs()[0];
                var AppName = Process.GetCurrentProcess().ProcessName;
                RegistryHelper.RegistryAutoStart(AppName, exePath);
            }
            else
            {
                var AppName = Process.GetCurrentProcess().ProcessName;
                RegistryHelper.UnRegistryAutoStart(AppName);
            }
        }

        private void SelectOperation(string operation)
        {
            switch (operation)
            {
                case "PreventScreenSaver":
                    NativeMethods.PreventScreenSaver();
                    break;
                case "PreventSleep":
                    NativeMethods.PreventSleep();
                    break;
                case "PreventScreenSaverAndSleep":
                    NativeMethods.PreventScreenSaverAndSleep();
                    break;
                case "AllowScreenSaverAndSleep":
                    NativeMethods.AllowScreenSaverAndSleep();
                    break;
                default:
                    break;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
            else
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
        }
    }
}
