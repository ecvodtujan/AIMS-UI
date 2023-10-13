namespace AMS.MasterFile
{
    partial class DepartmentNewMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentNewMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dept_add_btn = new System.Windows.Forms.ToolStripButton();
            this.dept_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.dept_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.dept_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.dept_print_btn = new System.Windows.Forms.ToolStripButton();
            this.dept_save_btn = new System.Windows.Forms.ToolStripButton();
            this.dept_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.deptLsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdeptFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtdeptCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dept_search_btn = new System.Windows.Forms.Button();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dept_add_btn,
            this.dept_edit_btn,
            this.dept_deactivate_btn,
            this.dept_activate_btn,
            this.dept_print_btn,
            this.dept_save_btn,
            this.dept_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 39);
            this.toolStrip1.TabIndex = 1054;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dept_add_btn
            // 
            this.dept_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_add_btn.Image")));
            this.dept_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_add_btn.Name = "dept_add_btn";
            this.dept_add_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_add_btn.ToolTipText = "add record";
            this.dept_add_btn.Click += new System.EventHandler(this.dept_add_btn_Click);
            // 
            // dept_edit_btn
            // 
            this.dept_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_edit_btn.Image")));
            this.dept_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_edit_btn.Name = "dept_edit_btn";
            this.dept_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_edit_btn.ToolTipText = "Edit record";
            this.dept_edit_btn.Click += new System.EventHandler(this.dept_edit_btn_Click);
            // 
            // dept_deactivate_btn
            // 
            this.dept_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_deactivate_btn.Image")));
            this.dept_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_deactivate_btn.Name = "dept_deactivate_btn";
            this.dept_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_deactivate_btn.ToolTipText = "Deactivate record";
            this.dept_deactivate_btn.Click += new System.EventHandler(this.dept_deactivate_btn_Click);
            // 
            // dept_activate_btn
            // 
            this.dept_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_activate_btn.Image")));
            this.dept_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_activate_btn.Name = "dept_activate_btn";
            this.dept_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_activate_btn.ToolTipText = "Activate record";
            this.dept_activate_btn.Click += new System.EventHandler(this.dept_activate_btn_Click);
            // 
            // dept_print_btn
            // 
            this.dept_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_print_btn.Image")));
            this.dept_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_print_btn.Name = "dept_print_btn";
            this.dept_print_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_print_btn.ToolTipText = "Print record";
            this.dept_print_btn.Click += new System.EventHandler(this.dept_print_btn_Click);
            // 
            // dept_save_btn
            // 
            this.dept_save_btn.Enabled = false;
            this.dept_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_save_btn.Image")));
            this.dept_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_save_btn.Name = "dept_save_btn";
            this.dept_save_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_save_btn.ToolTipText = "save record";
            this.dept_save_btn.Click += new System.EventHandler(this.dept_Save_btn_click);
            // 
            // dept_cancel_btn
            // 
            this.dept_cancel_btn.Enabled = false;
            this.dept_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_cancel_btn.Image")));
            this.dept_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dept_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dept_cancel_btn.Name = "dept_cancel_btn";
            this.dept_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.dept_cancel_btn.ToolTipText = "cancel record";
            this.dept_cancel_btn.Click += new System.EventHandler(this.dept_cancel_btn_Click);
            // 
            // deptLsvList
            // 
            this.deptLsvList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deptLsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6});
            this.deptLsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deptLsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLsvList.FullRowSelect = true;
            this.deptLsvList.GridLines = true;
            this.deptLsvList.Location = new System.Drawing.Point(0, 288);
            this.deptLsvList.Name = "deptLsvList";
            this.deptLsvList.Size = new System.Drawing.Size(638, 235);
            this.deptLsvList.TabIndex = 1111;
            this.deptLsvList.UseCompatibleStateImageBehavior = false;
            this.deptLsvList.View = System.Windows.Forms.View.Details;
            this.deptLsvList.SelectedIndexChanged += new System.EventHandler(this.deptLsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Department";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Created";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 115;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1062;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1097;
            this.label3.Text = "Filter Department :";
            // 
            // txtdeptFilter
            // 
            this.txtdeptFilter.BackColor = System.Drawing.Color.White;
            this.txtdeptFilter.Location = new System.Drawing.Point(112, 265);
            this.txtdeptFilter.Name = "txtdeptFilter";
            this.txtdeptFilter.Size = new System.Drawing.Size(507, 21);
            this.txtdeptFilter.TabIndex = 1096;
            this.btxMsg.SetText(this.txtdeptFilter, null);
            this.btxMsg.SetTitle(this.txtdeptFilter, null);
            this.txtdeptFilter.TextChanged += new System.EventHandler(this.txtDepartmentfilter);
            this.txtdeptFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepartment_Keydown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1093;
            this.label6.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1092;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(373, 187);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 21);
            this.txtDatecreated.TabIndex = 1092;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1091;
            this.label5.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(373, 162);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 21);
            this.txtUsercreated.TabIndex = 1091;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(373, 137);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 21);
            this.txtStatus.TabIndex = 1090;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // txtdeptCode
            // 
            this.txtdeptCode.BackColor = System.Drawing.Color.White;
            this.txtdeptCode.Location = new System.Drawing.Point(372, 90);
            this.txtdeptCode.Name = "txtdeptCode";
            this.txtdeptCode.ReadOnly = true;
            this.txtdeptCode.Size = new System.Drawing.Size(150, 21);
            this.txtdeptCode.TabIndex = 1087;
            this.btxMsg.SetText(this.txtdeptCode, "Department cannot be blanked");
            this.btxMsg.SetTitle(this.txtdeptCode, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1086;
            this.label1.Text = "Department :";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(372, 114);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(150, 21);
            this.txtCompany.TabIndex = 1088;
            this.btxMsg.SetText(this.txtCompany, null);
            this.btxMsg.SetTitle(this.txtCompany, null);
            this.txtCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompany_Keydwn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1099;
            this.label2.Text = "Company :";
            // 
            // dept_search_btn
            // 
            this.dept_search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.dept_search_btn.Enabled = false;
            this.dept_search_btn.FlatAppearance.BorderSize = 0;
            this.dept_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dept_search_btn.ForeColor = System.Drawing.Color.White;
            this.dept_search_btn.Image = ((System.Drawing.Image)(resources.GetObject("dept_search_btn.Image")));
            this.dept_search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dept_search_btn.Location = new System.Drawing.Point(523, 113);
            this.dept_search_btn.Name = "dept_search_btn";
            this.dept_search_btn.Size = new System.Drawing.Size(96, 21);
            this.dept_search_btn.TabIndex = 1089;
            this.dept_search_btn.Text = "      Search";
            this.dept_search_btn.UseVisualStyleBackColor = false;
            this.dept_search_btn.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label8);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 523);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(638, 25);
            this.panFoot.TabIndex = 1104;
            this.panFoot.Paint += new System.Windows.Forms.PaintEventHandler(this.panFoot_Paint);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 23);
            this.label8.TabIndex = 849;
            this.label8.Text = "Press Esc to close this form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DepartmentNewMasterform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 548);
            this.Controls.Add(this.dept_search_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdeptFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtdeptCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deptLsvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DepartmentNewMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Masterfile";
            this.Load += new System.EventHandler(this.DepartmentMasterfile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.departmentMasterform_keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton dept_add_btn;
        private System.Windows.Forms.ToolStripButton dept_edit_btn;
        private System.Windows.Forms.ToolStripButton dept_deactivate_btn;
        private System.Windows.Forms.ToolStripButton dept_activate_btn;
        private System.Windows.Forms.ToolStripButton dept_print_btn;
        private System.Windows.Forms.ToolStripButton dept_save_btn;
        private System.Windows.Forms.ToolStripButton dept_cancel_btn;
        private System.Windows.Forms.ListView deptLsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdeptFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtdeptCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dept_search_btn;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label8;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}