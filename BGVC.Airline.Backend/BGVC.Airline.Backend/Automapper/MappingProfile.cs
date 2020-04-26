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
            CreateMap<Flight, FlightDto>();
        }       
    }
}
