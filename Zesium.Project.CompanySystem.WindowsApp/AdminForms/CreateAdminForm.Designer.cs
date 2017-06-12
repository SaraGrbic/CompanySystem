namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    partial class CreateAdminForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.pckrDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rbtnGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbtnGenderMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtbxLastname = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Ime admina";
            // 
            // pckrDateOfBirth
            // 
            this.pckrDateOfBirth.Location = new System.Drawing.Point(193, 268);
            this.pckrDateOfBirth.Name = "pckrDateOfBirth";
            this.pckrDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.pckrDateOfBirth.TabIndex = 32;
            // 
            // rbtnGenderFemale
            // 
            this.rbtnGenderFemale.AutoSize = true;
            this.rbtnGenderFemale.Location = new System.Drawing.Point(274, 324);
            this.rbtnGenderFemale.Name = "rbtnGenderFemale";
            this.rbtnGenderFemale.Size = new System.Drawing.Size(61, 17);
            this.rbtnGenderFemale.TabIndex = 31;
            this.rbtnGenderFemale.TabStop = true;
            this.rbtnGenderFemale.Text = "Žensko";
            this.rbtnGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnGenderMale
            // 
            this.rbtnGenderMale.AutoSize = true;
            this.rbtnGenderMale.Location = new System.Drawing.Point(193, 324);
            this.rbtnGenderMale.Name = "rbtnGenderMale";
            this.rbtnGenderMale.Size = new System.Drawing.Size(57, 17);
            this.rbtnGenderMale.TabIndex = 30;
            this.rbtnGenderMale.TabStop = true;
            this.rbtnGenderMale.Text = "Muško";
            this.rbtnGenderMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(57, 324);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(22, 13);
            this.lblGender.TabIndex = 29;
            this.lblGender.Text = "Pol";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(57, 275);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(77, 13);
            this.lblDateOfBirth.TabIndex = 28;
            this.lblDateOfBirth.Text = "Datum rođenja";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(57, 209);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(81, 13);
            this.lblLastname.TabIndex = 27;
            this.lblLastname.Text = "Prezime admina";
            // 
            // txtbxLastname
            // 
            this.txtbxLastname.Location = new System.Drawing.Point(193, 202);
            this.txtbxLastname.Name = "txtbxLastname";
            this.txtbxLastname.Size = new System.Drawing.Size(134, 20);
            this.txtbxLastname.TabIndex = 26;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(193, 140);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(134, 20);
            this.txtbxName.TabIndex = 25;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Šifra";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(193, 79);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(134, 20);
            this.txtbxPassword.TabIndex = 23;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(193, 19);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(134, 20);
            this.txtbxUsername.TabIndex = 22;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(57, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 13);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Korisničko ime";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.Location = new System.Drawing.Point(12, 386);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(130, 23);
            this.btnCreateAdmin.TabIndex = 34;
            this.btnCreateAdmin.Text = "Create admin";
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 430);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateAdmin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pckrDateOfBirth);
            this.Controls.Add(this.rbtnGenderFemale);
            this.Controls.Add(this.rbtnGenderMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtbxLastname);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "CreateAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create admin account";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker pckrDateOfBirth;
        private System.Windows.Forms.RadioButton rbtnGenderFemale;
        private System.Windows.Forms.RadioButton rbtnGenderMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtbxLastname;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAdmin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}