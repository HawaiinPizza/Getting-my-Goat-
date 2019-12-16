using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS375Project.classes;

namespace CIS375Project.classes
{
     class Questions
     {
          public int QuestionNum { get; set; }
          public string Question { get; set; }
          public string Answer { get; set; }
          public string Reason { get; set; }
          public int S_id { get; set; }

          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
          
          public void CreateQ(Questions c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "INSERT INTO Questions(question_num, question, s_id) VALUES(NULL, @question, @s_id)";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@question", c.Question);
               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
          public void InsertAnswer(Questions c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "INSERT INTO Questions(answer, reason) VALUES(@answer, @reason)";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@answer", c.Answer);
               cmd.Parameters.AddWithValue("@reason", c.Reason);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
          //this displays all of the questions and answers for a certain STENER
          public void DisplayQandA(Questions c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               con.Open();

               cmd.CommandText = "SELECT * FROM STENER contents X, Questions Y WHERE X.s_id=@s_id AND X.question_num=Y.question_num";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }

     }
}
