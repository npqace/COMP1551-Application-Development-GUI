namespace COMP1551_Coursework.Forms.User_Control
{
    partial class StudentData
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPS2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxPS1 = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblCS2 = new System.Windows.Forms.Label();
            this.cBoxCS2 = new System.Windows.Forms.ComboBox();
            this.lblCS1 = new System.Windows.Forms.Label();
            this.cBoxCS1 = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlViewStudent = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblAllStudents = new System.Windows.Forms.Label();
            this.pnlStudentForm.SuspendLayout();
            this.pnlViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentForm
            // 
            this.pnlStudentForm.BackColor = System.Drawing.Color.White;
            this.pnlStudentForm.Controls.Add(this.label1);
            this.pnlStudentForm.Controls.Add(this.cBoxPS2);
            this.pnlStudentForm.Controls.Add(this.label2);
            this.pnlStudentForm.Controls.Add(this.cBoxPS1);
            this.pnlStudentForm.Controls.Add(this.txtPhone);
            this.pnlStudentForm.Controls.Add(this.lblPhone);
            this.pnlStudentForm.Controls.Add(this.txtEmail);
            this.pnlStudentForm.Controls.Add(this.lblEmail);
            this.pnlStudentForm.Controls.Add(this.btnDelete);
            this.pnlStudentForm.Controls.Add(this.btnUpdateStudent);
            this.pnlStudentForm.Controls.Add(this.btnAddStudent);
            this.pnlStudentForm.Controls.Add(this.lblCS2);
            this.pnlStudentForm.Controls.Add(this.cBoxCS2);
            this.pnlStudentForm.Controls.Add(this.lblCS1);
            this.pnlStudentForm.Controls.Add(this.cBoxCS1);
            this.pnlStudentForm.Controls.Add(this.txtName);
            this.pnlStudentForm.Controls.Add(this.lblFullName);
            this.pnlStudentForm.Location = new System.Drawing.Point(14, 351);
            this.pnlStudentForm.Name = "pnlStudentForm";
            this.pnlStudentForm.Size = new System.Drawing.Size(932, 294);
            this.pnlStudentForm.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(471, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Previous Subject 2";
            // 
            // cBoxPS2
            // 
            this.cBoxPS2.FormattingEnabled = true;
            this.cBoxPS2.Location = new System.Drawing.Point(586, 160);
            this.cBoxPS2.Name = "cBoxPS2";
            this.cBoxPS2.Size = new System.Drawing.Size(194, 21);
            this.cBoxPS2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(471, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Previous Subject 1";
            // 
            // cBoxPS1
            // 
            this.cBoxPS1.FormattingEnabled = true;
            this.cBoxPS1.Location = new System.Drawing.Point(586, 119);
            this.cBoxPS1.Name = "cBoxPS1";
            this.cBoxPS1.Size = new System.Drawing.Size(194, 21);
            this.cBoxPS1.TabIndex = 20;
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
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
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
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblCS2
            // 
            this.lblCS2.AutoSize = true;
            this.lblCS2.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCS2.Location = new System.Drawing.Point(471, 79);
            this.lblCS2.Name = "lblCS2";
            this.lblCS2.Size = new System.Drawing.Size(111, 17);
            this.lblCS2.TabIndex = 7;
            this.lblCS2.Text = "Current Subject 2";
            // 
            // cBoxCS2
            // 
            this.cBoxCS2.FormattingEnabled = true;
            this.cBoxCS2.Location = new System.Drawing.Point(586, 78);
            this.cBoxCS2.Name = "cBoxCS2";
            this.cBoxCS2.Size = new System.Drawing.Size(194, 21);
            this.cBoxCS2.TabIndex = 6;
            // 
            // lblCS1
            // 
            this.lblCS1.AutoSize = true;
            this.lblCS1.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCS1.Location = new System.Drawing.Point(471, 38);
            this.lblCS1.Name = "lblCS1";
            this.lblCS1.Size = new System.Drawing.Size(109, 17);
            this.lblCS1.TabIndex = 5;
            this.lblCS1.Text = "Current Subject 1";
            // 
            // cBoxCS1
            // 
            this.cBoxCS1.FormattingEnabled = true;
            this.cBoxCS1.Location = new System.Drawing.Point(586, 37);
            this.cBoxCS1.Name = "cBoxCS1";
            this.cBoxCS1.Size = new System.Drawing.Size(194, 21);
            this.cBoxCS1.TabIndex = 4;
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
            this.pnlViewStudent.Controls.Add(this.dgvStudents);
            this.pnlViewStudent.Controls.Add(this.lblAllStudents);
            this.pnlViewStudent.Location = new System.Drawing.Point(14, 15);
            this.pnlViewStudent.Name = "pnlViewStudent";
            this.pnlViewStudent.Size = new System.Drawing.Size(932, 319);
            this.pnlViewStudent.TabIndex = 14;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(19, 43);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(895, 258);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // lblAllStudents
            // 
            this.lblAllStudents.AutoSize = true;
            this.lblAllStudents.Font = new System.Drawing.Font("Google Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAllStudents.Location = new System.Drawing.Point(13, 5);
            this.lblAllStudents.Name = "lblAllStudents";
            this.lblAllStudents.Size = new System.Drawing.Size(177, 35);
            this.lblAllStudents.TabIndex = 0;
            this.lblAllStudents.Text = "All Students";
            // 
            // StudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStudentForm);
            this.Controls.Add(this.pnlViewStudent);
            this.Name = "StudentData";
            this.Size = new System.Drawing.Size(961, 661);
            this.pnlStudentForm.ResumeLayout(false);
            this.pnlStudentForm.PerformLayout();
            this.pnlViewStudent.ResumeLayout(false);
            this.pnlViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPS2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxPS1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblCS2;
        private System.Windows.Forms.ComboBox cBoxCS2;
        private System.Windows.Forms.Label lblCS1;
        private System.Windows.Forms.ComboBox cBoxCS1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlViewStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblAllStudents;
    }
}
