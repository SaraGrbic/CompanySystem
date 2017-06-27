using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.Models.Services;
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
            FillTable(HelperClass.GetAllDepartments());

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
            if (((Department)selectedItem).DepartmentId != 1 && ((Department)selectedItem).IsDepartmentActive == true)
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
            if(((Department)selectedItem).DepartmentId != 1 && ((Department)selectedItem).IsDepartmentActive == true)
            {
                HelperClass.DepartmentCancelation(((Department)selectedItem).DepartmentId);
                HelperClass.UpdateUsersWhenDepartmentIsCanceled(((Department)selectedItem).DepartmentId);
                HelperClass.UpdateProjectsWhenDepartmentIsCanceled(((Department)selectedItem).DepartmentId);
                HelperClass.UpdateTasksWhenDepartmentIsCanceled(((Department)selectedItem).DepartmentId);
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
        #endregion
    }
}
