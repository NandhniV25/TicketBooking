using AutoMapper.Configuration;
using EmployeeApi.Models.Employee;
using EmployeeApi.Service.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public ActionResult<List<EmployeeModel>> GetAll()
        {
            return _employeeService.GetAll();
        }

        [HttpPost]
        public ActionResult<int> SaveEmployee(CreateEmployeeModel model)
        {
            return _employeeService.SaveEmployee(model);
        }

        [HttpGet("{id:int}")]
        public ActionResult<EmployeeModel> GetEmployeeById(int id) 
        {
            return _employeeService.GetEmployeeId(id);
        }

        [HttpDelete("{id:int}")]
        public ActionResult DeleteEmployee(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var empEnity = _employeeService.GetEmployeeId(id);

            if (empEnity == null)
            {
                return NotFound();
            }

            _employeeService.DeleteEmployee(id);
            return Ok();
        }
    }
}
