﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS375Project
{
    public partial class ViolationLogs : Form
    {
        public ViolationLogs()
        {
            InitializeComponent();
        }

        private void ViolationLogs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bRAINSDataSet.Violation_log' table. You can move, or remove it, as needed.
            this.violation_logTableAdapter.Fill(this.bRAINSDataSet.Violation_log);

        }
    }
}
