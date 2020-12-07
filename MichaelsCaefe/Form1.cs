using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichaelsCaefe
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void UsernameLable_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void usernameInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lunch_menue l2 = new lunch_menue();
            l2.Show();

        }

        private void signIn_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            lunch_menue l1 = new lunch_menue();
            l1.Show();
        }
    }
}
