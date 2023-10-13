namespace AMS.MasterFile
{
    partial class BrandMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandMasterform));
            this.lsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBrandname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_btn = new System.Windows.Forms.ToolStripButton();
            this.edit_btn = new System.Windows.Forms.ToolStripButton();
            this.deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.activate_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtBrandFilter = new System.Windows.Forms.TextBox();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvList
            // 
            this.lsvList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 215);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(556, 206);
            this.lsvList.TabIndex = 1046;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Brand name";
            this.columnHeader3.Width = 222;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Created";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 113;
            // 
            // txtBrandname
            // 
            this.txtBrandname.BackColor = System.Drawing.Color.White;
            this.txtBrandname.Location = new System.Drawing.Point(275, 46);
            this.txtBrandname.Name = "txtBrandname";
            this.txtBrandname.ReadOnly = true;
            this.txtBrandname.Size = new System.Drawing.Size(213, 21);
            this.txtBrandname.TabIndex = 0;
            this.btxMsg.SetText(this.txtBrandname, "Brand name cannot be blanked");
            this.btxMsg.SetTitle(this.txtBrandname, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1048;
            this.label1.Text = "Brand Name :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_btn,
            this.edit_btn,
            this.deactivate_btn,
            this.activate_btn,
            this.print_btn,
            this.save_btn,
            this.cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 39);
            this.toolStrip1.TabIndex = 1049;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_btn
            // 
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(36, 36);
            this.add_btn.ToolTipText = "add record";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(36, 36);
            this.edit_btn.ToolTipText = "Edit record";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // deactivate_btn
            // 
            this.deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("deactivate_btn.Image")));
            this.deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deactivate_btn.Name = "deactivate_btn";
            this.deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.deactivate_btn.ToolTipText = "Deactivate record";
            this.deactivate_btn.Click += new System.EventHandler(this.deactivate_btn_Click);
            // 
            // activate_btn
            // 
            this.activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("activate_btn.Image")));
            this.activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.activate_btn.Name = "activate_btn";
            this.activate_btn.Size = new System.Drawing.Size(36, 36);
            this.activate_btn.ToolTipText = "Activate record";
            this.activate_btn.Click += new System.EventHandler(this.activate_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.ToolTipText = "Print record";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Enabled = false;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(36, 36);
            this.save_btn.ToolTipText = "save record";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Enabled = false;
            this.cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancel_btn.Image")));
            this.cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.cancel_btn.ToolTipText = "cancel record";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(30, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 131);
            this.pictureBox1.TabIndex = 1050;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1052;
            this.label2.Text = "Status :";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(275, 73);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 21);
            this.txtStatus.TabIndex = 1;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1054;
            this.label3.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(275, 100);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 21);
            this.txtUsercreated.TabIndex = 2;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1056;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(275, 127);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 21);
            this.txtDatecreated.TabIndex = 3;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // txtBrandFilter
            // 
            this.txtBrandFilter.BackColor = System.Drawing.Color.White;
            this.txtBrandFilter.Location = new System.Drawing.Point(93, 188);
            this.txtBrandFilter.Name = "txtBrandFilter";
            this.txtBrandFilter.Size = new System.Drawing.Size(288, 21);
            this.txtBrandFilter.TabIndex = 1081;
            this.btxMsg.SetText(this.txtBrandFilter, "Brand name cannot be blank");
            this.btxMsg.SetTitle(this.txtBrandFilter, null);
            this.txtBrandFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBrandFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandFilter_Keydown);
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
            this.panFoot.Size = new System.Drawing.Size(556, 25);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1083;
            this.label6.Text = "Filter Brand:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BrandMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrandFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrandname);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BrandMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brand Master file";
            this.Load += new System.EventHandler(this.BrandMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BrandMasterform_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtBrandname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton add_btn;
        private System.Windows.Forms.ToolStripButton edit_btn;
        private System.Windows.Forms.ToolStripButton deactivate_btn;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripButton save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStripButton activate_btn;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrandFilter;
        private System.Windows.Forms.Label label6;
    }
}