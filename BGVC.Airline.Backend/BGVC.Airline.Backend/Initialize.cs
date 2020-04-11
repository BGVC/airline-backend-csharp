using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend
{
    public class Initialize
    {
        // TODO: VC -> BG: This should be deleted this because you should use the injected AirlineDBContext context, like in CountriesController -> do that for all the other controllers

        public static AirlineDBContext GetContext()
        {
            var connectionString = @"Server=localhost;Database=Airline;Integrated Security=True";
            var options = new DbContextOptionsBuilder<AirlineDBContext>();
            options.UseSqlServer(connectionString);
            return new AirlineDBContext(options.Options);
        }
    }
}
