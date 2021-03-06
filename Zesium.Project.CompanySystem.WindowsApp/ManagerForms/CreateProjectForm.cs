﻿using System;
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
using Zesium.Project.CompanySystem.BussinesLaye;

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    public partial class CreateProjectForm : Form
    {
        private CompanySystemService companyService = new CompanySystemService();
        private ProjectService projectService = new ProjectService();
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
                projectService.AddNewProject(txtbxName.Text, int.Parse(txtbxCost.Text), rtxtbxDescription.Text, pckrStart.Value, pckrEnd.Value);
                CloseDialog();
            }
        }
        #endregion

        #region Methods
        private void SetProfileData()
        {
            lblOwnerName.Text = Company.Instance.CurrentUser.Name;
            lblOwnerLastname.Text = Company.Instance.CurrentUser.LastName;
        }

        private void CloseDialog()
        {
            Hide();
            var projectsForm = new ProjectsForm();
            projectsForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
