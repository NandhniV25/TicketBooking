using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.Ground;

namespace TicketRepository.Repository.Ground
{
    public interface IGroundRepository
    {
        List<GroundEntity> GetAll();
        int CreateGround(GroundEntity entity);
    }
}
