using AutoMapper;
using BGVC.Airline.Backend.Common;
using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Interfaces;
using BGVC.Airline.Backend.Models;
using BGVC.Airline.Backend.Persistence.Interfaces;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BGVC.Airline.Backend.Services
{
    public class BookingService : IBookingService
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationRepository;
        private readonly IAirportRepository _airportRepository;
        private readonly IFlightRepository _flightRepository;
        private readonly ILuggageOptionRepository _luggageOptionRepository;
        private readonly IFlightExtraOptionRepository _flightExtraOptionRepository;
        private readonly IPassengerRepository _passengerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BookingService(IMapper mapper,
            IUnitOfWork unitOfWork,
            IReservationRepository reservationRepository, 
            IAirportRepository airportRepository,
            IFlightRepository flightRepository,
            ILuggageOptionRepository luggageOptionRepository,
            IFlightExtraOptionRepository flightExtraOptionRepository,
            IPassengerRepository passengerRepository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _reservationRepository = reservationRepository;
            _airportRepository = airportRepository;
            _flightRepository = flightRepository;
            _luggageOptionRepository = luggageOptionRepository;
            _flightExtraOptionRepository = flightExtraOptionRepository;
            _passengerRepository = passengerRepository;
        }

        public BookingInitialStepChoiceDto GetBookingInitialStepChoice()
        {
            var availableAirports = _airportRepository.GetAll()
            .Select(airport => new AirportDto
                {
                    Id = airport.Id,
                    Name = airport.Name,
                    Abbreviation = airport.Code,
                    City = airport.Municipality.Name,
                    Country = airport.Municipality.IsoRegion.Country.Name
                }
            )
            .ToList();

            var availableTravelClasses = EnumHelper.GetIdName<TravelClass>();
            var tripTypes = EnumHelper.GetIdName<TripType>();

            return new BookingInitialStepChoiceDto
            {
                AvailableAirports = availableAirports,
                AvailableTravelClasses = availableTravelClasses,
                AvailableTripTypes = tripTypes
            };
        }

        public FlightSearchResultsDto GetAvailableFlights([NotNull] BookingInitialStepSelectionDto flightSelectionOptions)
        {
            var flightSearchResultsDto = new FlightSearchResultsDto();
            var availableDepartingFlights = _flightRepository
                .GetByDepartureAirportAndByDestinationAirportAndByDate(
                    flightSelectionOptions.DepartureAirportId,
                    flightSelectionOptions.DestinationAirportId,
                    flightSelectionOptions.DepartureDate.Date);

            var departingFlightDtos = _mapper.Map<List<Flight>, List<FlightDto>>(availableDepartingFlights);
            departingFlightDtos
                .ForEach(x =>
                    x.FlightDirectionId = (int)FlightDirection.Departure);

            flightSearchResultsDto.DepartingFlights = departingFlightDtos;

            var availableReturningFlights = _flightRepository
                .GetByDepartureAirportAndByDestinationAirportAndByDate(
                    flightSelectionOptions.DestinationAirportId,
                    flightSelectionOptions.DepartureAirportId,
                    flightSelectionOptions.ReturnDate.Date);

            var returningFlightDtos = _mapper.Map<List<Flight>, List<FlightDto>>(availableReturningFlights);
            returningFlightDtos
                .ForEach(x =>
                    x.FlightDirectionId = (int)FlightDirection.Return);

            flightSearchResultsDto.ReturningFlights = returningFlightDtos;

            return flightSearchResultsDto;
        }

        public ReservationOptionsDto GetAvailableReservationOptions()
        {
            var reservationOptions = new ReservationOptionsDto();
            var luggageOptions = _luggageOptionRepository.GetAll();
            var luggageOptionsDto = _mapper.Map<List<LuggageOption>, List<LuggageOptionDto>>(luggageOptions);
            var extraOptions = _flightExtraOptionRepository.GetAll();
            var extraOptionsDto = _mapper.Map<List<FlightExtraOption>, List<FlightExtraOptionDto>>(extraOptions);
            reservationOptions.LuggageOptions = luggageOptionsDto;
            reservationOptions.ExtraOptions = extraOptionsDto;

            return reservationOptions;
        }

        public ReservationDto CreateReservation(PassengerDto passenger, FlightDetailsDto returnFlightDetails)
        {
            var reservationDto = new ReservationDto
            {
                Passenger = passenger,
                FlightExtraOptionId = returnFlightDetails.FlightExtraOptionId,
                FlightId = returnFlightDetails.FlightId,
                LuggageOptionId = returnFlightDetails.LuggageOptionId
            };

            var reservation = _mapper.Map<ReservationDto, Reservation>(reservationDto);
            var existingPassenger = _passengerRepository
                .GetByPassportNumber(reservationDto.Passenger.Passport.Number);
            if (existingPassenger != null)
            {
                reservation.Passenger = existingPassenger;
            }
            else
            {
                var newPassenger = _mapper.Map<PassengerDto, Passenger>(reservationDto.Passenger);
                reservation.Passenger = newPassenger;
            }

            reservation.Number = GeneratorHelper.GetRandomAlphanumericString(6);
            _reservationRepository.Add(reservation);
            _unitOfWork.Commit();
            reservationDto.Id = reservation.Id;
            reservationDto.Number = reservation.Number;

            // todo: verify if it's more proper to once more convert database entity back to dto instead of just setting the id in request dto
            return reservationDto;
        }

        public List<ReservationDto> ReserveFlightsForPassenger(BookingDto bookingDto)
        {
            var departureFlightDetails = bookingDto.DepartureFlight;
            var departureReservation = CreateReservation(bookingDto.Passenger, departureFlightDetails);
            departureReservation.FlightDirectionId = (int)FlightDirection.Departure;
            ReservationDto returningReservation = new ReservationDto();

            var returnFlightDetails = bookingDto.ReturnFlight;
            if (returnFlightDetails != null)
            {
                returningReservation = CreateReservation(bookingDto.Passenger, returnFlightDetails);
                returningReservation.FlightDirectionId = (int)FlightDirection.Return;
            }

            return new List<ReservationDto>()
            {
                departureReservation,
                returningReservation
            };
        }
    }
}
