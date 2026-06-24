using _18_Swagger_Employee_API_Explorer.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace _18_Swagger_Employee_API_Explorer.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee? GetById(int id);
        void Create(Employee employee);
        void Update(int id, Employee employee);
        void Delete(int id);


    }
}
