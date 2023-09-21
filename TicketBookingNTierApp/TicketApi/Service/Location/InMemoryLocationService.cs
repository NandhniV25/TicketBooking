using TicketApi.Models.Location;

namespace TicketApi.Service.Location
{
    public class InMemoryLocationService : ILocationService
    {
        private List<Models.Location.Location> locations { get; set; } = new List<Models.Location.Location>();  
        private int id { get; set; } = 1;
        public int CreateLocation(CreateLocation createLocation)
        {
            var cityName = createLocation.cityName;
            var state = createLocation.state;
            locations.Add(new Models.Location.Location(id, cityName, state));
            id++;
            return id-1;
        }

        public List<Models.Location.Location> GetAllLocations()
        {
            return locations;
        }
    }
}
