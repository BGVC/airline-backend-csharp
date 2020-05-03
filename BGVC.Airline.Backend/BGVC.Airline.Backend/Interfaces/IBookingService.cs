using BGVC.Airline.Backend.Controllers;
using BGVC.Airline.Backend.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Interfaces
{
    public interface IBookingService
    {
        public ReservationOptionsDto GetAvailableReservationOptions();
        public BookingInitialStepChoiceDto GetBookingInitialStepChoice();
        public FlightSearchResultsDto GetAvailableFlights(BookingInitialStepSelectionDto flightSelectionOptions);
        ReservationDto CreateReservation(PassengerDto passenger, FlightDetailsDto returnFlightDetails);
        public List<ReservationDto> ReserveFlightsForPassenger(BookingDto bookingDto);
    }
}
