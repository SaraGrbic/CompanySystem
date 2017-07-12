using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;

namespace Zesium.Project.CompanySystem.Models
{
   
    public class User:Entity
    {
       
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public Gender Gender { get; set; } 

        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public UserType UserType { get; set; }

        public virtual ICollection<Project> EmployeeProjects { get; set; }
        public virtual ICollection<Project> ManagerProjects { get; set; }
        public virtual ICollection<Department> ManagerDepartmants { get; set; }

        public Department ManagerDepartmant => ManagerDepartmants.FirstOrDefault();
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }

    }
}
