using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.Ground
{
    public class CreateGroundModel
    {
        [Required]
        public string GroundName { get; set; }
        [Required]
        public int CityId { get; set; }
    }
}
