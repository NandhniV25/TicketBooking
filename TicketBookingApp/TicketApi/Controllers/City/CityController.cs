using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Models.City;

namespace TicketApi.Controllers.City
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<CityModel>> GetAll()
        {
            var l = new List<CityModel>();
            return l;
        }
        [HttpPost]
        public ActionResult<int> CreateCity(CreateCityModel model)
        {
            return Ok(model);
        }
    }
}
