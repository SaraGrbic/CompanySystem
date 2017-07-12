using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.BussinesLaye.IServices
{
    public interface ICompanySystemService
    {
        List<Department> GetAllDepartments();
       
        SelectListItem GetDepartmantsDropDownList();
     
      
        void AddNewDepartmentWeb(string name, string description, int? managerId);
    
        Department FindDepartment(int? id);
      
        void EditDepartment(int id, string name, string description, int? managerId, bool isDepartmentActive);


        void DepartmentCancelation(int departmentId);

            }

}
