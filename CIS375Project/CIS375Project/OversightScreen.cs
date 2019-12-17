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

        private void   UIBtnLogout_Click(object sender, EventArgs e)
        {

        }

        private void UIBtnAddSTENER_Click(object sender, EventArgs e)
        {

        }

        private void UIBtnviewViolations_Click(object sender, EventArgs e)
        {

        }
    }
}
