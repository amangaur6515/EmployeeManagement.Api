using EmployeeManagement.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees=new List<Employee>()
        {
                new Employee{EmployeeId = 1,FirstName="Aman",LastName="Gaur",Department="Technology"},
                new Employee{EmployeeId = 2,FirstName="John",LastName="Doe",Department="IT"},
                new Employee{EmployeeId = 3,FirstName="Sam",LastName="Altman",Department="Operations"},
                new Employee{EmployeeId = 4,FirstName="Jeff",LastName="Stark",Department="Sales"},
        };
        public EmployeeController()
        {
            
        }

        [HttpGet]
        public IActionResult Employees()
        {
            
            return Ok(_employees);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            if (employee != null)
            {
                _employees.Add(employee);
            }
            return Ok(employee);

        }
    }
}
