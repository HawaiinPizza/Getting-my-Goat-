using CIS375Project.classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

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
                    UIUserLoginButton.Text = ("Wrong password.  Try again");
                    break;
                // User is department
                case 1:
                    this.Hide();
                    DepartmentScreen FormDepart = new DepartmentScreen();
                    FormDepart.ShowDialog();
                    //this.Show();
                    //Application.Exit();
                    break;
                // User is oversight
                case 0:
                    this.Hide();
                    OversightScreen FormOver = new OversightScreen();
                    FormOver.ShowDialog();
                    //Application.Exit();
                    break;
                default:
                    UIUserLoginButton.Text = ("A critical bug has happen");
                    break;

            }



        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            Login c = new Login();
            //takes in the user in put and send it to the class functions
            c.Password = PasswordBox.Text;
            c.Username = UserNameBox.Text;
            
            bool good = c.Credentials(c);
            //if the credentials match then it sends to the department choosing
            if (good == true)
            {
                //this gets the department from the login class
                int dept = c.GetDepartment(c);
                LoginUserCheck(dept);
            }
            else
            {
                //sends back that it wasnt correct
                int dept = -1;
                LoginUserCheck(dept);

            }

        }

        private void DBLoginOversight_Click(object sender, EventArgs e)
        {
            this.Hide();
            OversightScreen FormOver = new OversightScreen();
            FormOver.ShowDialog();
            Application.Exit();

        }

        private void DBLoginDpartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartmentScreen FormDepart = new DepartmentScreen();
            FormDepart.ShowDialog();
            Application.Exit();

        }
    }
}
