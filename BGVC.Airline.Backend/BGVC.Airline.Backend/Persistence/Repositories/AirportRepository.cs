using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly AirlineDBContext _dbContext;

        public AirportRepository(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // todo: VC: Does it matter if we return IEnumerable instead of List? Also, why not return IQueryable
        // Basically explain the theory (probably clean architecture theory) behind this logic:
        // We are not returning IQueryable because once results are retrieved from the database,
        // no further querying should be done (No exposing of database out of repository). Hence no usage of IQueryable.

        public List<Airport> GetAll()
        {
            return _dbContext.Airports.ToList();
        }
    }
}
