﻿using System.ComponentModel.DataAnnotations;
using TicketApi.Models.City;
using TicketApi.Models.Court;

namespace TicketApi.Models.Ground
{
    public class GroundModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string GroundName { get; set; }
        [Required]
        public CityModel City { get; set; }
        
    }
}
