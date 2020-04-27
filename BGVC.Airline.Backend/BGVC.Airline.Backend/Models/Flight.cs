using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public Airport DepartureAirport { get; set; }
        [ForeignKey("Airport")]
        public int DepartureAirportId { get; set; }
        //public Airport DestinationAirport { get; set; }
        //[ForeignKey("Airport")]
        //public int DestinationAirportId { get; set; }
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