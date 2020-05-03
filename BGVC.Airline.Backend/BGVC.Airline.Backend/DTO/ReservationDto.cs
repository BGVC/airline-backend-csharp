using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.DTO
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public PassengerDto Passenger { get; set; }
        public int FlightId { get; set; }
        public int LuggageOptionId { get; set; }
        public int FlightExtraOptionId { get; set; }
        public int FlightDirectionId { get; set; }
    }
}