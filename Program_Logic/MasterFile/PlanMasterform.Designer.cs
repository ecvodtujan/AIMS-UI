namespace AMS.MasterFile
{
    partial class PlanMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanMasterform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.plan_add_btn = new System.Windows.Forms.ToolStripButton();
            this.plan_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.plan_print_btn = new System.Windows.Forms.ToolStripButton();
            this.plan_save_btn = new System.Windows.Forms.ToolStripButton();
            this.plan_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.planLsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panExpanPlan = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHandset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInclusion = new System.Windows.Forms.Button();
            this.btnInclusive = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.txtPlanFilter = new System.Windows.Forms.TextBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plan_add_btn,
            this.plan_edit_btn,
            this.plan_print_btn,
            this.plan_save_btn,
            this.plan_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 39);
            this.toolStrip1.TabIndex = 1051;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // plan_add_btn
            // 
            this.plan_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("plan_add_btn.Image")));
            this.plan_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.plan_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plan_add_btn.Name = "plan_add_btn";
            this.plan_add_btn.Size = new System.Drawing.Size(36, 36);
            this.plan_add_btn.ToolTipText = "add record";
            this.plan_add_btn.Click += new System.EventHandler(this.plan_add_btn_Click);
            // 
            // plan_edit_btn
            // 
            this.plan_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("plan_edit_btn.Image")));
            this.plan_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.plan_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plan_edit_btn.Name = "plan_edit_btn";
            this.plan_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.plan_edit_btn.ToolTipText = "Edit record";
            this.plan_edit_btn.Click += new System.EventHandler(this.plan_edit_btn_Click);
            // 
            // plan_print_btn
            // 
            this.plan_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("plan_print_btn.Image")));
            this.plan_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.plan_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plan_print_btn.Name = "plan_print_btn";
            this.plan_print_btn.Size = new System.Drawing.Size(36, 36);
            this.plan_print_btn.ToolTipText = "Print record";
            this.plan_print_btn.Click += new System.EventHandler(this.plan_print_btn_Click);
            // 
            // plan_save_btn
            // 
            this.plan_save_btn.Enabled = false;
            this.plan_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("plan_save_btn.Image")));
            this.plan_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.plan_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plan_save_btn.Name = "plan_save_btn";
            this.plan_save_btn.Size = new System.Drawing.Size(36, 36);
            this.plan_save_btn.ToolTipText = "save record";
            this.plan_save_btn.Click += new System.EventHandler(this.plan_save_btn_Click);
            // 
            // plan_cancel_btn
            // 
            this.plan_cancel_btn.Enabled = false;
            this.plan_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("plan_cancel_btn.Image")));
            this.plan_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.plan_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plan_cancel_btn.Name = "plan_cancel_btn";
            this.plan_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.plan_cancel_btn.ToolTipText = "cancel record";
            this.plan_cancel_btn.Click += new System.EventHandler(this.plan_cancel_btn_Click);
            // 
            // planLsvList
            // 
            this.planLsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader1});
            this.planLsvList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.planLsvList.FullRowSelect = true;
            this.planLsvList.Location = new System.Drawing.Point(0, 58);
            this.planLsvList.Name = "planLsvList";
            this.planLsvList.Size = new System.Drawing.Size(240, 480);
            this.planLsvList.TabIndex = 1056;
            this.planLsvList.UseCompatibleStateImageBehavior = false;
            this.planLsvList.View = System.Windows.Forms.View.Details;
            this.planLsvList.SelectedIndexChanged += new System.EventHandler(this.planLsvList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Plan Description";
            this.columnHeader5.Width = 324;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Handset";
            this.columnHeader1.Width = 0;
            // 
            // panExpanPlan
            // 
            this.panExpanPlan.BackColor = System.Drawing.Color.White;
            this.panExpanPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panExpanPlan.Location = new System.Drawing.Point(240, 212);
            this.panExpanPlan.Margin = new System.Windows.Forms.Padding(4);
            this.panExpanPlan.Name = "panExpanPlan";
            this.panExpanPlan.Size = new System.Drawing.Size(539, 326);
            this.panExpanPlan.TabIndex = 1069;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(353, 46);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 1112;
            this.btxMsg.SetText(this.txtDescription, "Plan Description cannot be blanked");
            this.btxMsg.SetTitle(this.txtDescription, null);
            // 
            // txtHandset
            // 
            this.txtHandset.BackColor = System.Drawing.Color.White;
            this.txtHandset.Location = new System.Drawing.Point(353, 66);
            this.txtHandset.Margin = new System.Windows.Forms.Padding(4);
            this.txtHandset.Name = "txtHandset";
            this.txtHandset.ReadOnly = true;
            this.txtHandset.Size = new System.Drawing.Size(260, 20);
            this.txtHandset.TabIndex = 1113;
            this.btxMsg.SetText(this.txtHandset, "Handset value cannot be blanked");
            this.txtHandset.Text = "0.00";
            this.btxMsg.SetTitle(this.txtHandset, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1114;
            this.label2.Text = "Plan Description :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1115;
            this.label1.Text = "Handset Value :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(354, 86);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(260, 55);
            this.txtRemarks.TabIndex = 1116;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(289, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1117;
            this.label3.Text = "Remarks :";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUser.Location = new System.Drawing.Point(355, 141);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(182, 20);
            this.txtUser.TabIndex = 1118;
            this.btxMsg.SetText(this.txtUser, null);
            this.btxMsg.SetTitle(this.txtUser, null);
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDateCreated.Location = new System.Drawing.Point(355, 162);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(182, 20);
            this.txtDateCreated.TabIndex = 1119;
            this.btxMsg.SetText(this.txtDateCreated, null);
            this.btxMsg.SetTitle(this.txtDateCreated, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(276, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1120;
            this.label4.Text = "Created by :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(266, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1121;
            this.label5.Text = "Date Created :";
            // 
            // btnInclusion
            // 
            this.btnInclusion.BackColor = System.Drawing.Color.White;
            this.btnInclusion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInclusion.Location = new System.Drawing.Point(239, 190);
            this.btnInclusion.Name = "btnInclusion";
            this.btnInclusion.Size = new System.Drawing.Size(157, 24);
            this.btnInclusion.TabIndex = 1122;
            this.btnInclusion.Text = "Inclusion";
            this.btnInclusion.UseVisualStyleBackColor = false;
            this.btnInclusion.Click += new System.EventHandler(this.btnInclusion_Clck);
            this.btnInclusion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_plan_inclusion);
            // 
            // btnInclusive
            // 
            this.btnInclusive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInclusive.Location = new System.Drawing.Point(394, 190);
            this.btnInclusive.Name = "btnInclusive";
            this.btnInclusive.Size = new System.Drawing.Size(160, 24);
            this.btnInclusive.TabIndex = 1123;
            this.btnInclusive.Text = "Inclusive";
            this.btnInclusive.UseVisualStyleBackColor = true;
            this.btnInclusive.Click += new System.EventHandler(this.btnInclusive_Click);
            this.btnInclusive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_plan_inclusive);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpgrade.Location = new System.Drawing.Point(551, 190);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(157, 24);
            this.btnUpgrade.TabIndex = 1124;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            this.btnUpgrade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_plan_upgrade);
            // 
            // txtPlanFilter
            // 
            this.txtPlanFilter.BackColor = System.Drawing.Color.White;
            this.txtPlanFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPlanFilter.Location = new System.Drawing.Point(0, 39);
            this.txtPlanFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlanFilter.Name = "txtPlanFilter";
            this.txtPlanFilter.Size = new System.Drawing.Size(240, 20);
            this.txtPlanFilter.TabIndex = 1125;
            this.btxMsg.SetText(this.txtPlanFilter, null);
            this.btxMsg.SetTitle(this.txtPlanFilter, null);
            this.txtPlanFilter.Click += new System.EventHandler(this.txtFilter_click);
            this.txtPlanFilter.CursorChanged += new System.EventHandler(this.txtPlanFilter_cursor);
            this.txtPlanFilter.TextChanged += new System.EventHandler(this.txtPlanFilter_TextChanged);
            this.txtPlanFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlanFilter_Keydown);
            this.txtPlanFilter.MouseLeave += new System.EventHandler(this.txtPlanFilter_mouseleave);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label7);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 539);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(779, 25);
            this.panFoot.TabIndex = 1127;
            this.panFoot.Paint += new System.Windows.Forms.PaintEventHandler(this.panFoot_Paint);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 849;
            this.label7.Text = "Press Esc to close this form";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlanMasterform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 564);
            this.Controls.Add(this.planLsvList);
            this.Controls.Add(this.txtPlanFilter);
            this.Controls.Add(this.panExpanPlan);
            this.Controls.Add(this.btnInclusive);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnInclusion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHandset);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlanMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Plan Masterfile";
            this.Load += new System.EventHandler(this.PlanMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlanMasterfile_Keydown);
            this.MouseLeave += new System.EventHandler(this.txtfiltermouseleave);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton plan_add_btn;
        private System.Windows.Forms.ToolStripButton plan_edit_btn;
        private System.Windows.Forms.ToolStripButton plan_print_btn;
        private System.Windows.Forms.ToolStripButton plan_save_btn;
        private System.Windows.Forms.ToolStripButton plan_cancel_btn;
        private System.Windows.Forms.ListView planLsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panExpanPlan;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHandset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnInclusion;
        private System.Windows.Forms.Button btnInclusive;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.TextBox txtPlanFilter;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}