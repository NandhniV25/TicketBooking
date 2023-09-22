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

        public void DeleteEmployee(int id)
        {
            var entity = GetEmployeeById(id);
            _dbContext.Employees.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<EmployeeEntity> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public EmployeeEntity GetEmployeeById(int id)
        {
            var entity = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public int SaveEmployee(EmployeeEntity entity)
        {
            _dbContext.Employees.Add(entity);
            _dbContext.SaveChanges();
            return entity.Id;
        }
    }
}
