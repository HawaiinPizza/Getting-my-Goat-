using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
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

               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "INSERT INTO User (fname, lname, dept_id) VALUES(@fname, @lname, @dept_id)";
               cmd.Connection = con;

               //Anytime you see this, it is inserting values from the user into the SQL statements
               cmd.Parameters.AddWithValue("@fname", c.Fname);
               cmd.Parameters.AddWithValue("@lname", c.Lname);
               cmd.Parameters.AddWithValue("@dept_id", c.DeptID);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();

          }
          //editing a user that has already been created
          public void EditUser(User c)
          {

               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "UPDATE User SET lname=@lname, fname=@fname, user_id=@user_id, dept_id=@dept_id WHERE user_id=@user_id";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@lname", c.Lname);
               cmd.Parameters.AddWithValue("@fname", c.Fname);
               cmd.Parameters.AddWithValue("@user_id", c.UserID);
               cmd.Parameters.AddWithValue("@dept_id", c.DeptID);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
          //deleting a user by choosing a user id
          public void DeleteUser(User c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();

               cmd.CommandText = "DELETE FROM User WHERE user_id=@user_id";
               cmd.Connection = con;

               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
     }
     
}
