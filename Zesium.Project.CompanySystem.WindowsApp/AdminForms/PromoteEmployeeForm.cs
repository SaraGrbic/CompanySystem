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
using Zesium.Project.CompanySystem.Models.Services;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public partial class PromoteEmployeeForm : Form
    {

        #region Constructors
        public PromoteEmployeeForm(User user)
        {
            InitializeComponent();
            SetDepartments();
            SelectedUser = user;
        }
        #endregion

        #region Properties
        public User SelectedUser { get; set; }
        #endregion

        #region Actions
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            if (InputServices.ComboBoxError(cmbbxDepartments, errorProvider1))
            {
                var newManager = new Manager(SelectedUser, cmbbxDepartments.SelectedItem as Department);
                Company.Instance.Users.Remove(SelectedUser.Id);
                Company.Instance.Users.Add(newManager.Id, newManager);
                CloseDialog();
            }
        }
        #endregion

        #region Methods
        private void CloseDialog()
        {
            Hide();
            var employeeForm = new EmployeesForm();
            employeeForm.ShowDialog();
            Close();
        }

        private void SetDepartments()
        {
            foreach (Department department in Company.Instance.Departments.Values)
            {
                if (department.IsDepartmentActive == true)
                {
                    cmbbxDepartments.Items.Add(department);
                }
            }
        }
        #endregion
    }
}
