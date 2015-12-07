using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace My1stWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text.Equals("username") && password.Text.Equals("1234"))
            {
                MessageBox.Show("Sign in Success!");
                info winInfo = new info();
                winInfo.Show();
            }
            else
            {
                MessageBox.Show("Sign in failed!");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Show();
        }
    }
}
