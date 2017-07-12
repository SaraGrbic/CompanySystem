using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models;
using System.Data.Entity;
using System.Web.Mvc;
using Zesium.Project.CompanySystem.BussinesLaye.IServices;

namespace Zesium.Project.CompanySystem.BussinesLaye
{
    public class CompanySystemService:ICompanySystemService
    {
        public List<Department> GetAllDepartments()
        {
            using (var db = new CompanyDbContext())
            {
                return db.Departmants.ToList();
            }
        }
        public SelectListItem GetDepartmantsDropDownList()
        {
            using (var db= new CompanyDbContext())
            {
              return (SelectListItem)db.Departmants.Select(d => new SelectListItem { Text = d.Name, Value = d.Id.ToString() });
               
            }
        }
        //public Department GetDepartmentById(int id)
        //{
        //    using (var db = new CompanyDbContext())
        //    {
        //        return db.Departmants.SingleOrDefault(x => x.Id == id);
        //    }
        //}
        public void AddNewDepartmentWeb(string name, string description, int? managerId)
        {
            using (var db = new CompanyDbContext())
            {
                var departments = new Department
                {
                    Name = name,
                    Description = description,
                    ManagerId=managerId,
                    IsDepartmentActive = true

                };
                db.Departmants.Add(departments);
                db.SaveChanges();
            }
        }
        public void AddNewDepartment(string name,string description)
        {
            using (var db = new CompanyDbContext())
            {
                var departments = new Department
                {
                    Name = name,
                    Description = description,
                    IsDepartmentActive = true

                };
                db.Departmants.Add(departments);
                db.SaveChanges();
            }
        }
        public Department FindDepartment(int? id)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Departmants.Find(id);

            }
        }
        public void EditDepartment(int id, string name, string description, int? managerId, bool isDepartmentActive)
        {
            using (var db = new CompanyDbContext())
            {
                var department = db.Departmants.SingleOrDefault(x => x.Id == id);
                if (department== null)
                {
                    throw new Exception("There is no department with given id");
                }
                department.Name = name;
                department.Description = description;
                department.ManagerId = managerId;
                department.IsDepartmentActive = isDepartmentActive;

                db.SaveChanges();
            }
        }
        public void DepartmentCancelation(int departmentId)
        {
            using (var db = new CompanyDbContext())
            {
                var depatment = db.Departmants.SingleOrDefault(x => x.Id == departmentId);
                if (depatment==null)
                {
                    throw new Exception("There is no department with given id");
    
                }
                depatment.IsDepartmentActive = false;
                db.SaveChanges();



            }
        }
    }
}
