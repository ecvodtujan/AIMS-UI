namespace AMS.Transaction.Decommission
{
    partial class AddDecommissionDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDecommissionDetails));
            this.lsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBrand = new System.Windows.Forms.CheckBox();
            this.chkItemType = new System.Windows.Forms.CheckBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_brand = new System.Windows.Forms.Button();
            this.btn_itemtype = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvList
            // 
            this.lsvList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 109);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(749, 312);
            this.lsvList.TabIndex = 1046;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            this.lsvList.DoubleClick += new System.EventHandler(this.lsvList_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asset Code";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item type";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Brand";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "            Model";
            this.columnHeader4.Width = 234;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Purchased";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 113;
            // 
            // txtItemType
            // 
            this.txtItemType.BackColor = System.Drawing.SystemColors.Window;
            this.txtItemType.Location = new System.Drawing.Point(99, 15);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(277, 21);
            this.txtItemType.TabIndex = 1081;
            this.txtItemType.Tag = "0";
            this.btxMsg.SetText(this.txtItemType, null);
            this.btxMsg.SetTitle(this.txtItemType, null);
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrand.Location = new System.Drawing.Point(99, 38);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(277, 21);
            this.txtBrand.TabIndex = 1083;
            this.txtBrand.Tag = "0";
            this.btxMsg.SetText(this.txtBrand, null);
            this.btxMsg.SetTitle(this.txtBrand, null);
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyword.Location = new System.Drawing.Point(99, 62);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(277, 21);
            this.txtKeyword.TabIndex = 1085;
            this.txtKeyword.Tag = "0";
            this.btxMsg.SetText(this.txtKeyword, null);
            this.btxMsg.SetTitle(this.txtKeyword, null);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label5);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 421);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(749, 25);
            this.panFoot.TabIndex = 1080;
            this.panFoot.Paint += new System.Windows.Forms.PaintEventHandler(this.panFoot_Paint);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 849;
            this.label5.Text = "Press Esc to close this form";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkBrand
            // 
            this.chkBrand.AutoSize = true;
            this.chkBrand.BackColor = System.Drawing.Color.Transparent;
            this.chkBrand.ForeColor = System.Drawing.Color.Black;
            this.chkBrand.Location = new System.Drawing.Point(11, 41);
            this.chkBrand.Name = "chkBrand";
            this.chkBrand.Size = new System.Drawing.Size(61, 17);
            this.chkBrand.TabIndex = 1089;
            this.chkBrand.Text = "Brand :";
            this.chkBrand.UseVisualStyleBackColor = false;
            this.chkBrand.CheckedChanged += new System.EventHandler(this.chkBrand_CheckedChanged);
            // 
            // chkItemType
            // 
            this.chkItemType.AutoSize = true;
            this.chkItemType.BackColor = System.Drawing.Color.Transparent;
            this.chkItemType.ForeColor = System.Drawing.Color.Black;
            this.chkItemType.Location = new System.Drawing.Point(11, 17);
            this.chkItemType.Name = "chkItemType";
            this.chkItemType.Size = new System.Drawing.Size(80, 17);
            this.chkItemType.TabIndex = 1088;
            this.chkItemType.Text = "item Type :";
            this.chkItemType.UseVisualStyleBackColor = false;
            this.chkItemType.CheckedChanged += new System.EventHandler(this.chkItemType_CheckedChanged);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_filter.FlatAppearance.BorderSize = 0;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.ForeColor = System.Drawing.Color.White;
            this.btn_filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_filter.Image")));
            this.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.Location = new System.Drawing.Point(376, 62);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(83, 21);
            this.btn_filter.TabIndex = 1086;
            this.btn_filter.Text = "      Search";
            this.btn_filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_brand
            // 
            this.btn_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_brand.FlatAppearance.BorderSize = 0;
            this.btn_brand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brand.ForeColor = System.Drawing.Color.White;
            this.btn_brand.Image = ((System.Drawing.Image)(resources.GetObject("btn_brand.Image")));
            this.btn_brand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brand.Location = new System.Drawing.Point(376, 38);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Size = new System.Drawing.Size(83, 21);
            this.btn_brand.TabIndex = 1084;
            this.btn_brand.Text = "      Search";
            this.btn_brand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brand.UseVisualStyleBackColor = false;
            // 
            // btn_itemtype
            // 
            this.btn_itemtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_itemtype.FlatAppearance.BorderSize = 0;
            this.btn_itemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemtype.ForeColor = System.Drawing.Color.White;
            this.btn_itemtype.Image = ((System.Drawing.Image)(resources.GetObject("btn_itemtype.Image")));
            this.btn_itemtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.Location = new System.Drawing.Point(375, 15);
            this.btn_itemtype.Name = "btn_itemtype";
            this.btn_itemtype.Size = new System.Drawing.Size(84, 21);
            this.btn_itemtype.TabIndex = 1082;
            this.btn_itemtype.Text = "      Search";
            this.btn_itemtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1087;
            this.label4.Text = "Keyword :";
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
            "APW",
            "All"});
            this.cboCompany.Location = new System.Drawing.Point(593, 14);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(142, 21);
            this.cboCompany.TabIndex = 1091;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.BackColor = System.Drawing.Color.Transparent;
            this.chkCompany.ForeColor = System.Drawing.Color.Black;
            this.chkCompany.Location = new System.Drawing.Point(512, 17);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(78, 17);
            this.chkCompany.TabIndex = 1090;
            this.chkCompany.Text = "Company :";
            this.chkCompany.UseVisualStyleBackColor = false;
            this.chkCompany.CheckedChanged += new System.EventHandler(this.chkCompany_CheckedChanged);
            // 
            // AddDecommissionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.chkCompany);
            this.Controls.Add(this.chkBrand);
            this.Controls.Add(this.chkItemType);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.btn_brand);
            this.Controls.Add(this.btn_itemtype);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AddDecommissionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Asset";
            this.Load += new System.EventHandler(this.AddDecommissionDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddDecommissionDetails_KeyDown);
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox chkBrand;
        private System.Windows.Forms.CheckBox chkItemType;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Button btn_brand;
        private System.Windows.Forms.Button btn_itemtype;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.CheckBox chkCompany;
    }
}