namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    partial class EditEmployeeForm
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.department_combobx = new System.Windows.Forms.ComboBox();
            this.dayOfBirth_pckr = new System.Windows.Forms.DateTimePicker();
            this.department_lbl = new System.Windows.Forms.Label();
            this.genderFemale_rbtn = new System.Windows.Forms.RadioButton();
            this.genderMale_rbtn = new System.Windows.Forms.RadioButton();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.dayOfBirth_lbl = new System.Windows.Forms.Label();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.lastName_txtbx = new System.Windows.Forms.TextBox();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.editAccount_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(39, 31);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(24, 13);
            this.name_lbl.TabIndex = 37;
            this.name_lbl.Text = "Ime";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(350, 351);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(119, 23);
            this.cancel_btn.TabIndex = 36;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // department_combobx
            // 
            this.department_combobx.FormattingEnabled = true;
            this.department_combobx.Location = new System.Drawing.Point(172, 247);
            this.department_combobx.Name = "department_combobx";
            this.department_combobx.Size = new System.Drawing.Size(169, 21);
            this.department_combobx.TabIndex = 35;
            // 
            // dayOfBirth_pckr
            // 
            this.dayOfBirth_pckr.Location = new System.Drawing.Point(172, 152);
            this.dayOfBirth_pckr.Name = "dayOfBirth_pckr";
            this.dayOfBirth_pckr.Size = new System.Drawing.Size(200, 20);
            this.dayOfBirth_pckr.TabIndex = 34;
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.Location = new System.Drawing.Point(36, 255);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(110, 13);
            this.department_lbl.TabIndex = 33;
            this.department_lbl.Text = "Departman kompanije";
            // 
            // genderFemale_rbtn
            // 
            this.genderFemale_rbtn.AutoSize = true;
            this.genderFemale_rbtn.Location = new System.Drawing.Point(253, 208);
            this.genderFemale_rbtn.Name = "genderFemale_rbtn";
            this.genderFemale_rbtn.Size = new System.Drawing.Size(61, 17);
            this.genderFemale_rbtn.TabIndex = 32;
            this.genderFemale_rbtn.TabStop = true;
            this.genderFemale_rbtn.Text = "Žensko";
            this.genderFemale_rbtn.UseVisualStyleBackColor = true;
            // 
            // genderMale_rbtn
            // 
            this.genderMale_rbtn.AutoSize = true;
            this.genderMale_rbtn.Location = new System.Drawing.Point(172, 208);
            this.genderMale_rbtn.Name = "genderMale_rbtn";
            this.genderMale_rbtn.Size = new System.Drawing.Size(57, 17);
            this.genderMale_rbtn.TabIndex = 31;
            this.genderMale_rbtn.TabStop = true;
            this.genderMale_rbtn.Text = "Muško";
            this.genderMale_rbtn.UseVisualStyleBackColor = true;
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(36, 208);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(22, 13);
            this.gender_lbl.TabIndex = 30;
            this.gender_lbl.Text = "Pol";
            // 
            // dayOfBirth_lbl
            // 
            this.dayOfBirth_lbl.AutoSize = true;
            this.dayOfBirth_lbl.Location = new System.Drawing.Point(36, 159);
            this.dayOfBirth_lbl.Name = "dayOfBirth_lbl";
            this.dayOfBirth_lbl.Size = new System.Drawing.Size(77, 13);
            this.dayOfBirth_lbl.TabIndex = 29;
            this.dayOfBirth_lbl.Text = "Datum rođenja";
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Location = new System.Drawing.Point(36, 93);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(44, 13);
            this.lastName_lbl.TabIndex = 28;
            this.lastName_lbl.Text = "Prezime";
            // 
            // lastName_txtbx
            // 
            this.lastName_txtbx.Location = new System.Drawing.Point(172, 86);
            this.lastName_txtbx.Name = "lastName_txtbx";
            this.lastName_txtbx.Size = new System.Drawing.Size(134, 20);
            this.lastName_txtbx.TabIndex = 27;
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(172, 24);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(134, 20);
            this.name_txtbx.TabIndex = 26;
            // 
            // editAccount_btn
            // 
            this.editAccount_btn.Location = new System.Drawing.Point(12, 351);
            this.editAccount_btn.Name = "editAccount_btn";
            this.editAccount_btn.Size = new System.Drawing.Size(130, 23);
            this.editAccount_btn.TabIndex = 21;
            this.editAccount_btn.Text = "Edit employee";
            this.editAccount_btn.Click += new System.EventHandler(this.editAccount_btn_Click);
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 382);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.department_combobx);
            this.Controls.Add(this.dayOfBirth_pckr);
            this.Controls.Add(this.department_lbl);
            this.Controls.Add(this.genderFemale_rbtn);
            this.Controls.Add(this.genderMale_rbtn);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.dayOfBirth_lbl);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.lastName_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Controls.Add(this.editAccount_btn);
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ComboBox department_combobx;
        private System.Windows.Forms.DateTimePicker dayOfBirth_pckr;
        private System.Windows.Forms.Label department_lbl;
        private System.Windows.Forms.RadioButton genderFemale_rbtn;
        private System.Windows.Forms.RadioButton genderMale_rbtn;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.Label dayOfBirth_lbl;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.TextBox lastName_txtbx;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.Button editAccount_btn;
    }
}