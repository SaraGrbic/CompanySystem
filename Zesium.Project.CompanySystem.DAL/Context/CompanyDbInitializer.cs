using System;
using System.Collections.Generic;
using System.Data.Entity;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.DAL.Context
{
    public class CompanyDbInitializer : DropCreateDatabaseIfModelChanges<CompanyDbContext>
    {
        protected override void Seed(CompanyDbContext context)
        {

            var departmant = new Department()
            {
                Id = 0,
                Description = "Departmant koji ne moze biti uklonjen",
                IsDepartmentActive = true,
                Name = "Undefined"
             
            };


            var user1 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 1,
                Name = "Sara",
                LastName = "Grbic",
                Gender = Gender.Female,
                Password = "12345",
                Username = "admin1",
                UserType = UserType.Administrator,
                ManagerProjects = new List<ProjectClass.Project>(),
                EmployeeProjects= new List<ProjectClass.Project>()

                
            };
            var user2 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 2,
                Name = "UserName1",
                LastName = "UserLastName1",
                Gender = Gender.Female,
                Password = "12345",
                Username = "user1",
                UserType = UserType.Manager,
                ManagerProjects = new List<ProjectClass.Project>()
            };
            var user3 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 3,
                Name = "UserName2",
                LastName = "UserLastName2",
                Gender = Gender.Female,
                Password = "12345",
                Username = "user2",
                UserType = UserType.Manager,
                ManagerProjects = new List<ProjectClass.Project>()
            };
            var user4 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 4,
                Name = "UserName3",
                LastName = "UserLastName3",
                Gender = Gender.Male,
                Password = "12345",
                Username = "user3",
                UserType = UserType.Manager,
                ManagerProjects = new List<ProjectClass.Project>()
            };
            var user5 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 5,
                Name = "UserName4",
                LastName = "UserLastName4",
                Gender = Gender.Female,
                Password = "12345",
                Username = "user4",
                UserType = UserType.Employee,
                EmployeeProjects = new List<ProjectClass.Project>()
            };
            var user6 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 6,
                Name = "UserName5",
                LastName = "UserLastName5",
                Gender = Gender.Male,
                Password = "12345",
                Username = "user5",
                UserType = UserType.Employee,
                EmployeeProjects = new List<ProjectClass.Project>()
            };
            var user7 = new User
            {
                DayOfBirth = DateTime.Now.AddYears(-20),
                DepartmentId = 0,
                Id = 7,
                Name = "UserName6",
                LastName = "UserLastName6",
                Gender = Gender.Female,
                Password = "12345",
                Username = "user6",
                UserType = UserType.Employee,
                EmployeeProjects = new List<ProjectClass.Project>()
            };
            var users = new List<User>()
            {
                user1,user2,user3,user4,user5,user6,user7
            };
            
      

            context.Departmants.Add(departmant);
            context.Users.AddRange(users);
            base.Seed(context);
        }
    }
}