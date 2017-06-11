using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        public ProjectsForm() : base(columns, true, true, false, false, true)
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

            this.Text = "My projects";
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

        public override void HandleEditEvent(object selectedItem)
        {
            if (((ProjectClass)selectedItem).ProjectState == ProjectState.Finished || ((ProjectClass)selectedItem).ProjectState == ProjectState.Canceled)
            {
                MessageBox.Show("Projekat nije moguce editovati, jer je zavrsen ili otkazan.");
                Hide();
                var projectsForm = new ProjectsForm();
                projectsForm.ShowDialog();
                Close();

            }
            else
            {
                Hide();
                var editProject = new EditProjectForm((ProjectClass)selectedItem);
                editProject.ShowDialog();
                Close();
            }
        }

        public override void HandleRemoveEvent(object selectedItem) { }

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
