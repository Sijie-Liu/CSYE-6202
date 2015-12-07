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
    /// Interaction logic for info.xaml
    /// </summary>
    public partial class info : Window
    {
        ObservableCollection<Student> list = Helper.Randomizer();
        Dictionary<string,int> departments = new Dictionary<string, int>();
        public info()
        {
            InitializeComponent();
            
            freshTable();
            departments["Information Systems"] = 0;
            departments["International Affairs"] = 1;
            departments["Nursing"] = 2;
            departments["Pharmacy"] = 3;
            departments["Professional Studies"] = 4;
            departments["Psychology"] = 5;
            departments["Public Administration"] = 6;
        }

       

        private void freshTable()
        {
            
            this.table.ItemsSource = list;

        }
        

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Student selected = (Student)this.table.SelectedItem;
            list.Remove(selected);
            selected.StudentID = this.studentID.Text;
            selected.FirstName = this.firstname.Text;
            selected.LastName = this.lastname.Text;
            selected.Department = this.department.Text;
            if (radioFullTime.IsChecked == true)
                selected.EnrollType = "Full Time";
            else
                selected.EnrollType = "Part Time";
            list.Add(selected);
            this.save.Visibility = Visibility.Hidden;
        }

        private void table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void department_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (this.studentID.Text == string.Empty || this.firstname.Text == string.Empty || this.lastname.Text == string.Empty || this.department.SelectedItem == null)
            {
                MessageBox.Show("All the field should be filled!");
                return;
            }
            if (radioFullTime.IsChecked == false && radioPartTime.IsChecked==false)
            {
                MessageBox.Show("All the field should be filled!");
                return;
            }

            string id = this.studentID.Text;
            string fn = this.firstname.Text;
            string ln = this.lastname.Text;
            string dep = this.department.Text;
            string g;
            if (radioFullTime.IsChecked == true)
                g = "Full Time";
            else 
                g = "Part Time";

            list.Add(new Student(id, fn, ln, dep, g));


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Student selected = (Student)this.table.SelectedItem;
            list.Remove(selected);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.save.Visibility = Visibility.Visible;
            Student selected = (Student)this.table.SelectedItem;
            this.studentID.Text = selected.StudentID;
            this.firstname.Text = selected.FirstName;
            this.lastname.Text = selected.LastName;
            this.department.SelectedIndex = departments[selected.Department];
            if (selected.EnrollType.Equals("Full Time"))
            {
                this.radioFullTime.IsChecked = true;
            }
            else
            {
                this.radioPartTime.IsChecked = true;
            }
        }
    }


    public class Helper
    {
        public static string[] firstname = { "Bart", "Maggie", "Lisa", "Homer", "Otto", "Dr.Marvin", "Radioactive" };
        public static string[] lastname = { "Simpson", "Mann", "Monroe", "Liu", "Louis", "Zhang", "Pan" };
        public static string[] department = { "Information Systems", "International Affairs", "Nursing", "Pharmacy", "Professional Studies", "Psychology", "Public Administration" };
        public static string[] enrollmentType = { "Full Time", "Part Time" };
        public static ObservableCollection<Student> Randomizer()
        {
            Random ran = new Random();
            ObservableCollection<Student> result = new ObservableCollection<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student s = new Student(ran.Next(100, 999).ToString() + "-" + ran.Next(10, 99).ToString() + "-" + ran.Next(1000, 9999).ToString(), firstname[ran.Next(0, 6)], lastname[ran.Next(0, 6)], department[ran.Next(0, 6)], enrollmentType[ran.Next(0, 1)]);
                

                result.Add(s);
            }
            return result;
        }
    }
}
