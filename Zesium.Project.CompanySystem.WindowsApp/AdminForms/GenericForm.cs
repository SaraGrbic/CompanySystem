using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.Model;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public abstract partial class GenericForm<T> : Form
    {
        public GenericForm(List<Column> columns,bool isAddButtonVisible, bool isEditButtonVisible, bool isRemoveButtonVisible, bool isPromoteButtonVisible, bool isTaskButtonVisible)
        {
            InitializeComponent();
            InitializeTable(columns);
            InitializeButtons(isAddButtonVisible, isEditButtonVisible, isRemoveButtonVisible, isPromoteButtonVisible, isTaskButtonVisible);
        }

        #region Action

        private void back_btn_Click(object sender, System.EventArgs e)
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.ShowDialog();
            Close();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Hide();
            HandleAddEvent();
            Close();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            Hide();
            HandleEditEvent(dgvGenericTable.CurrentRow.DataBoundItem);
            Close();
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            Hide();
            HandleRemoveEvent(dgvGenericTable.CurrentRow.DataBoundItem);
            Close();
        }

        private void btnPromote_Click(object sender, System.EventArgs e)
        {
            Hide();
            HandlePromoteEvent(dgvGenericTable.CurrentRow.DataBoundItem);
            Close();
        }

        private void btnTask_Click(object sender, System.EventArgs e)
        {
            Hide();
            HandleTaskEvent(dgvGenericTable.CurrentRow.DataBoundItem);
            Close();
        }
        #endregion

        #region Public Methods

        public void FillTable(List<T> values)
        {
            dgvGenericTable.DataSource = values;
        }

        public abstract void HandleAddEvent();

        public abstract void HandleEditEvent(object selectedItem);

        public abstract void HandleRemoveEvent(object selectedItem);

        public abstract void HandlePromoteEvent(object selectedItem);

        public abstract void HandleTaskEvent(object selectedItem);
        #endregion

        #region Private Methods
        private void InitializeButtons(bool isAddButtonVisible, bool isEditButtonVisible, bool isRemoveButtonVisible, bool isPromoteButtonVisible, bool isTaskButtonVisible)
        {
            btnAdd.Visible = isAddButtonVisible;
            btnEdit.Visible = isEditButtonVisible;
            btnRemove.Visible = isRemoveButtonVisible;
            btnPromote.Visible = isPromoteButtonVisible;
            btnTask.Visible = isTaskButtonVisible;
        }

        private void InitializeTable(List<Column> columns)
        {
            dgvGenericTable.AutoGenerateColumns = false;

            foreach (var item in columns)
            {
                DataGridViewColumn column;
                
                if(item.PropertyType == typeof(bool))
                {
                    column = new DataGridViewCheckBoxColumn();
                }
                else
                {
                    column = new DataGridViewTextBoxColumn();
                }
                    
                column.DataPropertyName = item.PropertyName;
                column.Name = item.Title;
                dgvGenericTable.Columns.Add(column);
            } 
        }

        #endregion
    }
}
