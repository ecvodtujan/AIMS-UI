namespace AMS.MasterFile
{
    partial class ItemTypeMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemTypeMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.itm_add_btn = new System.Windows.Forms.ToolStripButton();
            this.itm_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.itm_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.itm_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.itm_print_btn = new System.Windows.Forms.ToolStripButton();
            this.itm_save_btn = new System.Windows.Forms.ToolStripButton();
            this.itm_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.itemlsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtItmDesc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItmDCrtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItmUCrtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItmStat = new System.Windows.Forms.TextBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtItemFilter = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itm_add_btn,
            this.itm_edit_btn,
            this.itm_deactivate_btn,
            this.itm_activate_btn,
            this.itm_print_btn,
            this.itm_save_btn,
            this.itm_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 39);
            this.toolStrip1.TabIndex = 1050;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // itm_add_btn
            // 
            this.itm_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_add_btn.Image")));
            this.itm_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_add_btn.Name = "itm_add_btn";
            this.itm_add_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_add_btn.ToolTipText = "add record";
            this.itm_add_btn.Click += new System.EventHandler(this.itm_add_btn_Click);
            // 
            // itm_edit_btn
            // 
            this.itm_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_edit_btn.Image")));
            this.itm_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_edit_btn.Name = "itm_edit_btn";
            this.itm_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_edit_btn.ToolTipText = "Edit record";
            this.itm_edit_btn.Click += new System.EventHandler(this.itm_edit_btn_Click);
            // 
            // itm_deactivate_btn
            // 
            this.itm_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_deactivate_btn.Image")));
            this.itm_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_deactivate_btn.Name = "itm_deactivate_btn";
            this.itm_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_deactivate_btn.ToolTipText = "Deactivate record";
            this.itm_deactivate_btn.Click += new System.EventHandler(this.itm_deactivate_btn_Click);
            // 
            // itm_activate_btn
            // 
            this.itm_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_activate_btn.Image")));
            this.itm_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_activate_btn.Name = "itm_activate_btn";
            this.itm_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_activate_btn.ToolTipText = "Activate record";
            this.itm_activate_btn.Click += new System.EventHandler(this.itm_activate_btn_Click);
            // 
            // itm_print_btn
            // 
            this.itm_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_print_btn.Image")));
            this.itm_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_print_btn.Name = "itm_print_btn";
            this.itm_print_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_print_btn.ToolTipText = "Print record";
            this.itm_print_btn.Click += new System.EventHandler(this.itm_print_btn_Click);
            // 
            // itm_save_btn
            // 
            this.itm_save_btn.Enabled = false;
            this.itm_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_save_btn.Image")));
            this.itm_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_save_btn.Name = "itm_save_btn";
            this.itm_save_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_save_btn.ToolTipText = "save record";
            this.itm_save_btn.Click += new System.EventHandler(this.itm_save_btn_Click);
            // 
            // itm_cancel_btn
            // 
            this.itm_cancel_btn.Enabled = false;
            this.itm_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("itm_cancel_btn.Image")));
            this.itm_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itm_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itm_cancel_btn.Name = "itm_cancel_btn";
            this.itm_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.itm_cancel_btn.ToolTipText = "cancel record";
            this.itm_cancel_btn.Click += new System.EventHandler(this.itm_cancel_btn_Click);
            // 
            // itemlsvList
            // 
            this.itemlsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6});
            this.itemlsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemlsvList.FullRowSelect = true;
            this.itemlsvList.GridLines = true;
            this.itemlsvList.Location = new System.Drawing.Point(0, 269);
            this.itemlsvList.Name = "itemlsvList";
            this.itemlsvList.Size = new System.Drawing.Size(640, 198);
            this.itemlsvList.TabIndex = 1060;
            this.itemlsvList.UseCompatibleStateImageBehavior = false;
            this.itemlsvList.View = System.Windows.Forms.View.Details;
            this.itemlsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Item Code";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Description";
            this.columnHeader3.Width = 206;
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
            // txtItmDesc
            // 
            this.txtItmDesc.BackColor = System.Drawing.Color.White;
            this.txtItmDesc.Location = new System.Drawing.Point(273, 95);
            this.txtItmDesc.Name = "txtItmDesc";
            this.txtItmDesc.ReadOnly = true;
            this.txtItmDesc.Size = new System.Drawing.Size(224, 21);
            this.txtItmDesc.TabIndex = 1054;
            this.btxMsg.SetText(this.txtItmDesc, null);
            this.btxMsg.SetTitle(this.txtItmDesc, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1056;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1062;
            this.label4.Text = "Date Created :";
            // 
            // txtItmDCrtd
            // 
            this.txtItmDCrtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtItmDCrtd.Location = new System.Drawing.Point(273, 176);
            this.txtItmDCrtd.Name = "txtItmDCrtd";
            this.txtItmDCrtd.ReadOnly = true;
            this.txtItmDCrtd.Size = new System.Drawing.Size(102, 21);
            this.txtItmDCrtd.TabIndex = 1059;
            this.btxMsg.SetText(this.txtItmDCrtd, null);
            this.txtItmDCrtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtItmDCrtd, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1061;
            this.label3.Text = "User Created :";
            // 
            // txtItmUCrtd
            // 
            this.txtItmUCrtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtItmUCrtd.Location = new System.Drawing.Point(273, 149);
            this.txtItmUCrtd.Name = "txtItmUCrtd";
            this.txtItmUCrtd.ReadOnly = true;
            this.txtItmUCrtd.Size = new System.Drawing.Size(102, 21);
            this.txtItmUCrtd.TabIndex = 1058;
            this.btxMsg.SetText(this.txtItmUCrtd, null);
            this.txtItmUCrtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtItmUCrtd, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1060;
            this.label2.Text = "Status :";
            // 
            // txtItmStat
            // 
            this.txtItmStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtItmStat.Location = new System.Drawing.Point(273, 122);
            this.txtItmStat.Name = "txtItmStat";
            this.txtItmStat.ReadOnly = true;
            this.txtItmStat.Size = new System.Drawing.Size(102, 21);
            this.txtItmStat.TabIndex = 1057;
            this.btxMsg.SetText(this.txtItmStat, null);
            this.txtItmStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtItmStat, null);
            // 
            // txtItemFilter
            // 
            this.txtItemFilter.BackColor = System.Drawing.Color.White;
            this.txtItemFilter.Location = new System.Drawing.Point(91, 241);
            this.txtItemFilter.Name = "txtItemFilter";
            this.txtItemFilter.Size = new System.Drawing.Size(284, 21);
            this.txtItemFilter.TabIndex = 1081;
            this.btxMsg.SetText(this.txtItemFilter, null);
            this.btxMsg.SetTitle(this.txtItemFilter, null);
            this.txtItemFilter.TextChanged += new System.EventHandler(this.txtItemFilter_TextChanged);
            this.txtItemFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemFilter_Keydown);
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.White;
            this.txtItemCode.Location = new System.Drawing.Point(272, 68);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(102, 21);
            this.txtItemCode.TabIndex = 1053;
            this.btxMsg.SetText(this.txtItemCode, "Item Code cannot be blanked");
            this.btxMsg.SetTitle(this.txtItemCode, null);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label5);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 467);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(640, 25);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1052;
            this.label1.Text = "Item Description:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1082;
            this.label6.Text = "Filter Item :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1084;
            this.label7.Text = "Item Code :";
            // 
            // ItemTypeMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 492);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItmDCrtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItmUCrtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItmStat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtItmDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemlsvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ItemTypeMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Type Master File";
            this.Load += new System.EventHandler(this.ItemTypeMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemTypeMasterform_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton itm_add_btn;
        private System.Windows.Forms.ToolStripButton itm_edit_btn;
        private System.Windows.Forms.ToolStripButton itm_deactivate_btn;
        private System.Windows.Forms.ToolStripButton itm_activate_btn;
        private System.Windows.Forms.ToolStripButton itm_print_btn;
        private System.Windows.Forms.ToolStripButton itm_save_btn;
        private System.Windows.Forms.ToolStripButton itm_cancel_btn;
        private System.Windows.Forms.ListView itemlsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtItmDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItmDCrtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItmUCrtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItmStat;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}