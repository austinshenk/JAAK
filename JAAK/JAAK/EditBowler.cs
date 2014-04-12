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
    public partial class EditBowler : Form
    {
        Database DB;

        public EditBowler(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
