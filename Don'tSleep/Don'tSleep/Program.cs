// Copyright Bishop(LEE YONG IL). All rights reserved.
// Licensed under the Apache license.
// See LICENSE file in the project root for full license information.

using System;
using System.Windows.Forms;

namespace Don_tSleep
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}