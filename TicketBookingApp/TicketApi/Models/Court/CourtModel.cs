using System.ComponentModel.DataAnnotations;
using TicketApi.Models.Ground;
using TicketApi.Models.Section;

namespace TicketApi.Models.Court
{
    public class CourtModel
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string CourtName { get; set; }
        [Required]
        public GroundModel Ground { get; set; }
        [Required]
        public List<SectionModel> Sections { get; set; }
    }
}
