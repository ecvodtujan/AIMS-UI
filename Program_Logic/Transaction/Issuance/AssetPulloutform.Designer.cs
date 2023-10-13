namespace AMS.Transaction.Issuance
{
    partial class AssetPulloutform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetPulloutform));
            this.dtpPullout = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPulloutby = new System.Windows.Forms.TextBox();
            this.btn_issuedto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtPulloutRemarks = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtAssetInfo = new System.Windows.Forms.TextBox();
            this.txtDateIssued = new System.Windows.Forms.TextBox();
            this.txtIssuedTo = new System.Windows.Forms.TextBox();
            this.txtpulloutReason = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_preason = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPullout
            // 
            this.dtpPullout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPullout.Location = new System.Drawing.Point(107, 127);
            this.dtpPullout.Name = "dtpPullout";
            this.dtpPullout.Size = new System.Drawing.Size(127, 21);
            this.dtpPullout.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(25, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 925;
            this.label19.Text = "Date Pullout :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPulloutby
            // 
            this.txtPulloutby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPulloutby.Location = new System.Drawing.Point(107, 154);
            this.txtPulloutby.Name = "txtPulloutby";
            this.txtPulloutby.ReadOnly = true;
            this.txtPulloutby.Size = new System.Drawing.Size(256, 21);
            this.txtPulloutby.TabIndex = 5;
            this.btxMsg.SetText(this.txtPulloutby, "Pullout by cannot be blank");
            this.btxMsg.SetTitle(this.txtPulloutby, null);
            // 
            // btn_issuedto
            // 
            this.btn_issuedto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_issuedto.FlatAppearance.BorderSize = 0;
            this.btn_issuedto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issuedto.ForeColor = System.Drawing.Color.White;
            this.btn_issuedto.Image = ((System.Drawing.Image)(resources.GetObject("btn_issuedto.Image")));
            this.btn_issuedto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issuedto.Location = new System.Drawing.Point(365, 154);
            this.btn_issuedto.Name = "btn_issuedto";
            this.btn_issuedto.Size = new System.Drawing.Size(96, 21);
            this.btn_issuedto.TabIndex = 6;
            this.btn_issuedto.Text = "      Search";
            this.btn_issuedto.UseVisualStyleBackColor = false;
            this.btn_issuedto.Click += new System.EventHandler(this.btn_issuedto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 924;
            this.label6.Text = "Pullout by :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_issue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 48);
            this.panel1.TabIndex = 926;
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
            this.btn_cancel.Location = new System.Drawing.Point(376, 11);
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
            this.btn_issue.Location = new System.Drawing.Point(271, 11);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(99, 28);
            this.btn_issue.TabIndex = 8;
            this.btn_issue.Text = "   Save";
            this.btn_issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // txtPulloutRemarks
            // 
            this.txtPulloutRemarks.BackColor = System.Drawing.Color.White;
            this.txtPulloutRemarks.Location = new System.Drawing.Point(107, 210);
            this.txtPulloutRemarks.Multiline = true;
            this.txtPulloutRemarks.Name = "txtPulloutRemarks";
            this.txtPulloutRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPulloutRemarks.Size = new System.Drawing.Size(354, 87);
            this.txtPulloutRemarks.TabIndex = 7;
            this.btxMsg.SetText(this.txtPulloutRemarks, null);
            this.btxMsg.SetTitle(this.txtPulloutRemarks, null);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBarcode.Location = new System.Drawing.Point(107, 21);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(256, 21);
            this.txtBarcode.TabIndex = 0;
            this.btxMsg.SetText(this.txtBarcode, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtBarcode, null);
            // 
            // txtAssetInfo
            // 
            this.txtAssetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAssetInfo.Location = new System.Drawing.Point(107, 47);
            this.txtAssetInfo.Name = "txtAssetInfo";
            this.txtAssetInfo.ReadOnly = true;
            this.txtAssetInfo.Size = new System.Drawing.Size(256, 21);
            this.txtAssetInfo.TabIndex = 1;
            this.btxMsg.SetText(this.txtAssetInfo, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtAssetInfo, null);
            // 
            // txtDateIssued
            // 
            this.txtDateIssued.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDateIssued.Location = new System.Drawing.Point(107, 74);
            this.txtDateIssued.Name = "txtDateIssued";
            this.txtDateIssued.ReadOnly = true;
            this.txtDateIssued.Size = new System.Drawing.Size(256, 21);
            this.txtDateIssued.TabIndex = 2;
            this.btxMsg.SetText(this.txtDateIssued, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtDateIssued, null);
            // 
            // txtIssuedTo
            // 
            this.txtIssuedTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIssuedTo.Location = new System.Drawing.Point(107, 101);
            this.txtIssuedTo.Name = "txtIssuedTo";
            this.txtIssuedTo.ReadOnly = true;
            this.txtIssuedTo.Size = new System.Drawing.Size(256, 21);
            this.txtIssuedTo.TabIndex = 3;
            this.btxMsg.SetText(this.txtIssuedTo, "Brand cannot be blank");
            this.btxMsg.SetTitle(this.txtIssuedTo, null);
            // 
            // txtpulloutReason
            // 
            this.txtpulloutReason.BackColor = System.Drawing.Color.Gainsboro;
            this.txtpulloutReason.Location = new System.Drawing.Point(107, 182);
            this.txtpulloutReason.Multiline = true;
            this.txtpulloutReason.Name = "txtpulloutReason";
            this.txtpulloutReason.ReadOnly = true;
            this.txtpulloutReason.Size = new System.Drawing.Size(256, 21);
            this.txtpulloutReason.TabIndex = 937;
            this.btxMsg.SetText(this.txtpulloutReason, null);
            this.btxMsg.SetTitle(this.txtpulloutReason, null);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 928;
            this.label11.Text = "Pullout Remarks :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 934;
            this.label2.Text = "Barcode :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 933;
            this.label1.Text = "Asset Info. :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 932;
            this.label3.Text = "Date Issued :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 936;
            this.label4.Text = "Issued to :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 938;
            this.label7.Text = "Pullout Reason :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_preason
            // 
            this.btn_preason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_preason.FlatAppearance.BorderSize = 0;
            this.btn_preason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preason.ForeColor = System.Drawing.Color.White;
            this.btn_preason.Image = ((System.Drawing.Image)(resources.GetObject("btn_preason.Image")));
            this.btn_preason.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_preason.Location = new System.Drawing.Point(366, 182);
            this.btn_preason.Name = "btn_preason";
            this.btn_preason.Size = new System.Drawing.Size(96, 20);
            this.btn_preason.TabIndex = 939;
            this.btn_preason.Text = "      Search";
            this.btn_preason.UseVisualStyleBackColor = false;
            this.btn_preason.Click += new System.EventHandler(this.btn_pulloutReason_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 851;
            this.label8.Text = "0";
            // 
            // AssetPulloutform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 368);
            this.Controls.Add(this.btn_preason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpulloutReason);
            this.Controls.Add(this.txtIssuedTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateIssued);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAssetInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPulloutRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpPullout);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPulloutby);
            this.Controls.Add(this.btn_issuedto);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AssetPulloutform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pullout Asset";
            this.Load += new System.EventHandler(this.AssetPulloutform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AssetPulloutform_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPullout;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPulloutby;
        private System.Windows.Forms.Button btn_issuedto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_issue;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.TextBox txtPulloutRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssetInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDateIssued;
        private System.Windows.Forms.TextBox txtIssuedTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpulloutReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_preason;
        private System.Windows.Forms.Label label8;
    }
}