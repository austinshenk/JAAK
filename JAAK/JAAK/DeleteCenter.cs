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
    public partial class DeleteCenter : Form
    {
        Database DB;

        public DeleteCenter(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void DeleteCenter_Load(object sender, EventArgs e)
        {
            DB.Loadcmb(cmbCenters, "Select * from BowlingCenter", "CenterName", "CenterName");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCenters.SelectedIndex == -1) { MessageBox.Show("You must select a bowling center to delete"); return; }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected bowling center?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                DB.deleteBowlingCenter(cmbCenters.SelectedValue.ToString());
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
