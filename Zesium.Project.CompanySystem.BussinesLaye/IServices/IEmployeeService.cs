using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;

namespace Zesium.Project.CompanySystem.BussinesLaye.IServices
{
    public interface IEmployeeService
    {
        List<User> GetEmployeeManagers(int employeeId);
     
        List<User> GetAllEmployeesFromManagerDepartment(int departmentId);
      
        List<User> GetAllUsers();
     

        void PromoteEmployeeToManager(int id, Department department);
    
        List<ProjectClass> GetAllProjectsFromEmployee(int id);
   
        void UpdateUsersWhenDepartmentIsCanceled(int departmentId);
  

    }
}
