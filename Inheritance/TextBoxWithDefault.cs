using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nasljeđivanje
{

    public partial class TextBoxWithDefault : TextBox
    {
        public TextBoxWithDefault()
        {
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (TextLength == 0)
            {
                DrawDefaultText(pe);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }

        private void DrawDefaultText(PaintEventArgs pe)
        {
            var rect = ClientRectangle;
            rect.Offset(-2, 1);
            TextRenderer.DrawText(pe.Graphics, text, Font, rect, SystemColors.GrayText, TextFormatFlags.TextBoxControl);
        }
        private string text = "Default";
    }
}
