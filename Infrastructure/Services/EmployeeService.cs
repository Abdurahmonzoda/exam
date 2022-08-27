using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models; 
namespace Infrastructure.Services
{
    public class EmployeeService
    {
        List<Employee> employees;
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void Update(Employee employee, int id)
        {
            var depar = employees.Find(x => x.Id == id);
            depar.Id = employee.Id;
            depar.FirsName = employee.FirsName;
            depar.LastName = employee.LastName;
            depar.BirthDate = employee.BirthDate;
            depar.Address = employee.Address;
            depar.Phone = employee.Phone;
            depar.Department = employee.Department;
            depar.Roles = employee.Roles;
            depar.Experiences = employee.Experiences; 

        }
        public Employee GetEmployeeById(int id)
        {
            var depar = employees.Find(x => x.Id == id);
            return depar;
        }
        public void DeleteEmployee(int id)
        {
            var depar = employees.Find(x => x.Id == id);
            employees.Remove(depar);
        }
        public int CountDepartmens()
        {
            return (int)employees.Count();
        }

    }
}
