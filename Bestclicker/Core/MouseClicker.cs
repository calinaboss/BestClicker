using AutoClicker.Utils;
using System;

namespace AutoClicker.Core
{
    internal static class MouseClicker
    {
        public static void Click(bool leftButton)
        {
            NativeMethods.INPUT[] inputs = new NativeMethods.INPUT[2];

            uint downFlag = leftButton ? NativeMethods.MOUSEEVENTF_LEFTDOWN : NativeMethods.MOUSEEVENTF_RIGHTDOWN;
            uint upFlag = leftButton ? NativeMethods.MOUSEEVENTF_LEFTUP : NativeMethods.MOUSEEVENTF_RIGHTUP;

            inputs[0] = new NativeMethods.INPUT
            {
                type = NativeMethods.INPUT_MOUSE,
                U = new NativeMethods.InputUnion
                {
                    mi = new NativeMethods.MOUSEINPUT
                    {
                        dx = 0,
                        dy = 0,
                        mouseData = 0,
                        dwFlags = downFlag,
                        time = 0,
                        dwExtraInfo = NativeMethods.GetMessageExtraInfo()
                    }
                }
            };

            inputs[1] = new NativeMethods.INPUT
            {
                type = NativeMethods.INPUT_MOUSE,
                U = new NativeMethods.InputUnion
                {
                    mi = new NativeMethods.MOUSEINPUT
                    {
                        dx = 0,
                        dy = 0,
                        mouseData = 0,
                        dwFlags = upFlag,
                        time = 0,
                        dwExtraInfo = NativeMethods.GetMessageExtraInfo()
                    }
                }
            };

            NativeMethods.SendInput((uint)inputs.Length, inputs, System.Runtime.InteropServices.Marshal.SizeOf(typeof(NativeMethods.INPUT)));
        }
    }
}