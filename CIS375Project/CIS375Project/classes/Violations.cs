using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS375Project.classes
{
     class Violations
     {
          public string Description { get; set; }
          public int ViolationID { get; set; }
          public DateTime Vdate { get; set; }
          public bool Resolved { get; set; }
          public int DeptID { get; set; }
          static string Connstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

          public void DisplayV(Violations c)
          {

          }
     }
}
