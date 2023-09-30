using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Seat;

namespace TicketRepository.Repository.Seat
{
    public interface ISeatRepository
    {
        List<SeatEntity> GetSeatsBySectionId(int secId);
    }
}
