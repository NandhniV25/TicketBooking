using EmployeeApi.Models.Employee;

namespace EmployeeApi.Service.Employee
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAll();
        int SaveEmployee(CreateEmployeeModel model);
        void DeleteEmployee(int id);
        EmployeeModel GetEmployeeId(int id);
    }
}
