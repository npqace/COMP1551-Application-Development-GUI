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
    public partial class AdminData : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AdminData()
        {
            InitializeComponent();
            LoadEmploymentTypes();
            adminData();
        }

        private void AdminData_Load(object sender, EventArgs e)
        {

        }

        public void adminData()
        {
            Admin admin = new Admin();

            dgvAdmin.AutoGenerateColumns = false;
            dgvAdmin.Columns.Clear();

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn();
            personIDColumn.DataPropertyName = "PersonID"; // The property name in your Admin class
            personIDColumn.HeaderText = "PersonID"; // The column header text
            dgvAdmin.Columns.Add(personIDColumn);

            DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
            studentIDColumn.DataPropertyName = "AdminID"; // The property name in your Admin class
            studentIDColumn.HeaderText = "AdminID"; // The column header text
            dgvAdmin.Columns.Add(studentIDColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dgvAdmin.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn telephoneColumn = new DataGridViewTextBoxColumn();
            telephoneColumn.DataPropertyName = "Telephone";
            telephoneColumn.HeaderText = "Telephone";
            dgvAdmin.Columns.Add(telephoneColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";
            dgvAdmin.Columns.Add(emailColumn);

            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn();
            salaryColumn.DataPropertyName = "Salary";
            salaryColumn.HeaderText = "Salary";
            dgvAdmin.Columns.Add(salaryColumn);

            DataGridViewTextBoxColumn employmentTypeColumn = new DataGridViewTextBoxColumn();
            employmentTypeColumn.DataPropertyName = "EmploymentType";
            employmentTypeColumn.HeaderText = "EmploymentType";
            dgvAdmin.Columns.Add(employmentTypeColumn);

            DataGridViewTextBoxColumn workingHoursColumn = new DataGridViewTextBoxColumn();
            workingHoursColumn.DataPropertyName = "WorkingHours";
            workingHoursColumn.HeaderText = "WorkingHours";
            dgvAdmin.Columns.Add(workingHoursColumn);

            dgvAdmin.DataSource = admin.admins();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
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
                        personCmd.Parameters.AddWithValue("@Role", Role.Admin.ToString());

                        personID = (int)personCmd.ExecuteScalar();
                    }

                    string adminQuery = "INSERT INTO Admin (PersonID, Salary, EmploymentType, WorkingHours) VALUES (@PersonID, @Salary, @EmploymentType, @WorkingHours)";
                    using (SqlCommand adminCmd = new SqlCommand(adminQuery, conn))
                    {
                        adminCmd.Parameters.AddWithValue("@PersonID", personID);
                        adminCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                        adminCmd.Parameters.AddWithValue("@EmploymentType", cBoxEployment.SelectedItem.ToString());
                        adminCmd.Parameters.AddWithValue("@WorkingHours", txtWorkingHours.Text.Trim());
                        adminCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Admin added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminData();
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

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    int personID = GetSelectedPersonID();

                    // Update Person table
                    SqlCommand updatePersonCmd = new SqlCommand(
                        "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = @PersonID", conn);
                    updatePersonCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    updatePersonCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                    updatePersonCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    updatePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                    updatePersonCmd.ExecuteNonQuery();

                    // Update Admin table
                    SqlCommand updateAdminCmd = new SqlCommand(
                        "UPDATE Admin SET Salary = @Salary, EmploymentType = @EmploymentType, WorkingHours = @WorkingHours WHERE PersonID = @PersonID", conn);
                    updateAdminCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                    updateAdminCmd.Parameters.AddWithValue("@EmploymentType", cBoxEployment.SelectedItem.ToString());
                    updateAdminCmd.Parameters.AddWithValue("@WorkingHours", txtWorkingHours.Text.Trim());
                    updateAdminCmd.Parameters.AddWithValue("@PersonID", personID);
                    updateAdminCmd.ExecuteNonQuery();

                    MessageBox.Show("Admin updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminData();
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

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an admin to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Display confirmation box
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected admin?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

                    // Delete from Admin table
                    SqlCommand deleteAdminCmd = new SqlCommand("DELETE FROM Admin WHERE PersonID = @PersonID", conn);
                    deleteAdminCmd.Parameters.AddWithValue("@PersonID", personID);
                    deleteAdminCmd.ExecuteNonQuery();

                    // Delete from Person table
                    SqlCommand deletePersonCmd = new SqlCommand("DELETE FROM Person WHERE PersonID = @PersonID", conn);
                    deletePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                    deletePersonCmd.ExecuteNonQuery();

                    MessageBox.Show("Admin deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminData();
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
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            else
            {
                throw new InvalidOperationException("No admin selected.");
            }
        }

        private void LoadEmploymentTypes()
        {
            // Create a list of strings and add an empty string as the first item
            List<string> employmentTypes = new List<string> { "" };

            // Add the enum values to the list
            employmentTypes.AddRange(Enum.GetNames(typeof(EmploymentType)));

            // Bind the list to the ComboBox
            cBoxEployment.DataSource = employmentTypes;
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];
                txtName.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtSalary.Text = row.Cells[5].Value.ToString();
                cBoxEployment.SelectedItem = row.Cells[6].Value.ToString();
                txtWorkingHours.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
