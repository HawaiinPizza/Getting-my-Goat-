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
          public string Username { get; set; }
          public string Password { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
          //creating a new user into the system
          public void AddUser(User c)
          {

               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               OleDbCommand cmd2 = con.CreateCommand();
               OleDbCommand cmd3 = con.CreateCommand();
               OleDbCommand cmd4 = con.CreateCommand();
               //all of these are for the different sql commands
               cmd.Connection = con;
               cmd2.Connection = con;
               cmd3.Connection = con;
               cmd4.Connection = con;
               //this inserts the user data into the user table
               cmd.CommandText = "INSERT INTO User(fname, lname, dept_id) VALUES(@fname, @lname, @dept_id)";
               cmd.Parameters.AddWithValue("@fname", c.Fname);
               cmd.Parameters.AddWithValue("@lname", c.Lname);
               cmd.Parameters.AddWithValue("@dept_id", c.DeptID);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
               //this inserts the username and password into credentials
               cmd2.CommandText = "INSERT INTO Credentials(username, password) VALUES(@username,@password)";
               cmd2.Parameters.AddWithValue("@username", c.Username);
               cmd2.Parameters.AddWithValue("@password", c.Password);
               con.Open();
               cmd2.ExecuteNonQuery();
               con.Close();
               int user_id;
               /*so for this, it gets the user id from the recently created user
                which then inserts that along with the created username into the table
                that links them together, so it will work for the login function */
               cmd3.CommandText = "SELECT MAX(user_id) FROM User";
               con.Open();
               user_id = (Int32)cmd3.ExecuteScalar();
               con.Close();
               cmd4.CommandText = "INSERT INTO Usercredentials(u_id,username)VALUES(@u_id,@username)";
               cmd4.Parameters.AddWithValue("@u_id", user_id);
               cmd4.Parameters.AddWithValue("username", c.Username);
               con.Open();
               cmd4.ExecuteNonQuery();
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
