using AutoMapper;
using TicketApi.Models.City;
using TicketApi.Models.Court;
using TicketApi.Models.Ground;
using TicketApi.Models.Section;
using TicketRepository.Entity.City;
using TicketRepository.Entity.Court;
using TicketRepository.Entity.Ground;
using TicketRepository.Entity.Section;

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
            CreateMap<GroundModelWithVenues, GroundEntity>().ReverseMap();

            CreateMap<CourtModel, CourtEntity>().ReverseMap();
            CreateMap<CreateCourtModel,  CourtEntity>().ReverseMap();
            CreateMap<CourtGroundModel, CourtEntity>().ReverseMap();

            CreateMap<SectionModel, SectionEntity>().ReverseMap();
            CreateMap<CreateSectionModel, SectionEntity>().ReverseMap();
        }
    }
}
