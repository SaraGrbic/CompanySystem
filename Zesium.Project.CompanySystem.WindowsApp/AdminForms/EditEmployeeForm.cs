using System;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.Models.Services;
using Zesium.Project.CompanySystem.WindowsApp;
using Zesium.Project.CompanySystem.BussinesLaye;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public partial class EditEmployeeForm : Form
    {
        private CompanySystemService companyService = new CompanySystemService();
        private AccountService accountService = new AccountService();
        #region Constructors
        public EditEmployeeForm(User user)
        {
            InitializeComponent();
            SetDepartments(user);
            ShowSelectedUser(user);
            SelectedUser = user;
            if (user.UserType == UserType.Administrator)
            {
                cmbbxDepartment.Visible = false;
            }
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
                && InputServices.ComboBoxError(cmbbxDepartment, errorProvider1))
            {
                ChangeSelectedUser(SelectedUser);

                CloseDialog();
            }
        }
        #endregion

        #region Methods
        private void ChangeSelectedUser(User user)
        {
            accountService.EditUser(user.Id, name_txtbx.Text, lastName_txtbx.Text, dayOfBirth_pckr.Value, GenderChoice(), cmbbxDepartment.SelectedItem as Department);
        }

        private void ShowSelectedUser(User user)
        {
            name_txtbx.Text = user.Name;
            lastName_txtbx.Text = user.LastName;
            dayOfBirth_pckr.Value = user.DayOfBirth;
            switch(user.Gender)
            {
                case Gender.Male: genderMale_rbtn.Checked = true;
                    break;
                case Gender.Female: genderFemale_rbtn.Checked = true;
                    break;
            }
        }
        
        private void SetDepartments(User user)
        {
            foreach (Department department in companyService.GetAllDepartments())
            {
                if (department.IsDepartmentActive == true)
                {
                    cmbbxDepartment.Items.Add(department);

                    if (user.Department.Id == department.Id)
                    {
                        cmbbxDepartment.SelectedItem = department;
                    }

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
