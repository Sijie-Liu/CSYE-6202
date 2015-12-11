using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public partial class Update : Form
    {
        Helper helper = new Helper();
        public Update(string flight,string dep,string arr,string depTime,string arrTime,string carrier)
        {
            InitializeComponent();
            this.txt_flight.Text = flight;
            this.txt_dep.Text = dep;
            this.txt_depTime.Text = depTime;
            this.txt_arr.Text = arr;
            this.txt_arrTime.Text = arrTime;
            this.txt_carrier.Text = carrier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helper.UpdateFlight(this.txt_flight.Text, this.txt_dep.Text, this.txt_arr.Text, this.txt_depTime.Text, this.txt_arrTime.Text, this.txt_carrier.Text);
            MessageBox.Show("Done!");
            this.Close();
        }
    }
}
