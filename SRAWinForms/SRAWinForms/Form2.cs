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
    public partial class Form2 : Form
    {
        private List<ListViewItem> result;
        public Form2()
        {
            InitializeComponent();
            result = Helper.Randomizer();
            foreach (ListViewItem item in result)
            {
                this.table.Items.Add(item);
            }
        }

        public void refreshTable()
        {
            this.table.Items.Clear();
            foreach (ListViewItem item in result)
            {
                this.table.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student_id = studentID.Text;
            string first_name = firstname.Text;
            string last_name = lastname.Text;
            if (department.SelectedItem == null)
            {
                MessageBox.Show("All the field must be filled!");
                return;
            }
            string dep = department.SelectedItem.ToString();
            string enrollType = string.Empty;
            if (fulltime.Checked == true)
            {
                enrollType = "Full Time";
            }
            else if (parttime.Checked == true)
            {
                enrollType = "Part Time";
            }

            if (student_id == string.Empty || first_name == string.Empty || last_name == string.Empty || dep == null || enrollType == string.Empty)
            {
                MessageBox.Show("All the field must be filled!");
                return;
            }

            ListViewItem item = new ListViewItem();
            item.Text = student_id;
            item.SubItems.Add(first_name);
            item.SubItems.Add(last_name);
            item.SubItems.Add(dep);
            item.SubItems.Add(enrollType);

            this.table.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in result)
            {
                if(item.Text.ToString().Equals(studentID.Text.ToString()) )
                    this.table.Items.Remove(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in result)
            {
                if (item.Text.ToString().Equals(studentID.Text.ToString()))
                {
                    this.table.Items.Remove(item);

                    string student_id = studentID.Text;
                    string first_name = firstname.Text;
                    string last_name = lastname.Text;
                    if (department.SelectedItem == null)
                    {
                        MessageBox.Show("All the field must be filled!");
                        return;
                    }
                    string dep = department.SelectedItem.ToString();
                    string enrollType = string.Empty;
                    if (fulltime.Checked == true)
                    {
                        enrollType = "Full Time";
                    }
                    else if (parttime.Checked == true)
                    {
                        enrollType = "Part Time";
                    }

                    if (student_id == string.Empty || first_name == string.Empty || last_name == string.Empty || dep == null || enrollType == string.Empty)
                    {
                        MessageBox.Show("All the field must be filled!");
                        return;
                    }
                    ListViewItem item2 = new ListViewItem();
                    item2.Text = student_id;
                    item2.SubItems.Add(first_name);
                    item2.SubItems.Add(last_name);
                    item2.SubItems.Add(dep);
                    item2.SubItems.Add(enrollType);

                    this.table.Items.Add(item2);
                }
                    
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class Helper
    {
        public static string[] firstname = {"Bart","Maggie","Lisa","Homer","Otto","Dr.Marvin","Radioactive" };
        public static string[] lastname = {"Simpson","Mann","Monroe","Liu","Louis","Zhang","Pan" };
        public static string[] department = {"Information Systems","International Affairs","Nursing","Pharmacy","Professional Studies","Psychology","Public Administration" };
        public static string[] enrollmentType = {"Full Time","Part Time" };
        public static List<ListViewItem> Randomizer()
        {
            Random ran = new Random();
            List<ListViewItem> result = new List<ListViewItem>();
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ran.Next(100, 999).ToString()+"-" + ran.Next(10, 99).ToString() +"-"+ ran.Next(1000, 9999).ToString();
                item.SubItems.Add(firstname[ran.Next(0,6)]);
                item.SubItems.Add(lastname[ran.Next(0, 6)]);
                item.SubItems.Add(department[ran.Next(0, 6)]);
                item.SubItems.Add(enrollmentType[ran.Next(0, 1)]);

                result.Add(item);
            }
            return result;
        }
    }
}
