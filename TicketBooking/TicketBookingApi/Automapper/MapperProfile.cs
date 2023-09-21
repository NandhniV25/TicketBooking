using AutoMapper;
using TicketBookingApi.DTO.Location;
using TicketBookingApi.Models;

namespace TicketBookingApi.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Location, createLocationDto>().ReverseMap();
        }
    }
}
