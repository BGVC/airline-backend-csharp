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
using Microsoft.EntityFrameworkCore;

namespace BGVC.Airline.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BookingController(IMapper mapper)
        {
            _mapper = mapper;
        }

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
                        //&& flight.DestinationAirport.Id == flightSelectionOptions.DestinationAirportId
                        && flight.DepartureTime.Date == flightSelectionOptions.DepartureDate.Date)
                    .ToList();

                var airport = context.Airports
                    .Include(airport => airport.Municipality)
                        .ThenInclude(municipality => municipality.IsoRegion)
                            .ThenInclude(isoRegion => isoRegion.Country)
                    .First(airport => airport.Id == 1);

                var airportDto = _mapper.Map<Airport, AirportDto>(airport);

                var departingFlightDtos = new List<FlightDto>();
                var flight = _mapper.Map<Flight, FlightDto>(availableDepartingFlights.First());
                departingFlightDtos.ForEach(x => x.FlightDirectionId = (int)FlightDirection.Departure);
                flightSearchResultsDto.DepartingFlights = departingFlightDtos;

                var availableReturningFlights = context.Flights
                    .Where(flight =>
                        flight.DepartureAirport.Id == flightSelectionOptions.DestinationAirportId
                        //&& flight.DestinationAirport.Id == flightSelectionOptions.DepartureAirportId
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