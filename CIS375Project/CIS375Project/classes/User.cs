using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS375Project.classes
{
     class User {
         //getter and setter functions
         public int UserID { get; set; }
         public string Fname { get; set; }
         public string Lname { get; set; }
          public int DeptID { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
          //creating a new user into the system
          public void AddUser(User c)
          {
               SqlConnection connection = new SqlConnection(Connstring);
               string sql = "INSERT INTO User (fname, lname, dept_id) VALUES(@fname, @lname, @dept_id)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
               //Anytime you see this, it is inserting values from the user into the SQL statements
               cmd.Parameters.AddWithValue("@fname", c.Fname);
               cmd.Parameters.AddWithValue("@lname", c.Lname);
               cmd.Parameters.AddWithValue("@dept_id", c.DeptID);
               connection.Open();
               cmd.ExecuteNonQuery();
               connection.Close();

          }
          //editing a user that has already been created
          public void EditUser(User c)
          {
               SqlConnection connection = new SqlConnection(Connstring);
               string sql = "UPDATE User SET lname=@lname, fname=@fname, user_id=@user_id, dept_id=@dept_id WHERE user_id=@user_id";
               SqlCommand cmd = new SqlCommand(sql, connection);
               cmd.Parameters.AddWithValue("@lname", c.Lname);
               cmd.Parameters.AddWithValue("@fname", c.Fname);
               cmd.Parameters.AddWithValue("@user_id", c.UserID);
               cmd.Parameters.AddWithValue("@dept_id", c.DeptID);
               cmd.Connection = connection;
               connection.Open();
               cmd.ExecuteNonQuery();
               connection.Close();
          }
          //deleting a user by choosing a user id
          public void DeleteUser(User c)
          {

               SqlConnection connection = new SqlConnection(Connstring);
               string sql = "DELETE FROM User WHERE user_id=@user_id";
               SqlCommand cmd = new SqlCommand(sql, connection);


               cmd.Connection = connection;
               connection.Open();
               cmd.ExecuteNonQuery();
               connection.Close();

          }
     }
     
}
