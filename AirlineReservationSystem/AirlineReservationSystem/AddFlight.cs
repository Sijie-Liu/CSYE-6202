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
    public partial class AddFlight : Form
    {
        private Helper helper = new Helper();
        public AddFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helper.AddFlight(this.txt_flight.Text,this.txt_dep.Text,this.txt_arr.Text,this.txt_depTime.Text,this.txt_arrTime.Text,this.txt_carrier.Text);
            MessageBox.Show("Done.");
            this.Close();
        }
    }
}
