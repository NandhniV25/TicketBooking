using AutoMapper;
using TicketApi.Models.City;
using TicketRepository.Entity.City;
using TicketRepository.Repository.City;

namespace TicketApi.Service.City
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
             _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public int CreateCity(CreateCityModel model)
        {
            return _cityRepository.CreateCity(_mapper.Map<CityEntity>(model));
        }

        public List<CityModel> GetAll()
        {
            return _mapper.Map<List<CityModel>>(_cityRepository.GetAll());
        }
    }
}
