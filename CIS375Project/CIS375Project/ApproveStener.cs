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
      public List<List<string>> Array { get; set; }
        public ApproveStener()
        {
            InitializeComponent();
            STENER c = new STENER();
            listBox1.Items.Add("Department\tStener");
            List<List<string>> Arr  = c.ViewSS(c);
            foreach (List<string> ArrInner in Arr) {
                listBox1.Items.Add(ArrInner[0] +"\t" + ArrInner[1] );
            }
            this.Array=Arr;
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

            listBox2.Items.Clear();
            Questions form = new Questions();
            List<List<string>> Arr=form.DisplayQandA(form, Int32.Parse(Array[listBox1.SelectedIndex-1][0]));
            foreach(List<string> Str in Arr)
            {
                string STR = "";
                STR += Str[0] + "\t" + Str[1] + "\t" + Str[2] + "\t" + Str[4];
                listBox2.Items.Add(STR);
            }



        }

        private void Approve_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You didn't select anything");
            }
            else
            {
                STENER form = new STENER();
                int Temp = Int32.Parse(this.Array[listBox1.SelectedIndex-1][0]);
                form.Approve(form, Temp, true);
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
                STENER form = new STENER();
                int Temp = Int32.Parse(this.Array[listBox1.SelectedIndex-1][0]);
                MessageBox.Show("This is your temp\t" + Temp);
                form.Approve(form, Temp, false);
            }

        }
    }
}
