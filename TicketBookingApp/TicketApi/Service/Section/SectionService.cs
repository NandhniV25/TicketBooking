using AutoMapper;
using System.Collections.Generic;
using TicketApi.Models.Seat;
using TicketApi.Models.Section;
using TicketRepository.Entity.Section;
using TicketRepository.Repository.Seat;
using TicketRepository.Repository.Section;

namespace TicketApi.Service.Section
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly IMapper _mapper;
        private readonly ISeatRepository _seatRepository;
        public SectionService(ISectionRepository sectionRepository, IMapper mapper, ISeatRepository seatRepository)
        {
            _sectionRepository = sectionRepository;
            _mapper = mapper;
            _seatRepository = seatRepository;
        }
        public int CreateSection(CreateSectionModel model)
        {
            return _sectionRepository.CreateSection(_mapper.Map<SectionEntity>(model));
        }

        public List<SectionModel> GetAll()
        {
            return _mapper.Map<List<SectionModel>>(_sectionRepository.GetAll());
        }

        public SectionSeatModel GetSectionById(int id)
        {
            var entity = _sectionRepository.GetById(id);
            var seatsEntity = _seatRepository.GetSeatsBySectionId(id);
            var seatModel = _mapper.Map<List<SeatModel>>(seatsEntity);
            
            var sectionSeatModel = _mapper.Map<SectionSeatModel>(entity);

            sectionSeatModel.Seats = seatModel;

            return sectionSeatModel;
        }
    }
}
