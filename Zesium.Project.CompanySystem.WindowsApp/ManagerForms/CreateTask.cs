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

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    public partial class CreateTask : Form
    {
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

        #region Actions
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InputServices.CreateTask(txtbxName.Text, pckrStartTime.Value, pckrEndTime.Value, rchTxtBxDescription.Text, (Employee)dgvEmployees.CurrentRow.DataBoundItem, SelectedProject);
            SelectedProject.ProjectState = ProjectState.InProgres;
            CloseDialog();
        }
        #endregion

        #region Methods
        private void FillTable()
        {
            var values = new List<Employee>();

            foreach(var currentuser in Company.Instance.Users.Values)
            {
                if (currentuser.Department == Company.Instance.CurrentUser.Department && currentuser.UserType == UserType.Employee)
                {
                    values.Add((Employee)currentuser);
                }
            }

            dgvEmployees.DataSource = values;
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
