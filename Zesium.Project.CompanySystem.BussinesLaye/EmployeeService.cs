using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.BussinesLaye.IServices;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.BussinesLaye
{
    public class EmployeeService:IEmployeeService
    {
        public List<User> GetEmployeeManagers(int employeeId)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Users.Where(x => x.Id == employeeId && x.UserType == UserType.Manager).ToList();
            }
        }
        public List<User> GetAllEmployeesFromManagerDepartment(int departmentId)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Users.Where(x => x.DepartmentId == departmentId && x.UserType == UserType.Employee).ToList();

            }
        }
        public List<User> GetAllUsers()
        {
            using (var db = new CompanyDbContext())
            {
                return db.Users.ToList();
            }
        }
        
        public void PromoteEmployeeToManager(int id, Department department)
        {
            using (var db = new CompanyDbContext())
            {
                var user = db.Users.SingleOrDefault(x => x.Id == id);
                if (user == null)
                {
                    throw new Exception("Employee with given Id does not exist");
                }
                user.DepartmentId = department.Id;
                user.UserType = UserType.Manager;

                db.SaveChanges();

            }

        }
        public List<ProjectClass.Project> GetAllProjectsFromEmployee(int id)
        {
            using (var db = new CompanyDbContext())
            {
                var user = db.Users.Where(x => x.Id == id).Include(x => x.EmployeeProjects).Include(d => d.Department).SingleOrDefault();
                if(user==null)
                {
                    throw new Exception("User with provided ID does not exist");
                }
                return user.EmployeeProjects.ToList();
            }
        }
        public void UpdateUsersWhenDepartmentIsCanceled(int departmentId)
        {
            using (var db = new  CompanyDbContext())
            {
                var users = db.Users.Where(x => x.DepartmentId == departmentId).ToList();

                users.ForEach(x => x.DepartmentId = 0);
                db.SaveChanges();
            }
        }



    }
}
