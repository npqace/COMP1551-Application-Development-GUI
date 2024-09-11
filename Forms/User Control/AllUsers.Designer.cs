namespace COMP1551_Coursework.Forms.User_Control
{
    partial class AllUsers
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
            this.pnlViewStudent = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.pnlViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewStudent
            // 
            this.pnlViewStudent.BackColor = System.Drawing.Color.White;
            this.pnlViewStudent.Controls.Add(this.dgvUsers);
            this.pnlViewStudent.Controls.Add(this.lblAllUsers);
            this.pnlViewStudent.Location = new System.Drawing.Point(14, 22);
            this.pnlViewStudent.Name = "pnlViewStudent";
            this.pnlViewStudent.Size = new System.Drawing.Size(932, 619);
            this.pnlViewStudent.TabIndex = 17;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(19, 43);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(895, 555);
            this.dgvUsers.TabIndex = 1;
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Font = new System.Drawing.Font("Google Sans Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAllUsers.Location = new System.Drawing.Point(13, 5);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(130, 35);
            this.lblAllUsers.TabIndex = 0;
            this.lblAllUsers.Text = "All Users";
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlViewStudent);
            this.Name = "AllUsers";
            this.Size = new System.Drawing.Size(961, 661);
            this.pnlViewStudent.ResumeLayout(false);
            this.pnlViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewStudent;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblAllUsers;
    }
}
