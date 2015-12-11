using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Flight
    {
        public string flight_name { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public string dep_time { get; set; }
        public string arr_time { get; set; }
        public string carrier { get; set; }
        public List<Seat> seatList = new List<Seat>();

        public Flight() { }
        public Flight(string n, string dep, string arr, string dt, string at,string c)
        {
            this.flight_name = n;
            this.departure = dep;
            this.arrival = arr;
            this.dep_time = dt;
            this.arr_time = at;
            this.carrier = c;
        }
    }
}
