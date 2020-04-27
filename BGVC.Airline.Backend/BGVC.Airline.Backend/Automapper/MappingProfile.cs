using System;
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
            CreateMap<AirlineCompany, AirlineCompanyDto>();
            CreateMap<Airport, AirportDto>()
                .ForMember(airport => airport.City, opt => opt.MapFrom(s => s.Municipality.Name))
                .ForMember(airport => airport.Country, opt => opt.MapFrom(s => s.Municipality.IsoRegion.Country.Name))
                .ForMember(airport => airport.Abbreviation, opt => opt.MapFrom(s => s.Code));

            CreateMap<Flight, FlightDto>()
                .ForMember(flight => flight.DepartureAirport, 
                            opt => opt.MapFrom(s => s.DepartureAirport));
        }       
    }
}
    