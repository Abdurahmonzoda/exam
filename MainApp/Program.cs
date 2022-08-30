using Domain.Models;
using Infrastructure.Services; 
var dep1 = new Department() ;
dep1.Id = 1;
dep1.Name = "IT";
dep1.Description = "helloIT";

var dep2 = new Department(); 
dep2.Id = 2;
dep2.Name = "HR";
dep2.Description = "helloHR";

var dep3 = new Department() ;
dep3.Id = 3;
dep3.Name = "Accounting";
dep3.Description = "hellAccounting";

List<Role> roles1  = new List<Role>();
var rol1 = new Role();
rol1.Id = 1;
rol1.Name = "user";
rol1.Description = "hellouser";

var rol2 = new Role();
rol2.Id = 2;
rol2.Name = "hr";
rol2.Description = "hellohr";

var rol3 = new Role();
rol3.Id = 3;
rol3.Name = "Accounting";
rol3.Description = "hellAccounting";

var rol4 = new Role();
rol4.Id = 4;
rol4.Name = "it";
rol4.Description = "hellit";

roles1.Add(rol1); 
roles1.Add(rol2);
var roles2 = new List<Role>();
roles2.Add(rol3);
roles2.Add(rol4);
var experienc1 = new Experience();
experienc1.Id = 1;
experienc1.Name = "Alif";
experienc1.Description = "helloAlif";

var experienc2 = new Experience();
experienc2.Id = 1;
experienc2.Name = "Mohir";
experienc2.Description = "helloMohir";
List<Experience> experiences = new List<Experience>();
experiences.Add(experienc1); 
experiences.Add(experienc2);
var empl1 = new Employee
{
    Id = 1,
    FirsName = "Safar",
    LastName = "Abdurahmonzoda",
    BirthDate = DateTime.Now,
    Address = "Firdavsi",
    Phone = "949290000",
    Department = dep1,
    Roles = roles1,
    Experiences = experiences 
};
var empl2= new Employee
{
    Id = 1,
    FirsName = "Muhammad",
    LastName = "Mirzoev",
    BirthDate = DateTime.Now,
    Address = "Firdavsi",
    Phone = "949290000",
    Department = dep2,
    Roles = roles2,
    Experiences = experiences
};
var empl3 = new Employee
{
    Id = 1,
    FirsName = "Jahonzeb",
    LastName = "Jahonzoda",
    BirthDate = DateTime.Now,
    Address = "Firdavsi",
    Phone = "949290000",
    Department = dep1,
    Roles = roles1,
    Experiences = experiences
};

var empl4 = new Employee
{
    Id = 1,
    FirsName = "Sunnatulloi",
    LastName = "Zafar",
    BirthDate = DateTime.Now,
    Address = "Firdavsi",
    Phone = "949290000",
    Department = dep2,
    Roles = roles2,
    Experiences = experiences
};

var empl5 = new Employee
{
    Id = 1,
    FirsName = "Fariz",
    LastName = "Safarov",
    BirthDate = DateTime.Now,
    Address = "Firdavsi",
    Phone = "949290000",
    Department = dep1,
    Roles = roles1,
    Experiences = experiences
};
List< Employee> employees = new List<Employee>();
employees.Add(empl1);
employees.Add(empl2);
employees.Add(empl3);
employees.Add(empl4);
employees.Add(empl5);
foreach (var employee in employees)
{
    Console.WriteLine(new string(c: '*', 50)); 
    Console.WriteLine(employee.FirsName + " " + employee.LastName);
    Console.Write("Experiences : ");
    foreach(var dep in employee.Experiences)
    {
        Console.Write(dep.Name + " ");
    }
    Console.WriteLine();
    Console.Write("Rolles : ");
    foreach(var rol in employee.Roles)
    {
        Console.Write(rol.Name + " ");
    }
    Console.WriteLine(); 

}



