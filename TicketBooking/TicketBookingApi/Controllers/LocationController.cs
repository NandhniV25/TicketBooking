using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using TicketBookingApi.DTO.Location;
using TicketBookingApi.Models;

namespace TicketBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        [HttpPost]
        public ActionResult<createLocationDto> Create([FromBody] createLocationDto locationDto)
        {
            var location = new createLocationDto();
            return location;
        }

        //[HttpGet]
        //public Task<ActionResult<IEnumerable<LocationDto>>> GetAll ()
        //{
        //    return Ok();
        //}
    }
}
