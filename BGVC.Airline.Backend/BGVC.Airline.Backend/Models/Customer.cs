using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BGVC.Airline.Backend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        // todo: handle enums properties properly
        //public Title TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public Gender GenderId { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public virtual Passport PassportNumber { get; set; }

    }
}
