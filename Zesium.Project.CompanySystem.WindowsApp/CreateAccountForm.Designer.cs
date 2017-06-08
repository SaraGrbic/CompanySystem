namespace Zesium.Project.CompanySystem.WindowsApp
{
    partial class CreateAccountForm
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
            this.createAccount_btn = new System.Windows.Forms.Button();
            this.username_lbl = new System.Windows.Forms.Label();
            this.username_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.lastName_txtbx = new System.Windows.Forms.TextBox();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.dayOfBirth_lbl = new System.Windows.Forms.Label();
            this.gender_lbl = new System.Windows.Forms.Label();
            this.genderMale_rbtn = new System.Windows.Forms.RadioButton();
            this.genderFemale_rbtn = new System.Windows.Forms.RadioButton();
            this.department_lbl = new System.Windows.Forms.Label();
            this.dayOfBirth_pckr = new System.Windows.Forms.DateTimePicker();
            this.department_combobx = new System.Windows.Forms.ComboBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.Location = new System.Drawing.Point(12, 475);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(130, 23);
            this.createAccount_btn.TabIndex = 0;
            this.createAccount_btn.Text = "Create Account";
            this.createAccount_btn.Click += new System.EventHandler(this.createAccount_btn_Click);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(36, 30);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(75, 13);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Korisničko ime";
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(172, 27);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(134, 20);
            this.username_txtbx.TabIndex = 2;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(172, 87);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(134, 20);
            this.password_txtbx.TabIndex = 3;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(39, 94);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(28, 13);
            this.password_lbl.TabIndex = 4;
            this.password_lbl.Text = "Šifra";
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(172, 148);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(134, 20);
            this.name_txtbx.TabIndex = 5;
            // 
            // lastName_txtbx
            // 
            this.lastName_txtbx.Location = new System.Drawing.Point(172, 210);
            this.lastName_txtbx.Name = "lastName_txtbx";
            this.lastName_txtbx.Size = new System.Drawing.Size(134, 20);
            this.lastName_txtbx.TabIndex = 7;
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.AutoSize = true;
            this.lastName_lbl.Location = new System.Drawing.Point(36, 217);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(70, 13);
            this.lastName_lbl.TabIndex = 8;
            this.lastName_lbl.Text = "Vaše prezime";
            // 
            // dayOfBirth_lbl
            // 
            this.dayOfBirth_lbl.AutoSize = true;
            this.dayOfBirth_lbl.Location = new System.Drawing.Point(36, 283);
            this.dayOfBirth_lbl.Name = "dayOfBirth_lbl";
            this.dayOfBirth_lbl.Size = new System.Drawing.Size(96, 13);
            this.dayOfBirth_lbl.TabIndex = 10;
            this.dayOfBirth_lbl.Text = "Vaš datum rođenja";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(36, 332);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(22, 13);
            this.gender_lbl.TabIndex = 11;
            this.gender_lbl.Text = "Pol";
            // 
            // genderMale_rbtn
            // 
            this.genderMale_rbtn.AutoSize = true;
            this.genderMale_rbtn.Location = new System.Drawing.Point(172, 332);
            this.genderMale_rbtn.Name = "genderMale_rbtn";
            this.genderMale_rbtn.Size = new System.Drawing.Size(57, 17);
            this.genderMale_rbtn.TabIndex = 12;
            this.genderMale_rbtn.TabStop = true;
            this.genderMale_rbtn.Text = "Muško";
            this.genderMale_rbtn.UseVisualStyleBackColor = true;
            // 
            // genderFemale_rbtn
            // 
            this.genderFemale_rbtn.AutoSize = true;
            this.genderFemale_rbtn.Location = new System.Drawing.Point(253, 332);
            this.genderFemale_rbtn.Name = "genderFemale_rbtn";
            this.genderFemale_rbtn.Size = new System.Drawing.Size(61, 17);
            this.genderFemale_rbtn.TabIndex = 13;
            this.genderFemale_rbtn.TabStop = true;
            this.genderFemale_rbtn.Text = "Žensko";
            this.genderFemale_rbtn.UseVisualStyleBackColor = true;
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.Location = new System.Drawing.Point(36, 379);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(110, 13);
            this.department_lbl.TabIndex = 15;
            this.department_lbl.Text = "Departman kompanije";
            // 
            // dayOfBirth_pckr
            // 
            this.dayOfBirth_pckr.Location = new System.Drawing.Point(172, 276);
            this.dayOfBirth_pckr.Name = "dayOfBirth_pckr";
            this.dayOfBirth_pckr.Size = new System.Drawing.Size(200, 20);
            this.dayOfBirth_pckr.TabIndex = 16;
            // 
            // department_combobx
            // 
            this.department_combobx.FormattingEnabled = true;
            this.department_combobx.Location = new System.Drawing.Point(172, 371);
            this.department_combobx.Name = "department_combobx";
            this.department_combobx.Size = new System.Drawing.Size(169, 21);
            this.department_combobx.TabIndex = 17;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(403, 475);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(119, 23);
            this.cancel_btn.TabIndex = 18;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(39, 155);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(50, 13);
            this.name_lbl.TabIndex = 20;
            this.name_lbl.Text = "Vaše ime";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 523);
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
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.username_txtbx);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.createAccount_btn);
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccount_btn;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.TextBox lastName_txtbx;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.Label dayOfBirth_lbl;
        private System.Windows.Forms.Label gender_lbl;
        private System.Windows.Forms.RadioButton genderMale_rbtn;
        private System.Windows.Forms.RadioButton genderFemale_rbtn;
        private System.Windows.Forms.Label department_lbl;
        private System.Windows.Forms.DateTimePicker dayOfBirth_pckr;
        private System.Windows.Forms.ComboBox department_combobx;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label name_lbl;
    }
}