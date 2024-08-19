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
        public event EventHandler PersonAdded; // Declare an event to notify subscribers when a person is added
        public event EventHandler PersonUpdated; // Declare an event to notify subscribers when a person is updated
        public event EventHandler PersonDeleted; // Declare an event to notify subscribers when a person is deleted

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AdminData()
        {
            InitializeComponent();
            LoadEmploymentTypes(); // Call the LoadEmploymentTypes method to load the employment types into the ComboBox
            adminData(); // Call the adminData method to display all admins
        }

        public void adminData()
        {
            Admin admin = new Admin(); // Create a new Admin object

            dgvAdmin.AutoGenerateColumns = false; // Configure the DataGridView to not automatically generate columns
            dgvAdmin.Columns.Clear(); // Clear any existing columns

            // Define columns manually
            DataGridViewTextBoxColumn personIDColumn = new DataGridViewTextBoxColumn(); // Create a new DataGridViewTextBoxColumn to display PersonID data
            personIDColumn.DataPropertyName = "PersonID"; // Bind the column to the "PersonID" property of the data source
            personIDColumn.HeaderText = "PersonID"; // Set the header text of the column
            dgvAdmin.Columns.Add(personIDColumn); // Add the column to the DataGridView

            DataGridViewTextBoxColumn studentIDColumn = new DataGridViewTextBoxColumn();
            studentIDColumn.DataPropertyName = "AdminID"; 
            studentIDColumn.HeaderText = "AdminID"; 
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

            dgvAdmin.DataSource = admin.admins(); // Bind the DataGridView to the list of admins
        }

        private void btnAddAdmin_Click(object sender, EventArgs e) // Handle click event for the Add button
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string personQuery = "INSERT INTO Person (Name, Telephone, Email, Role) OUTPUT INSERTED.PersonID VALUES (@Name, @Telephone, @Email, @Role)"; // Define a query to insert a new person
                    int personID; // Declare a variable to store the ID of the new person
                    using (SqlCommand personCmd = new SqlCommand(personQuery, conn)) // Create a new SqlCommand object
                    {
                        // Add parameters to the query
                        personCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        personCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                        personCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        personCmd.Parameters.AddWithValue("@Role", Role.Admin.ToString());
                        personID = (int)personCmd.ExecuteScalar(); // Execute the query and store the ID of the new person
                    }

                    string adminQuery = "INSERT INTO Admin (PersonID, Salary, EmploymentType, WorkingHours) VALUES (@PersonID, @Salary, @EmploymentType, @WorkingHours)"; // Define a query to insert a new admin
                    using (SqlCommand adminCmd = new SqlCommand(adminQuery, conn)) // Create a new SqlCommand object
                    {
                        // Add parameters to the query
                        adminCmd.Parameters.AddWithValue("@PersonID", personID);
                        adminCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                        adminCmd.Parameters.AddWithValue("@EmploymentType", cBoxEployment.SelectedItem.ToString());
                        adminCmd.Parameters.AddWithValue("@WorkingHours", txtWorkingHours.Text.Trim());
                        adminCmd.ExecuteNonQuery(); // Execute the query
                    }
                    MessageBox.Show("Admin added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminData(); // Call the adminData method to refresh the DataGridView

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

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    int personID = GetSelectedPersonID(); // Get the ID of the selected admin

                    // Update Person table
                    SqlCommand updatePersonCmd = new SqlCommand( // Create a new SqlCommand object to update the Person table
                        "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email WHERE PersonID = @PersonID", conn);
                    // Add parameters to the query
                    updatePersonCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    updatePersonCmd.Parameters.AddWithValue("@Telephone", txtPhone.Text.Trim());
                    updatePersonCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    updatePersonCmd.Parameters.AddWithValue("@PersonID", personID);
                    updatePersonCmd.ExecuteNonQuery(); // Execute the query

                    // Update Admin table
                    SqlCommand updateAdminCmd = new SqlCommand( // Create a new SqlCommand object to update the Admin table
                        "UPDATE Admin SET Salary = @Salary, EmploymentType = @EmploymentType, WorkingHours = @WorkingHours WHERE PersonID = @PersonID", conn);
                    // Add parameters to the query
                    updateAdminCmd.Parameters.AddWithValue("@Salary", txtSalary.Text.Trim());
                    updateAdminCmd.Parameters.AddWithValue("@EmploymentType", cBoxEployment.SelectedItem.ToString());
                    updateAdminCmd.Parameters.AddWithValue("@WorkingHours", txtWorkingHours.Text.Trim());
                    updateAdminCmd.Parameters.AddWithValue("@PersonID", personID);
                    updateAdminCmd.ExecuteNonQuery(); // Execute the query

                    MessageBox.Show("Admin updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminData(); // Call the adminData method to refresh the DataGridView

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

        private void btnDeleteAdmin_Click(object sender, EventArgs e) // Handle click event for the Delete button
        {
            // Check if a row is selected
            if (dgvAdmin.SelectedRows.Count == 0) // If no row is selected
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

        private int GetSelectedPersonID() // Method to get the ID of the selected admin
        {
            if (dgvAdmin.SelectedRows.Count > 0) // If a row is selected
            {
                DataGridViewRow selectedRow = dgvAdmin.SelectedRows[0]; // Get the selected row
                return Convert.ToInt32(selectedRow.Cells[0].Value); // Return the value of the PersonID cell in the selected row
            }
            else
            {
                throw new InvalidOperationException("No admin selected.");
            }
        }

        private void LoadEmploymentTypes() // Method to load the employment types into the ComboBox
        {
            // Create a list of strings and add an empty string as the first item
            List<string> employmentTypes = new List<string> { "" };

            // Add the enum values to the list
            employmentTypes.AddRange(Enum.GetNames(typeof(EmploymentType)));

            // Bind the list to the ComboBox
            cBoxEployment.DataSource = employmentTypes;
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e) // Handle click event for the DataGridView
        {
            if(e.RowIndex >= 0) // If a row is selected
            {
                // Get the selected row
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
