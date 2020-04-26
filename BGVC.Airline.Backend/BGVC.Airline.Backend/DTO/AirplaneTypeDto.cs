using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.DTO
{
    public class AirplaneTypeDto
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}
