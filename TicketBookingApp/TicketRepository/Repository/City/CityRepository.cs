using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Data;
using TicketRepository.Entity.City;

namespace TicketRepository.Repository.City
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CityRepository(ApplicationDbContext dbContext)
        {  
            _dbContext = dbContext;
        }
        public int CreateCity(CityEntity city)
        {
            _dbContext.Cities.Add(city);
            _dbContext.SaveChanges();
            return city.Id;
        }

        public List<CityEntity> GetAll()
        {
            return _dbContext.Cities.ToList();
        }

        public CityEntity GetCityById(int id)
        {
            return _dbContext.Cities.FirstOrDefault(c => c.Id == id);
        }
    }
}
