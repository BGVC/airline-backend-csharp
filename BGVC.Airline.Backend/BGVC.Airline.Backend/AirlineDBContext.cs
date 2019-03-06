using BGVC.Airline.Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend
{
    public class AirlineDBContext : DbContext
    {
        public AirlineDBContext(DbContextOptions<AirlineDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        internal void EnsureSeedDataForContext()
        {
            throw new NotImplementedException();
        }
    }
}
