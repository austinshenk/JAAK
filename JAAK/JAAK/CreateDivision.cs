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
    public partial class CreateDivision : Form
    {
        Database DB = new Database();
        string tid;
        string eid;

        public CreateDivision(string TID, string EID)
        {
            tid = TID;
            eid = EID;
            InitializeComponent();
        }

        private void chkAge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAge.Checked)
            {
                lblAgeMax.Visible = true;
                lblAgeMin.Visible = true;
                txtAgeMax.Visible = true;
                txtAgeMin.Visible = true;
            }
            else
            {
                lblAgeMax.Visible = false;
                lblAgeMin.Visible = false;
                txtAgeMax.Visible = false;
                txtAgeMin.Visible = false;
            }
        }

        private void chkAve_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAve.Checked)
            {
                lblAveMax.Visible = true;
                lblAveMin.Visible = true;
                txtAveMax.Visible = true;
                txtAveMin.Visible = true;
            }
            else
            {
                lblAveMax.Visible = false;
                lblAveMin.Visible = false;
                txtAveMax.Visible = false;
                txtAveMin.Visible = false;
            }
        }

        private void chkSex_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSex.Checked)
            {
                lblSex.Visible = true;
                cmbSex.Visible = true;
            }
            else
            {
                lblSex.Visible = false;
                cmbSex.Visible = false;
            }
        }

        private void CreateDivsion_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(cmbEvent, "Select * from Event where TournamentID = " + tid, "EventID", "EventName");
            cmbEvent.SelectedValue = eid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //validate inputs
            if (txtName.Text == "" || txtPercent.Text == "" || txtBase.Text == "") { MessageBox.Show("All fields are required"); return; }
            if (chkAge.Checked) { if (txtAgeMax.Text == "" || txtAgeMin.Text == "") { MessageBox.Show("You must provide maximum and minimum ages"); return; } }
            if (chkAve.Checked) { if (txtAveMax.Text == "" || txtAveMin.Text == "") { MessageBox.Show("You must provide maximum and minimum averages"); return; } }
            if (chkSex.Checked) { if (cmbSex.SelectedIndex==-1) { MessageBox.Show("You must choose a sex"); return; } }

            string DID = DB.GetNewID("Division","DivisionID").ToString();
            DB.addDivision(DID, tid, cmbEvent.SelectedValue.ToString(), txtName.Text, chkAge.Checked.ToString(), chkAve.Checked.ToString(), chkSex.Checked.ToString(), txtAgeMin.Text, txtAgeMax.Text, txtAveMin.Text, txtAveMax.Text, cmbSex.Text, txtPercent.Text, txtBase.Text);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
