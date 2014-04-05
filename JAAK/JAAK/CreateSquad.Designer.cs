namespace JAAK
{
    partial class CreateSquad
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.directorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.centerNameCmbo = new System.Windows.Forms.ComboBox();
            this.typeCmbo = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.jAAKdatabaseDataSet = new JAAK.JAAKdatabaseDataSet();
            this.bowlingCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bowlingCenterTableAdapter = new JAAK.JAAKdatabaseDataSetTableAdapters.BowlingCenterTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jAAKdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingCenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.time, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nameLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.directorLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.centerNameCmbo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.typeCmbo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.date, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 118);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time.CustomFormat = "hh:mm tt";
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time.Location = new System.Drawing.Point(87, 87);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(190, 20);
            this.time.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLbl
            // 
            this.nameLbl.Location = new System.Drawing.Point(3, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 28);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Center Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // directorLbl
            // 
            this.directorLbl.Location = new System.Drawing.Point(3, 28);
            this.directorLbl.Name = "directorLbl";
            this.directorLbl.Size = new System.Drawing.Size(71, 28);
            this.directorLbl.TabIndex = 5;
            this.directorLbl.Text = "Type";
            this.directorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // centerNameCmbo
            // 
            this.centerNameCmbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerNameCmbo.DataSource = this.bowlingCenterBindingSource;
            this.centerNameCmbo.DisplayMember = "CenterName";
            this.centerNameCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.centerNameCmbo.FormattingEnabled = true;
            this.centerNameCmbo.Location = new System.Drawing.Point(87, 3);
            this.centerNameCmbo.Name = "centerNameCmbo";
            this.centerNameCmbo.Size = new System.Drawing.Size(190, 21);
            this.centerNameCmbo.TabIndex = 11;
            // 
            // typeCmbo
            // 
            this.typeCmbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCmbo.FormattingEnabled = true;
            this.typeCmbo.Items.AddRange(new object[] {
            "Singles",
            "Doubles",
            "Teams",
            "Singles and Doubles",
            "All Events"});
            this.typeCmbo.Location = new System.Drawing.Point(87, 31);
            this.typeCmbo.Name = "typeCmbo";
            this.typeCmbo.Size = new System.Drawing.Size(190, 21);
            this.typeCmbo.TabIndex = 12;
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Location = new System.Drawing.Point(87, 59);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(190, 20);
            this.date.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(217, 156);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(136, 156);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // jAAKdatabaseDataSet
            // 
            this.jAAKdatabaseDataSet.DataSetName = "JAAKdatabaseDataSet";
            this.jAAKdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bowlingCenterBindingSource
            // 
            this.bowlingCenterBindingSource.DataMember = "BowlingCenter";
            this.bowlingCenterBindingSource.DataSource = this.jAAKdatabaseDataSet;
            // 
            // bowlingCenterTableAdapter
            // 
            this.bowlingCenterTableAdapter.ClearBeforeFill = true;
            // 
            // CreateSquad
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(304, 187);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "CreateSquad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Squad";
            this.Load += new System.EventHandler(this.CreateSquad_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jAAKdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingCenterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label directorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox centerNameCmbo;
        private System.Windows.Forms.ComboBox typeCmbo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DateTimePicker time;
        private JAAKdatabaseDataSet jAAKdatabaseDataSet;
        private System.Windows.Forms.BindingSource bowlingCenterBindingSource;
        private JAAKdatabaseDataSetTableAdapters.BowlingCenterTableAdapter bowlingCenterTableAdapter;
    }
}