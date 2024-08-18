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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public TeacherData()
        {
            InitializeComponent();
            LoadSubjects();
            teacherData();
        }

        public void teacherData()
        {
            Teacher teacher = new Teacher();

            dgvTeachers.AutoGenerateColumns = false;

            dgvTeachers.Columns.Clear();

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn();
            personIDColumn.DataPropertyName = "PersonID"; // The property name in your Student class
            personIDColumn.HeaderText = "PersonID"; // The column header text
            dgvTeachers.Columns.Add(personIDColumn);

            DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
            studentIDColumn.DataPropertyName = "TeacherID"; // The property name in your Student class
            studentIDColumn.HeaderText = "TeacherID"; // The column header text
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

            dgvTeachers.DataSource = teacher.teachers();

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (txtName.Text == ""
                || txtPhone.Text == ""
                || txtEmail.Text == ""
                || txtSalary.Text == ""
                || cBoxTS1.Text == ""
                || cBoxTS2.Text == "")
            {
                MessageBox.Show("Please fill all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cBoxTS1.Text == cBoxTS2.Text)
            {
                MessageBox.Show("Error: Subjects cannot be the same.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadSubjects();
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        string personQuery = "INSERT INTO Person (Name, Telephone, Email, Role) OUTPUT INSERTED.PersonID VALUES (@Name, @Telephone, @Email, @Role)";
                        int personID;
                        using (SqlCommand personCmd = new SqlCommand(personQuery, conn))
                        {
                            personCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            personCmd.Parameters.AddWithValue("@Role", Role.Teacher.ToString());

                            personID = (int)personCmd.ExecuteScalar();
                        }

                        string teacherQuery = "INSERT INTO Teacher (PersonID, Salary, TeachingSubject1, TeachingSubject2) VALUES (@PersonID, @Salary, @TeachingSubject1, @TeachingSubject2)";
                        using (SqlCommand teacherCmd = new SqlCommand(teacherQuery, conn))
                        {
                            teacherCmd.Parameters.AddWithValue("@PersonID", personID);
                            teacherCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.ToString());
                            teacherCmd.Parameters.AddWithValue("@TeachingSubject1", cBoxTS1.Text);
                            teacherCmd.Parameters.AddWithValue("@TeachingSubject2", cBoxTS2.Text);

                            teacherCmd.ExecuteNonQuery();

                        }

                        MessageBox.Show("Teacher added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        teacherData();
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

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            if (cBoxTS1.Text == cBoxTS2.Text)
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

                        int personID = GetSelectedPersonID();

                        SqlCommand updatePersonCmd = new SqlCommand(
                            "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = @PersonID", conn);
                        updatePersonCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        updatePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                        updatePersonCmd.ExecuteNonQuery();

                        SqlCommand updateTeacherCmd = new SqlCommand(
                            "UPDATE Teacher SET Salary = @Salary, TeachingSubject1 = @TeachingSubject1, TeachingSubject2 = @TeachingSubject2 WHERE PersonID = @PersonID", conn);
                        updateTeacherCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                        updateTeacherCmd.Parameters.AddWithValue("@TeachingSubject1", cBoxTS1.Text);
                        updateTeacherCmd.Parameters.AddWithValue("@TeachingSubject2", cBoxTS2.Text);
                        updateTeacherCmd.Parameters.AddWithValue("@PersonID", personID);
                        updateTeacherCmd.ExecuteNonQuery();

                        MessageBox.Show("Teacher updated successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        teacherData();
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
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                    int personID = GetSelectedPersonID();

                    SqlCommand deleteTeacherCmd = new SqlCommand("DELETE FROM Teacher WHERE PersonID = @PersonID", conn);
                    deleteTeacherCmd.Parameters.AddWithValue("@PersonID", personID);
                    deleteTeacherCmd.ExecuteNonQuery();

                    SqlCommand deletePersonCmd = new SqlCommand("DELETE FROM Person WHERE PersonID = @PersonID", conn);
                    deletePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                    deletePersonCmd.ExecuteNonQuery();

                    MessageBox.Show("Teacher deleted successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teacherData();

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
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTeachers.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                throw new InvalidOperationException("No teacher selected.");
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

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeachers.Rows[e.RowIndex];
                txtName.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtSalary.Text = row.Cells[5].Value.ToString();
                cBoxTS1.Text = row.Cells[6].Value.ToString();
                cBoxTS2.Text = row.Cells[7].Value.ToString();
            }
        }

        private void TeacherData_Load(object sender, EventArgs e)
        {

        }
    }
}
