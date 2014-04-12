namespace JAAK
{
    partial class CreateTournament
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.directorLbl = new System.Windows.Forms.Label();
            this.directorTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.stateTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.zipTxt = new System.Windows.Forms.MaskedTextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nameLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameTxt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.directorLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.directorTxt, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.endDate, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.startDate, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.addressTxt, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cityTxt, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.stateTxt, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.phoneTxt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.zipTxt, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 249);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Director Zip";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Director State";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Director City";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Director Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(3, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(70, 28);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Location = new System.Drawing.Point(97, 3);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(215, 20);
            this.nameTxt.TabIndex = 4;
            // 
            // directorLbl
            // 
            this.directorLbl.Location = new System.Drawing.Point(3, 28);
            this.directorLbl.Name = "directorLbl";
            this.directorLbl.Size = new System.Drawing.Size(70, 28);
            this.directorLbl.TabIndex = 5;
            this.directorLbl.Text = "Director";
            this.directorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // directorTxt
            // 
            this.directorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorTxt.Location = new System.Drawing.Point(97, 31);
            this.directorTxt.Name = "directorTxt";
            this.directorTxt.Size = new System.Drawing.Size(215, 20);
            this.directorTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Director Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ending Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Starting Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endDate
            // 
            this.endDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDate.CustomFormat = "";
            this.endDate.Location = new System.Drawing.Point(97, 227);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(215, 20);
            this.endDate.TabIndex = 10;
            // 
            // startDate
            // 
            this.startDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDate.CustomFormat = "";
            this.startDate.Location = new System.Drawing.Point(97, 199);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(215, 20);
            this.startDate.TabIndex = 8;
            // 
            // addressTxt
            // 
            this.addressTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTxt.Location = new System.Drawing.Point(97, 87);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(215, 20);
            this.addressTxt.TabIndex = 17;
            // 
            // cityTxt
            // 
            this.cityTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTxt.Location = new System.Drawing.Point(97, 115);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(215, 20);
            this.cityTxt.TabIndex = 18;
            // 
            // stateTxt
            // 
            this.stateTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateTxt.Location = new System.Drawing.Point(97, 143);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(215, 20);
            this.stateTxt.TabIndex = 19;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneTxt.Location = new System.Drawing.Point(97, 59);
            this.phoneTxt.Mask = "(999) 000-0000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(215, 20);
            this.phoneTxt.TabIndex = 21;
            // 
            // zipTxt
            // 
            this.zipTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zipTxt.Location = new System.Drawing.Point(97, 171);
            this.zipTxt.Mask = "00000";
            this.zipTxt.Name = "zipTxt";
            this.zipTxt.Size = new System.Drawing.Size(215, 20);
            this.zipTxt.TabIndex = 22;
            this.zipTxt.ValidatingType = typeof(int);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(168, 268);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(249, 267);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CreateTournament
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(339, 302);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "CreateTournament";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Tournament";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label directorLbl;
        private System.Windows.Forms.TextBox directorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.TextBox stateTxt;
        private System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.MaskedTextBox zipTxt;
    }
}