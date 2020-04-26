using BGVC.Airline.Backend.Common;
using BGVC.Airline.Backend.DTO;
using System;
using System.Collections.Generic;

namespace BGVC.Airline.Backend.Controllers
{
    public class BookingInitialStepChoiceDto
    {
        public List<AirportDto> AvailableAirports { get; set; }
        public List<ItemIdName> AvailableTripTypes { get; set; }
        public List<ItemIdName> AvailableTravelClasses { get; set; }
    }
}