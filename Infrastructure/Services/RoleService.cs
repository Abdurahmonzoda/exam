using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models; 
namespace Infrastructure.Services
{
    public class RoleService
    {
        List<Role> roles;
        public List<Role> GetRoles()
        {
            return roles;
        }
        public void AddRole(Role employee )
        {
            roles.Add(employee);
        }
        public void Update(Role Role, int id)
        {
            var rol = roles.Find(x => x.Id == id);
            rol.Id = Role.Id;
            rol.Name = Role.Name;
            rol.Description = Role.Description;
            rol.Company = Role.Company;
            rol.EmployeeId = Role.EmployeeId;

        }
        public Role GetRoleById(int id)
        {
            var rol = roles.Find(x => x.Id == id);
            return rol; 
        }
        public void DeleteRole(int id)
        {
            var rol = roles.Find(x => x.Id == id);
            roles.Remove(rol);
        }
        public int CountRoles()
        {
            return (int)roles.Count();
        }


    }
}
