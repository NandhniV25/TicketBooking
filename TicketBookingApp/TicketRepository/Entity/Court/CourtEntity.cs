using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Ground;

namespace TicketRepository.Entity.Court
{
    public class CourtEntity
    {
        public int Id { get; set; }
        public string CourtName { get; set; }
        public GroundEntity Ground { get; set; }
        public int GroundId { get; set; }
    }
}
