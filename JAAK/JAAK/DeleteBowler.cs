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
    public partial class DeleteBowler : Form
    {
        Database DB;

        public DeleteBowler(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBowlerID.Text == "")
            {
                MessageBox.Show("You must input a bowlerID");
                return;
            }

            DataTable result = DB.Query("Select * from Bowler where BowlerID = " + txtBowlerID.Text);
            int rowcount = result.Rows.Count;
            if (rowcount == 0) { MessageBox.Show("BowlerID " + txtBowlerID.Text + " does not exisit in the database."); return; }
            DataRow row = result.Rows[0];
            DialogResult Dresult = MessageBox.Show("Are you sure you want to delete " + (string)row["Name"], "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (Dresult == DialogResult.Yes)
            {
                DB.deleteBowler(txtBowlerID.Text);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
