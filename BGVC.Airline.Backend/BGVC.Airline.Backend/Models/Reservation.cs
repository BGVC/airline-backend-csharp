﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BGVC.Airline.Backend.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("FlightId")]
        public virtual Flight Flight { get; set; }
        [Required]
        public int FlightId { get; set; }
        [ForeignKey("LuggageOptionId")]
        public virtual LuggageOption LuggageOption { get; set; }
        [Required]
        public int LuggageOptionId { get; set; }
        [ForeignKey("FlightExtraOptionId")]
        public virtual FlightExtraOption FlightExtraOption { get; set; }
        [Required]
        public int FlightExtraOptionId { get; set; }


    }
}