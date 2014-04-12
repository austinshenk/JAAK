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
    public partial class CreateEvent : Form
    {
        Database DB = new Database();
        String TID;

        public CreateEvent(String tid)
        {
            TID = tid;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int eid = DB.GetNewID("Event","EventID");
            if (cmbDF.SelectedIndex == -1) { DB.addEvent(eid.ToString(), TID, txtName.Text, cmbType.Text, cmbBoD.Text, null, txtLinage.Text, txtExpenses.Text, txtPrize.Text, lblTotal.Text); }
            else { DB.addEvent(eid.ToString(), TID, txtName.Text, cmbType.Text, cmbBoD.Text, cmbDF.SelectedValue.ToString(), txtLinage.Text, txtExpenses.Text, txtPrize.Text, lblTotal.Text); }
            DB.addDivision(DB.GetNewID("Division", "DivisionID").ToString(), TID, eid.ToString(), cmbType.Text, null, null, null, null, null, null, null, null, null, null);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLinage_TextChanged(object sender, EventArgs e)
        {
            decimal linage=0;
            decimal expenses=0;
            decimal prize=0;
            decimal total=0;

            if (decimal.TryParse(txtLinage.Text, out linage) && decimal.TryParse(txtExpenses.Text, out expenses) && decimal.TryParse(txtPrize.Text, out prize))
            {
                total = linage + expenses + prize;
            }

            lblTotal.Text = total.ToString();
        }

        private void txtExpenses_TextChanged(object sender, EventArgs e)
        {
            decimal linage = 0;
            decimal expenses = 0;
            decimal prize = 0;
            decimal total = 0;

            if (decimal.TryParse(txtLinage.Text, out linage) && decimal.TryParse(txtExpenses.Text, out expenses) && decimal.TryParse(txtPrize.Text, out prize))
            {
                total = linage + expenses + prize;
            }

            lblTotal.Text = total.ToString();
        }

        private void txtPrize_TextChanged(object sender, EventArgs e)
        {
            decimal linage = 0;
            decimal expenses = 0;
            decimal prize = 0;
            decimal total = 0;

            if (decimal.TryParse(txtLinage.Text, out linage) && decimal.TryParse(txtExpenses.Text, out expenses) && decimal.TryParse(txtPrize.Text, out prize))
            {
                total = linage + expenses + prize;
            }

            lblTotal.Text = total.ToString();
        }

        private void cmbBoD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoD.Text == "Derived")
            {
                DB.Loadcmb(cmbDF, "Select * from Event where TournamentID = " + TID, "EventID", "EventName");
                cmbDF.Visible = true;
                label4.Visible = true;
            }
            else
            {
                cmbDF.SelectedIndex = -1;
                cmbDF.Visible = false;
                label4.Visible = false;
            }
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
            cmbBoD.SelectedIndex = 0;
        }


    }
}
