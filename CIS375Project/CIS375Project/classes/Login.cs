using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CIS375Project.classes
{
     class Login
     {
          public string Username { get; set; }
          public string Password { get; set; }
        string Conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fru\Source\repos\FuckHoes\BRAINS.accdb";
          //this function will return a bool, true if the credentials match, false if they dont
          StringBuilder errorMessages = new StringBuilder();
          public bool Credentials(Login c)
          {
               //this is for retrieving the credentials from the database
               //SqlConnection connection = new SqlConnection(Connstring);
                   bool match = false;
                    OleDbConnection con = new OleDbConnection(Conn);  
                    OleDbCommand cmd = con.CreateCommand();    
                    con.Open();
                    cmd.CommandText =  "SELECT username, password FROM Credentials WHERE username = @username AND password= @password";
                    cmd.Connection = con;
                    //sets the values from the login screen
                    cmd.Parameters.AddWithValue("@username", c.Username);
                    cmd.Parameters.AddWithValue("@password", c.Password);
                    //variable to return                 
                    int rows = cmd.ExecuteNonQuery();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if ( reader[0].ToString() == c.Username)
                        {
                            rows = 1;
                        }
                    Console.WriteLine(reader[0].ToString());
                    }
            reader.Close();


                    if (rows < 1)
                    {
                        Console.WriteLine("FUCK HOES");
                         match = false;
                    }
                    else
                    {
                        Console.WriteLine(" GET BITCEHS");
                         match = true;
                    }
                    con.Close();
                    
               return match;
          }
          //this gets the department for the login page
          public int GetDepartment(Login c)
          {

                int dept = 0;
                OleDbConnection con = new OleDbConnection(Conn);  
                OleDbCommand cmd = con.CreateCommand();    
                con.Open();
                cmd.CommandText =  "SELECT X.dept_id FROM [UserCredentials] AS [Y], [User] AS [X] WHERE Y.username = @username AND X.user_id = Y.u_id";
                cmd.Connection = con;
                //sets the values from the login screen
                cmd.Parameters.AddWithValue("@username", c.Username);
                //variable to return                 
                cmd.ExecuteNonQuery();
                OleDbDataReader Read = cmd.ExecuteReader();
                while (Read.Read())
                {
                    Int32.TryParse(Read[0].ToString(), out dept);
                }
                con.Close();
                return dept;
            
          }
        
//            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\BRAINS - Copy.accdb");  
//            OleDbCommand cmd = con.CreateCommand();    
//            con.Open();
//            cmd.CommandText = "SELECT * FROM Credentials";
//            cmd.Connection = con;    
//            cmd.ExecuteNonQuery();    
//            OleDbDataReader reader = cmd.ExecuteReader();
//            con.Close();   
     }
}
