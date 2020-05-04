using BGVC.Airline.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Interfaces
{
    public interface IAirportRepository
    {
        List<Airport> GetAll();
    }
}
