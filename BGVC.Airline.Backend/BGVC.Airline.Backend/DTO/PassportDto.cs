using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.DTO
{
    public class PassportDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CountryOfIssueId { get; set; }
        public int CitizenshipCountryId { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}