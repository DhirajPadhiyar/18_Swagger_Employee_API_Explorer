using _18_Swagger_Employee_API_Explorer.Data;
using _18_Swagger_Employee_API_Explorer.Models;

namespace _18_Swagger_Employee_API_Explorer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = _context.Employees.Find(id);

            if(employee!= null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Update(int id, Employee employee)
        {
           var existingEmployee= _context.Employees.Find(id);

            if (existingEmployee != null)
            {
                existingEmployee.FirstName= employee.FirstName;
                existingEmployee.LastName= employee.LastName;
                existingEmployee.Email= employee.Email;
                existingEmployee.PhoneNumber=employee.PhoneNumber;
                existingEmployee.Department=employee.Department;
                existingEmployee.Salary= employee.Salary;

                _context.SaveChanges();
            }


        }
    }
}
