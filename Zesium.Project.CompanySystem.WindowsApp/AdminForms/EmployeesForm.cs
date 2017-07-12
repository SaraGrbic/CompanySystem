using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.Model;
using Zesium.Project.CompanySystem.BussinesLaye;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public class EmployeesForm : GenericForm<User>
    {
        private AccountService accountService;
        private CompanySystemService companyService;
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
        public EmployeesForm(): base(columns, false, true, false, true, false)
        {
            accountService = new AccountService();
            companyService = new CompanySystemService();
            FillTable(accountService.GetAllUsers());

            this.Text = "Employees";

            //pravljenje cbox-a samo za ovu formu
            var cBoxDepartments = new ComboBox();
            cBoxDepartments.Location = new Point(800, 14);
            cBoxDepartments.DropDownStyle = ComboBoxStyle.DropDownList;

            var listOfDepartmentNames = new List<string>();
            foreach (var department in companyService.GetAllDepartments())
            {
                if (department.IsDepartmentActive)
                {
                    listOfDepartmentNames.Add(department.Name);
                }
            }

            listOfDepartmentNames.Insert(0, "All");

            cBoxDepartments.DataSource = listOfDepartmentNames;
            
            cBoxDepartments.SelectionChangeCommitted += CBoxDepartments_SelectionChangeCommitted;

            this.Controls.Add(cBoxDepartments);
        }
        #endregion

        #region Actions
        private void CBoxDepartments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterTableByDepartment(((ComboBox)sender).SelectedValue.ToString());
        }

        public override void HandleAddEvent() { }

        public override void HandleRemoveEvent(object selectedItem) { }

        public override void HandleEditEvent(object selectedItem)
        {
            if (((User)selectedItem).Id != 1)
            {
                var editEmployeeForm = new EditEmployeeForm(((User)selectedItem));
                editEmployeeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Admin Almighty ne moze biti izmenjen!");
                CloseDialog();
            }
        }

        public override void HandlePromoteEvent(object selectedItem)
        {
            if (((User)selectedItem).UserType != UserType.Employee)
            {
                MessageBox.Show("Dozvoljeno je promovisanje samo zaposlenih tipa Employee. Odaberite ponovo.");
                CloseDialog();
            }
            else
            {
                Hide();
                var promoteForm = new PromoteEmployeeForm(((User)selectedItem));
                promoteForm.ShowDialog();
                Close();
            }
        }

        public override void HandleTaskEvent(object selectedItem) { }
        #endregion

        #region Methods
        private void CloseDialog()
        {
            Hide();
            var employeeForm = new EmployeesForm();
            employeeForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
