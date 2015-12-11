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
    public partial class MainScreen : Form
    {
        private Account account;
        private Helper helper = new Helper();
        List<Flight> flightList;
        public MainScreen(Account account)
        {
            InitializeComponent();
            this.account = account;
            //this.name.Text = account.username;
            this.name.Text = account.type;
            if (account.type.Trim().Equals("regular"))
            {
                
                this.btn_add.Visible = false;
                this.btn_update.Visible = false;
                this.btn_delete.Visible = false;
                
                
            }
            populateTable();
            
        }

        public void populateTable()
        {
            flightList = helper.GetFlightList();
            for (int i = 0; i < flightList.Count; i++)
            {
                this.flightTable.Rows.Add();
                this.flightTable.Rows[i].Cells[0].Value = flightList[i].flight_name;
                this.flightTable.Rows[i].Cells[1].Value = flightList[i].departure;
                this.flightTable.Rows[i].Cells[2].Value = flightList[i].arrival;
                this.flightTable.Rows[i].Cells[3].Value = flightList[i].dep_time;
                this.flightTable.Rows[i].Cells[4].Value = flightList[i].arr_time;
                this.flightTable.Rows[i].Cells[5].Value = flightList[i].carrier;


            }

        }
        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Trip> tripList = helper.GetTripList(account);
            ViewTrip vt = new ViewTrip(tripList);
            vt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string flight = this.flightTable.CurrentRow.Cells[0].Value.ToString();
            List<Customer> customerList = helper.GetCustomerFromFlight(flight);
            FlightInfo fi = new FlightInfo(customerList);
            fi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string flight = this.flightTable.CurrentRow.Cells[0].Value.ToString();
            List<Seat> seatList = helper.GetSeatListFromFlight(flight);

            ViewSeat vs = new ViewSeat(seatList);
            vs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string flight = this.flightTable.CurrentRow.Cells[0].Value.ToString();
            BookTickets bt = new BookTickets(account.username,flight);
            bt.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string flight = this.flightTable.CurrentRow.Cells[0].Value.ToString();
            helper.DeleteFlight(flight);
            MessageBox.Show("Done!");
            populateTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddFlight af = new AddFlight();
            af.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string flight = this.flightTable.CurrentRow.Cells[0].Value.ToString();
            string dep = this.flightTable.CurrentRow.Cells[1].Value.ToString();
            string arr = this.flightTable.CurrentRow.Cells[2].Value.ToString();
            string depTime = this.flightTable.CurrentRow.Cells[3].Value.ToString();
            string arrTime = this.flightTable.CurrentRow.Cells[4].Value.ToString();
            string carrier = this.flightTable.CurrentRow.Cells[5].Value.ToString();
            Update u = new Update(flight,dep,arr,depTime,arrTime,carrier);
            u.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            populateTable();
        }
    }
}
