﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JAAK
{
    public partial class SquadProperties : UserControl
    {
        Database DB;

        public SquadProperties(Database db)
        {
            DB = db;
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Refresh database with new properties
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Delete selected squad
        }
    }
}
