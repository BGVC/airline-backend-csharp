using BGVC.Airline.Backend.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace BGVC.Airline.Backend.DTO
{
    public class FlightDto
    {
        public AirportDto DepartureAirport { get; set; }
        public AirportDto ArrivalAirport { get; set; }
        // todo: Show the local time in the corresponding country and also get precise flight duration information
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string AirplaneNumber { get; set; }
        public AirplaneTypeDto AirplaneType { get; set; }
        public decimal Price { get; set; }
        public int FlightDirectionId { get; set; }
        public AirlineCompanyDto Company { get; set; }
    }
}