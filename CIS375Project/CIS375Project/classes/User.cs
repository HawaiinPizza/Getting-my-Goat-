using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS375Project.classes
{
     class User {
         //getter and setter functions
         public int UserID { get; set; }
         public string Fname { get; set; }
         public string Lname { get; set; }
          static string connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
     }
}
