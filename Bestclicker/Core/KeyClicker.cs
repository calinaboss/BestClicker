using AutoClicker.Utils;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker.Core
{
    internal static class KeyClicker
    {
        public static void PressKey(Keys key)
        {
            NativeMethods.INPUT[] inputs = new NativeMethods.INPUT[2];

            inputs[0] = new NativeMethods.INPUT
            {
                type = NativeMethods.INPUT_KEYBOARD,
                U = new NativeMethods.InputUnion
                {
                    ki = new NativeMethods.KEYBDINPUT
                    {
                        wVk = (ushort)key,
                        wScan = 0,
                        dwFlags = NativeMethods.KEYEVENTF_KEYDOWN,
                        time = 0,
                        dwExtraInfo = NativeMethods.GetMessageExtraInfo()
                    }
                }
            };

            inputs[1] = new NativeMethods.INPUT
            {
                type = NativeMethods.INPUT_KEYBOARD,
                U = new NativeMethods.InputUnion
                {
                    ki = new NativeMethods.KEYBDINPUT
                    {
                        wVk = (ushort)key,
                        wScan = 0,
                        dwFlags = NativeMethods.KEYEVENTF_KEYUP,
                        time = 0,
                        dwExtraInfo = NativeMethods.GetMessageExtraInfo()
                    }
                }
            };

            NativeMethods.SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(NativeMethods.INPUT)));
        }
    }
}