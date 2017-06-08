namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    partial class DepartmentsTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.departments_dgv = new System.Windows.Forms.DataGridView();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDepartmentActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addDep_btn = new System.Windows.Forms.Button();
            this.editDep_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departments_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // departments_dgv
            // 
            this.departments_dgv.AutoGenerateColumns = false;
            this.departments_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departments_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departments_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isDepartmentActiveDataGridViewCheckBoxColumn});
            this.departments_dgv.DataSource = this.departmentBindingSource;
            this.departments_dgv.Location = new System.Drawing.Point(2, 46);
            this.departments_dgv.Name = "departments_dgv";
            this.departments_dgv.Size = new System.Drawing.Size(1289, 567);
            this.departments_dgv.TabIndex = 0;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDepartmentActiveDataGridViewCheckBoxColumn
            // 
            this.isDepartmentActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsDepartmentActive";
            this.isDepartmentActiveDataGridViewCheckBoxColumn.HeaderText = "Department is active";
            this.isDepartmentActiveDataGridViewCheckBoxColumn.Name = "isDepartmentActiveDataGridViewCheckBoxColumn";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Zesium.Project.CompanySystem.Models.Department);
            // 
            // addDep_btn
            // 
            this.addDep_btn.Location = new System.Drawing.Point(12, 13);
            this.addDep_btn.Name = "addDep_btn";
            this.addDep_btn.Size = new System.Drawing.Size(113, 23);
            this.addDep_btn.TabIndex = 1;
            this.addDep_btn.Text = "Add department";
            this.addDep_btn.UseVisualStyleBackColor = true;
            this.addDep_btn.Click += new System.EventHandler(this.addDep_btn_Click);
            // 
            // editDep_btn
            // 
            this.editDep_btn.Location = new System.Drawing.Point(192, 13);
            this.editDep_btn.Name = "editDep_btn";
            this.editDep_btn.Size = new System.Drawing.Size(104, 23);
            this.editDep_btn.TabIndex = 3;
            this.editDep_btn.Text = "Edit department";
            this.editDep_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(622, 13);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(87, 23);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // DepartmentsTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 614);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.editDep_btn);
            this.Controls.Add(this.addDep_btn);
            this.Controls.Add(this.departments_dgv);
            this.Name = "DepartmentsTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of all departments";
            ((System.ComponentModel.ISupportInitialize)(this.departments_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView departments_dgv;
        private System.Windows.Forms.Button addDep_btn;
        private System.Windows.Forms.Button editDep_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDepartmentActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}