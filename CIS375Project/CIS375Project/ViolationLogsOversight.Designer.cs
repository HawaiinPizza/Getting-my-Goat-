namespace CIS375Project
{
    partial class ViolationLogsOversight
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
            this.label6 = new System.Windows.Forms.Label();
            this.ViolationRatingBox = new System.Windows.Forms.ListBox();
            this.violationLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bRAINSDataSet = new CIS375Project.BRAINSDataSet();
            this.violationLogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bRAINSDataSet1 = new CIS375Project.BRAINSDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.violation_logTableAdapter = new CIS375Project.BRAINSDataSetTableAdapters.Violation_logTableAdapter();
            this.DescriptionAddBox = new System.Windows.Forms.TextBox();
            this.VioIDBox = new System.Windows.Forms.MaskedTextBox();
            this.VioDateBox = new System.Windows.Forms.MaskedTextBox();
            this.DeptIDBox = new System.Windows.Forms.MaskedTextBox();
            this.AddVioButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ListBox();
            this.RatingBox = new System.Windows.Forms.ListBox();
            this.violationLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.violation_logTableAdapter1 = new CIS375Project.BRAINSDataSet1TableAdapters.Violation_logTableAdapter();
            this.DeleteVioButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rating";
            // 
            // ViolationRatingBox
            // 
            this.ViolationRatingBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "Description", true));
            this.ViolationRatingBox.DataSource = this.violationLogBindingSource2;
            this.ViolationRatingBox.DisplayMember = "rating";
            this.ViolationRatingBox.FormattingEnabled = true;
            this.ViolationRatingBox.ItemHeight = 16;
            this.ViolationRatingBox.Location = new System.Drawing.Point(705, 38);
            this.ViolationRatingBox.Name = "ViolationRatingBox";
            this.ViolationRatingBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ViolationRatingBox.Size = new System.Drawing.Size(69, 244);
            this.ViolationRatingBox.TabIndex = 22;
            this.ViolationRatingBox.ValueMember = "rating";
            // 
            // violationLogBindingSource
            // 
            this.violationLogBindingSource.DataMember = "Violation log";
            this.violationLogBindingSource.DataSource = this.bRAINSDataSet;
            // 
            // bRAINSDataSet
            // 
            this.bRAINSDataSet.DataSetName = "BRAINSDataSet";
            this.bRAINSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // violationLogBindingSource2
            // 
            this.violationLogBindingSource2.DataMember = "Violation log";
            this.violationLogBindingSource2.DataSource = this.bRAINSDataSet1;
            // 
            // bRAINSDataSet1
            // 
            this.bRAINSDataSet1.DataSetName = "BRAINSDataSet1";
            this.bRAINSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Status";
            // 
            // listBox5
            // 
            this.listBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "dept_id", true));
            this.listBox5.DataSource = this.violationLogBindingSource;
            this.listBox5.DisplayMember = "resolved";
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(496, 38);
            this.listBox5.Name = "listBox5";
            this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox5.Size = new System.Drawing.Size(77, 244);
            this.listBox5.TabIndex = 20;
            this.listBox5.ValueMember = "resolved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Department ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Violation Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Violation ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description";
            // 
            // listBox4
            // 
            this.listBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "rating", true));
            this.listBox4.DataSource = this.violationLogBindingSource;
            this.listBox4.DisplayMember = "dept_id";
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(572, 38);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(136, 244);
            this.listBox4.TabIndex = 15;
            this.listBox4.ValueMember = "dept_id";
            // 
            // listBox3
            // 
            this.listBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "resolved", true));
            this.listBox3.DataSource = this.violationLogBindingSource;
            this.listBox3.DisplayMember = "v_date";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(335, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(163, 244);
            this.listBox3.TabIndex = 14;
            this.listBox3.ValueMember = "v_date";
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "v_date", true));
            this.listBox2.DataSource = this.violationLogBindingSource;
            this.listBox2.DisplayMember = "violationID";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(23, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(163, 244);
            this.listBox2.TabIndex = 13;
            this.listBox2.ValueMember = "violationID";
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.violationLogBindingSource, "violationID", true));
            this.listBox1.DataSource = this.violationLogBindingSource;
            this.listBox1.DisplayMember = "Description";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(179, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(160, 244);
            this.listBox1.TabIndex = 12;
            this.listBox1.ValueMember = "Description";
            // 
            // violation_logTableAdapter
            // 
            this.violation_logTableAdapter.ClearBeforeFill = true;
            // 
            // DescriptionAddBox
            // 
            this.DescriptionAddBox.Location = new System.Drawing.Point(23, 412);
            this.DescriptionAddBox.Name = "DescriptionAddBox";
            this.DescriptionAddBox.Size = new System.Drawing.Size(156, 22);
            this.DescriptionAddBox.TabIndex = 24;
            // 
            // VioIDBox
            // 
            this.VioIDBox.Location = new System.Drawing.Point(179, 412);
            this.VioIDBox.Mask = "00";
            this.VioIDBox.Name = "VioIDBox";
            this.VioIDBox.Size = new System.Drawing.Size(160, 22);
            this.VioIDBox.TabIndex = 25;
            this.VioIDBox.ValidatingType = typeof(int);
            // 
            // VioDateBox
            // 
            this.VioDateBox.Location = new System.Drawing.Point(338, 411);
            this.VioDateBox.Mask = "00/00/0000";
            this.VioDateBox.Name = "VioDateBox";
            this.VioDateBox.Size = new System.Drawing.Size(160, 22);
            this.VioDateBox.TabIndex = 26;
            this.VioDateBox.ValidatingType = typeof(System.DateTime);
            // 
            // DeptIDBox
            // 
            this.DeptIDBox.Location = new System.Drawing.Point(572, 412);
            this.DeptIDBox.Mask = "00";
            this.DeptIDBox.Name = "DeptIDBox";
            this.DeptIDBox.Size = new System.Drawing.Size(136, 22);
            this.DeptIDBox.TabIndex = 28;
            this.DeptIDBox.ValidatingType = typeof(int);
            // 
            // AddVioButton
            // 
            this.AddVioButton.Location = new System.Drawing.Point(221, 605);
            this.AddVioButton.Name = "AddVioButton";
            this.AddVioButton.Size = new System.Drawing.Size(160, 84);
            this.AddVioButton.TabIndex = 30;
            this.AddVioButton.Text = "Add Violation";
            this.AddVioButton.UseVisualStyleBackColor = true;
            this.AddVioButton.Click += new System.EventHandler(this.AddVioButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.ItemHeight = 16;
            this.StatusBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.StatusBox.Location = new System.Drawing.Point(496, 412);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(77, 36);
            this.StatusBox.TabIndex = 31;
            // 
            // RatingBox
            // 
            this.RatingBox.FormattingEnabled = true;
            this.RatingBox.ItemHeight = 16;
            this.RatingBox.Items.AddRange(new object[] {
            "Major",
            "Minor"});
            this.RatingBox.Location = new System.Drawing.Point(705, 411);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(69, 36);
            this.RatingBox.TabIndex = 32;
            // 
            // violationLogBindingSource1
            // 
            this.violationLogBindingSource1.DataMember = "Violation log";
            this.violationLogBindingSource1.DataSource = this.bRAINSDataSet;
            // 
            // violation_logTableAdapter1
            // 
            this.violation_logTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteVioButton
            // 
            this.DeleteVioButton.Location = new System.Drawing.Point(437, 605);
            this.DeleteVioButton.Name = "DeleteVioButton";
            this.DeleteVioButton.Size = new System.Drawing.Size(155, 84);
            this.DeleteVioButton.TabIndex = 33;
            this.DeleteVioButton.Text = "Delete Violation";
            this.DeleteVioButton.UseVisualStyleBackColor = true;
            this.DeleteVioButton.Click += new System.EventHandler(this.DeleteVioButton_Click);
            // 
            // ViolationLogsOversight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(823, 716);
            this.Controls.Add(this.DeleteVioButton);
            this.Controls.Add(this.RatingBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.AddVioButton);
            this.Controls.Add(this.DeptIDBox);
            this.Controls.Add(this.VioDateBox);
            this.Controls.Add(this.VioIDBox);
            this.Controls.Add(this.DescriptionAddBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ViolationRatingBox);
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
            this.Name = "ViolationLogsOversight";
            this.Text = "ViolationLogsOversight";
            this.Load += new System.EventHandler(this.ViolationLogsOversight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRAINSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violationLogBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ViolationRatingBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private BRAINSDataSet bRAINSDataSet;
        private System.Windows.Forms.BindingSource violationLogBindingSource;
        private BRAINSDataSetTableAdapters.Violation_logTableAdapter violation_logTableAdapter;
        private System.Windows.Forms.TextBox DescriptionAddBox;
        private System.Windows.Forms.MaskedTextBox VioIDBox;
        private System.Windows.Forms.MaskedTextBox VioDateBox;
        private System.Windows.Forms.MaskedTextBox DeptIDBox;
        private System.Windows.Forms.Button AddVioButton;
        private System.Windows.Forms.ListBox StatusBox;
        private System.Windows.Forms.ListBox RatingBox;
        private System.Windows.Forms.BindingSource violationLogBindingSource1;
        private BRAINSDataSet1 bRAINSDataSet1;
        private System.Windows.Forms.BindingSource violationLogBindingSource2;
        private BRAINSDataSet1TableAdapters.Violation_logTableAdapter violation_logTableAdapter1;
        private System.Windows.Forms.Button DeleteVioButton;
    }
}