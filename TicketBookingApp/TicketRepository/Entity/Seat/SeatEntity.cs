using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Section;

namespace TicketRepository.Entity.Seat
{
    public class SeatEntity
    {
        public int Id { get; set; }
        public SectionEntity Section { get; set; }
        public int SectionId { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
