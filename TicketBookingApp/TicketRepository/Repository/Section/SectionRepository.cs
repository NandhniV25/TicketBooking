using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Data;
using TicketRepository.Entity.Section;

namespace TicketRepository.Repository.Section
{
    public class SectionRepository : ISectionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SectionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateSection(SectionEntity entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }

        public List<SectionEntity> GetAll()
        {
            return _dbContext.Sections.ToList();
        }

        public SectionEntity GetById(int id)
        {
            return _dbContext.Sections.FirstOrDefault(x => x.Id == id);
        }

        public List<SectionEntity> GetSectionById(int id)
        {
            return _dbContext.Sections.Where(x => x.CourtId == id).ToList();
        }
    }
}
