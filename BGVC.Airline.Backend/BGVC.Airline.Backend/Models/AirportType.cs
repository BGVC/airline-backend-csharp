using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class AirportType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }
        public virtual ICollection<Airport> Airports { get; set; }
    }
}
