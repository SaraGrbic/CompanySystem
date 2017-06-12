using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.Models.Services;

namespace Zesium.Project.CompanySystem.WindowsApp.EmployeeForms
{
    public partial class EditTaskForm : Form
    {

        #region Constructors
        public EditTaskForm(TaskClass task, ProjectClass project)
        {
            InitializeComponent();
            SelectedTask = task;
            SelectedProject = project;
            ShowSelectedTask(task);

        }
        #endregion

        #region Actions
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(InputServices.TextBoxIntError(txtBxEstimatedTime, errorProvider1) && InputServices.TextBoxIntError(txtBxRemainingTime, errorProvider1)
                && InputServices.RichTextBoxError(rchTxtBxComment, errorProvider1))
            {
                SelectedTask.EstimatedWorkingTime = int.Parse(txtBxEstimatedTime.Text);
                SelectedTask.RemainingWorkingTime = int.Parse(txtBxRemainingTime.Text);
                SelectedTask.TaskComment = rchTxtBxComment.Text;
                if (rdBtnInProgress.Checked)
                {
                    SelectedTask.TaskState = TaskState.In_Progres;
                }
                else if (rdBtnDone.Checked)
                {
                    SelectedTask.TaskState = TaskState.Done;
                    SelectedTask.RemainingWorkingTime = 0;
                    SelectedTask.TaskEndTime = DateTime.Now;
                }
                else { SelectedTask.TaskState = TaskState.To_Do; }

                CloseDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }
        #endregion

        #region Properties
        public TaskClass SelectedTask { get; set; }
        public ProjectClass SelectedProject { get; set; }
        #endregion

        #region Methods
        private void CloseDialog()
        {
            Hide();
            var employeeTasks = new EmployeeTasksForm(SelectedProject);
            employeeTasks.ShowDialog();
            Close();

        }

        private void ShowSelectedTask(TaskClass task)
        {
            txtBxEstimatedTime.Text = task.EstimatedWorkingTime.ToString();
            txtBxRemainingTime.Text = task.RemainingWorkingTime.ToString();
            switch (task.TaskState)
            {
                case TaskState.In_Progres:
                   rdBtnInProgress.Checked = true;
                    break;
                case TaskState.Done:
                    rdBtnDone.Checked = true;
                    break;
            }
            rchTxtBxComment.Text = task.TaskComment;
        }
        #endregion
    }
}
