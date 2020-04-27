using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.Models
{
    public class Flight
    {
        public int Id { get; set; }
        [ForeignKey("DepartureAirportId")]
        public Airport DepartureAirport { get; set; }
        public int DepartureAirportId { get; set; }
        [ForeignKey("DestinationAirportId")]
        public Airport DestinationAirport { get; set; }
        public int DestinationAirportId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string AirplaneNumber { get; set; }
        [ForeignKey("AirplaneType")]
        public int AirplaneTypeId { get; set; }
        public AirplaneType AirplaneType { get; set; }
        public AirlineCompany Company { get; set; }
        [ForeignKey("AirlineCompany")]
        public int CompanyId { get; set; }
        // todo: set decimal precision
        public decimal Price { get; set; }
    }
}