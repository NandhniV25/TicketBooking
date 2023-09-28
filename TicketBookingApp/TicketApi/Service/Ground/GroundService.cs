using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Runtime.CompilerServices;
using TicketApi.Models.City;
using TicketApi.Models.Court;
using TicketApi.Models.Ground;
using TicketRepository.Entity.Ground;
using TicketRepository.Repository.City;
using TicketRepository.Repository.Court;
using TicketRepository.Repository.Ground;

namespace TicketApi.Service.Ground
{
    public class GroundService : IGroundService
    {
        private readonly IGroundRepository _groundRepository;
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;
        private readonly ICourtRepository _courtRepository;
        public GroundService(IGroundRepository groundRepository, IMapper mapper, ICityRepository cityRepository, ICourtRepository courtRepository)
        {
            _groundRepository = groundRepository;
            _mapper = mapper;
            _cityRepository = cityRepository;
            _courtRepository = courtRepository;
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
        public List<GroundModelWithVenues> GetAll()
        {
            var entities = _groundRepository.GetAll();
            var models = new List<GroundModelWithVenues>();
            foreach (var entity in entities)
            {
                var cityEntity = _cityRepository.GetCityById(entity.CityId);
                var cityModel = _mapper.Map<CityModel>(cityEntity);

                var courtEntity = _courtRepository.GetCourtById(entity.Id);
                var courtList = _mapper.Map<List<CourtGroundModel>>(courtEntity);

                var groundModel = _mapper.Map<GroundModelWithVenues>(entity);
                
                groundModel.City = cityModel;
                groundModel.Courts = courtList;
               
                models.Add(groundModel);
            }

            return models;
        }

        public GroundModelWithVenues GetGroundById(int id)
        {
            var groundEntity = _groundRepository.GetGroundById(id);
            var groundModel = _mapper.Map < GroundModelWithVenues >(groundEntity);

            if (groundModel == null)
            {
                throw new Exception("The groundId does not exists. Please enter valid groundId.");
            }
            else
            {
                var cityEntity = _cityRepository.GetCityById(groundEntity.CityId);
                var cityModel = _mapper.Map<CityModel>(cityEntity);

                var courtEntity = _courtRepository.GetCourtById(groundEntity.Id);
                var courtList = _mapper.Map<List<CourtGroundModel>>(courtEntity);

                groundModel.City = cityModel;
                groundModel.Courts = courtList;

                return groundModel;
            }
        }
    }
}
