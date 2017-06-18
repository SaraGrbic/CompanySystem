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

        #region Actions
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            var createAccountForm = new CreateAccountForm();
            createAccountForm.ShowDialog();
            Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
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

        private void loadCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                try
                {
                    Company.Instance.ReadFromBinary(path);
                }
                catch
                {
                    MessageBox.Show("Fajl ne moze biti otvoren.");
                }
                finally
                {
                    MessageBox.Show("Uspesno ste otvorili fajl.");
                }
            }
        }
        #endregion
    }
}
