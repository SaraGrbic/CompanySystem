namespace Zesium.Project.CompanySystem.WindowsApp
{
    partial class MainForm
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
            this.signOut_btn = new System.Windows.Forms.Button();
            this.currentUserDescr_lbl = new System.Windows.Forms.Label();
            this.currentUserName_lbl = new System.Windows.Forms.Label();
            this.currentUserLastname_lbl = new System.Windows.Forms.Label();
            this.departmentDescr_lbl = new System.Windows.Forms.Label();
            this.currentUserDepartment_lbl = new System.Windows.Forms.Label();
            this.listOfEmployees_btn = new System.Windows.Forms.Button();
            this.listOfDepartments_btn = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signOut_btn
            // 
            this.signOut_btn.Location = new System.Drawing.Point(669, 16);
            this.signOut_btn.Name = "signOut_btn";
            this.signOut_btn.Size = new System.Drawing.Size(75, 23);
            this.signOut_btn.TabIndex = 0;
            this.signOut_btn.Text = "Sign Out";
            this.signOut_btn.UseVisualStyleBackColor = true;
            this.signOut_btn.Click += new System.EventHandler(this.signOut_btn_Click);
            // 
            // currentUserDescr_lbl
            // 
            this.currentUserDescr_lbl.AutoSize = true;
            this.currentUserDescr_lbl.Location = new System.Drawing.Point(13, 21);
            this.currentUserDescr_lbl.Name = "currentUserDescr_lbl";
            this.currentUserDescr_lbl.Size = new System.Drawing.Size(141, 13);
            this.currentUserDescr_lbl.TabIndex = 1;
            this.currentUserDescr_lbl.Text = "Trenutno ulogovani korisnik:";
            // 
            // currentUserName_lbl
            // 
            this.currentUserName_lbl.AutoSize = true;
            this.currentUserName_lbl.Location = new System.Drawing.Point(160, 22);
            this.currentUserName_lbl.Name = "currentUserName_lbl";
            this.currentUserName_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserName_lbl.TabIndex = 2;
            this.currentUserName_lbl.Text = "label2";
            // 
            // currentUserLastname_lbl
            // 
            this.currentUserLastname_lbl.AutoSize = true;
            this.currentUserLastname_lbl.Location = new System.Drawing.Point(222, 22);
            this.currentUserLastname_lbl.Name = "currentUserLastname_lbl";
            this.currentUserLastname_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserLastname_lbl.TabIndex = 3;
            this.currentUserLastname_lbl.Text = "label3";
            // 
            // departmentDescr_lbl
            // 
            this.departmentDescr_lbl.AutoSize = true;
            this.departmentDescr_lbl.Location = new System.Drawing.Point(16, 63);
            this.departmentDescr_lbl.Name = "departmentDescr_lbl";
            this.departmentDescr_lbl.Size = new System.Drawing.Size(107, 13);
            this.departmentDescr_lbl.TabIndex = 4;
            this.departmentDescr_lbl.Text = "Departman korisnika:";
            // 
            // currentUserDepartment_lbl
            // 
            this.currentUserDepartment_lbl.AutoSize = true;
            this.currentUserDepartment_lbl.Location = new System.Drawing.Point(129, 63);
            this.currentUserDepartment_lbl.Name = "currentUserDepartment_lbl";
            this.currentUserDepartment_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserDepartment_lbl.TabIndex = 5;
            this.currentUserDepartment_lbl.Text = "label5";
            // 
            // listOfEmployees_btn
            // 
            this.listOfEmployees_btn.Location = new System.Drawing.Point(16, 149);
            this.listOfEmployees_btn.Name = "listOfEmployees_btn";
            this.listOfEmployees_btn.Size = new System.Drawing.Size(125, 46);
            this.listOfEmployees_btn.TabIndex = 10;
            this.listOfEmployees_btn.Text = "List of all employees";
            this.listOfEmployees_btn.UseVisualStyleBackColor = true;
            this.listOfEmployees_btn.Visible = false;
            this.listOfEmployees_btn.Click += new System.EventHandler(this.listOfEmployees_btn_Click);
            // 
            // listOfDepartments_btn
            // 
            this.listOfDepartments_btn.Location = new System.Drawing.Point(16, 89);
            this.listOfDepartments_btn.Name = "listOfDepartments_btn";
            this.listOfDepartments_btn.Size = new System.Drawing.Size(122, 46);
            this.listOfDepartments_btn.TabIndex = 11;
            this.listOfDepartments_btn.Text = "List of all departments";
            this.listOfDepartments_btn.UseVisualStyleBackColor = true;
            this.listOfDepartments_btn.Visible = false;
            this.listOfDepartments_btn.Click += new System.EventHandler(this.listOfDepartments_btn_Click_1);
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(183, 89);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(122, 46);
            this.btnProjects.TabIndex = 12;
            this.btnProjects.Text = "List of all projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Visible = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(183, 149);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(122, 46);
            this.btnTasks.TabIndex = 13;
            this.btnTasks.Text = "List of all tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Visible = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 357);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.listOfDepartments_btn);
            this.Controls.Add(this.listOfEmployees_btn);
            this.Controls.Add(this.currentUserDepartment_lbl);
            this.Controls.Add(this.departmentDescr_lbl);
            this.Controls.Add(this.currentUserLastname_lbl);
            this.Controls.Add(this.currentUserName_lbl);
            this.Controls.Add(this.currentUserDescr_lbl);
            this.Controls.Add(this.signOut_btn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signOut_btn;
        private System.Windows.Forms.Label currentUserDescr_lbl;
        private System.Windows.Forms.Label currentUserName_lbl;
        private System.Windows.Forms.Label currentUserLastname_lbl;
        private System.Windows.Forms.Label departmentDescr_lbl;
        private System.Windows.Forms.Label currentUserDepartment_lbl;
        private System.Windows.Forms.Button listOfEmployees_btn;
        private System.Windows.Forms.Button listOfDepartments_btn;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnTasks;
    }
}