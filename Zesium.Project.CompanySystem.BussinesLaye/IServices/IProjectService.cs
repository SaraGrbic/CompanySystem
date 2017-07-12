using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;



namespace Zesium.Project.CompanySystem.BussinesLaye.IServices
{
    public interface IProjectService
    {
        List<ProjectClass> GetAllProjectsFromManager(int id);
     
        List<ProjectClass> GetAllProjectsFromEmployee(int id);
    
        List<ProjectClass> GetAllProjects();
     
        void AddNewProjectWeb(string projectName, int projectPrice, string projectDescription, DateTime projectStartDate, DateTime projectEndDate, ProjectState projectState, int managerId, int departmantId);
  
        ProjectClass FindProject(int? id);
    

        void DeleteProject(int? id);
     
        void EditProject(int id,
                                string name,
                                int price,
                                string description,
                                DateTime startDate,
                                DateTime endDate,
                                ProjectState projectState,
                                int departmentId,
                                int managerId);
       
        void EditProject(int id, string name, int price, string description, ProjectState projectState);
      
        void UpdateProjectsWhenDepartmentIsCanceled(int deprtmentId);
      
        void UpdateProjectStateAfterCreatingTask(int projectId);
    

    }
}
