using _18_Swagger_Employee_API_Explorer.Models;
using _18_Swagger_Employee_API_Explorer.Services;
using Microsoft.AspNetCore.Mvc;

namespace _18_Swagger_Employee_API_Explorer.Controllers
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
        public IActionResult GetAllList()
        {
            var employee = _employeeService.GetAll();
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _employeeService.Create(employee);
            return Ok("Employee Added Successfully!");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id,Employee employee)
        {
            var existingEmployee = _employeeService.GetById(id);

            if (existingEmployee == null)
            {
                return NotFound();
            }
            _employeeService.Update(id, employee);
            return Ok("Employee Updated Successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employees = _employeeService.GetById(id);

            if(employees ==null)
            {
                return NotFound();
            }

            _employeeService.Delete(id);
            return Ok("Employee deleted successfully!");
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
