using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MichaelsCaefe
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_returnHome_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 f1 = new form1();
            f1.Show();
        }
    }
}
