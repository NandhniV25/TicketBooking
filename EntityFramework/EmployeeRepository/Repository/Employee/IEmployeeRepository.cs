using EmployeeRepository.Entity.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository.Repository.Employee
{
    public interface IEmployeeRepository
    {
        List<EmployeeEntity> GetAll();
        int SaveEmployee(EmployeeEntity entity);
        void DeleteEmployee(int id);
        EmployeeEntity GetEmployeeById(int id);
    }
}
