using System.Collections.Generic;

namespace BGVC.Airline.Backend.DTO
{
    public class ReservationOptionsDto
    {
        public List<LuggageOptionDto> LuggageOptions { get; set; }
        public List<FlightExtraOptionDto> ExtraOptions { get; set; }
    }
}