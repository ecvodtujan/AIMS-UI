namespace AMS.MasterFile
{
    partial class SupplierMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.supp_add_btn = new System.Windows.Forms.ToolStripButton();
            this.supp_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.supp_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.supp_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.supp_print_btn = new System.Windows.Forms.ToolStripButton();
            this.supp_save_btn = new System.Windows.Forms.ToolStripButton();
            this.supp_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.supplsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtsuppName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsuppTin = new System.Windows.Forms.TextBox();
            this.txtsuppCon = new System.Windows.Forms.TextBox();
            this.txtsuppConp = new System.Windows.Forms.TextBox();
            this.txtsuppAdd = new System.Windows.Forms.TextBox();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtSuppFilter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supp_add_btn,
            this.supp_edit_btn,
            this.supp_deactivate_btn,
            this.supp_activate_btn,
            this.supp_print_btn,
            this.supp_save_btn,
            this.supp_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 39);
            this.toolStrip1.TabIndex = 1053;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // supp_add_btn
            // 
            this.supp_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_add_btn.Image")));
            this.supp_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_add_btn.Name = "supp_add_btn";
            this.supp_add_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_add_btn.ToolTipText = "add record";
            this.supp_add_btn.Click += new System.EventHandler(this.supp_add_btn_Click);
            // 
            // supp_edit_btn
            // 
            this.supp_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_edit_btn.Image")));
            this.supp_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_edit_btn.Name = "supp_edit_btn";
            this.supp_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_edit_btn.ToolTipText = "Edit record";
            this.supp_edit_btn.Click += new System.EventHandler(this.supp_edit_btn_Click);
            // 
            // supp_deactivate_btn
            // 
            this.supp_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_deactivate_btn.Image")));
            this.supp_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_deactivate_btn.Name = "supp_deactivate_btn";
            this.supp_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_deactivate_btn.ToolTipText = "Deactivate record";
            this.supp_deactivate_btn.Click += new System.EventHandler(this.supp_deactivate_btn_Click);
            // 
            // supp_activate_btn
            // 
            this.supp_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_activate_btn.Image")));
            this.supp_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_activate_btn.Name = "supp_activate_btn";
            this.supp_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_activate_btn.ToolTipText = "Activate record";
            this.supp_activate_btn.Click += new System.EventHandler(this.supp_activate_btn_Click);
            // 
            // supp_print_btn
            // 
            this.supp_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_print_btn.Image")));
            this.supp_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_print_btn.Name = "supp_print_btn";
            this.supp_print_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_print_btn.ToolTipText = "Print record";
            this.supp_print_btn.Click += new System.EventHandler(this.supp_print_btn_Click);
            // 
            // supp_save_btn
            // 
            this.supp_save_btn.Enabled = false;
            this.supp_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_save_btn.Image")));
            this.supp_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_save_btn.Name = "supp_save_btn";
            this.supp_save_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_save_btn.ToolTipText = "save record";
            this.supp_save_btn.Click += new System.EventHandler(this.supp_save_btn_Click);
            // 
            // supp_cancel_btn
            // 
            this.supp_cancel_btn.Enabled = false;
            this.supp_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("supp_cancel_btn.Image")));
            this.supp_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supp_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.supp_cancel_btn.Name = "supp_cancel_btn";
            this.supp_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.supp_cancel_btn.ToolTipText = "cancel record";
            this.supp_cancel_btn.Click += new System.EventHandler(this.supp_cancel_btn_Click);
            // 
            // supplsvList
            // 
            this.supplsvList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.supplsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.supplsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.supplsvList.FullRowSelect = true;
            this.supplsvList.GridLines = true;
            this.supplsvList.Location = new System.Drawing.Point(0, 244);
            this.supplsvList.Name = "supplsvList";
            this.supplsvList.Size = new System.Drawing.Size(813, 244);
            this.supplsvList.TabIndex = 1080;
            this.supplsvList.UseCompatibleStateImageBehavior = false;
            this.supplsvList.View = System.Windows.Forms.View.Details;
            this.supplsvList.SelectedIndexChanged += new System.EventHandler(this.supplsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Supplier Name";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 162;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TIN";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact No";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contact Person";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "User Created";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 85;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date Created";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 91;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1061;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1079;
            this.label6.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1078;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(667, 103);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(134, 21);
            this.txtDatecreated.TabIndex = 1079;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1077;
            this.label5.Text = "User Created :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(667, 79);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(134, 21);
            this.txtUsercreated.TabIndex = 1078;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(667, 55);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(134, 21);
            this.txtStatus.TabIndex = 1077;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // txtsuppName
            // 
            this.txtsuppName.BackColor = System.Drawing.Color.White;
            this.txtsuppName.Location = new System.Drawing.Point(280, 55);
            this.txtsuppName.Name = "txtsuppName";
            this.txtsuppName.ReadOnly = true;
            this.txtsuppName.Size = new System.Drawing.Size(179, 21);
            this.txtsuppName.TabIndex = 1072;
            this.btxMsg.SetText(this.txtsuppName, "Supplier Name cannot be blanked");
            this.btxMsg.SetTitle(this.txtsuppName, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1071;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1070;
            this.label1.Text = "Supplier Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1080;
            this.label3.Text = "TIN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1081;
            this.label7.Text = "Contact No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 1082;
            this.label8.Text = "Contact Person:";
            // 
            // txtsuppTin
            // 
            this.txtsuppTin.BackColor = System.Drawing.Color.White;
            this.txtsuppTin.Location = new System.Drawing.Point(280, 127);
            this.txtsuppTin.Name = "txtsuppTin";
            this.txtsuppTin.ReadOnly = true;
            this.txtsuppTin.Size = new System.Drawing.Size(179, 21);
            this.txtsuppTin.TabIndex = 1074;
            this.btxMsg.SetText(this.txtsuppTin, null);
            this.btxMsg.SetTitle(this.txtsuppTin, null);
            // 
            // txtsuppCon
            // 
            this.txtsuppCon.BackColor = System.Drawing.Color.White;
            this.txtsuppCon.Location = new System.Drawing.Point(280, 149);
            this.txtsuppCon.Name = "txtsuppCon";
            this.txtsuppCon.ReadOnly = true;
            this.txtsuppCon.Size = new System.Drawing.Size(179, 21);
            this.txtsuppCon.TabIndex = 1075;
            this.btxMsg.SetText(this.txtsuppCon, null);
            this.btxMsg.SetTitle(this.txtsuppCon, null);
            // 
            // txtsuppConp
            // 
            this.txtsuppConp.BackColor = System.Drawing.Color.White;
            this.txtsuppConp.Location = new System.Drawing.Point(280, 172);
            this.txtsuppConp.Name = "txtsuppConp";
            this.txtsuppConp.ReadOnly = true;
            this.txtsuppConp.Size = new System.Drawing.Size(179, 21);
            this.txtsuppConp.TabIndex = 1076;
            this.btxMsg.SetText(this.txtsuppConp, null);
            this.btxMsg.SetTitle(this.txtsuppConp, null);
            // 
            // txtsuppAdd
            // 
            this.txtsuppAdd.BackColor = System.Drawing.Color.White;
            this.txtsuppAdd.Location = new System.Drawing.Point(280, 78);
            this.txtsuppAdd.Multiline = true;
            this.txtsuppAdd.Name = "txtsuppAdd";
            this.txtsuppAdd.ReadOnly = true;
            this.txtsuppAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsuppAdd.Size = new System.Drawing.Size(266, 47);
            this.txtsuppAdd.TabIndex = 1073;
            this.btxMsg.SetText(this.txtsuppAdd, null);
            this.btxMsg.SetTitle(this.txtsuppAdd, null);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label9);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 488);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(813, 25);
            this.panFoot.TabIndex = 1087;
            this.panFoot.Paint += new System.Windows.Forms.PaintEventHandler(this.panFoot_Paint);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 23);
            this.label9.TabIndex = 849;
            this.label9.Text = "Press Esc to close this form";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSuppFilter
            // 
            this.txtSuppFilter.BackColor = System.Drawing.Color.White;
            this.txtSuppFilter.Location = new System.Drawing.Point(121, 217);
            this.txtSuppFilter.Name = "txtSuppFilter";
            this.txtSuppFilter.Size = new System.Drawing.Size(338, 21);
            this.txtSuppFilter.TabIndex = 1088;
            this.btxMsg.SetText(this.txtSuppFilter, null);
            this.btxMsg.SetTitle(this.txtSuppFilter, null);
            this.txtSuppFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSuppFilter_Keydown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 1089;
            this.label10.Text = "Filter Supplier:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // SupplierMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 513);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSuppFilter);
            this.Controls.Add(this.supplsvList);
            this.Controls.Add(this.panFoot);
            this.Controls.Add(this.txtsuppAdd);
            this.Controls.Add(this.txtsuppConp);
            this.Controls.Add(this.txtsuppCon);
            this.Controls.Add(this.txtsuppTin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtsuppName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SupplierMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Master File";
            this.Load += new System.EventHandler(this.SupplierMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierMasterform_Keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton supp_add_btn;
        private System.Windows.Forms.ToolStripButton supp_edit_btn;
        private System.Windows.Forms.ToolStripButton supp_deactivate_btn;
        private System.Windows.Forms.ToolStripButton supp_activate_btn;
        private System.Windows.Forms.ToolStripButton supp_print_btn;
        private System.Windows.Forms.ToolStripButton supp_save_btn;
        private System.Windows.Forms.ToolStripButton supp_cancel_btn;
        private System.Windows.Forms.ListView supplsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtsuppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsuppTin;
        private System.Windows.Forms.TextBox txtsuppCon;
        private System.Windows.Forms.TextBox txtsuppConp;
        private System.Windows.Forms.TextBox txtsuppAdd;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label9;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.TextBox txtSuppFilter;
        private System.Windows.Forms.Label label10;
    }
}