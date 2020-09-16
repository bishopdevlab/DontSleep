// Copyright Bishop(LEE YONG IL). All rights reserved.
// Licensed under the Apache license.
// See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace Don_tSleep
{
    public static class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern long SetCursorPos(int x, int y);

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        public static void PreventScreenSaver()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
        }

        public static void PreventSleep()
        {
            // Prevent Idle-to-Sleep (monitor not affected) (see note above)
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
        }

        public static void PreventScreenSaverAndSleep()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS |
                                    EXECUTION_STATE.ES_SYSTEM_REQUIRED |
                                    EXECUTION_STATE.ES_AWAYMODE_REQUIRED |
                                    EXECUTION_STATE.ES_DISPLAY_REQUIRED);
        }

        public static void AllowScreenSaverAndSleep()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
        }

        public static void KeepSystemAwake()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED);
        }
    }
}