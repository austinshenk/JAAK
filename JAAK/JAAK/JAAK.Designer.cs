<<<<<<< HEAD
﻿namespace JAAK
{
    partial class JAAK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Manager = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeTeamBtn = new System.Windows.Forms.Button();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tournamentList = new System.Windows.Forms.ListBox();
            this.teamList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeTournamentBtn = new System.Windows.Forms.Button();
            this.addTournamentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.squadList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeSquadBtn = new System.Windows.Forms.Button();
            this.addSquadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.Bowlers = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.editBowlerBtn = new System.Windows.Forms.Button();
            this.removeBowlerBtn = new System.Windows.Forms.Button();
            this.addBowlerBtn = new System.Windows.Forms.Button();
            this.bowlerDataGrid = new System.Windows.Forms.DataGridView();
            this.databaseBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Manager.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Bowlers.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bowlerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Manager);
            this.tabControl1.Controls.Add(this.Bowlers);
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 401);
            this.tabControl1.TabIndex = 1;
            // 
            // Manager
            // 
            this.Manager.Controls.Add(this.splitContainer1);
            this.Manager.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager.Location = new System.Drawing.Point(4, 23);
            this.Manager.Margin = new System.Windows.Forms.Padding(0);
            this.Manager.Name = "Manager";
            this.Manager.Padding = new System.Windows.Forms.Padding(3);
            this.Manager.Size = new System.Drawing.Size(778, 374);
            this.Manager.TabIndex = 0;
            this.Manager.Text = "Manager";
            this.Manager.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.propertiesPanel);
            this.splitContainer1.Size = new System.Drawing.Size(772, 368);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tournamentList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.teamList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.squadList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.removeTeamBtn);
            this.panel3.Controls.Add(this.addTeamBtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(258, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 40);
            this.panel3.TabIndex = 12;
            // 
            // removeTeamBtn
            // 
            this.removeTeamBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.removeTeamBtn.Location = new System.Drawing.Point(32, 17);
            this.removeTeamBtn.Name = "removeTeamBtn";
            this.removeTeamBtn.Size = new System.Drawing.Size(20, 20);
            this.removeTeamBtn.TabIndex = 2;
            this.removeTeamBtn.Text = "-";
            this.removeTeamBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeTeamBtn.UseVisualStyleBackColor = true;
            this.removeTeamBtn.Click += new System.EventHandler(this.removeTeamBtn_Click);
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addTeamBtn.Location = new System.Drawing.Point(6, 17);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(20, 20);
            this.addTeamBtn.TabIndex = 1;
            this.addTeamBtn.Text = "+";
            this.addTeamBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTeamBtn.UseVisualStyleBackColor = true;
            this.addTeamBtn.Click += new System.EventHandler(this.addTeamBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Team";
            // 
            // tournamentList
            // 
            this.tournamentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tournamentList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentList.FormattingEnabled = true;
            this.tournamentList.ItemHeight = 16;
            this.tournamentList.Items.AddRange(new object[] {
            "Saturday Tourney",
            "Battle at Bowling"});
            this.tournamentList.Location = new System.Drawing.Point(0, 40);
            this.tournamentList.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tournamentList.Name = "tournamentList";
            this.tournamentList.Size = new System.Drawing.Size(126, 328);
            this.tournamentList.TabIndex = 7;
            this.tournamentList.Click += new System.EventHandler(this.TournamentList_Clicked);
            // 
            // teamList
            // 
            this.teamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 16;
            this.teamList.Items.AddRange(new object[] {
            "Team1",
            "Team2",
            "Team3",
            "Team4",
            "Team5",
            "Team6"});
            this.teamList.Location = new System.Drawing.Point(258, 40);
            this.teamList.Margin = new System.Windows.Forms.Padding(0);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(130, 328);
            this.teamList.TabIndex = 11;
            this.teamList.Click += new System.EventHandler(this.TeamList_Clicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.removeTournamentBtn);
            this.panel1.Controls.Add(this.addTournamentBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 40);
            this.panel1.TabIndex = 8;
            // 
            // removeTournamentBtn
            // 
            this.removeTournamentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.removeTournamentBtn.Location = new System.Drawing.Point(32, 17);
            this.removeTournamentBtn.Name = "removeTournamentBtn";
            this.removeTournamentBtn.Size = new System.Drawing.Size(20, 20);
            this.removeTournamentBtn.TabIndex = 2;
            this.removeTournamentBtn.Text = "-";
            this.removeTournamentBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeTournamentBtn.UseVisualStyleBackColor = true;
            this.removeTournamentBtn.Click += new System.EventHandler(this.removeTournamentBtn_Click);
            // 
            // addTournamentBtn
            // 
            this.addTournamentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addTournamentBtn.Location = new System.Drawing.Point(6, 17);
            this.addTournamentBtn.Name = "addTournamentBtn";
            this.addTournamentBtn.Size = new System.Drawing.Size(20, 20);
            this.addTournamentBtn.TabIndex = 1;
            this.addTournamentBtn.Text = "+";
            this.addTournamentBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTournamentBtn.UseVisualStyleBackColor = true;
            this.addTournamentBtn.Click += new System.EventHandler(this.addTournamentBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament";
            // 
            // squadList
            // 
            this.squadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squadList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squadList.FormattingEnabled = true;
            this.squadList.ItemHeight = 16;
            this.squadList.Items.AddRange(new object[] {
            "Squad1",
            "Squad2",
            "Squad3",
            "Squad4"});
            this.squadList.Location = new System.Drawing.Point(129, 40);
            this.squadList.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.squadList.Name = "squadList";
            this.squadList.Size = new System.Drawing.Size(126, 328);
            this.squadList.TabIndex = 9;
            this.squadList.Click += new System.EventHandler(this.SquadList_Clicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.removeSquadBtn);
            this.panel2.Controls.Add(this.addSquadBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(129, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 40);
            this.panel2.TabIndex = 10;
            // 
            // removeSquadBtn
            // 
            this.removeSquadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSquadBtn.Location = new System.Drawing.Point(32, 17);
            this.removeSquadBtn.Name = "removeSquadBtn";
            this.removeSquadBtn.Size = new System.Drawing.Size(20, 20);
            this.removeSquadBtn.TabIndex = 2;
            this.removeSquadBtn.Text = "-";
            this.removeSquadBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeSquadBtn.UseVisualStyleBackColor = true;
            this.removeSquadBtn.Click += new System.EventHandler(this.removeSquadBtn_Click);
            // 
            // addSquadBtn
            // 
            this.addSquadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addSquadBtn.Location = new System.Drawing.Point(6, 17);
            this.addSquadBtn.Name = "addSquadBtn";
            this.addSquadBtn.Size = new System.Drawing.Size(20, 20);
            this.addSquadBtn.TabIndex = 1;
            this.addSquadBtn.Text = "+";
            this.addSquadBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addSquadBtn.UseVisualStyleBackColor = true;
            this.addSquadBtn.Click += new System.EventHandler(this.addSquadBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Squad";
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.BackColor = System.Drawing.Color.Transparent;
            this.propertiesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(376, 368);
            this.propertiesPanel.TabIndex = 13;
            // 
            // Bowlers
            // 
            this.Bowlers.Controls.Add(this.panel5);
            this.Bowlers.Controls.Add(this.bowlerDataGrid);
            this.Bowlers.Location = new System.Drawing.Point(4, 23);
            this.Bowlers.Name = "Bowlers";
            this.Bowlers.Padding = new System.Windows.Forms.Padding(3);
            this.Bowlers.Size = new System.Drawing.Size(778, 374);
            this.Bowlers.TabIndex = 1;
            this.Bowlers.Text = "Bowlers";
            this.Bowlers.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.editBowlerBtn);
            this.panel5.Controls.Add(this.removeBowlerBtn);
            this.panel5.Controls.Add(this.addBowlerBtn);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(780, 40);
            this.panel5.TabIndex = 1;
            // 
            // editBowlerBtn
            // 
            this.editBowlerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editBowlerBtn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBowlerBtn.Location = new System.Drawing.Point(132, 3);
            this.editBowlerBtn.Name = "editBowlerBtn";
            this.editBowlerBtn.Size = new System.Drawing.Size(122, 34);
            this.editBowlerBtn.TabIndex = 2;
            this.editBowlerBtn.Text = "Edit";
            this.editBowlerBtn.UseVisualStyleBackColor = true;
            this.editBowlerBtn.Click += new System.EventHandler(this.editBowlerBtn_Click);
            // 
            // removeBowlerBtn
            // 
            this.removeBowlerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBowlerBtn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBowlerBtn.Location = new System.Drawing.Point(655, 3);
            this.removeBowlerBtn.Name = "removeBowlerBtn";
            this.removeBowlerBtn.Size = new System.Drawing.Size(122, 34);
            this.removeBowlerBtn.TabIndex = 1;
            this.removeBowlerBtn.Text = "Delete";
            this.removeBowlerBtn.UseVisualStyleBackColor = true;
            this.removeBowlerBtn.Click += new System.EventHandler(this.removeBowlerBtn_Click);
            // 
            // addBowlerBtn
            // 
            this.addBowlerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addBowlerBtn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBowlerBtn.Location = new System.Drawing.Point(3, 3);
            this.addBowlerBtn.Name = "addBowlerBtn";
            this.addBowlerBtn.Size = new System.Drawing.Size(122, 34);
            this.addBowlerBtn.TabIndex = 0;
            this.addBowlerBtn.Text = "Register";
            this.addBowlerBtn.UseVisualStyleBackColor = true;
            this.addBowlerBtn.Click += new System.EventHandler(this.addBowlerBtn_Click);
            // 
            // bowlerDataGrid
            // 
            this.bowlerDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bowlerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bowlerDataGrid.Location = new System.Drawing.Point(0, 40);
            this.bowlerDataGrid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.bowlerDataGrid.Name = "bowlerDataGrid";
            this.bowlerDataGrid.Size = new System.Drawing.Size(780, 371);
            this.bowlerDataGrid.TabIndex = 0;
            // 
            // databaseBtn
            // 
            this.databaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseBtn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseBtn.Location = new System.Drawing.Point(707, 3);
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(75, 23);
            this.databaseBtn.TabIndex = 2;
            this.databaseBtn.Text = "Database";
            this.databaseBtn.UseVisualStyleBackColor = true;
            // 
            // JAAK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.databaseBtn);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JAAK";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Text = "JAAK";
            this.tabControl1.ResumeLayout(false);
            this.Manager.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Bowlers.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bowlerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Bowlers;
        private System.Windows.Forms.Button databaseBtn;
        private System.Windows.Forms.TabPage Manager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeTournamentBtn;
        private System.Windows.Forms.Button addTournamentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button removeTeamBtn;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox tournamentList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeSquadBtn;
        private System.Windows.Forms.Button addSquadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox squadList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView bowlerDataGrid;
        private System.Windows.Forms.Button removeBowlerBtn;
        private System.Windows.Forms.Button addBowlerBtn;
        private System.Windows.Forms.ListBox teamList;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button editBowlerBtn;
    }
}

=======
﻿namespace JAAK
{
    partial class JAAK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Squads = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeTeamBtn = new System.Windows.Forms.Button();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teamList = new System.Windows.Forms.ListBox();
            this.squadList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeSquadBtn = new System.Windows.Forms.Button();
            this.addSquadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.propertiesPanel = new System.Windows.Forms.Panel();
            this.Scoring = new System.Windows.Forms.TabPage();
            this.Winners = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bowlersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bowlingCentersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Events = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeDivisionBtn = new System.Windows.Forms.Button();
            this.addDivisionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.removeEventBtn = new System.Windows.Forms.Button();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.Squads.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Events.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Events);
            this.tabControl1.Controls.Add(this.Squads);
            this.tabControl1.Controls.Add(this.Scoring);
            this.tabControl1.Controls.Add(this.Winners);
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 386);
            this.tabControl1.TabIndex = 1;
            // 
            // Squads
            // 
            this.Squads.Controls.Add(this.splitContainer1);
            this.Squads.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Squads.Location = new System.Drawing.Point(4, 23);
            this.Squads.Margin = new System.Windows.Forms.Padding(0);
            this.Squads.Name = "Squads";
            this.Squads.Padding = new System.Windows.Forms.Padding(3);
            this.Squads.Size = new System.Drawing.Size(778, 359);
            this.Squads.TabIndex = 0;
            this.Squads.Text = "Squads";
            this.Squads.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.propertiesPanel);
            this.splitContainer1.Size = new System.Drawing.Size(772, 353);
            this.splitContainer1.SplitterDistance = 388;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.teamList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.squadList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.removeTeamBtn);
            this.panel3.Controls.Add(this.addTeamBtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 40);
            this.panel3.TabIndex = 12;
            // 
            // removeTeamBtn
            // 
            this.removeTeamBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.removeTeamBtn.Location = new System.Drawing.Point(32, 17);
            this.removeTeamBtn.Name = "removeTeamBtn";
            this.removeTeamBtn.Size = new System.Drawing.Size(20, 20);
            this.removeTeamBtn.TabIndex = 2;
            this.removeTeamBtn.Text = "-";
            this.removeTeamBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeTeamBtn.UseVisualStyleBackColor = true;
            this.removeTeamBtn.Click += new System.EventHandler(this.removeTeamBtn_Click);
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.addTeamBtn.Location = new System.Drawing.Point(6, 17);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(20, 20);
            this.addTeamBtn.TabIndex = 1;
            this.addTeamBtn.Text = "+";
            this.addTeamBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addTeamBtn.UseVisualStyleBackColor = true;
            this.addTeamBtn.Click += new System.EventHandler(this.addTeamBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Team";
            // 
            // teamList
            // 
            this.teamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 16;
            this.teamList.Items.AddRange(new object[] {
            "Team1",
            "Team2",
            "Team3",
            "Team4",
            "Team5",
            "Team6"});
            this.teamList.Location = new System.Drawing.Point(194, 40);
            this.teamList.Margin = new System.Windows.Forms.Padding(0);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(194, 313);
            this.teamList.TabIndex = 11;
            this.teamList.Click += new System.EventHandler(this.TeamList_Clicked);
            // 
            // squadList
            // 
            this.squadList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squadList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squadList.FormattingEnabled = true;
            this.squadList.ItemHeight = 16;
            this.squadList.Items.AddRange(new object[] {
            "Squad1",
            "Squad2"});
            this.squadList.Location = new System.Drawing.Point(0, 40);
            this.squadList.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.squadList.Name = "squadList";
            this.squadList.Size = new System.Drawing.Size(191, 313);
            this.squadList.TabIndex = 9;
            this.squadList.Click += new System.EventHandler(this.SquadList_Clicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.removeSquadBtn);
            this.panel2.Controls.Add(this.addSquadBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 40);
            this.panel2.TabIndex = 10;
            // 
            // removeSquadBtn
            // 
            this.removeSquadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSquadBtn.Location = new System.Drawing.Point(32, 17);
            this.removeSquadBtn.Name = "removeSquadBtn";
            this.removeSquadBtn.Size = new System.Drawing.Size(20, 20);
            this.removeSquadBtn.TabIndex = 2;
            this.removeSquadBtn.Text = "-";
            this.removeSquadBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeSquadBtn.UseVisualStyleBackColor = true;
            this.removeSquadBtn.Click += new System.EventHandler(this.removeSquadBtn_Click);
            // 
            // addSquadBtn
            // 
            this.addSquadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.addSquadBtn.Location = new System.Drawing.Point(6, 17);
            this.addSquadBtn.Name = "addSquadBtn";
            this.addSquadBtn.Size = new System.Drawing.Size(20, 20);
            this.addSquadBtn.TabIndex = 1;
            this.addSquadBtn.Text = "+";
            this.addSquadBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addSquadBtn.UseVisualStyleBackColor = true;
            this.addSquadBtn.Click += new System.EventHandler(this.addSquadBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Squad";
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.BackColor = System.Drawing.Color.Transparent;
            this.propertiesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Size = new System.Drawing.Size(376, 353);
            this.propertiesPanel.TabIndex = 13;
            // 
            // Scoring
            // 
            this.Scoring.Location = new System.Drawing.Point(4, 23);
            this.Scoring.Name = "Scoring";
            this.Scoring.Padding = new System.Windows.Forms.Padding(3);
            this.Scoring.Size = new System.Drawing.Size(778, 359);
            this.Scoring.TabIndex = 1;
            this.Scoring.Text = "Scoring";
            this.Scoring.UseVisualStyleBackColor = true;
            // 
            // Winners
            // 
            this.Winners.Location = new System.Drawing.Point(4, 23);
            this.Winners.Name = "Winners";
            this.Winners.Size = new System.Drawing.Size(778, 359);
            this.Winners.TabIndex = 2;
            this.Winners.Text = "Winners";
            this.Winners.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tournamentToolStripMenuItem,
            this.bowlingCentersToolStripMenuItem,
            this.bowlersToolStripMenuItem,
            this.administrativeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.editToolStripMenuItem});
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bowlersToolStripMenuItem
            // 
            this.bowlersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.bowlersToolStripMenuItem.Name = "bowlersToolStripMenuItem";
            this.bowlersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.bowlersToolStripMenuItem.Text = "Bowlers";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // administrativeToolStripMenuItem
            // 
            this.administrativeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.administrativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.administrativeToolStripMenuItem.Name = "administrativeToolStripMenuItem";
            this.administrativeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administrativeToolStripMenuItem.Text = "Administrative";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // bowlingCentersToolStripMenuItem
            // 
            this.bowlingCentersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem3});
            this.bowlingCentersToolStripMenuItem.Name = "bowlingCentersToolStripMenuItem";
            this.bowlingCentersToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.bowlingCentersToolStripMenuItem.Text = "Bowling Centers";
            // 
            // editToolStripMenuItem3
            // 
            this.editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            this.editToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem3.Text = "Edit";
            // 
            // Events
            // 
            this.Events.Controls.Add(this.splitContainer2);
            this.Events.Location = new System.Drawing.Point(4, 23);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(778, 359);
            this.Events.TabIndex = 3;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Size = new System.Drawing.Size(772, 353);
            this.splitContainer2.SplitterDistance = 388;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 353);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.removeDivisionBtn);
            this.panel1.Controls.Add(this.addDivisionBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 40);
            this.panel1.TabIndex = 12;
            // 
            // removeDivisionBtn
            // 
            this.removeDivisionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDivisionBtn.Location = new System.Drawing.Point(32, 17);
            this.removeDivisionBtn.Name = "removeDivisionBtn";
            this.removeDivisionBtn.Size = new System.Drawing.Size(20, 20);
            this.removeDivisionBtn.TabIndex = 2;
            this.removeDivisionBtn.Text = "-";
            this.removeDivisionBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeDivisionBtn.UseVisualStyleBackColor = true;
            // 
            // addDivisionBtn
            // 
            this.addDivisionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.addDivisionBtn.Location = new System.Drawing.Point(6, 17);
            this.addDivisionBtn.Name = "addDivisionBtn";
            this.addDivisionBtn.Size = new System.Drawing.Size(20, 20);
            this.addDivisionBtn.TabIndex = 1;
            this.addDivisionBtn.Text = "+";
            this.addDivisionBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDivisionBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divisions";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Divison1",
            "Divison2"});
            this.listBox1.Location = new System.Drawing.Point(194, 40);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 313);
            this.listBox1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.removeEventBtn);
            this.panel4.Controls.Add(this.addEventBtn);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 40);
            this.panel4.TabIndex = 10;
            // 
            // removeEventBtn
            // 
            this.removeEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.removeEventBtn.Location = new System.Drawing.Point(32, 17);
            this.removeEventBtn.Name = "removeEventBtn";
            this.removeEventBtn.Size = new System.Drawing.Size(20, 20);
            this.removeEventBtn.TabIndex = 2;
            this.removeEventBtn.Text = "-";
            this.removeEventBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeEventBtn.UseVisualStyleBackColor = true;
            // 
            // addEventBtn
            // 
            this.addEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.addEventBtn.Location = new System.Drawing.Point(6, 17);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(20, 20);
            this.addEventBtn.TabIndex = 1;
            this.addEventBtn.Text = "+";
            this.addEventBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addEventBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Events";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Event1",
            "Event2"});
            this.listBox2.Location = new System.Drawing.Point(0, 40);
            this.listBox2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(191, 313);
            this.listBox2.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(376, 353);
            this.panel5.TabIndex = 13;
            // 
            // JAAK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JAAK";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Text = "JAAK";
            this.tabControl1.ResumeLayout(false);
            this.Squads.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Events.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Squads;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button removeTeamBtn;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeSquadBtn;
        private System.Windows.Forms.Button addSquadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox squadList;
        private System.Windows.Forms.ListBox teamList;
        private System.Windows.Forms.Panel propertiesPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bowlersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.TabPage Scoring;
        private System.Windows.Forms.TabPage Winners;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.ToolStripMenuItem bowlingCentersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeDivisionBtn;
        private System.Windows.Forms.Button addDivisionBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button removeEventBtn;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel5;
    }
}

>>>>>>> 882f8fc345bf59e6a0d32bd5bd1335bb38f44783
