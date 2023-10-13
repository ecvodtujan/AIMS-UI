namespace AMS.MasterFile
{
    partial class LocationMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationMasterform));
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loclsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.loc_add_btn = new System.Windows.Forms.ToolStripButton();
            this.loc_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.loc_print_btn = new System.Windows.Forms.ToolStripButton();
            this.loc_save_btn = new System.Windows.Forms.ToolStripButton();
            this.loc_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panFoot.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1115;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(253, 128);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(111, 20);
            this.txtDatecreated.TabIndex = 1116;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1113;
            this.label5.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(253, 103);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(111, 20);
            this.txtUsercreated.TabIndex = 1114;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(253, 77);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(224, 20);
            this.txtLocation.TabIndex = 1111;
            this.btxMsg.SetText(this.txtLocation, "Location cannot be blanked");
            this.btxMsg.SetTitle(this.txtLocation, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1110;
            this.label1.Text = "Location :";
            // 
            // loclsvList
            // 
            this.loclsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader4});
            this.loclsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loclsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loclsvList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loclsvList.FullRowSelect = true;
            this.loclsvList.GridLines = true;
            this.loclsvList.Location = new System.Drawing.Point(0, 236);
            this.loclsvList.Name = "loclsvList";
            this.loclsvList.Size = new System.Drawing.Size(505, 234);
            this.loclsvList.TabIndex = 1118;
            this.loclsvList.UseCompatibleStateImageBehavior = false;
            this.loclsvList.View = System.Windows.Forms.View.Details;
            this.loclsvList.SelectedIndexChanged += new System.EventHandler(this.loclsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "       Location";
            this.columnHeader5.Width = 226;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Created";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1120;
            this.label2.Text = "Filter Location:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLocFilter
            // 
            this.txtLocFilter.BackColor = System.Drawing.Color.White;
            this.txtLocFilter.Location = new System.Drawing.Point(140, 207);
            this.txtLocFilter.Name = "txtLocFilter";
            this.txtLocFilter.Size = new System.Drawing.Size(352, 20);
            this.txtLocFilter.TabIndex = 1119;
            this.btxMsg.SetText(this.txtLocFilter, null);
            this.btxMsg.SetTitle(this.txtLocFilter, null);
            this.txtLocFilter.TextChanged += new System.EventHandler(this.txtLocFilter_TextChanged);
            this.txtLocFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocFilter_Keydown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1121;
            this.pictureBox1.TabStop = false;
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label3);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 470);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(505, 25);
            this.panFoot.TabIndex = 1122;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loc_add_btn,
            this.loc_edit_btn,
            this.loc_print_btn,
            this.loc_save_btn,
            this.loc_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(505, 39);
            this.toolStrip1.TabIndex = 1123;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // loc_add_btn
            // 
            this.loc_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("loc_add_btn.Image")));
            this.loc_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loc_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loc_add_btn.Name = "loc_add_btn";
            this.loc_add_btn.Size = new System.Drawing.Size(36, 36);
            this.loc_add_btn.ToolTipText = "add record";
            this.loc_add_btn.Click += new System.EventHandler(this.loc_add_btn_Click);
            // 
            // loc_edit_btn
            // 
            this.loc_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("loc_edit_btn.Image")));
            this.loc_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loc_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loc_edit_btn.Name = "loc_edit_btn";
            this.loc_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.loc_edit_btn.ToolTipText = "Edit record";
            this.loc_edit_btn.Click += new System.EventHandler(this.loc_edit_btn_Click);
            // 
            // loc_print_btn
            // 
            this.loc_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("loc_print_btn.Image")));
            this.loc_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loc_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loc_print_btn.Name = "loc_print_btn";
            this.loc_print_btn.Size = new System.Drawing.Size(36, 36);
            this.loc_print_btn.ToolTipText = "Print record";
            this.loc_print_btn.Click += new System.EventHandler(this.loc_print_btn_Click);
            // 
            // loc_save_btn
            // 
            this.loc_save_btn.Enabled = false;
            this.loc_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("loc_save_btn.Image")));
            this.loc_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loc_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loc_save_btn.Name = "loc_save_btn";
            this.loc_save_btn.Size = new System.Drawing.Size(36, 36);
            this.loc_save_btn.ToolTipText = "save record";
            this.loc_save_btn.Click += new System.EventHandler(this.loc_save_btn_Click);
            // 
            // loc_cancel_btn
            // 
            this.loc_cancel_btn.Enabled = false;
            this.loc_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("loc_cancel_btn.Image")));
            this.loc_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loc_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loc_cancel_btn.Name = "loc_cancel_btn";
            this.loc_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.loc_cancel_btn.ToolTipText = "cancel record";
            this.loc_cancel_btn.Click += new System.EventHandler(this.loc_cancel_btn_Click);
            // 
            // LocationMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 495);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocFilter);
            this.Controls.Add(this.loclsvList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panFoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LocationMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Location Masterfile";
            this.Load += new System.EventHandler(this.LocationMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LocationMasterform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView loclsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton loc_add_btn;
        private System.Windows.Forms.ToolStripButton loc_edit_btn;
        private System.Windows.Forms.ToolStripButton loc_print_btn;
        private System.Windows.Forms.ToolStripButton loc_save_btn;
        private System.Windows.Forms.ToolStripButton loc_cancel_btn;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}