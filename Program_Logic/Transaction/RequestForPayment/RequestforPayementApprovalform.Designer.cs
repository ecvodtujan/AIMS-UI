namespace AMS.Transaction.RequestForPayment
{
    partial class RequestforPayementApprovalform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestforPayementApprovalform));
            this.post_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestno = new System.Windows.Forms.TextBox();
            this.dtpReplyDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckno = new System.Windows.Forms.TextBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtCVno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // post_btn
            // 
            this.post_btn.BackColor = System.Drawing.Color.White;
            this.post_btn.FlatAppearance.BorderSize = 2;
            this.post_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.post_btn.Image = ((System.Drawing.Image)(resources.GetObject("post_btn.Image")));
            this.post_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.post_btn.Location = new System.Drawing.Point(12, 333);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(354, 34);
            this.post_btn.TabIndex = 1081;
            this.post_btn.Text = "Approve";
            this.post_btn.UseVisualStyleBackColor = false;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1085;
            this.label8.Text = "Remarks :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(12, 242);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(354, 85);
            this.txtRemarks.TabIndex = 4;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotalAmount.Location = new System.Drawing.Point(14, 115);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(127, 21);
            this.txtTotalAmount.TabIndex = 3;
            this.btxMsg.SetText(this.txtTotalAmount, null);
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtTotalAmount, null);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1084;
            this.label6.Text = "Total Amount :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1082;
            this.label1.Text = "Request no. :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRequestno
            // 
            this.txtRequestno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRequestno.Location = new System.Drawing.Point(12, 32);
            this.txtRequestno.Name = "txtRequestno";
            this.txtRequestno.ReadOnly = true;
            this.txtRequestno.Size = new System.Drawing.Size(127, 21);
            this.txtRequestno.TabIndex = 0;
            this.btxMsg.SetText(this.txtRequestno, null);
            this.txtRequestno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtRequestno, null);
            // 
            // dtpReplyDate
            // 
            this.dtpReplyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReplyDate.Location = new System.Drawing.Point(12, 72);
            this.dtpReplyDate.Name = "dtpReplyDate";
            this.dtpReplyDate.Size = new System.Drawing.Size(127, 21);
            this.dtpReplyDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1083;
            this.label2.Text = "Reply Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(239, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1087;
            this.label3.Text = "Check no.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCheckno
            // 
            this.txtCheckno.BackColor = System.Drawing.Color.White;
            this.txtCheckno.Location = new System.Drawing.Point(239, 73);
            this.txtCheckno.Name = "txtCheckno";
            this.txtCheckno.Size = new System.Drawing.Size(127, 21);
            this.txtCheckno.TabIndex = 1;
            this.btxMsg.SetText(this.txtCheckno, "Check no. cannot be blank");
            this.txtCheckno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtCheckno, null);
            // 
            // txtPurpose
            // 
            this.txtPurpose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurpose.Location = new System.Drawing.Point(12, 159);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.ReadOnly = true;
            this.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPurpose.Size = new System.Drawing.Size(354, 51);
            this.txtPurpose.TabIndex = 1089;
            this.btxMsg.SetText(this.txtPurpose, null);
            this.btxMsg.SetTitle(this.txtPurpose, null);
            // 
            // txtCVno
            // 
            this.txtCVno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCVno.Location = new System.Drawing.Point(239, 30);
            this.txtCVno.Name = "txtCVno";
            this.txtCVno.Size = new System.Drawing.Size(127, 21);
            this.txtCVno.TabIndex = 1091;
            this.btxMsg.SetText(this.txtCVno, "Check no. cannot be blank");
            this.txtCVno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtCVno, null);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 24);
            this.label4.TabIndex = 1088;
            this.label4.Text = "      Press Escape key to close";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1090;
            this.label5.Text = "Purpose :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(236, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1092;
            this.label7.Text = "CV no.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RequestforPayementApprovalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 394);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCVno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCheckno);
            this.Controls.Add(this.post_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequestno);
            this.Controls.Add(this.dtpReplyDate);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "RequestforPayementApprovalform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request for Payment Approval";
            this.Load += new System.EventHandler(this.RequestforPayementApprovalform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RequestforPayementApprovalform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestno;
        private System.Windows.Forms.DateTimePicker dtpReplyDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckno;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.TextBox txtCVno;
        private System.Windows.Forms.Label label7;
    }
}