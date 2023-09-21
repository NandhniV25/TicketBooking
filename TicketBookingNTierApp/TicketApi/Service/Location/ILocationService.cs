using TicketApi.Models.Location;

namespace TicketApi.Service.Location
{
    public interface ILocationService
    {
        int CreateLocation(CreateLocation createLocation);
        List<TicketApi.Models.Location.Location> GetAllLocations();
    }
}
