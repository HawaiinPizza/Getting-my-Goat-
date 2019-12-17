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
     public partial class AddSTENER : Form
     {
          public AddSTENER()
          {
               InitializeComponent();
          }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               STENER c = new STENER();
               c.D_id = Int32.Parse(d_idBox.Text);
               c.CreateS(c);
               this.Hide();
               OversightScreen FormDepart = new OversightScreen();
               FormDepart.ShowDialog();
          }
     }
}
