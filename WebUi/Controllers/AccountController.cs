using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebUi.Models;
using Zesium.Project.CompanySystem.BussinesLaye;
using Zesium.Project.CompanySystem.BussinesLaye.Iservices;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Controllers
{
    public class AccountController : Controller
    {
      
       private IAccountService accountService;
       

        public AccountController(IAccountService acc)
        {
            accountService = acc;
        }

        // GET: Acoount
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
           
            if (!ModelState.IsValid)
            {
                return View("Login", login);

            }
            var result = accountService.LoginWeb(login.Username, login.Password);
            Company.Instance.CurrentUser = result;
            Session["user"] = result;

            if (result!=null)
            {
               
                return RedirectToAction("GetAllProjects", "Projects");
            }
            ModelState.AddModelError("Key", "No such user");
            return View("Login");
        }
        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new NewUserViewModel();
            var db = new CompanyDbContext();
            viewModel.Department = db.Departmants.Select(d => new SelectListItem { Text = d.Name, Value = d.Id.ToString() });

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(NewUserViewModel user)
        {
            if (ModelState.IsValid)
            {    
                accountService.AddNewUser(user.Username, user.Password, user.Name, user.LastName, user.DayOfBirth, user.Gender, user.UserType, user.DepartmentId);
                return RedirectToAction("Login", "Account");

            }
            return View(user);
           
        }
 

    }
}