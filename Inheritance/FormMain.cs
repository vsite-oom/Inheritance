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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

      

        private void textBoxShippingName_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Default")
            {
                tb.ResetText();
                tb.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxShippingName_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.TextLength == 0)
            {
                tb.Text = "Default";
                tb.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
