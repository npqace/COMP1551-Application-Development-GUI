using COMP1551_Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1551_Coursework.Forms.User_Control
{
    public partial class AllUsers : UserControl
    {
        private AdminData adminData;// Create a new AdminData object
        private TeacherData teacherData;// Create a new TeacherData object
        private StudentData studentData;// Create a new StudentData object

        public AllUsers(AdminData adminData, TeacherData teacherData, StudentData studentData)
        {
            InitializeComponent();
            
            this.adminData = adminData;
            this.teacherData = teacherData;
            this.studentData = studentData;

            userData(); // Call the userData method to display all users
        }

        public void userData()
        {
            Person user = new Person(); // Create a new Person object

            // Configure the DataGridView to not automatically generate columns
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear(); // Clear any existing columns

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn(); // // Create a new DataGridViewTextBoxColumn to display PersonID data
            personIDColumn.DataPropertyName = "PersonID"; // // Bind the column to the "PersonID" property of the data source
            personIDColumn.HeaderText = "PersonID"; // Set the header text of the column
            dgvUsers.Columns.Add(personIDColumn); // Add the column to the DataGridView

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dgvUsers.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
            telephoneColumn.DataPropertyName = "Telephone";
            telephoneColumn.HeaderText = "Telephone";
            dgvUsers.Columns.Add(telephoneColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";
            dgvUsers.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.DataPropertyName = "UserRole";
            roleColumn.HeaderText = "Role";
            dgvUsers.Columns.Add(roleColumn);

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.DataPropertyName = "Salary";
            salaryColumn.HeaderText = "Salary";
            dgvUsers.Columns.Add(salaryColumn);

            DataGridViewTextBoxColumn teachingSubject1Column = new DataGridViewTextBoxColumn();
            teachingSubject1Column.DataPropertyName = "TeachingSubject1";
            teachingSubject1Column.HeaderText = "Teaching Subject 1";
            dgvUsers.Columns.Add(teachingSubject1Column);

            DataGridViewTextBoxColumn teachingSubject2Column = new DataGridViewTextBoxColumn();
            teachingSubject2Column.DataPropertyName = "TeachingSubject2";
            teachingSubject2Column.HeaderText = "Teaching Subject 2";
            dgvUsers.Columns.Add(teachingSubject2Column);

            DataGridViewTextBoxColumn currentSubject1Column = new DataGridViewTextBoxColumn();
            currentSubject1Column.DataPropertyName = "CurrentSubject1";
            currentSubject1Column.HeaderText = "Current Subject 1";
            dgvUsers.Columns.Add(currentSubject1Column);

            DataGridViewTextBoxColumn currentSubject2Column = new DataGridViewTextBoxColumn();
            currentSubject2Column.DataPropertyName = "CurrentSubject2";
            currentSubject2Column.HeaderText = "Current Subject 2";
            dgvUsers.Columns.Add(currentSubject2Column);

            DataGridViewTextBoxColumn previousSubject1Column = new DataGridViewTextBoxColumn();
            previousSubject1Column.DataPropertyName = "PreviousSubject1";
            previousSubject1Column.HeaderText = "Previous Subject 1";
            dgvUsers.Columns.Add(previousSubject1Column);

            DataGridViewTextBoxColumn previousSubject2Column = new DataGridViewTextBoxColumn();
            previousSubject2Column.DataPropertyName = "PreviousSubject2";
            previousSubject2Column.HeaderText = "Previous Subject 2";
            dgvUsers.Columns.Add(previousSubject2Column);

            // Set the data source of the DataGridView to the list of users returned by the UserList method
            dgvUsers.DataSource = user.UserList();
        }

        public void RefreshData()
        {
            userData(); // Call the userData method to refresh the data
        }
    }
}
