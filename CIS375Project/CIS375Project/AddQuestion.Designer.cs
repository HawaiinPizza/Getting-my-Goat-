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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(135, 50);
            this.QuestionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(80, 20);
            this.QuestionBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department number";
            // 
            // sIDBox
            // 
            this.sIDBox.Location = new System.Drawing.Point(135, 77);
            this.sIDBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sIDBox.Name = "sIDBox";
            this.sIDBox.Size = new System.Drawing.Size(68, 20);
            this.sIDBox.TabIndex = 3;
            // 
            // AddQBtn
            // 
            this.AddQBtn.Location = new System.Drawing.Point(127, 127);
            this.AddQBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddQBtn.Name = "AddQBtn";
            this.AddQBtn.Size = new System.Drawing.Size(87, 36);
            this.AddQBtn.TabIndex = 4;
            this.AddQBtn.Text = "Add Question";
            this.AddQBtn.UseVisualStyleBackColor = true;
            this.AddQBtn.Click += new System.EventHandler(this.AddQBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1 Human Resource",
            "2 IT ",
            "3 Facilities ",
            "4 Finance"});
            this.listBox1.Location = new System.Drawing.Point(248, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 134);
            this.listBox1.TabIndex = 5;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 280);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddQBtn);
            this.Controls.Add(this.sIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}