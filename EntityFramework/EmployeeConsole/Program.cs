using EmployeeRepository.Data;
using EmployeeRepository.Repository.Employee;

namespace EmployeeConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            DesignTimeDbContextFactory designTimeDbContextFactory = new DesignTimeDbContextFactory();
            ApplicationDbContext dbContext = designTimeDbContextFactory.CreateDbContext(args);
            IEmployeeRepository employeeRepository = new 
                EmployeeRepository.Repository.Employee.EmployeeRepository(dbContext);
            var employees = employeeRepository.GetAll();
            foreach ( var employee in employees )
            {
                Console.WriteLine( employee.Id + " " + employee.EmpName );
            }
        }
    }
}
