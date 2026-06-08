using System.Windows.Forms;

namespace AutoClicker.Models
{
    internal class KeySettings
    {
        public Keys Key { get; set; } = Keys.Space;
        public int IntervalMs { get; set; } = 1000;
    }
}