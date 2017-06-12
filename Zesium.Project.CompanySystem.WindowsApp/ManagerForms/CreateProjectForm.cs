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

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    public partial class CreateProjectForm : Form
    {

        #region Constructors
        public CreateProjectForm()
        {
            InitializeComponent();
            SetProfileData();
        }
        #endregion

        #region Actions
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (InputServices.TextBoxError(txtbxName, errorProvider1) && InputServices.DateTimePickersError(pckrStart, pckrEnd, errorProvider1) && InputServices.TextBoxIntError(txtbxCost, errorProvider1)
                && InputServices.RichTextBoxError(rtxtbxDescription, errorProvider1))
            {
                InputServices.CreateProject(txtbxName.Text, int.Parse(txtbxCost.Text), rtxtbxDescription.Text, pckrStart.Value, pckrEnd.Value, (Manager)Company.Instance.CurrentUser, Company.Instance.CurrentUser.Department);
                CloseDialog();
            }
        }
        #endregion

        #region Methods
        private void SetProfileData()
        {
            lblOwnerName.Text = Company.Instance.CurrentUser.Name;
            lblOwnerLastname.Text = Company.Instance.CurrentUser.Lastname;
        }

        private void CloseDialog()
        {
            Hide();
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            Close();
        }

        //private int ParsePriceInput(string input)
        //{
        //    int projectCost;

        //    if (int.TryParse(input, out projectCost))
        //    {
        //        return projectCost;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        #endregion
    }
}
