using BGVC.Airline.Backend.Models;
using System.Collections.Generic;

namespace BGVC.Airline.Backend.Persistence.Interfaces
{
    public interface IPassengerRepository
    {
        Passenger GetByPassportNumber(string passportNumber);
    }
}