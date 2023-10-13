namespace AMS.Transaction.Issuance
{
    partial class AssetIssuanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetIssuanceForm));
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtIssuedBy = new System.Windows.Forms.TextBox();
            this.txtIssuedTo = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtAssetInfo = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_issuedby = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_issuedto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIssuedBy
            // 
            this.txtIssuedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIssuedBy.Location = new System.Drawing.Point(121, 119);
            this.txtIssuedBy.Name = "txtIssuedBy";
            this.txtIssuedBy.ReadOnly = true;
            this.txtIssuedBy.Size = new System.Drawing.Size(256, 21);
            this.txtIssuedBy.TabIndex = 5;
            this.btxMsg.SetText(this.txtIssuedBy, "Issued by cannot be blank");
            this.btxMsg.SetTitle(this.txtIssuedBy, null);
            this.txtIssuedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssuedBy_KeyDown);
            // 
            // txtIssuedTo
            // 
            this.txtIssuedTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIssuedTo.Location = new System.Drawing.Point(121, 92);
            this.txtIssuedTo.Name = "txtIssuedTo";
            this.txtIssuedTo.ReadOnly = true;
            this.txtIssuedTo.Size = new System.Drawing.Size(256, 21);
            this.txtIssuedTo.TabIndex = 3;
            this.btxMsg.SetText(this.txtIssuedTo, "Issued to canno be blank");
            this.btxMsg.SetTitle(this.txtIssuedTo, null);
            this.txtIssuedTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIssuedTo_KeyDown);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(121, 146);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(354, 87);
            this.txtRemarks.TabIndex = 7;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // txtAssetInfo
            // 
            this.txtAssetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAssetInfo.Location = new System.Drawing.Point(121, 38);
            this.txtAssetInfo.Name = "txtAssetInfo";
            this.txtAssetInfo.ReadOnly = true;
            this.txtAssetInfo.Size = new System.Drawing.Size(256, 21);
            this.txtAssetInfo.TabIndex = 1;
            this.btxMsg.SetText(this.txtAssetInfo, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtAssetInfo, null);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBarcode.Location = new System.Drawing.Point(121, 12);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(256, 21);
            this.txtBarcode.TabIndex = 0;
            this.btxMsg.SetText(this.txtBarcode, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtBarcode, null);
            // 
            // btn_issuedby
            // 
            this.btn_issuedby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_issuedby.FlatAppearance.BorderSize = 0;
            this.btn_issuedby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issuedby.ForeColor = System.Drawing.Color.White;
            this.btn_issuedby.Image = ((System.Drawing.Image)(resources.GetObject("btn_issuedby.Image")));
            this.btn_issuedby.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issuedby.Location = new System.Drawing.Point(379, 119);
            this.btn_issuedby.Name = "btn_issuedby";
            this.btn_issuedby.Size = new System.Drawing.Size(96, 21);
            this.btn_issuedby.TabIndex = 6;
            this.btn_issuedby.Text = "      Search";
            this.btn_issuedby.UseVisualStyleBackColor = false;
            this.btn_issuedby.Click += new System.EventHandler(this.btn_issuedby_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 916;
            this.label3.Text = "Issued by :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_issuedto
            // 
            this.btn_issuedto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_issuedto.FlatAppearance.BorderSize = 0;
            this.btn_issuedto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issuedto.ForeColor = System.Drawing.Color.White;
            this.btn_issuedto.Image = ((System.Drawing.Image)(resources.GetObject("btn_issuedto.Image")));
            this.btn_issuedto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issuedto.Location = new System.Drawing.Point(379, 92);
            this.btn_issuedto.Name = "btn_issuedto";
            this.btn_issuedto.Size = new System.Drawing.Size(96, 21);
            this.btn_issuedto.TabIndex = 4;
            this.btn_issuedto.Text = "      Search";
            this.btn_issuedto.UseVisualStyleBackColor = false;
            this.btn_issuedto.Click += new System.EventHandler(this.btn_issuedto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(54, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 915;
            this.label6.Text = "Issued to :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(58, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 918;
            this.label11.Text = "Remarks :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssue.Location = new System.Drawing.Point(121, 65);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(127, 21);
            this.dtpDateIssue.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(41, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 920;
            this.label19.Text = "Date Issued :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_issue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
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
            this.btn_cancel.Location = new System.Drawing.Point(377, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 28);
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
            this.btn_issue.Location = new System.Drawing.Point(272, 11);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(99, 28);
            this.btn_issue.TabIndex = 8;
            this.btn_issue.Text = "   Issue";
            this.btn_issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 923;
            this.label1.Text = "Asset Info. :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 925;
            this.label2.Text = "Barcode :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AssetIssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 287);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAssetInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDateIssue);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIssuedBy);
            this.Controls.Add(this.btn_issuedby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIssuedTo);
            this.Controls.Add(this.btn_issuedto);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AssetIssuanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Issuance";
            this.Load += new System.EventHandler(this.AssetIssuanceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssetIssuanceForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtIssuedBy;
        private System.Windows.Forms.Button btn_issuedby;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIssuedTo;
        private System.Windows.Forms.Button btn_issuedto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDateIssue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.TextBox txtAssetInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}