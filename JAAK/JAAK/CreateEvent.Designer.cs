namespace JAAK
{
    partial class CreateEvent
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLinage = new System.Windows.Forms.TextBox();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(104, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Singles",
            "Doubles",
            "Teams"});
            this.cmbType.Location = new System.Drawing.Point(104, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(232, 21);
            this.cmbType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBoD
            // 
            this.cmbBoD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoD.FormattingEnabled = true;
            this.cmbBoD.Items.AddRange(new object[] {
            "Bowled",
            "Derived"});
            this.cmbBoD.Location = new System.Drawing.Point(104, 57);
            this.cmbBoD.Name = "cmbBoD";
            this.cmbBoD.Size = new System.Drawing.Size(232, 21);
            this.cmbBoD.TabIndex = 4;
            this.cmbBoD.SelectedIndexChanged += new System.EventHandler(this.cmbBoD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bowled or Derived";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDF
            // 
            this.cmbDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDF.FormattingEnabled = true;
            this.cmbDF.Location = new System.Drawing.Point(104, 84);
            this.cmbDF.Name = "cmbDF";
            this.cmbDF.Size = new System.Drawing.Size(232, 21);
            this.cmbDF.TabIndex = 6;
            this.cmbDF.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Derived From";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Linage";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Expenses";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prize Fund";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Per Bowler";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(195, 236);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "OK";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(276, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLinage
            // 
            this.txtLinage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLinage.Location = new System.Drawing.Point(104, 111);
            this.txtLinage.Name = "txtLinage";
            this.txtLinage.Size = new System.Drawing.Size(232, 20);
            this.txtLinage.TabIndex = 20;
            this.txtLinage.Text = "00.00";
            this.txtLinage.TextChanged += new System.EventHandler(this.txtLinage_TextChanged);
            // 
            // txtExpenses
            // 
            this.txtExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpenses.Location = new System.Drawing.Point(104, 138);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(232, 20);
            this.txtExpenses.TabIndex = 21;
            this.txtExpenses.Text = "00.00";
            this.txtExpenses.TextChanged += new System.EventHandler(this.txtExpenses_TextChanged);
            // 
            // txtPrize
            // 
            this.txtPrize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrize.Location = new System.Drawing.Point(104, 165);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(232, 20);
            this.txtPrize.TabIndex = 22;
            this.txtPrize.Text = "00.00";
            this.txtPrize.TextChanged += new System.EventHandler(this.txtPrize_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrize, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenses, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtLinage, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbDF, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 218);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // CreateEvent
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(363, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTotal);
            this.MaximizeBox = false;
            this.Name = "CreateEvent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Event";
            this.Load += new System.EventHandler(this.CreateEvent_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLinage;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.TextBox txtPrize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}