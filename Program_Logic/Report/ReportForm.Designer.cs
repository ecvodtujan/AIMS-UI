namespace AIMS.Report
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.dtpYearTo = new System.Windows.Forms.DateTimePicker();
            this.dtpYearFrom = new System.Windows.Forms.DateTimePicker();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.post_btn = new System.Windows.Forms.Button();
            this.chkBrand = new System.Windows.Forms.CheckBox();
            this.chkItemType = new System.Windows.Forms.CheckBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.btn_brand = new System.Windows.Forms.Button();
            this.btn_itemtype = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboreportby = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Enabled = false;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Items.AddRange(new object[] {
            "ZMG",
            "APS",
            "ASI",
            "APW"});
            this.cboCompany.Location = new System.Drawing.Point(112, 126);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(154, 21);
            this.cboCompany.TabIndex = 1089;
            this.cboCompany.SelectedIndexChanged += new System.EventHandler(this.cbocompanyindexchange);
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.BackColor = System.Drawing.Color.Transparent;
            this.chkCompany.Enabled = false;
            this.chkCompany.ForeColor = System.Drawing.Color.Black;
            this.chkCompany.Location = new System.Drawing.Point(26, 128);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(78, 17);
            this.chkCompany.TabIndex = 1088;
            this.chkCompany.Text = "Company :";
            this.chkCompany.UseVisualStyleBackColor = false;
            this.chkCompany.CheckedChanged += new System.EventHandler(this.chkCompany_checkedChange);
            // 
            // dtpYearTo
            // 
            this.dtpYearTo.CustomFormat = "yyyy";
            this.dtpYearTo.Enabled = false;
            this.dtpYearTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearTo.Location = new System.Drawing.Point(347, 102);
            this.dtpYearTo.Name = "dtpYearTo";
            this.dtpYearTo.ShowUpDown = true;
            this.dtpYearTo.Size = new System.Drawing.Size(74, 21);
            this.dtpYearTo.TabIndex = 1098;
            this.dtpYearTo.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // dtpYearFrom
            // 
            this.dtpYearFrom.CustomFormat = "yyyy";
            this.dtpYearFrom.Enabled = false;
            this.dtpYearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearFrom.Location = new System.Drawing.Point(270, 102);
            this.dtpYearFrom.Name = "dtpYearFrom";
            this.dtpYearFrom.ShowUpDown = true;
            this.dtpYearFrom.Size = new System.Drawing.Size(74, 21);
            this.dtpYearFrom.TabIndex = 1097;
            this.dtpYearFrom.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.BackColor = System.Drawing.Color.Transparent;
            this.chkYear.Enabled = false;
            this.chkYear.ForeColor = System.Drawing.Color.Black;
            this.chkYear.Location = new System.Drawing.Point(26, 105);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(70, 17);
            this.chkYear.TabIndex = 1096;
            this.chkYear.Text = "By Year :";
            this.chkYear.UseVisualStyleBackColor = false;
            this.chkYear.CheckedChanged += new System.EventHandler(this.chkYear_CheckedChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Enabled = false;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "Warranty Date",
            "Purchase Date",
            "Manufacturing Date"});
            this.cboYear.Location = new System.Drawing.Point(112, 101);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(155, 21);
            this.cboYear.TabIndex = 1095;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // post_btn
            // 
            this.post_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.post_btn.FlatAppearance.BorderSize = 0;
            this.post_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.ForeColor = System.Drawing.Color.White;
            this.post_btn.Image = ((System.Drawing.Image)(resources.GetObject("post_btn.Image")));
            this.post_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.post_btn.Location = new System.Drawing.Point(331, 156);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(119, 37);
            this.post_btn.TabIndex = 1094;
            this.post_btn.Text = "Print Report";
            this.post_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.post_btn.UseVisualStyleBackColor = false;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // chkBrand
            // 
            this.chkBrand.AutoSize = true;
            this.chkBrand.BackColor = System.Drawing.Color.Transparent;
            this.chkBrand.Enabled = false;
            this.chkBrand.ForeColor = System.Drawing.Color.Black;
            this.chkBrand.Location = new System.Drawing.Point(26, 79);
            this.chkBrand.Name = "chkBrand";
            this.chkBrand.Size = new System.Drawing.Size(61, 17);
            this.chkBrand.TabIndex = 1105;
            this.chkBrand.Text = "Brand :";
            this.chkBrand.UseVisualStyleBackColor = false;
            this.chkBrand.CheckedChanged += new System.EventHandler(this.chkBrand_change);
            // 
            // chkItemType
            // 
            this.chkItemType.AutoSize = true;
            this.chkItemType.BackColor = System.Drawing.Color.Transparent;
            this.chkItemType.Enabled = false;
            this.chkItemType.ForeColor = System.Drawing.Color.Black;
            this.chkItemType.Location = new System.Drawing.Point(26, 57);
            this.chkItemType.Name = "chkItemType";
            this.chkItemType.Size = new System.Drawing.Size(82, 17);
            this.chkItemType.TabIndex = 1104;
            this.chkItemType.Text = "Item Type :";
            this.chkItemType.UseVisualStyleBackColor = false;
            this.chkItemType.CheckedChanged += new System.EventHandler(this.chkItemtype_change);
            // 
            // txtItemType
            // 
            this.txtItemType.BackColor = System.Drawing.SystemColors.Window;
            this.txtItemType.Location = new System.Drawing.Point(112, 55);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(249, 21);
            this.txtItemType.TabIndex = 1100;
            this.txtItemType.Tag = "0";
            // 
            // btn_brand
            // 
            this.btn_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_brand.FlatAppearance.BorderSize = 0;
            this.btn_brand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brand.ForeColor = System.Drawing.Color.White;
            this.btn_brand.Image = ((System.Drawing.Image)(resources.GetObject("btn_brand.Image")));
            this.btn_brand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brand.Location = new System.Drawing.Point(364, 77);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Size = new System.Drawing.Size(83, 21);
            this.btn_brand.TabIndex = 1103;
            this.btn_brand.Text = "      Search";
            this.btn_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brand.UseVisualStyleBackColor = false;
            this.btn_brand.Click += new System.EventHandler(this.btn_brand_Click);
            // 
            // btn_itemtype
            // 
            this.btn_itemtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_itemtype.FlatAppearance.BorderSize = 0;
            this.btn_itemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemtype.ForeColor = System.Drawing.Color.White;
            this.btn_itemtype.Image = ((System.Drawing.Image)(resources.GetObject("btn_itemtype.Image")));
            this.btn_itemtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.Location = new System.Drawing.Point(363, 54);
            this.btn_itemtype.Name = "btn_itemtype";
            this.btn_itemtype.Size = new System.Drawing.Size(84, 21);
            this.btn_itemtype.TabIndex = 1101;
            this.btn_itemtype.Text = "      Search";
            this.btn_itemtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.UseVisualStyleBackColor = false;
            this.btn_itemtype.Click += new System.EventHandler(this.btn_itemtype_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrand.Location = new System.Drawing.Point(112, 78);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(249, 21);
            this.txtBrand.TabIndex = 1102;
            this.txtBrand.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1106;
            this.label1.Text = "CHOOSE REPORT BY:";
            // 
            // cboreportby
            // 
            this.cboreportby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboreportby.FormattingEnabled = true;
            this.cboreportby.Items.AddRange(new object[] {
            "ITEM TYPE",
            "BRAND",
            "YEAR",
            "COMPANY",
            "ALL"});
            this.cboreportby.Location = new System.Drawing.Point(122, 7);
            this.cboreportby.Name = "cboreportby";
            this.cboreportby.Size = new System.Drawing.Size(155, 21);
            this.cboreportby.TabIndex = 1107;
            this.cboreportby.SelectedIndexChanged += new System.EventHandler(this.cboReportby_selectedchange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 35);
            this.panel1.TabIndex = 1108;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 203);
            this.Controls.Add(this.cboreportby);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBrand);
            this.Controls.Add(this.chkItemType);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.btn_brand);
            this.Controls.Add(this.btn_itemtype);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.dtpYearTo);
            this.Controls.Add(this.dtpYearFrom);
            this.Controls.Add(this.chkYear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.post_btn);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.chkCompany);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.Leave += new System.EventHandler(this.ReportForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.DateTimePicker dtpYearTo;
        private System.Windows.Forms.DateTimePicker dtpYearFrom;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.CheckBox chkBrand;
        private System.Windows.Forms.CheckBox chkItemType;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Button btn_brand;
        private System.Windows.Forms.Button btn_itemtype;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboreportby;
        private System.Windows.Forms.Panel panel1;
    }
}