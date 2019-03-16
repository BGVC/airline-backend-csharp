using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class Municipality
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int IsoRegionId { get; set; }
        public virtual IsoRegion IsoRegion { get; set; }
        public virtual ICollection<Airport> Airports { get; set; }
    }
}
