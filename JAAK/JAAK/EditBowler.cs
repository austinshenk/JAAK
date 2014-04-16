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
    public partial class EditBowler : Form
    {
        Database DB = new Database();
        string bid = null;

        public EditBowler()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (bid == null) { MessageBox.Show("You must load a bowler first."); return; }
            if (bid != IDtxt.Text) { MessageBox.Show("You can not change a bowler's ID"); return; }

            if (IDtxt.Text == "" || firstNameTxt.Text == "" || lastNameTxt.Text == "" || tnbaNum.Text == "" || usbcNum.Text == "" || AvgNum.Text == "" || genderCmbo.Text == "" || Senatetxt.Text == "" || Addresstxt.Text == "" || citytxt.Text == "" || statetxt.Text == "" || Ziptxt.Text == "")
            {
                MessageBox.Show("All fields are required except M.I.");
                return;
            }
            Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
            if (RgxUrl.IsMatch(IDtxt.Text) || RgxUrl.IsMatch(firstNameTxt.Text) || RgxUrl.IsMatch(MItxt.Text) || RgxUrl.IsMatch(lastNameTxt.Text) || RgxUrl.IsMatch(tnbaNum.Text) || RgxUrl.IsMatch(usbcNum.Text) || RgxUrl.IsMatch(Senatetxt.Text) || RgxUrl.IsMatch(Addresstxt.Text) || RgxUrl.IsMatch(citytxt.Text) || RgxUrl.IsMatch(statetxt.Text) || RgxUrl.IsMatch(Ziptxt.Text))
            {
                MessageBox.Show("No special characters.");
                return;
            }

            int average;

            if (int.TryParse(AvgNum.Text, out average))
            {
                if (average > 300 || average < 0) { MessageBox.Show("Invalid Average"); return; }
            }
            else { MessageBox.Show("Invalid Average"); return; }

            DB.updateBowler(bid, firstNameTxt.Text, MItxt.Text, lastNameTxt.Text, genderCmbo.Text, Addresstxt.Text, citytxt.Text, statetxt.Text, Ziptxt.Text, tnbaNum.Text, usbcNum.Text, AvgNum.Text, AvgNum.Text, Senatetxt.Text);

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "") { MessageBox.Show("You have to fill out the ID field first"); return; }
            DataTable result = DB.Query("Select * from Bowler where BowlerID = " + IDtxt.Text);
            if (result.Rows.Count == 0) { MessageBox.Show("Bowler ID " + IDtxt.Text + " was not found"); return; }
            DataRow row = result.Rows[0];
            bid = IDtxt.Text;
            firstNameTxt.Text = row["FirstName"].ToString();
            MItxt.Text = row["MI"].ToString();
            lastNameTxt.Text = row["LastName"].ToString();
            tnbaNum.Text = row["TNBANumber"].ToString();
            usbcNum.Text = row["USBCNumber"].ToString();
            AvgNum.Text = row["CurrentAvg"].ToString();
            genderCmbo.Text = row["Gender"].ToString();
            Senatetxt.Text = row["Senate"].ToString();
            Addresstxt.Text = row["Address"].ToString();
            citytxt.Text = row["City"].ToString();
            statetxt.Text = row["State"].ToString();
            Ziptxt.Text = row["zipCode"].ToString();

        }
    }
}
