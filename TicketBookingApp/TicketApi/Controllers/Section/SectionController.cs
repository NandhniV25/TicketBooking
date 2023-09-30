using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketApi.Models.Section;
using TicketApi.Service.Section;

namespace TicketApi.Controllers.Section
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }
        [HttpGet]
        public ActionResult<List<SectionModel>> GetAll()
        {
            return _sectionService.GetAll();
        }
        [HttpPost]
        public ActionResult<int> CreateSection(CreateSectionModel model)
        {
            return _sectionService.CreateSection(model);
        }
        [HttpGet("{id:int}")]
        public ActionResult<SectionSeatModel> GetSectionById(int id) 
        {
            return _sectionService.GetSectionById(id);
        }
    }
}
