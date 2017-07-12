using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUi.Models;
using Zesium.Project.CompanySystem.BussinesLaye;
using Zesium.Project.CompanySystem.BussinesLaye.IServices;
using Zesium.Project.CompanySystem.Models;


namespace WebUi.Controllers
{
    public class DepartmentEmployeesController : Controller
    {
        private IEmployeeService employeeService;
        public DepartmentEmployeesController(IEmployeeService es)
        {
            employeeService = es;
        }
        // GET: DepartmentEmployees
        public ActionResult GetEmployeesForDepartment(int departmentId)
        {
            var model = new DepartmentEmployeesViewModel { DepartmentId = departmentId };
            model.Employees = employeeService.GetAllUsers().Select(u => new UserTypeViewModel
            {
                Id=u.Id,
                Name=u.Name,
                LastName=u.LastName,
                UserTypeName=SetUserType()
               

            });
            return View(model);
        }

        private string SetUserType()
        {
            User user = (User)Session["user"];

            if (user.UserType==UserType.Employee)
            {
                return UserTypeNames.EmployeeType;
            }
            else if(user.UserType==UserType.Manager)
            {
                return UserTypeNames.ManagerType;

            }
            else
            {
                return UserTypeNames.AdminType;
            }
 
        }
    }
}