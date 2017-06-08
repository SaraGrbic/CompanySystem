﻿using System;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.Models.Services;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public partial class AddDepartmentForm : Form
    {
        #region Constructors
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        public AddDepartmentForm(Department department)
        {
            InitializeComponent();
            SelectedDepartment = department;
            ShowSelectedDepartment(department);
        }
        #endregion

        #region Properties
        public Department SelectedDepartment { get; set; }
        #endregion

        #region Actions
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void createDepartment_btn_Click(object sender, EventArgs e)
        {
            if (SelectedDepartment == null)
            {
                InputServices.CreateDepartment(depName_txtbx.Text, depDescription_txtbx.Text);
                CloseDialog();
            }
            else
            {
                ChangeSelectedDepartment(SelectedDepartment);
                CloseDialog();
            }
        }
        #endregion

        #region Methods
        private void ChangeSelectedDepartment(Department department)
        {
            department.Name = depName_txtbx.Text;
            department.Description = depDescription_txtbx.Text;
        }

        private void ShowSelectedDepartment(Department department)
        {
            depName_txtbx.Text = department.Name;
            depDescription_txtbx.Text = department.Description;
        }

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
