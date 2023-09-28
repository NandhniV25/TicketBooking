using AutoMapper;
using TicketApi.Models.City;
using TicketApi.Models.Court;
using TicketApi.Models.Ground;
using TicketRepository.Entity.Court;
using TicketRepository.Entity.Ground;
using TicketRepository.Repository.City;
using TicketRepository.Repository.Court;
using TicketRepository.Repository.Ground;

namespace TicketApi.Service.Court
{
    public class CourtService : ICourtService
    {
        private readonly ICourtRepository _courtRepository;
        private readonly IMapper _mapper;

        private readonly IGroundRepository _groundRepository;
        private readonly ICityRepository _cityRepository;
        public CourtService(ICourtRepository courtRepository, IMapper mapper, IGroundRepository groundRepository, ICityRepository cityRepository)
        {
            _courtRepository = courtRepository; 
            _mapper = mapper;
            _groundRepository = groundRepository;
            _cityRepository = cityRepository;
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

        public CourtModel GetById(int id)
        {
            var courtEntity = _courtRepository.GetById(id);
            var courtModel = _mapper.Map<CourtModel>(courtEntity);

            var groundEntity = _groundRepository.GetGroundById(courtEntity.GroundId);
            var groundModel = _mapper.Map<GroundModel>(groundEntity);

            var cityEntity = _cityRepository.GetCityById(groundModel.City.Id);
            var cityModel = _mapper.Map<CityModel>(cityEntity);

            groundModel.City = cityModel;
            courtModel.Ground = groundModel;
            return courtModel;
        }
    }
}
