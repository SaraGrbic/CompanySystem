using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUi.Models;
using Zesium.Project.CompanySystem.BussinesLaye;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Controllers
{
    public class TaskController : Controller
    {
        TaskService taskService;
        public TaskController()
        {
            taskService = new TaskService();
        }
        // GET: Task
        public ActionResult GetAllTasks(int id)
        {
            User user = (User)Session["user"];
            IEnumerable<Task> tasks;
            if (user.UserType == UserType.Manager)
            {
                tasks = taskService.GetAllTasksFromManager(id);
            }
            else if (user.UserType==UserType.Employee)
            {
                tasks = taskService.GetEmployeeTasksForSelectedProject(user.Id, id);
            }
            else
            {
                tasks = taskService.GetAllTasksForSelectedProject(id);
            }
            return View(new TaskModel {Tasks=tasks, ProjectId=id });
        }
        [HttpGet]
        public ActionResult CreateNewTask(int id)
        {
            var model = new TaskViewModel { ProjectId = id };
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateNewTask(TaskViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                taskService.AddNewTask(/*viewModel.Id,*/
                                       viewModel.EmployeeId,
                                       viewModel.ProjectId,
                                        viewModel.TaskName,
                                        viewModel.TaskDescription,
                                        viewModel.TaskState,
                                        viewModel.TaskStartTime,
                                        viewModel.TaskEndTime,
                                        viewModel.EstimatedWorkingTime,
                                        viewModel.RemainingWorkingTime,
                                        viewModel.TaskComment
                                        );
                 
                return RedirectToAction("GetAllTasks", new { id = viewModel.ProjectId } );
                          
            }
            return View(viewModel);
        }
    }
}