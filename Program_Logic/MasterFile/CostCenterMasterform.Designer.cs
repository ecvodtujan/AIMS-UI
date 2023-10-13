namespace AMS.MasterFile
{
    partial class CostCenterMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostCenterMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ccm_add_btn = new System.Windows.Forms.ToolStripButton();
            this.ccm_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.ccm_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.ccm_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.ccm_print_btn = new System.Windows.Forms.ToolStripButton();
            this.ccm_save_btn = new System.Windows.Forms.ToolStripButton();
            this.ccm_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.ccmsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtccCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtccDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrandFilter = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ccm_add_btn,
            this.ccm_edit_btn,
            this.ccm_deactivate_btn,
            this.ccm_activate_btn,
            this.ccm_print_btn,
            this.ccm_save_btn,
            this.ccm_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(659, 39);
            this.toolStrip1.TabIndex = 1053;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ccm_add_btn
            // 
            this.ccm_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_add_btn.Image")));
            this.ccm_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_add_btn.Name = "ccm_add_btn";
            this.ccm_add_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_add_btn.ToolTipText = "add record";
            // 
            // ccm_edit_btn
            // 
            this.ccm_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_edit_btn.Image")));
            this.ccm_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_edit_btn.Name = "ccm_edit_btn";
            this.ccm_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_edit_btn.ToolTipText = "Edit record";
            // 
            // ccm_deactivate_btn
            // 
            this.ccm_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_deactivate_btn.Image")));
            this.ccm_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_deactivate_btn.Name = "ccm_deactivate_btn";
            this.ccm_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_deactivate_btn.ToolTipText = "Deactivate record";
            // 
            // ccm_activate_btn
            // 
            this.ccm_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_activate_btn.Image")));
            this.ccm_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_activate_btn.Name = "ccm_activate_btn";
            this.ccm_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_activate_btn.ToolTipText = "Activate record";
            // 
            // ccm_print_btn
            // 
            this.ccm_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_print_btn.Image")));
            this.ccm_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_print_btn.Name = "ccm_print_btn";
            this.ccm_print_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_print_btn.ToolTipText = "Print record";
            // 
            // ccm_save_btn
            // 
            this.ccm_save_btn.Enabled = false;
            this.ccm_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_save_btn.Image")));
            this.ccm_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_save_btn.Name = "ccm_save_btn";
            this.ccm_save_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_save_btn.ToolTipText = "save record";
            this.ccm_save_btn.Click += new System.EventHandler(this.ccm_save_btn_Click);
            // 
            // ccm_cancel_btn
            // 
            this.ccm_cancel_btn.Enabled = false;
            this.ccm_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("ccm_cancel_btn.Image")));
            this.ccm_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ccm_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ccm_cancel_btn.Name = "ccm_cancel_btn";
            this.ccm_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.ccm_cancel_btn.ToolTipText = "cancel record";
            // 
            // ccmsvList
            // 
            this.ccmsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader6});
            this.ccmsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ccmsvList.FullRowSelect = true;
            this.ccmsvList.GridLines = true;
            this.ccmsvList.Location = new System.Drawing.Point(0, 269);
            this.ccmsvList.Name = "ccmsvList";
            this.ccmsvList.Size = new System.Drawing.Size(659, 262);
            this.ccmsvList.TabIndex = 1054;
            this.ccmsvList.UseCompatibleStateImageBehavior = false;
            this.ccmsvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cost Center";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
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
            this.pictureBox1.Location = new System.Drawing.Point(27, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1061;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1079;
            this.label6.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1078;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(318, 199);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 20);
            this.txtDatecreated.TabIndex = 1076;
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1077;
            this.label5.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(318, 172);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 20);
            this.txtUsercreated.TabIndex = 1075;
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(318, 145);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 20);
            this.txtStatus.TabIndex = 1074;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtccCode
            // 
            this.txtccCode.BackColor = System.Drawing.Color.White;
            this.txtccCode.Location = new System.Drawing.Point(317, 70);
            this.txtccCode.Name = "txtccCode";
            this.txtccCode.ReadOnly = true;
            this.txtccCode.Size = new System.Drawing.Size(103, 20);
            this.txtccCode.TabIndex = 1072;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1070;
            this.label1.Text = "Cost Center :";
            // 
            // txtccDesc
            // 
            this.txtccDesc.BackColor = System.Drawing.Color.White;
            this.txtccDesc.Location = new System.Drawing.Point(317, 95);
            this.txtccDesc.Name = "txtccDesc";
            this.txtccDesc.ReadOnly = true;
            this.txtccDesc.Size = new System.Drawing.Size(150, 20);
            this.txtccDesc.TabIndex = 1080;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1081;
            this.label2.Text = "Description:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1085;
            this.label3.Text = "Filter Cost Center:";
            // 
            // txtBrandFilter
            // 
            this.txtBrandFilter.BackColor = System.Drawing.Color.White;
            this.txtBrandFilter.Location = new System.Drawing.Point(317, 238);
            this.txtBrandFilter.Name = "txtBrandFilter";
            this.txtBrandFilter.Size = new System.Drawing.Size(150, 20);
            this.txtBrandFilter.TabIndex = 1084;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(317, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1086;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1087;
            this.label7.Text = "Company :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(471, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 1103;
            this.button1.Text = "      Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CostCenterMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrandFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtccDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtccCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ccmsvList);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CostCenterMasterform";
            this.Text = "Cost Center Master File";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ccm_add_btn;
        private System.Windows.Forms.ToolStripButton ccm_edit_btn;
        private System.Windows.Forms.ToolStripButton ccm_deactivate_btn;
        private System.Windows.Forms.ToolStripButton ccm_activate_btn;
        private System.Windows.Forms.ToolStripButton ccm_print_btn;
        private System.Windows.Forms.ToolStripButton ccm_save_btn;
        private System.Windows.Forms.ToolStripButton ccm_cancel_btn;
        private System.Windows.Forms.ListView ccmsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtccCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtccDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrandFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}