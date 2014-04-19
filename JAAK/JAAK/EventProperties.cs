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
    public partial class EventProperties : UserControl
    {
        String eID;
        String tID;

        public EventProperties(String tID,String eID)
        {
            InitializeComponent();
            this.eID = eID;
            this.tID = tID;
            Form_Load();
        }
        public String getElement(String col)
        {
            return "SELECT " + col + " FROM Event WHERE EventID = " + eID;
        }
        public void Form_Load()
        {
            Database db = new Database();
            nameTxt.Text = db.querySingle(getElement("EventName"));
            typeCmbo.SelectedText = db.querySingle(getElement("EventType"));
            derivedCmbo.SelectedText = db.querySingle(getElement("BowledOrDerived"));
            db.Loadcmb(derivedFromCmbo, "SELECT EventName FROM Event WHERE EventID != " + eID, "EventID", "EventName");
            derivedFromCmbo.SelectedText = db.querySingle(getElement("DerivedFrom"));
            txtbLineage.Text = "$"+db.querySingle(getElement("Linage"));
            txtbExpenses.Text = "$" + db.querySingle(getElement("Expenses"));
            txtbPrize.Text = "$" + db.querySingle(getElement("PrizeFund"));
            txtbTPB.Text = "$" + db.querySingle(getElement("TotalPerBowler"));
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.updateEvent(eID, tID, nameTxt.Text, typeCmbo.SelectedText, derivedCmbo.SelectedText,
                derivedFromCmbo.SelectedText, txtbLineage.Text, txtbExpenses.Text, txtbPrize.Text, txtbTPB.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.deleteEvent(eID);
        }

    }
}
