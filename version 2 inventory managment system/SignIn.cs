using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version_2_inventory_managment_system
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (1<10 || passwordTextbox.Text == "12345" && usernameTxtbox.Text == "aser")
           // if (passwordTextbox.Text == "12345" && usernameTxtbox.Text == "aser")
            {
                MDI form1 = new MDI();
                form1.Show();
                this.Hide();
            }
        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
