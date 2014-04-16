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
    public partial class CreateBowler : Form
    {
        Database DB = new Database();

        public CreateBowler()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTxt.Text == "" || lastNameTxt.Text == "" || tnbaNum.Text == "" || usbcNum.Text == "" || AvgNum.Text == "" || genderCmbo.Text == "" || Senatetxt.Text == "" || Addresstxt.Text == "" || citytxt.Text == "" || statetxt.Text == "" || Ziptxt.Text == "")
            {
                MessageBox.Show("All fields are required except M.I.");
                return;
            }
            Regex RgxUrl = new Regex("[^a-zA-Z0-9 ]");
            if (RgxUrl.IsMatch(firstNameTxt.Text) || RgxUrl.IsMatch(MItxt.Text) || RgxUrl.IsMatch(lastNameTxt.Text) || RgxUrl.IsMatch(tnbaNum.Text) || RgxUrl.IsMatch(usbcNum.Text) || RgxUrl.IsMatch(Senatetxt.Text) || RgxUrl.IsMatch(Addresstxt.Text) || RgxUrl.IsMatch(citytxt.Text) || RgxUrl.IsMatch(statetxt.Text) || RgxUrl.IsMatch(Ziptxt.Text))
            {
                MessageBox.Show("No special characters.");
                return;
            }

            int average;
            
            if(int.TryParse(AvgNum.Text,out average)){
                if(average>300||average<0){MessageBox.Show("Invalid Average"); return;}
            }
            else { MessageBox.Show("Invalid Average"); return; }

            string bid = DB.GetNewID("Bowler", "BowlerID").ToString();

            DB.addBowler(bid,firstNameTxt.Text, MItxt.Text, lastNameTxt.Text, genderCmbo.Text, Addresstxt.Text, citytxt.Text, statetxt.Text, Ziptxt.Text, tnbaNum.Text, usbcNum.Text, AvgNum.Text, AvgNum.Text, Senatetxt.Text);

            MessageBox.Show("This bowler's ID number is " + bid);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
