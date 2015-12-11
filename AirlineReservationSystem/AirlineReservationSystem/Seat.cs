using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Seat
    {
        public string seatID { get; set; }
        public string type { get; set; }
        public string price { get; set; }

        public Seat() { }
        public Seat(string id, string t, string p)
        {
            this.seatID = id;
            this.type = t;
            this.price = p;
        }
    }
}
