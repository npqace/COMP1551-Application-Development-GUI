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
        public AllUsers()
        {
            InitializeComponent();
            userData();
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {

        }

        public void userData()
        {
            Person user = new Person();

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.Columns.Clear();

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn();
            personIDColumn.DataPropertyName = "PersonID";
            personIDColumn.HeaderText = "PersonID";
            dgvUsers.Columns.Add(personIDColumn);

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

            dgvUsers.DataSource = user.UserList();
        }
    }
}
