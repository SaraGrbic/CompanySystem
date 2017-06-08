using System;
using System.Collections.Generic;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.AdminForms;
using Zesium.Project.CompanySystem.WindowsApp.Model;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    class ProjectsForm : GenericForm<ProjectClass>
    {
        private static List<Column> columns = new List<Column>
        {
            new Column() {PropertyName="ProjectId", Title="ID", PropertyType=typeof(string) },
            new Column() {PropertyName="ProjectName", Title="Name", PropertyType=typeof(string) },
            new Column() {PropertyName="ProjectPrice", Title="Price", PropertyType=typeof(string) },
            new Column() {PropertyName="ProjectState", Title="State", PropertyType=typeof(ProjectState) },
            new Column() {PropertyName="ProjectStartDate", Title="Start time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="ProjectEndDate", Title="End time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="ProjectManager", Title="Owner", PropertyType=typeof(string) },
            new Column() {PropertyName="Department", Title = "Department", PropertyType = typeof(Department) },
            new Column() {PropertyName="ProjectDescription", Title="Description", PropertyType=typeof(string) }        
        };

        #region Constructors
        public ProjectsForm(): base(columns, true, true, true, false, true)
        {
            if (Company.Instance.CurrentUser.UserType == UserType.Employee)
            {
                var values = new List<ProjectClass>();
                foreach (var empolyeeProject in ((Employee)Company.Instance.CurrentUser).EmployeeProjects.Values)
                {
                    values.Add(empolyeeProject);
                }

                FillTable(values);
            }
            else
            {
                var values = new List<ProjectClass>();
                foreach (var managerProject in Company.Instance.Projects.Values)
                {
                    if (Company.Instance.CurrentUser == managerProject.ProjectManager)
                    {
                        values.Add(managerProject);
                    }
                }

                FillTable(values);
            }

            this.Text = "Projects";
        }
        #endregion

        #region Actions
        public override void HandleAddEvent()
        {
            Hide();
            var createProject = new CreateProjectForm();
            createProject.ShowDialog();
            Close();
        }

        public override void HandleRemoveEvent(object selectedItem) { }//TODO implement

        public override void HandleEditEvent(object selectedItem) { }//TODO implement
        
        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem)
        {
            Hide();
            var taskForm = new TaskForm((ProjectClass)selectedItem);
            taskForm.ShowDialog();
            Close();
        }
        #endregion

        #region Methods
        #endregion
    }
}
