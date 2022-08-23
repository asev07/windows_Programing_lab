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
    public partial class Name : UserControl
    {
        public string _PName  ;
        private string _PPrice ;
        private string _PNum ;
        public string PName
        {
            get { return _PName; }
            set {  nameLbl.Text = value; }
        }
        public string PPrice
        {
            get { return _PPrice; }
            set { priceLbl.Text = value; }
        } 
        public string PNum
        {
            get { return _PNum; }
            set { numLbl.Text = value; }
        }
        public Name()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_Load(object sender, EventArgs e)
        {

        }

        private void priceLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
