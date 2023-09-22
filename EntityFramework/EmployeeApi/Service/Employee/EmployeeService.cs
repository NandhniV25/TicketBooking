using AutoMapper;
using EmployeeApi.Models.Employee;
using EmployeeRepository.Repository.Employee;

namespace EmployeeApi.Service.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public List<EmployeeModel> GetAll()
        {
            var employees = _employeeRepository.GetAll();
            var emp = _mapper.Map<List<EmployeeModel>>(employees);
            return emp;
        }
    }
}
