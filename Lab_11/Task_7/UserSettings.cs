using System;
using System.Drawing;

namespace Task_7
{
    [Serializable]
    public class UserSettings
    {
        public Font SelectedFont { get; set; }
        public Color SelectedBackColor { get; set; }
        public Color SelectedForeColor { get; set; }

        public UserSettings()
        {
            SelectedFont = (SelectedFont == null) ? SystemFonts.DefaultFont : SelectedFont;
            SelectedBackColor = (SelectedFont == null) ? SystemColors.ControlText : SelectedBackColor;
            SelectedForeColor = (SelectedForeColor == null) ? SystemColors.ControlText : SelectedForeColor;
        }
    }
}