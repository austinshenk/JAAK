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
    public partial class CreateTeam : Form
    {
        Database DB;

        public CreateTeam(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {/*
            //Checks to ensure the user entered data in all fields
            if (tmB1FName.Text == "" || tmB2FName.Text == "" || tmB3FName.Text == "" || tmB4FName.Text == "" ||
                tmB1LName.Text == "" || tmB2LName.Text == "" || tmB3LName.Text == "" || tmB4LName.Text == "" ||
                tmB1Sex.Text == "" || tmB2Sex.Text == "" || tmB3Sex.Text == "" || tmB4Sex.Text == "" ||
                tmB1Address.Text == "" || tmB2Address.Text == "" || tmB3Address.Text == "" || tmB4Address.Text == "" ||
                tmB1Average.Text == "" || tmB2Average.Text == "" || tmB3Average.Text == "" || tmB4Average.Text == "" ||
                tmB1USBC.Text == "" || tmB2USBC.Text == "" || tmB3USBC.Text == "" || tmB4USBC.Text == "" ||
                tmB1TNBA.Text == "" || tmB2TNBA.Text == "" || tmB3TNBA.Text == "" || tmB4TNBA.Text == "" ||
                dblB1FName.Text == "" || dblB2FName.Text == "" || dblB3FName.Text == "" || dblB4FName.Text == "" ||
                dblB1LName.Text == "" || dblB2LName.Text == "" || dblB3LName.Text == "" || dblB4LName.Text == "" ||
                dblB1Sex.Text == "" || dblB2Sex.Text == "" || dblB3Sex.Text == "" || dblB4Sex.Text == "" ||
                dblB1Address.Text == "" || dblB2Address.Text == "" || dblB3Address.Text == "" || dblB4Address.Text == "" ||
                dblB1Average.Text == "" || dblB2Average.Text == "" || dblB3Average.Text == "" || dblB4Average.Text == "" ||
                dblB1USBC.Text == "" || dblB2USBC.Text == "" || dblB3USBC.Text == "" || dblB4USBC.Text == "" ||
                dblB1TNBA.Text == "" || dblB2TNBA.Text == "" || dblB3TNBA.Text == "" || dblB4TNBA.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }

            //checks for special characters
            Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
            if (RgxUrl.IsMatch(tmB1FName.Text) || RgxUrl.IsMatch(tmB2FName.Text) || RgxUrl.IsMatch(tmB3FName.Text) || RgxUrl.IsMatch(tmB4FName.Text) ||
                RgxUrl.IsMatch(tmB1LName.Text) || RgxUrl.IsMatch(tmB2LName.Text) || RgxUrl.IsMatch(tmB3LName.Text) || RgxUrl.IsMatch(tmB4LName.Text) ||
                RgxUrl.IsMatch(tmB1Sex.Text) || RgxUrl.IsMatch(tmB2Sex.Text) || RgxUrl.IsMatch(tmB3Sex.Text) || RgxUrl.IsMatch(tmB4Sex.Text) ||
                RgxUrl.IsMatch(tmB1Address.Text) || RgxUrl.IsMatch(tmB2Address.Text) || RgxUrl.IsMatch(tmB3Address.Text) || RgxUrl.IsMatch(tmB4Address.Text) ||
                RgxUrl.IsMatch(tmB1Average.Text) || RgxUrl.IsMatch(tmB2Average.Text) || RgxUrl.IsMatch(tmB3Average.Text) || RgxUrl.IsMatch(tmB4Average.Text) ||
                RgxUrl.IsMatch(tmB1USBC.Text) || RgxUrl.IsMatch(tmB2USBC.Text) || RgxUrl.IsMatch(tmB3USBC.Text) || RgxUrl.IsMatch(tmB4USBC.Text) ||
                RgxUrl.IsMatch(tmB1TNBA.Text) || RgxUrl.IsMatch(tmB2TNBA.Text) || RgxUrl.IsMatch(tmB3TNBA.Text) || RgxUrl.IsMatch(tmB4TNBA.Text) ||
                RgxUrl.IsMatch(dblB1FName.Text) || RgxUrl.IsMatch(dblB2FName.Text) || RgxUrl.IsMatch(dblB3FName.Text) || RgxUrl.IsMatch(dblB4FName.Text) ||
                RgxUrl.IsMatch(dblB1LName.Text) || RgxUrl.IsMatch(dblB2LName.Text) || RgxUrl.IsMatch(dblB3LName.Text) || RgxUrl.IsMatch(dblB4LName.Text) ||
                RgxUrl.IsMatch(dblB1Sex.Text) || RgxUrl.IsMatch(dblB2Sex.Text) || RgxUrl.IsMatch(dblB3Sex.Text) || RgxUrl.IsMatch(dblB4Sex.Text) ||
                RgxUrl.IsMatch(dblB1Address.Text) || RgxUrl.IsMatch(dblB2Address.Text) || RgxUrl.IsMatch(dblB3Address.Text) || RgxUrl.IsMatch(dblB4Address.Text) ||
                RgxUrl.IsMatch(dblB1Average.Text) || RgxUrl.IsMatch(dblB2Average.Text) || RgxUrl.IsMatch(dblB3Average.Text) || RgxUrl.IsMatch(dblB4Average.Text) ||
                RgxUrl.IsMatch(dblB1USBC.Text) || RgxUrl.IsMatch(dblB2USBC.Text) || RgxUrl.IsMatch(dblB3USBC.Text) || RgxUrl.IsMatch(dblB4USBC.Text) ||
                RgxUrl.IsMatch(dblB1TNBA.Text) || RgxUrl.IsMatch(dblB2TNBA.Text) || RgxUrl.IsMatch(dblB3TNBA.Text) || RgxUrl.IsMatch(dblB4TNBA.Text))
            {
                MessageBox.Show("No special characters");
                return;
            }
            //Get New bowler ID's
            //Check to see if bowlers already exsist
            //Add first names to all bowlers
            //determine what division everyone belongs to

            //Adding team members to database
            DB.addBowler("0", tmB1TNBA.Text, tmB1USBC.Text, tmB1LName.Text, tmB1Average.Text, tmB1Average.Text, senateTxt.Text, "", tmB1Sex.Text);
            DB.addBowler("1", tmB2TNBA.Text, tmB2USBC.Text, tmB2LName.Text, tmB2Average.Text, tmB2Average.Text, senateTxt.Text, "", tmB2Sex.Text);
            DB.addBowler("2", tmB3TNBA.Text, tmB3USBC.Text, tmB3LName.Text, tmB3Average.Text, tmB3Average.Text, senateTxt.Text, "", tmB3Sex.Text);
            DB.addBowler("3", tmB4TNBA.Text, tmB4USBC.Text, tmB4LName.Text, tmB4Average.Text, tmB4Average.Text, senateTxt.Text, "", tmB4Sex.Text);
            //Adding team to database
            DB.addTeam("", "Team", "0", "1", "2", "3", senateTxt.Text, cityTxt.Text); //add state

            if (same1.SelectedIndex == -1 || same1.SelectedIndex == 0)
            {
                DB.addBowler("4", dblB1TNBA.Text, dblB1USBC.Text, dblB1LName.Text, dblB1Average.Text, dblB1Average.Text, senateTxt.Text, "", dblB1Sex.Text);
            }
            if (same2.SelectedIndex == -1 || same2.SelectedIndex == 0)
            {
                DB.addBowler("5", dblB2TNBA.Text, dblB2USBC.Text, dblB2LName.Text, dblB2Average.Text, dblB2Average.Text, senateTxt.Text, "", dblB2Sex.Text);
            }
            if (same3.SelectedIndex == -1 || same3.SelectedIndex == 0)
            {
                DB.addBowler("6", dblB3TNBA.Text, dblB3USBC.Text, dblB3LName.Text, dblB3Average.Text, dblB3Average.Text, senateTxt.Text, "", dblB3Sex.Text);
            }
            if (same1.SelectedIndex == -1 || same1.SelectedIndex == 0)
            {
                DB.addBowler("7", dblB4TNBA.Text, dblB4USBC.Text, dblB4LName.Text, dblB4Average.Text, dblB4Average.Text, senateTxt.Text, "", dblB4Sex.Text);
            }

            DB.addTeam("","Double","4","5",null,null,senateTxt.Text,cityTxt.Text); //add state
            DB.addTeam("", "Double", "6", "7", null, null, senateTxt.Text, cityTxt.Text); //add state
            */
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void same1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (same1.SelectedItem.ToString() == "None")
            {
                //None was selected
            }
            else if (same1.SelectedItem.ToString() == "Bowler #1")
            {
                dblB1FName.Text = tmB1FName.Text;
                dblB1LName.Text = tmB1LName.Text;
                dblB1Sex.Text = tmB1Sex.Text;
                dblB1Address.Text = tmB1Address.Text;
                dblB1Average.Text = tmB1Average.Text;
                dblB1USBC.Text = tmB1USBC.Text;
                dblB1TNBA.Text = tmB1TNBA.Text;
            }
            else if (same1.SelectedItem.ToString() == "Bowler #2")
            {
                dblB1FName.Text = tmB2FName.Text;
                dblB1LName.Text = tmB2LName.Text;
                dblB1Sex.Text = tmB2Sex.Text;
                dblB1Address.Text = tmB2Address.Text;
                dblB1Average.Text = tmB2Average.Text;
                dblB1USBC.Text = tmB2USBC.Text;
                dblB1TNBA.Text = tmB2TNBA.Text;
            }
            else if (same1.SelectedItem.ToString() == "Bowler #3")
            {
                dblB1FName.Text = tmB3FName.Text;
                dblB1LName.Text = tmB3LName.Text;
                dblB1Sex.Text = tmB3Sex.Text;
                dblB1Address.Text = tmB3Address.Text;
                dblB1Average.Text = tmB3Average.Text;
                dblB1USBC.Text = tmB3USBC.Text;
                dblB1TNBA.Text = tmB3TNBA.Text;
            }
            else if (same1.SelectedItem.ToString() == "Bowler #4")
            {
                dblB1FName.Text = tmB4FName.Text;
                dblB1LName.Text = tmB4LName.Text;
                dblB1Sex.Text = tmB4Sex.Text;
                dblB1Address.Text = tmB4Address.Text;
                dblB1Average.Text = tmB4Average.Text;
                dblB1USBC.Text = tmB4USBC.Text;
                dblB1TNBA.Text = tmB4TNBA.Text;
            }
        }

        private void same2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (same2.SelectedItem.ToString() == "None")
            {
                //None was selected
            }
            else if (same2.SelectedItem.ToString() == "Bowler #1")
            {
                dblB2FName.Text = tmB1FName.Text;
                dblB2LName.Text = tmB1LName.Text;
                dblB2Sex.Text = tmB1Sex.Text;
                dblB2Address.Text = tmB1Address.Text;
                dblB2Average.Text = tmB1Average.Text;
                dblB2USBC.Text = tmB1USBC.Text;
                dblB2TNBA.Text = tmB1TNBA.Text;
            }
            else if (same2.SelectedItem.ToString() == "Bowler #2")
            {
                dblB2FName.Text = tmB2FName.Text;
                dblB2LName.Text = tmB2LName.Text;
                dblB2Sex.Text = tmB2Sex.Text;
                dblB2Address.Text = tmB2Address.Text;
                dblB2Average.Text = tmB2Average.Text;
                dblB2USBC.Text = tmB2USBC.Text;
                dblB2TNBA.Text = tmB2TNBA.Text;
            }
            else if (same2.SelectedItem.ToString() == "Bowler #3")
            {
                dblB2FName.Text = tmB3FName.Text;
                dblB2LName.Text = tmB3LName.Text;
                dblB2Sex.Text = tmB3Sex.Text;
                dblB2Address.Text = tmB3Address.Text;
                dblB2Average.Text = tmB3Average.Text;
                dblB2USBC.Text = tmB3USBC.Text;
                dblB2TNBA.Text = tmB3TNBA.Text;
            }
            else if (same2.SelectedItem.ToString() == "Bowler #4")
            {
                dblB2FName.Text = tmB4FName.Text;
                dblB2LName.Text = tmB4LName.Text;
                dblB2Sex.Text = tmB4Sex.Text;
                dblB2Address.Text = tmB4Address.Text;
                dblB2Average.Text = tmB4Average.Text;
                dblB2USBC.Text = tmB4USBC.Text;
                dblB2TNBA.Text = tmB4TNBA.Text;
            }
        }

        private void same3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (same3.SelectedItem.ToString() == "None")
            {
                //None was selected
            }
            else if (same3.SelectedItem.ToString() == "Bowler #1")
            {
                dblB3FName.Text = tmB1FName.Text;
                dblB3LName.Text = tmB1LName.Text;
                dblB3Sex.Text = tmB1Sex.Text;
                dblB3Address.Text = tmB1Address.Text;
                dblB3Average.Text = tmB1Average.Text;
                dblB3USBC.Text = tmB1USBC.Text;
                dblB3TNBA.Text = tmB1TNBA.Text;
            }
            else if (same3.SelectedItem.ToString() == "Bowler #2")
            {
                dblB3FName.Text = tmB2FName.Text;
                dblB3LName.Text = tmB2LName.Text;
                dblB3Sex.Text = tmB2Sex.Text;
                dblB3Address.Text = tmB2Address.Text;
                dblB3Average.Text = tmB2Average.Text;
                dblB3USBC.Text = tmB2USBC.Text;
                dblB3TNBA.Text = tmB2TNBA.Text;
            }
            else if (same3.SelectedItem.ToString() == "Bowler #3")
            {
                dblB3FName.Text = tmB3FName.Text;
                dblB3LName.Text = tmB3LName.Text;
                dblB3Sex.Text = tmB3Sex.Text;
                dblB3Address.Text = tmB3Address.Text;
                dblB3Average.Text = tmB3Average.Text;
                dblB3USBC.Text = tmB3USBC.Text;
                dblB3TNBA.Text = tmB3TNBA.Text;
            }
            else if (same3.SelectedItem.ToString() == "Bowler #4")
            {
                dblB3FName.Text = tmB4FName.Text;
                dblB3LName.Text = tmB4LName.Text;
                dblB3Sex.Text = tmB4Sex.Text;
                dblB3Address.Text = tmB4Address.Text;
                dblB3Average.Text = tmB4Average.Text;
                dblB3USBC.Text = tmB4USBC.Text;
                dblB3TNBA.Text = tmB4TNBA.Text;
            }
        }

        private void same4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (same4.SelectedItem.ToString() == "None")
            {
                //None was selected
            }
            else if (same4.SelectedItem.ToString() == "Bowler #1")
            {
                dblB4FName.Text = tmB1FName.Text;
                dblB4LName.Text = tmB1LName.Text;
                dblB4Sex.Text = tmB1Sex.Text;
                dblB4Address.Text = tmB1Address.Text;
                dblB4Average.Text = tmB1Average.Text;
                dblB4USBC.Text = tmB1USBC.Text;
                dblB4TNBA.Text = tmB1TNBA.Text;
            }
            else if (same4.SelectedItem.ToString() == "Bowler #2")
            {
                dblB4FName.Text = tmB2FName.Text;
                dblB4LName.Text = tmB2LName.Text;
                dblB4Sex.Text = tmB2Sex.Text;
                dblB4Address.Text = tmB2Address.Text;
                dblB4Average.Text = tmB2Average.Text;
                dblB4USBC.Text = tmB2USBC.Text;
                dblB4TNBA.Text = tmB2TNBA.Text;
            }
            else if (same4.SelectedItem.ToString() == "Bowler #3")
            {
                dblB4FName.Text = tmB3FName.Text;
                dblB4LName.Text = tmB3LName.Text;
                dblB4Sex.Text = tmB3Sex.Text;
                dblB4Address.Text = tmB3Address.Text;
                dblB4Average.Text = tmB3Average.Text;
                dblB4USBC.Text = tmB3USBC.Text;
                dblB4TNBA.Text = tmB3TNBA.Text;
            }
            else if (same4.SelectedItem.ToString() == "Bowler #4")
            {
                dblB4FName.Text = tmB4FName.Text;
                dblB4LName.Text = tmB4LName.Text;
                dblB4Sex.Text = tmB4Sex.Text;
                dblB4Address.Text = tmB4Address.Text;
                dblB4Average.Text = tmB4Average.Text;
                dblB4USBC.Text = tmB4USBC.Text;
                dblB4TNBA.Text = tmB4TNBA.Text;
            }
        }
    }
}
