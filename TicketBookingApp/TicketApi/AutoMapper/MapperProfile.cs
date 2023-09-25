using AutoMapper;
using TicketApi.Models.City;
using TicketApi.Models.Court;
using TicketApi.Models.Ground;
using TicketRepository.Entity.City;
using TicketRepository.Entity.Court;
using TicketRepository.Entity.Ground;

namespace TicketApi.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CityModel, CityEntity>().ReverseMap();    
            CreateMap<CreateCityModel, CityEntity>().ReverseMap();
            CreateMap<GroundModel, GroundEntity>().ReverseMap();
            CreateMap<CreateGroundModel, GroundEntity>().ReverseMap();
            CreateMap<CourtModel, CourtEntity>().ReverseMap();
            CreateMap<CreateCourtModel,  CourtEntity>().ReverseMap();
        }
    }
}
