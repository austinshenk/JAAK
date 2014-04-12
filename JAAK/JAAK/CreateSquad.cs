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
        string Tid;
        int squadID;

        public CreateSquad(Database db, string id)
        {
            DB = db;
            Tid = id;
            InitializeComponent();
        }
        
        private void CreateSquad_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(centerNameCmbo, "Select CenterName from BowlingCenter", "CenterName", "CenterName");
            DB.Loadcmb(typeCmbo, "Select * from Event where TournamentID = " + Tid, "EventID", "EventName");
            squadID = DB.GetNewID("Squad", "SquadID");
            txtName.Text = "Squad0" + (squadID+1).ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            
            if (centerNameCmbo.Text == "" || typeCmbo.Text == "") { MessageBox.Show("All fields are required"); return; }
            DB.addSquad(squadID.ToString(), Tid,typeCmbo.SelectedValue.ToString(), txtName.Text ,centerNameCmbo.SelectedValue.ToString(), date.Value.ToShortDateString(), time.Value.ToShortTimeString());
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
