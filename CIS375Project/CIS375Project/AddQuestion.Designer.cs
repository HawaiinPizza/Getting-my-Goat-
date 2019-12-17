namespace CIS375Project
{
     partial class AddQuestion
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
               this.QuestionBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.sIDBox = new System.Windows.Forms.MaskedTextBox();
               this.AddQBtn = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // QuestionBox
               // 
               this.QuestionBox.Location = new System.Drawing.Point(202, 77);
               this.QuestionBox.Name = "QuestionBox";
               this.QuestionBox.Size = new System.Drawing.Size(118, 26);
               this.QuestionBox.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(123, 80);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(73, 20);
               this.label1.TabIndex = 1;
               this.label1.Text = "Question";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(64, 121);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(132, 20);
               this.label2.TabIndex = 2;
               this.label2.Text = "STENER number";
               // 
               // sIDBox
               // 
               this.sIDBox.Location = new System.Drawing.Point(202, 118);
               this.sIDBox.Name = "sIDBox";
               this.sIDBox.Size = new System.Drawing.Size(100, 26);
               this.sIDBox.TabIndex = 3;
               // 
               // AddQBtn
               // 
               this.AddQBtn.Location = new System.Drawing.Point(190, 196);
               this.AddQBtn.Name = "AddQBtn";
               this.AddQBtn.Size = new System.Drawing.Size(130, 56);
               this.AddQBtn.TabIndex = 4;
               this.AddQBtn.Text = "Add Question";
               this.AddQBtn.UseVisualStyleBackColor = true;
               this.AddQBtn.Click += new System.EventHandler(this.AddQBtn_Click);
               // 
               // AddQuestion
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(601, 300);
               this.Controls.Add(this.AddQBtn);
               this.Controls.Add(this.sIDBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.QuestionBox);
               this.Name = "AddQuestion";
               this.Text = "AddQuestion";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox QuestionBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.MaskedTextBox sIDBox;
          private System.Windows.Forms.Button AddQBtn;
     }
}