using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Data;
using TicketRepository.Entity.Seat;

namespace TicketRepository.Repository.Seat
{
    public class SeatRepository : ISeatRepository
    {

        private readonly ApplicationDbContext _dbContext;
        public SeatRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SeatEntity> GetSeatsBySectionId(int secId)
        {
            return _dbContext.Seats.Where(x => x.SectionId == secId).ToList();
        }
    }
}
