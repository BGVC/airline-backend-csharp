using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.Models
{
    public class Passport
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [ForeignKey("CountryOfIssueId")]
        public virtual Country CountryOfIssue { get; set; }
        public int CountryOfIssueId { get; set; }
        [ForeignKey("CitizenshipCountryId")]
        public virtual Country CitizenshipCountry { get; set; }
        public int CitizenshipCountryId { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
    }
}