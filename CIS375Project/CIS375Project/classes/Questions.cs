using CIS375Project.classes;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CIS375Project.classes
{
     class Questions
     {
          public int QuestionNum { get; set; }
          public string Question { get; set; }
          public string Answer { get; set; }
          public string Reason { get; set; }
          public int S_id { get; set; }

          static string Connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\fru\Source\repos\FuckHoes\BRAINS.accdb";

          
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
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            con.Open();

            cmd.CommandText = cmd.CommandText = "SELECT Y.* FROM STENERcontents X, Questions Y WHERE X.s_id=@s_id AND X.question_num=Y.question_num";
            cmd.Parameters.AddWithValue("@s_id", 1);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Connection = con;
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            int i = 0;
            while (read.Read())
            {
                
                Console.WriteLine(i + "\t"+ read[0].ToString()+ "	" +read[1].ToString()+ "	" +read[2].ToString()+ "	" +read[3].ToString()+ "	" +read[4].ToString()+ "	" +read[5].ToString());
                i++;
            }

            con.Close();
        }
     }
}
