using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace version_2_inventory_managment_system
{
    public partial class UserControlTrail : Form
    {
        public UserControlTrail()
        {
            InitializeComponent();
        }

        private void UserControlTrail_Load(object sender, EventArgs e)
        {
            String connectionString = @"Data Source = DESKTOP-LPP4R31\SQLEXPRESS;Initial Catalog=inventory;Integrated Security=True";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connected");
            }
            catch {
                if(connection !=null)
                connection.Close();
                MessageBox.Show("Not Connected");
                
            }
        }

        private void productCard1_Load(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
          ProductCard name = new ProductCard();
            
            name.Title = nameTxtBox.Text;
            name.Disc = discTxtBox.Text;
            name.Price = priceTxtBox.Text;
            name.Show();
            flowLayoutPanel1.Controls.Add(name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
