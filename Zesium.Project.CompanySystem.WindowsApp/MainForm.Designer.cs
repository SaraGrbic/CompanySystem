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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.currentUserDescr_lbl = new System.Windows.Forms.Label();
            this.currentUserName_lbl = new System.Windows.Forms.Label();
            this.currentUserLastname_lbl = new System.Windows.Forms.Label();
            this.departmentDescr_lbl = new System.Windows.Forms.Label();
            this.currentUserDepartment_lbl = new System.Windows.Forms.Label();
            this.btnListOfEmployees = new System.Windows.Forms.Button();
            this.btnListOfDepartments = new System.Windows.Forms.Button();
            this.btnManagerProjects = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnEmployeeProjects = new System.Windows.Forms.Button();
            this.btnManagers = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(669, 16);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // currentUserDescr_lbl
            // 
            this.currentUserDescr_lbl.AutoSize = true;
            this.currentUserDescr_lbl.Location = new System.Drawing.Point(262, 19);
            this.currentUserDescr_lbl.Name = "currentUserDescr_lbl";
            this.currentUserDescr_lbl.Size = new System.Drawing.Size(141, 13);
            this.currentUserDescr_lbl.TabIndex = 1;
            this.currentUserDescr_lbl.Text = "Trenutno ulogovani korisnik:";
            // 
            // currentUserName_lbl
            // 
            this.currentUserName_lbl.AutoSize = true;
            this.currentUserName_lbl.Location = new System.Drawing.Point(409, 20);
            this.currentUserName_lbl.Name = "currentUserName_lbl";
            this.currentUserName_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserName_lbl.TabIndex = 2;
            this.currentUserName_lbl.Text = "label2";
            // 
            // currentUserLastname_lbl
            // 
            this.currentUserLastname_lbl.AutoSize = true;
            this.currentUserLastname_lbl.Location = new System.Drawing.Point(471, 20);
            this.currentUserLastname_lbl.Name = "currentUserLastname_lbl";
            this.currentUserLastname_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserLastname_lbl.TabIndex = 3;
            this.currentUserLastname_lbl.Text = "label3";
            // 
            // departmentDescr_lbl
            // 
            this.departmentDescr_lbl.AutoSize = true;
            this.departmentDescr_lbl.Location = new System.Drawing.Point(265, 61);
            this.departmentDescr_lbl.Name = "departmentDescr_lbl";
            this.departmentDescr_lbl.Size = new System.Drawing.Size(107, 13);
            this.departmentDescr_lbl.TabIndex = 4;
            this.departmentDescr_lbl.Text = "Departman korisnika:";
            // 
            // currentUserDepartment_lbl
            // 
            this.currentUserDepartment_lbl.AutoSize = true;
            this.currentUserDepartment_lbl.Location = new System.Drawing.Point(378, 61);
            this.currentUserDepartment_lbl.Name = "currentUserDepartment_lbl";
            this.currentUserDepartment_lbl.Size = new System.Drawing.Size(35, 13);
            this.currentUserDepartment_lbl.TabIndex = 5;
            this.currentUserDepartment_lbl.Text = "label5";
            // 
            // btnListOfEmployees
            // 
            this.btnListOfEmployees.Location = new System.Drawing.Point(310, 153);
            this.btnListOfEmployees.Name = "btnListOfEmployees";
            this.btnListOfEmployees.Size = new System.Drawing.Size(122, 46);
            this.btnListOfEmployees.TabIndex = 10;
            this.btnListOfEmployees.Text = "List of all employees";
            this.btnListOfEmployees.UseVisualStyleBackColor = true;
            this.btnListOfEmployees.Visible = false;
            this.btnListOfEmployees.Click += new System.EventHandler(this.btnListOfEmployees_Click);
            // 
            // btnListOfDepartments
            // 
            this.btnListOfDepartments.Location = new System.Drawing.Point(143, 153);
            this.btnListOfDepartments.Name = "btnListOfDepartments";
            this.btnListOfDepartments.Size = new System.Drawing.Size(122, 46);
            this.btnListOfDepartments.TabIndex = 11;
            this.btnListOfDepartments.Text = "List of all departments";
            this.btnListOfDepartments.UseVisualStyleBackColor = true;
            this.btnListOfDepartments.Visible = false;
            this.btnListOfDepartments.Click += new System.EventHandler(this.btnListOfDepartments_Click);
            // 
            // btnManagerProjects
            // 
            this.btnManagerProjects.Location = new System.Drawing.Point(154, 153);
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
            this.btnTasks.Location = new System.Drawing.Point(322, 153);
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
            this.btnEmployeeProjects.Location = new System.Drawing.Point(146, 153);
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
            this.btnManagers.Location = new System.Drawing.Point(316, 153);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(119, 46);
            this.btnManagers.TabIndex = 15;
            this.btnManagers.Text = "List of all managers";
            this.btnManagers.UseVisualStyleBackColor = true;
            this.btnManagers.Visible = false;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Location = new System.Drawing.Point(481, 153);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(119, 46);
            this.btnCreateAdmin.TabIndex = 17;
            this.btnCreateAdmin.Text = "Create admin";
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Visible = false;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(757, 24);
            this.menuStripOptions.TabIndex = 18;
            this.menuStripOptions.Text = "Options";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCompanyToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveCompanyToolStripMenuItem
            // 
            this.saveCompanyToolStripMenuItem.Name = "saveCompanyToolStripMenuItem";
            this.saveCompanyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveCompanyToolStripMenuItem.Text = "Save Company";
            this.saveCompanyToolStripMenuItem.Click += new System.EventHandler(this.saveCompanyToolStripMenuItem_Click);
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
            this.Controls.Add(this.btnListOfDepartments);
            this.Controls.Add(this.btnListOfEmployees);
            this.Controls.Add(this.currentUserDepartment_lbl);
            this.Controls.Add(this.departmentDescr_lbl);
            this.Controls.Add(this.currentUserLastname_lbl);
            this.Controls.Add(this.currentUserName_lbl);
            this.Controls.Add(this.currentUserDescr_lbl);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.menuStripOptions);
            this.MainMenuStrip = this.menuStripOptions;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label currentUserDescr_lbl;
        private System.Windows.Forms.Label currentUserName_lbl;
        private System.Windows.Forms.Label currentUserLastname_lbl;
        private System.Windows.Forms.Label departmentDescr_lbl;
        private System.Windows.Forms.Label currentUserDepartment_lbl;
        private System.Windows.Forms.Button btnListOfEmployees;
        private System.Windows.Forms.Button btnListOfDepartments;
        private System.Windows.Forms.Button btnManagerProjects;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnEmployeeProjects;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCompanyToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}