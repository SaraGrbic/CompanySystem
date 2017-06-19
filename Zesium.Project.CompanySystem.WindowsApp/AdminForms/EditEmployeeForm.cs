using System;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.Models.Services;
using Zesium.Project.CompanySystem.WindowsApp;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public partial class EditEmployeeForm : Form
    {
        #region Constructors
        public EditEmployeeForm(User user)
        {
            InitializeComponent();
            SetDepartments();
            ShowSelectedUser(user);
            SelectedUser = user;
        }
        #endregion

        #region Properties
        public User SelectedUser { get; set; }
        #endregion

        #region Actions
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void editAccount_btn_Click(object sender, EventArgs e)
        {
            if (InputServices.TextBoxError(name_txtbx, errorProvider1) && InputServices.TextBoxError(lastName_txtbx, errorProvider1)
                && InputServices.ComboBoxError(department_combobx, errorProvider1))
            {
                ChangeSelectedUser(SelectedUser);

                CloseDialog();
            }
        }
        #endregion

        #region Methods
        private void ChangeSelectedUser(User user)
        {
            user.Name = name_txtbx.Text;
            user.Lastname = lastName_txtbx.Text;
            user.DayOfBirth = dayOfBirth_pckr.Value;
            user.Gender = GenderChoice();
            user.Department = department_combobx.SelectedItem as Department;
        }

        private void ShowSelectedUser(User user)
        {
            name_txtbx.Text = user.Name;
            lastName_txtbx.Text = user.Lastname;
            dayOfBirth_pckr.Value = user.DayOfBirth;
            switch(user.Gender)
            {
                case Gender.Male: genderMale_rbtn.Checked = true;
                    break;
                case Gender.Female: genderFemale_rbtn.Checked = true;
                    break;
            }
            department_combobx.SelectedItem = user.Department;
        }
        
        private void SetDepartments()
        {
            foreach (Department department in Company.Instance.Departments.Values)
            {
                if (department.IsDepartmentActive == true)
                {
                    department_combobx.Items.Add(department);
                }
            }
        }

        private Gender GenderChoice()
        {
            if (genderMale_rbtn.Checked)
            {
                return Gender.Male;
            }
            else if (genderFemale_rbtn.Checked)
            {
                return Gender.Female;
            }
            else
            {
                return Gender.Unknown;
            }
        }

        private void CloseDialog()
        {
            Hide();
            var employeeForm = new EmployeesForm();
            employeeForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
