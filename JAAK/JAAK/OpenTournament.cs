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
    public partial class OpenTournament : Form
    {
        Database DB;
        JAAK mainmenu;

        public OpenTournament(Database db, JAAK main)
        {
            DB = db;
            mainmenu = main;
            InitializeComponent();
        }

        private void OpenTournament_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(cmbTourney, "Select * from Tournament", "TournamentID", "Name");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbTourney.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select or create a tournament first");
            }
            else
            {
                mainmenu.changeTournament(cmbTourney.SelectedValue.ToString(), cmbTourney.Text.ToString());
                this.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateTournament form = new CreateTournament(DB);
            form.ShowDialog();
        }
    }
}
