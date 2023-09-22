using AutoMapper;
using EmployeeApi.Models.Employee;
using EmployeeRepository.Entity.Employee;
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
        public void DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
        }

        public List<EmployeeModel> GetAll()
        {
            var employees = _employeeRepository.GetAll();
            var emp = _mapper.Map<List<EmployeeModel>>(employees);
            return emp;
        }

        public EmployeeModel GetEmployeeId(int id)
        {
            var entity = _employeeRepository.GetEmployeeById(id);
            var emp = _mapper.Map<EmployeeModel>(entity);
            return emp;
        }

        public int SaveEmployee(CreateEmployeeModel model)
        {
            var employeeEntity = _mapper.Map<EmployeeEntity>(model);
            return _employeeRepository.SaveEmployee(employeeEntity);
        }
    }
}
