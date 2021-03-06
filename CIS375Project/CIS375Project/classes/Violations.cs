﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using CIS375Project.classes;

namespace CIS375Project.classes
{
     class Violations
     {
          public string Description { get; set; }
          public int ViolationID { get; set; }
          public DateTime Vdate { get; set; }
          public bool Resolved { get; set; }
          public int DeptID { get; set; }
        public string Rating { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;



          public void AddV(Violations c)
          {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "INSERT INTO Violationlog(Description, violationID, v_date, resolved, dept_id, rating) VALUES(@Description, @violationID, @v_date, @resolved, @dept_id, @rating)";
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@Description", c.Description);
            cmd.Parameters.AddWithValue("@violationID", c.ViolationID);
            cmd.Parameters.AddWithValue("@v_date", c.Vdate);
            cmd.Parameters.AddWithValue("@resolved", c.Resolved);
            cmd.Parameters.AddWithValue("@dept_id", c.DeptID);
            cmd.Parameters.AddWithValue("@rating", c.Rating);

            cmd.ExecuteNonQuery();
            con.Close();


        }

        public void DeleteVio(Violations c)
        {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();

            
            cmd.CommandText = "DELETE FROM Violationlog WHERE violationID=@violationID";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@violationID", c.ViolationID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void ViewUserViolation(Violations c)
        {
            OleDbConnection con = new OleDbConnection(Connstring);
            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "DELETE FROM Violationlog WHERE violationID=@violationID";
            cmd.Connection = con;
            //cmd.Parameters.AddWithValue("@violationID", c.ViolationID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


     }
}
