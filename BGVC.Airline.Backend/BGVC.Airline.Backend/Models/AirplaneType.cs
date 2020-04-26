using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class AirplaneType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(512)]
        public string Manufacturer { get; set; }
        [Required]
        [MaxLength(512)]
        public string Model { get; set; }
    }
}
