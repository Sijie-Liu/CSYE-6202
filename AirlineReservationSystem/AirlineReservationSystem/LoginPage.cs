using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class LoginPage : Form
    {
        private Helper helper = new Helper();
        private Dictionary<string, string> accountList = new Dictionary<string, string>();
        public LoginPage()
        {
            InitializeComponent();
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            Account user = helper.checkLogin(username, password);
            if (user ==  null)
            {
                MessageBox.Show("Login Failed!");
                return;
            }
            MessageBox.Show("Login Successfully!");
            MainScreen ms = new MainScreen(user);

            //this.Hide();
            ms.ShowDialog();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.ShowDialog();
        }
    }
}
