namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    partial class EditProjectForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxCost = new System.Windows.Forms.TextBox();
            this.rtxtbxDescription = new System.Windows.Forms.RichTextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOwnerLastname = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.rBtnInProgres = new System.Windows.Forms.RadioButton();
            this.rBtnFinished = new System.Windows.Forms.RadioButton();
            this.rBtnCanceled = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(33, 289);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 23);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit project";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(123, 50);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 20);
            this.txtbxName.TabIndex = 29;
            // 
            // txtbxCost
            // 
            this.txtbxCost.Location = new System.Drawing.Point(123, 86);
            this.txtbxCost.Name = "txtbxCost";
            this.txtbxCost.Size = new System.Drawing.Size(100, 20);
            this.txtbxCost.TabIndex = 28;
            // 
            // rtxtbxDescription
            // 
            this.rtxtbxDescription.Location = new System.Drawing.Point(123, 123);
            this.rtxtbxDescription.Name = "rtxtbxDescription";
            this.rtxtbxDescription.Size = new System.Drawing.Size(206, 96);
            this.rtxtbxDescription.TabIndex = 27;
            this.rtxtbxDescription.Text = "";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(30, 86);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 23;
            this.lblCost.Text = "Cena:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(30, 239);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 13);
            this.lblState.TabIndex = 21;
            this.lblState.Text = "Stanje:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 123);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Opis:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Naziv:";
            // 
            // lblOwnerLastname
            // 
            this.lblOwnerLastname.AutoSize = true;
            this.lblOwnerLastname.Location = new System.Drawing.Point(224, 20);
            this.lblOwnerLastname.Name = "lblOwnerLastname";
            this.lblOwnerLastname.Size = new System.Drawing.Size(72, 13);
            this.lblOwnerLastname.TabIndex = 36;
            this.lblOwnerLastname.Text = "labelaPrezime";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(121, 20);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(52, 13);
            this.lblOwnerName.TabIndex = 35;
            this.lblOwnerName.Text = "labelaIme";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(23, 20);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(85, 13);
            this.lblOwner.TabIndex = 34;
            this.lblOwner.Text = "Vlasnik projekta:";
            // 
            // rBtnInProgres
            // 
            this.rBtnInProgres.AutoSize = true;
            this.rBtnInProgres.Location = new System.Drawing.Point(88, 237);
            this.rBtnInProgres.Name = "rBtnInProgres";
            this.rBtnInProgres.Size = new System.Drawing.Size(72, 17);
            this.rBtnInProgres.TabIndex = 37;
            this.rBtnInProgres.TabStop = true;
            this.rBtnInProgres.Text = "In progres";
            this.rBtnInProgres.UseVisualStyleBackColor = true;
            // 
            // rBtnFinished
            // 
            this.rBtnFinished.AutoSize = true;
            this.rBtnFinished.Location = new System.Drawing.Point(179, 237);
            this.rBtnFinished.Name = "rBtnFinished";
            this.rBtnFinished.Size = new System.Drawing.Size(64, 17);
            this.rBtnFinished.TabIndex = 38;
            this.rBtnFinished.TabStop = true;
            this.rBtnFinished.Text = "Finished";
            this.rBtnFinished.UseVisualStyleBackColor = true;
            // 
            // rBtnCanceled
            // 
            this.rBtnCanceled.AutoSize = true;
            this.rBtnCanceled.Location = new System.Drawing.Point(270, 237);
            this.rBtnCanceled.Name = "rBtnCanceled";
            this.rBtnCanceled.Size = new System.Drawing.Size(70, 17);
            this.rBtnCanceled.TabIndex = 39;
            this.rBtnCanceled.TabStop = true;
            this.rBtnCanceled.Text = "Canceled";
            this.rBtnCanceled.UseVisualStyleBackColor = true;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 335);
            this.Controls.Add(this.rBtnCanceled);
            this.Controls.Add(this.rBtnFinished);
            this.Controls.Add(this.rBtnInProgres);
            this.Controls.Add(this.lblOwnerLastname);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxCost);
            this.Controls.Add(this.rtxtbxDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "EditProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxCost;
        private System.Windows.Forms.RichTextBox rtxtbxDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOwnerLastname;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.RadioButton rBtnInProgres;
        private System.Windows.Forms.RadioButton rBtnFinished;
        private System.Windows.Forms.RadioButton rBtnCanceled;
    }
}