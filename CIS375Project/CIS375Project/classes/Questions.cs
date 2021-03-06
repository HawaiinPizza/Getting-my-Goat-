﻿using System;
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
          public string Evidence { get; set; }
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
          public void UpdateQ(Questions c, string question, string id)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               cmd.CommandText = "UPDATE Questions SET question=@question, answer='', reason='', Evidence='' WHERE question_num=@question_id ";

               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@question", question);
               cmd.Parameters.AddWithValue("@s_id",id);
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

               cmd.CommandText = "UPDATE Questions SET  answer=@answer, reason=@reason, Evidence=@evidence WHERE question_num=@question_id ";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@answer", c.Answer);
               cmd.Parameters.AddWithValue("@reason", c.Reason);
               cmd.Parameters.AddWithValue("@Evidence", c.Evidence);
               cmd.Parameters.AddWithValue("@question_num", c.QuestionNum);
               cmd.Connection = con;
               cmd.ExecuteNonQuery();
               con.Close();
          }
            public List<List<string>> DisplayQandADep(Questions c, int i)
            {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            con.Open();

             cmd.CommandText = "SELECT * FROM Questions where s_id=(SELECT s_id FROM STENER WHERE d_id=d_id)";
                

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Parameters.AddWithValue("d_id", i) ;
            cmd.Connection = con;
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<List<string>> Arr = new List<List<string>>();
            while (read.Read())
            {
                List<string> Temp = new List<string>();
                Temp.Add(read[0].ToString());
                Temp.Add(read[1].ToString());
                Temp.Add(read[2].ToString());
                Temp.Add(read[4].ToString());
                Temp.Add(read[5].ToString());
                Temp.Add(read[6].ToString());
                Arr.Add(Temp);
            }


            con.Close();
            return Arr;
          }
          //this displays all of the questions and answers for a certain STENER
            public List<List<string>> DisplayQandA(Questions c, int i)
            {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            DataTable dt = new DataTable();
            con.Open();

             cmd.CommandText = "SELECT * FROM Questions where s_id=@s_id";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@s_id", i) ;
            cmd.Connection = con;
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<List<string>> Arr = new List<List<string>>();
            while (read.Read())
            {
                List<string> Temp = new List<string>();
                Temp.Add(read[0].ToString());
                Temp.Add(read[1].ToString());
                Temp.Add(read[2].ToString());
                Temp.Add(read[4].ToString());
                Temp.Add(read[5].ToString());
                Temp.Add(read[6].ToString());
                Arr.Add(Temp);
            }


            con.Close();
            return Arr;
          }

     }
}
