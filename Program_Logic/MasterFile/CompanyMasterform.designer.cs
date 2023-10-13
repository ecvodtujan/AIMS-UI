namespace AMS.MasterFile
{
    partial class CompanyMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmp_add_btn = new System.Windows.Forms.ToolStripButton();
            this.cmp_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.cmp_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.cmp_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.cmp_print_btn = new System.Windows.Forms.ToolStripButton();
            this.cmp_save_btn = new System.Windows.Forms.ToolStripButton();
            this.cmp_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.complsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcompCode = new System.Windows.Forms.TextBox();
            this.txtcompName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmp_add_btn,
            this.cmp_edit_btn,
            this.cmp_deactivate_btn,
            this.cmp_activate_btn,
            this.cmp_print_btn,
            this.cmp_save_btn,
            this.cmp_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 39);
            this.toolStrip1.TabIndex = 1052;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmp_add_btn
            // 
            this.cmp_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_add_btn.Image")));
            this.cmp_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_add_btn.Name = "cmp_add_btn";
            this.cmp_add_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_add_btn.ToolTipText = "add record";
            this.cmp_add_btn.Click += new System.EventHandler(this.cmp_add_btn_Click);
            // 
            // cmp_edit_btn
            // 
            this.cmp_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_edit_btn.Image")));
            this.cmp_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_edit_btn.Name = "cmp_edit_btn";
            this.cmp_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_edit_btn.ToolTipText = "Edit record";
            this.cmp_edit_btn.Click += new System.EventHandler(this.cmp_edit_btn_Click);
            // 
            // cmp_deactivate_btn
            // 
            this.cmp_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_deactivate_btn.Image")));
            this.cmp_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_deactivate_btn.Name = "cmp_deactivate_btn";
            this.cmp_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_deactivate_btn.ToolTipText = "Deactivate record";
            this.cmp_deactivate_btn.Click += new System.EventHandler(this.cmp_deactivate_btn_Click);
            // 
            // cmp_activate_btn
            // 
            this.cmp_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_activate_btn.Image")));
            this.cmp_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_activate_btn.Name = "cmp_activate_btn";
            this.cmp_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_activate_btn.ToolTipText = "Activate record";
            this.cmp_activate_btn.Click += new System.EventHandler(this.cmp_activate_btn_Click);
            // 
            // cmp_print_btn
            // 
            this.cmp_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_print_btn.Image")));
            this.cmp_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_print_btn.Name = "cmp_print_btn";
            this.cmp_print_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_print_btn.ToolTipText = "Print record";
            this.cmp_print_btn.Click += new System.EventHandler(this.cmp_print_btn_Click);
            // 
            // cmp_save_btn
            // 
            this.cmp_save_btn.Enabled = false;
            this.cmp_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_save_btn.Image")));
            this.cmp_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_save_btn.Name = "cmp_save_btn";
            this.cmp_save_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_save_btn.ToolTipText = "save record";
            this.cmp_save_btn.Click += new System.EventHandler(this.cmp_save_btn_Click);
            // 
            // cmp_cancel_btn
            // 
            this.cmp_cancel_btn.Enabled = false;
            this.cmp_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("cmp_cancel_btn.Image")));
            this.cmp_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmp_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmp_cancel_btn.Name = "cmp_cancel_btn";
            this.cmp_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.cmp_cancel_btn.ToolTipText = "cancel record";
            this.cmp_cancel_btn.Click += new System.EventHandler(this.cmp_cancel_btn_Click);
            // 
            // complsvList
            // 
            this.complsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6});
            this.complsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.complsvList.FullRowSelect = true;
            this.complsvList.GridLines = true;
            this.complsvList.Location = new System.Drawing.Point(0, 199);
            this.complsvList.Name = "complsvList";
            this.complsvList.Size = new System.Drawing.Size(616, 262);
            this.complsvList.TabIndex = 1053;
            this.complsvList.UseCompatibleStateImageBehavior = false;
            this.complsvList.View = System.Windows.Forms.View.Details;
            this.complsvList.SelectedIndexChanged += new System.EventHandler(this.complsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Code";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company Name";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Created";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1054;
            this.label1.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1055;
            this.label2.Text = "Company Name :";
            // 
            // txtcompCode
            // 
            this.txtcompCode.BackColor = System.Drawing.Color.White;
            this.txtcompCode.Location = new System.Drawing.Point(289, 46);
            this.txtcompCode.Name = "txtcompCode";
            this.txtcompCode.ReadOnly = true;
            this.txtcompCode.Size = new System.Drawing.Size(150, 21);
            this.txtcompCode.TabIndex = 1057;
            this.btxMsg.SetText(this.txtcompCode, "Code Cannot be blanked");
            this.btxMsg.SetTitle(this.txtcompCode, null);
            // 
            // txtcompName
            // 
            this.txtcompName.BackColor = System.Drawing.Color.White;
            this.txtcompName.Location = new System.Drawing.Point(289, 73);
            this.txtcompName.Name = "txtcompName";
            this.txtcompName.ReadOnly = true;
            this.txtcompName.Size = new System.Drawing.Size(288, 21);
            this.txtcompName.TabIndex = 1058;
            this.btxMsg.SetText(this.txtcompName, null);
            this.btxMsg.SetTitle(this.txtcompName, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1060;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1069;
            this.label6.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1068;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(289, 154);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 21);
            this.txtDatecreated.TabIndex = 1066;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1067;
            this.label5.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(289, 127);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 21);
            this.txtUsercreated.TabIndex = 1065;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(289, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 21);
            this.txtStatus.TabIndex = 1064;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label3);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 461);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(616, 25);
            this.panFoot.TabIndex = 1080;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 849;
            this.label3.Text = "Press Esc to close this form";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompanyMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 486);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcompName);
            this.Controls.Add(this.txtcompCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complsvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CompanyMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Master File";
            this.Load += new System.EventHandler(this.CompanyMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyMasterform_Keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmp_add_btn;
        private System.Windows.Forms.ToolStripButton cmp_edit_btn;
        private System.Windows.Forms.ToolStripButton cmp_deactivate_btn;
        private System.Windows.Forms.ToolStripButton cmp_activate_btn;
        private System.Windows.Forms.ToolStripButton cmp_print_btn;
        private System.Windows.Forms.ToolStripButton cmp_save_btn;
        private System.Windows.Forms.ToolStripButton cmp_cancel_btn;
        private System.Windows.Forms.ListView complsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcompCode;
        private System.Windows.Forms.TextBox txtcompName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label3;
    }
}