using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MichaelsCaefe
{
    public partial class Order_details : Form
    {
        public Order_details()
        {
            InitializeComponent();
        }

        private void od_checkout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Checkout uc1 = new User_Checkout();
            uc1.Show();
        }

        private void od_guest_checkout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestCheckout gc1 = new GuestCheckout();
            gc1.Show();
        }
    }
}
