using System.ComponentModel.DataAnnotations;
using TicketApi.Models.Seat;

namespace TicketApi.Models.Section
{
    public class SectionSeatModel
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
        public double YOffset { get; set; }
        [Required]
        public int CourtId { get; set; }
        [Required]
        public List<SeatModel> Seats { get; set; }
    }
}
