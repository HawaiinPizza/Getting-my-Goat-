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
    public partial class StenerMang : Form
    {
        public StenerMang()
        {
            InitializeComponent();
        }

        private void StenerMang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            OversightScreen FormOver = new OversightScreen();
            FormOver.ShowDialog();
            Application.Exit();
            this.Close();


        }
    }
}
