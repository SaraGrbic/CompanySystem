using System;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.AdminForms;
using Zesium.Project.CompanySystem.WindowsApp.EmployeeForms;
using Zesium.Project.CompanySystem.WindowsApp.ManagerForms;

namespace Zesium.Project.CompanySystem.WindowsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetProfileData();
            SetAvilableOptions();

        }
        #region Actions
        private void signOut_btn_Click(object sender, EventArgs e)
        {
            Company.Instance.SaveInBinary(Company.Instance);
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void listOfDepartments_btn_Click_1(object sender, EventArgs e)
        {
            Hide();
            var departmentForm = new DepartmentsForm();
            departmentForm.ShowDialog();
            Close();
        }

        private void listOfEmployees_btn_Click(object sender, EventArgs e)
        {
            Hide();
            var employeesForm = new EmployeesForm();
            employeesForm.ShowDialog();
            Close();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            Hide();
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            Close();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            Hide();
            var allTaskForm = new TasksList();
            allTaskForm.ShowDialog();
            Close();
        }

        private void btnEmployeeProjects_Click(object sender, EventArgs e)
        {
            Hide();
            var projectsForm = new EmployeeProjectsForm();
            projectsForm.ShowDialog();
            Close();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            Hide();
            var managerListForm = new ManagerList();
            managerListForm.ShowDialog();
            Close();
        }
        #endregion

        #region Methods
        private void SetProfileData()
        {
            currentUserName_lbl.Text = Company.Instance.CurrentUser.Name;
            currentUserLastname_lbl.Text = Company.Instance.CurrentUser.Lastname;
            currentUserDepartment_lbl.Text = Company.Instance.CurrentUser.Department.Name;
        }

        private void SetAvilableOptions()
        {
            switch (Company.Instance.CurrentUser.UserType)
            {
                case UserType.Employee:
                    btnEmployeeProjects.Visible = true;
                    btnManagers.Visible = true;
                    break;
                case UserType.Manager:
                    btnManagerProjects.Visible = true;
                    btnTasks.Visible = true;
                break;
                case UserType.Administrator :
                    listOfDepartments_btn.Visible = true;
                    listOfEmployees_btn.Visible = true;
                break;
            }
        }
        #endregion
    }
}
