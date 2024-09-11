using COMP1551_Coursework.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1551_Coursework.Models
{
    public class Admin : Person // Inherite from Person class
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        
        // Data members
        public string AdminID { get; set; }
        public new decimal Salary { get; set; } // Overrides Person.Salary
        public EmploymentType employmentType { get; set; }
        public int WorkingHours { get; set; }

        // Default constructor
        public Admin() { }

        // Constructor to create an Admin object with the specified values
        public Admin (int personID, string name, string telephone, string email, Role userRole, string adminID, decimal salary, EmploymentType employmentType, int workingHours)
            : base(name, telephone, email, userRole)
        {
            this.PersonID = personID;
            this.Name = name;
            this.Telephone = telephone;
            this.Email = email;
            this.UserRole = userRole;
            this.AdminID = adminID;
            this.Salary = salary;
            this.employmentType = employmentType;
            this.WorkingHours = workingHours;
        }

        // Method to retrieve a list of all Admin objects from the databas
        public List<Admin> admins()
        {
            // Create an empty list to store retrieved Admin objects
            List<Admin> adminList = new List<Admin>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    // Open the connection to the database
                    conn.Open();
                    // SQL query to retrieve Admin data with a join on the Person table
                    string query = @"SELECT
                                    p.PersonID, a.AdminID, p.Name, p.Telephone, p.Email,
                                    a.Salary, a.EmploymentType, a.WorkingHours
                                    FROM Admin a
                                    LEFT JOIN Person p ON a.PersonID = p.PersonID
                                    WHERE p.Role = 'Admin'
                                    ORDER BY a.AdminID";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a command object for the query
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Execute the query and create a SqlDataReader
                        while (reader.Read()) // Loop through each row returned by the query
                        {
                            Admin admin = new Admin(); // Create a new Admin object
                            {
                                // Assign values from the data reader to the Admin object properties
                                admin.PersonID = Convert.ToInt32(reader["PersonID"]);
                                admin.AdminID = reader["AdminID"].ToString();
                                admin.Name = reader["Name"].ToString();
                                admin.Telephone = reader["Telephone"].ToString();
                                admin.Email = reader["Email"].ToString();
                                admin.Salary = Convert.ToDecimal(reader["Salary"]);
                                admin.employmentType = (EmploymentType)Enum.Parse(typeof(EmploymentType), reader["EmploymentType"].ToString());
                                admin.WorkingHours = Convert.ToInt32(reader["WorkingHours"]);
                            };
                            adminList.Add(admin); // Add the created Admin object to the list
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return adminList;
        }
    }
}
