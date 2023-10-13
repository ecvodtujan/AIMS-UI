namespace AMS.MasterFile.Plan
{
    partial class PlanInclusioncontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanInclusioncontrol));
            this.inclusionlsvList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.inclusion_add_btn = new System.Windows.Forms.ToolStripButton();
            this.inclusion_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.inclusion_save_btn = new System.Windows.Forms.ToolStripButton();
            this.inclusion_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inclusionlsvList
            // 
            this.inclusionlsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader4});
            this.inclusionlsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inclusionlsvList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclusionlsvList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inclusionlsvList.FullRowSelect = true;
            this.inclusionlsvList.GridLines = true;
            this.inclusionlsvList.Location = new System.Drawing.Point(0, 190);
            this.inclusionlsvList.Margin = new System.Windows.Forms.Padding(4);
            this.inclusionlsvList.Name = "inclusionlsvList";
            this.inclusionlsvList.Size = new System.Drawing.Size(479, 168);
            this.inclusionlsvList.TabIndex = 1119;
            this.inclusionlsvList.UseCompatibleStateImageBehavior = false;
            this.inclusionlsvList.View = System.Windows.Forms.View.Details;
            this.inclusionlsvList.SelectedIndexChanged += new System.EventHandler(this.inclusionlsvList_SelectedIndexChanged);
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
            this.columnHeader5.Text = "       Inclusion Description";
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
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDateCreated.Location = new System.Drawing.Point(247, 105);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(134, 20);
            this.txtDateCreated.TabIndex = 1124;
            this.btxMsg.SetText(this.txtDateCreated, null);
            this.btxMsg.SetTitle(this.txtDateCreated, null);
            this.txtDateCreated.WordWrap = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUser.Location = new System.Drawing.Point(246, 80);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(135, 20);
            this.txtUser.TabIndex = 1123;
            this.btxMsg.SetText(this.txtUser, null);
            this.btxMsg.SetTitle(this.txtUser, null);
            this.txtUser.WordWrap = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(246, 56);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(210, 20);
            this.txtDescription.TabIndex = 1120;
            this.btxMsg.SetText(this.txtDescription, null);
            this.btxMsg.SetTitle(this.txtDescription, "Description cannot be blanked");
            this.txtDescription.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1125;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1126;
            this.label1.Text = "Created by :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1127;
            this.label3.Text = "Date Created :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inclusion_add_btn,
            this.inclusion_edit_btn,
            this.inclusion_save_btn,
            this.inclusion_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(479, 39);
            this.toolStrip1.TabIndex = 1128;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // inclusion_add_btn
            // 
            this.inclusion_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusion_add_btn.Image")));
            this.inclusion_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusion_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusion_add_btn.Name = "inclusion_add_btn";
            this.inclusion_add_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusion_add_btn.ToolTipText = "add record";
            this.inclusion_add_btn.Click += new System.EventHandler(this.inclusion_add_btn_Click);
            // 
            // inclusion_edit_btn
            // 
            this.inclusion_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusion_edit_btn.Image")));
            this.inclusion_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusion_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusion_edit_btn.Name = "inclusion_edit_btn";
            this.inclusion_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusion_edit_btn.ToolTipText = "Edit record";
            this.inclusion_edit_btn.Click += new System.EventHandler(this.inclusion_edit_btn_Click);
            // 
            // inclusion_save_btn
            // 
            this.inclusion_save_btn.Enabled = false;
            this.inclusion_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusion_save_btn.Image")));
            this.inclusion_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusion_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusion_save_btn.Name = "inclusion_save_btn";
            this.inclusion_save_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusion_save_btn.ToolTipText = "save record";
            this.inclusion_save_btn.Click += new System.EventHandler(this.inclusion_save_btn_Click);
            // 
            // inclusion_cancel_btn
            // 
            this.inclusion_cancel_btn.Enabled = false;
            this.inclusion_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("inclusion_cancel_btn.Image")));
            this.inclusion_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inclusion_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inclusion_cancel_btn.Name = "inclusion_cancel_btn";
            this.inclusion_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.inclusion_cancel_btn.ToolTipText = "cancel record";
            this.inclusion_cancel_btn.Click += new System.EventHandler(this.inclusion_cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1129;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1134;
            this.label4.Text = "Plan Inclusion";
            // 
            // PlanInclusioncontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.inclusionlsvList);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanInclusioncontrol";
            this.Size = new System.Drawing.Size(479, 358);
            this.Load += new System.EventHandler(this.PlanInclusioncontrol_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView inclusionlsvList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton inclusion_add_btn;
        private System.Windows.Forms.ToolStripButton inclusion_edit_btn;
        private System.Windows.Forms.ToolStripButton inclusion_save_btn;
        private System.Windows.Forms.ToolStripButton inclusion_cancel_btn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Label label4;
    }
}
