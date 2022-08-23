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
    
    public partial class ProductCard : UserControl
    {
        private string _Title="-----------";
        public string Title
        {
            get { return _Title; }
            set { tittleNameLbl.Text = _Title; }
        }
        public String Desc { set; get; }
        public String Price { set; get; }
        public ProductCard()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void tittleLbl_Click(object sender, EventArgs e)
        {

        }

        private void tittleNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
