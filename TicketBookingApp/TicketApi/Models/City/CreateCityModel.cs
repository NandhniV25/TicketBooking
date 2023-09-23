using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.City
{
    public class CreateCityModel
    {
        [Required]
        public string CityName { get; set; }
        [Required]
        public string State { get; set; }
    }
}
