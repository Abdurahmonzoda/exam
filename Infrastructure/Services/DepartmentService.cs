using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models; 
namespace Infrastructure.Services
{
    public class DepartmentService
    {
        List<Department> departments; 
        public List<Department> GetDepartments()
        {
            return departments;
        }
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }
        public void Update(Department department , int id)
        {
            var depar = departments.Find(x => x.Id == id);
            depar.Id = department.Id; 
            depar.Name = department.Name;
            depar.Description = department.Description;
        }
        public Department GetDepartmentById(int id)
        {
            var depar = departments.Find(x => x.Id == id);
            return depar; 
        }
        public void DeleteDepartment(int id)
        {
            var depar = departments.Find(x => x.Id == id);
            departments.Remove(depar); 
        }
        public int CountDepartmens()
        {
            return (int)departments.Count();
        }



    }
}
