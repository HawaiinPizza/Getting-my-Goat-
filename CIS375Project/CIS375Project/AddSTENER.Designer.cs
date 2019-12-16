namespace CIS375Project
{
     partial class AddSTENER
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
               this.d_idBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // d_idBox
               // 
               this.d_idBox.Location = new System.Drawing.Point(133, 47);
               this.d_idBox.Name = "d_idBox";
               this.d_idBox.Size = new System.Drawing.Size(113, 26);
               this.d_idBox.TabIndex = 0;
               this.d_idBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 47);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(115, 20);
               this.label1.TabIndex = 1;
               this.label1.Text = "Department ID\r\n";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(96, 157);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(150, 98);
               this.button1.TabIndex = 2;
               this.button1.Text = "Create STENER";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // AddSTENER
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(374, 285);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.d_idBox);
               this.Name = "AddSTENER";
               this.Text = "AddSTENER";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox d_idBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button button1;
     }
}