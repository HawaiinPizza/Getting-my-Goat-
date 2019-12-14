using System;
using System.Collections.Generic;
using System.Configuration;
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
               SqlConnection connection = new SqlConnection(Connstring);
               string sql = "INSERT INTO Questions(question_num, question, s_id) VALUES(NULL, @question, @s_id)";
               SqlCommand cmd = new SqlCommand(sql, connection);
               cmd.Parameters.AddWithValue("@question", c.Question);
               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = connection;
               connection.Open();
               cmd.ExecuteNonQuery();
               connection.Close();
          }
          public void InsertAnswer(Questions c)
          {
               SqlConnection connection = new SqlConnection(Connstring);
               string sql = "INSERT INTO Questions(answer, reason) VALUES(@answer, @reason)";
               SqlCommand cmd = new SqlCommand(sql, connection);
               cmd.Parameters.AddWithValue("@answer", c.Answer);
               cmd.Parameters.AddWithValue("@reason", c.Reason);
               cmd.Connection = connection;
               connection.Open();
               cmd.ExecuteNonQuery();
               connection.Close();
          }
          //this displays all of the questions and answers for a certain STENER
          public void DisplayQandA(Questions c)
          {
               SqlConnection connection = new SqlConnection(Connstring);
               string sql = "SELECT * FROM STENER contents X, Questions Y WHERE X.s_id=@s_id AND X.question_num=Y.question_num";
               SqlCommand cmd = new SqlCommand(sql, connection);
               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = connection;
               connection.Open();
               cmd.ExecuteNonQuery();
               connection.Close();
          }

     }
}
