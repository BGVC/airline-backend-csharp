using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(2)] public string Iso { get; set; }
        [MaxLength(64)] public string Name { get; set; }
        [MaxLength(64)] public string PrintableName { get; set; }
        [MaxLength(3)] public string Iso3 { get; set; }
        [MaxLength(3)] public string NumCode { get; set; }
        [MaxLength(4)] public string PhoneCode { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
