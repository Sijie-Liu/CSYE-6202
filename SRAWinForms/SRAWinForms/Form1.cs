using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRAWinForms
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Username or Password cannot be empty!");
                textBox1.Clear();
                textBox2.Clear();
                return;
            }

            if (textBox1.Text.Equals("username") && textBox2.Text.Equals("password"))
            {
                MessageBox.Show("Login successfully.");
                
                this.Visible = false;
                Form2 form2 = new Form2();
                form2.Show();
                
            }
            else
            {
                count++;
                if (count >= 3)
                {
                    MessageBox.Show("Sorry you have to reopen the application.");
                }
                else
                {
                    MessageBox.Show("Username or Password is wrong. You have "+(3-count)+" times left to try.");
                }
            }
        }

        
    }
}
