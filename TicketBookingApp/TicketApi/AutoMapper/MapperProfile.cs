using AutoMapper;
using TicketApi.Models.City;
using TicketRepository.Entity.City;

namespace TicketApi.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CityModel, CityEntity>().ReverseMap();    
            CreateMap<CreateCityModel, CityEntity>().ReverseMap();
        }
    }
}
