using TicketApi.Models.City;
using TicketRepository.Repository.City;

namespace TicketApi.Service.City
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
             _cityRepository = cityRepository;
        }
        public int CreateCity(CreateCityModel model)
        {
            return _cityRepository.CreateCity(model);
        }

        public List<CityModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
