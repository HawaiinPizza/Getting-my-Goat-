namespace CIS375Project
{
    partial class ViolationLogs
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.violationLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRAINSDataSet = new CIS375Project.BRAINSDataSet();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.violation_logTableAdapter = new CIS375Project.BRAINSDataSetTableAdapters.Violation_logTableAdapter();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.violationLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bRAINSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRAINSDataSet1 = new CIS375Project.BRAINSDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.violation_logTableAdapter1 = new CIS375Project.BRAINSDataSet1TableAdapters.Violation_logTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "violationID", true));
            this.listBox1.DataSource = this.violationLogBindingSource;
            this.listBox1.DisplayMember = "Description";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 46);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(121, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Description";
            // 
            // violationLogBindingSource
            // 
            this.violationLogBindingSource.DataMember = "Violation log";
            this.violationLogBindingSource.DataSource = this.bRAINSDataSet;
            this.violationLogBindingSource.CurrentChanged += new System.EventHandler(this.violationLogBindingSource_CurrentChanged);
            // 
            // bRAINSDataSet
            // 
            this.bRAINSDataSet.DataSetName = "BRAINSDataSet";
            this.bRAINSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "v_date", true));
            this.listBox2.DataSource = this.violationLogBindingSource;
            this.listBox2.DisplayMember = "violationID";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(127, 46);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(123, 199);
            this.listBox2.TabIndex = 1;
            this.listBox2.ValueMember = "violationID";
            // 
            // listBox3
            // 
            this.listBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "resolved", true));
            this.listBox3.DataSource = this.violationLogBindingSource;
            this.listBox3.DisplayMember = "v_date";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(246, 46);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(123, 199);
            this.listBox3.TabIndex = 2;
            this.listBox3.ValueMember = "v_date";
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "rating", true));
            this.listBox4.DataSource = this.violationLogBindingSource;
            this.listBox4.DisplayMember = "dept_id";
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(424, 46);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(103, 199);
            this.listBox4.TabIndex = 3;
            this.listBox4.ValueMember = "dept_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Violation ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Violation Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department ID";
            // 
            // violation_logTableAdapter
            // 
            this.violation_logTableAdapter.ClearBeforeFill = true;
            // 
            // listBox5
            // 
            this.listBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "dept_id", true));
            this.listBox5.DataSource = this.violationLogBindingSource;
            this.listBox5.DisplayMember = "resolved";
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(367, 46);
            this.listBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox5.Name = "listBox5";
            this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox5.Size = new System.Drawing.Size(59, 199);
            this.listBox5.TabIndex = 8;
            this.listBox5.ValueMember = "resolved";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status";
            // 
            // listBox6
            // 
            this.listBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "Description", true));
            this.listBox6.DataSource = this.violationLogBindingSource1;
            this.listBox6.DisplayMember = "rating";
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(524, 46);
            this.listBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox6.Name = "listBox6";
            this.listBox6.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox6.Size = new System.Drawing.Size(53, 199);
            this.listBox6.TabIndex = 10;
            this.listBox6.ValueMember = "rating";
            // 
            // violationLogBindingSource1
            // 
            this.violationLogBindingSource1.DataMember = "Violation log";
            this.violationLogBindingSource1.DataSource = this.bRAINSDataSet1BindingSource;
            // 
            // bRAINSDataSet1BindingSource
            // 
            this.bRAINSDataSet1BindingSource.DataSource = this.bRAINSDataSet1;
            this.bRAINSDataSet1BindingSource.Position = 0;
            // 
            // bRAINSDataSet1
            // 
            this.bRAINSDataSet1.DataSetName = "BRAINSDataSet1";
            this.bRAINSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rating";
            // 
            // violation_logTableAdapter1
            // 
            this.violation_logTableAdapter1.ClearBeforeFill = true;
            // 
            // ViolationLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViolationLogs";
            this.Text = "ViolationLogs";
            this.Load += new System.EventHandler(this.ViolationLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private BRAINSDataSet bRAINSDataSet;
        private System.Windows.Forms.BindingSource violationLogBindingSource;
        private BRAINSDataSetTableAdapters.Violation_logTableAdapter violation_logTableAdapter;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bRAINSDataSet1BindingSource;
        private BRAINSDataSet1 bRAINSDataSet1;
        private System.Windows.Forms.BindingSource violationLogBindingSource1;
        private BRAINSDataSet1TableAdapters.Violation_logTableAdapter violation_logTableAdapter1;
    }
}