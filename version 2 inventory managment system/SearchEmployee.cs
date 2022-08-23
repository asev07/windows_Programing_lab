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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.inventory);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void searchInventoryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.searchInventory(this.inventoryDataSet.inventory, parameterToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void parameterToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
