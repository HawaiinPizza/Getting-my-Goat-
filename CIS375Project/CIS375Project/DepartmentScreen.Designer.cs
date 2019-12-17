namespace CIS375Project
{
    partial class DepartmentScreen
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
            this.ButtonViolation = new System.Windows.Forms.Button();
            this.ButtonSTENER = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonViolation
            // 
            this.ButtonViolation.Location = new System.Drawing.Point(16, 166);
            this.ButtonViolation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonViolation.Name = "ButtonViolation";
            this.ButtonViolation.Size = new System.Drawing.Size(232, 215);
            this.ButtonViolation.TabIndex = 0;
            this.ButtonViolation.Text = "Violation Logs";
            this.ButtonViolation.UseVisualStyleBackColor = true;
            this.ButtonViolation.Click += new System.EventHandler(this.ButtonViolation_Click);
            // 
            // ButtonSTENER
            // 
            this.ButtonSTENER.Location = new System.Drawing.Point(807, 166);
            this.ButtonSTENER.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSTENER.Name = "ButtonSTENER";
            this.ButtonSTENER.Size = new System.Drawing.Size(232, 215);
            this.ButtonSTENER.TabIndex = 1;
            this.ButtonSTENER.Text = "Answer/Sumbit STENER";
            this.ButtonSTENER.UseVisualStyleBackColor = true;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Location = new System.Drawing.Point(403, 292);
            this.ButtonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(291, 90);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // DepartmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.ButtonSTENER);
            this.Controls.Add(this.ButtonViolation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DepartmentScreen";
            this.Text = "Department Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonViolation;
        private System.Windows.Forms.Button ButtonSTENER;
        private System.Windows.Forms.Button ButtonLogout;
    }
}