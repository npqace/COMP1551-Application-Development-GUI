using COMP1551_Coursework.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COMP1551_Coursework.Models
{
    public class Person 
    {
        // Connect to the database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        
        // Data members
        public int PersonID { get; internal set; } // internal set so that it can only be set within the class
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; set; }
        public decimal? Salary { get; set; }
        public string TeachingSubject1 { get; set; }
        public string TeachingSubject2 { get; set; }
        public string CurrentSubject1 { get; set; }
        public string CurrentSubject2 { get; set; }
        public string PreviousSubject1 { get; set; }
        public string PreviousSubject2 { get; set; }
        
        // Default constructor
        public Person() { }

        // Constructor to create a Person object with the specified values
        public Person(string name, string telephone, string email, Role userRole)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            UserRole = userRole;
        }


        // Method to retrieve a list of all people from the database
        public List<Person> UserList()
        {
            // Create an empty list to store the retrieved users
            List<Person> users = new List<Person>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    // SQL query to retrieve user data from multiple tables
                    string query = @"SELECT 
                                    p.PersonID, p.Name, p.Telephone, p.Email, p.Role, 
                                    COALESCE(a.Salary, t.Salary) AS Salary, 
                                    t.TeachingSubject1, t.TeachingSubject2, 
                                    s.CurrentSubject1, s.CurrentSubject2, s.PreviousSubject1, s.PreviousSubject2
                                    FROM Person p
                                    LEFT JOIN Admin a ON p.PersonID = a.PersonID
                                    LEFT JOIN Teacher t ON p.PersonID = t.PersonID
                                    LEFT JOIN Student s ON p.PersonID = s.PersonID
                                    ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the command and create a SqlDataReader to read the results
                        SqlDataReader reader = cmd.ExecuteReader();
                        {
                            // Loop through each row in the result set retrieved from the database
                            while (reader.Read())
                            {
                                Person user = new Person();
                                {
                                    // Assign values from the reader to the user object
                                    user.PersonID = Convert.ToInt32(reader["PersonID"]);
                                    user.Name = reader["Name"].ToString();
                                    user.Telephone = reader["Telephone"].ToString();
                                    user.Email = reader["Email"].ToString();
                                    user.UserRole = (Role)Enum.Parse(typeof(Role), reader["Role"].ToString());
                                    user.Salary = reader["Salary"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["Salary"]);
                                    user.TeachingSubject1 = reader["TeachingSubject1"].ToString();
                                    user.TeachingSubject2 = reader["TeachingSubject2"].ToString();
                                    user.CurrentSubject1 = reader["CurrentSubject1"].ToString();
                                    user.CurrentSubject2 = reader["CurrentSubject2"].ToString();
                                    user.PreviousSubject1 = reader["PreviousSubject1"].ToString();
                                    user.PreviousSubject2 = reader["PreviousSubject2"].ToString();
                                }
                                users.Add(user);
                            }
                            // Close the SqlDataReader to release resources
                            reader.Close();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return users;
        }
    }
}
