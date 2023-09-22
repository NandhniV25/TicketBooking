using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models.Employee
{
    public class CreateEmployeeModel
    {
        [Required]
        public string EmpName { get; set; }
    }
}
