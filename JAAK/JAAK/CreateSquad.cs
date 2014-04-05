using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JAAK
{
    public partial class CreateSquad : Form
    {
        Database DB;
        public CreateSquad(Database db)
        {
            DB = db;
            InitializeComponent();
        }
        
        private void CreateSquad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jAAKdatabaseDataSet.BowlingCenter' table. You can move, or remove it, as needed.
            this.bowlingCenterTableAdapter.Fill(this.jAAKdatabaseDataSet.BowlingCenter);
            //TODO fill combo box with existing Bowling Center Names
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int squadID = 0;
            int tourneyID = 0; //TODO set to currently selected tournament
            if (centerNameCmbo.Text == "" || typeCmbo.Text == "") { MessageBox.Show("All fields are required"); return; }
            DB.addSquad(squadID.ToString(), tourneyID.ToString(), centerNameCmbo.Text, typeCmbo.Text, date.Value.ToShortDateString(), time.Value.ToShortTimeString());
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
