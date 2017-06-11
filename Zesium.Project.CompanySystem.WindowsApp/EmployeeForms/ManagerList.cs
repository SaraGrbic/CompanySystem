using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.WindowsApp.AdminForms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.Model;

namespace Zesium.Project.CompanySystem.WindowsApp.EmployeeForms
{
    class ManagerList : GenericForm<User>
    {
        private static List<Column> columns = new List<Column>
        {
            new Column() {PropertyName="Id", Title="ID", PropertyType=typeof(string) },
            new Column() {PropertyName="Name", Title="Name", PropertyType=typeof(string) },
            new Column() {PropertyName="Lastname", Title="Lastname", PropertyType=typeof(string) },
            new Column() {PropertyName="DayOfBirth", Title="Day of birth", PropertyType=typeof(DateTime) },
            new Column() {PropertyName="Gender", Title="Gender", PropertyType=typeof(Gender) },
            new Column() {PropertyName="Department", Title="Department", PropertyType=typeof(Department) },
            new Column() {PropertyName="UserType", Title = "Type of user", PropertyType = typeof(UserType) }
        };

        #region Constructors
        public ManagerList(): base(columns, false, false, false, false, false)
        {
            var values = new List<User>();
            foreach (var currentProject in ((Employee)Company.Instance.CurrentUser).EmployeeProjects.Values)
            { 
                if (!values.Contains(currentProject.ProjectManager))
                {
                    values.Add(currentProject.ProjectManager);
                }
            }

            FillTable(values);

            this.Text = "My managers";
        }
        #endregion

        #region Properties
        #endregion

        #region Actions
        #endregion

        #region Methods
        public override void HandleAddEvent() { }

        public override void HandleEditEvent(object selectedItem) { }

        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleRemoveEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem) { }
        #endregion
    }
}
