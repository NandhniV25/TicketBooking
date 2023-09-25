using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.Section
{
    public class CreateSectionModel
    {
        [Required]
        public string SectionName { get; set; }
        [Required]
        public int Rows { get; set; }
        [Required]
        public int Columns { get; set; }
        [Required]
        public int CourtId { get; set; }
    }
}
