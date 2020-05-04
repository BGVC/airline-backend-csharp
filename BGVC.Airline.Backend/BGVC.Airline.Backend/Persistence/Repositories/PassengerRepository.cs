using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly AirlineDBContext _dbContext;
        public PassengerRepository(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Passenger GetByPassportNumber(string passportNumber)
        {
            return _dbContext.Passengers.FirstOrDefault(passenger =>
                passenger.Passport.Number == passportNumber);
        }
    }
}
