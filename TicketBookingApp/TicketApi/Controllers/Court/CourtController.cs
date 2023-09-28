using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Models.Court;
using TicketApi.Models.Ground;
using TicketApi.Service.Court;

namespace TicketApi.Controllers.Court
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtController : ControllerBase
    {
        private readonly ICourtService _courtService;
        public CourtController(ICourtService courtService)
        {
            _courtService = courtService;
        }
        [HttpGet]
        public ActionResult<List<CourtModel>> GetAll()
        {
            return _courtService.GetAll();
        }
        [HttpGet("{id:int}")]
        public ActionResult<CourtModel> GetById(int id)
        {
            return _courtService.GetById(id);
        }
        [HttpPost]
        public ActionResult<int> CreateCourt(CreateCourtModel model)
        {
            return _courtService.CreateCourt(model);
        }
    }
}
