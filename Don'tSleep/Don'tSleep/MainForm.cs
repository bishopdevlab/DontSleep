// Copyright Bishop(LEE YONG IL). All rights reserved.
// Licensed under the Apache license.
// See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Don_tSleep
{
    public partial class MainForm : Form
    {
        private Timer myTimer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoStart();
            CreateTimer();
            SetOperation();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        #region Auto Start

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

        private void checkBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart();
        }

        #endregion Auto Start

        #region Tray Icon

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

        #endregion Tray Icon

        #region Operation

        private void SetOperation()
        {
            var operation = string.Empty;
            if (PreventScreenSaver.Checked) operation = "PreventScreenSaver";
            else if (PreventSleep.Checked) operation = "PreventSleep";
            else if (PreventScreenSaverAndSleep.Checked) operation = "PreventScreenSaverAndSleep";
            else if (AllowScreenSaverAndSleep.Checked) operation = "AllowScreenSaverAndSleep";

            SelectOperation(operation);
        }

        private void PowerSaver_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = (sender as RadioButton);

            if (selectedRadioButton.Checked == true)
            {
                SelectOperation(selectedRadioButton.Name);
            }
        }

        private void SelectOperation(string operation)
        {
            checkBoxMoveMouse.Enabled = true;
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
                    checkBoxMoveMouse.Enabled = false;
                    break;

                default:
                    break;
            }
        }

        #endregion Operation

        #region Move Mouse Automatically

        private void CreateTimer()
        {
            myTimer = new Timer();
            myTimer.Enabled = false;
            myTimer.Interval = 5000;
            myTimer.Tick += Timer_Tick;
        }

        private void checkBoxMoveMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMoveMouse.Checked)
            {
                if (!myTimer.Enabled)
                    myTimer.Start();
            }
            else
            {
                if (myTimer.Enabled)
                    myTimer.Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NativeMethods.SetCursorPos(Cursor.Position.X + 10, Cursor.Position.Y);
            NativeMethods.SetCursorPos(Cursor.Position.X - 10, Cursor.Position.Y);
        }

        #endregion Move Mouse Automatically
    }
}