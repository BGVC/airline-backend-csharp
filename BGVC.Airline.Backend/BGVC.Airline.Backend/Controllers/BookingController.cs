using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BGVC.Airline.Backend.Common;
using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BGVC.Airline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IMapper _mapper;

        [HttpGet]
        public BookingInitialStepChoiceDto GetBookingInitialStepChoice()
        {
            var availableAirports = new List<AirportDto>();
            using (var context = Initialize.GetContext())
            {
                availableAirports = context.Airports
                .Select(airport => new AirportDto
                    {
                        Id = airport.Id,
                        Name = airport.Name,
                        Abbreviation = airport.Code,
                        City = airport.Municipality.Name,
                        Country = airport.Municipality.IsoRegion.Country.Name
                    }
                ).ToList();
            }

            var availableTravelClasses = EnumHelper.GetIdName<TravelClass>();
            var tripTypes = EnumHelper.GetIdName<TripType>();

            return new BookingInitialStepChoiceDto
            {
                AvailableAirports = availableAirports,
                AvailableTravelClasses = availableTravelClasses,
                AvailableTripTypes = tripTypes
            };
        }

        [HttpPost]
        public FlightSearchResultsDto GetAvailableFlights(BookingInitialStepSelectionDto flightSelectionOptions)
        {
            var flightSearchResultsDto = new FlightSearchResultsDto();

            using (var context = Initialize.GetContext())
            {
                var availableDepartingFlights = context.Flights
                    .Where(flight => 
                        flight.DepartureAirport.Id == flightSelectionOptions.DepartureAirportId
                        && flight.DestinationAirport.Id == flightSelectionOptions.DestinationAirportId
                        && flight.DepartureTime.Date == flightSelectionOptions.DepartureDate.Date)
                    .ToList();

                var departingFlightDtos = _mapper.Map<List<Flight>, List<FlightDto>>(availableDepartingFlights);
                departingFlightDtos.ForEach(x => x.FlightDirectionId = (int)FlightDirection.Departure);
                flightSearchResultsDto.DepartingFlights = departingFlightDtos;

                var availableReturningFlights = context.Flights
                    .Where(flight =>
                        flight.DepartureAirport.Id == flightSelectionOptions.DestinationAirportId
                        && flight.DestinationAirport.Id == flightSelectionOptions.DepartureAirportId
                        && flight.DepartureTime.Date == flightSelectionOptions.ReturnDate.Date)
                     .ToList();

                var returningFlightDtos = _mapper.Map<List<Flight>, List<FlightDto>>(availableReturningFlights);
                returningFlightDtos.ForEach(x => x.FlightDirectionId = (int)FlightDirection.Return);
                flightSearchResultsDto.ReturningFlights = returningFlightDtos;

                return flightSearchResultsDto;
            }
        }
    }
}