using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool signchecker(char sign)
        {
            bool checker=true;
            char[] c = textBox1.Text.ToCharArray();
            int s = c.Length-1;

            if (textBox1.Text != null)
            {
              //  if (c[s] == ('*') || c[s] == ('/') || c[s] == ('-') || c[s] == ('+') || c[s] == ('.') || c[s] == ('%'))
                if (textBox1.Text.EndsWith("*") || textBox1.Text.EndsWith("/") || textBox1.Text.EndsWith("-") || textBox1.Text.EndsWith("+") || textBox1.Text.EndsWith(".") || textBox1.Text.EndsWith("%"))
                {
                    checker = false;
                    c[s] = sign;
                    //MessageBox.Show(c[s] + " is the char sign");

                    string x = new string(c);
                    textBox1.Text = x;



                }
                else
                    textBox1.Text.Append(sign);
            }
            else
            {
                if(sign == '-' || sign == '+')
                {
                    textBox1.Text = char.ToString(sign);
                }
            }


                return checker;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //equals button
        }

        private void button10_Click(object sender, EventArgs e)
        {

            signchecker('-');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                signchecker('*');
                
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                signchecker('/');
        }

        private void button16_Click(object sender, EventArgs e)
        {
           signchecker('-');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            



           // MessageBox.Show(textBox1.Text + " is the string before" );

                signchecker('%');

              //  MessageBox.Show(textBox1.Text + " is the string after" );

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
        }
    }
}
