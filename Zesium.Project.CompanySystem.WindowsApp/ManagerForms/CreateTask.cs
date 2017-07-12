using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using Zesium.Project.CompanySystem.Models.Services;
using Zesium.Project.CompanySystem.BussinesLaye;

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    public partial class CreateTask : Form
    {
        private ProjectService projectService = new ProjectService();
        private EmployeeService employeeService = new EmployeeService();
        private TaskService taskService = new TaskService();
        #region Constructors
        public CreateTask(ProjectClass selectedProject)
        {
            InitializeComponent();
            FillTable();
            SelectedProject = selectedProject;
        }
        #endregion

        #region Properties
        public ProjectClass SelectedProject { get; set; }
        #endregion

        //#region Actions
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        //private void btnCreate_Click(object sender, EventArgs e)
        //{
        //    if (InputServices.TextBoxError(txtbxName, errorProvider1) && InputServices.DateTimePickersError(pckrStartTime, pckrEndTime, errorProvider1)
        //        && InputServices.RichTextBoxError(rchTxtBxDescription, errorProvider1))
        //    {
        //        taskService.AddNewTask(txtbxName.Text, pckrStartTime.Value, pckrEndTime.Value, rchTxtBxDescription.Text, ((User)dgvEmployees.CurrentRow.DataBoundItem).Id, SelectedProject.Id);
        //        projectService.UpdateProjectStateAfterCreatingTask(SelectedProject.Id);
        //        CloseDialog();
        //    }
        //}
        //#endregion

        #region Methods
        private void FillTable()
        {
            dgvEmployees.DataSource = employeeService.GetAllEmployeesFromManagerDepartment(Company.Instance.CurrentUser.Department.Id);
        }

        private void CloseDialog()
        {
            Hide();
            var taskForm = new TaskForm(SelectedProject);
            taskForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
