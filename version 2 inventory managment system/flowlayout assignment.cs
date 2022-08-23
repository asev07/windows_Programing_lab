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
    public partial class flowlayout_assignment : Form
    {
        static int a = 0;
        public flowlayout_assignment()
        {
            InitializeComponent();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void formlayout_assignment_Load(object sender, EventArgs e)
        {
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxtBox.Clear();
            priceTxtBox.Clear();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            
            Name name = new Name();
            a++;
            name.PName = nameTxtBox.Text;
            name.PNum = a.ToString();
            name.PPrice = priceTxtBox.Text;
            name.Show();
            flowLayoutPanel.Controls.Add(name);
        }

        private void name1_Load(object sender, EventArgs e)
        {

        }
    }
}
