﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MichaelsCaefe
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_GoToReview_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmation c1 = new Confirmation();
            c1.Show();
        }
    }
}
