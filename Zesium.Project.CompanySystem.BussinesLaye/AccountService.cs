using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.BussinesLaye.Repositories;
using System.Data.Entity;
using Zesium.Project.CompanySystem.BussinesLaye.Iservices;

namespace Zesium.Project.CompanySystem.BussinesLaye
{
    public class AccountService:IAccountService
    {
        public User LoginWeb(string username, string password)
        {
            using (var db= new CompanyDbContext())
            {
                User user = db.Users.Where(x => x.Username == username && x.Password == password).Include(x => x.Department).SingleOrDefault();
                if (user!= null)
                {
                    return user;
                   
                }
                throw new Exception("User does not exist");
            }
        }
        public bool Login(string username, string password)
        {
            using (var db = new CompanyDbContext())
            {
                User user = db.Users.Where(x => x.Username == username && x.Password == password).Include(x => x.Department).SingleOrDefault();
                if (user != null)
                {
                    Company.Instance.CurrentUser = user;
                    return true;
                }
                return false;
            }
        }
        public List<User> GetAllUsers()
        {
            using (var db = new CompanyDbContext())
            {
                return db.Users.ToList();
            }
        }
        public void CreateAdmin(string username, string password, string name, string lastName, DateTime dayOfBirth, Gender gender)
        {
            using (var db = new CompanyDbContext())
            {
                var user = new User
                {
                    DayOfBirth = dayOfBirth,
                    Name= name,
                    LastName= lastName,
                    Password=password,
                    Username= username,
                    Gender= gender,
                    UserType= UserType.Administrator

                };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    
        public void EditUser(int id, string name, string lastName, DateTime dayOfBirth, Gender gender, Department department)
        {
            using (var db = new CompanyDbContext())
            {
                var user = db.Users.Single(x => x.Id == id);
                if (user==null)
                {
                    throw new Exception("Specified user doesn't exist");
                }
                user.Name = name;
                user.LastName = lastName;
                user.DayOfBirth = dayOfBirth;
                user.Gender = gender;
                user.Department = department;

                db.SaveChanges();
            }
        }

        public void AddNewUser(string username, string password, string lastName, string name, DateTime dayOfBirth, Gender gender, UserType userType, int departmentId)
        {
            using (var db = new CompanyDbContext())
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                    Name = name,
                    LastName = lastName,
                    DayOfBirth = dayOfBirth,
                    Gender = gender,
                    UserType = userType,
                    DepartmentId = departmentId


                };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
