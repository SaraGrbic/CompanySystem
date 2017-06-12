namespace Zesium.Project.CompanySystem.WindowsApp.EmployeeForms
{
    partial class EditTaskForm
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
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.rchTxtBxComment = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdBtnInProgress = new System.Windows.Forms.RadioButton();
            this.rdBtnDone = new System.Windows.Forms.RadioButton();
            this.txtBxEstimatedTime = new System.Windows.Forms.TextBox();
            this.txtBxRemainingTime = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Location = new System.Drawing.Point(22, 28);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(96, 13);
            this.lblEstimatedTime.TabIndex = 0;
            this.lblEstimatedTime.Text = "Procenjeno vreme:";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(22, 80);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(86, 13);
            this.lblRemainingTime.TabIndex = 1;
            this.lblRemainingTime.Text = "Preostalo vreme:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(22, 129);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(43, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Stanje :";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(22, 179);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(55, 13);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "Komentar:";
            // 
            // rchTxtBxComment
            // 
            this.rchTxtBxComment.Location = new System.Drawing.Point(135, 179);
            this.rchTxtBxComment.Name = "rchTxtBxComment";
            this.rchTxtBxComment.Size = new System.Drawing.Size(212, 96);
            this.rchTxtBxComment.TabIndex = 4;
            this.rchTxtBxComment.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(25, 307);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdBtnInProgress
            // 
            this.rdBtnInProgress.AutoSize = true;
            this.rdBtnInProgress.Location = new System.Drawing.Point(135, 129);
            this.rdBtnInProgress.Name = "rdBtnInProgress";
            this.rdBtnInProgress.Size = new System.Drawing.Size(77, 17);
            this.rdBtnInProgress.TabIndex = 7;
            this.rdBtnInProgress.TabStop = true;
            this.rdBtnInProgress.Text = "In progress";
            this.rdBtnInProgress.UseVisualStyleBackColor = true;
            // 
            // rdBtnDone
            // 
            this.rdBtnDone.AutoSize = true;
            this.rdBtnDone.Location = new System.Drawing.Point(243, 129);
            this.rdBtnDone.Name = "rdBtnDone";
            this.rdBtnDone.Size = new System.Drawing.Size(51, 17);
            this.rdBtnDone.TabIndex = 8;
            this.rdBtnDone.TabStop = true;
            this.rdBtnDone.Text = "Done";
            this.rdBtnDone.UseVisualStyleBackColor = true;
            // 
            // txtBxEstimatedTime
            // 
            this.txtBxEstimatedTime.Location = new System.Drawing.Point(135, 28);
            this.txtBxEstimatedTime.Name = "txtBxEstimatedTime";
            this.txtBxEstimatedTime.Size = new System.Drawing.Size(100, 20);
            this.txtBxEstimatedTime.TabIndex = 9;
            // 
            // txtBxRemainingTime
            // 
            this.txtBxRemainingTime.Location = new System.Drawing.Point(135, 73);
            this.txtBxRemainingTime.Name = "txtBxRemainingTime";
            this.txtBxRemainingTime.Size = new System.Drawing.Size(100, 20);
            this.txtBxRemainingTime.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 344);
            this.Controls.Add(this.txtBxRemainingTime);
            this.Controls.Add(this.txtBxEstimatedTime);
            this.Controls.Add(this.rdBtnDone);
            this.Controls.Add(this.rdBtnInProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.rchTxtBxComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.lblEstimatedTime);
            this.Name = "EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit task";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.RichTextBox rchTxtBxComment;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdBtnInProgress;
        private System.Windows.Forms.RadioButton rdBtnDone;
        private System.Windows.Forms.TextBox txtBxEstimatedTime;
        private System.Windows.Forms.TextBox txtBxRemainingTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}