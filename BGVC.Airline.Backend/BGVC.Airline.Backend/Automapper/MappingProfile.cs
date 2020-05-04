﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BGVC.Airline.Backend.DTO;
using BGVC.Airline.Backend.Models;

namespace BGVC.Airline.Backend.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AirplaneType, AirplaneTypeDto>();
            CreateMap<LuggageOption, LuggageOptionDto>();
            CreateMap<FlightExtraOption, FlightExtraOptionDto>();
            CreateMap<AirplaneType, AirplaneTypeDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<AirlineCompany, AirlineCompanyDto>()
                .ForMember(company => company.CountryName, opt => opt.MapFrom(s => s.Country.Name));
            CreateMap<Airport, AirportMinimalDto>()
                .ForMember(airport => airport.City, opt => opt.MapFrom(s => s.Municipality.Name))
                .ForMember(airport => airport.Abbreviation, opt => opt.MapFrom(s => s.Code));
            CreateMap<Airport, AirportDto>()
                .ForMember(airport => airport.City, opt => opt.MapFrom(s => s.Municipality.Name))
                .ForMember(airport => airport.Country, opt => opt.MapFrom(s => s.Municipality.IsoRegion.Country.Name))
                .ForMember(airport => airport.Abbreviation, opt => opt.MapFrom(s => s.Code));

            CreateMap<Flight, FlightDto>()
                .ForMember(flight => flight.DepartureAirport, 
                            opt => opt.MapFrom(s => s.DepartureAirport))
                .ForMember(flight => flight.ArrivalAirport,
                            opt => opt.MapFrom(s => s.DestinationAirport));
            CreateMap<PassengerDto, Passenger>()
                .ForMember(passenger => passenger.Passport,
                    opt => opt.MapFrom(s => s.Passport));
            CreateMap<PassportDto, Passport>();

            CreateMap<ReservationDto, Reservation>();
        }       
    }
}
    