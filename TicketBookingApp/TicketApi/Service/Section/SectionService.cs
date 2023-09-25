using AutoMapper;
using TicketApi.Models.Section;
using TicketRepository.Entity.Section;
using TicketRepository.Repository.Section;

namespace TicketApi.Service.Section
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;
        public SectionService(ISectionRepository sectionRepository, IMapper mapper)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
        }
        public int CreateSection(CreateSectionModel model)
        {
            return _sectionRepository.CreateSection(_mapper.Map<SectionEntity>(model));
        }

        public List<SectionModel> GetAll()
        {
            return _mapper.Map<List<SectionModel>>(_sectionRepository.GetAll());
        }
    }
}
