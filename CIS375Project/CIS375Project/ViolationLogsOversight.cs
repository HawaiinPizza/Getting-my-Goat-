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
    public partial class ViolationLogsOversight : Form
    {
        public ViolationLogsOversight()
        {
            InitializeComponent();
        }

        private void ViolationLogsOversight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bRAINSDataSet1.Violation_log' table. You can move, or remove it, as needed.
            this.violation_logTableAdapter1.Fill(this.bRAINSDataSet1.Violation_log);
            // TODO: This line of code loads data into the 'bRAINSDataSet.Violation_log' table. You can move, or remove it, as needed.
            this.violation_logTableAdapter.Fill(this.bRAINSDataSet.Violation_log);

        }

        private void AddVioButton_Click(object sender, EventArgs e)
        {
            Violations NewVio = new Violations();

            NewVio.Description = DescriptionAddBox.Text;
            NewVio.DeptID = int.Parse(DeptIDBox.Text);
            if(ViolationRatingBox.SelectedIndex == 0)
            {
                NewVio.Rating = "Major";
            }
            else
            {
                NewVio.Rating = "Minor";
            }
            
            if(StatusBox.SelectedIndex == 0)
            {
                NewVio.Resolved = true;
            }
            else
            {
                NewVio.Resolved = false;
            }
            NewVio.ViolationID = int.Parse(VioIDBox.Text);
            NewVio.Vdate = DateTime.Parse(VioDateBox.Text);

            NewVio.AddV(NewVio);



        }

        private void DeleteVioButton_Click(object sender, EventArgs e)
        {
            Violations VioToDelete = new Violations();

            VioToDelete.ViolationID = int.Parse(listBox2.GetItemText(listBox2.SelectedItem));

            VioToDelete.DeleteVio(VioToDelete);

        }
    }
}
