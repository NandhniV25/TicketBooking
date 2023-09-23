using TicketApi.Models.City;

namespace TicketApi.Service.City
{
    public interface ICityService
    {
        List<CityModel> GetAll();
        int CreateCity(CreateCityModel model);
    }
}
