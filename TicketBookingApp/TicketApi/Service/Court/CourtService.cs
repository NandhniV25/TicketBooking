using AutoMapper;
using System.Net.WebSockets;
using TicketApi.Models.City;
using TicketApi.Models.Court;
using TicketApi.Models.Ground;
using TicketApi.Models.Section;
using TicketRepository.Entity.Court;
using TicketRepository.Entity.Ground;
using TicketRepository.Repository.City;
using TicketRepository.Repository.Court;
using TicketRepository.Repository.Ground;
using TicketRepository.Repository.Section;

namespace TicketApi.Service.Court
{
    public class CourtService : ICourtService
    {
        private readonly ICourtRepository _courtRepository;
        private readonly IMapper _mapper;

        private readonly IGroundRepository _groundRepository;
        private readonly ICityRepository _cityRepository;
        private readonly ISectionRepository _sectionRepository;
        public CourtService(ICourtRepository courtRepository, IMapper mapper, IGroundRepository groundRepository, ICityRepository cityRepository, ISectionRepository sectionRepository)
        {
            _courtRepository = courtRepository; 
            _mapper = mapper;
            _groundRepository = groundRepository;
            _cityRepository = cityRepository;
            _sectionRepository = sectionRepository;
        }
        public int CreateCourt(CreateCourtModel model)
        {
            return _courtRepository.CreateCourt(_mapper.Map<CourtEntity>(model));
        }

        public List<CourtModel> GetAll()
        {
            var entities = _courtRepository.GetAll();
            var courtLists = new List<CourtModel>();
            foreach (var entity in entities)
                {
                      var groundEntity = _groundRepository.GetGroundById(entity.GroundId);
                      var cityEntity = _cityRepository.GetCityById(groundEntity.CityId);
                      var cityModel = _mapper.Map<CityModel>(cityEntity);
                      var groundModel = _mapper.Map<GroundModel>(groundEntity);
                      groundModel.City = cityModel;
                      var courtModel = _mapper.Map<CourtModel>(entity);
                      courtModel.Ground = groundModel;
                      courtLists.Add(courtModel);
                   }
            return courtLists; 
        }

        public CourtSectionModel GetById(int id)
        {
            var courtEntity = _courtRepository.GetById(id);
            var courtModel = _mapper.Map<CourtSectionModel>(courtEntity);

            var groundEntity = _groundRepository.GetGroundById(courtEntity.GroundId);
            var groundModel = _mapper.Map<GroundModel>(groundEntity);

            var cityEntity = _cityRepository.GetCityById(groundModel.City.Id);
            var cityModel = _mapper.Map<CityModel>(cityEntity);

            var sectionEntity = _sectionRepository.GetSectionById(courtEntity.Id);
            var sectionModel = _mapper.Map<List<SectionModel>>(sectionEntity);

            groundModel.City = cityModel;
            courtModel.Ground = groundModel;
            courtModel.Sections = sectionModel;

            return courtModel;
        }
    }
}
