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
    public partial class EditCenter : Form
    {
        Database DB;

        public EditCenter(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void EditCenter_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(cmbCenters, "Select * from BowlingCenter", "CenterName", "CenterName");
        }

        private void cmbCenters_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable result = DB.Query("Select * from BowlingCenter where CenterName = '" + cmbCenters.Text.ToString() + "'");
            DataRow row = result.Rows[0];
            txtManager.Text = (string)row["GeneralManager"];
            txtAddress.Text = (string)row["Address"];
            txtPhone.Text = (string)row["PhoneNumber"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbCenters.Text == "" || txtManager.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "" || txtZip.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            DB.updateBowlingCenter(cmbCenters.Text, txtManager.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, txtPhone.Text);
            this.Close();
        }
    }
}
