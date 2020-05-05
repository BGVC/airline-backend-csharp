using BGVC.Airline.Backend.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public AirlineDBContext _dbContext { get; set; }
        public UnitOfWork(AirlineDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
