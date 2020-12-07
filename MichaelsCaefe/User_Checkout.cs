using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MichaelsCaefe
{
    public partial class User_Checkout : Form
    {
        public User_Checkout()
        {
            InitializeComponent();
        }

        private void UserCheckout_acount_info_lable_Click(object sender, EventArgs e)
        {

        }

        private void UserCheckout_paymentOptions_chas_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserCheckout_GoToDelivery_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery d1 = new Delivery();
            d1.Show();
        }

        private void User_checkout_PickUp_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PickUp p1 = new PickUp();
            p1.Show();
        }
    }
}
