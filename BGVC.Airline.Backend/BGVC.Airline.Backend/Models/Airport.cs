using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BGVC.Airline.Backend.Models
{
    public class Airport
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [ForeignKey("AirportType")]
        public int TypeId { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        public int LatitudeDegrees { get; set; }
        public int LongitudeDegrees { get; set; }
        public int ElevationFeet { get; set; }
        public int MunicipalityId { get; set; }
        public Municipality Municipality { get; set; }
    }
}
