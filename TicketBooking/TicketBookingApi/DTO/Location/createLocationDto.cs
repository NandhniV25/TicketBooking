﻿using System.ComponentModel.DataAnnotations;

namespace TicketBookingApi.DTO.Location
{
    public class createLocationDto
    {
        [Required]
        public string cityName { get; set; } = string.Empty;
    }
}
