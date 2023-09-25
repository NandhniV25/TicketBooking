using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Data;
using TicketRepository.Entity.Court;

namespace TicketRepository.Repository.Court
{
    public class CourtRepository : ICourtRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CourtRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateCourt(CourtEntity entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        public List<CourtEntity> GetAll()
        {
            return _dbContext.Courts.ToList();
        }
    }
}
