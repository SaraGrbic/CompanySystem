namespace Zesium.Project.CompanySystem.WindowsApp.AdminForms
{
    partial class AddDepartmentForm
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
            this.depName_lbl = new System.Windows.Forms.Label();
            this.depName_txtbx = new System.Windows.Forms.TextBox();
            this.depDescription_lbl = new System.Windows.Forms.Label();
            this.depDescription_txtbx = new System.Windows.Forms.RichTextBox();
            this.createDepartment_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // depName_lbl
            // 
            this.depName_lbl.AutoSize = true;
            this.depName_lbl.Location = new System.Drawing.Point(62, 45);
            this.depName_lbl.Name = "depName_lbl";
            this.depName_lbl.Size = new System.Drawing.Size(86, 13);
            this.depName_lbl.TabIndex = 0;
            this.depName_lbl.Text = "Ime departmana:";
            // 
            // depName_txtbx
            // 
            this.depName_txtbx.Location = new System.Drawing.Point(212, 42);
            this.depName_txtbx.Name = "depName_txtbx";
            this.depName_txtbx.Size = new System.Drawing.Size(170, 20);
            this.depName_txtbx.TabIndex = 1;
            // 
            // depDescription_lbl
            // 
            this.depDescription_lbl.AutoSize = true;
            this.depDescription_lbl.Location = new System.Drawing.Point(65, 106);
            this.depDescription_lbl.Name = "depDescription_lbl";
            this.depDescription_lbl.Size = new System.Drawing.Size(90, 13);
            this.depDescription_lbl.TabIndex = 2;
            this.depDescription_lbl.Text = "Opis departmana:";
            // 
            // depDescription_txtbx
            // 
            this.depDescription_txtbx.Location = new System.Drawing.Point(212, 103);
            this.depDescription_txtbx.Name = "depDescription_txtbx";
            this.depDescription_txtbx.Size = new System.Drawing.Size(170, 96);
            this.depDescription_txtbx.TabIndex = 4;
            this.depDescription_txtbx.Text = "";
            // 
            // createDepartment_btn
            // 
            this.createDepartment_btn.Location = new System.Drawing.Point(65, 269);
            this.createDepartment_btn.Name = "createDepartment_btn";
            this.createDepartment_btn.Size = new System.Drawing.Size(116, 23);
            this.createDepartment_btn.TabIndex = 5;
            this.createDepartment_btn.Text = "Create department";
            this.createDepartment_btn.UseVisualStyleBackColor = true;
            this.createDepartment_btn.Click += new System.EventHandler(this.createDepartment_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(306, 268);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 336);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.createDepartment_btn);
            this.Controls.Add(this.depDescription_txtbx);
            this.Controls.Add(this.depDescription_lbl);
            this.Controls.Add(this.depName_txtbx);
            this.Controls.Add(this.depName_lbl);
            this.Name = "AddDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or edit department";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depName_lbl;
        private System.Windows.Forms.TextBox depName_txtbx;
        private System.Windows.Forms.Label depDescription_lbl;
        private System.Windows.Forms.RichTextBox depDescription_txtbx;
        private System.Windows.Forms.Button createDepartment_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}