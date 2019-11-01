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
            this.OversightLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.Location = new System.Drawing.Point(140, 154);
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.Size = new System.Drawing.Size(148, 95);
            this.UserLoginButton.TabIndex = 0;
            this.UserLoginButton.Text = "Login as User";
            this.UserLoginButton.UseVisualStyleBackColor = true;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // OversightLoginButton
            // 
            this.OversightLoginButton.Location = new System.Drawing.Point(340, 154);
            this.OversightLoginButton.Name = "OversightLoginButton";
            this.OversightLoginButton.Size = new System.Drawing.Size(147, 95);
            this.OversightLoginButton.TabIndex = 1;
            this.OversightLoginButton.Text = "Login as Oversight";
            this.OversightLoginButton.UseVisualStyleBackColor = true;
            this.OversightLoginButton.Click += new System.EventHandler(this.OversightLoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(140, 47);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(148, 22);
            this.UserNameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(140, 95);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(148, 22);
            this.PasswordBox.TabIndex = 5;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 263);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OversightLoginButton);
            this.Controls.Add(this.UserLoginButton);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserLoginButton;
        private System.Windows.Forms.Button OversightLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
    }
}

