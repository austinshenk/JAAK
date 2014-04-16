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
    public partial class CreateBowlingCenter : Form
    {
        Database DB; 

        public CreateBowlingCenter(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtManager.Text == "" || txtAddress.Text == "" || txtCity.Text == "" || txtState.Text == "" || txtZip.Text == "" || txtPhone.Text == "" || txtLanes.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            DB.addBowlingCenter(txtName.Text, txtManager.Text, txtAddress.Text, txtCity.Text, txtState.Text, txtZip.Text, txtPhone.Text, txtLanes.Text);
            this.Close();
        }
    }
}
