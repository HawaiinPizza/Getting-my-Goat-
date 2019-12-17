using CIS375Project.classes;
using System;
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
    public partial class ApproveStener : Form
    {
        public ApproveStener()
        {
            InitializeComponent();
            STENER c = new STENER();
            listBox1.Items.Add("Department\tStener");
            List<string> Arr  = c.ViewS(c);
            foreach (string Str in Arr) {
                string temp = Str[0] + "\t\t" + Str[1];
                listBox1.Items.Add(temp);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApproveStener_Click(object sender, EventArgs e)
        {

        }

        // Print the questions of a selected STENER
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

            Questions form = new Questions();
            List<string> Arr=form.DisplayQandA(form, listBox1.SelectedIndex);
            string str = "";
            foreach(string Str in Arr)
            {
                str += Str;
            }
            MessageBox.Show(str);



        }

        private void Approve_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You didn't select anything");
            }
            else
            {
                string temp = listBox1.SelectedItem.ToString().Replace("\t", "");
                STENER form = new STENER();
                form.Approve(form, temp[0]-48, true);
            }
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You didn't select anything");
            }
            else
            {
                string temp = listBox1.SelectedItem.ToString().Replace("\t", "");
                MessageBox.Show(temp[0] + "\t" + temp[1] + "\t");
                STENER form = new STENER();
                form.Approve(form, temp[0]-48, false);
            }

        }
    }
}
