﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS375Project.classes
{
     class Login
     {
          public string Username { get; set; }
          public string Password { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
          //this function will return a bool, true if the credentials match, false if they dont
          public bool Credentials(Login c)
          {
               //this is for retrieving the credentials from the database
               SqlConnection connection = new SqlConnection(Connstring);
               bool match = false;
               try
               {
                    string sql = "SELECT username, password FROM Credentials WHERE username = @username AND password= @password";
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    connection.Open();
                    cmd.Connection = connection;
                    //sets the values from the login screen
                    cmd.Parameters.AddWithValue("@username", c.Username);
                    cmd.Parameters.AddWithValue("@password", c.Password);
                    //variable to return                 
                    
                    int rows = cmd.ExecuteNonQuery();
                    if (rows < 1)
                    {
                         match = false;
                        
                    }
                    else
                    {
                         match = true;
                         
                    }
               }
               catch (Exception ex)
               {
                   
                    

               }
               finally
               {
                    connection.Close();
                    
               }
               return match;
          }
          //this gets the department for the login page
          public int GetDepartment(Login c)
          {
               
               SqlConnection connection = new SqlConnection(Connstring);

               string sql = "SELECT X.dept_id FROM [User credentials] Y, User X WHERE Y.username = @username AND X.user_id = Y.u_id;";
               SqlCommand cmd = new SqlCommand(sql, connection);
               connection.Open();
               cmd.Parameters.AddWithValue("@username", c.Username);
               int dept = (int)cmd.ExecuteScalar();
               return dept;

          }

     }
}
