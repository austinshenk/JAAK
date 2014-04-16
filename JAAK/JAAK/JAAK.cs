using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JAAK
{
    public partial class JAAK : Form
    {
        Database DB = new Database();
        string tid="0";
        string tourney="0";
        string eventid="0";
        string divisionid="0";
        string squadid="0";
        string teamid="0";

        public JAAK()
        {
            InitializeComponent();
        }

        public void loadTournament(string id, string name)
        {
            tabControl1.Visible = false;
            tid = id;
            tourney = name;
            Tournament.Text = tourney;
            lblTournamentName.Text = tourney;
            DataTable result = DB.Query("Select * from Tournament where TournamentID = " + tid);
            DataRow row = result.Rows[0];
            txtDirName.Text = row["DirectorName"].ToString();
            txtDirPN.Text = row["DirectorPhone"].ToString();
            txtDirAdd.Text = row["DirectorAddress"].ToString();
            txtDirCity.Text = row["DirectorCity"].ToString();
            txtDirState.Text = row["DirectorState"].ToString();
            txtDirZip.Text = row["DirectorZip"].ToString();

            if (row["PrizePerDivision"] != null)
            {
                if (row["PrizePerDivision"].ToString() == "True")
                {
                    chkDiff.Checked = true;
                    radPercent.Enabled = false;
                    radPlaces.Enabled = false;
                    txtPercent.Enabled = false;
                    txtPlaces.Enabled = false;
                }
                else if (row["PrizePerDivision"].ToString() == "False")
                {
                    chkDiff.Checked = false;
                    radPercent.Enabled = true;
                    radPlaces.Enabled = true;
                    txtPercent.Enabled = false;
                    txtPlaces.Enabled = false;
                }

                if (row["TopPercentOrNumber"].ToString() == "Percent")
                {
                    radPercent.Checked = true;
                    radPlaces.Checked = false;
                    txtPercent.Enabled = true;
                    txtPlaces.Enabled = false;
                }
                else if (row["TopPercentOrNumber"].ToString() == "Number")
                {
                    radPercent.Checked = false;
                    radPlaces.Checked = true;
                    txtPercent.Enabled = false;
                    txtPlaces.Enabled = true;
                }
                else
                {
                    radPercent.Checked = false;
                    radPlaces.Checked = false;
                    txtPercent.Enabled = false;
                    txtPlaces.Enabled = false;
                }
                txtPercent.Text = row["PercentOfTeams"].ToString();
                txtPlaces.Text = row["NumberOfTeams"].ToString();
            }

            Registration.Controls.Add(new Registration(tid));

            tabControl1.Visible = true;
        }

        public void update()
        {
            if (tabControl1.Visible == false)
            {
                DB.Loadcmb(cmbTourney, "select * from Tournament", "TournamentID", "Name");
            }
            else
            {
                DB.LoadList(eventlist, "select * from Event where TournamentID = " + tid, "EventID", "EventName");
                DB.LoadList(squadList, "select * from Squad where TournamentID = " + tid, "SquadID", "Name");
            }

            Registration.Controls.Clear();
            Registration.Controls.Add(new Registration(tid));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbTourney.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select or create a tournament first");
            }
            else
            {
                loadTournament(cmbTourney.SelectedValue.ToString(), cmbTourney.Text);
                update();
            }
        }

        private void JAAK_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(cmbTourney, "Select * from Tournament", "TournamentID", "Name");
        }
        
        private void MIopentournament_Click(object sender, EventArgs e)
        {
            OpenTournament open = new OpenTournament(DB, this);
            open.ShowDialog();
        }
        
        private void MIclosetournament_Click(object sender, EventArgs e)
        {
            tid = null;
            tourney = null;
            tabControl1.Visible = false;
        }

        private void SquadList_Clicked(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            propertiesPanel.Controls.Clear();
            if (list.SelectedIndex == -1) { return; }

            //Draw Squad Properties
            SquadProperties sp = new SquadProperties(DB);
            sp.Width = propertiesPanel.Width;
            sp.Height = propertiesPanel.Height;
            sp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))); ;
            propertiesPanel.Controls.Add(sp);
        }

        private void TeamList_Clicked(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            propertiesPanel.Controls.Clear();
            if (list.SelectedIndex == -1) { return; }

            //Draw Team Properties
            TeamProperties tp = new TeamProperties(DB);
            tp.Width = propertiesPanel.Width;
            tp.Height = propertiesPanel.Height;
            tp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))); ;
            propertiesPanel.Controls.Add(tp);
        }

        private void removeSquadBtn_Click(object sender, EventArgs e)
        {
            if (squadList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a squad from the list below.", "No Squad Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this squad and all data associated with it?","Delete selected squad",MessageBoxButtons.YesNo);
                if( result == DialogResult.Yes){
                    DB.deleteSquad(squadid);
                    DB.Query("delete from score where SquadID = " + squadid);
                    update();
                }
            }
        }

        private void removeTeamBtn_Click(object sender, EventArgs e)
        {
            if (teamList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a team from the list below.", "No Team Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Delete selected squad
            }
        }

        private void addBowlerBtn_Click(object sender, EventArgs e)
        {
            CreateBowler form = new CreateBowler();
            form.ShowDialog();
        }

        private void removeBowlerBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected bowler?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(result == DialogResult.Yes)
            {

            }
        }

        private void editBowlerBtn_Click(object sender, EventArgs e)
        {
            BowlerProperties form = new BowlerProperties(DB);
            form.ShowDialog();
        }

        private void MInewtournament_Click(object sender, EventArgs e)
        {
            CreateTournament form = new CreateTournament(DB);
            form.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateTournament form = new CreateTournament(DB);
            form.ShowDialog();
        }

        private void MInewbowlingcenter_Click(object sender, EventArgs e)
        {
            CreateBowlingCenter form = new CreateBowlingCenter(DB);
            form.ShowDialog();
        }

        private void MIdeletebowlingcenter_Click(object sender, EventArgs e)
        {
            DeleteCenter form = new DeleteCenter(DB);
            form.ShowDialog();
        }

        private void MIeditbowlingcenter_Click(object sender, EventArgs e)
        {
            EditCenter form = new EditCenter(DB);
            form.ShowDialog();
        }

        private void MInewbowler_Click(object sender, EventArgs e)
        {
            CreateBowler form = new CreateBowler();
            form.ShowDialog();
        }

        private void MIdeletebowler_Click(object sender, EventArgs e)
        {
            DeleteBowler form = new DeleteBowler(DB);
            form.ShowDialog();
        }

        private void MIeditbowler_Click(object sender, EventArgs e)
        {
            EditBowler form = new EditBowler();
            form.ShowDialog();
        }

        private void addSquadBtn_Click(object sender, EventArgs e)
        {
            CreateSquad form = new CreateSquad(DB, tid);
            form.ShowDialog();
            update();
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            if (squadList.SelectedIndex == -1)
            {
                DialogResult result = MessageBox.Show("Would you like to create a new squad?", "No Squad selected", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    addSquadBtn_Click(sender, e);
                }
            }
            else
            {
                DataTable result = DB.Query("Select * from Team");// where TournamentID = " + tid);
                if (result.Rows.Count == 0)
                {
                    DialogResult Dresult = MessageBox.Show("No teams have been registered for this tournament yet, would you like to start registration now?", "No Teams Registered", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (Dresult == DialogResult.Yes)
                    {
                        this.tabControl1.SelectedTab = Registration;
                    }
                }
            }

            update();
        }

        private void tabControl1_VisibleChanged(object sender, EventArgs e)
        {
            update();
        }

        private void eventlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventid = eventlist.SelectedValue.ToString();
            DB.LoadList(divisionlist, "select * from Division where EventID = " + eventid, "DivisionID", "Description");
        }

        private void divisionlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisionid = divisionlist.SelectedValue.ToString();
        }

        private void squadList_SelectedIndexChanged(object sender, EventArgs e)
        {
            squadid = squadList.SelectedValue.ToString();
            DB.LoadList(teamList, "Select * from Team where SquadID = " + squadid, "RegistrationNumber", "Name");
        }

        private void teamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamid = teamList.SelectedValue.ToString();
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            CreateEvent form = new CreateEvent(tid);
            form.ShowDialog();
            update();
        }

        private void addDivisionBtn_Click(object sender, EventArgs e)
        {
            CreateDivision form = new CreateDivision(tid, eventid);
            form.ShowDialog();
            update();
        }

        private void radPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radPercent.Checked == true)
            {
                txtPercent.Enabled = true;
                txtPlaces.Enabled = false;
            }
        }

        private void radPlaces_CheckedChanged(object sender, EventArgs e)
        {
            if (radPlaces.Checked == true)
            {
                txtPercent.Enabled = false;
                txtPlaces.Enabled = true;
            }
        }

        private void chkDiff_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiff.Checked == true)
            {
                radPercent.Enabled = false;
                radPlaces.Enabled = false;
                txtPercent.Enabled = false;
                txtPlaces.Enabled = false;
            }
            if (chkDiff.Checked == false)
            {
                radPercent.Enabled = true;
                radPlaces.Enabled = true;

                if (radPercent.Checked == true) { txtPercent.Enabled = true; txtPlaces.Enabled = false; }
                if (radPlaces.Checked == true) { txtPercent.Enabled = false; txtPlaces.Enabled = true; }
            }
        }

        private void removeEventBtn_Click(object sender, EventArgs e)
        {
            if (eventlist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an event from the list below.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this event and all division, squad, team, and score data associated with it?", "Delete selected event", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //to delete scores associated with this event, we will need squads associated with it
                    DataTable Squads = DB.Query("Select * from Squad where EventID = " + eventid);
                    //now delete all scores from the squads in the DataTable
                    for (int i = 0; i<Squads.Rows.Count; i++)
                    {
                        DataRow row = Squads.Rows[i];
                        string sid = row["SquadID"].ToString();
                        DB.Query("Delete from Score where SquadID = " + sid);
                        //also, go ahead and delete all teams in these squads
                        DB.Query("Delete from Team where SquadID = " + sid);
                    }
                    //delete the squads and divisions associated with this event
                    DB.Query("Delete from Squad where EventID = " + eventid);
                    DB.Query("Delete from Division where EventID = " + eventid);

                    //finally, delete the event
                    DB.deleteEvent(eventid);

                    update();
                }
            }
        }

        private void removeDivisionBtn_Click(object sender, EventArgs e)
        {
            if (divisionlist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a division from the list below.", "No division Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this division and all data associated with it?", "Delete selected division", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //no need to delete teams and scores, but we do need to reassign the teams to divisions after this is deleted.
                    //If no more divisions exsist for this event, one should be created
                    DB.deleteDivision(divisionid);
                    
                    //check to see if any more divisions exsist for the selected event
                    if (!DB.exists("Division", "EventID", eventid))
                    {
                        MessageBox.Show("There are no more divisions for this event, creating a default division.");
                        DB.addDivision(DB.GetNewID("Division", "DivisionID").ToString(), tid, eventid, eventlist.Text, "False", "False", "False", null, null, null, null, null, "80", "210");
                    }

                    update();
                }
            }
        }
    }
}