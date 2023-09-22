using EmployeeRepository.Data;
using EmployeeRepository.Entity.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepository.Repository.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<EmployeeEntity> GetAll()
        {
            return _dbContext.Employees.ToList();
        }
    }
}
