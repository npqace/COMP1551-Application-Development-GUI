namespace COMP1551_Coursework
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnViewTeacher = new System.Windows.Forms.Button();
            this.btnViewAdmin = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.allUsers1 = new COMP1551_Coursework.Forms.User_Control.AllUsers(this.adminData1, this.teacherData1, this.studentData1);
            this.adminData1 = new COMP1551_Coursework.Forms.User_Control.AdminData();
            this.teacherData1 = new COMP1551_Coursework.Forms.User_Control.TeacherData();
            this.studentData1 = new COMP1551_Coursework.Forms.User_Control.StudentData();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.lblWelcome);
            this.pnlMenu.Controls.Add(this.btnViewStudent);
            this.pnlMenu.Controls.Add(this.btnViewTeacher);
            this.pnlMenu.Controls.Add(this.btnViewAdmin);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(276, 661);
            this.pnlMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP1551_Coursework.Properties.Resources.UoG_logo;
            this.pictureBox1.Location = new System.Drawing.Point(85, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Google Sans Medium", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(75, 136);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 28);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.BackColor = System.Drawing.Color.White;
            this.btnViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudent.Font = new System.Drawing.Font("Google Sans", 12F);
            this.btnViewStudent.Location = new System.Drawing.Point(27, 466);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(218, 64);
            this.btnViewStudent.TabIndex = 4;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.UseVisualStyleBackColor = false;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnViewTeacher
            // 
            this.btnViewTeacher.BackColor = System.Drawing.Color.White;
            this.btnViewTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTeacher.Font = new System.Drawing.Font("Google Sans", 12F);
            this.btnViewTeacher.Location = new System.Drawing.Point(27, 386);
            this.btnViewTeacher.Name = "btnViewTeacher";
            this.btnViewTeacher.Size = new System.Drawing.Size(218, 64);
            this.btnViewTeacher.TabIndex = 3;
            this.btnViewTeacher.Text = "View Teacher";
            this.btnViewTeacher.UseVisualStyleBackColor = false;
            this.btnViewTeacher.Click += new System.EventHandler(this.btnViewTeacher_Click);
            // 
            // btnViewAdmin
            // 
            this.btnViewAdmin.BackColor = System.Drawing.Color.White;
            this.btnViewAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAdmin.Font = new System.Drawing.Font("Google Sans", 12F);
            this.btnViewAdmin.Location = new System.Drawing.Point(27, 306);
            this.btnViewAdmin.Name = "btnViewAdmin";
            this.btnViewAdmin.Size = new System.Drawing.Size(218, 64);
            this.btnViewAdmin.TabIndex = 2;
            this.btnViewAdmin.Text = "View Admin";
            this.btnViewAdmin.UseVisualStyleBackColor = false;
            this.btnViewAdmin.Click += new System.EventHandler(this.btnViewAdmin_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.White;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Google Sans", 12F);
            this.btnViewAll.Location = new System.Drawing.Point(27, 226);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(218, 64);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "View All Users";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // allUsers1
            // 
            this.allUsers1.Location = new System.Drawing.Point(263, 0);
            this.allUsers1.Name = "allUsers1";
            this.allUsers1.Size = new System.Drawing.Size(961, 661);
            this.allUsers1.TabIndex = 5;
            // 
            // adminData1
            // 
            this.adminData1.Location = new System.Drawing.Point(263, 0);
            this.adminData1.Name = "adminData1";
            this.adminData1.Size = new System.Drawing.Size(961, 661);
            this.adminData1.TabIndex = 4;
            // 
            // teacherData1
            // 
            this.teacherData1.Location = new System.Drawing.Point(263, 0);
            this.teacherData1.Name = "teacherData1";
            this.teacherData1.Size = new System.Drawing.Size(961, 661);
            this.teacherData1.TabIndex = 3;
            // 
            // studentData1
            // 
            this.studentData1.Dock = System.Windows.Forms.DockStyle.Right;
            this.studentData1.Location = new System.Drawing.Point(263, 0);
            this.studentData1.Name = "studentData1";
            this.studentData1.Size = new System.Drawing.Size(961, 661);
            this.studentData1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 661);
            this.Controls.Add(this.allUsers1);
            this.Controls.Add(this.adminData1);
            this.Controls.Add(this.teacherData1);
            this.Controls.Add(this.studentData1);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnViewTeacher;
        private System.Windows.Forms.Button btnViewAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private Forms.User_Control.StudentData studentData1;
        private Forms.User_Control.TeacherData teacherData1;
        private Forms.User_Control.AdminData adminData1;
        private Forms.User_Control.AllUsers allUsers1;
    }
}

