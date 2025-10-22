using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    internal class ServiceFlight
    {
        public List<Flight> Flights { get; set; }

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            /*for (int j = 0; j < Flights.Count; j++)
            {
                if (Flights[j].Destination.Equals(destination))
                    dates.Add(Flights[j].FlightDate);
            }*/

            foreach (Flight f in Flights)
            {
                if (f.Destination.Equals(destination))
                    dates.Add(f.FlightDate);
               
            }
            return dates;
        }

        public void GetFlight(string filterType, string filtervalue)
        {
            switch (filterType)
            {
                case "Destination":

                    foreach (Flight f in Flights)
                    {
                        if (f.Destination.Equals(filtervalue))
                            Console.WriteLine(f);


                    }
                    break;
                case "FlighDate":

                    foreach (Flight f in Flights)
                    {
                        //if (DateTime.Equals(f.FlightDate, DateTime.Parse(filtervalue)))
                        if(f.FlightDate.ToString().Equals(filtervalue))
                            Console.WriteLine(f);


                    }
                    break;
            }
        }


    }
}
