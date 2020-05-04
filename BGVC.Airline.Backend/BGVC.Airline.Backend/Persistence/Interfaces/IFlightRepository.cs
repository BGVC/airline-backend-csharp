using BGVC.Airline.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Persistence.Interfaces
{
    // todo: VC: plural or singular in repository name?
    public interface IFlightRepository
    {
        List<Flight> GetByDepartureAirportAndByDestinationAirportAndByDate(int departureAirport, int destinationAirport, DateTime flightDate);
    }
}
