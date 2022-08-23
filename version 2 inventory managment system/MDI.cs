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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                SignIn signIn = new SignIn();
                signIn.MdiParent = this;
                signIn.Show();
            }
            else
            {

                active.Dispose();
                SignIn signIn = new SignIn();
                signIn.MdiParent = this;
                signIn.Show();

            }

        }

        private void addInventoryPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                AddInventory form1 = new AddInventory();
                form1.MdiParent = this;
                form1.Show();

            }
            else
            {

                active.Dispose();
                AddInventory form1 = new AddInventory();
                form1.MdiParent = this;
                form1.Show();

            }



        }

        private void displayEmployeePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                Search form1 = new Search();
                form1.MdiParent = this;
                form1.Show();

            }
            else
            {

                active.Dispose();
                Search form1 = new Search();
                form1.MdiParent = this;
                form1.Show();

            }

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                Display_Inventory form1 = new Display_Inventory();
                form1.MdiParent = this;
                form1.Show();

            }
            else
            {

                active.Dispose();
                Display_Inventory form1 = new Display_Inventory();
                form1.MdiParent = this;
                form1.Show();

            }

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                Search form1 = new Search();
                form1.MdiParent = this;
                form1.Show();

            }
            else
            {

                active.Dispose();
                Search form1 = new Search();
                form1.MdiParent = this;
                form1.Show();

            }

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                SearchEmployee form1 = new SearchEmployee();
                form1.MdiParent = this;
                form1.Show();

            }
            else
            {

                active.Dispose();
                SearchEmployee form1 = new SearchEmployee();
                form1.MdiParent = this;
                form1.Show();

            }
        }

        private void userControlTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active == null)
            {
                UserControlTrail form1 = new UserControlTrail();
                form1.MdiParent = this;
                form1.Show();

            }
            else
            {

                active.Dispose();
                UserControlTrail form1 = new UserControlTrail();
                form1.MdiParent = this;
                form1.Show();


            }
        }
    }
        }

