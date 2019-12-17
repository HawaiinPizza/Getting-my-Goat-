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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void AddUserBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUser AddU = new AddUser();
            AddU.ShowDialog();
        }

        private void EditUserBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUser AddU = new EditUser();
            AddU.ShowDialog();
        }

        private void DeleteUserBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser AddU = new DeleteUser();
            AddU.ShowDialog();

        }
    }
}

