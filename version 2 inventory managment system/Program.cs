using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace version_2_inventory_managment_system
{
    internal class Product 
    {
       public int idNumber { get; set; }  
       public string date { get; set; }  
       public int moniter { get; set; }  
       public string itemName { get; set; }  
       public int count { get; set; }  
       public float price { get; set; }  

        public  void display()
        {
            Console.WriteLine(" ${idNumber}  -   ${date}  -   ${monitor}   -   ${itemName}  -   ${count}   -    ${price}");
        }
    }
    internal class inventory { 
     

        public void addProduct(Product product)
        {
            string statement = $"insert into inventory(employee,itemName,dateofregistration,itemcount,price) values({product.moniter},{product.itemName},{product.date},{product.count},{product.price})";
            String connectionString = @"Data Source = DESKTOP-LPP4R31\SQLEXPRESS;Initial Catalog=inventory;Integrated Security=True";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(connectionString,connection);
                MessageBox.Show("Connected");
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                if (connection != null)
                    connection.Close();
                MessageBox.Show("Not Connected");

            }

        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new SignIn());
            Application.Run(new MDI());
            //Application.Run(new flowlayout_assignment());
            //Application.Run(new UserControlTrail());



        }


    }
}
