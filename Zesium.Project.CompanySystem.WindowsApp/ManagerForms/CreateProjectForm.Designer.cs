namespace Zesium.Project.CompanySystem.WindowsApp.ManagerForms
{
    partial class CreateProjectForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblOwnerLastname = new System.Windows.Forms.Label();
            this.rtxtbxDescription = new System.Windows.Forms.RichTextBox();
            this.txtbxCost = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.pckrStart = new System.Windows.Forms.DateTimePicker();
            this.pckrEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(82, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Naziv:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(82, 83);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(82, 13);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Vreme početka:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(81, 120);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(86, 13);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "Vreme završetka";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(82, 291);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Opis:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(82, 167);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(40, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "Stanje:";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(182, 167);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(29, 13);
            this.lblNew.TabIndex = 5;
            this.lblNew.Text = "New";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(82, 204);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cena:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(82, 247);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(85, 13);
            this.lblOwner.TabIndex = 7;
            this.lblOwner.Text = "Vlasnik projekta:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(195, 247);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(52, 13);
            this.lblOwnerName.TabIndex = 8;
            this.lblOwnerName.Text = "labelaIme";
            // 
            // lblOwnerLastname
            // 
            this.lblOwnerLastname.AutoSize = true;
            this.lblOwnerLastname.Location = new System.Drawing.Point(313, 247);
            this.lblOwnerLastname.Name = "lblOwnerLastname";
            this.lblOwnerLastname.Size = new System.Drawing.Size(72, 13);
            this.lblOwnerLastname.TabIndex = 9;
            this.lblOwnerLastname.Text = "labelaPrezime";
            // 
            // rtxtbxDescription
            // 
            this.rtxtbxDescription.Location = new System.Drawing.Point(179, 288);
            this.rtxtbxDescription.Name = "rtxtbxDescription";
            this.rtxtbxDescription.Size = new System.Drawing.Size(206, 96);
            this.rtxtbxDescription.TabIndex = 10;
            this.rtxtbxDescription.Text = "";
            // 
            // txtbxCost
            // 
            this.txtbxCost.Location = new System.Drawing.Point(185, 201);
            this.txtbxCost.Name = "txtbxCost";
            this.txtbxCost.Size = new System.Drawing.Size(100, 20);
            this.txtbxCost.TabIndex = 11;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(185, 40);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 20);
            this.txtbxName.TabIndex = 12;
            // 
            // pckrStart
            // 
            this.pckrStart.Location = new System.Drawing.Point(185, 83);
            this.pckrStart.Name = "pckrStart";
            this.pckrStart.Size = new System.Drawing.Size(200, 20);
            this.pckrStart.TabIndex = 13;
            // 
            // pckrEnd
            // 
            this.pckrEnd.Location = new System.Drawing.Point(185, 120);
            this.pckrEnd.Name = "pckrEnd";
            this.pckrEnd.Size = new System.Drawing.Size(200, 20);
            this.pckrEnd.TabIndex = 14;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(53, 414);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create project";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pckrEnd);
            this.Controls.Add(this.pckrStart);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.txtbxCost);
            this.Controls.Add(this.rtxtbxDescription);
            this.Controls.Add(this.lblOwnerLastname);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblName);
            this.Name = "CreateProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwnerLastname;
        private System.Windows.Forms.RichTextBox rtxtbxDescription;
        private System.Windows.Forms.TextBox txtbxCost;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.DateTimePicker pckrStart;
        private System.Windows.Forms.DateTimePicker pckrEnd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}