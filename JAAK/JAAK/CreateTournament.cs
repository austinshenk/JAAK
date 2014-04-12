using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JAAK
{
    public partial class CreateTournament : Form
    {
        Database DB;
        public CreateTournament(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int TID;
            //Checks to ensure the user entered data
            if (nameTxt.Text == "" || directorTxt.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            
            //checks for special characters
            Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
            if (RgxUrl.IsMatch(nameTxt.Text) || RgxUrl.IsMatch(directorTxt.Text))
            {
                MessageBox.Show("No special characters");
                return;
            }
            
            //checks to see if the start and end dates are the same. acceptable, but prompt the user anyway.
            if (startDate.Value.Date.Equals(endDate.Value.Date))
            {
                DialogResult result = MessageBox.Show("The start date and end date are the same, is this a one day tournament?", "Same start and end date", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            TID = DB.GetNewID("Tournament", "TournamentID");
            DB.addTournament(TID.ToString(), nameTxt.Text, startDate.Value.ToShortDateString(), endDate.Value.ToShortDateString(), directorTxt.Text, phoneTxt.Text, addressTxt.Text, cityTxt.Text, stateTxt.Text, zipTxt.Text, null, null, null, null);
            int E1ID = DB.GetNewID("Event", "EventID");
            DB.addEvent(E1ID.ToString(), TID.ToString(), "Singles", "Singles", null, null, null, null, null, null);
            int E2ID = DB.GetNewID("Event", "EventID");
            DB.addEvent(E2ID.ToString(), TID.ToString(), "Doubles", "Doubles", null, null, null, null, null, null);
            int E3ID = DB.GetNewID("Event", "EventID");
            DB.addEvent(E3ID.ToString(), TID.ToString(), "Teams", "Teams", null, null, null, null, null, null);
            DB.addDivision(DB.GetNewID("Division", "DivisionID").ToString(), TID.ToString(), E1ID.ToString(), "Singles", null, null, null, null, null, null, null, null, null, null);
            DB.addDivision(DB.GetNewID("Division", "DivisionID").ToString(), TID.ToString(), E2ID.ToString(), "Doubles", null, null, null, null, null, null, null, null, null, null);
            DB.addDivision(DB.GetNewID("Division", "DivisionID").ToString(), TID.ToString(), E3ID.ToString(), "Teams", null, null, null, null, null, null, null, null, null, null);
            this.Close();

        }


    }
}
