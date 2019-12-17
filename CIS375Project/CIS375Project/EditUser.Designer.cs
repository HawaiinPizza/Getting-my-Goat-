namespace CIS375Project
{
     partial class EditUser
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
               this.FnameBox = new System.Windows.Forms.TextBox();
               this.LnameBox = new System.Windows.Forms.TextBox();
               this.EditUserBtn = new System.Windows.Forms.Button();
               this.listBox2 = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(164, 38);
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
               // FnameBox
               // 
               this.FnameBox.Location = new System.Drawing.Point(288, 35);
               this.FnameBox.Name = "FnameBox";
               this.FnameBox.Size = new System.Drawing.Size(114, 26);
               this.FnameBox.TabIndex = 5;
               this.FnameBox.TextChanged += new System.EventHandler(this.FnameBox_TextChanged);
               // 
               // LnameBox
               // 
               this.LnameBox.Location = new System.Drawing.Point(288, 94);
               this.LnameBox.Name = "LnameBox";
               this.LnameBox.Size = new System.Drawing.Size(114, 26);
               this.LnameBox.TabIndex = 9;
               this.LnameBox.TextChanged += new System.EventHandler(this.LnameBox_TextChanged);
               // 
               // EditUserBtn
               // 
               this.EditUserBtn.Location = new System.Drawing.Point(195, 176);
               this.EditUserBtn.Name = "EditUserBtn";
               this.EditUserBtn.Size = new System.Drawing.Size(207, 123);
               this.EditUserBtn.TabIndex = 10;
               this.EditUserBtn.Text = "Edit User";
               this.EditUserBtn.UseVisualStyleBackColor = true;
               this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
               // 
               // listBox2
               // 
               this.listBox2.FormattingEnabled = true;
               this.listBox2.ItemHeight = 20;
               this.listBox2.Location = new System.Drawing.Point(476, 35);
               this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.listBox2.Name = "listBox2";
               this.listBox2.ScrollAlwaysVisible = true;
               this.listBox2.Size = new System.Drawing.Size(706, 264);
               this.listBox2.TabIndex = 11;
               this.listBox2.TabStop = false;
               this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
               // 
               // EditUser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1251, 449);
               this.Controls.Add(this.listBox2);
               this.Controls.Add(this.EditUserBtn);
               this.Controls.Add(this.LnameBox);
               this.Controls.Add(this.FnameBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "EditUser";
               this.Text = "EditUser";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox FnameBox;
          private System.Windows.Forms.TextBox LnameBox;
          private System.Windows.Forms.Button EditUserBtn;
        private System.Windows.Forms.ListBox listBox2;
    }
}