namespace AMS.MasterFile.Plan
{
    partial class PlanUpgradecontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanUpgradecontrol));
            this.upgradeLsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.upgrade_add_btn = new System.Windows.Forms.ToolStripButton();
            this.upgrade_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.upgrade_save_btn = new System.Windows.Forms.ToolStripButton();
            this.upgrade_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upgradeLsvList
            // 
            this.upgradeLsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader4});
            this.upgradeLsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.upgradeLsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradeLsvList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upgradeLsvList.FullRowSelect = true;
            this.upgradeLsvList.GridLines = true;
            this.upgradeLsvList.Location = new System.Drawing.Point(0, 209);
            this.upgradeLsvList.Margin = new System.Windows.Forms.Padding(4);
            this.upgradeLsvList.Name = "upgradeLsvList";
            this.upgradeLsvList.Size = new System.Drawing.Size(516, 169);
            this.upgradeLsvList.TabIndex = 1119;
            this.upgradeLsvList.UseCompatibleStateImageBehavior = false;
            this.upgradeLsvList.View = System.Windows.Forms.View.Details;
            this.upgradeLsvList.SelectedIndexChanged += new System.EventHandler(this.upgradeLsvList_SelectedChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "plan_id";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "       Upgrade Description";
            this.columnHeader5.Width = 166;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Amount";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User Created";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Created";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 146;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDateCreated.Location = new System.Drawing.Point(285, 127);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(146, 20);
            this.txtDateCreated.TabIndex = 1124;
            this.btxMsg.SetText(this.txtDateCreated, null);
            this.btxMsg.SetTitle(this.txtDateCreated, null);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUser.Location = new System.Drawing.Point(285, 105);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 1123;
            this.btxMsg.SetText(this.txtUser, null);
            this.btxMsg.SetTitle(this.txtUser, null);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(284, 84);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(213, 20);
            this.txtAmount.TabIndex = 1121;
            this.btxMsg.SetText(this.txtAmount, null);
            this.txtAmount.Text = "0.00";
            this.btxMsg.SetTitle(this.txtAmount, null);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(284, 61);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(213, 20);
            this.txtDescription.TabIndex = 1120;
            this.btxMsg.SetText(this.txtDescription, null);
            this.btxMsg.SetTitle(this.txtDescription, null);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upgrade_add_btn,
            this.upgrade_edit_btn,
            this.upgrade_save_btn,
            this.upgrade_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(516, 39);
            this.toolStrip1.TabIndex = 1125;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // upgrade_add_btn
            // 
            this.upgrade_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("upgrade_add_btn.Image")));
            this.upgrade_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.upgrade_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upgrade_add_btn.Name = "upgrade_add_btn";
            this.upgrade_add_btn.Size = new System.Drawing.Size(36, 36);
            this.upgrade_add_btn.ToolTipText = "add record";
            this.upgrade_add_btn.Click += new System.EventHandler(this.upgrade_add_btn_Click);
            // 
            // upgrade_edit_btn
            // 
            this.upgrade_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("upgrade_edit_btn.Image")));
            this.upgrade_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.upgrade_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upgrade_edit_btn.Name = "upgrade_edit_btn";
            this.upgrade_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.upgrade_edit_btn.ToolTipText = "Edit record";
            this.upgrade_edit_btn.Click += new System.EventHandler(this.upgrade_edit_btn_Click);
            // 
            // upgrade_save_btn
            // 
            this.upgrade_save_btn.Enabled = false;
            this.upgrade_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("upgrade_save_btn.Image")));
            this.upgrade_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.upgrade_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upgrade_save_btn.Name = "upgrade_save_btn";
            this.upgrade_save_btn.Size = new System.Drawing.Size(36, 36);
            this.upgrade_save_btn.ToolTipText = "save record";
            this.upgrade_save_btn.Click += new System.EventHandler(this.upgrade_save_btn_Click);
            // 
            // upgrade_cancel_btn
            // 
            this.upgrade_cancel_btn.Enabled = false;
            this.upgrade_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("upgrade_cancel_btn.Image")));
            this.upgrade_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.upgrade_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upgrade_cancel_btn.Name = "upgrade_cancel_btn";
            this.upgrade_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.upgrade_cancel_btn.ToolTipText = "cancel record";
            this.upgrade_cancel_btn.Click += new System.EventHandler(this.upgrade_cancel_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1126;
            this.label2.Text = "Upgrade Description :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1127;
            this.label1.Text = "Amount :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1128;
            this.label3.Text = "Created by :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1129;
            this.label4.Text = "Date Created :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1130;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1134;
            this.label5.Text = "Plan Upgrade";
            // 
            // PlanUpgradecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.upgradeLsvList);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanUpgradecontrol";
            this.Size = new System.Drawing.Size(516, 378);
            this.Load += new System.EventHandler(this.PlanUpgradecontrol_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView upgradeLsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton upgrade_add_btn;
        private System.Windows.Forms.ToolStripButton upgrade_edit_btn;
        private System.Windows.Forms.ToolStripButton upgrade_cancel_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton upgrade_save_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label5;
    }
}
