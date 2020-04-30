using BGVC.Airline.Backend.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class LuggageOption
    {
        public int Id { get; set; }
        [Required, MaxLength(128)]
        public string Name { get; set; }
        [Required, MaxLength(512)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
