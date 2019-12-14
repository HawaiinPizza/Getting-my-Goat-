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
    public partial class DepartmentScreen : Form
    {
        public DepartmentScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
                    this.Hide();
                    LoginScreen FormDepart = new LoginScreen();
                    FormDepart.ShowDialog();

        }
    }
}
