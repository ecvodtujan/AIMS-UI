namespace AMS.MasterFile
{
    partial class DesignationMasterfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignationMasterfile));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pos_add_btn = new System.Windows.Forms.ToolStripButton();
            this.pos_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.pos_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.pos_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.pos_print_btn = new System.Windows.Forms.ToolStripButton();
            this.pos_save_btn = new System.Windows.Forms.ToolStripButton();
            this.pos_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.postlsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panFoot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPosDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpostFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pos_add_btn,
            this.pos_edit_btn,
            this.pos_deactivate_btn,
            this.pos_activate_btn,
            this.pos_print_btn,
            this.pos_save_btn,
            this.pos_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(516, 39);
            this.toolStrip1.TabIndex = 1053;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pos_add_btn
            // 
            this.pos_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_add_btn.Image")));
            this.pos_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_add_btn.Name = "pos_add_btn";
            this.pos_add_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_add_btn.ToolTipText = "add record";
            this.pos_add_btn.Click += new System.EventHandler(this.pos_add_btn_Click);
            // 
            // pos_edit_btn
            // 
            this.pos_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_edit_btn.Image")));
            this.pos_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_edit_btn.Name = "pos_edit_btn";
            this.pos_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_edit_btn.ToolTipText = "Edit record";
            this.pos_edit_btn.Click += new System.EventHandler(this.pos_edit_btn_Click);
            // 
            // pos_deactivate_btn
            // 
            this.pos_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_deactivate_btn.Image")));
            this.pos_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_deactivate_btn.Name = "pos_deactivate_btn";
            this.pos_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_deactivate_btn.ToolTipText = "Deactivate record";
            this.pos_deactivate_btn.Click += new System.EventHandler(this.pos_deactivate_btn_Click);
            // 
            // pos_activate_btn
            // 
            this.pos_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_activate_btn.Image")));
            this.pos_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_activate_btn.Name = "pos_activate_btn";
            this.pos_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_activate_btn.ToolTipText = "Activate record";
            this.pos_activate_btn.Click += new System.EventHandler(this.pos_activate_btn_Click);
            // 
            // pos_print_btn
            // 
            this.pos_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_print_btn.Image")));
            this.pos_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_print_btn.Name = "pos_print_btn";
            this.pos_print_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_print_btn.ToolTipText = "Print record";
            this.pos_print_btn.Click += new System.EventHandler(this.pos_print_btn_Click);
            // 
            // pos_save_btn
            // 
            this.pos_save_btn.Enabled = false;
            this.pos_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_save_btn.Image")));
            this.pos_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_save_btn.Name = "pos_save_btn";
            this.pos_save_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_save_btn.ToolTipText = "save record";
            this.pos_save_btn.Click += new System.EventHandler(this.pos_save_btn_Click);
            // 
            // pos_cancel_btn
            // 
            this.pos_cancel_btn.Enabled = false;
            this.pos_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("pos_cancel_btn.Image")));
            this.pos_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pos_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pos_cancel_btn.Name = "pos_cancel_btn";
            this.pos_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.pos_cancel_btn.ToolTipText = "cancel record";
            this.pos_cancel_btn.Click += new System.EventHandler(this.pos_cancel_btn_Click);
            // 
            // postlsvList
            // 
            this.postlsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.postlsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postlsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postlsvList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.postlsvList.FullRowSelect = true;
            this.postlsvList.GridLines = true;
            this.postlsvList.Location = new System.Drawing.Point(0, 216);
            this.postlsvList.Name = "postlsvList";
            this.postlsvList.Size = new System.Drawing.Size(516, 234);
            this.postlsvList.TabIndex = 1054;
            this.postlsvList.UseCompatibleStateImageBehavior = false;
            this.postlsvList.View = System.Windows.Forms.View.Details;
            this.postlsvList.SelectedIndexChanged += new System.EventHandler(this.postLsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "        Description";
            this.columnHeader5.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 82;
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
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label3);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 450);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(516, 25);
            this.panFoot.TabIndex = 1081;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1109;
            this.label6.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1107;
            this.label4.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDatecreated.Location = new System.Drawing.Point(258, 138);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 20);
            this.txtDatecreated.TabIndex = 1108;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1105;
            this.label5.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsercreated.Location = new System.Drawing.Point(258, 113);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 20);
            this.txtUsercreated.TabIndex = 1106;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(258, 88);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 20);
            this.txtStatus.TabIndex = 1104;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // txtPosDesc
            // 
            this.txtPosDesc.BackColor = System.Drawing.Color.White;
            this.txtPosDesc.Location = new System.Drawing.Point(258, 61);
            this.txtPosDesc.Name = "txtPosDesc";
            this.txtPosDesc.ReadOnly = true;
            this.txtPosDesc.Size = new System.Drawing.Size(215, 20);
            this.txtPosDesc.TabIndex = 1101;
            this.btxMsg.SetText(this.txtPosDesc, "Position Description cannot be blanked");
            this.btxMsg.SetTitle(this.txtPosDesc, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1100;
            this.label1.Text = "Description :";
            // 
            // txtpostFilter
            // 
            this.txtpostFilter.BackColor = System.Drawing.Color.White;
            this.txtpostFilter.Location = new System.Drawing.Point(121, 191);
            this.txtpostFilter.Name = "txtpostFilter";
            this.txtpostFilter.Size = new System.Drawing.Size(352, 20);
            this.txtpostFilter.TabIndex = 1110;
            this.btxMsg.SetText(this.txtpostFilter, null);
            this.btxMsg.SetTitle(this.txtpostFilter, null);
            this.txtpostFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostFilter_Keydown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1111;
            this.label2.Text = "Filter Position :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1112;
            this.pictureBox1.TabStop = false;
            // 
            // DesignationMasterfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpostFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDatecreated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsercreated);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPosDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.postlsvList);
            this.Controls.Add(this.panFoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DesignationMasterfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Position Masterfile";
            this.Load += new System.EventHandler(this.PositionMasterfile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PositionMasterform_Keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pos_add_btn;
        private System.Windows.Forms.ToolStripButton pos_edit_btn;
        private System.Windows.Forms.ToolStripButton pos_deactivate_btn;
        private System.Windows.Forms.ToolStripButton pos_activate_btn;
        private System.Windows.Forms.ToolStripButton pos_print_btn;
        private System.Windows.Forms.ToolStripButton pos_save_btn;
        private System.Windows.Forms.ToolStripButton pos_cancel_btn;
        private System.Windows.Forms.ListView postlsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPosDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpostFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}