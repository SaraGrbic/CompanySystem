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
    public partial class CreateAdminForm : Form
    {
        public CreateAdminForm()
        {
            InitializeComponent();
        }

        #region Actions
        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            if (InputServices.TextBoxError(txtbxUsername, errorProvider1) && InputServices.TextBoxError(txtbxPassword, errorProvider1)
                && InputServices.TextBoxError(txtbxName, errorProvider1) && InputServices.TextBoxError(txtbxLastname, errorProvider1))
            {
                InputServices.CreateAdmin(txtbxUsername.Text, txtbxPassword.Text, txtbxName.Text, txtbxLastname.Text, pckrDateOfBirth.Value, GenderChoice());
                CloseDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }
        #endregion

        #region Methods
        private void CloseDialog()
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private Gender GenderChoice()
        {
            if (rbtnGenderMale.Checked)
            {
                return Gender.Male;
            }
            else if (rbtnGenderFemale.Checked)
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
