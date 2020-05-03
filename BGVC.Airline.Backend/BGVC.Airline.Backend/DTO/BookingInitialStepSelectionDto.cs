using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Models;
using System;

namespace BGVC.Airline.Backend.DTO
{
    public class BookingInitialStepSelectionDto
    {
        public int DepartureAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public int TripTypeId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int FlightClassId { get; set; }
    }
}