using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace JAAK
{
    public partial class Registration : UserControl
    {
        string tid;
        Database DB = new Database();
        bool check = false;

        public Registration(string TID)
        {
            tid = TID;
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(cmbTeamEvent, "select * from Event where EventType = 'Teams' and TournamentID = " + tid, "EventID", "EventName");
            DB.Loadcmb(cmbDoublesEvent, "select * from Event where EventType = 'Doubles' and TournamentID = " + tid, "EventID", "EventName");
            DB.Loadcmb(cmbSinglesEvent, "select * from Event where EventType = 'Singles' and TournamentID = " + tid, "EventID", "EventName");
            DB.Loadcmb(cmbTeamDivision, "select * from Division where EventID = " + cmbTeamEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbDoublesADivision, "select * from Division where EventID = " + cmbDoublesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbDoublesBDivision, "select * from Division where EventID = " + cmbDoublesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS1D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS2D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS3D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS4D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
        }

        private void cmbTeamEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = DB.querySingle("select BowledOrDerived from Event where EventID = " + cmbTeamEvent.SelectedValue.ToString());
            if (result == "Bowled") { DB.Loadcmb(cmbTeamSquad, "Select * from Squad where EventID = " + cmbTeamEvent.SelectedValue.ToString(), "SquadID", "Name"); }
            else if (result == "Derived")
            {
                txtTeamLane.Enabled = false;
                string derivedfrom = DB.querySingle("Select DerivedFrom from Event where EventID = " + cmbTeamEvent.SelectedValue.ToString());
                DB.Loadcmb(cmbTeamSquad, "Select * from Squad where EventID = " + derivedfrom, "SquadID", "Name");
            }
            DB.Loadcmb(cmbTeamDivision, "select * from Division where EventID = " + cmbTeamEvent.SelectedValue.ToString(), "DivisionID", "Description");
        }
        
        private void cmbDoublesEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = DB.querySingle("select BowledOrDerived from Event where EventID = " + cmbDoublesEvent.SelectedValue.ToString());
            if (result == "Bowled") { DB.Loadcmb(cmbDoublesSquad, "Select * from Squad where EventID = " + cmbDoublesEvent.SelectedValue.ToString(), "SquadID", "Name"); }
            else if (result == "Derived")
            {
                txtDoublesLane.Enabled = false;
                string derivedfrom = DB.querySingle("Select DerivedFrom from Event where EventID = " + cmbDoublesEvent.SelectedValue.ToString());
                DB.Loadcmb(cmbDoublesSquad, "Select * from Squad where EventID = " + derivedfrom, "SquadID", "Name");
            }
            DB.Loadcmb(cmbDoublesADivision, "select * from Division where EventID = " + cmbDoublesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbDoublesBDivision, "select * from Division where EventID = " + cmbDoublesEvent.SelectedValue.ToString(), "DivisionID", "Description");
        }
        
        private void cmbSinglesEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = DB.querySingle("select BowledOrDerived from Event where EventID = " + cmbSinglesEvent.SelectedValue.ToString());
            if (result == "Bowled") { DB.Loadcmb(cmbSinglesSquad, "Select * from Squad where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "SquadID", "Name"); }
            else if (result == "Derived")
            {
                txtSinglesLane.Enabled = false;
                string derivedfrom = DB.querySingle("Select DerivedFrom from Event where EventID = " + cmbSinglesEvent.SelectedValue.ToString());
                DB.Loadcmb(cmbSinglesSquad, "Select * from Squad where EventID = " + derivedfrom, "SquadID", "Name");
            }
            DB.Loadcmb(cmbS1D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS2D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS3D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
            DB.Loadcmb(cmbS4D, "select * from Division where EventID = " + cmbSinglesEvent.SelectedValue.ToString(), "DivisionID", "Description");
        }

        private void btnNewBowler_Click(object sender, EventArgs e)
        {
            CreateBowler form = new CreateBowler();
            form.ShowDialog();
        }

        private void txtTeamB1ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtTeamB1ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtTeamB1ID.Text);
                DataRow row = Name.Rows[0];
                lblTeamB1.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblTeamB1.Text = "Bowler not found"; }
        }

        private void txtTeamB2ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtTeamB2ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtTeamB2ID.Text);
                DataRow row = Name.Rows[0];
                lblTeamB2.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblTeamB2.Text = "Bowler not found"; }
        }

        private void txtTeamB3ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtTeamB3ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtTeamB3ID.Text);
                DataRow row = Name.Rows[0];
                lblTeamB3.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblTeamB3.Text = "Bowler not found"; }
        }

        private void txtTeamB4ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtTeamB4ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtTeamB4ID.Text);
                DataRow row = Name.Rows[0];
                lblTeamB4.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblTeamB4.Text = "Bowler not found"; }
        }

        private void txtDblB1ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtDblB1ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtDblB1ID.Text);
                DataRow row = Name.Rows[0];
                lblDblB1.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblDblB1.Text = "Bowler not found"; }
        }

        private void txtDblB2ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtDblB2ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtDblB2ID.Text);
                DataRow row = Name.Rows[0];
                lblDblB2.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblDblB2.Text = "Bowler not found"; }
        }

        private void txtDblB3ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtDblB3ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtDblB3ID.Text);
                DataRow row = Name.Rows[0];
                lblDblB3.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblDblB3.Text = "Bowler not found"; }
        }

        private void txtDblB4ID_Leave(object sender, EventArgs e)
        {
            if (DB.exists("Bowler", "BowlerID", txtDblB4ID.Text))
            {
                DataTable Name = DB.Query("Select FirstName, MI, LastName from Bowler where BowlerID = " + txtDblB4ID.Text);
                DataRow row = Name.Rows[0];
                lblDblB4.Text = row["FirstName"].ToString() + " " + row["MI"] + " " + row["LastName"];
            }
            else { lblDblB4.Text = "Bowler not found"; }
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (txtName.Text == "" || txtSenate.Text == "" || txtCity.Text == "" || txtState.Text == "" || txtTeamB1ID.Text == "" || txtTeamB2ID.Text == "" || txtTeamB3ID.Text == "" || txtTeamB4ID.Text == "")
                {
                    MessageBox.Show("You must fill out all team information");
                    return;
                }
                Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
                if (RgxUrl.IsMatch(txtName.Text) || RgxUrl.IsMatch(txtSenate.Text) || RgxUrl.IsMatch(txtCity.Text) || RgxUrl.IsMatch(txtState.Text))
                {
                    MessageBox.Show("No special Characters allowed");
                    return;
                }
                if (txtTeamLane.Enabled) { if (!checklane(txtTeamLane.Text, cmbTeamSquad.SelectedValue.ToString())) { return; } }
            }

            string regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();

            DB.addTeam(regnum, tid, cmbTeamSquad.SelectedValue.ToString(), cmbTeamDivision.SelectedValue.ToString(), txtName.Text, "Teams", txtTeamB1ID.Text, txtTeamB2ID.Text, txtTeamB3ID.Text, txtTeamB4ID.Text, txtSenate.Text, txtCity.Text, txtState.Text);

            MessageBox.Show("Team '" + txtName.Text + "' has been created in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbTeamDivision.SelectedValue.ToString()) + " and the registration number is " + regnum);

            
            int hdcpbase;
            int hdcppercent;
            int bowleraverage;
            int bowlerhandicap;
            
            int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbTeamDivision.SelectedValue.ToString()),out hdcpbase);
            int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbTeamDivision.SelectedValue.ToString()),out hdcppercent);

            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtTeamB1ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbTeamSquad.SelectedValue.ToString(), txtTeamB1ID.Text, tid, txtTeamLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            
            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtTeamB2ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbTeamSquad.SelectedValue.ToString(), txtTeamB2ID.Text, tid, txtTeamLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            
            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtTeamB3ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbTeamSquad.SelectedValue.ToString(), txtTeamB3ID.Text, tid, txtTeamLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            
            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtTeamB4ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbTeamSquad.SelectedValue.ToString(), txtTeamB4ID.Text, tid, txtTeamLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
        }

        private void btnDoubles_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (txtSenate.Text == "" || txtCity.Text == "" || txtState.Text == "" || txtDblB1ID.Text == "" || txtDblB2ID.Text == "" || txtDblB3ID.Text == "" || txtDblB4ID.Text == "")
                {
                    MessageBox.Show("You must fill out all team information and doubles bowler ID's");
                    return;
                }
                Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
                if (RgxUrl.IsMatch(txtSenate.Text) || RgxUrl.IsMatch(txtCity.Text) || RgxUrl.IsMatch(txtState.Text))
                {
                    MessageBox.Show("No special Characters allowed");
                    return;
                }

                if (txtDoublesLane.Enabled) { if (!checklane(txtDoublesLane.Text, cmbDoublesSquad.SelectedValue.ToString())) { return; } }
            }

            string regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();

            DB.addTeam(regnum, tid, cmbDoublesSquad.SelectedValue.ToString(), cmbDoublesADivision.SelectedValue.ToString(), lblDblB1.Text + "/" + lblDblB2.Text, "Doubles", txtDblB1ID.Text, txtDblB2ID.Text, null, null, txtSenate.Text, txtCity.Text, txtState.Text);

            MessageBox.Show("Doubles Team " + lblDblB1.Text + "/" + lblDblB2.Text + " has been created in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbDoublesADivision.SelectedValue.ToString()) + " and the registration number is " + regnum);

            regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();
            DB.addTeam(regnum, tid, cmbDoublesSquad.SelectedValue.ToString(), cmbDoublesBDivision.SelectedValue.ToString(), lblDblB3.Text + "/" + lblDblB4.Text, "Doubles", txtDblB3ID.Text, txtDblB4ID.Text, null, null, txtSenate.Text, txtCity.Text, txtState.Text);

            MessageBox.Show("Doubles Team " + lblDblB3.Text + "/" + lblDblB4.Text + " has been created in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbDoublesBDivision.SelectedValue.ToString()) + " and the registration number is " + regnum);

            int hdcpbase;
            int hdcppercent;
            int bowleraverage;
            int bowlerhandicap;

            int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbDoublesADivision.SelectedValue.ToString()), out hdcpbase);
            int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbDoublesADivision.SelectedValue.ToString()), out hdcppercent);

            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB1ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbDoublesSquad.SelectedValue.ToString(), txtDblB1ID.Text, tid, txtDoublesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);

            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB2ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbDoublesSquad.SelectedValue.ToString(), txtDblB3ID.Text, tid, txtDoublesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);

            int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbDoublesBDivision.SelectedValue.ToString()), out hdcpbase);
            int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbDoublesBDivision.SelectedValue.ToString()), out hdcppercent);

            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB3ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbDoublesSquad.SelectedValue.ToString(), txtDblB3ID.Text, tid, txtDoublesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);

            int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB4ID.Text), out bowleraverage);
            bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
            DB.addScore(cmbDoublesSquad.SelectedValue.ToString(), txtDblB4ID.Text, tid, txtDoublesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
        }

        private void btnSingles_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (txtSenate.Text == "" || txtCity.Text == "" || txtState.Text == "")
                {
                    MessageBox.Show("You must fill out all team information");
                    return;
                }
                if (chkB1S.Checked && txtDblB1ID.Text == "") { MessageBox.Show("If bowler 1 is in Singles, you must give Bowler 1's ID"); return; }
                if (chkB2S.Checked && txtDblB2ID.Text == "") { MessageBox.Show("If bowler 2 is in Singles, you must give Bowler 2's ID"); return; }
                if (chkB3S.Checked && txtDblB3ID.Text == "") { MessageBox.Show("If bowler 3 is in Singles, you must give Bowler 3's ID"); return; }
                if (chkB4S.Checked && txtDblB4ID.Text == "") { MessageBox.Show("If bowler 4 is in Singles, you must give Bowler 4's ID"); return; }

                Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
                if (RgxUrl.IsMatch(txtSenate.Text) || RgxUrl.IsMatch(txtCity.Text) || RgxUrl.IsMatch(txtState.Text))
                {
                    MessageBox.Show("No special Characters allowed");
                    return;
                }

                if (txtSinglesLane.Enabled) { if (!checklane(txtSinglesLane.Text, cmbSinglesSquad.SelectedValue.ToString())) { return; } }
            }

            int hdcpbase;
            int hdcppercent;
            int bowleraverage;
            int bowlerhandicap;

            

            string regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();
            if (chkB1S.Checked)
            {
                DB.addTeam(regnum, tid, cmbSinglesSquad.SelectedValue.ToString(), cmbS1D.SelectedValue.ToString(), lblDblB1.Text, "Singles", txtDblB1ID.Text, null, null, null, txtSenate.Text, txtCity.Text, txtState.Text);
                MessageBox.Show(lblDblB1.Text + " has been registered for singles in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbS1D.SelectedValue.ToString()) + " with registration number " + regnum);

                int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbS1D.SelectedValue.ToString()), out hdcpbase);
                int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbS1D.SelectedValue.ToString()), out hdcppercent);

                int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB1ID.Text), out bowleraverage);
                bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
                DB.addScore(cmbSinglesSquad.SelectedValue.ToString(), txtDblB1ID.Text, tid, txtSinglesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            }

            if (chkB2S.Checked)
            {
                regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();
                DB.addTeam(regnum, tid, cmbSinglesSquad.SelectedValue.ToString(), cmbS2D.SelectedValue.ToString(), lblDblB2.Text, "Singles", txtDblB2ID.Text, null, null, null, txtSenate.Text, txtCity.Text, txtState.Text);
                MessageBox.Show(lblDblB2.Text + " has been registered for singles in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbS2D.SelectedValue.ToString()) + " with registration number " + regnum);

                int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbS2D.SelectedValue.ToString()), out hdcpbase);
                int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbS2D.SelectedValue.ToString()), out hdcppercent);

                int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB2ID.Text), out bowleraverage);
                bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
                DB.addScore(cmbSinglesSquad.SelectedValue.ToString(), txtDblB2ID.Text, tid, txtSinglesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            }

            if (chkB3S.Checked)
            {
                regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();
                DB.addTeam(regnum, tid, cmbSinglesSquad.SelectedValue.ToString(), cmbS3D.SelectedValue.ToString(), lblDblB3.Text, "Singles", txtDblB3ID.Text, null, null, null, txtSenate.Text, txtCity.Text, txtState.Text);
                MessageBox.Show(lblDblB3.Text + " has been registered for singles in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbS3D.SelectedValue.ToString()) + " with registration number " + regnum);

                int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbS3D.SelectedValue.ToString()), out hdcpbase);
                int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbS3D.SelectedValue.ToString()), out hdcppercent);

                int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB3ID.Text), out bowleraverage);
                bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
                DB.addScore(cmbSinglesSquad.SelectedValue.ToString(), txtDblB3ID.Text, tid, txtSinglesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            }

            if (chkB4S.Checked)
            {
                regnum = DB.GetNewID("Team", "RegistrationNumber").ToString();
                DB.addTeam(regnum, tid, cmbSinglesSquad.SelectedValue.ToString(), cmbS4D.SelectedValue.ToString(), lblDblB4.Text, "Singles", txtDblB4ID.Text, null, null, null, txtSenate.Text, txtCity.Text, txtState.Text);
                MessageBox.Show(lblDblB4.Text + " has been registered for singles in division " + DB.querySingle("Select Description from Division where DivisionID = " + cmbS4D.SelectedValue.ToString()) + " with registration number " + regnum);

                int.TryParse(DB.querySingle("Select HDCPbase from Division where DivisionID = " + cmbS4D.SelectedValue.ToString()), out hdcpbase);
                int.TryParse(DB.querySingle("Select HDCPpercent from Division where DivisionID = " + cmbS4D.SelectedValue.ToString()), out hdcppercent);

                int.TryParse(DB.querySingle("Select CurrentAvg from Bowler where BowlerID = " + txtDblB4ID.Text), out bowleraverage);
                bowlerhandicap = findhandicap(bowleraverage, hdcpbase, hdcppercent);
                DB.addScore(cmbSinglesSquad.SelectedValue.ToString(), txtDblB4ID.Text, tid, txtSinglesLane.Text, bowleraverage.ToString(), bowlerhandicap.ToString(), null, null, null, null, null);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSenate.Text == "" || txtCity.Text == "" || txtState.Text == "" || txtTeamB1ID.Text == "" || txtTeamB2ID.Text == "" || txtTeamB3ID.Text == "" || txtTeamB4ID.Text == "" || txtDblB1ID.Text == "" || txtDblB2ID.Text == "" || txtDblB3ID.Text == "" || txtDblB4ID.Text == "")
            {
                MessageBox.Show("You must fill out all information");
                return;
            }
            Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
            if (RgxUrl.IsMatch(txtName.Text) || RgxUrl.IsMatch(txtSenate.Text) || RgxUrl.IsMatch(txtCity.Text) || RgxUrl.IsMatch(txtState.Text))
            {
                MessageBox.Show("No special Characters allowed");
                return;
            }

            //if (txtTeamLane.Enabled) { if (!checklane(txtTeamLane.Text, cmbTeamSquad.SelectedValue.ToString())) { return; } }
            //if (txtDoublesLane.Enabled) { if (!checklane(txtDoublesLane.Text, cmbDoublesSquad.SelectedValue.ToString())) { return; } }
            //if (txtSinglesLane.Enabled) { if (!checklane(txtSinglesLane.Text, cmbSinglesSquad.SelectedValue.ToString())) { return; } }

            check = true;

            btnTeam.PerformClick();
            btnDoubles.PerformClick();
            btnSingles.PerformClick();

            check = false;
        }

        private bool checklane(string selLane, string selSquad)
        {
            //check lane availability 
            //get center name the squad takes place at
            string center = DB.querySingle("Select CenterName from Squad where SquadID = " + selSquad);
            //get max lanes at that center
            string sLanes = DB.querySingle("Select Lanes from BowlingCenter where CenterName = '" + center + "'");
            int maxLanes;
            int.TryParse(sLanes, out maxLanes);
            //make sure selected lane is within bounds
            int cLane;
            int.TryParse(selLane, out cLane);

            if (cLane > maxLanes) { MessageBox.Show("The bowling center for this squad only has " + sLanes + ". You cannot pick a lane greater than that."); return false; }
            else if (cLane < 1) { MessageBox.Show("You can't pick a lane that's lower than 1"); return false; }

            //check to see if another team is already on that lane
            DataTable onlane = DB.Query("Select * from score where SquadID = '" + selSquad + "' and LaneNum = '" + selLane);
            if (onlane.Rows.Count >= 4)
            {
                MessageBox.Show("That lane is full"); return false;
            }
            return true;
        }

        private int findhandicap(int average, int b, int percent)
        {
            return (b - average) * percent / 100;
        }
    }
}
