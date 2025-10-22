using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {


        public int FlightId { get; set; }
        public string Destination { get; set; }
        public DateTime Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public TimeSpan EstimatedDuration { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Plane> Planes { get; set; }
        public  ICollection<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return"Flight Date : " + FlightDate + " Destination :" +Destination + " Departure : " + Departure  + " Estimated Duration : " + EstimatedDuration;
        }

    }
}


       
