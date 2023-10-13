namespace AMS.MasterFile
{
    partial class EmployeeNewMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeNewMasterform));
            this.panExpanEmp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.history_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panExpanEmp
            // 
            this.panExpanEmp.BackColor = System.Drawing.Color.White;
            this.panExpanEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panExpanEmp.Location = new System.Drawing.Point(44, 0);
            this.panExpanEmp.Name = "panExpanEmp";
            this.panExpanEmp.Size = new System.Drawing.Size(544, 528);
            this.panExpanEmp.TabIndex = 1068;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.history_btn);
            this.panel1.Controls.Add(this.info_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 528);
            this.panel1.TabIndex = 1067;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pane1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Blue;
            this.SidePanel.Location = new System.Drawing.Point(5, 16);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(6, 24);
            this.SidePanel.TabIndex = 9;
            // 
            // history_btn
            // 
            this.history_btn.Image = ((System.Drawing.Image)(resources.GetObject("history_btn.Image")));
            this.history_btn.Location = new System.Drawing.Point(11, 44);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(23, 26);
            this.history_btn.TabIndex = 1;
            this.history_btn.UseVisualStyleBackColor = true;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Image = ((System.Drawing.Image)(resources.GetObject("info_btn.Image")));
            this.info_btn.Location = new System.Drawing.Point(11, 15);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(23, 26);
            this.info_btn.TabIndex = 0;
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // EmployeeNewMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 528);
            this.Controls.Add(this.panExpanEmp);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EmployeeNewMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master File";
            this.Load += new System.EventHandler(this.EmployeeNewMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeNewMasterform_Keydown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panExpanEmp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button history_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}