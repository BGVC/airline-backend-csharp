using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BGVC.Airline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public BookingInitialStepChoiceDto GetBookingInitialStepChoice()
        {
            return _bookingService.GetBookingInitialStepChoice();
        }

        [HttpPost("get-flights")]
        public FlightSearchResultsDto GetAvailableFlights(BookingInitialStepSelectionDto flightSelectionOptions)
        {
            return _bookingService.GetAvailableFlights(flightSelectionOptions);
        }

        [HttpGet("options")]
        public ReservationOptionsDto GetAvailableReservationOptions()
        {
            return _bookingService.GetAvailableReservationOptions();
        }

        [HttpPost]
        public List<ReservationDto> ReserveFlightsForPassenger([NotNull] BookingDto bookingDto)
        {
            return _bookingService.ReserveFlightsForPassenger(bookingDto);
        }
    }
}