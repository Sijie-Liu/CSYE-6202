using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Customer
    {
        public string flightName { get; set; }
        public string name { get; set; }
        public string seatID { get; set; }
        public string price { get; set; }
        public Customer() { }
        public Customer(string f, string n,string s,string p)
        {
            this.flightName = f;
            this.name = n;
            this.seatID = s;
            this.price = p;
        }
    }
}
