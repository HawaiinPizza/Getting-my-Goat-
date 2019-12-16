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
            this.UIBtnRemoveSTENER = new System.Windows.Forms.Button();
            this.UIBtnAddSTENER = new System.Windows.Forms.Button();
            this.UIBtnUpdateSTENER = new System.Windows.Forms.Button();
            this.UIBtnRejectSTENER = new System.Windows.Forms.Button();
            this.UIBtnApproveSTENER = new System.Windows.Forms.Button();
            this.UIBtnviewViolations = new System.Windows.Forms.Button();
            this.UIBtnSTENERMangment = new System.Windows.Forms.Button();
            this.UserMangment = new System.Windows.Forms.Button();
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
            // UIBtnRemoveSTENER
            // 
            this.UIBtnRemoveSTENER.Location = new System.Drawing.Point(44, 90);
            this.UIBtnRemoveSTENER.Name = "UIBtnRemoveSTENER";
            this.UIBtnRemoveSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnRemoveSTENER.TabIndex = 3;
            this.UIBtnRemoveSTENER.Text = "Remove STENER";
            this.UIBtnRemoveSTENER.UseVisualStyleBackColor = true;
            // 
            // UIBtnAddSTENER
            // 
            this.UIBtnAddSTENER.Location = new System.Drawing.Point(252, 90);
            this.UIBtnAddSTENER.Name = "UIBtnAddSTENER";
            this.UIBtnAddSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnAddSTENER.TabIndex = 4;
            this.UIBtnAddSTENER.Text = "Add STENER";
            this.UIBtnAddSTENER.UseVisualStyleBackColor = true;
            // 
            // UIBtnUpdateSTENER
            // 
            this.UIBtnUpdateSTENER.Location = new System.Drawing.Point(44, 299);
            this.UIBtnUpdateSTENER.Name = "UIBtnUpdateSTENER";
            this.UIBtnUpdateSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnUpdateSTENER.TabIndex = 5;
            this.UIBtnUpdateSTENER.Text = "Update STENER";
            this.UIBtnUpdateSTENER.UseVisualStyleBackColor = true;
            // 
            // UIBtnRejectSTENER
            // 
            this.UIBtnRejectSTENER.Location = new System.Drawing.Point(252, 299);
            this.UIBtnRejectSTENER.Name = "UIBtnRejectSTENER";
            this.UIBtnRejectSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnRejectSTENER.TabIndex = 6;
            this.UIBtnRejectSTENER.Text = "Reject STENER";
            this.UIBtnRejectSTENER.UseVisualStyleBackColor = true;
            // 
            // UIBtnApproveSTENER
            // 
            this.UIBtnApproveSTENER.Location = new System.Drawing.Point(446, 90);
            this.UIBtnApproveSTENER.Name = "UIBtnApproveSTENER";
            this.UIBtnApproveSTENER.Size = new System.Drawing.Size(159, 161);
            this.UIBtnApproveSTENER.TabIndex = 7;
            this.UIBtnApproveSTENER.Text = "Approve STENER";
            this.UIBtnApproveSTENER.UseVisualStyleBackColor = true;
            // 
            // UIBtnviewViolations
            // 
            this.UIBtnviewViolations.Location = new System.Drawing.Point(446, 299);
            this.UIBtnviewViolations.Name = "UIBtnviewViolations";
            this.UIBtnviewViolations.Size = new System.Drawing.Size(159, 161);
            this.UIBtnviewViolations.TabIndex = 8;
            this.UIBtnviewViolations.Text = "View Violations";
            this.UIBtnviewViolations.UseVisualStyleBackColor = true;
            // 
            // UIBtnSTENERMangment
            // 
            this.UIBtnSTENERMangment.Location = new System.Drawing.Point(639, 90);
            this.UIBtnSTENERMangment.Name = "UIBtnSTENERMangment";
            this.UIBtnSTENERMangment.Size = new System.Drawing.Size(107, 161);
            this.UIBtnSTENERMangment.TabIndex = 9;
            this.UIBtnSTENERMangment.Text = "STENER Mangment";
            this.UIBtnSTENERMangment.UseVisualStyleBackColor = true;
            this.UIBtnSTENERMangment.Click += new System.EventHandler(this.UIBtnSTENERMangment_Click);
            // 
            // UserMangment
            // 
            this.UserMangment.Location = new System.Drawing.Point(639, 299);
            this.UserMangment.Name = "UserMangment";
            this.UserMangment.Size = new System.Drawing.Size(107, 161);
            this.UserMangment.TabIndex = 10;
            this.UserMangment.Text = "User Mangamnet";
            this.UserMangment.UseVisualStyleBackColor = true;
            // 
            // OversightScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 567);
            this.Controls.Add(this.UserMangment);
            this.Controls.Add(this.UIBtnSTENERMangment);
            this.Controls.Add(this.UIBtnviewViolations);
            this.Controls.Add(this.UIBtnApproveSTENER);
            this.Controls.Add(this.UIBtnRejectSTENER);
            this.Controls.Add(this.UIBtnUpdateSTENER);
            this.Controls.Add(this.UIBtnAddSTENER);
            this.Controls.Add(this.UIBtnRemoveSTENER);
            this.Controls.Add(this.UILogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OversightScreen";
            this.Text = "Oversight";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UILogout;
        private System.Windows.Forms.Button UIBtnRemoveSTENER;
        private System.Windows.Forms.Button UIBtnAddSTENER;
        private System.Windows.Forms.Button UIBtnUpdateSTENER;
        private System.Windows.Forms.Button UIBtnRejectSTENER;
        private System.Windows.Forms.Button UIBtnApproveSTENER;
        private System.Windows.Forms.Button UIBtnviewViolations;
        private System.Windows.Forms.Button UIBtnSTENERMangment;
        private System.Windows.Forms.Button UserMangment;
    }
}