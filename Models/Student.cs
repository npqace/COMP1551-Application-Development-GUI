using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP1551_Coursework.Models.Enums;

namespace COMP1551_Coursework.Models
{
    public class Student : Person // Inherite from Person class
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        // Data members
        public string StudentID { get; set; }
        public new string CurrentSubject1 { get; set; } // Overrides Person.CurrentSubject1
        public new string CurrentSubject2 { get; set; } // Overrides Person.CurrentSubject2
        public new string PreviousSubject1 { get; set; } // Overrides Person.PreviousSubject1
        public new string PreviousSubject2 { get; set; } // Overrides Person.PreviousSubject2

        // Default constructor
        public Student() { }

        // Constructor to create a Student object with the specified values
        public Student(int personID, string name, string telephone, string email, Role userRole, string studentID, string currentSubject1, string currentSubject2, string previousSubject1, string previousSubject2)
            : base(name, telephone, email, userRole)
        {
            this.PersonID = personID;
            this.Name = name;
            this.Telephone = telephone;
            this.Email = email;
            this.UserRole = userRole;
            this.StudentID = studentID;
            this.CurrentSubject1 = currentSubject1;
            this.CurrentSubject2 = currentSubject2;
            this.PreviousSubject1 = previousSubject1;
            this.PreviousSubject2 = previousSubject2;
        }

        // Method to retrieve a list of all Student objects from the database
        public List<Student> students()
        {
            // Create an empty list to store retrieved Student objects
            List<Student> studentList = new List<Student>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open(); // Open the connection to the database

                    // SQL query to retrieve Student data with a join on the Person table
                    string query = @"SELECT
                                    p.PersonID, s.StudentID, p.Name, p.Telephone, p.Email,
                                    s.CurrentSubject1, s.CurrentSubject2, s.PreviousSubject1, s.PreviousSubject2
                                    FROM Student s
                                    LEFT JOIN Person p ON s.PersonID = p.PersonID
                                    WHERE p.Role = 'Student'
                                    ORDER BY s.StudentID";

                    using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a command object for the query
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Execute the query and create a SqlDataReader

                        while (reader.Read()) // Loop through each row returned by the query
                        {
                            Student student = new Student(); // Create a new Student object
                            {
                                // Assign values from the data reader to the Student object properties
                                student.PersonID = Convert.ToInt32(reader["PersonID"]);
                                student.StudentID = reader["StudentID"].ToString();
                                student.Name = reader["Name"].ToString();
                                student.Telephone = reader["Telephone"].ToString();
                                student.Email = reader["Email"].ToString();
                                student.CurrentSubject1 = reader["CurrentSubject1"].ToString();
                                student.CurrentSubject2 = reader["CurrentSubject2"].ToString();
                                student.PreviousSubject1 = reader["PreviousSubject1"].ToString();
                                student.PreviousSubject2 = reader["PreviousSubject2"].ToString();
                            };
                            studentList.Add(student);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return studentList;
        }
    }
}
