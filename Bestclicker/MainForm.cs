using AutoClicker.Core;
using AutoClicker.Utils;
using System;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        private readonly ClickScheduler _scheduler = new ClickScheduler();
        private HotkeyManager? _hotkeyManager;
        private bool _isRunning = false;

       public MainForm()
{
    InitializeComponent();
    PopulateKeyComboBox();
    
    _hotkeyManager = new HotkeyManager(this.Handle);
    _hotkeyManager.HotkeyPressed += OnHotkeyPressed; // Questo ti conviene lasciarlo qui
    ApplyHotkey();

    
    this.FormClosing += MainForm_FormClosing; 
}

        private void PopulateKeyComboBox()
        {
            cmbKey.Items.Clear();
            foreach (Keys k in Enum.GetValues(typeof(Keys)))
            {
                string name = k.ToString();
                if (!cmbKey.Items.Contains(name))
                    cmbKey.Items.Add(name);
            }
            cmbKey.SelectedItem = Keys.Space.ToString();
            if (cmbKey.SelectedIndex < 0 && cmbKey.Items.Count > 0)
                cmbKey.SelectedIndex = 0;
        }

        private void OnModeChanged(object? sender, EventArgs e)
        {
            bool isMouse = rbMouse.Checked;
            panelMouseOptions.Visible = isMouse;
            panelKeyOptions.Visible = !isMouse;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartClicking();
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            StopClicking();
        }

        private void BtnApplyHotkey_Click(object? sender, EventArgs e)
        {
            ApplyHotkey();
        }

        private void OnHotkeyPressed(object? sender, EventArgs e)
        {
            if (_isRunning)
                StopClicking();
            else
                StartClicking();
        }

        private void StartClicking()
        {
            if (_isRunning) return;

            int intervalMs = TimeConverter.ToMilliseconds(nudInterval.Value, cmbUnit.SelectedItem?.ToString() ?? "ms");
            if (intervalMs < 1) intervalMs = 1;

            if (rbMouse.Checked)
            {
                bool leftClick = rbLeftClick.Checked;
                _scheduler.Start(intervalMs, () => MouseClicker.Click(leftClick));
            }
            else
            {
                if (cmbKey.SelectedItem == null) return;
                if (!Enum.TryParse<Keys>(cmbKey.SelectedItem.ToString(), out Keys selectedKey)) return;
                _scheduler.Start(intervalMs, () => KeyClicker.PressKey(selectedKey));
            }

            _isRunning = true;
            UpdateUI();
        }

        private void StopClicking()
        {
            _scheduler.Stop();
            _isRunning = false;
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateUI));
                return;
            }

            btnStart.Enabled = !_isRunning;
            btnStop.Enabled = _isRunning;

            if (_isRunning)
            {
                lblStatus.Text = "Running";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(80, 240, 130);
                lblStatusDot.ForeColor = System.Drawing.Color.FromArgb(80, 240, 130);
                btnStart.BackColor = System.Drawing.Color.FromArgb(14, 60, 30);
                btnStart.ForeColor = System.Drawing.Color.FromArgb(60, 160, 90);
                btnStop.BackColor = System.Drawing.Color.FromArgb(90, 20, 20);
                btnStop.ForeColor = System.Drawing.Color.FromArgb(255, 90, 90);
            }
            else
            {
                lblStatus.Text = "Stopped";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(240, 100, 80);
                lblStatusDot.ForeColor = System.Drawing.Color.FromArgb(240, 100, 80);
                btnStart.BackColor = System.Drawing.Color.FromArgb(20, 90, 50);
                btnStart.ForeColor = System.Drawing.Color.FromArgb(80, 240, 130);
                btnStop.BackColor = System.Drawing.Color.FromArgb(80, 20, 20);
                btnStop.ForeColor = System.Drawing.Color.FromArgb(240, 80, 80);
            }
        }

        private void ApplyHotkey()
        {
            if (_hotkeyManager == null) return;

            string? selected = cmbHotkey.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            if (!Enum.TryParse<Keys>(selected, out Keys hotkeyKey)) return;

            _hotkeyManager.Unregister();
            bool ok = _hotkeyManager.Register(hotkeyKey, 9001);

            if (!ok)
                MessageBox.Show($"Impossibile registrare la hotkey {selected}. Potrebbe essere già in uso da un altro programma.", "Hotkey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected override void WndProc(ref Message m)
        {
            _hotkeyManager?.ProcessMessage(m);
            base.WndProc(ref m);
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _scheduler.Dispose();
            _hotkeyManager?.Dispose();
        }
    }
}