using AutoClicker.Utils;
using System;
using System.Windows.Forms;

namespace AutoClicker.Core
{
    internal class HotkeyManager : IDisposable
    {
        private readonly IntPtr _hWnd;
        private int _hotkeyId = -1;
        private bool _disposed = false;

        public event EventHandler? HotkeyPressed;

        public HotkeyManager(IntPtr hWnd)
        {
            _hWnd = hWnd;
        }

        public bool Register(Keys key, int id = 1)
        {
            if (_hotkeyId >= 0)
                Unregister();

            bool result = NativeMethods.RegisterHotKey(_hWnd, id, NativeMethods.MOD_NONE, (uint)key);
            if (result)
                _hotkeyId = id;
            return result;
        }

        public void Unregister()
        {
            if (_hotkeyId >= 0)
            {
                NativeMethods.UnregisterHotKey(_hWnd, _hotkeyId);
                _hotkeyId = -1;
            }
        }

        public void ProcessMessage(Message m)
        {
            if (m.Msg == NativeMethods.WM_HOTKEY && m.WParam.ToInt32() == _hotkeyId)
                HotkeyPressed?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                Unregister();
                _disposed = true;
            }
        }
    }
}