namespace AMS.MasterFile
{
    partial class EmployeeMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.emp_add_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_print_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_save_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emplsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_company = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emp_add_btn,
            this.emp_edit_btn,
            this.emp_deactivate_btn,
            this.emp_activate_btn,
            this.emp_print_btn,
            this.emp_save_btn,
            this.emp_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 39);
            this.toolStrip1.TabIndex = 1051;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // emp_add_btn
            // 
            this.emp_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_add_btn.Image")));
            this.emp_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_add_btn.Name = "emp_add_btn";
            this.emp_add_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_add_btn.ToolTipText = "add record";
            this.emp_add_btn.Click += new System.EventHandler(this.emp_add_btn_Click);
            // 
            // emp_edit_btn
            // 
            this.emp_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_edit_btn.Image")));
            this.emp_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_edit_btn.Name = "emp_edit_btn";
            this.emp_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_edit_btn.ToolTipText = "Edit record";
            this.emp_edit_btn.Click += new System.EventHandler(this.emp_edit_btn_Click);
            // 
            // emp_deactivate_btn
            // 
            this.emp_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_deactivate_btn.Image")));
            this.emp_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_deactivate_btn.Name = "emp_deactivate_btn";
            this.emp_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_deactivate_btn.ToolTipText = "Deactivate record";
            this.emp_deactivate_btn.Click += new System.EventHandler(this.emp_deactivate_btn_Click);
            // 
            // emp_activate_btn
            // 
            this.emp_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_activate_btn.Image")));
            this.emp_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_activate_btn.Name = "emp_activate_btn";
            this.emp_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_activate_btn.ToolTipText = "Activate record";
            this.emp_activate_btn.Click += new System.EventHandler(this.emp_activate_btn_Click);
            // 
            // emp_print_btn
            // 
            this.emp_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_print_btn.Image")));
            this.emp_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_print_btn.Name = "emp_print_btn";
            this.emp_print_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_print_btn.ToolTipText = "Print record";
            this.emp_print_btn.Click += new System.EventHandler(this.emp_print_btn_Click);
            // 
            // emp_save_btn
            // 
            this.emp_save_btn.Enabled = false;
            this.emp_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_save_btn.Image")));
            this.emp_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_save_btn.Name = "emp_save_btn";
            this.emp_save_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_save_btn.ToolTipText = "save record";
            this.emp_save_btn.Click += new System.EventHandler(this.emp_save_btn_Click);
            // 
            // emp_cancel_btn
            // 
            this.emp_cancel_btn.Enabled = false;
            this.emp_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_cancel_btn.Image")));
            this.emp_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_cancel_btn.Name = "emp_cancel_btn";
            this.emp_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_cancel_btn.ToolTipText = "cancel record";
            this.emp_cancel_btn.Click += new System.EventHandler(this.emp_cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1052;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1053;
            this.label2.Text = "Middle Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1054;
            this.label3.Text = "Last Name:";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(289, 42);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(361, 21);
            this.txtfname.TabIndex = 0;
            this.btxMsg.SetText(this.txtfname, null);
            this.btxMsg.SetTitle(this.txtfname, null);
            this.txtfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(289, 69);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(361, 21);
            this.txtmname.TabIndex = 1;
            this.btxMsg.SetText(this.txtmname, null);
            this.btxMsg.SetTitle(this.txtmname, null);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(289, 96);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(361, 21);
            this.txtlname.TabIndex = 2;
            this.btxMsg.SetText(this.txtlname, null);
            this.btxMsg.SetTitle(this.txtlname, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1058;
            this.label4.Text = "Company:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // emplsvList
            // 
            this.emplsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader4});
            this.emplsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.emplsvList.FullRowSelect = true;
            this.emplsvList.GridLines = true;
            this.emplsvList.Location = new System.Drawing.Point(0, 231);
            this.emplsvList.Name = "emplsvList";
            this.emplsvList.Size = new System.Drawing.Size(728, 279);
            this.emplsvList.TabIndex = 1060;
            this.emplsvList.UseCompatibleStateImageBehavior = false;
            this.emplsvList.View = System.Windows.Forms.View.Details;
            this.emplsvList.SelectedIndexChanged += new System.EventHandler(this.emplsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Middle Name";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last Name";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Company";
            this.columnHeader7.Width = 139;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 93;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Created";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 87;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1063;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1069;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1068;
            this.label5.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(289, 204);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 21);
            this.txtDatecreated.TabIndex = 6;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1067;
            this.label7.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(289, 177);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 21);
            this.txtUsercreated.TabIndex = 5;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(289, 150);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 21);
            this.txtStatus.TabIndex = 4;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(289, 123);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(259, 21);
            this.txtCompanyName.TabIndex = 1081;
            this.btxMsg.SetText(this.txtCompanyName, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtCompanyName, null);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label8);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 510);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(728, 25);
            this.panFoot.TabIndex = 1080;
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
            // btn_company
            // 
            this.btn_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_company.Enabled = false;
            this.btn_company.FlatAppearance.BorderSize = 0;
            this.btn_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_company.ForeColor = System.Drawing.Color.White;
            this.btn_company.Image = ((System.Drawing.Image)(resources.GetObject("btn_company.Image")));
            this.btn_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company.Location = new System.Drawing.Point(554, 123);
            this.btn_company.Name = "btn_company";
            this.btn_company.Size = new System.Drawing.Size(96, 21);
            this.btn_company.TabIndex = 1082;
            this.btn_company.Text = "      Search";
            this.btn_company.UseVisualStyleBackColor = false;
            this.btn_company.Click += new System.EventHandler(this.btn_company_Click);
            // 
            // EmployeeMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(728, 535);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.btn_company);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.emplsvList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EmployeeMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master File";
            this.Load += new System.EventHandler(this.EmployeeMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeMasterform_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton emp_add_btn;
        private System.Windows.Forms.ToolStripButton emp_edit_btn;
        private System.Windows.Forms.ToolStripButton emp_deactivate_btn;
        private System.Windows.Forms.ToolStripButton emp_activate_btn;
        private System.Windows.Forms.ToolStripButton emp_print_btn;
        private System.Windows.Forms.ToolStripButton emp_save_btn;
        private System.Windows.Forms.ToolStripButton emp_cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView emplsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btn_company;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}