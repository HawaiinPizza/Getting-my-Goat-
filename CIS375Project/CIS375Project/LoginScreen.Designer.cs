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
               this.UserLoginButton = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.UserNameBox = new System.Windows.Forms.TextBox();
               this.PasswordBox = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // UserLoginButton
               // 
               this.UserLoginButton.Location = new System.Drawing.Point(158, 192);
               this.UserLoginButton.Name = "UserLoginButton";
               this.UserLoginButton.Size = new System.Drawing.Size(390, 118);
               this.UserLoginButton.TabIndex = 0;
               this.UserLoginButton.Text = "Login as User";
               this.UserLoginButton.UseVisualStyleBackColor = true;
               this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(14, 66);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(83, 20);
               this.label1.TabIndex = 2;
               this.label1.Text = "Username";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(14, 118);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(78, 20);
               this.label2.TabIndex = 3;
               this.label2.Text = "Password";
               // 
               // UserNameBox
               // 
               this.UserNameBox.Location = new System.Drawing.Point(158, 58);
               this.UserNameBox.Name = "UserNameBox";
               this.UserNameBox.Size = new System.Drawing.Size(166, 26);
               this.UserNameBox.TabIndex = 4;
               this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
               // 
               // PasswordBox
               // 
               this.PasswordBox.Location = new System.Drawing.Point(158, 118);
               this.PasswordBox.Name = "PasswordBox";
               this.PasswordBox.Size = new System.Drawing.Size(166, 26);
               this.PasswordBox.TabIndex = 5;
               // 
               // LoginScreen
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(686, 329);
               this.Controls.Add(this.PasswordBox);
               this.Controls.Add(this.UserNameBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.UserLoginButton);
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

          
    }
}

