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

                SelectedProject.ProjectName = txtbxName.Text;
                SelectedProject.ProjectPrice = int.Parse(txtbxCost.Text);
                SelectedProject.ProjectDescription = rtxtbxDescription.Text;
                if (rBtnInProgres.Checked == true)
                {
                    SelectedProject.ProjectState = ProjectState.InProgres;
                }
                else if (rBtnFinished.Checked == true)
                {
                    SelectedProject.ProjectState = ProjectState.Finished;
                }
                else if (rBtnCanceled.Checked == true)
                {
                    SelectedProject.ProjectState = ProjectState.Canceled;
                    ProjectCancelation(SelectedProject);
                }
                else SelectedProject.ProjectState = ProjectState.New;

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
            lblOwnerLastname.Text = Company.Instance.CurrentUser.Lastname;
            txtbxName.Text = project.ProjectName;
            txtbxCost.Text = project.ProjectPrice.ToString();
            rtxtbxDescription.Text = project.ProjectDescription;
            if (project.ProjectState == ProjectState.InProgres)
            {
                rBtnInProgres.Checked = true;
            }
            //switch (project.ProjectState)
            //{
            //    case ProjectState.InProgres:
            //        rBtnInProgres.Checked = true;
            //        break;
            //    case ProjectState.Finished:
            //        rBtnFinished.Checked = true;
            //        break;
            //    case ProjectState.Canceled:
            //        rBtnCanceled.Checked = true;
            //        break;
            //}
        }

        private void CloseDialog()
        {
            Hide();
            var projectForm = new ProjectsForm();
            projectForm.ShowDialog();
            Close();
        }

        private void ProjectCancelation(ProjectClass project)
        {
            foreach(var currentTask in project.ProjectTasks.Values)
            {
                currentTask.TaskState = TaskState.Canceled;
                currentTask.TaskEndTime = DateTime.Now;
                currentTask.RemainingWorkingTime = 0;
            }
        }

        private bool AreAllTasksDone()
        {
            foreach(TaskClass task in SelectedProject.ProjectTasks.Values)
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
