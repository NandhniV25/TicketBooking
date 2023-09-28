using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Court;

namespace TicketRepository.Repository.Court
{
    public interface ICourtRepository
    {
        List<CourtEntity> GetAll();
        int CreateCourt(CourtEntity entity);
        List<CourtEntity> GetCourtById(int id);
        CourtEntity GetById(int id);
    }
}
