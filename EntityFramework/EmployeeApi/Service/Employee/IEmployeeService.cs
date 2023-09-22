using EmployeeApi.Models.Employee;

namespace EmployeeApi.Service.Employee
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAll();
    }
}
