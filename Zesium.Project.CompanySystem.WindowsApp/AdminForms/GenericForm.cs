using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Zesium.Project.CompanySystem.Models;
using Zesium.Project.CompanySystem.WindowsApp.Model;

namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    public abstract partial class GenericForm<T> : Form
    {

        #region Constructors
        public GenericForm(List<Column> columns,bool isAddButtonVisible, bool isEditButtonVisible, bool isRemoveButtonVisible, bool isPromoteButtonVisible, bool isTaskButtonVisible)
        {
            InitializeComponent();
            InitializeTable(columns);
            InitializeButtons(isAddButtonVisible, isEditButtonVisible, isRemoveButtonVisible, isPromoteButtonVisible, isTaskButtonVisible);
        }
        #endregion

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

            
            if (dgvGenericTable.Rows.Count < 1)
            {
                btnEdit.Enabled = false;
                btnRemove.Enabled = false;
                btnPromote.Enabled = false;
                btnTask.Enabled = false;
            }
        }

        public void FilterTableByDepartment(string departmentName)
        {
            //cm vraca ceo objekat, a ne prop kao pm           // bindingcontext pravi razlicite instance istog datasource
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvGenericTable.DataSource];

            // temporary suspension and resumption of data binding in a simple binding scenario
            currencyManager1.SuspendBinding();

            foreach (DataGridViewRow row in dgvGenericTable.Rows)
            {

                if (departmentName != "All" && row.Cells[5].Value.ToString() != departmentName)
                {
                    row.Visible = false;
                }
                else
                {
                    row.Visible = true;
                }
            }
            
            currencyManager1.ResumeBinding();
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
