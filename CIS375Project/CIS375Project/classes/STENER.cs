using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows;

namespace CIS375Project.classes
{
     class STENER
     {
          public int S_id { get; set; }
          public int D_id { get; set; }
          public string DueDate { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
          //creating a new STENER
          public void CreateS(STENER c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
               try
               {
                    cmd.CommandText = "INSERT INTO STENER(d_id) VALUES(@dept_id)";
                    cmd.Connection = con;

                    //insert value
                    cmd.Parameters.AddWithValue("@d_id", c.D_id);

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
               }
               catch( OleDbException ex)
               {
                    string bad = "That dept already exists";
                    MessageBox.Show(bad);
               }
               con.Close();
          }
          public void DeleteS(STENER c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
              

               cmd.CommandText = "DELETE FROM STENER WHERE s_id=@s_id";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }

          public void Iwish(STENER c)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();
              

               cmd.CommandText = "DELETE FROM STENER WHERE s_id=@s_id";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("@s_id", c.S_id);
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
          public void Sumbit(STENER c, int i)
          {
               OleDbConnection con = new OleDbConnection(Connstring);
               OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE STENER SET status = TRUE WHERE s_id=(               SELECT s_id FROM STENER WHERE d_id=@d_id) ";
               cmd.Connection = con;

               cmd.Parameters.AddWithValue("d_id", i) ;
               cmd.Connection = con;
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
          }
        // Updates the database to approve/disaproove
        public void Approve(STENER c, int id, bool approve)
        {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();

            int value = 0;
            if ( approve == false)
            {
                value = -1;
            }
            else
            {
                value = 1;
            }
            cmd.CommandText = "UPDATE STENER SET approval=@X WHERE s_id=@Y";
            cmd.Parameters.AddWithValue("@X", value);
            Console.WriteLine("ID " + id);
            cmd.Parameters.AddWithValue("@Y", id);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();
            con.Close();


        }
        // Get a list of steners to view
          public List<List<string>> ViewS(STENER c)
          {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();

            cmd.CommandText = cmd.CommandText = "SELECT * FROM STENER ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<List<string>> Arr = new List<List<string>>();
            while (read.Read())
            {
                    List<string> Temp = new List<string>();
                    Temp.Add(read[0].ToString());
                    Temp.Add(read[1].ToString());
                    Arr.Add(Temp);
            }
            con.Close();
            return Arr;
               
          }
        // Get a list of steners to view
          public List<List<string>> ViewF(STENER c)
          {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();

            cmd.CommandText = cmd.CommandText = "SELECT * FROM STENER ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<List<string>> Arr = new List<List<string>>();
            while (read.Read())
            {
                if (read[4].ToString() == "False")
                {
                    List<string> Temp = new List<string>();
                    Temp.Add(read[0].ToString());
                    Temp.Add(read[1].ToString());
                    Arr.Add(Temp);
                }
                else
                {
                    Console.WriteLine("Zaki sucks" + read[4].ToString());
                }
            }
            con.Close();
            return Arr;
               
          }
        // Get a list of steners to view
          public List<List<string>> ViewSS(STENER c)
          {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();

            cmd.CommandText = cmd.CommandText = "SELECT * FROM STENER ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<List<string>> Arr = new List<List<string>>();
            while (read.Read())
            {
                if (read[4].ToString() == "True")
                {
                    List<string> Temp = new List<string>();
                    Temp.Add(read[0].ToString());
                    Temp.Add(read[1].ToString());
                    Arr.Add(Temp);
                }
                else
                {
                    Console.WriteLine("Zaki sucks" + read[4].ToString());
                }
            }
            con.Close();
            return Arr;
               
          }

        // Get a specific
          public List<string> GetSten(STENER c)
          {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();

            cmd.CommandText = "SELECT * FROM STENER WHERE s_id=X AND d_id=Y";
            cmd.Parameters.AddWithValue("Y", c.D_id);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            OleDbDataReader read = cmd.ExecuteReader();

            List<string> Arr = new List<string>();
            while (read.Read())
            {
                string Temp="";

                Temp +=
                    read[0].ToString() +":\t\t" + read[1].ToString() +":\t\t" + read[2].ToString() ;

                Arr.Add(Temp);
            }
            con.Close();
            return Arr;
               
          }
     }

}
