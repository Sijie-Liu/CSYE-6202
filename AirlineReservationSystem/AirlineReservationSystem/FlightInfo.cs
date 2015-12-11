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
    public partial class FlightInfo : Form
    {
        private List<Customer> customerList;
        public FlightInfo(List<Customer> cl)
        {
            InitializeComponent();
            customerList = cl;

            for (int i = 0; i < customerList.Count; i++)
            {
                this.customerTable.Rows.Add();
                this.customerTable.Rows[i].Cells[0].Value = customerList[i].name;
                this.customerTable.Rows[i].Cells[1].Value = customerList[i].seatID;
                this.customerTable.Rows[i].Cells[2].Value = customerList[i].price;
            }
        }
    }
}
