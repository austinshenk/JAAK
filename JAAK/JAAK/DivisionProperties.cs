using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JAAK
{
    public partial class DivisionProperties : UserControl
    {
        String dID;
        String eID;
        String tID;
        public DivisionProperties(String tID, String eID, String dID)
        {
            InitializeComponent();
            this.dID = dID;
            this.eID = eID;
            this.tID = tID;
            Form_Load();
        }
        public String getElement(String col)
        {
            return "SELECT " + col + " FROM Division WHERE DivisionID = " + dID;
        }
        public void Form_Load()
        {
            Database db = new Database();
            nameTxt.Text = db.querySingle(getElement("Description"));
            ageCheckBox.Checked = Convert.ToBoolean(db.querySingle(getElement("UseAge")));
            minAgeNum.Value = Convert.ToInt32(db.querySingle(getElement("MinAge")));
            maxAgeNum.Value = Convert.ToInt32(db.querySingle(getElement("MaxAge")));
            averageCheckBox.Checked = Convert.ToBoolean(db.querySingle(getElement("UseAve")));
            minAverageNum.Value = Convert.ToInt32(db.querySingle(getElement("MinAve")));
            maxAverageNum.Value = Convert.ToInt32(db.querySingle(getElement("MaxAve")));
            sexCheckBox.Checked = Convert.ToBoolean(db.querySingle(getElement("UseSex")));
            sexCmbo.SelectedText = db.querySingle(getElement("Sex"));
            hdcpPercentNum.Value = Convert.ToInt32(db.querySingle(getElement("HDCPpercent")));
            hdcpBaseNum.Value = Convert.ToInt32(db.querySingle(getElement("HDCPbase")));
            ageCheckBox_CheckedChanged(ageCheckBox, null);
            averageCheckBox_CheckedChanged(averageCheckBox, null);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.updateDivision(dID, tID, eID, nameTxt.Text,
                ageCheckBox.Enabled + "", averageCheckBox.Enabled + "", sexCheckBox.Enabled + "",
                minAgeNum.Value + "", maxAgeNum.Value + "", minAverageNum.Value + "", maxAverageNum.Value + "",
                sexCmbo.SelectedText, hdcpPercentNum.Value + "", hdcpBaseNum.Value + "");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.deleteDivision(dID);
        }

        private void ageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Boolean enable = cb.Checked;
            minAgeLbl.Enabled = enable;
            minAgeNum.Enabled = enable;
            maxAgeLbl.Enabled = enable;
            maxAgeNum.Enabled = enable;
        }

        private void averageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Boolean enable = cb.Checked;
            minAveLbl.Enabled = enable;
            minAverageNum.Enabled = enable;
            maxAveLbl.Enabled = enable;
            maxAverageNum.Enabled = enable;
        }

        private void sexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            Boolean enable = cb.Checked;
            sexLbl.Enabled = enable;
            sexCmbo.Enabled = enable;
        }
    }
}
