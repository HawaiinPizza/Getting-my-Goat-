namespace CIS375Project
{
     partial class DeleteUser
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
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Location = new System.Drawing.Point(129, 196);
            this.DeleteUserBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(138, 80);
            this.DeleteUserBtn.TabIndex = 10;
            this.DeleteUserBtn.Text = "Delete User";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(129, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(660, 173);
            this.listBox2.TabIndex = 11;
            this.listBox2.TabStop = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 292);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.DeleteUserBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.ListBox listBox2;
    }
}