using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.Court
{
    public class CreateCourtModel
    {
        [Required]
        public string CourtName { get; set; }
        [Required]
        public int GroundId { get; set; }

    }
}
