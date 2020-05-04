using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly AirlineDBContext _dbContext;
        public FlightRepository(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Flight> GetByDepartureAirportAndByDestinationAirportAndByDate(int departureAirportId, int destinationAirportId, DateTime flightDate)
        {
            return _dbContext.Flights
                .Where(flight =>
                    flight.DepartureAirport.Id == departureAirportId
                    && flight.DestinationAirport.Id == destinationAirportId
                    && flight.DepartureTime.Date == flightDate)
                .ToList();
        }
    }
}
