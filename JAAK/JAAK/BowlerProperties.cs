﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JAAK
{
    public partial class BowlerProperties : Form
    {
        Database DB;

        public BowlerProperties(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
