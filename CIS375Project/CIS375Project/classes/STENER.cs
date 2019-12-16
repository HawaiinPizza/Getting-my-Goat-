using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS375Project.classes
{
     class STENER
     {
          public int S_id { get; set; }
          public int D_id { get; set; }
          public DateTime DueDate { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
          //creating a new STENER
          public void CreateS(STENER c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "INSERT INTO STENER(s_id,dept_id) VALUES(NULL, @dept_id)";
               cmd.Connection = con;

               //insert value
               cmd.Parameters.AddWithValue("@dept_id", c.D_id);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
          public void DeleteS(STENER c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "DELETE FROM STENER WHERE s_id=@s_id";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }

     }
}
