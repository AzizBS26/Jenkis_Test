
using AM.ApplicationCore.Domain;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Passenger.cs;

//Plane plane = new Plane();
//plane.PlaneType = PlaneType.Airbus;
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(2018, 11, 10);
//Console.WriteLine(plane.ToString());
Plane plane1 = new Plane { Capacity = 200, PlaneType = PlaneType.Boeing, ManufactureDate = DateTime.Now };
Console.WriteLine(plane1);


// partie 3
Console.WriteLine("****************************");
Passenger p1 = new Passenger( FirstName = "steave", LastName = "jobs", EmailAddress = "aaaaa@gmail.com");
Console.WriteLine("La methode Checkpassenger");
Console.WriteLine(p1.CheckProfile("steave", "Jobs"));
Console.WriteLine(p1.CheckProfile("steave", "Jobs", "steave.jobs@gmail.com"));

// partie 4
Console.WriteLine("****************************");
Staff s1 = new Staff(FirstName = "bill", LastName = "jobs", EmailAddress = "aaaaa@gmail.com");
Traveller t1 = new Traveller(FirstName = "MArk", LastName = "jobs", EmailAddress = "aaaaa@gmail.com");
p1.PssengerType();
s1.PssengerType();
t1.PssengerType();

Console.WriteLine("*************************************");
ServiceFlight sf = new ServiceFlight();

//partie 5.1
sf.Flights = TestData.
