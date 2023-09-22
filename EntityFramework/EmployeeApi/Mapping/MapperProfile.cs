using AutoMapper;
using EmployeeApi.Models.Employee;
using EmployeeRepository.Entity.Employee;

namespace EmployeeApi.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
             CreateMap<EmployeeModel, EmployeeEntity>().ReverseMap();
        }
    }
}
