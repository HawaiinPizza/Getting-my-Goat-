using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS375Project.classes;

namespace CIS375Project
{
     public partial class AddQuestion : Form
     {
          public AddQuestion()
          {
               InitializeComponent();
          }

          private void AddQBtn_Click(object sender, EventArgs e)
          {
               Questions c = new Questions();
               c.Question = QuestionBox.Text;
               c.S_id = Int32.Parse(sIDBox.Text);
               c.CreateQ(c);

               this.Hide();
               OversightScreen FormDepart = new OversightScreen();
               FormDepart.ShowDialog();

          }
     }
}
