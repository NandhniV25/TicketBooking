using System.ComponentModel.DataAnnotations;

namespace TicketBookingApi.Models
{
    public class Ground
    {
        [Key] 
        public int GroundId { get; set; }

        [Required] 
        public string GroundName { get; set; }   

        // set foreign key
        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
