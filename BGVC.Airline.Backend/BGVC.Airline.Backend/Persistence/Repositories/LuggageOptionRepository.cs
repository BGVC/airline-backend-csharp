using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Repositories
{
    public class LuggageOptionRepository : ILuggageOptionRepository
    {
        private readonly AirlineDBContext _dbContext;

        public LuggageOptionRepository(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<LuggageOption> GetAll()
        {
            return _dbContext.LuggageOptions.ToList();
        }
    }
}
