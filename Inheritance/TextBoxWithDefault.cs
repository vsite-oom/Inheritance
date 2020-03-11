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
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (TextLength == 0)
                DrawDefaultText(pe);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }

        private void DrawDefaultText(PaintEventArgs pe)
        {
            TextRenderer.DrawText(pe.Graphics, "Default", Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.TextBoxControl);
        }
    }
}
