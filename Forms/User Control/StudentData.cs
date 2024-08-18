using COMP1551_Coursework.Models;
using COMP1551_Coursework.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1551_Coursework.Forms.User_Control
{
    public partial class StudentData : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public StudentData()
        {
            InitializeComponent();
            LoadSubjects();
            studentData();
        }

        private void StudentData_Load(object sender, EventArgs e)
        {

        }
        public void studentData()
        {
            Student student = new Student();

            dgvStudents.AutoGenerateColumns = false;

            dgvStudents.Columns.Clear();

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn();
            personIDColumn.DataPropertyName = "PersonID"; // The property name in your Student class
            personIDColumn.HeaderText = "PersonID"; // The column header text
            dgvStudents.Columns.Add(personIDColumn);

            DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
            studentIDColumn.DataPropertyName = "StudentID"; // The property name in your Student class
            studentIDColumn.HeaderText = "StudentID"; // The column header text
            dgvStudents.Columns.Add(studentIDColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dgvStudents.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
            telephoneColumn.DataPropertyName = "Telephone";
            telephoneColumn.HeaderText = "Telephone";
            dgvStudents.Columns.Add(telephoneColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";
            dgvStudents.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn currentSubject1Column = new DataGridViewTextBoxColumn();
            currentSubject1Column.DataPropertyName = "CurrentSubject1";
            currentSubject1Column.HeaderText = "Current Subject 1";
            dgvStudents.Columns.Add(currentSubject1Column);

            DataGridViewTextBoxColumn currentSubject2Column = new DataGridViewTextBoxColumn();
            currentSubject2Column.DataPropertyName = "CurrentSubject2";
            currentSubject2Column.HeaderText = "Current Subject 2";
            dgvStudents.Columns.Add(currentSubject2Column);

            DataGridViewTextBoxColumn previousSubject1Column = new DataGridViewTextBoxColumn();
            previousSubject1Column.DataPropertyName = "PreviousSubject1";
            previousSubject1Column.HeaderText = "Previous Subject 1";
            dgvStudents.Columns.Add(previousSubject1Column);

            DataGridViewTextBoxColumn previousSubject2Column = new DataGridViewTextBoxColumn();
            previousSubject2Column.DataPropertyName = "PreviousSubject2";
            previousSubject2Column.HeaderText = "Previous Subject 2";
            dgvStudents.Columns.Add(previousSubject2Column);

            dgvStudents.DataSource = student.students();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtName.Text == ""
                || txtPhone.Text == ""
                || txtEmail.Text == ""
                || cBoxCS1.Text == ""
                || cBoxCS2.Text == ""
                || cBoxPS1.Text == ""
                || cBoxPS2.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cBoxCS1.Text == cBoxCS2.Text || cBoxCS1.Text == cBoxPS1.Text || cBoxCS1.Text == cBoxPS2.Text
                || cBoxCS2.Text == cBoxPS1.Text || cBoxCS2.Text == cBoxPS2.Text || cBoxPS1.Text == cBoxPS2.Text)
            {
                MessageBox.Show("Error: Subjects cannot be the same", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reload the form to allow the user to correct the input
                LoadSubjects();
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        // Insert into Person table
                        string personQuery = "INSERT INTO Person (Name, Telephone, Email, Role) OUTPUT INSERTED.PersonID VALUES (@Name, @Telephone, @Email, @Role)";
                        int personID;
                        using (SqlCommand personCmd = new SqlCommand(personQuery, conn))
                        {
                            personCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Role", Role.Student.ToString());

                            personID = (int)personCmd.ExecuteScalar();
                        }

                        // Insert into Student table
                        string studentQuery = "INSERT INTO Student (PersonID, CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2) VALUES (@PersonID, @CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2)";
                        using (SqlCommand studentCmd = new SqlCommand(studentQuery, conn))
                        {
                            studentCmd.Parameters.AddWithValue("@PersonID", personID);
                            studentCmd.Parameters.AddWithValue("@CurrentSubject1", cBoxCS1.Text.Trim());
                            studentCmd.Parameters.AddWithValue("@CurrentSubject2", cBoxCS2.Text.Trim());
                            studentCmd.Parameters.AddWithValue("@PreviousSubject1", cBoxPS1.Text.Trim());
                            studentCmd.Parameters.AddWithValue("@PreviousSubject2", cBoxPS2.Text.Trim());

                            studentCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Student added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        studentData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (cBoxCS1.Text == cBoxCS2.Text || cBoxCS1.Text == cBoxPS1.Text || cBoxCS1.Text == cBoxPS2.Text
                || cBoxCS2.Text == cBoxPS1.Text || cBoxCS2.Text == cBoxPS2.Text || cBoxPS1.Text == cBoxPS2.Text)
            {
                MessageBox.Show("Error: Subjects cannot be the same", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reload the form to allow the user to correct the input
                LoadSubjects();
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        // Assuming you have a way to get the selected student's PersonID
                        int personID = GetSelectedPersonID();

                        // Update Person table
                        SqlCommand updatePersonCmd = new SqlCommand(
                            "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = @PersonID", conn);
                        updatePersonCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                        updatePersonCmd.ExecuteNonQuery();

                        // Update Student table
                        SqlCommand updateStudentCmd = new SqlCommand(
                            "UPDATE Student SET CurrentSubject1 = @CurrentSubject1, CurrentSubject2 = @CurrentSubject2, PreviousSubject1 = @PreviousSubject1, PreviousSubject2 = @PreviousSubject2 WHERE PersonID = @PersonID", conn);
                        updateStudentCmd.Parameters.AddWithValue("@CurrentSubject1", cBoxCS1.Text.Trim());
                        updateStudentCmd.Parameters.AddWithValue("@CurrentSubject2", cBoxCS2.Text.Trim());
                        updateStudentCmd.Parameters.AddWithValue("@PreviousSubject1", cBoxPS1.Text.Trim());
                        updateStudentCmd.Parameters.AddWithValue("@PreviousSubject2", cBoxPS2.Text.Trim());
                        updateStudentCmd.Parameters.AddWithValue("@PersonID", personID);
                        updateStudentCmd.ExecuteNonQuery();

                        MessageBox.Show("Student updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        studentData();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display confirmation box
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            else if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    // Get the selected student's PersonID
                    int personID = GetSelectedPersonID();

                    // Delete from Student table
                    SqlCommand deleteStudentCmd = new SqlCommand("DELETE FROM Student WHERE PersonID = @PersonID", conn);
                    deleteStudentCmd.Parameters.AddWithValue("@PersonID", personID);
                    deleteStudentCmd.ExecuteNonQuery();

                    // Delete from Person table
                    SqlCommand deletePersonCmd = new SqlCommand("DELETE FROM Person WHERE PersonID = @PersonID", conn);
                    deletePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                    deletePersonCmd.ExecuteNonQuery();

                    MessageBox.Show("Student deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private int GetSelectedPersonID()
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvStudents.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                throw new InvalidOperationException("No student selected.");
            }
        }

        private void LoadSubjects()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SubjectName FROM Subject";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        List<string> subjects = new List<string>() { "" };
                        while (reader.Read())
                        {
                            subjects.Add(reader["SubjectName"].ToString());
                        }
                        reader.Close();

                        // Bind the subjects to the ComboBox controls
                        cBoxCS1.DataSource = new List<string>(subjects);
                        cBoxCS2.DataSource = new List<string>(subjects);
                        cBoxPS1.DataSource = new List<string>(subjects);
                        cBoxPS2.DataSource = new List<string>(subjects);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
               DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtName.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                cBoxCS1.Text = row.Cells[5].Value.ToString();
                cBoxCS2.Text = row.Cells[6].Value.ToString();
                cBoxPS1.Text = row.Cells[7].Value.ToString();
                cBoxPS2.Text = row.Cells[8].Value.ToString();
            }
        }

        

    }
}
