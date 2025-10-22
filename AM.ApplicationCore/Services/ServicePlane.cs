using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>,IServicePlane
    {
        //IGenericRepository<Plane> _repository;

        //public ServicePlane(IGenericRepository<Plane> repository)
        //{
        //    _repository = repository;
        //}

        IUnitOfWork unitOfWork;

        public ServicePlane(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        //public void Add(Plane P)
        //{
        //    //_repository.Add(P);
        //    unitOfWork.Repository<Plane>().Add(P);
        //}

        //public IList<Plane> GetAll()
        //{
        //   //return _repository.GetAll().ToList();
        //   return unitOfWork.Repository<Plane>().GetAll().ToList();
        //}

        //public void Save()
        //{
        //    //_repository.SubmitChanges();
        //    unitOfWork.Save();
        //}
        public List<Passenger> GetPassengers(Plane P)
        {
            return GetById(P.PlaneId).Flights
                .SelectMany(f=>f.Tickets)
                .Select(t=>t.Passenger).ToList();
        }

        public IEnumerable<IGrouping<int , Flight>> GetFlights(int n)
        {
            return GetMany().OrderByDescending(p => p.PlaneId).Take(n)
                .SelectMany(p => p.Flights)
                .OrderBy(F => F.FlightDate)
                .GroupBy(F => F.PlaneId);
        }

        public bool IsAvailablePlane(int n, Flight flight)
        {
            int cap = Get(p=>p.Flights.Contains(flight)== true).Capacity;
            int nbPassenger = flight.Tickets.Count();
            return cap >= (nbPassenger + n ) ;
        }

        public void deletePlanes()
        {
            var listPlane = GetMany().Where(p = (DateTime.Now - p.ManuFactureDate).TotalDays >= 365 * 10);
                foreach (var plane in listPlane) { 
                    Delete(plane);
            }
                Commit();
        }
    }
}
