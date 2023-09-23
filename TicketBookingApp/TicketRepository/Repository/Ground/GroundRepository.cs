using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Data;
using TicketRepository.Entity.Ground;

namespace TicketRepository.Repository.Ground
{
    public class GroundRepository : IGroundRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GroundRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateGround(GroundEntity entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        public List<GroundEntity> GetAll()
        {
            return _dbContext.Grounds.ToList();
        }
    }
}
