using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class IsoRegion
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(16)]
        public string Code { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}
