using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.Model;

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

        public override void HandleAddEvent()
        {
            var addDepartment = new AddDepartmentForm();
            addDepartment.ShowDialog();
        }

        public override void HandleEditEvent(object selectedItem)
        {
            var editDepartmentForm = new AddDepartmentForm(((Department)selectedItem));
            if (((Department)selectedItem).DepartmentId != 0)
            {
                editDepartmentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Departman Undefined ne moze biti izmenjen!");
                CloseDialog();
            }
        }

        public override void HandleRemoveEvent(object selectedItem)
        {
            if(((Department)selectedItem).DepartmentId != 0)
            {
                ((Department)selectedItem).IsDepartmentActive = false;
                CloseDialog();
            }
            else
            {
                MessageBox.Show("Departman Undefined ne moze biti izmenjen!");
                CloseDialog();
            }
        }

        public override void HandlePromoteEvent(object selectedItem) { }

        public override void HandleTaskEvent(object selectedItem) { }
        #region Methods
        public void CloseDialog()
        {
            Hide();
            var departmentForm = new DepartmentsForm();
            departmentForm.ShowDialog();
            Close();
        }
        #endregion
    }
}
