using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend
{
    public class Initialize
    {
        // TODO: VC -> BG: This should be deleted this because we have it in startup 

        public static AirlineDBContext GetContext()
        {
            var connectionString = @"Server=localhost\MSSQLSERVER01;Database=Airline;Integrated Security=True";
            var options = new DbContextOptionsBuilder<AirlineDBContext>();
            options.UseSqlServer(connectionString);
            return new AirlineDBContext(options.Options);
        }
    }
}
