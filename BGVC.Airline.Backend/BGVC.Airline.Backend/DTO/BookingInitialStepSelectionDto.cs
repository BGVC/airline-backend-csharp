using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Models;
using System;

namespace BGVC.Airline.Backend.Controllers
{
    public class BookingInitialStepSelectionDto
    {
        public int DepartureAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public TripType TripType { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public TravelClass FlightClass { get; set; }
    }
}