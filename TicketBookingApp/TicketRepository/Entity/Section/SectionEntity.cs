using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Court;

namespace TicketRepository.Entity.Section
{
    public class SectionEntity
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public double XOffset { get; set; }
        public double YOffset { get; set; }
        public CourtEntity Court { get; set; }      
        public int CourtId { get; set; }
    }
}
