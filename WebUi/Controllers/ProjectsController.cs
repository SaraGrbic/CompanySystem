using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebUi.Attributes;
using WebUi.Models;
using Zesium.Project.CompanySystem.BussinesLaye;
using Zesium.Project.CompanySystem.BussinesLaye.IServices;
using Zesium.Project.CompanySystem.Models;


namespace WebUi.Controllers
{
    [CustomAuthorize]
    public class ProjectsController : Controller
    {
        private IProjectService projectService;
        public ProjectsController(IProjectService ps)
        {
            projectService = ps;
        }
        // GET: Projects
        [CustomAuthorize]
        [HttpGet]
        public ActionResult GetAllProjects()
            
        {
            User user = (User)Session["user"];
            IEnumerable<Project> projects;
            if (user.UserType==UserType.Manager)
            {
                 projects = projectService.GetAllProjectsFromManager(user.Id);
            }
            else if(user.UserType==UserType.Employee)
            {
                projects = projectService.GetAllProjectsFromEmployee(user.Id);

            }
            else
            {
                projects = projectService.GetAllProjects();
            }
            
         
          return View(new ProjectModel { Projects = projects });
        }
       
        [HttpGet] 
        public ActionResult CreateNewProjectView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewProjectView(ProjectViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
           
                projectService.AddNewProjectWeb(viewModel.ProjectName, viewModel.ProjectPrice, viewModel.ProjectDescription
               , viewModel.ProjectStartDate, viewModel.ProjectEndDate, viewModel.ProjectState, viewModel.DepartmentId, viewModel.ProjectManagerId);
                return RedirectToAction("GetAllProjects");
            }
            return View(viewModel);  
           
        }
        [HttpGet]
        public ActionResult EditProject(int? id)
        {
            User user = (User)Session["user"];
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var project = projectService.FindProject(id);
            ProjectViewModel viewModel = new ProjectViewModel();
            viewModel.Id = project.Id;
            viewModel.ProjectDescription = project.ProjectDescription;
            viewModel.ProjectEndDate = project.ProjectEndDate;
            viewModel.ProjectManagerId = user.Id;
            viewModel.ProjectName = project.ProjectName;
            viewModel.ProjectPrice = project.ProjectPrice;
            viewModel.ProjectStartDate = project.ProjectStartDate;
            viewModel.ProjectState = project.ProjectState;
            viewModel.DepartmentId = project.DepartmentId;


            return View(viewModel);
            
        }
        [HttpPost]
        public ActionResult EditProject(ProjectViewModel viewModel)
        {
            if (ModelState.IsValid)
            {

                projectService.EditProject(viewModel.Id,
                                           viewModel.ProjectName,
                                           viewModel.ProjectPrice, 
                                           viewModel.ProjectDescription,
                                           viewModel.ProjectStartDate, 
                                           viewModel.ProjectEndDate, 
                                           viewModel.ProjectState,
                                           viewModel.DepartmentId,
                                           viewModel.ProjectManagerId);
                return RedirectToAction("GetAllProjects");
            }
            return View(viewModel);

        }

        [HttpGet]
        public ActionResult DeleteProject(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             projectService.DeleteProject(id);

            return RedirectToAction("GetAllProjects");

        }


    }
}