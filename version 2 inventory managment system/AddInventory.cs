using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace version_2_inventory_managment_system
{
    public partial class AddInventory : Form
    {
        static List<Product> products = new List<Product>();   
       SignIn signin ;
        public AddInventory()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                //creating the product object
                Product product = new Product();

           

                //finally adding the data to the list 
                products.Add(product);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.inventoryDataSet.Employee);
            // TODO: This line of code loads data into the 'inventoryDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.inventory);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();   
            product.price = float.Parse(priceTextBox.Text);
            product.moniter = 2;
            product.count = int.Parse(countTextBox.Text);
            product.date = (DateTime.Now.ToString() );
            product.itemName = nameTextBox.Text;
            // the save button saves the static list of products either to file or database
            inventory inv = new inventory();
            inv.addProduct(product);
        }

        private void numberTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            bool hasOnlyAlpha=false;
                foreach(char i in numberTextBox.Text)
            {
               hasOnlyAlpha= regex.IsMatch(char.ToString(i));
                if (hasOnlyAlpha)
                {
                    break;
                }
            }
            if (hasOnlyAlpha)
            {
                errorProvider1.SetError(numberTextBox, "Id is Numbers only ");

            }

            else
            {
                errorProvider1.Clear();
            }


            }

        private void dateTextBox_Leave(object sender, EventArgs e)
        {
            if (dateTextBox.Text == null)
            {
                errorProvider2.SetError(dateTextBox, "Enter Date ");

            }

            else
            {
                errorProvider2.Clear();
            }
            }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            bool hasOnlyAlpha = false;
            foreach (char i in dateTextBox.Text)
            {
                hasOnlyAlpha = regex.IsMatch(char.ToString(i));
                if (hasOnlyAlpha)
                {
                    break;
                }
            }
            if (hasOnlyAlpha)
            {
                errorProvider3.SetError(dateTextBox, "Id is Numbers only ");

            }

            else
            {
                errorProvider3.Clear();
            }

        }

       

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            bool hasOnlyAlpha = false;
            foreach (char i in nameTextBox.Text)
            {
                hasOnlyAlpha = regex.IsMatch(char.ToString(i));
                if (!hasOnlyAlpha)
                {
                    break;
                }
            }
            if (!hasOnlyAlpha)
            {
                errorProvider5.SetError(nameTextBox, "Id is Numbers only ");

            }

            else
            {
                errorProvider5.Clear();
            }
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            bool hasOnlyAlpha = false;
            foreach (char i in countTextBox.Text)
            {
                hasOnlyAlpha = regex.IsMatch(char.ToString(i));
                if (hasOnlyAlpha)
                {
                    break;
                }
            }
            if (hasOnlyAlpha)
            {
                errorProvider6.SetError(countTextBox, "Id is Numbers only ");

            }

            else
            {
                errorProvider6.Clear();
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            bool hasOnlyAlpha = false;
            foreach (char i in priceTextBox.Text)
            {
                hasOnlyAlpha = regex.IsMatch(char.ToString(i));
                if (hasOnlyAlpha)
                {
                    break;
                }
            }
            if (hasOnlyAlpha)
            {
                errorProvider1.SetError(priceTextBox, "Id is Numbers only ");

            }

            else
            {
                errorProvider1.Clear();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
