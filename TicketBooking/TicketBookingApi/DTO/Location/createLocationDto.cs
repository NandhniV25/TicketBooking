using System.ComponentModel.DataAnnotations;

namespace TicketBookingApi.DTO.Location
{
    public class CreateLocationDto
    {
        [Required]
        public string cityName { get; set; } = string.Empty;
    }
}
