namespace TicketApi.Models.Location
{
    public class Location
    {
        public Location(int id, string cityName, string state)
        {
            this.Id = id;
            this.cityName = cityName;
            this.state = state;
        }
        public int Id { get; set; }
        public string cityName { get; set; }
        public string state { get; set; }
    }
}
