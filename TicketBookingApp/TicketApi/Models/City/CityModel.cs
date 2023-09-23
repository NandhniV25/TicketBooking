using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.City
{
    public class CityModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; }
        [Required]
        public string State { get; set; }
    }
}
