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
    public class Admin : Person
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\comp1551_coursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        
        // data member
        public string AdminID { get; set; }
        public new decimal Salary { get; set; }
        public EmploymentType employmentType { get; set; }
        public int WorkingHours { get; set; }

        public Admin() { }
        //constructor
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

        public List<Admin> admins()
        {
            List<Admin> adminList = new List<Admin>();

            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT
                                    p.PersonID, a.AdminID, p.Name, p.Telephone, p.Email,
                                    a.Salary, a.EmploymentType, a.WorkingHours
                                    FROM Admin a
                                    LEFT JOIN Person p ON a.PersonID = p.PersonID
                                    WHERE p.Role = 'Admin'
                                    ORDER BY a.AdminID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Admin admin = new Admin();
                            {
                                admin.PersonID = Convert.ToInt32(reader["PersonID"]);
                                admin.AdminID = reader["AdminID"].ToString();
                                admin.Name = reader["Name"].ToString();
                                admin.Telephone = reader["Telephone"].ToString();
                                admin.Email = reader["Email"].ToString();
                                admin.Salary = Convert.ToDecimal(reader["Salary"]);
                                admin.employmentType = (EmploymentType)Enum.Parse(typeof(EmploymentType), reader["EmploymentType"].ToString());
                                admin.WorkingHours = Convert.ToInt32(reader["WorkingHours"]);
                            };
                            adminList.Add(admin);
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
