namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    partial class PromoteEmployeeForm
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
            this.btnPromote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPromote = new System.Windows.Forms.Label();
            this.cmbbxDepartments = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(35, 202);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(75, 23);
            this.btnPromote.TabIndex = 0;
            this.btnPromote.Text = "Promote";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPromote
            // 
            this.lblPromote.AutoSize = true;
            this.lblPromote.Location = new System.Drawing.Point(68, 32);
            this.lblPromote.Name = "lblPromote";
            this.lblPromote.Size = new System.Drawing.Size(194, 13);
            this.lblPromote.TabIndex = 2;
            this.lblPromote.Text = "Odaberite departman novog menadžera";
            // 
            // cmbbxDepartments
            // 
            this.cmbbxDepartments.FormattingEnabled = true;
            this.cmbbxDepartments.Location = new System.Drawing.Point(104, 70);
            this.cmbbxDepartments.Name = "cmbbxDepartments";
            this.cmbbxDepartments.Size = new System.Drawing.Size(121, 21);
            this.cmbbxDepartments.TabIndex = 3;
            // 
            // PromoteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 266);
            this.Controls.Add(this.cmbbxDepartments);
            this.Controls.Add(this.lblPromote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPromote);
            this.Name = "PromoteEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promote employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPromote;
        private System.Windows.Forms.ComboBox cmbbxDepartments;
    }
}