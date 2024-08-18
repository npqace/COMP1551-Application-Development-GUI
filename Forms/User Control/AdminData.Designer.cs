namespace COMP1551_Coursework.Forms.User_Control
{
    partial class AdminData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStudentForm = new System.Windows.Forms.Panel();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.lblWorkingHours = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmployment = new System.Windows.Forms.Label();
            this.cBoxEployment = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlViewStudent = new System.Windows.Forms.Panel();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.lblAllAdmin = new System.Windows.Forms.Label();
            this.pnlStudentForm.SuspendLayout();
            this.pnlViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentForm
            // 
            this.pnlStudentForm.BackColor = System.Drawing.Color.White;
            this.pnlStudentForm.Controls.Add(this.txtWorkingHours);
            this.pnlStudentForm.Controls.Add(this.lblWorkingHours);
            this.pnlStudentForm.Controls.Add(this.txtSalary);
            this.pnlStudentForm.Controls.Add(this.lblSalary);
            this.pnlStudentForm.Controls.Add(this.lblEmployment);
            this.pnlStudentForm.Controls.Add(this.cBoxEployment);
            this.pnlStudentForm.Controls.Add(this.txtPhone);
            this.pnlStudentForm.Controls.Add(this.lblPhone);
            this.pnlStudentForm.Controls.Add(this.txtEmail);
            this.pnlStudentForm.Controls.Add(this.lblEmail);
            this.pnlStudentForm.Controls.Add(this.btnDelete);
            this.pnlStudentForm.Controls.Add(this.btnUpdateStudent);
            this.pnlStudentForm.Controls.Add(this.btnAddStudent);
            this.pnlStudentForm.Controls.Add(this.txtName);
            this.pnlStudentForm.Controls.Add(this.lblFullName);
            this.pnlStudentForm.Location = new System.Drawing.Point(14, 351);
            this.pnlStudentForm.Name = "pnlStudentForm";
            this.pnlStudentForm.Size = new System.Drawing.Size(932, 294);
            this.pnlStudentForm.TabIndex = 17;
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Location = new System.Drawing.Point(623, 131);
            this.txtWorkingHours.Multiline = true;
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(194, 25);
            this.txtWorkingHours.TabIndex = 27;
            // 
            // lblWorkingHours
            // 
            this.lblWorkingHours.AutoSize = true;
            this.lblWorkingHours.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWorkingHours.Location = new System.Drawing.Point(522, 132);
            this.lblWorkingHours.Name = "lblWorkingHours";
            this.lblWorkingHours.Size = new System.Drawing.Size(95, 17);
            this.lblWorkingHours.TabIndex = 26;
            this.lblWorkingHours.Text = "Working Hours";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(623, 45);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(194, 25);
            this.txtSalary.TabIndex = 25;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSalary.Location = new System.Drawing.Point(573, 46);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(44, 17);
            this.lblSalary.TabIndex = 24;
            this.lblSalary.Text = "Salary";
            // 
            // lblEmployment
            // 
            this.lblEmployment.AutoSize = true;
            this.lblEmployment.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmployment.Location = new System.Drawing.Point(505, 89);
            this.lblEmployment.Name = "lblEmployment";
            this.lblEmployment.Size = new System.Drawing.Size(112, 17);
            this.lblEmployment.TabIndex = 23;
            this.lblEmployment.Text = "Employment Type";
            // 
            // cBoxEployment
            // 
            this.cBoxEployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cBoxEployment.FormattingEnabled = true;
            this.cBoxEployment.Location = new System.Drawing.Point(623, 89);
            this.cBoxEployment.Name = "cBoxEployment";
            this.cBoxEployment.Size = new System.Drawing.Size(194, 21);
            this.cBoxEployment.TabIndex = 22;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(163, 88);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 25);
            this.txtPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhone.Location = new System.Drawing.Point(63, 89);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(94, 17);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 131);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 25);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(118, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 17);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(552, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 48);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdateStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(397, 222);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(137, 48);
            this.btnUpdateStudent.TabIndex = 13;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(241, 222);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(137, 48);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 45);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFullName.Location = new System.Drawing.Point(92, 46);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(65, 17);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // pnlViewStudent
            // 
            this.pnlViewStudent.BackColor = System.Drawing.Color.White;
            this.pnlViewStudent.Controls.Add(this.dgvAdmin);
            this.pnlViewStudent.Controls.Add(this.lblAllAdmin);
            this.pnlViewStudent.Location = new System.Drawing.Point(14, 15);
            this.pnlViewStudent.Name = "pnlViewStudent";
            this.pnlViewStudent.Size = new System.Drawing.Size(932, 319);
            this.pnlViewStudent.TabIndex = 16;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(19, 43);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(895, 258);
            this.dgvAdmin.TabIndex = 1;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            // 
            // lblAllAdmin
            // 
            this.lblAllAdmin.AutoSize = true;
            this.lblAllAdmin.Font = new System.Drawing.Font("Google Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAllAdmin.Location = new System.Drawing.Point(13, 5);
            this.lblAllAdmin.Name = "lblAllAdmin";
            this.lblAllAdmin.Size = new System.Drawing.Size(143, 35);
            this.lblAllAdmin.TabIndex = 0;
            this.lblAllAdmin.Text = "All Admin";
            // 
            // AdminData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStudentForm);
            this.Controls.Add(this.pnlViewStudent);
            this.Name = "AdminData";
            this.Size = new System.Drawing.Size(961, 661);
            this.Load += new System.EventHandler(this.AdminData_Load);
            this.pnlStudentForm.ResumeLayout(false);
            this.pnlStudentForm.PerformLayout();
            this.pnlViewStudent.ResumeLayout(false);
            this.pnlViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentForm;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlViewStudent;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label lblAllAdmin;
        private System.Windows.Forms.Label lblEmployment;
        private System.Windows.Forms.ComboBox cBoxEployment;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.Label lblWorkingHours;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
    }
}
