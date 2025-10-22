using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public  ICollection<Flight> Flights { get; set; }
    
    // Overriding ToString method
    public override string ToString()
        {
            return $"{FirstName} {LastName}, Passport: {PassportNumber}";
        }
        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }
        public bool CheckProfile(string firstName, string lastName, string emailAddress)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == emailAddress;
        }

        public virtual void PssengerType()
        {
            Console.WriteLine("I am a passenger");
        }
    }
   

}