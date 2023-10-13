namespace AMS.MasterFile
{
    partial class ReasonMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReasonMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reas_add_btn = new System.Windows.Forms.ToolStripButton();
            this.reas_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.reas_print_btn = new System.Windows.Forms.ToolStripButton();
            this.reas_save_btn = new System.Windows.Forms.ToolStripButton();
            this.reas_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.reasonlsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panFoot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            this.panFoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reas_add_btn,
            this.reas_edit_btn,
            this.reas_print_btn,
            this.reas_save_btn,
            this.reas_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 39);
            this.toolStrip1.TabIndex = 1124;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reas_add_btn
            // 
            this.reas_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("reas_add_btn.Image")));
            this.reas_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reas_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reas_add_btn.Name = "reas_add_btn";
            this.reas_add_btn.Size = new System.Drawing.Size(36, 36);
            this.reas_add_btn.ToolTipText = "add record";
            this.reas_add_btn.Click += new System.EventHandler(this.reas_add_btn_Click);
            // 
            // reas_edit_btn
            // 
            this.reas_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("reas_edit_btn.Image")));
            this.reas_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reas_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reas_edit_btn.Name = "reas_edit_btn";
            this.reas_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.reas_edit_btn.ToolTipText = "Edit record";
            this.reas_edit_btn.Click += new System.EventHandler(this.reas_edit_btn_Click);
            // 
            // reas_print_btn
            // 
            this.reas_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("reas_print_btn.Image")));
            this.reas_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reas_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reas_print_btn.Name = "reas_print_btn";
            this.reas_print_btn.Size = new System.Drawing.Size(36, 36);
            this.reas_print_btn.ToolTipText = "Print record";
            this.reas_print_btn.Click += new System.EventHandler(this.reas_print_btn_Click);
            // 
            // reas_save_btn
            // 
            this.reas_save_btn.Enabled = false;
            this.reas_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("reas_save_btn.Image")));
            this.reas_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reas_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reas_save_btn.Name = "reas_save_btn";
            this.reas_save_btn.Size = new System.Drawing.Size(36, 36);
            this.reas_save_btn.ToolTipText = "save record";
            this.reas_save_btn.Click += new System.EventHandler(this.reas_save_btn_Click);
            // 
            // reas_cancel_btn
            // 
            this.reas_cancel_btn.Enabled = false;
            this.reas_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("reas_cancel_btn.Image")));
            this.reas_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reas_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reas_cancel_btn.Name = "reas_cancel_btn";
            this.reas_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.reas_cancel_btn.ToolTipText = "cancel record";
            this.reas_cancel_btn.Click += new System.EventHandler(this.reas_cancel_btn_Click);
            // 
            // reasonlsvList
            // 
            this.reasonlsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader4});
            this.reasonlsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reasonlsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonlsvList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reasonlsvList.FullRowSelect = true;
            this.reasonlsvList.GridLines = true;
            this.reasonlsvList.Location = new System.Drawing.Point(0, 251);
            this.reasonlsvList.Name = "reasonlsvList";
            this.reasonlsvList.Size = new System.Drawing.Size(547, 234);
            this.reasonlsvList.TabIndex = 1125;
            this.reasonlsvList.UseCompatibleStateImageBehavior = false;
            this.reasonlsvList.View = System.Windows.Forms.View.Details;
            this.reasonlsvList.SelectedIndexChanged += new System.EventHandler(this.reasonlsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Class";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "      Description";
            this.columnHeader5.Width = 247;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Created";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 214;
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label3);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 485);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(547, 25);
            this.panFoot.TabIndex = 1126;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1131;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(282, 159);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(111, 20);
            this.txtDatecreated.TabIndex = 1132;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1129;
            this.label5.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(282, 134);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(111, 20);
            this.txtUsercreated.TabIndex = 1130;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(280, 105);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(224, 20);
            this.txtDesc.TabIndex = 1128;
            this.btxMsg.SetText(this.txtDesc, "Description cannot be blanked");
            this.btxMsg.SetTitle(this.txtDesc, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1127;
            this.label1.Text = "Descripton :";
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.White;
            this.txtClass.Location = new System.Drawing.Point(280, 79);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(224, 20);
            this.txtClass.TabIndex = 1133;
            this.btxMsg.SetText(this.txtClass, "Reason Class cannot be blanked");
            this.btxMsg.SetTitle(this.txtClass, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1134;
            this.label2.Text = "Reason Class :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1136;
            this.label6.Text = "Filter Reason:";
            // 
            // txtClassFilter
            // 
            this.txtClassFilter.BackColor = System.Drawing.Color.White;
            this.txtClassFilter.Location = new System.Drawing.Point(169, 215);
            this.txtClassFilter.Name = "txtClassFilter";
            this.txtClassFilter.Size = new System.Drawing.Size(352, 20);
            this.txtClassFilter.TabIndex = 1135;
            this.btxMsg.SetText(this.txtClassFilter, null);
            this.btxMsg.SetTitle(this.txtClassFilter, null);
            this.txtClassFilter.TextChanged += new System.EventHandler(this.txtClassFilter_TextChanged);
            this.txtClassFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReasonFilter_Keydown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1137;
            this.pictureBox1.TabStop = false;
            // 
            // ReasonMasterform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(547, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClassFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonlsvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReasonMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reason Masterfile";
            this.Load += new System.EventHandler(this.ReasonMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReasonMasterform_Keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton reas_add_btn;
        private System.Windows.Forms.ToolStripButton reas_edit_btn;
        private System.Windows.Forms.ToolStripButton reas_print_btn;
        private System.Windows.Forms.ToolStripButton reas_save_btn;
        private System.Windows.Forms.ToolStripButton reas_cancel_btn;
        private System.Windows.Forms.ListView reasonlsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}