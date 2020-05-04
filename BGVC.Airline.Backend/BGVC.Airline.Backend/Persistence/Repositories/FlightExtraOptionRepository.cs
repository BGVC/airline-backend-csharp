using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Repositories
{
    public class FlightExtraOptionRepository : IFlightExtraOptionRepository
    {
        private readonly AirlineDBContext _dbContext;

        public FlightExtraOptionRepository(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<FlightExtraOption> GetAll()
        {
            return _dbContext.FlightExtraOptions.ToList();
        }
    }
}
