using System;
using System.Collections.Generic;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.AdminForms;
using Zesium.Project.CompanySystem.WindowsApp.ManagerForms;
using Zesium.Project.CompanySystem.WindowsApp.Model;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    class TasksList : GenericForm<TaskClass>
    {
        private static List<Column> columns = new List<Column>
        {
            new Column() {PropertyName="TaskId", Title="ID", PropertyType=typeof(string) },
            new Column() {PropertyName="TaskName", Title="Name", PropertyType=typeof(string) },
            new Column() {PropertyName="TaskState", Title="State", PropertyType=typeof(TaskState) },
            new Column() {PropertyName="TaskStartTime", Title="Start time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="TasksEmployee", Title = "Assigned employee", PropertyType = typeof(Employee) },
            new Column() {PropertyName="TaskDescription", Title="Description", PropertyType=typeof(string) },
            new Column() { PropertyName = "TaskComment", Title = "Comment", PropertyType = typeof(string) },
            new Column() { PropertyName = "TasksProject", Title = "Project", PropertyType = typeof(string) }
        };

        #region Constructors
        public TasksList() : base(columns, false, false, false, false, false)
        {
            var values = new List<TaskClass>();
            foreach (var currentProject in ((Manager)Company.Instance.CurrentUser).ManagerProjects.Values)
            {
                foreach (var currentTask in currentProject.ProjectTasks.Values)
                {
                    values.Add(currentTask);
                }
            }

            FillTable(values);

            this.Text = "Tasks";
        }
        #endregion

        #region Properties
        #endregion

        #region Actions
        public override void HandleAddEvent() { }

        public override void HandleEditEvent(object selectedItem) { }

        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleRemoveEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem) { }
        #endregion
    }
}
