﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.AdminForms;
using Zesium.Project.CompanySystem.WindowsApp.Model;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using Zesium.Project.CompanySystem.BussinesLaye;

namespace Zesium.Project.CompanySystem.WindowsApp.EmployeeForms
{
    public class EmployeeProjectsForm : GenericForm<ProjectClass>
    {
        private CompanySystemService companyService = new CompanySystemService();
        private EmployeeService employeeService = new EmployeeService();
        private static List<Column> columns = new List<Column>
        {
            new Column() {PropertyName="ProjectId", Title="ID", PropertyType=typeof(string) },
            new Column() {PropertyName="ProjectName", Title="Name", PropertyType=typeof(string) },
            new Column() {PropertyName="ProjectPrice", Title="Price", PropertyType=typeof(string) },
            new Column() {PropertyName="ProjectState", Title="State", PropertyType=typeof(ProjectState) },
            new Column() {PropertyName="ProjectStartDate", Title="Start time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="ProjectEndDate", Title="End time", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="ProjectManager", Title="Owner", PropertyType=typeof(string) },
            new Column() {PropertyName="Department", Title = "Department", PropertyType = typeof(Department) },
            new Column() {PropertyName="ProjectDescription", Title="Description", PropertyType=typeof(string) },
            new Column() {PropertyName="Delayed", Title="Is project delayed", PropertyType=typeof(bool) }
        };

        #region Constructors
        public EmployeeProjectsForm(): base(columns, false, false, false, false, true)
        {
            FillTable(employeeService.GetAllProjectsFromEmployee(Company.Instance.CurrentUser.Id));

            this.Text = "My projects";
        }
        #endregion

        #region Actions
        public override void HandleAddEvent() { }

        public override void HandleEditEvent(object selectedItem) { }

        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleRemoveEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem)
        {
            Hide();
            var taskForm = new EmployeeTasksForm((ProjectClass)selectedItem);
            taskForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
