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
    public partial class UpdateStener : Form
    {
     public List<List<string>> Array { get; set; }
        public UpdateStener()
        {
            InitializeComponent();
            STENER c = new STENER();
            listBox1.Items.Add("Department\tStener");
            List<List<string>> Arr  = c.ViewS(c);
            foreach (List<string> ArrInner in Arr) {
                listBox1.Items.Add(ArrInner[0] +"\t" + ArrInner[1] + "\t" + ArrInner[2]);
            }
            this.Array=Arr;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
