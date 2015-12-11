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
    public partial class BookTickets : Form
    {
        Helper helper = new Helper();
        public string username { get; set; }
        public string flight_number { get; set; }
        public BookTickets(string username, string flight_number)
        {
            InitializeComponent();
            this.username = username;
            this.flight_number = flight_number;
            this.txt_flight.Text = flight_number;
            this.txt_user.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer = txt_customerName.Text;
            string type = combo_seatType.Text;
            string id = "20A";
            string price = helper.GetPriceFromSeat(flight_number,type);
            helper.InsertIntoUserTrip(username,flight_number,customer,id,price);
            MessageBox.Show("Done!");
            this.Close();
        }
    }
}
