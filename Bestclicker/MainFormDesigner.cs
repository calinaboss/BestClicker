namespace AutoClicker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMode = new System.Windows.Forms.GroupBox();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.rbKeyboard = new System.Windows.Forms.RadioButton();
            this.panelMouseOptions = new System.Windows.Forms.GroupBox();
            this.rbLeftClick = new System.Windows.Forms.RadioButton();
            this.rbRightClick = new System.Windows.Forms.RadioButton();
            this.panelKeyOptions = new System.Windows.Forms.GroupBox();
            this.lblKeySelect = new System.Windows.Forms.Label();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.panelInterval = new System.Windows.Forms.GroupBox();
            this.lblIntervalLabel = new System.Windows.Forms.Label();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.panelHotkey = new System.Windows.Forms.GroupBox();
            this.lblHotkeyLabel = new System.Windows.Forms.Label();
            this.cmbHotkey = new System.Windows.Forms.ComboBox();
            this.btnApplyHotkey = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatusDot = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMode.SuspendLayout();
            this.panelMouseOptions.SuspendLayout();
            this.panelKeyOptions.SuspendLayout();
            this.panelInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.panelHotkey.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.panelMode);
            this.panelMain.Controls.Add(this.panelMouseOptions);
            this.panelMain.Controls.Add(this.panelKeyOptions);
            this.panelMain.Controls.Add(this.panelInterval);
            this.panelMain.Controls.Add(this.panelHotkey);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 420);
            this.panelMain.TabIndex = 0;

            // panelTitle
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(24, 24, 38);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.lblSubtitle);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(500, 60);
            this.panelTitle.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(120, 200, 255);
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "⚡ AutoClicker";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 140);
            this.lblSubtitle.Location = new System.Drawing.Point(18, 38);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Mouse & Keyboard Automation";

            // panelMode
            this.panelMode.Controls.Add(this.rbMouse);
            this.panelMode.Controls.Add(this.rbKeyboard);
            this.panelMode.ForeColor = System.Drawing.Color.FromArgb(160, 160, 200);
            this.panelMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelMode.Location = new System.Drawing.Point(12, 70);
            this.panelMode.Name = "panelMode";
            this.panelMode.Size = new System.Drawing.Size(230, 55);
            this.panelMode.TabIndex = 1;
            this.panelMode.Text = "Modalità";

            // rbMouse
            this.rbMouse.AutoSize = true;
            this.rbMouse.Checked = true;
            this.rbMouse.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.rbMouse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMouse.Location = new System.Drawing.Point(16, 22);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.TabIndex = 0;
            this.rbMouse.TabStop = true;
            this.rbMouse.Text = "🖱 Mouse";

            // rbKeyboard
            this.rbKeyboard.AutoSize = true;
            this.rbKeyboard.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.rbKeyboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbKeyboard.Location = new System.Drawing.Point(110, 22);
            this.rbKeyboard.Name = "rbKeyboard";
            this.rbKeyboard.TabIndex = 1;
            this.rbKeyboard.Text = "⌨ Tastiera";

            // panelMouseOptions
            this.panelMouseOptions.Controls.Add(this.rbLeftClick);
            this.panelMouseOptions.Controls.Add(this.rbRightClick);
            this.panelMouseOptions.ForeColor = System.Drawing.Color.FromArgb(160, 160, 200);
            this.panelMouseOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelMouseOptions.Location = new System.Drawing.Point(12, 133);
            this.panelMouseOptions.Name = "panelMouseOptions";
            this.panelMouseOptions.Size = new System.Drawing.Size(230, 55);
            this.panelMouseOptions.TabIndex = 2;
            this.panelMouseOptions.Text = "Pulsante Mouse";

            // rbLeftClick
            this.rbLeftClick.AutoSize = true;
            this.rbLeftClick.Checked = true;
            this.rbLeftClick.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.rbLeftClick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbLeftClick.Location = new System.Drawing.Point(16, 22);
            this.rbLeftClick.Name = "rbLeftClick";
            this.rbLeftClick.TabIndex = 0;
            this.rbLeftClick.TabStop = true;
            this.rbLeftClick.Text = "Click Sinistro";

            // rbRightClick
            this.rbRightClick.AutoSize = true;
            this.rbRightClick.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.rbRightClick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbRightClick.Location = new System.Drawing.Point(120, 22);
            this.rbRightClick.Name = "rbRightClick";
            this.rbRightClick.TabIndex = 1;
            this.rbRightClick.Text = "Click Destro";

            // panelKeyOptions
            this.panelKeyOptions.Controls.Add(this.lblKeySelect);
            this.panelKeyOptions.Controls.Add(this.cmbKey);
            this.panelKeyOptions.ForeColor = System.Drawing.Color.FromArgb(160, 160, 200);
            this.panelKeyOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelKeyOptions.Location = new System.Drawing.Point(12, 133);
            this.panelKeyOptions.Name = "panelKeyOptions";
            this.panelKeyOptions.Size = new System.Drawing.Size(230, 55);
            this.panelKeyOptions.TabIndex = 3;
            this.panelKeyOptions.Text = "Tasto";
            this.panelKeyOptions.Visible = false;

            // lblKeySelect
            this.lblKeySelect.AutoSize = true;
            this.lblKeySelect.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.lblKeySelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKeySelect.Location = new System.Drawing.Point(12, 26);
            this.lblKeySelect.Name = "lblKeySelect";
            this.lblKeySelect.Text = "Tasto:";

            // cmbKey
            this.cmbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKey.BackColor = System.Drawing.Color.FromArgb(30, 30, 48);
            this.cmbKey.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.cmbKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbKey.Location = new System.Drawing.Point(55, 22);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(160, 23);
            this.cmbKey.TabIndex = 0;

            // panelInterval
            this.panelInterval.Controls.Add(this.lblIntervalLabel);
            this.panelInterval.Controls.Add(this.nudInterval);
            this.panelInterval.Controls.Add(this.cmbUnit);
            this.panelInterval.ForeColor = System.Drawing.Color.FromArgb(160, 160, 200);
            this.panelInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelInterval.Location = new System.Drawing.Point(12, 196);
            this.panelInterval.Name = "panelInterval";
            this.panelInterval.Size = new System.Drawing.Size(230, 58);
            this.panelInterval.TabIndex = 4;
            this.panelInterval.Text = "Intervallo";

            // lblIntervalLabel
            this.lblIntervalLabel.AutoSize = true;
            this.lblIntervalLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.lblIntervalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIntervalLabel.Location = new System.Drawing.Point(12, 28);
            this.lblIntervalLabel.Name = "lblIntervalLabel";
            this.lblIntervalLabel.Text = "Ogni:";

            // nudInterval
            this.nudInterval.BackColor = System.Drawing.Color.FromArgb(30, 30, 48);
            this.nudInterval.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.nudInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudInterval.Location = new System.Drawing.Point(50, 24);
            this.nudInterval.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(80, 23);
            this.nudInterval.TabIndex = 0;
            this.nudInterval.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // cmbUnit
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.BackColor = System.Drawing.Color.FromArgb(30, 30, 48);
            this.cmbUnit.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.cmbUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbUnit.Items.AddRange(new object[] { "ms", "sec", "min", "ore" });
            this.cmbUnit.Location = new System.Drawing.Point(136, 24);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(76, 23);
            this.cmbUnit.SelectedIndex = 0;
            this.cmbUnit.TabIndex = 1;

            // panelHotkey
            this.panelHotkey.Controls.Add(this.lblHotkeyLabel);
            this.panelHotkey.Controls.Add(this.cmbHotkey);
            this.panelHotkey.Controls.Add(this.btnApplyHotkey);
            this.panelHotkey.ForeColor = System.Drawing.Color.FromArgb(160, 160, 200);
            this.panelHotkey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelHotkey.Location = new System.Drawing.Point(258, 70);
            this.panelHotkey.Name = "panelHotkey";
            this.panelHotkey.Size = new System.Drawing.Size(230, 90);
            this.panelHotkey.TabIndex = 5;
            this.panelHotkey.Text = "Hotkey Globale";

            // lblHotkeyLabel
            this.lblHotkeyLabel.AutoSize = true;
            this.lblHotkeyLabel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.lblHotkeyLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHotkeyLabel.Location = new System.Drawing.Point(12, 28);
            this.lblHotkeyLabel.Name = "lblHotkeyLabel";
            this.lblHotkeyLabel.Text = "Tasto:";

            // cmbHotkey
            this.cmbHotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHotkey.BackColor = System.Drawing.Color.FromArgb(30, 30, 48);
            this.cmbHotkey.ForeColor = System.Drawing.Color.FromArgb(220, 220, 240);
            this.cmbHotkey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHotkey.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            this.cmbHotkey.Location = new System.Drawing.Point(55, 24);
            this.cmbHotkey.Name = "cmbHotkey";
            this.cmbHotkey.Size = new System.Drawing.Size(80, 23);
            this.cmbHotkey.SelectedIndex = 5;
            this.cmbHotkey.TabIndex = 0;

            // btnApplyHotkey
            this.btnApplyHotkey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyHotkey.BackColor = System.Drawing.Color.FromArgb(40, 60, 90);
            this.btnApplyHotkey.ForeColor = System.Drawing.Color.FromArgb(120, 200, 255);
            this.btnApplyHotkey.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnApplyHotkey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 100, 150);
            this.btnApplyHotkey.Location = new System.Drawing.Point(12, 56);
            this.btnApplyHotkey.Name = "btnApplyHotkey";
            this.btnApplyHotkey.Size = new System.Drawing.Size(200, 26);
            this.btnApplyHotkey.TabIndex = 1;
            this.btnApplyHotkey.Text = "Applica Hotkey";
            this.btnApplyHotkey.UseVisualStyleBackColor = false;

            // panelControls
            this.panelControls.Controls.Add(this.btnStart);
            this.panelControls.Controls.Add(this.btnStop);
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelControls.Location = new System.Drawing.Point(258, 168);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(230, 90);
            this.panelControls.TabIndex = 6;

            // btnStart
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(20, 90, 50);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(80, 240, 130);
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(40, 160, 80);
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 84);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "▶  START";
            this.btnStart.UseVisualStyleBackColor = false;

            // btnStop
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(80, 20, 20);
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(240, 80, 80);
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(120, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 84);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "■  STOP";
            this.btnStop.UseVisualStyleBackColor = false;

            // panelStatus
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(24, 24, 38);
            this.panelStatus.Controls.Add(this.lblStatusDot);
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 386);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(500, 34);
            this.panelStatus.TabIndex = 7;

            // lblStatusDot
            this.lblStatusDot.AutoSize = true;
            this.lblStatusDot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblStatusDot.ForeColor = System.Drawing.Color.FromArgb(100, 100, 140);
            this.lblStatusDot.Location = new System.Drawing.Point(12, 6);
            this.lblStatusDot.Name = "lblStatusDot";
            this.lblStatusDot.Text = "●";

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(160, 160, 200);
            this.lblStatus.Location = new System.Drawing.Point(32, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Ready";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMode.ResumeLayout(false);
            this.panelMode.PerformLayout();
            this.panelMouseOptions.ResumeLayout(false);
            this.panelMouseOptions.PerformLayout();
            this.panelKeyOptions.ResumeLayout(false);
            this.panelKeyOptions.PerformLayout();
            this.panelInterval.ResumeLayout(false);
            this.panelInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.panelHotkey.ResumeLayout(false);
            this.panelHotkey.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox panelMode;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.RadioButton rbKeyboard;
        private System.Windows.Forms.GroupBox panelMouseOptions;
        private System.Windows.Forms.RadioButton rbLeftClick;
        private System.Windows.Forms.RadioButton rbRightClick;
        private System.Windows.Forms.GroupBox panelKeyOptions;
        private System.Windows.Forms.Label lblKeySelect;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.GroupBox panelInterval;
        private System.Windows.Forms.Label lblIntervalLabel;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.GroupBox panelHotkey;
        private System.Windows.Forms.Label lblHotkeyLabel;
        private System.Windows.Forms.ComboBox cmbHotkey;
        private System.Windows.Forms.Button btnApplyHotkey;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblStatusDot;
        private System.Windows.Forms.Label lblStatus;
    }
}