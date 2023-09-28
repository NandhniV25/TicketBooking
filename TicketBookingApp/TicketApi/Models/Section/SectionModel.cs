using System.ComponentModel.DataAnnotations;

namespace TicketApi.Models.Section
{
    public class SectionModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SectionName { get; set; }
        [Required]
        public int Rows { get; set; }
        [Required]
        public int Columns { get; set; }
        [Required]
        public double XOffset { get; set; }
        [Required] 
        public double YOffset { get; set ; }
        [Required]
        public int CourtId { get; set; }
    }
}
