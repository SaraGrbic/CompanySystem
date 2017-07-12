using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.BussinesLaye
{
    public class TaskService
    {
        ProjectService projectService = new ProjectService();
        public void AddNewTask(/*int id,*/int employeeId, int projectId, string taskName, string taskDescription, TaskState taskState,  DateTime taskStartTime, DateTime taskEndTime, int estimatedWorkingTime, int remainingWorkingTime, string taskComment)
        {
            using (var db = new CompanyDbContext())
            {
                var task = new ProjectClass.Task
                {
                    //Id=id,
                    EmployeeId=Company.Instance.CurrentUser.Id,
                    ProjectId = projectId,
                    TaskName =taskName,
                    TaskDescription = taskDescription,
                    TaskStartTime =taskStartTime,
                    TaskEndTime=taskEndTime,
                    EstimatedWorkingTime=estimatedWorkingTime,
                    RemainingWorkingTime=remainingWorkingTime,
                    TaskComment=taskComment,
                   
                   
                };
                db.Tasks.Add(task);
                db.SaveChanges();
                projectService.UpdateProjectStateAfterCreatingTask(projectId);
            }

        }
        public void UpdateTaskWhenStateChangedToDone(int taskId)
        {
            using (var db = new CompanyDbContext())
            {
                var task = db.Tasks.SingleOrDefault(x => x.Id == taskId);
                if (task==null)
                {
                    throw new Exception("Task with that id doesn't exist");

                }
                task.TaskState = TaskState.Done;
                db.SaveChanges();
            }
        }
        public void UpdateTasksWhenProjectIsCanceled(int projectId)
        {
            using (var db = new CompanyDbContext())
            {
                var task = db.Tasks.Where(x => x.ProjectId == projectId).ToList();
                task.ForEach(x => x.TaskState = TaskState.Canceled);
                db.SaveChanges();
            }

        }
        public void UpdateTasksWhenDepartmentIsCanceled(int departmentId)
        {
            using (var db = new CompanyDbContext())
            {
                var tasks = db.Projects.Where(x => x.DepartmentId.Equals(departmentId))
                    .Join(db.Tasks, x => x.Id, t => t.ProjectId, (x, t) => t).ToList();
                tasks.ForEach(x => x.TaskState = TaskState.Canceled);
                db.SaveChanges();
            }
        }
        public void EditTask(int id, int estimatedTime, int remainingTime, TaskState taskState, string taskComment)
        {
            using (var db = new CompanyDbContext())
            {
                var tasks = db.Tasks.SingleOrDefault(x => x.Id == id);
                if (tasks==null)
                {
                    throw new Exception("Task with given Id doesn't exist");
                }
                tasks.EstimatedWorkingTime = estimatedTime;
                tasks.RemainingWorkingTime = remainingTime;
                tasks.TaskState = taskState;
                tasks.TaskComment = taskComment;
                db.SaveChanges();
            }
        }
        public List<ProjectClass.Task> GetAllTasksFromManager(int managerId)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Tasks.Where(x => x.EmployeeId == managerId).ToList();

            }
        }
        public List<ProjectClass.Task> GetAllTasksForSelectedProject(int projectId)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Tasks.Where(x => x.ProjectId == projectId).ToList();
            }
        }
        public List<ProjectClass.Task> GetEmployeeTasksForSelectedProject(int employeeId, int projectId)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Tasks.Where(x => x.ProjectId == projectId && x.EmployeeId == employeeId).ToList();
            }
        }

    }
}
