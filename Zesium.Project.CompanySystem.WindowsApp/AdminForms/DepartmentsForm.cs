using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.Model;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public class DepartmentsForm : GenericForm<Department>
    {
        private static List<Column> columns = new List<Column>
        {
            new Column() {PropertyName="DepartmentId", Title="ID", PropertyType=typeof(string) },
            new Column() {PropertyName="Name", Title="Name", PropertyType=typeof(string) },
            new Column() {PropertyName="Description", Title="Description", PropertyType=typeof(string) },
            new Column() {PropertyName="IsDepartmentActive", Title="Active", PropertyType=typeof(bool) }
        };

        #region Constructors
        public DepartmentsForm(): base(columns, true, true, true, false, false)
        {
            var values = new List<Department>();
            foreach (var item in Company.Instance.Departments.Values)
            {
                values.Add(item);
            }
            FillTable(values);

            this.Text = "Departments";
        }
        #endregion

        #region Actions
        public override void HandleAddEvent()
        {
            var addDepartment = new AddDepartmentForm();
            addDepartment.ShowDialog();
        }

        public override void HandleEditEvent(object selectedItem)
        {
            var editDepartmentForm = new AddDepartmentForm(((Department)selectedItem));
            if (((Department)selectedItem).DepartmentId != 0 && ((Department)selectedItem).IsDepartmentActive == true)
            {
                editDepartmentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Departman ne moze biti izmenjen!");
                CloseDialog();
            }
        }

        public override void HandleRemoveEvent(object selectedItem)
        {
            if(((Department)selectedItem).DepartmentId != 0 && ((Department)selectedItem).IsDepartmentActive == true)
            {
                ((Department)selectedItem).IsDepartmentActive = false;
                DepartmentCancelation((Department)selectedItem);
                CloseDialog();
            }
            else
            {
                MessageBox.Show("Departman ne moze biti izmenjen!");
                CloseDialog();
            }
        }

        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem) { }
        #endregion

        #region Methods
        private void CloseDialog()
        {
            Hide();
            var departmentForm = new DepartmentsForm();
            departmentForm.ShowDialog();
            Close();
        }

        private void DepartmentCancelation(Department department)
        {
            foreach (var currentProject in Company.Instance.Projects.Values)
            {
                if (currentProject.Department == department)
                {
                    currentProject.ProjectState = ProjectState.Canceled;

                    foreach (var currentTask in currentProject.ProjectTasks.Values)
                    {
                        currentTask.TaskState = TaskState.Canceled;
                        currentTask.TaskEndTime = DateTime.Now;
                        currentTask.RemainingWorkingTime = 0;
                    }
                }
            }

            foreach (var currentUser in Company.Instance.Users.Values)
            {
                if (currentUser.Department == department)
                {
                    currentUser.Department = Company.Instance.Departments[0];
                }
            }
        }
        #endregion
    }
}
