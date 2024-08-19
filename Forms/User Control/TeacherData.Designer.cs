namespace COMP1551_Coursework.Forms.User_Control
{
    partial class TeacherData
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.lblTS2 = new System.Windows.Forms.Label();
            this.cBoxTS2 = new System.Windows.Forms.ComboBox();
            this.lblTS1 = new System.Windows.Forms.Label();
            this.cBoxTS1 = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlViewStudent = new System.Windows.Forms.Panel();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.lblAllTeacher = new System.Windows.Forms.Label();
            this.pnlStudentForm.SuspendLayout();
            this.pnlViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentForm
            // 
            this.pnlStudentForm.BackColor = System.Drawing.Color.White;
            this.pnlStudentForm.Controls.Add(this.txtSalary);
            this.pnlStudentForm.Controls.Add(this.lblSalary);
            this.pnlStudentForm.Controls.Add(this.txtPhone);
            this.pnlStudentForm.Controls.Add(this.lblPhone);
            this.pnlStudentForm.Controls.Add(this.txtEmail);
            this.pnlStudentForm.Controls.Add(this.lblEmail);
            this.pnlStudentForm.Controls.Add(this.btnDelete);
            this.pnlStudentForm.Controls.Add(this.btnUpdateTeacher);
            this.pnlStudentForm.Controls.Add(this.btnAddTeacher);
            this.pnlStudentForm.Controls.Add(this.lblTS2);
            this.pnlStudentForm.Controls.Add(this.cBoxTS2);
            this.pnlStudentForm.Controls.Add(this.lblTS1);
            this.pnlStudentForm.Controls.Add(this.cBoxTS1);
            this.pnlStudentForm.Controls.Add(this.txtName);
            this.pnlStudentForm.Controls.Add(this.lblFullName);
            this.pnlStudentForm.Location = new System.Drawing.Point(14, 351);
            this.pnlStudentForm.Name = "pnlStudentForm";
            this.pnlStudentForm.Size = new System.Drawing.Size(932, 294);
            this.pnlStudentForm.TabIndex = 17;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(586, 45);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(194, 25);
            this.txtSalary.TabIndex = 21;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSalary.Location = new System.Drawing.Point(515, 46);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(44, 17);
            this.lblSalary.TabIndex = 20;
            this.lblSalary.Text = "Salary";
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdateTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUpdateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateTeacher.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTeacher.Location = new System.Drawing.Point(397, 222);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(137, 48);
            this.btnUpdateTeacher.TabIndex = 13;
            this.btnUpdateTeacher.Text = "Update";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Location = new System.Drawing.Point(241, 222);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(137, 48);
            this.btnAddTeacher.TabIndex = 12;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // lblTS2
            // 
            this.lblTS2.AutoSize = true;
            this.lblTS2.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTS2.Location = new System.Drawing.Point(471, 136);
            this.lblTS2.Name = "lblTS2";
            this.lblTS2.Size = new System.Drawing.Size(117, 17);
            this.lblTS2.TabIndex = 7;
            this.lblTS2.Text = "Teaching Subject 2";
            // 
            // cBoxTS2
            // 
            this.cBoxTS2.FormattingEnabled = true;
            this.cBoxTS2.Location = new System.Drawing.Point(586, 135);
            this.cBoxTS2.Name = "cBoxTS2";
            this.cBoxTS2.Size = new System.Drawing.Size(194, 21);
            this.cBoxTS2.TabIndex = 6;
            // 
            // lblTS1
            // 
            this.lblTS1.AutoSize = true;
            this.lblTS1.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTS1.Location = new System.Drawing.Point(471, 93);
            this.lblTS1.Name = "lblTS1";
            this.lblTS1.Size = new System.Drawing.Size(115, 17);
            this.lblTS1.TabIndex = 5;
            this.lblTS1.Text = "Teaching Subject 1";
            // 
            // cBoxTS1
            // 
            this.cBoxTS1.FormattingEnabled = true;
            this.cBoxTS1.Location = new System.Drawing.Point(586, 92);
            this.cBoxTS1.Name = "cBoxTS1";
            this.cBoxTS1.Size = new System.Drawing.Size(194, 21);
            this.cBoxTS1.TabIndex = 4;
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
            this.pnlViewStudent.Controls.Add(this.dgvTeachers);
            this.pnlViewStudent.Controls.Add(this.lblAllTeacher);
            this.pnlViewStudent.Location = new System.Drawing.Point(14, 15);
            this.pnlViewStudent.Name = "pnlViewStudent";
            this.pnlViewStudent.Size = new System.Drawing.Size(932, 319);
            this.pnlViewStudent.TabIndex = 16;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(19, 43);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(895, 258);
            this.dgvTeachers.TabIndex = 1;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);
            // 
            // lblAllTeacher
            // 
            this.lblAllTeacher.AutoSize = true;
            this.lblAllTeacher.Font = new System.Drawing.Font("Google Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAllTeacher.Location = new System.Drawing.Point(13, 5);
            this.lblAllTeacher.Name = "lblAllTeacher";
            this.lblAllTeacher.Size = new System.Drawing.Size(177, 35);
            this.lblAllTeacher.TabIndex = 0;
            this.lblAllTeacher.Text = "All Teachers";
            // 
            // TeacherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStudentForm);
            this.Controls.Add(this.pnlViewStudent);
            this.Name = "TeacherData";
            this.Size = new System.Drawing.Size(961, 661);
            this.pnlStudentForm.ResumeLayout(false);
            this.pnlStudentForm.PerformLayout();
            this.pnlViewStudent.ResumeLayout(false);
            this.pnlViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentForm;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label lblTS2;
        private System.Windows.Forms.ComboBox cBoxTS2;
        private System.Windows.Forms.Label lblTS1;
        private System.Windows.Forms.ComboBox cBoxTS1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlViewStudent;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label lblAllTeacher;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
    }
}
