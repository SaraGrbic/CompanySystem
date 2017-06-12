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
            this.btnManagerProjects = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnEmployeeProjects = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
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
            this.currentUserDescr_lbl.Location = new System.Drawing.Point(12, 16);
            this.currentUserDescr_lbl.Name = "currentUserDescr_lbl";
            this.currentUserDescr_lbl.Size = new System.Drawing.Size(141, 13);
            this.currentUserDescr_lbl.TabIndex = 1;
            this.currentUserDescr_lbl.Text = "Trenutno ulogovani korisnik:";
            // 
            // currentUserName_lbl
            // 
            this.currentUserName_lbl.AutoSize = true;
            this.currentUserName_lbl.Location = new System.Drawing.Point(159, 17);
            this.currentUserName_lbl.Name = "currentUserName_lbl";
            this.currentUserName_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserName_lbl.TabIndex = 2;
            this.currentUserName_lbl.Text = "label2";
            // 
            // currentUserLastname_lbl
            // 
            this.currentUserLastname_lbl.AutoSize = true;
            this.currentUserLastname_lbl.Location = new System.Drawing.Point(221, 17);
            this.currentUserLastname_lbl.Name = "currentUserLastname_lbl";
            this.currentUserLastname_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserLastname_lbl.TabIndex = 3;
            this.currentUserLastname_lbl.Text = "label3";
            // 
            // departmentDescr_lbl
            // 
            this.departmentDescr_lbl.AutoSize = true;
            this.departmentDescr_lbl.Location = new System.Drawing.Point(15, 58);
            this.departmentDescr_lbl.Name = "departmentDescr_lbl";
            this.departmentDescr_lbl.Size = new System.Drawing.Size(107, 13);
            this.departmentDescr_lbl.TabIndex = 4;
            this.departmentDescr_lbl.Text = "Departman korisnika:";
            // 
            // currentUserDepartment_lbl
            // 
            this.currentUserDepartment_lbl.AutoSize = true;
            this.currentUserDepartment_lbl.Location = new System.Drawing.Point(128, 58);
            this.currentUserDepartment_lbl.Name = "currentUserDepartment_lbl";
            this.currentUserDepartment_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserDepartment_lbl.TabIndex = 5;
            this.currentUserDepartment_lbl.Text = "label5";
            // 
            // listOfEmployees_btn
            // 
            this.listOfEmployees_btn.Location = new System.Drawing.Point(391, 114);
            this.listOfEmployees_btn.Name = "listOfEmployees_btn";
            this.listOfEmployees_btn.Size = new System.Drawing.Size(122, 46);
            this.listOfEmployees_btn.TabIndex = 10;
            this.listOfEmployees_btn.Text = "List of all employees";
            this.listOfEmployees_btn.UseVisualStyleBackColor = true;
            this.listOfEmployees_btn.Visible = false;
            this.listOfEmployees_btn.Click += new System.EventHandler(this.listOfEmployees_btn_Click);
            // 
            // listOfDepartments_btn
            // 
            this.listOfDepartments_btn.Location = new System.Drawing.Point(224, 114);
            this.listOfDepartments_btn.Name = "listOfDepartments_btn";
            this.listOfDepartments_btn.Size = new System.Drawing.Size(122, 46);
            this.listOfDepartments_btn.TabIndex = 11;
            this.listOfDepartments_btn.Text = "List of all departments";
            this.listOfDepartments_btn.UseVisualStyleBackColor = true;
            this.listOfDepartments_btn.Visible = false;
            this.listOfDepartments_btn.Click += new System.EventHandler(this.listOfDepartments_btn_Click_1);
            // 
            // btnManagerProjects
            // 
            this.btnManagerProjects.Location = new System.Drawing.Point(224, 114);
            this.btnManagerProjects.Name = "btnManagerProjects";
            this.btnManagerProjects.Size = new System.Drawing.Size(122, 46);
            this.btnManagerProjects.TabIndex = 12;
            this.btnManagerProjects.Text = "List of all projects";
            this.btnManagerProjects.UseVisualStyleBackColor = true;
            this.btnManagerProjects.Visible = false;
            this.btnManagerProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(391, 114);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(122, 46);
            this.btnTasks.TabIndex = 13;
            this.btnTasks.Text = "List of all tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Visible = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnEmployeeProjects
            // 
            this.btnEmployeeProjects.Location = new System.Drawing.Point(224, 114);
            this.btnEmployeeProjects.Name = "btnEmployeeProjects";
            this.btnEmployeeProjects.Size = new System.Drawing.Size(119, 46);
            this.btnEmployeeProjects.TabIndex = 14;
            this.btnEmployeeProjects.Text = "List of all projects";
            this.btnEmployeeProjects.UseVisualStyleBackColor = true;
            this.btnEmployeeProjects.Visible = false;
            this.btnEmployeeProjects.Click += new System.EventHandler(this.btnEmployeeProjects_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.Location = new System.Drawing.Point(394, 114);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(119, 46);
            this.btnManagers.TabIndex = 15;
            this.btnManagers.Text = "List of all managers";
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Visible = false;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Location = new System.Drawing.Point(562, 114);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(119, 46);
            this.btnCreateAdmin.TabIndex = 17;
            this.btnCreateAdmin.Text = "Create admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Visible = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 357);
            this.Controls.Add(this.btnCreateAdmin);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnEmployeeProjects);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnManagerProjects);
            this.Controls.Add(this.listOfDepartments_btn);
            this.Controls.Add(this.listOfEmployees_btn);
            this.Controls.Add(this.currentUserDepartment_lbl);
            this.Controls.Add(this.departmentDescr_lbl);
            this.Controls.Add(this.currentUserLastname_lbl);
            this.Controls.Add(this.currentUserName_lbl);
            this.Controls.Add(this.currentUserDescr_lbl);
            this.Controls.Add(this.signOut_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Button btnManagerProjects;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnEmployeeProjects;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCreateAdmin;
    }
}