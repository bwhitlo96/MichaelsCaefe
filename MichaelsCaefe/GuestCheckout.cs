using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MichaelsCaefe
{
    public partial class GuestCheckout : Form
    {
        public GuestCheckout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuestCheckout_cvv_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuestCheckout_GoToDelivery_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery d1 = new Delivery();
            d1.Show();
        }

        private void GuestCheckout_GoToPickup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PickUp p1 = new PickUp();
            p1.Show();
        }
    }
}
