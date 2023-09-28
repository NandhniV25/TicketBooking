using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.Court
{
    public class CourtGroundModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CourtName { get; set; }
    }
}
