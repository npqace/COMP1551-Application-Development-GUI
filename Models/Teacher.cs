using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP1551_Coursework.Models.Enums;

namespace COMP1551_Coursework.Models
{
    public class Teacher : Person // Inherite from Person class
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        // Data members
        public string TeacherID { get; set; }
        public new decimal Salary { get; set; } // Overrides Person.Salary
        public new string TeachingSubject1 { get; set; } // Overrides Person.TeachingSubject1
        public new string TeachingSubject2 { get; set; } // Overrides Person.TeachingSubject2

        // Default constructor
        public Teacher() { }

        // Constructor to create a Teacher object with the specified values
        public Teacher(int personID, string name, string telephone, string email, Role userRole, string teacherID, decimal salary, string teachingSubject1, string teachingSubject2)
            : base(name, telephone, email, userRole)
        {
            this.PersonID = personID;
            this.Name = name;
            this.Telephone = telephone;
            this.Email = email;
            this.UserRole = userRole;
            this.TeacherID = teacherID;
            this.Salary = salary;
            this.TeachingSubject1 = teachingSubject1;
            this.TeachingSubject2 = teachingSubject2;
        }

        // Method to retrieve a list of all Teacher objects from the database
        public List<Teacher> teachers()
        {
            // Create an empty list to store retrieved Teacher objects
            List<Teacher> teacherList = new List<Teacher>();

            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open(); // Open the connection to the database

                    // SQL query to retrieve Teacher data with a join on the Person table
                    string query = @"SELECT
                        p.PersonID, t.TeacherID, p.Name, p.Telephone, p.Email, t.Salary,
                        t.TeachingSubject1, t.TeachingSubject2
                        FROM Teacher t
                        LEFT JOIN Person p ON t.PersonID = p.PersonID
                        WHERE p.Role = 'Teacher'
                        ORDER BY t.TeacherID";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a command object for the query
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Execute the query and create a SqlDataReader

                        while (reader.Read()) // Loop through each row returned by the query
                        {
                            Teacher teacher = new Teacher(); // Create a new Teacher object
                            {
                                // Assign values from the data reader to the Teacher object properties
                                teacher.PersonID = Convert.ToInt32(reader["PersonID"]);
                                teacher.TeacherID = reader["TeacherID"].ToString();
                                teacher.Name = reader["Name"].ToString();
                                teacher.Telephone = reader["Telephone"].ToString();
                                teacher.Email = reader["Email"].ToString();
                                teacher.Salary = Convert.ToDecimal(reader["Salary"]);
                                teacher.TeachingSubject1 = reader["TeachingSubject1"].ToString();
                                teacher.TeachingSubject2 = reader["TeachingSubject2"].ToString();
                            };
                            teacherList.Add(teacher);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connection Database: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return teacherList;
        }
    }
}
