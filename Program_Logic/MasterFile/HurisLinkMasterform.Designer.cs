namespace AMS.MasterFile
{
    partial class HurisLinkMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HurisLinkMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.asst_add_btn = new System.Windows.Forms.ToolStripButton();
            this.asst_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.asst_print_btn = new System.Windows.Forms.ToolStripButton();
            this.asst_save_btn = new System.Windows.Forms.ToolStripButton();
            this.asst_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.hurisLsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHurisId = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_emp = new System.Windows.Forms.Button();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asst_add_btn,
            this.asst_edit_btn,
            this.asst_print_btn,
            this.asst_save_btn,
            this.asst_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 39);
            this.toolStrip1.TabIndex = 1054;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // asst_add_btn
            // 
            this.asst_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("asst_add_btn.Image")));
            this.asst_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asst_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.asst_add_btn.Name = "asst_add_btn";
            this.asst_add_btn.Size = new System.Drawing.Size(36, 36);
            this.asst_add_btn.ToolTipText = "add record";
            this.asst_add_btn.Click += new System.EventHandler(this.asst_add_btn_Click);
            // 
            // asst_edit_btn
            // 
            this.asst_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("asst_edit_btn.Image")));
            this.asst_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asst_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.asst_edit_btn.Name = "asst_edit_btn";
            this.asst_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.asst_edit_btn.ToolTipText = "Edit record";
            this.asst_edit_btn.Click += new System.EventHandler(this.asst_edit_btn_Click);
            // 
            // asst_print_btn
            // 
            this.asst_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("asst_print_btn.Image")));
            this.asst_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asst_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.asst_print_btn.Name = "asst_print_btn";
            this.asst_print_btn.Size = new System.Drawing.Size(36, 36);
            this.asst_print_btn.ToolTipText = "Print record";
            this.asst_print_btn.Click += new System.EventHandler(this.asst_print_btn_Click);
            // 
            // asst_save_btn
            // 
            this.asst_save_btn.Enabled = false;
            this.asst_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("asst_save_btn.Image")));
            this.asst_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asst_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.asst_save_btn.Name = "asst_save_btn";
            this.asst_save_btn.Size = new System.Drawing.Size(36, 36);
            this.asst_save_btn.ToolTipText = "save record";
            this.asst_save_btn.Click += new System.EventHandler(this.asst_save_btn_Click);
            // 
            // asst_cancel_btn
            // 
            this.asst_cancel_btn.Enabled = false;
            this.asst_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("asst_cancel_btn.Image")));
            this.asst_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asst_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.asst_cancel_btn.Name = "asst_cancel_btn";
            this.asst_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.asst_cancel_btn.ToolTipText = "cancel record";
            this.asst_cancel_btn.Click += new System.EventHandler(this.asst_cancel_btn_Click);
            // 
            // hurisLsvList
            // 
            this.hurisLsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader7});
            this.hurisLsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hurisLsvList.FullRowSelect = true;
            this.hurisLsvList.GridLines = true;
            this.hurisLsvList.Location = new System.Drawing.Point(0, 205);
            this.hurisLsvList.Name = "hurisLsvList";
            this.hurisLsvList.Size = new System.Drawing.Size(473, 208);
            this.hurisLsvList.TabIndex = 1055;
            this.hurisLsvList.UseCompatibleStateImageBehavior = false;
            this.hurisLsvList.View = System.Windows.Forms.View.Details;
            this.hurisLsvList.SelectedIndexChanged += new System.EventHandler(this.AssetTagSeries_Selectedindex);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Employee Name";
            this.columnHeader5.Width = 187;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Huris ID";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 196;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date Created";
            this.columnHeader7.Width = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1097;
            this.label3.Text = "Filter :";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.Location = new System.Drawing.Point(138, 174);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(239, 21);
            this.txtFilter.TabIndex = 1096;
            this.btxMsg.SetText(this.txtFilter, null);
            this.btxMsg.SetTitle(this.txtFilter, null);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtTagfilter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTagFilter_Keydown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1095;
            this.label2.Text = "HURIS Id :";
            // 
            // txtHurisId
            // 
            this.txtHurisId.BackColor = System.Drawing.Color.White;
            this.txtHurisId.Location = new System.Drawing.Point(237, 88);
            this.txtHurisId.Name = "txtHurisId";
            this.txtHurisId.ReadOnly = true;
            this.txtHurisId.Size = new System.Drawing.Size(103, 21);
            this.txtHurisId.TabIndex = 1094;
            this.btxMsg.SetText(this.txtHurisId, null);
            this.btxMsg.SetTitle(this.txtHurisId, null);
            this.txtHurisId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.assetItemCode_Keydown);
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.Color.White;
            this.txtEmployee.Location = new System.Drawing.Point(237, 64);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(103, 21);
            this.txtEmployee.TabIndex = 1087;
            this.btxMsg.SetText(this.txtEmployee, "Company Code cannot be blanked");
            this.btxMsg.SetTitle(this.txtEmployee, null);
            this.txtEmployee.TextChanged += new System.EventHandler(this.txtAssetCC_TextChanged);
            this.txtEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.assetCC_Keydown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1086;
            this.label1.Text = "Employee :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1100;
            this.pictureBox1.TabStop = false;
            // 
            // btn_emp
            // 
            this.btn_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_emp.Enabled = false;
            this.btn_emp.FlatAppearance.BorderSize = 0;
            this.btn_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp.ForeColor = System.Drawing.Color.White;
            this.btn_emp.Image = ((System.Drawing.Image)(resources.GetObject("btn_emp.Image")));
            this.btn_emp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emp.Location = new System.Drawing.Point(341, 64);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(96, 21);
            this.btn_emp.TabIndex = 1101;
            this.btn_emp.Text = "      Search";
            this.btn_emp.UseVisualStyleBackColor = false;
            this.btn_emp.Click += new System.EventHandler(this.btn_company_Click);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label5);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 413);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(473, 25);
            this.panFoot.TabIndex = 1103;
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
            // HurisLinkMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 438);
            this.Controls.Add(this.btn_emp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHurisId);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hurisLsvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "HurisLinkMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huris Link Master file";
            this.Load += new System.EventHandler(this.AssetTagSeries_Load);
            this.TextChanged += new System.EventHandler(this.assetTag);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssetTag_Keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton asst_add_btn;
        private System.Windows.Forms.ToolStripButton asst_edit_btn;
        private System.Windows.Forms.ToolStripButton asst_print_btn;
        private System.Windows.Forms.ToolStripButton asst_save_btn;
        private System.Windows.Forms.ToolStripButton asst_cancel_btn;
        private System.Windows.Forms.ListView hurisLsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHurisId;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label5;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}