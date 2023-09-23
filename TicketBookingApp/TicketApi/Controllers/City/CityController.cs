using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Models.City;
using TicketApi.Service.City;

namespace TicketApi.Controllers.City
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
             _cityService = cityService;
        }

        [HttpGet]
        public ActionResult<List<CityModel>> GetAll()
        {
            return _cityService.GetAll();
        }
        [HttpPost]
        public ActionResult<int> CreateCity(CreateCityModel model)
        {
            return _cityService.CreateCity(model);
        }
    }
}
