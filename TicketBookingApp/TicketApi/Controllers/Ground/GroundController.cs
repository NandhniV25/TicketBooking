using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Models.Ground;
using TicketApi.Service.Ground;
using TicketRepository.Entity.Ground;

namespace TicketApi.Controllers.Ground
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroundController : ControllerBase
    {
        private readonly IGroundService _groundService;
        public GroundController(IGroundService groundService)
        {
            _groundService = groundService;
        }
        [HttpGet]
        public ActionResult<List<GroundModelWithVenues>> GetAll()
        {
            return _groundService.GetAll();
        }
        [HttpGet("{id:int}")]
        public ActionResult<GroundModelWithVenues> GetGroundById(int id)
        {
            return _groundService.GetGroundById(id);
        }
        [HttpPost]
        public ActionResult<int> CreateGround(CreateGroundModel ground)
        {
            return _groundService.CreateGround(ground);
        }

    }
}
