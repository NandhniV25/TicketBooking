using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Section;

namespace TicketRepository.Repository.Section
{
    public interface ISectionRepository
    {
        List<SectionEntity> GetAll();
        int CreateSection(SectionEntity entity);
        List<SectionEntity> GetSectionById(int id);
        SectionEntity GetById(int id);
    }
}
