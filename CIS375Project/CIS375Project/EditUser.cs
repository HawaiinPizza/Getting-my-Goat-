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
     public partial class EditUser : Form
     {
      public List<List<string>> Array { get; set; }

          public EditUser()
          {
               InitializeComponent();
               User c = new User();
               listBox2.Items.Add("Fist Name\t\tLast Name\t\tDepartment ID");
               List<List<string>> Arr  = c.GetUser(c);
               foreach (List<string> ArrInner in Arr) {
                listBox2.Items.Add(ArrInner[1] +"\t\t\t" + ArrInner[2] +"\t\t\t" + ArrInner[3]);
               }
            this.Array=Arr;

          }

          private void EditUserBtn_Click(object sender, EventArgs e)
          {
               User c = new User();
               c.Fname = FnameBox.Text;
               c.Lname = LnameBox.Text;
               //c.DeptID = Int32.Parse(dIDBox.Text);
               //c.Username = UsernameBox.Text;
               //c.Password = PasswordBox.Text;

               c.UserID = int.Parse(Array[listBox2.SelectedIndex-1][0]);
               c.EditUser(c);
               this.Hide();
               OversightScreen FormDepart = new OversightScreen();
               FormDepart.ShowDialog();
          }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LnameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
