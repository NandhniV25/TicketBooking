using System.ComponentModel.DataAnnotations;

namespace TicketBookingApi.Models
{
    public class Location
    {
        [Key]
        public int CityId { get; set; }

        [Required]
        public string CityName { get; set; } = string.Empty;
    }
}
