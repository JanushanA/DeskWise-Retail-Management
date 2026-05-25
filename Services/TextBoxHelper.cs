using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeskWise.Services
{
    // Grey placeholder text for search boxes (Windows cue banner).
    public static class TextBoxHelper
    {
        private const int EmSetCueBanner = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public static void SetSearchPlaceholder(TextBox textBox, string placeholder = "Search")
        {
            if (textBox == null) return;

            void apply(object sender, EventArgs e)
            {
                if (textBox.IsHandleCreated)
                {
                    SendMessage(textBox.Handle, EmSetCueBanner, (IntPtr)1, placeholder);
                }
            }

            textBox.HandleCreated += apply;
            if (textBox.IsHandleCreated) apply(null, EventArgs.Empty);
        }
    }
}
