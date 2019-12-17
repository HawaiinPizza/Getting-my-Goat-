namespace CIS375Project
{
    partial class ApproveStener
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
            this.components = new System.ComponentModel.Container();
            this.credentialsTableAdapter1 = new CIS375Project.BRAINSDataSetTableAdapters.CredentialsTableAdapter();
            this.questionsTableAdapter1 = new CIS375Project.BRAINSDataSetTableAdapters.QuestionsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bRAINSDataSet = new CIS375Project.BRAINSDataSet();
            this.bRAINSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reject = new System.Windows.Forms.Button();
            this.Approve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // credentialsTableAdapter1
            // 
            this.credentialsTableAdapter1.ClearBeforeFill = true;
            // 
            // questionsTableAdapter1
            // 
            this.questionsTableAdapter1.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(129, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(518, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // bRAINSDataSet
            // 
            this.bRAINSDataSet.DataSetName = "BRAINSDataSet";
            this.bRAINSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bRAINSDataSetBindingSource
            // 
            this.bRAINSDataSetBindingSource.DataSource = this.bRAINSDataSet;
            this.bRAINSDataSetBindingSource.Position = 0;
            // 
            // Reject
            // 
            this.Reject.Location = new System.Drawing.Point(653, 175);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(122, 23);
            this.Reject.TabIndex = 2;
            this.Reject.Text = "Reject Stener";
            this.Reject.UseVisualStyleBackColor = true;
            this.Reject.Click += new System.EventHandler(this.Reject_Click);
            // 
            // Approve
            // 
            this.Approve.Location = new System.Drawing.Point(653, 105);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(122, 23);
            this.Approve.TabIndex = 3;
            this.Approve.Text = "Approve Stener";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // ApproveStener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.listBox1);
            this.Name = "ApproveStener";
            this.Text = "Approve Stener";
            this.Click += new System.EventHandler(this.ApproveStener_Click);
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BRAINSDataSetTableAdapters.CredentialsTableAdapter credentialsTableAdapter1;
        private BRAINSDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter1;
        private System.Windows.Forms.ListBox listBox1;
        private BRAINSDataSet bRAINSDataSet;
        private System.Windows.Forms.BindingSource bRAINSDataSetBindingSource;
        private System.Windows.Forms.Button Reject;
        private System.Windows.Forms.Button Approve;
    }
}