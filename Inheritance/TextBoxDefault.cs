using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextBoxDefault : System.Windows.Forms.TextBox
    {
        private string defaultText = "Default";

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
            {
                DrawDefaultText(e);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }

        private void DrawDefaultText(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, defaultText, Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.TextBoxControl);
        }
    }
}
