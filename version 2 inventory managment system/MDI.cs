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
            SignIn signIn = new SignIn();
            signIn.MdiParent = this;    
            signIn.Show();
           
        }

        private void addInventoryPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form active = this.ActiveMdiChild;
            if(active == null)
            {
                Form1 form1 = new Form1();
                form1.MdiParent = this;
                form1.Show();
            }


            
        }
    }
}
