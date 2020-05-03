using BGVC.Airline.Backend.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.DTO
{
    public class BookingDto
    {
        public PassengerDto Passenger { get; set; }
        public FlightDetailsDto DepartureFlight { get; set; }
        // todo: check how add optional and mandatory annotations on dto properties
        public FlightDetailsDto ReturnFlight { get; set; }
    }
}