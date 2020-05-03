using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        // todo: handle enums properties properly
        //public Title TitleId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        //public Gender GenderId { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [ForeignKey("PassportId")]
        public virtual Passport Passport { get; set; }
        [Required]
        public int PassportId { get; set; }

    }
}
