using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using TicketBookingApi.Data;
using TicketBookingApi.DTO.Location;
using TicketBookingApi.Models;

namespace TicketBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        // Constructor 
        public LocationController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public ActionResult<Location> Create([FromBody] Location location)
        {
            _dbContext.Locations.Add(location);
            _dbContext.SaveChanges();
            return Ok();
        }

        //[HttpGet]
        //public Task<ActionResult<IEnumerable<LocationDto>>> GetAll ()
        //{
        //    return Ok();
        //}
    }
}
