using AutoMapper;
using TicketApi.Models.Court;
using TicketRepository.Entity.Court;
using TicketRepository.Repository.Court;

namespace TicketApi.Service.Court
{
    public class CourtService : ICourtService
    {
        private readonly ICourtRepository _courtRepository;
        private readonly IMapper _mapper;
        public CourtService(ICourtRepository courtRepository, IMapper mapper)
        {
            _courtRepository = courtRepository; 
            _mapper = mapper;
        }
        public int CreateCourt(CreateCourtModel model)
        {
            return _courtRepository.CreateCourt(_mapper.Map<CourtEntity>(model));
        }

        public List<CourtModel> GetAll()
        {
            return _mapper.Map<List<CourtModel>>(_courtRepository.GetAll());  
        }
    }
}
