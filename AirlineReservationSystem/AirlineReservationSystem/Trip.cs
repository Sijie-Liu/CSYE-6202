using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem
{
    public class Trip
    {
        public string tripID { get; set; }
        public string flight { get; set; }
        public string customer { get; set; }

        public Trip()
        { }

        public Trip(string id, string f, string c)
        {
            this.tripID = id;
            this.flight = f;
            this.customer = c;
        }
    }
}
