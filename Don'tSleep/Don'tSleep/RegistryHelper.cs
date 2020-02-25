// Copyright LEE YONG IL. All rights reserved.
// Licensed under the Apache license.
// See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;

namespace Don_tSleep
{
    public static class RegistryHelper
    {
        private const string AUTORUN_REGISTRY_PATH = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        public static string GetRegistry(string _strSubKey, string _strKey)
        {
            string strValue = "";
            try
            {
                RegistryKey rkRoot = Registry.LocalMachine;
                RegistryKey rkSubKey = rkRoot.OpenSubKey(_strSubKey, true);

                if (rkSubKey != null)
                    strValue = Convert.ToString(rkSubKey.GetValue(_strKey));

                rkSubKey.Close();
                rkRoot.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return strValue;
        }

        public static bool SetRegistry(string _strSubKey, string _strKey, string _strValue)
        {
            try
            {
                RegistryKey rkRoot = Registry.LocalMachine;
                RegistryKey rkSubKey = rkRoot.OpenSubKey(_strSubKey, true);
                if (rkSubKey == null)
                {
                    rkSubKey = rkRoot.CreateSubKey(_strSubKey);
                }

                rkSubKey.SetValue(_strKey, _strValue, RegistryValueKind.String);

                rkSubKey.Close();
                rkRoot.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public static bool DeleteRegistry(string _strSubKey, string _strKey)
        {
            try
            {
                RegistryKey rkRoot = Registry.LocalMachine;
                RegistryKey rkSubKey = rkRoot.OpenSubKey(_strSubKey, true);
                rkSubKey.DeleteValue(_strKey);

                rkSubKey.Close();
                rkRoot.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public static bool RegistryAutoStart(string _strKey, string _strValue)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(AUTORUN_REGISTRY_PATH, true);
                registryKey.SetValue(_strKey, _strValue);
                registryKey.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public static bool UnRegistryAutoStart(string _strKey)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(AUTORUN_REGISTRY_PATH, true);
                registryKey.DeleteValue(_strKey);
                registryKey.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}
