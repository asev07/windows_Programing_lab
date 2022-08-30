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
        private string _Disc="-----------";
        private string _Price="-----------";

        public string Title
        {
            get { return _Title; }
            set { tittleNameLbl.Text = value; }
        }
        public string Disc
        {
            get { return _Disc; }
            set { descLbl.Text = value; }
        } 
        public string Price
        {
            get { return _Price; }
            set { priceLbl.Text = value; }
        }
        
        public ProductCard()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void CardClick(Object o ,EventArgs e)
        {
          
            MessageBox.Show("CARD CLICKED");
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

        private void priceLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
