using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextBoxDefault : System.Windows.Forms.TextBox
    {
        private string defaultText = "Default Value";

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, Text.Length == 0);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0 ) {

                DrawDefaultText(e);

            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint,Text.Length == 0);
            Invalidate();
           
        }


        private void DrawDefaultText(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics,defaultText,Font,ClientRectangle,SystemColors.GrayText);
        }
    }
}
