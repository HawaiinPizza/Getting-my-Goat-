namespace CIS375Project
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.DBButtonLoginOversight = new System.Windows.Forms.Button();
            this.DBButtonLoginDepartment = new System.Windows.Forms.Button();
            this.DBButtonLoginWrong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.Location = new System.Drawing.Point(105, 125);
            this.UserLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.Size = new System.Drawing.Size(260, 77);
            this.UserLoginButton.TabIndex = 0;
            this.UserLoginButton.Text = "Login as User";
            this.UserLoginButton.UseVisualStyleBackColor = true;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(105, 38);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(112, 20);
            this.UserNameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(105, 77);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(112, 20);
            this.PasswordBox.TabIndex = 5;
            // 
            // DBButtonLoginOversight
            // 
            this.DBButtonLoginOversight.Location = new System.Drawing.Point(290, 12);
            this.DBButtonLoginOversight.Name = "DBButtonLoginOversight";
            this.DBButtonLoginOversight.Size = new System.Drawing.Size(155, 23);
            this.DBButtonLoginOversight.TabIndex = 6;
            this.DBButtonLoginOversight.Text = "DEBUG Login Oversight";
            this.DBButtonLoginOversight.UseVisualStyleBackColor = true;
            this.DBButtonLoginOversight.Click += new System.EventHandler(this.DBButtonLoginOversight_Click);
            // 
            // DBButtonLoginDepartment
            // 
            this.DBButtonLoginDepartment.Location = new System.Drawing.Point(290, 43);
            this.DBButtonLoginDepartment.Name = "DBButtonLoginDepartment";
            this.DBButtonLoginDepartment.Size = new System.Drawing.Size(155, 23);
            this.DBButtonLoginDepartment.TabIndex = 7;
            this.DBButtonLoginDepartment.Text = "DEBUG Login Department";
            this.DBButtonLoginDepartment.UseVisualStyleBackColor = true;
            this.DBButtonLoginDepartment.Click += new System.EventHandler(this.DBButtonLoginDepartment_Click);
            // 
            // DBButtonLoginWrong
            // 
            this.DBButtonLoginWrong.Location = new System.Drawing.Point(290, 75);
            this.DBButtonLoginWrong.Name = "DBButtonLoginWrong";
            this.DBButtonLoginWrong.Size = new System.Drawing.Size(155, 23);
            this.DBButtonLoginWrong.TabIndex = 8;
            this.DBButtonLoginWrong.Text = "DEBUG Wrong Login";
            this.DBButtonLoginWrong.UseVisualStyleBackColor = true;
            this.DBButtonLoginWrong.Click += new System.EventHandler(this.DBButtonLoginWrong_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 214);
            this.Controls.Add(this.DBButtonLoginWrong);
            this.Controls.Add(this.DBButtonLoginDepartment);
            this.Controls.Add(this.DBButtonLoginOversight);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLoginButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button DBButtonLoginOversight;
        private System.Windows.Forms.Button DBButtonLoginDepartment;
        private System.Windows.Forms.Button DBButtonLoginWrong;
    }
}

