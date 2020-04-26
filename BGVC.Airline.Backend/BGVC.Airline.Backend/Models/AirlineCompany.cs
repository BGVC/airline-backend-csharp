using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class AirlineCompany
    {
        public int Id { get; set; }
        [Required, MaxLength(512)]
        public string Name { get; set; }
        public Country Country { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}
