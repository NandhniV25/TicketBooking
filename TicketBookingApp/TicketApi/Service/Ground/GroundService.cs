using AutoMapper;
using TicketApi.Models.City;
using TicketApi.Models.Ground;
using TicketRepository.Entity.Ground;
using TicketRepository.Repository.City;
using TicketRepository.Repository.Ground;

namespace TicketApi.Service.Ground
{
    public class GroundService : IGroundService
    {
        private readonly IGroundRepository _groundRepository;
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;
        public GroundService(IGroundRepository groundRepository, IMapper mapper, ICityRepository cityRepository)
        {
            _groundRepository = groundRepository;
            _mapper = mapper;
            _cityRepository = cityRepository;
        }
        public int CreateGround(CreateGroundModel model)
        {
            return _groundRepository.CreateGround(_mapper.Map<GroundEntity>(model));
        }

        //public List<GroundModel> GetAll()
        //{
        //    var entities = _groundRepository.GetAll();
        //    var models = _mapper.Map<List<GroundModel>>(entities);
        //    foreach ( var entity in models )
        //    {
        //        var cityEntity = _cityRepository.GetCityById(entity.CityId);
        //        entity.CityName = cityEntity.CityName;
        //        entity.State = cityEntity.State;//
        //    }
        //    return models;
        //}
        public List<GroundModel> GetAll()
        {
            var entities = _groundRepository.GetAll();
            var models = new List<GroundModel>();
            foreach (var entity in entities)
            {
                var cityEntity = _cityRepository.GetCityById(entity.CityId);
                var cityModel = _mapper.Map<CityModel>(cityEntity);
                var groundModel = _mapper.Map<GroundModel>(entity);
                groundModel.City = cityModel;
                models.Add(groundModel);
            }
            return models;
        }
    }
}
