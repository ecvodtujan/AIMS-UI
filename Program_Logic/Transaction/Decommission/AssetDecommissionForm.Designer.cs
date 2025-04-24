namespace AMS.Transaction.Decommission
{
    partial class AssetDecommissionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetDecommissionForm));
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtRequesttype = new System.Windows.Forms.TextBox();
            this.txtRequestedby = new System.Windows.Forms.TextBox();
            this.txtDecomm = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_requesttype = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_requestedby = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateEffective = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_location = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRequesttype
            // 
            this.txtRequesttype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRequesttype.Location = new System.Drawing.Point(122, 67);
            this.txtRequesttype.Name = "txtRequesttype";
            this.txtRequesttype.ReadOnly = true;
            this.txtRequesttype.Size = new System.Drawing.Size(256, 21);
            this.txtRequesttype.TabIndex = 5;
            this.btxMsg.SetText(this.txtRequesttype, "Issued by cannot be blank");
            this.btxMsg.SetTitle(this.txtRequesttype, null);
            this.txtRequesttype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssuedBy_KeyDown);
            // 
            // txtRequestedby
            // 
            this.txtRequestedby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRequestedby.Location = new System.Drawing.Point(122, 92);
            this.txtRequestedby.Name = "txtRequestedby";
            this.txtRequestedby.ReadOnly = true;
            this.txtRequestedby.Size = new System.Drawing.Size(256, 21);
            this.txtRequestedby.TabIndex = 3;
            this.btxMsg.SetText(this.txtRequestedby, "Issued to canno be blank");
            this.btxMsg.SetTitle(this.txtRequestedby, null);
            this.txtRequestedby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssuedTo_KeyDown);
            // 
            // txtDecomm
            // 
            this.txtDecomm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDecomm.Location = new System.Drawing.Point(122, 13);
            this.txtDecomm.Name = "txtDecomm";
            this.txtDecomm.ReadOnly = true;
            this.txtDecomm.Size = new System.Drawing.Size(256, 21);
            this.txtDecomm.TabIndex = 0;
            this.btxMsg.SetText(this.txtDecomm, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtDecomm, null);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLocation.Location = new System.Drawing.Point(122, 119);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(256, 21);
            this.txtLocation.TabIndex = 926;
            this.btxMsg.SetText(this.txtLocation, "Issued to canno be blank");
            this.btxMsg.SetTitle(this.txtLocation, null);
            // 
            // btn_requesttype
            // 
            this.btn_requesttype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_requesttype.FlatAppearance.BorderSize = 0;
            this.btn_requesttype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requesttype.ForeColor = System.Drawing.Color.White;
            this.btn_requesttype.Image = ((System.Drawing.Image)(resources.GetObject("btn_requesttype.Image")));
            this.btn_requesttype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requesttype.Location = new System.Drawing.Point(380, 67);
            this.btn_requesttype.Name = "btn_requesttype";
            this.btn_requesttype.Size = new System.Drawing.Size(96, 21);
            this.btn_requesttype.TabIndex = 6;
            this.btn_requesttype.Text = "      Search";
            this.btn_requesttype.UseVisualStyleBackColor = false;
            this.btn_requesttype.Click += new System.EventHandler(this.btn_issuedby_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 916;
            this.label3.Text = "Request type :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_requestedby
            // 
            this.btn_requestedby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_requestedby.FlatAppearance.BorderSize = 0;
            this.btn_requestedby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requestedby.ForeColor = System.Drawing.Color.White;
            this.btn_requestedby.Image = ((System.Drawing.Image)(resources.GetObject("btn_requestedby.Image")));
            this.btn_requestedby.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requestedby.Location = new System.Drawing.Point(380, 92);
            this.btn_requestedby.Name = "btn_requestedby";
            this.btn_requestedby.Size = new System.Drawing.Size(96, 21);
            this.btn_requestedby.TabIndex = 4;
            this.btn_requestedby.Text = "      Search";
            this.btn_requestedby.UseVisualStyleBackColor = false;
            this.btn_requestedby.Click += new System.EventHandler(this.btn_issuedto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 915;
            this.label6.Text = "Requested by :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDateEffective
            // 
            this.dtpDateEffective.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEffective.Location = new System.Drawing.Point(123, 41);
            this.dtpDateEffective.Name = "dtpDateEffective";
            this.dtpDateEffective.Size = new System.Drawing.Size(127, 21);
            this.dtpDateEffective.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(36, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 920;
            this.label19.Text = "Date Effective  :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_issue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 48);
            this.panel1.TabIndex = 921;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 48);
            this.label5.TabIndex = 850;
            this.label5.Text = "      Press Esc to close this form";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(380, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 28);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "   Cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_issue
            // 
            this.btn_issue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_issue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_issue.FlatAppearance.BorderSize = 0;
            this.btn_issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issue.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.ForeColor = System.Drawing.Color.White;
            this.btn_issue.Image = ((System.Drawing.Image)(resources.GetObject("btn_issue.Image")));
            this.btn_issue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issue.Location = new System.Drawing.Point(278, 11);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(99, 28);
            this.btn_issue.TabIndex = 8;
            this.btn_issue.Text = "   Save";
            this.btn_issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 925;
            this.label2.Text = "Decommission No :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_location
            // 
            this.btn_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_location.FlatAppearance.BorderSize = 0;
            this.btn_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_location.ForeColor = System.Drawing.Color.White;
            this.btn_location.Image = ((System.Drawing.Image)(resources.GetObject("btn_location.Image")));
            this.btn_location.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_location.Location = new System.Drawing.Point(380, 119);
            this.btn_location.Name = "btn_location";
            this.btn_location.Size = new System.Drawing.Size(96, 21);
            this.btn_location.TabIndex = 927;
            this.btn_location.Text = "      Search";
            this.btn_location.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 928;
            this.label1.Text = "Location :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AssetDecommissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 207);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btn_location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecomm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDateEffective);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtRequesttype);
            this.Controls.Add(this.btn_requesttype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRequestedby);
            this.Controls.Add(this.btn_requestedby);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AssetDecommissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Decommission";
            this.Load += new System.EventHandler(this.AssetIssuanceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssetIssuanceForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtRequesttype;
        private System.Windows.Forms.Button btn_requesttype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRequestedby;
        private System.Windows.Forms.Button btn_requestedby;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateEffective;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.TextBox txtDecomm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btn_location;
        private System.Windows.Forms.Label label1;
    }
}