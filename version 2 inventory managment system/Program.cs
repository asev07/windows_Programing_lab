using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version_2_inventory_managment_system
{
    internal class Product 
    {
       public string idNumber { get; set; }  
       public string date { get; set; }  
       public string moniter { get; set; }  
       public string itemName { get; set; }  
       public string count { get; set; }  
       public string price { get; set; }  

        public  void display()
        {
            Console.WriteLine(" ${idNumber}  -   ${date}  -   ${monitor}   -   ${itemName}  -   ${count}   -    ${price}");
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
        }


    }
}
