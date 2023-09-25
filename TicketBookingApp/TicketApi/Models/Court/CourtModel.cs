﻿using System.ComponentModel.DataAnnotations;
using TicketApi.Models.Ground;

namespace TicketApi.Models.Court
{
    public class CourtModel
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string CourtName { get; set; }
        [Required]
        public int GroundId { get; set; }
    }
}
