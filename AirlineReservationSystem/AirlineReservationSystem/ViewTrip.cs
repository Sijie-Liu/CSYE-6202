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
    
    public partial class ViewTrip : Form
    {
        private List<Trip> tripList;
        Helper helper = new Helper();
        public ViewTrip(List<Trip> tl)
        {
            InitializeComponent();
            this.tripList = tl;


            //this.tripTable.DataSource = tripList;
            for(int i=0;i<tripList.Count;i++)
            {
                this.tripTable.Rows.Add();
                this.tripTable.Rows[i].Cells[0].Value = tripList[i].tripID;
                this.tripTable.Rows[i].Cells[1].Value = tripList[i].flight;
                this.tripTable.Rows[i].Cells[2].Value = tripList[i].customer;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flight_number = this.tripTable.CurrentRow.Cells[1].Value.ToString();
            string customer = this.tripTable.CurrentRow.Cells[2].Value.ToString();

            helper.DeleteFromUserTrip(flight_number,customer);
            MessageBox.Show("Done!");
            this.Close();
        }
    }
}
