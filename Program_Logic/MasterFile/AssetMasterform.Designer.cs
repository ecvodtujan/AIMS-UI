namespace AMS.MasterFile
{
    partial class AssetMasterform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetMasterform));
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.document_btn = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.repair_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.panExpan = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDeac = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.lblAsset = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDeac.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1054;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(879, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 1064;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.document_btn);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.repair_btn);
            this.panel1.Controls.Add(this.history_btn);
            this.panel1.Controls.Add(this.info_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 512);
            this.panel1.TabIndex = 1065;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(4, 491);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "0";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // document_btn
            // 
            this.document_btn.Image = ((System.Drawing.Image)(resources.GetObject("document_btn.Image")));
            this.document_btn.Location = new System.Drawing.Point(11, 46);
            this.document_btn.Name = "document_btn";
            this.document_btn.Size = new System.Drawing.Size(23, 26);
            this.document_btn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.document_btn, "Asset owner history");
            this.document_btn.UseVisualStyleBackColor = true;
            this.document_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Blue;
            this.SidePanel.Location = new System.Drawing.Point(5, 16);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(6, 24);
            this.SidePanel.TabIndex = 9;
            // 
            // repair_btn
            // 
            this.repair_btn.Image = ((System.Drawing.Image)(resources.GetObject("repair_btn.Image")));
            this.repair_btn.Location = new System.Drawing.Point(11, 108);
            this.repair_btn.Name = "repair_btn";
            this.repair_btn.Size = new System.Drawing.Size(23, 26);
            this.repair_btn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.repair_btn, "Asset Repair history");
            this.repair_btn.UseVisualStyleBackColor = true;
            this.repair_btn.Click += new System.EventHandler(this.repair_btn_Click);
            // 
            // history_btn
            // 
            this.history_btn.Image = ((System.Drawing.Image)(resources.GetObject("history_btn.Image")));
            this.history_btn.Location = new System.Drawing.Point(11, 77);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(23, 26);
            this.history_btn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.history_btn, "Asset owner history");
            this.history_btn.UseVisualStyleBackColor = true;
            this.history_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // info_btn
            // 
            this.info_btn.Image = ((System.Drawing.Image)(resources.GetObject("info_btn.Image")));
            this.info_btn.Location = new System.Drawing.Point(11, 15);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(23, 26);
            this.info_btn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.info_btn, "Asset information");
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panExpan
            // 
            this.panExpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panExpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panExpan.Location = new System.Drawing.Point(44, 0);
            this.panExpan.Name = "panExpan";
            this.panExpan.Size = new System.Drawing.Size(773, 512);
            this.panExpan.TabIndex = 1066;
            this.panExpan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDeac
            // 
            this.panelDeac.BackColor = System.Drawing.Color.Red;
            this.panelDeac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeac.Controls.Add(this.label19);
            this.panelDeac.Controls.Add(this.panel3);
            this.panelDeac.Controls.Add(this.lblAsset);
            this.panelDeac.Location = new System.Drawing.Point(118, 66);
            this.panelDeac.Name = "panelDeac";
            this.panelDeac.Size = new System.Drawing.Size(581, 380);
            this.panelDeac.TabIndex = 1067;
            this.panelDeac.Visible = false;
            this.panelDeac.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panDeac_Keydown);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(422, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 23);
            this.label19.TabIndex = 850;
            this.label19.Text = "Press Esc to close this form";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.close_btn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 26);
            this.panel3.TabIndex = 1;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(548, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 22);
            this.close_btn.TabIndex = 875;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // lblAsset
            // 
            this.lblAsset.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsset.ForeColor = System.Drawing.Color.DimGray;
            this.lblAsset.Image = ((System.Drawing.Image)(resources.GetObject("lblAsset.Image")));
            this.lblAsset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAsset.Location = new System.Drawing.Point(49, 87);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(493, 187);
            this.lblAsset.TabIndex = 0;
            this.lblAsset.Text = "Asset was already deactivated. Editing is not allowed.";
            this.lblAsset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssetMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 512);
            this.Controls.Add(this.panelDeac);
            this.Controls.Add(this.panExpan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AssetMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Master File";
            this.Load += new System.EventHandler(this.AssetMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssetMasterform_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDeac.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panExpan;
        private System.Windows.Forms.Button repair_btn;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button document_btn;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDeac;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label lblAsset;
    }
}