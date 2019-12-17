namespace CIS375Project
{
     partial class UserManagement
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
            this.AddUserBox = new System.Windows.Forms.Button();
            this.EditUserBox = new System.Windows.Forms.Button();
            this.DeleteUserBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserBox
            // 
            this.AddUserBox.Location = new System.Drawing.Point(25, 79);
            this.AddUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserBox.Name = "AddUserBox";
            this.AddUserBox.Size = new System.Drawing.Size(147, 103);
            this.AddUserBox.TabIndex = 0;
            this.AddUserBox.Text = "Add User";
            this.AddUserBox.UseVisualStyleBackColor = true;
            this.AddUserBox.Click += new System.EventHandler(this.AddUserBox_Click);
            // 
            // EditUserBox
            // 
            this.EditUserBox.Location = new System.Drawing.Point(199, 79);
            this.EditUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.EditUserBox.Name = "EditUserBox";
            this.EditUserBox.Size = new System.Drawing.Size(147, 103);
            this.EditUserBox.TabIndex = 1;
            this.EditUserBox.Text = "Edit User";
            this.EditUserBox.UseVisualStyleBackColor = true;
            this.EditUserBox.Click += new System.EventHandler(this.EditUserBox_Click);
            // 
            // DeleteUserBox
            // 
            this.DeleteUserBox.Location = new System.Drawing.Point(367, 79);
            this.DeleteUserBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteUserBox.Name = "DeleteUserBox";
            this.DeleteUserBox.Size = new System.Drawing.Size(147, 103);
            this.DeleteUserBox.TabIndex = 2;
            this.DeleteUserBox.Text = "Delete User";
            this.DeleteUserBox.UseVisualStyleBackColor = true;
            this.DeleteUserBox.Click += new System.EventHandler(this.DeleteUserBox_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.DeleteUserBox);
            this.Controls.Add(this.EditUserBox);
            this.Controls.Add(this.AddUserBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button AddUserBox;
          private System.Windows.Forms.Button EditUserBox;
          private System.Windows.Forms.Button DeleteUserBox;
     }
}