<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JAAK
{
    public partial class JAAK : Form
    {
        Database DB = new Database();

        public JAAK()
        {
            InitializeComponent();
        }

        private void TournamentList_Clicked(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            propertiesPanel.Controls.Clear();
            if (list.SelectedIndex == -1) { return; }

            //Draw Tournament Properties
            TournamentProperies tp = new TournamentProperies(DB);
            tp.Width = propertiesPanel.Width;
            tp.Height = propertiesPanel.Height;
            tp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))); ;
            propertiesPanel.Controls.Add(tp);
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

        private void addTournamentBtn_Click(object sender, EventArgs e)
        {
            CreateTournament form = new CreateTournament(DB);
            form.ShowDialog();
        }
        private void removeTournamentBtn_Click(object sender, EventArgs e)
        {
            if (tournamentList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tournament from the list below.", "No Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Delete selected tournament
            }
        }
        private void addSquadBtn_Click(object sender, EventArgs e)
        {
            if (tournamentList.SelectedIndex == -1)
            {
                DialogResult result = MessageBox.Show("Would you like to create a new tournament?", "No Tournament selected", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    addTournamentBtn_Click(sender, e);
                }
            }
            else
            {
                CreateSquad form = new CreateSquad(DB);
                form.ShowDialog();
            }
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
                CreateTeam form = new CreateTeam(DB);
                form.ShowDialog();
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
    }
=======
﻿using System;
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

        public JAAK()
        {
            InitializeComponent();
        }

        private void TournamentList_Clicked(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            propertiesPanel.Controls.Clear();
            if (list.SelectedIndex == -1) { return; }

            //Draw Tournament Properties
            TournamentProperies tp = new TournamentProperies(DB);
            tp.Width = propertiesPanel.Width;
            tp.Height = propertiesPanel.Height;
            tp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right))); ;
            propertiesPanel.Controls.Add(tp);
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

        private void addTournamentBtn_Click(object sender, EventArgs e)
        {
            CreateTournament form = new CreateTournament(DB);
            form.ShowDialog();
        }
        private void removeTournamentBtn_Click(object sender, EventArgs e)
        {
        }
        private void addSquadBtn_Click(object sender, EventArgs e)
        {
            CreateSquad form = new CreateSquad(DB);
            form.ShowDialog();
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
                CreateTeam form = new CreateTeam(DB);
                form.ShowDialog();
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
    }
>>>>>>> 882f8fc345bf59e6a0d32bd5bd1335bb38f44783
}