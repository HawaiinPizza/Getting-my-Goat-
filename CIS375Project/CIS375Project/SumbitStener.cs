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
            List<List<string>> Arr;
        public SumbitStener()
        {

            InitializeComponent();
            if (UserID.ID == 0)
            {
                UserID.ID = 1;
            }
            Questions form = new Questions();
             Arr=form.DisplayQandADep(form, UserID.ID);
            foreach(List<string> Str in Arr)
            {
                string STR = "";
                STR += Str[0] + "\t" + Str[1] + "\t" + Str[2] + "\t" + Str[4] ;
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
            foreach (List<string> ArrInner in Arr)
            {
                if( ArrInner[1].Length==0 || ArrInner[2].Length==0)
                {
                    MessageBox.Show("You didn't put in a reason and/or answer in one of the quesions");
                    break;
                }

                STENER Muaz = new STENER();
                Muaz.Sumbit(Muaz, UserID.ID);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Data is empty");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length==0  || comboBox1.SelectedIndex==-1  )
            {
                MessageBox.Show("Data is empty");
            }
            else if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("YOu didn't select anythng");
            }
            {
                Questions Temp = new Questions();
                Temp.Answer = comboBox1.Text;
                Temp.Reason = textBox1.Text;
                if (textBox2.Text.Length == 0)
                {
                    Temp.Evidence = "N/A";
                }
                else
                {
                    Temp.Evidence = textBox2.Text;
                }
                Temp.QuestionNum =Int32.Parse(Arr[listBox1.SelectedIndex][5]);
                Temp.InsertAnswer(Temp);
                listBox1.Items.Clear();
            Questions form = new Questions();
             Arr=form.DisplayQandADep(form, UserID.ID);
            foreach(List<string> Str in Arr)
            {
                string STR = "";
                STR += Str[0] + "\t" + Str[1] + "\t" + Str[2] + "\t" + Str[4] ;
                listBox1.Items.Add(STR);
            }
            }

        }
    }
}
