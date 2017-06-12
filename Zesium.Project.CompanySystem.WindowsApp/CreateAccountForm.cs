using System;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models.Services;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.WindowsApp
{
    public partial class CreateAccountForm : Form
    {

        public CreateAccountForm()
        {
            InitializeComponent();
            SetDepartments();
        }
        #region Actions
        private void createAccount_btn_Click(object sender, EventArgs e)
        {
            if (InputServices.TextBoxError(username_txtbx, errorProvider1) && InputServices.TextBoxError(password_txtbx, errorProvider1)
                && InputServices.TextBoxError(name_txtbx, errorProvider1) && InputServices.TextBoxError(lastName_txtbx, errorProvider1)
                && InputServices.ComboBoxError(department_combobx, errorProvider1))
            {
                DateTime dayOfBirth = dayOfBirth_pckr.Value;
                Department department = department_combobx.SelectedItem as Department;
                InputServices.CreateUser(username_txtbx.Text, password_txtbx.Text, name_txtbx.Text, lastName_txtbx.Text, dayOfBirth, GenderChoice(), department);
                Hide();
                var mainForm = new MainForm();
                mainForm.ShowDialog();
                Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }
        #endregion

        #region Methods
        private void SetDepartments()
        {
            foreach (Department department in Company.Instance.Departments.Values)
            {
                if (department.ToString() == "Undefined")
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

        #endregion
    }
}
