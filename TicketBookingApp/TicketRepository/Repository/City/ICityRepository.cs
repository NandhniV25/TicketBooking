using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.City;

namespace TicketRepository.Repository.City
{
    public interface ICityRepository
    {
        List<CityEntity> GetAll();
        int CreateCity(CityEntity city);
    }
}
