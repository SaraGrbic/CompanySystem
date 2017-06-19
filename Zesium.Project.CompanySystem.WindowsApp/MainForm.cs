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
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void btnListOfDepartments_Click(object sender, EventArgs e)
        {
            Hide();
            var departmentForm = new DepartmentsForm();
            departmentForm.ShowDialog();
            Close();
        }

        private void btnListOfEmployees_Click(object sender, EventArgs e)
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

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            var createAdmin = new CreateAdminForm();
            createAdmin.ShowDialog();
            Close();
        }

        private void saveCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                try
                {
                    Company.Instance.SaveInBinary(Company.Instance, path);
                    MessageBox.Show("Fajl uspesno snimljen");
                }
                catch
                {
                    MessageBox.Show("Fajl nije uspesno snimljen");
                }
            }
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
                case UserType.Administrator:
                    btnListOfDepartments.Visible = true;
                    btnListOfEmployees.Visible = true;
                    btnCreateAdmin.Visible = true;
                    break;
            }
        }
        #endregion
    }
}
