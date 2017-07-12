using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.AdminForms;
using Zesium.Project.CompanySystem.WindowsApp.ManagerForms;
using Zesium.Project.CompanySystem.WindowsApp.Model;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;
using Zesium.Project.CompanySystem.BussinesLaye;

namespace Zesium.Project.CompanySystem.WindowsApp
{
    class TaskForm : GenericForm<TaskClass>
    {
        private CompanySystemService companyService = new CompanySystemService();
        private TaskService taskService = new TaskService();
        private static List<Column> columns = new List<Column>
        {
            new Column() {PropertyName="TaskId", Title="ID", PropertyType=typeof(string) },
            new Column() {PropertyName="TaskName", Title="Name", PropertyType=typeof(string) },
            new Column() {PropertyName="TaskState", Title="State", PropertyType=typeof(TaskState) },
            new Column() {PropertyName="TaskStartTime", Title="Start time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="TaskEndTime", Title="End time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="EstimatedWorkingTime", Title="Estimated working time", PropertyType=typeof(string) },
            new Column() {PropertyName="RemainingWorkingTime", Title="Remaining working time", PropertyType=typeof(string) },
            new Column() {PropertyName="TasksEmployee", Title = "Assigned employee", PropertyType = typeof(string) },
            new Column() {PropertyName="TaskDescription", Title="Description", PropertyType=typeof(string) },
            new Column() { PropertyName = "TaskComment", Title = "Comment", PropertyType = typeof(string) },
            new Column() { PropertyName = "TasksProject", Title = "Project", PropertyType = typeof(string) }
        };

        #region Constructors
        public TaskForm(ProjectClass selectedProject) : base(columns, true, false, false, false, false)
        {
            FillTable(taskService.GetAllTasksForSelectedProject(selectedProject.Id));

            SelectedProject = selectedProject;

            this.Text = "Tasks";
        }
        #endregion

        #region Properties
        public ProjectClass SelectedProject { get; set; }
        #endregion

        #region Actions
        public override void HandleAddEvent()
        {
            if (SelectedProject.ProjectState == ProjectState.Finished || SelectedProject.ProjectState == ProjectState.Canceled)
            {
                MessageBox.Show("Nije moguće dodati task, jer je projekat zavrsen ili otkazan.");
                Hide();
                var taskForm = new TaskForm(SelectedProject);
                taskForm.ShowDialog();
                Close();
            }
            else
            {
                Hide();
                var createTask = new CreateTask(SelectedProject);
                createTask.ShowDialog();
                Close();
            }
        }

        public override void HandleEditEvent(object selectedItem) { }

        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleRemoveEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem) { }
        #endregion
    }
}
