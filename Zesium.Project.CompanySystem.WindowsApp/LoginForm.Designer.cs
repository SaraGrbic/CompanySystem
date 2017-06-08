namespace Zesium.Project.CompanySystem.WindowsApp
{
    partial class LoginForm
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
            this.username_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.signUp_btn = new System.Windows.Forms.Button();
            this.password_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(176, 81);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(100, 20);
            this.username_txtbx.TabIndex = 0;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(176, 122);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(100, 20);
            this.password_txtbx.TabIndex = 1;
            //this.password_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_txtbx_KeyPress);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(196, 39);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(52, 13);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Welcome";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(94, 88);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(55, 13);
            this.username_lbl.TabIndex = 3;
            this.username_lbl.Text = "Username";
            // 
            // signIn_btn
            // 
            this.signIn_btn.Location = new System.Drawing.Point(54, 204);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(75, 23);
            this.signIn_btn.TabIndex = 4;
            this.signIn_btn.Text = "Sign in";
            this.signIn_btn.UseVisualStyleBackColor = true;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // signUp_btn
            // 
            this.signUp_btn.Location = new System.Drawing.Point(322, 204);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(75, 23);
            this.signUp_btn.TabIndex = 7;
            this.signUp_btn.Text = "Sign Up";
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(94, 129);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 269);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.signUp_btn);
            this.Controls.Add(this.signIn_btn);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.username_txtbx);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label password_lbl;
    }
}

