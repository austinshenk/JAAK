namespace JAAK
{
    partial class CreateDivision
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAge = new System.Windows.Forms.CheckBox();
            this.chkAve = new System.Windows.Forms.CheckBox();
            this.chkSex = new System.Windows.Forms.CheckBox();
            this.lblAgeMax = new System.Windows.Forms.Label();
            this.lblAgeMin = new System.Windows.Forms.Label();
            this.lblAveMin = new System.Windows.Forms.Label();
            this.lblAveMax = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.MaskedTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAgeMax = new System.Windows.Forms.MaskedTextBox();
            this.txtAgeMin = new System.Windows.Forms.MaskedTextBox();
            this.txtAveMax = new System.Windows.Forms.MaskedTextBox();
            this.txtAveMin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbEvent
            // 
            this.cmbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(95, 40);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(121, 21);
            this.cmbEvent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "This will divide people by their....";
            // 
            // chkAge
            // 
            this.chkAge.AutoSize = true;
            this.chkAge.Location = new System.Drawing.Point(20, 96);
            this.chkAge.Name = "chkAge";
            this.chkAge.Size = new System.Drawing.Size(45, 17);
            this.chkAge.TabIndex = 5;
            this.chkAge.Text = "Age";
            this.chkAge.UseVisualStyleBackColor = true;
            this.chkAge.CheckedChanged += new System.EventHandler(this.chkAge_CheckedChanged);
            // 
            // chkAve
            // 
            this.chkAve.AutoSize = true;
            this.chkAve.Location = new System.Drawing.Point(71, 96);
            this.chkAve.Name = "chkAve";
            this.chkAve.Size = new System.Drawing.Size(66, 17);
            this.chkAve.TabIndex = 6;
            this.chkAve.Text = "Average";
            this.chkAve.UseVisualStyleBackColor = true;
            this.chkAve.CheckedChanged += new System.EventHandler(this.chkAve_CheckedChanged);
            // 
            // chkSex
            // 
            this.chkSex.AutoSize = true;
            this.chkSex.Location = new System.Drawing.Point(143, 96);
            this.chkSex.Name = "chkSex";
            this.chkSex.Size = new System.Drawing.Size(44, 17);
            this.chkSex.TabIndex = 7;
            this.chkSex.Text = "Sex";
            this.chkSex.UseVisualStyleBackColor = true;
            this.chkSex.CheckedChanged += new System.EventHandler(this.chkSex_CheckedChanged);
            // 
            // lblAgeMax
            // 
            this.lblAgeMax.AutoSize = true;
            this.lblAgeMax.Location = new System.Drawing.Point(20, 120);
            this.lblAgeMax.Name = "lblAgeMax";
            this.lblAgeMax.Size = new System.Drawing.Size(27, 13);
            this.lblAgeMax.TabIndex = 9;
            this.lblAgeMax.Text = "Max";
            this.lblAgeMax.Visible = false;
            // 
            // lblAgeMin
            // 
            this.lblAgeMin.AutoSize = true;
            this.lblAgeMin.Location = new System.Drawing.Point(20, 163);
            this.lblAgeMin.Name = "lblAgeMin";
            this.lblAgeMin.Size = new System.Drawing.Size(24, 13);
            this.lblAgeMin.TabIndex = 10;
            this.lblAgeMin.Text = "Min";
            this.lblAgeMin.Visible = false;
            // 
            // lblAveMin
            // 
            this.lblAveMin.AutoSize = true;
            this.lblAveMin.Location = new System.Drawing.Point(71, 163);
            this.lblAveMin.Name = "lblAveMin";
            this.lblAveMin.Size = new System.Drawing.Size(24, 13);
            this.lblAveMin.TabIndex = 14;
            this.lblAveMin.Text = "Min";
            this.lblAveMin.Visible = false;
            // 
            // lblAveMax
            // 
            this.lblAveMax.AutoSize = true;
            this.lblAveMax.Location = new System.Drawing.Point(71, 120);
            this.lblAveMax.Name = "lblAveMax";
            this.lblAveMax.Size = new System.Drawing.Size(27, 13);
            this.lblAveMax.TabIndex = 13;
            this.lblAveMax.Text = "Max";
            this.lblAveMax.Visible = false;
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(143, 136);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(59, 21);
            this.cmbSex.TabIndex = 16;
            this.cmbSex.Visible = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(143, 119);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(44, 13);
            this.lblSex.TabIndex = 17;
            this.lblSex.Text = "Which?";
            this.lblSex.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "The handicap for this division will be ";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(191, 199);
            this.txtPercent.Mask = "000";
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(25, 20);
            this.txtPercent.TabIndex = 19;
            this.txtPercent.Text = "80";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "percent of";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(283, 199);
            this.txtBase.Mask = "000";
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(31, 20);
            this.txtBase.TabIndex = 21;
            this.txtBase.Text = "210";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 227);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAgeMax
            // 
            this.txtAgeMax.Location = new System.Drawing.Point(23, 135);
            this.txtAgeMax.Mask = "000";
            this.txtAgeMax.Name = "txtAgeMax";
            this.txtAgeMax.Size = new System.Drawing.Size(42, 20);
            this.txtAgeMax.TabIndex = 24;
            this.txtAgeMax.Text = "0";
            this.txtAgeMax.Visible = false;
            // 
            // txtAgeMin
            // 
            this.txtAgeMin.Location = new System.Drawing.Point(23, 180);
            this.txtAgeMin.Mask = "000";
            this.txtAgeMin.Name = "txtAgeMin";
            this.txtAgeMin.Size = new System.Drawing.Size(42, 20);
            this.txtAgeMin.TabIndex = 25;
            this.txtAgeMin.Text = "120";
            this.txtAgeMin.Visible = false;
            // 
            // txtAveMax
            // 
            this.txtAveMax.Location = new System.Drawing.Point(71, 134);
            this.txtAveMax.Mask = "0000";
            this.txtAveMax.Name = "txtAveMax";
            this.txtAveMax.Size = new System.Drawing.Size(66, 20);
            this.txtAveMax.TabIndex = 26;
            this.txtAveMax.Text = "0";
            this.txtAveMax.Visible = false;
            // 
            // txtAveMin
            // 
            this.txtAveMin.Location = new System.Drawing.Point(71, 179);
            this.txtAveMin.Mask = "0000";
            this.txtAveMin.Name = "txtAveMin";
            this.txtAveMin.Size = new System.Drawing.Size(66, 20);
            this.txtAveMin.TabIndex = 27;
            this.txtAveMin.Text = "1200";
            this.txtAveMin.Visible = false;
            // 
            // CreateDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 262);
            this.Controls.Add(this.txtAveMin);
            this.Controls.Add(this.txtAveMax);
            this.Controls.Add(this.txtAgeMin);
            this.Controls.Add(this.txtAgeMax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.lblAveMin);
            this.Controls.Add(this.lblAveMax);
            this.Controls.Add(this.lblAgeMin);
            this.Controls.Add(this.lblAgeMax);
            this.Controls.Add(this.chkSex);
            this.Controls.Add(this.chkAve);
            this.Controls.Add(this.chkAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "CreateDivision";
            this.Text = "CreateDivision";
            this.Load += new System.EventHandler(this.CreateDivsion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAge;
        private System.Windows.Forms.CheckBox chkAve;
        private System.Windows.Forms.CheckBox chkSex;
        private System.Windows.Forms.Label lblAgeMax;
        private System.Windows.Forms.Label lblAgeMin;
        private System.Windows.Forms.Label lblAveMin;
        private System.Windows.Forms.Label lblAveMax;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtBase;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtAgeMax;
        private System.Windows.Forms.MaskedTextBox txtAgeMin;
        private System.Windows.Forms.MaskedTextBox txtAveMax;
        private System.Windows.Forms.MaskedTextBox txtAveMin;
    }
}