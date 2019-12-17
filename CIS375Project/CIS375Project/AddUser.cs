using CIS375Project.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS375Project
{
     public partial class AddUser : Form
     {
          public AddUser()
          {
               InitializeComponent();
          }

          private void AddUserBtn_Click(object sender, EventArgs e)
          {
               User c = new User();
               c.Fname = FnameBox.Text;
               c.Lname = LnameBox.Text;
               c.DeptID = Int32.Parse(dIDBox.Text);
               c.Username = UsernameBox.Text;
               c.Password = PasswordBox.Text;
            Console.WriteLine(c.Fname+ c.Lname + c.DeptID + c.Username + c.Password);
               c.AddUser(c);
               this.Hide();
               OversightScreen FormDepart = new OversightScreen();
               FormDepart.ShowDialog();
          }
     }
}
