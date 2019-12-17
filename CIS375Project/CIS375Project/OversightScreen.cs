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
     public partial class OversightScreen : Form
     {
          public OversightScreen()
          {
               InitializeComponent();
          }

          private void UILogout_Click(object sender, EventArgs e)
          {
               this.Hide();
               LoginScreen FormDepart = new LoginScreen();
               FormDepart.ShowDialog();
          }

          private void UIBtnLogout_Click(object sender, EventArgs e)
          {

          }

          private void UIBtnAddSTENER_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddSTENER NewStener = new AddSTENER();
               NewStener.ShowDialog();
          }

          private void UIBtnviewViolations_Click(object sender, EventArgs e)
          {
               this.Hide();
               ViolationLogsOversight VioOversight = new ViolationLogsOversight();
               VioOversight.ShowDialog();
          }

          private void UIBtnUserMangment_Click(object sender, EventArgs e)
          {
               this.Hide();
               UserManagement UserM = new UserManagement();
               UserM.ShowDialog();
          }

          // Open a window to get list of stener,s than either approve or disaprove
          private void UIBtnApproveSTENER_Click(object sender, EventArgs e)
          {
               ApproveStener Form = new ApproveStener();
               Form.Show();

          }

          private void AddQBtn_Click(object sender, EventArgs e)
          {
               this.Hide();
               AddQuestion newQuesiton = new AddQuestion();
               newQuesiton.ShowDialog();
          }
     }
}

