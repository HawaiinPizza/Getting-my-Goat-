namespace CIS375Project
{
     partial class AddUser
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
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.FnameBox = new System.Windows.Forms.TextBox();
               this.PasswordBox = new System.Windows.Forms.TextBox();
               this.UsernameBox = new System.Windows.Forms.TextBox();
               this.dIDBox = new System.Windows.Forms.TextBox();
               this.LnameBox = new System.Windows.Forms.TextBox();
               this.AddUserBtn = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(164, 39);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(86, 20);
               this.label1.TabIndex = 0;
               this.label1.Text = "First Name";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(164, 97);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(86, 20);
               this.label2.TabIndex = 1;
               this.label2.Text = "Last Name";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(135, 153);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(115, 20);
               this.label3.TabIndex = 2;
               this.label3.Text = "Department ID";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(167, 205);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(83, 20);
               this.label4.TabIndex = 3;
               this.label4.Text = "Username";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(172, 260);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(78, 20);
               this.label5.TabIndex = 4;
               this.label5.Text = "Password";
               // 
               // FnameBox
               // 
               this.FnameBox.Location = new System.Drawing.Point(288, 36);
               this.FnameBox.Name = "FnameBox";
               this.FnameBox.Size = new System.Drawing.Size(113, 26);
               this.FnameBox.TabIndex = 5;
               // 
               // PasswordBox
               // 
               this.PasswordBox.Location = new System.Drawing.Point(288, 257);
               this.PasswordBox.Name = "PasswordBox";
               this.PasswordBox.Size = new System.Drawing.Size(113, 26);
               this.PasswordBox.TabIndex = 6;
               // 
               // UsernameBox
               // 
               this.UsernameBox.Location = new System.Drawing.Point(288, 202);
               this.UsernameBox.Name = "UsernameBox";
               this.UsernameBox.Size = new System.Drawing.Size(113, 26);
               this.UsernameBox.TabIndex = 7;
               // 
               // dIDBox
               // 
               this.dIDBox.Location = new System.Drawing.Point(288, 150);
               this.dIDBox.Name = "dIDBox";
               this.dIDBox.Size = new System.Drawing.Size(113, 26);
               this.dIDBox.TabIndex = 8;
               // 
               // LnameBox
               // 
               this.LnameBox.Location = new System.Drawing.Point(288, 94);
               this.LnameBox.Name = "LnameBox";
               this.LnameBox.Size = new System.Drawing.Size(113, 26);
               this.LnameBox.TabIndex = 9;
               // 
               // AddUserBtn
               // 
               this.AddUserBtn.Location = new System.Drawing.Point(194, 302);
               this.AddUserBtn.Name = "AddUserBtn";
               this.AddUserBtn.Size = new System.Drawing.Size(207, 123);
               this.AddUserBtn.TabIndex = 10;
               this.AddUserBtn.Text = "Add User";
               this.AddUserBtn.UseVisualStyleBackColor = true;
               this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
               // 
               // AddUser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(655, 450);
               this.Controls.Add(this.AddUserBtn);
               this.Controls.Add(this.LnameBox);
               this.Controls.Add(this.dIDBox);
               this.Controls.Add(this.UsernameBox);
               this.Controls.Add(this.PasswordBox);
               this.Controls.Add(this.FnameBox);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "AddUser";
               this.Text = "AddUser";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox FnameBox;
          private System.Windows.Forms.TextBox PasswordBox;
          private System.Windows.Forms.TextBox UsernameBox;
          private System.Windows.Forms.TextBox dIDBox;
          private System.Windows.Forms.TextBox LnameBox;
          private System.Windows.Forms.Button AddUserBtn;
     }
}