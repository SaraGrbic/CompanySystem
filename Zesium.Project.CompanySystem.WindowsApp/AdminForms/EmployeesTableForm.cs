using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public partial class EmployeesTableForm : Form
    {
        //public static int UserIndex { get; set; }

        public EmployeesTableForm()
        {
            InitializeComponent();
            SetEmployeesTable();
        }
        #region Actions
        private void back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void editEmployee_btn_Click(object sender, EventArgs e)
        {
            Hide();
            var editEmployeeForm = new EditEmployeeForm(((User)(employees_dgv.CurrentRow.DataBoundItem)));
            editEmployeeForm.ShowDialog();
            Close();
        }

        //private void employees_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    UserIndex = e.RowIndex;
        //}

        #endregion

        #region Methods
        //private void SetEmployeesTable()
        //{
        //    DataTable employeesDataTable = new DataTable();
        //    employeesDataTable.Columns.Add("ID", typeof(int));
        //    employeesDataTable.Columns.Add("Name", typeof(string));
        //    employeesDataTable.Columns.Add("Lastname", typeof(string));
        //    employeesDataTable.Columns.Add("Gender", typeof(Gender));
        //    employeesDataTable.Columns.Add("Department", typeof(Department));
        //    employeesDataTable.Columns.Add("Day of birth", typeof(DateTime));

        //    foreach (User user in Company.Instance.Users.Values)
        //    {
        //        employeesDataTable.Rows.Add(new object[] { user.Id, user.Name, user.Lastname, user.Gender, user.Department, user.DayOfBirth });
        //    }

        //    employees_dgv.DataSource = employeesDataTable;
        //}

        private void SetEmployeesTable()
        {
            List<User> users = new List<User>();

            foreach(User currentUser in Company.Instance.Users.Values)
            {
                users.Add(currentUser);
            }

            employees_dgv.DataSource = users;
        }

        //public static User GetUserBySelectedCell()
        //{
        //    if (!Company.Instance.Users.ContainsKey(UserIndex))
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return Company.Instance.Users[UserIndex];
        //    }
        //}
        #endregion
    }
}
