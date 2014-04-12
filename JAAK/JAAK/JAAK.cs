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
        string tid;
        string tourney;
        string eventid;
        string divisionid;
        string squadid;
        string teamid;

        public JAAK()
        {
            InitializeComponent();
        }

        public void changeTournament(string id, string name)
        {
            tid = id;
            tourney = name;
            Tournament.Text = tourney;
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
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbTourney.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select or create a tournament first");
            }
            else
            {
                tid = cmbTourney.SelectedValue.ToString();
                tourney = cmbTourney.Text.ToString();
                Tournament.Text = tourney;
                tabControl1.Visible = false;
                tabControl1.Visible = true;
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
                //Delete selected squad
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
            CreateBowler form = new CreateBowler(DB);
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
            CreateBowler form = new CreateBowler(DB);
            form.ShowDialog();
        }

        private void MIdeletebowler_Click(object sender, EventArgs e)
        {
            DeleteBowler form = new DeleteBowler(DB);
            form.ShowDialog();
        }

        private void MIeditbowler_Click(object sender, EventArgs e)
        {
            EditBowler form = new EditBowler(DB);
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
            update();
        }
    }
}