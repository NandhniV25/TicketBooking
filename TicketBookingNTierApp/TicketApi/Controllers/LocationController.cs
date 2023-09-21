using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Models.Location;
using TicketApi.Service.Location;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        [HttpPost]
        public ActionResult<int> Create([FromBody] CreateLocation location)
        {
            var result = _locationService.CreateLocation(location);
            return Ok(result);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Location>> GetAll()
        {
            var result = _locationService.GetAllLocations();
            return Ok(result);
        }
    }
}
