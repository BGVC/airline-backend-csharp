using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.DTO
{
    public class FlightSearchResultsDto
    {
        public List<FlightDto> DepartingFlights { get; set; }
        public List<FlightDto> ReturningFlights { get; set; }
    }
}
