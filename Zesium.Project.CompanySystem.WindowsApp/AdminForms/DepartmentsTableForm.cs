using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public partial class DepartmentsTableForm : Form
    {
        public DepartmentsTableForm()
        {
            InitializeComponent();
            SetDepartmentsTable();
        }

        #region Action
        private void back_btn_Click(object sender, System.EventArgs e)
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }
        #endregion

        #region Methods
        private void SetDepartmentsTable()
        {
            List<Department> departments = new List<Department>();

            foreach(Department currentDepartment in Company.Instance.Departments.Values)
            {
                departments.Add(currentDepartment);
            }

            departments_dgv.DataSource = departments;
        }

        //private void SetDepartmentsTable()
        //{
        //    DataTable departmentsDataTable = new DataTable();
        //    departmentsDataTable.Columns.Add("ID", typeof(int));
        //    departmentsDataTable.Columns.Add("Name", typeof(string));
        //    departmentsDataTable.Columns.Add("Description", typeof(string));
        //    departmentsDataTable.Columns.Add("Departman aktivan", typeof(bool));

        //    foreach (Department departments in Company.Instance.Departments.Values)
        //    {
        //        departmentsDataTable.Rows.Add(new object[] { departments.DepartmentId, departments.Name, departments.Description, departments.IsDepartmentActive });
        //    }

        //    departments_dgv.DataSource = departmentsDataTable;
        //}
        #endregion

        private void addDep_btn_Click(object sender, System.EventArgs e)
        {
            Hide();
            var addDepartment = new AddDepartmentForm();
            addDepartment.ShowDialog();
            Close();
        }
    }
}
