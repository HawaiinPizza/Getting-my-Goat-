namespace CIS375Project
{
    partial class OversightScreen
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
            this.UILogout = new System.Windows.Forms.Button();
            this.UIBtnAddSTENER = new System.Windows.Forms.Button();
            this.UIBtnUpdateSTENER = new System.Windows.Forms.Button();
            this.UIBtnApproveSTENER = new System.Windows.Forms.Button();
            this.UIBtnviewViolations = new System.Windows.Forms.Button();
            this.UIBtnUserMangment = new System.Windows.Forms.Button();
            this.AddQBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UILogout
            // 
            this.UILogout.Location = new System.Drawing.Point(524, 12);
            this.UILogout.Name = "UILogout";
            this.UILogout.Size = new System.Drawing.Size(222, 41);
            this.UILogout.TabIndex = 2;
            this.UILogout.Text = "Logout";
            this.UILogout.UseVisualStyleBackColor = true;
            this.UILogout.Click += new System.EventHandler(this.UILogout_Click);
            // 
            // UIBtnAddSTENER
            // 
            this.UIBtnAddSTENER.Location = new System.Drawing.Point(252, 90);
            this.UIBtnAddSTENER.Name = "UIBtnAddSTENER";
            this.UIBtnAddSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnAddSTENER.TabIndex = 4;
            this.UIBtnAddSTENER.Text = "Add STENER";
            this.UIBtnAddSTENER.UseVisualStyleBackColor = true;
            this.UIBtnAddSTENER.Click += new System.EventHandler(this.UIBtnAddSTENER_Click);
            // 
            // UIBtnUpdateSTENER
            // 
            this.UIBtnUpdateSTENER.Location = new System.Drawing.Point(44, 299);
            this.UIBtnUpdateSTENER.Name = "UIBtnUpdateSTENER";
            this.UIBtnUpdateSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnUpdateSTENER.TabIndex = 5;
            this.UIBtnUpdateSTENER.Text = "Update STENER";
            this.UIBtnUpdateSTENER.UseVisualStyleBackColor = true;
            this.UIBtnUpdateSTENER.Click += new System.EventHandler(this.UIBtnUpdateSTENER_Click);
            // 
            // UIBtnApproveSTENER
            // 
            this.UIBtnApproveSTENER.Location = new System.Drawing.Point(446, 90);
            this.UIBtnApproveSTENER.Name = "UIBtnApproveSTENER";
            this.UIBtnApproveSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnApproveSTENER.TabIndex = 7;
            this.UIBtnApproveSTENER.Text = "Approve STENER";
            this.UIBtnApproveSTENER.UseVisualStyleBackColor = true;
            this.UIBtnApproveSTENER.Click += new System.EventHandler(this.UIBtnApproveSTENER_Click);
            // 
            // UIBtnviewViolations
            // 
            this.UIBtnviewViolations.Location = new System.Drawing.Point(446, 299);
            this.UIBtnviewViolations.Name = "UIBtnviewViolations";
            this.UIBtnviewViolations.Size = new System.Drawing.Size(159, 161);
            this.UIBtnviewViolations.TabIndex = 8;
            this.UIBtnviewViolations.Text = "View Violations";
            this.UIBtnviewViolations.UseVisualStyleBackColor = true;
            this.UIBtnviewViolations.Click += new System.EventHandler(this.UIBtnviewViolations_Click);
            // 
            // UIBtnUserMangment
            // 
            this.UIBtnUserMangment.Location = new System.Drawing.Point(639, 90);
            this.UIBtnUserMangment.Name = "UIBtnUserMangment";
            this.UIBtnUserMangment.Size = new System.Drawing.Size(107, 370);
            this.UIBtnUserMangment.TabIndex = 9;
            this.UIBtnUserMangment.Text = "User Mangament";
            this.UIBtnUserMangment.UseVisualStyleBackColor = true;
            this.UIBtnUserMangment.Click += new System.EventHandler(this.UIBtnUserMangment_Click);
            // 
            // AddQBtn
            // 
            this.AddQBtn.Location = new System.Drawing.Point(208, 12);
            this.AddQBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddQBtn.Name = "AddQBtn";
            this.AddQBtn.Size = new System.Drawing.Size(241, 60);
            this.AddQBtn.TabIndex = 10;
            this.AddQBtn.Text = "Add Questions";
            this.AddQBtn.UseVisualStyleBackColor = true;
            this.AddQBtn.Click += new System.EventHandler(this.AddQBtn_Click);
            // 
            // OversightScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 567);
            this.Controls.Add(this.AddQBtn);
            this.Controls.Add(this.UIBtnUserMangment);
            this.Controls.Add(this.UIBtnviewViolations);
            this.Controls.Add(this.UIBtnApproveSTENER);
            this.Controls.Add(this.UIBtnUpdateSTENER);
            this.Controls.Add(this.UIBtnAddSTENER);
            this.Controls.Add(this.UILogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OversightScreen";
            this.Text = "Oversight";
            this.Load += new System.EventHandler(this.OversightScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UILogout;
        private System.Windows.Forms.Button UIBtnAddSTENER;
        private System.Windows.Forms.Button UIBtnUpdateSTENER;
        private System.Windows.Forms.Button UIBtnApproveSTENER;
        private System.Windows.Forms.Button UIBtnviewViolations;
        private System.Windows.Forms.Button UIBtnUserMangment;
          private System.Windows.Forms.Button AddQBtn;
     }
}
