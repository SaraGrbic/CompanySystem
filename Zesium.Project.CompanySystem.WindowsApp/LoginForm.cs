using System;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models.Services;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.WindowsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //username_txtbx.Text = "admin";
            //password_txtbx.Text = "admin";
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            Hide();
            var createAccountForm = new CreateAccountForm();
            createAccountForm.ShowDialog();
            Close();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            if (InputServices.SignInSuccessful(username_txtbx.Text, password_txtbx.Text))
            {
                Hide();
                var mainForm = new MainForm();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Username ili password nisu validni. Pokusajte ponovo.");
                Hide();
                var loginForm = new LoginForm();
                loginForm.ShowDialog();
                Close();
            }
        }


    }
}
