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
using System.Windows.Shapes;

namespace My1stWPFApp
{
    /// <summary>
    /// Interaction logic for info.xaml
    /// </summary>
    public partial class info : Window
    {
        public info()
        {
            InitializeComponent();
            freshTable();
        }

        private void department_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void freshTable()
        {
            Student s = new Student("10010","Jay","Liu","IS","Full Time");
            ListViewItem item = new ListViewItem();
            //item.DataContext = s;
            item.
            this.table.Items.Add(item);

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
