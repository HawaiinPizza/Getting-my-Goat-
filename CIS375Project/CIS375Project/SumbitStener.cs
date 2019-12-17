using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS375Project.classes;

namespace CIS375Project
{
    public partial class SumbitStener : Form
    {
        public SumbitStener()
        {
            InitializeComponent();
            if (UserID.ID == 0)
            {
                UserID.ID = 1;
            }
            Questions form = new Questions();
            List<List<string>> Arr=form.DisplayQandADep(form, UserID.ID);
            foreach(List<string> Str in Arr)
            {
                string STR = "";
                STR += Str[0] + "\t" + Str[1] + "\t" + Str[2] + "\t" + Str[4] ;
                MessageBox.Show(STR);
                listBox1.Items.Add(STR);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
