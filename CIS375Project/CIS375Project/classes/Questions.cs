using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
              

               cmd.CommandText = "INSERT INTO Questions(question, s_id) VALUES(@question, @s_id)";
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
            public List<string> DisplayQandA(Questions c, int i)
            {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            con.Open();

            cmd.CommandText = cmd.CommandText = "select * from Questions where s_id= @s_id";
            cmd.Parameters.AddWithValue("@s_id", i);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Connection = con;
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<string> Arr = new List<string>();
            while (read.Read())
            {
                string Temp="";

                Temp +=
                    read[0].ToString() + ":\t"+  read[1].ToString() + ":\t"+read[2].ToString() + "\n" ;

                Arr.Add(Temp);
            }

            con.Close();
            return Arr;
          }

     }
}
