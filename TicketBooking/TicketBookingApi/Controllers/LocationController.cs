using AutoMapper;
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

        private readonly IMapper _mapper;

        // Constructor 
        public LocationController(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<CreateLocationDto> Create([FromBody] CreateLocationDto createLocationDto)
        {
            var location = _mapper.Map<Location>(createLocationDto);  
            _dbContext.Locations.Add(location);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
