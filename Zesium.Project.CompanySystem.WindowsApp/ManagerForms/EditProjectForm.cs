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
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;

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
            rBtnFinished.Enabled = AreAllTasksDone();
        }
        #endregion

        #region Actions
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(InputServices.TextBoxError(txtbxName, errorProvider1) && InputServices.TextBoxIntError(txtbxCost, errorProvider1)
                && InputServices.RichTextBoxError(rtxtbxDescription, errorProvider1))
            {
                HelperClass.EditProject(SelectedProject.ProjectId, txtbxName.Text, int.Parse(txtbxCost.Text), rtxtbxDescription.Text, ProjectStateChoice());

                if(ProjectStateChoice() == ProjectState.Canceled)
                {
                    HelperClass.UpdateTasksWhenProjectIsCanceled(SelectedProject.ProjectId);
                }

                CloseDialog();
            }
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
            lblOwnerLastname.Text = Company.Instance.CurrentUser.LastName;
            txtbxName.Text = project.ProjectName;
            txtbxCost.Text = project.ProjectPrice.ToString();
            rtxtbxDescription.Text = project.ProjectDescription;
            if (project.ProjectState == ProjectState.InProgres)
            {
                rBtnInProgres.Checked = true;
            }
        }

        private void CloseDialog()
        {
            Hide();
            var projectForm = new ProjectsForm();
            projectForm.ShowDialog();
            Close();
        }

        private ProjectState ProjectStateChoice()
        {
            if (rBtnInProgres.Checked)
            {
                return ProjectState.InProgres;
            }
            else if (rBtnFinished.Checked)
            {
                return ProjectState.Finished;
            }
            else if (rBtnCanceled.Checked)
            {
                return ProjectState.Canceled;
            }
            else
            {
                return ProjectState.New;
            }
        }

        private bool AreAllTasksDone()
        {
            foreach (TaskClass task in HelperClass.GetAllTasksForSelectedProject(SelectedProject.ProjectId))
            {
                if (task.TaskState != TaskState.Done)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
