using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models; 
namespace Infrastructure.Services
{
    public class ExperienceService
    {
        List<Experience> experiences;
        public List<Experience> GetExperiences()
        {
            return experiences;
        }
        public void AddExperience(Experience employee)
        {
            experiences.Add(employee);
        }
        public void Update(Experience experience, int id)
        {
            var rol = experiences.Find(x => x.Id == id);
            rol.Id = experience.Id;
            rol.Name = experience.Name;
            rol.Description = experience.Description;
            rol.Company = experience.Company;
            rol.EmployeeId = experience.employeeld;

        }
        public Experience GetExperienceById(int id)
        {
            var exper = experiences.Find(x => x.Id == id);
            return exper;
        }
        public void DeleteExperience(int id)
        {
            var rol = experiences.Find(x => x.Id == id);
            experiences.Remove(rol);
        }
        public int CountExperiences()
        {
            return (int)experiences.Count();
        }
    }
}
