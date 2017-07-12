using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.BussinesLaye.IServices;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models;



namespace Zesium.Project.CompanySystem.BussinesLaye
{
    public class ProjectService:IProjectService
    {

        public List<ProjectClass.Project> GetAllProjectsFromManager(int id)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Projects.Where(x => x.ProjectManagerId == id).ToList();
            }
        }
        public List<ProjectClass.Project> GetAllProjectsFromEmployee(int id)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Projects.Where(x => x.Employees.Any(e => e.Id == Company.Instance.CurrentUser.Id)).ToList();
            }
        }
      public List<ProjectClass.Project> GetAllProjects()
        {
            using (var db = new CompanyDbContext())
            {

                var allProjects = db.Projects.ToList();
                foreach(ProjectClass.Project project in allProjects)
                {

                    project.Delayed = project.ProjectEndDate < DateTime.Now;
                   
                }

                return allProjects;
            }
        }
        public void AddNewProjectWeb(string projectName, int projectPrice, string projectDescription, DateTime projectStartDate, DateTime projectEndDate,ProjectState projectState, int managerId, int departmantId)
        {
            bool delay = false;
            if (projectEndDate<DateTime.Now)
            {
                delay = true;
            }
            using (var db = new CompanyDbContext())
            {
                var project = new ProjectClass.Project
                {
                    ProjectName = projectName,
                    ProjectPrice = projectPrice,
                    ProjectDescription = projectDescription,
                    ProjectStartDate = projectStartDate,
                    ProjectEndDate = projectEndDate,
                    ProjectState = projectState,
                    DepartmentId = departmantId,
                    ProjectManagerId =managerId,
                    Delayed = delay
                };
                db.Projects.Add(project);
                db.SaveChanges();
            }
        }
        public void AddNewProject(string projectName, int projectPrice, string projectDescription, DateTime projectStartDate, DateTime projectEndDate )
        {
          
            using (var db = new CompanyDbContext())
            {
              
                var project = new ProjectClass.Project
                {
                    ProjectName = projectName,
                    ProjectPrice = projectPrice,
                    ProjectDescription = projectDescription,
                    ProjectStartDate = projectStartDate,
                    ProjectEndDate = projectEndDate,   
                    DepartmentId =(int) Company.Instance.CurrentUser.DepartmentId,
                    ProjectManagerId = Company.Instance.CurrentUser.Id,        
                };
                db.Projects.Add(project);
                db.SaveChanges();
            }
        }
        public ProjectClass.Project FindProject(int? id)
        {
            using (var db = new CompanyDbContext())
            {
                return db.Projects.Find(id);
              
            }
        }

        public void DeleteProject(int? id)
        {
            using (var db = new CompanyDbContext())
            {
                var project =  db.Projects.Find(id);
                db.Projects.Remove(project);
                db.SaveChanges();

            }
        }

        public void EditProject(int id,
                                string name, 
                                int price, 
                                string description,
                                DateTime startDate,
                                DateTime endDate, 
                                ProjectState projectState,
                                int departmentId,
                                int managerId)
        {
            using (var db = new CompanyDbContext())
            {
                var project = db.Projects.SingleOrDefault(x => x.Id == id);
                if (project==null)
                {
                    throw new Exception("There isn't project with that id");
                }
                project.ProjectName = name;
                project.ProjectPrice = price;
                project.ProjectDescription = description;
                project.ProjectStartDate = startDate;
                project.ProjectEndDate = endDate;
                project.ProjectManagerId = managerId;
                project.DepartmentId = departmentId;
                project.ProjectState = projectState;
                db.SaveChanges();
            }
        }
        public void EditProject(int id, string name, int price, string description, ProjectState projectState)
        {
            using (var ctx = new CompanyDbContext())
            {
                var project = ctx.Projects.Single(x => x.Id.Equals(id));
                if (project == null)
                {
                    throw new Exception("Project does not exist");
                }

                project.ProjectName = name;
                project.ProjectPrice = price;
                project.ProjectDescription = description;

                if(projectState == ProjectState.Finished)
                {

                }




                project.ProjectState = projectState;
                ctx.SaveChanges();
            }
        }
        public void UpdateProjectsWhenDepartmentIsCanceled(int deprtmentId)
        {
            using (var db = new CompanyDbContext())
            {
                var projects = db.Projects.Where(x => x.DepartmentId == deprtmentId).ToList();
                projects.ForEach(x => x.ProjectState = ProjectState.Canceled);
                db.SaveChanges();
            }
        }
        public void UpdateProjectStateAfterCreatingTask(int projectId)
        {
            using (var db = new CompanyDbContext())
            {
                var project = db.Projects.SingleOrDefault(x => x.Id == projectId);
                if (project==null)
                {
                    throw new Exception("Project with that id doesn't exist");

                }
                project.ProjectState = ProjectState.InProgres;
            }
        }

    }
   
}
