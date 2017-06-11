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
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;

namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    public partial class EditProjectForm : Form
    {
        #region Constructors
        public EditProjectForm(ProjectClass project)
        {
            InitializeComponent();
            SelectedProject = project;
            ShowSelectedProject(project);
        }
        #endregion

        #region Actions
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SelectedProject.ProjectName = txtbxName.Text;
            SelectedProject.ProjectPrice = ParsePriceInput(txtbxCost.Text);
            SelectedProject.ProjectDescription = rtxtbxDescription.Text;
            if (rBtnInProgres.Checked == true)
            {
                SelectedProject.ProjectState = ProjectState.InProgres;
            }
            else if (rBtnFinished.Checked == true)
            {
                //TODO ako moze, provera svih taskova u projektu i ako postoji onaj koji nije done-> error; ako ne postoji izvrsi ovu liniju
                SelectedProject.ProjectState = ProjectState.Finished;
            }
            else if (rBtnCanceled.Checked == true)
            {
                SelectedProject.ProjectState = ProjectState.Canceled;
            }
            else SelectedProject.ProjectState = ProjectState.New;

            CloseDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }
        #endregion

        #region Properties
        public ProjectClass SelectedProject { get; set; }
        #endregion

        #region Methods
        private void ShowSelectedProject(ProjectClass project)
        {
            lblOwnerName.Text = Company.Instance.CurrentUser.Name;
            lblOwnerLastname.Text = Company.Instance.CurrentUser.Lastname;
            txtbxName.Text = project.ProjectName;
            txtbxCost.Text = project.ProjectPrice.ToString();
            rtxtbxDescription.Text = project.ProjectDescription;
            switch (project.ProjectState)
            {
                case ProjectState.InProgres:
                    rBtnInProgres.Checked = true;
                    break;
                case ProjectState.Finished:
                    rBtnFinished.Checked = true;
                    break;
                case ProjectState.Canceled:
                    rBtnCanceled.Checked = true;
                    break;
            }
        }

        private void CloseDialog()
        {
            Hide();
            var projectForm = new ProjectsForm();
            projectForm.ShowDialog();
            Close();
        }

        private int ParsePriceInput(string input)
        {
            int projectCost;

            if (int.TryParse(input, out projectCost))
            {
                return projectCost;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
