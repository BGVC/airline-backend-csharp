using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.DTO
{
    public class CountryDto
    {
        public string Iso { get; set; }
        public string Name { get; set; }
        public string PrintableName { get; set; }
        public string Iso3 { get; set; }
        public string NumCode { get; set; }
        public string PhoneCode { get; set; }
    }
}
