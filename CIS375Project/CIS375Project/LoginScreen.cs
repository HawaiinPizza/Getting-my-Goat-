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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

         private void LoginUserCheck(int dept)
        {
               //Check in database function (IDK how the database is going to work, or even what it's going to upload. So I'll pretend it does something ehre.
               int UserStatus = dept; //This would be int UserStatus = Database.UserCheck(user, password);
               if (UserStatus > 1)
               {
                    UserStatus = 0;
               }
            switch (UserStatus)
            {
                // Can't find user in database
                case -1:
                    UserLoginButton.Text=("Wrong password.  Try again");
                    break;
                // User is department
                case 0:
                    this.Hide();
                    DepartmentScreen FormDepart = new DepartmentScreen();
                    FormDepart.ShowDialog();
                    Application.Exit();
                    break;
                // User is oversight
                case 1:
                    this.Hide();
                    OversightScreen FormOver = new OversightScreen();
                    FormOver.ShowDialog();
                    Application.Exit();
                    break;
                default:
                    UserLoginButton.Text=("A critical bug has happen");
                    break;

            }



        } 

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
             string Password = PasswordBox.Text;
            string User = UserNameBox.Text;
            LoginUserCheck(User, Password); 
        }

    }
}
