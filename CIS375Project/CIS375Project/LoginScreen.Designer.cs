using CIS375Project.classes;

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
            this.UIUserLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.DBLoginOversight = new System.Windows.Forms.Button();
            this.DBLoginDpartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIUserLoginButton
            // 
            this.UIUserLoginButton.Location = new System.Drawing.Point(105, 125);
            this.UIUserLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.UIUserLoginButton.Name = "UIUserLoginButton";
            this.UIUserLoginButton.Size = new System.Drawing.Size(260, 77);
            this.UIUserLoginButton.TabIndex = 0;
            this.UIUserLoginButton.Text = "Login as User";
            this.UIUserLoginButton.UseVisualStyleBackColor = true;
            this.UIUserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
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
            // DBLoginOversight
            // 
            this.DBLoginOversight.Location = new System.Drawing.Point(234, 11);
            this.DBLoginOversight.Margin = new System.Windows.Forms.Padding(2);
            this.DBLoginOversight.Name = "DBLoginOversight";
            this.DBLoginOversight.Size = new System.Drawing.Size(119, 42);
            this.DBLoginOversight.TabIndex = 6;
            this.DBLoginOversight.Text = "DEBUG Login Oversight";
            this.DBLoginOversight.UseVisualStyleBackColor = true;
            this.DBLoginOversight.Click += new System.EventHandler(this.DBLoginOversight_Click);
            // 
            // DBLoginDpartment
            // 
            this.DBLoginDpartment.Location = new System.Drawing.Point(234, 77);
            this.DBLoginDpartment.Margin = new System.Windows.Forms.Padding(2);
            this.DBLoginDpartment.Name = "DBLoginDpartment";
            this.DBLoginDpartment.Size = new System.Drawing.Size(119, 42);
            this.DBLoginDpartment.TabIndex = 7;
            this.DBLoginDpartment.Text = "DEBUG Login Departmnet";
            this.DBLoginDpartment.UseVisualStyleBackColor = true;
            this.DBLoginDpartment.Click += new System.EventHandler(this.DBLoginDpartment_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 214);
            this.Controls.Add(this.DBLoginDpartment);
            this.Controls.Add(this.DBLoginOversight);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIUserLoginButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UIUserLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button DBLoginOversight;
        private System.Windows.Forms.Button DBLoginDpartment;
    }
}

