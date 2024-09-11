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
    public partial class TeacherData : UserControl
    {
        public event EventHandler PersonAdded; // Declare an event to notify subscribers when a person is added
        public event EventHandler PersonUpdated; // Declare an event to notify subscribers when a person is updated
        public event EventHandler PersonDeleted; // Declare an event to notify subscribers when a person is deleted

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public TeacherData()
        {
            InitializeComponent();
            LoadSubjects(); // Load available subjects for the comboboxes
            teacherData(); // Populate the DataGridView control with teacher data on initialization
        }

        public void teacherData()
        {
            Teacher teacher = new Teacher(); // Create a new Teacher object

            dgvTeachers.AutoGenerateColumns = false; // Configure the DataGridView to not automatically generate columns
            dgvTeachers.Columns.Clear(); // Clear any existing columns

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn(); // Create a new DataGridViewTextBoxColumn to display PersonID data
            personIDColumn.DataPropertyName = "PersonID"; // Bind the column to the "PersonID" property of the data source
            personIDColumn.HeaderText = "PersonID"; // Set the header text of the column
            dgvTeachers.Columns.Add(personIDColumn); // Add the column to the DataGridView

            DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
            studentIDColumn.DataPropertyName = "TeacherID"; 
            studentIDColumn.HeaderText = "TeacherID"; 
            dgvTeachers.Columns.Add(studentIDColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dgvTeachers.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
            telephoneColumn.DataPropertyName = "Telephone";
            telephoneColumn.HeaderText = "Telephone";
            dgvTeachers.Columns.Add(telephoneColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";
            dgvTeachers.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.DataPropertyName = "Salary";
            salaryColumn.HeaderText = "Salary";
            dgvTeachers.Columns.Add(salaryColumn);

            DataGridViewTextBoxColumn teachingSubject1Column = new DataGridViewTextBoxColumn();
            teachingSubject1Column.DataPropertyName = "TeachingSubject1";
            teachingSubject1Column.HeaderText = "Teaching Subject 1";
            dgvTeachers.Columns.Add(teachingSubject1Column);

            DataGridViewTextBoxColumn teachingSubject2Column = new DataGridViewTextBoxColumn();
            teachingSubject2Column.DataPropertyName = "TeachingSubject2";
            teachingSubject2Column.HeaderText = "Teaching Subject 2";
            dgvTeachers.Columns.Add(teachingSubject2Column);

            // Bind the DataGridView control to the data source
            dgvTeachers.DataSource = teacher.teachers();

        }

        private void btnAddTeacher_Click(object sender, EventArgs e) // Handle the click event for the Add Teacher button
        {
            // Validate the input fields
            if (txtName.Text == ""
                || txtPhone.Text == ""
                || txtEmail.Text == ""
                || txtSalary.Text == ""
                || cBoxTS1.Text == ""
                || cBoxTS2.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cBoxTS1.Text == cBoxTS2.Text) // Check if the subjects are the same (preventing duplicates)
            {
                MessageBox.Show("Error: Subjects cannot be the same.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSubjects(); // Reload the form to allow the user to correct the input
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        // Insert information to Person table
                        string personQuery = "INSERT INTO Person (Name, Telephone, Email, Role) OUTPUT INSERTED.PersonID VALUES (@Name, @Telephone, @Email, @Role)";
                        int personID;
                        using (SqlCommand personCmd = new SqlCommand(personQuery, conn)) // Create a new SqlCommand object
                        {
                            // Add parameters to the query
                            personCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Role", Role.Teacher.ToString());

                            personID = (int)personCmd.ExecuteScalar(); // Execute the query and get the PersonID of the newly inserted record
                        }

                        // Insert information to Teacher table
                        string teacherQuery = "INSERT INTO Teacher (PersonID, Salary, TeachingSubject1, TeachingSubject2) VALUES (@PersonID, @Salary, @TeachingSubject1, @TeachingSubject2)";
                        using (SqlCommand teacherCmd = new SqlCommand(teacherQuery, conn)) // Creae a new SqlCommand object
                        {
                            // Add parameters to the query
                            teacherCmd.Parameters.AddWithValue("@PersonID", personID);
                            teacherCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.ToString());
                            teacherCmd.Parameters.AddWithValue("@TeachingSubject1", cBoxTS1.Text);
                            teacherCmd.Parameters.AddWithValue("@TeachingSubject2", cBoxTS2.Text);

                            teacherCmd.ExecuteNonQuery(); // Execute the query

                        }
                        // Display a success message
                        MessageBox.Show("Teacher added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        teacherData(); // Reload the DataGridView control

                        // Raise the event
                        PersonAdded?.Invoke(this, EventArgs.Empty);
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

        private void btnUpdateTeacher_Click(object sender, EventArgs e) // Handle the click event for the Update button
        {
            if (cBoxTS1.Text == cBoxTS2.Text) // Check if the subjects are the same (preventing duplicates)
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

                        int personID = GetSelectedPersonID(); // Get the PersonID of the selected teacher

                        // Update the Person table
                        SqlCommand updatePersonCmd = new SqlCommand(
                            "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = @PersonID", conn); // Create a new SqlCommand object
                        // Add parameters to the query
                        updatePersonCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                        updatePersonCmd.ExecuteNonQuery();

                        // Update the Teacher table
                        SqlCommand updateTeacherCmd = new SqlCommand( // Create a new SqlCommand object
                            "UPDATE Teacher SET Salary = @Salary, TeachingSubject1 = @TeachingSubject1, TeachingSubject2 = @TeachingSubject2 WHERE PersonID = @PersonID", conn); 
                        // Add parameters to the query
                        updateTeacherCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                        updateTeacherCmd.Parameters.AddWithValue("@TeachingSubject1", cBoxTS1.Text);
                        updateTeacherCmd.Parameters.AddWithValue("@TeachingSubject2", cBoxTS2.Text);
                        updateTeacherCmd.Parameters.AddWithValue("@PersonID", personID);
                        updateTeacherCmd.ExecuteNonQuery();

                        MessageBox.Show("Teacher updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        teacherData(); // Reload the DataGridView control

                        // Raise the event
                        PersonUpdated?.Invoke(this, EventArgs.Empty);
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

        private void btnDelete_Click(object sender, EventArgs e) // Handle the click event for the Delete button
        {
            // Check if a teacher is selected
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    int personID = GetSelectedPersonID(); // Get the PersonID of the selected teacher

                    // Delete the teacher from the Teacher table
                    SqlCommand deleteTeacherCmd = new SqlCommand("DELETE FROM Teacher WHERE PersonID = @PersonID", conn); // Create a new SqlCommand object
                    deleteTeacherCmd.Parameters.AddWithValue("@PersonID", personID); // Add parameters to the query
                    deleteTeacherCmd.ExecuteNonQuery(); // Execute the query

                    // Delete the teacher from the Person table
                    SqlCommand deletePersonCmd = new SqlCommand("DELETE FROM Person WHERE PersonID = @PersonID", conn); // Create a new SqlCommand object
                    deletePersonCmd.Parameters.AddWithValue("@PersonID", personID); // Add parameters to the query
                    deletePersonCmd.ExecuteNonQuery(); // Execute the query

                    MessageBox.Show("Teacher deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teacherData(); // Reload the DataGridView control

                    // Raise the event
                    PersonDeleted?.Invoke(this, EventArgs.Empty);

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

        private int GetSelectedPersonID() // Get the PersonID of the selected teacher
        {
            // Check if a teacher is selected
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTeachers.SelectedRows[0]; // Get the selected row
                return Convert.ToInt32(selectedRow.Cells[0].Value); // Return the PersonID of the selected teacher
            }
            else
            {
                throw new InvalidOperationException("No teacher selected."); // Throw an exception if no teacher is selected
            }
        }

        private void LoadSubjects() // Load available subjects for the comboboxes
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SubjectName FROM Subject"; // Create a new query to get all subjects
                    using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SqlCommand object
                    {
                        // Execute the query and get the subjects
                        SqlDataReader reader = cmd.ExecuteReader();
                        List<string> subjects = new List<string>() { "" }; // Create a new list to store the subjects and add an empty string as the first element
                        while (reader.Read()) // Loop through the results
                        {
                            subjects.Add(reader["SubjectName"].ToString()); // Add the subject to the list
                        }
                        reader.Close();

                        // Bind the subjects to the ComboBox controls
                        cBoxTS1.DataSource = new List<string>(subjects);
                        cBoxTS2.DataSource = new List<string>(subjects);
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

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e) // Handle the click event for the DataGridView control
        {
            // Check if a row is selected
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex]; // Get the selected row
                txtName.Text = row.Cells[2].Value.ToString(); // Populate the input fields with the data of the selected teacher
                txtPhone.Text = row.Cells[3].Value.ToString(); // Populate the input fields with the data of the selected teacher
                txtEmail.Text = row.Cells[4].Value.ToString(); // Populate the input fields with the data of the selected teacher
                txtSalary.Text = row.Cells[5].Value.ToString(); // Populate the input fields with the data of the selected teacher
                cBoxTS1.Text = row.Cells[6].Value.ToString(); // Populate the input fields with the data of the selected teacher
                cBoxTS2.Text = row.Cells[7].Value.ToString(); // Populate the input fields with the data of the selected teacher
            }
        }
    }
}
