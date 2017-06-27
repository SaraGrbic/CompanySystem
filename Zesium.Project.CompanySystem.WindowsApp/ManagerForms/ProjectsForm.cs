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
            new Column() {PropertyName="ProjectDescription", Title="Description", PropertyType=typeof(string) },
            new Column() {PropertyName="Delayed", Title="Is project delayed", PropertyType=typeof(bool) }
        };

        #region Constructors
        public ProjectsForm() : base(columns, true, true, false, false, true)
        {
            FillTable(HelperClass.GetAllProjectsFromManager(Company.Instance.CurrentUser.Id));

            this.Text = "My projects";
        }
        #endregion

        #region Actions
        public override void HandleAddEvent()
        {
            if (Company.Instance.CurrentUser.Department.DepartmentId != 1)
            {
                Hide();
                var createProject = new CreateProjectForm();
                createProject.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Ova opcija Vam nije dostupna, jer nemate departman.");
                CloseDialog();
            }
        }

        public override void HandleEditEvent(object selectedItem)
        {
            if (((ProjectClass)selectedItem).ProjectState == ProjectState.Finished || ((ProjectClass)selectedItem).ProjectState == ProjectState.Canceled)
            {
                MessageBox.Show("Projekat nije moguce editovati, jer je zavrsen ili otkazan.");
                CloseDialog();
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
        private void CloseDialog()
        {
            Hide();
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
