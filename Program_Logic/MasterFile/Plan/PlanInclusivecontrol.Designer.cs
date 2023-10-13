namespace AMS.MasterFile.Plan
{
    partial class PlanInclusivecontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanInclusivecontrol));
            this.inclusiveLsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.inclusive_add_btn = new System.Windows.Forms.ToolStripButton();
            this.inclusive_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.inclusive_save_btn = new System.Windows.Forms.ToolStripButton();
            this.inclusive_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inclusiveLsvList
            // 
            this.inclusiveLsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader4});
            this.inclusiveLsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inclusiveLsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclusiveLsvList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inclusiveLsvList.FullRowSelect = true;
            this.inclusiveLsvList.GridLines = true;
            this.inclusiveLsvList.Location = new System.Drawing.Point(0, 184);
            this.inclusiveLsvList.Margin = new System.Windows.Forms.Padding(4);
            this.inclusiveLsvList.Name = "inclusiveLsvList";
            this.inclusiveLsvList.Size = new System.Drawing.Size(509, 164);
            this.inclusiveLsvList.TabIndex = 1119;
            this.inclusiveLsvList.UseCompatibleStateImageBehavior = false;
            this.inclusiveLsvList.View = System.Windows.Forms.View.Details;
            this.inclusiveLsvList.SelectedIndexChanged += new System.EventHandler(this.inclusiveLsvList_SelectedIndexChanged);
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
            this.columnHeader5.Text = "       Inclusive Description";
            this.columnHeader5.Width = 192;
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
            this.columnHeader4.Width = 146;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDateCreated.Location = new System.Drawing.Point(238, 107);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(160, 20);
            this.txtDateCreated.TabIndex = 1124;
            this.btxMsg.SetText(this.txtDateCreated, null);
            this.btxMsg.SetTitle(this.txtDateCreated, null);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUser.Location = new System.Drawing.Point(238, 84);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(160, 20);
            this.txtUser.TabIndex = 1123;
            this.btxMsg.SetText(this.txtUser, null);
            this.btxMsg.SetTitle(this.txtUser, null);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(238, 61);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(228, 20);
            this.txtDescription.TabIndex = 1120;
            this.btxMsg.SetText(this.txtDescription, "Inclusive Description cannot be blanked");
            this.btxMsg.SetTitle(this.txtDescription, null);
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclusive_add_btn,
            this.inclusive_edit_btn,
            this.inclusive_save_btn,
            this.inclusive_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(509, 39);
            this.toolStrip1.TabIndex = 1125;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // inclusive_add_btn
            // 
            this.inclusive_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusive_add_btn.Image")));
            this.inclusive_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusive_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusive_add_btn.Name = "inclusive_add_btn";
            this.inclusive_add_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusive_add_btn.ToolTipText = "add record";
            this.inclusive_add_btn.Click += new System.EventHandler(this.inclusive_add_btn_Click);
            // 
            // inclusive_edit_btn
            // 
            this.inclusive_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusive_edit_btn.Image")));
            this.inclusive_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusive_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusive_edit_btn.Name = "inclusive_edit_btn";
            this.inclusive_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusive_edit_btn.ToolTipText = "Edit record";
            this.inclusive_edit_btn.Click += new System.EventHandler(this.inclusive_edit_btn_Click);
            // 
            // inclusive_save_btn
            // 
            this.inclusive_save_btn.Enabled = false;
            this.inclusive_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusive_save_btn.Image")));
            this.inclusive_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusive_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusive_save_btn.Name = "inclusive_save_btn";
            this.inclusive_save_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusive_save_btn.ToolTipText = "save record";
            this.inclusive_save_btn.Click += new System.EventHandler(this.inclusive_save_btn_Click);
            // 
            // inclusive_cancel_btn
            // 
            this.inclusive_cancel_btn.Enabled = false;
            this.inclusive_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusive_cancel_btn.Image")));
            this.inclusive_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusive_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusive_cancel_btn.Name = "inclusive_cancel_btn";
            this.inclusive_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusive_cancel_btn.ToolTipText = "cancel record";
            this.inclusive_cancel_btn.Click += new System.EventHandler(this.inclusive_cancel_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1126;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1127;
            this.label1.Text = "Created by :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1128;
            this.label3.Text = "Date Created :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1131;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1133;
            this.label4.Text = "Plan Inclusive";
            // 
            // PlanInclusivecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.inclusiveLsvList);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanInclusivecontrol";
            this.Size = new System.Drawing.Size(509, 348);
            this.Load += new System.EventHandler(this.PlanInclusivecontrol_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView inclusiveLsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton inclusive_add_btn;
        private System.Windows.Forms.ToolStripButton inclusive_edit_btn;
        private System.Windows.Forms.ToolStripButton inclusive_save_btn;
        private System.Windows.Forms.ToolStripButton inclusive_cancel_btn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Label label4;
    }
}
