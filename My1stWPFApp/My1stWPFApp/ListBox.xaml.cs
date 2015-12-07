using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ListBox.xaml
    /// </summary>
    public partial class ListBox : Window
    {
        ObservableCollection<People> peopleList = new ObservableCollection<People>();

        public ListBox()
        {
            InitializeComponent();
            peopleList.Add(new People()
            {
                name = "Jay",
                age = 24,
                gender = "M",
            });
            peopleList.Add(new People()
            {
                name = "Jay2",
                age = 24,
                gender = "M",
            });

            this.dataTable.ItemsSource = peopleList;

        }

        
        
    }
}
