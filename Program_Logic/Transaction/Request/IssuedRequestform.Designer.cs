namespace AMS.Transaction.Request
{
    partial class IssuedRequestform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuedRequestform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.unpost_btn = new System.Windows.Forms.Button();
            this.issued_btn = new System.Windows.Forms.Button();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtIssuedby = new System.Windows.Forms.TextBox();
            this.txtIssuedto = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btn_issuedby = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_issuedto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.unpost_btn);
            this.panel1.Controls.Add(this.issued_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 44);
            this.panel1.TabIndex = 863;
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
            this.label5.Size = new System.Drawing.Size(174, 44);
            this.label5.TabIndex = 850;
            this.label5.Text = "Press Esc to close this form";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unpost_btn
            // 
            this.unpost_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unpost_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.unpost_btn.FlatAppearance.BorderSize = 0;
            this.unpost_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unpost_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpost_btn.ForeColor = System.Drawing.Color.White;
            this.unpost_btn.Image = ((System.Drawing.Image)(resources.GetObject("unpost_btn.Image")));
            this.unpost_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unpost_btn.Location = new System.Drawing.Point(388, 6);
            this.unpost_btn.Name = "unpost_btn";
            this.unpost_btn.Size = new System.Drawing.Size(99, 28);
            this.unpost_btn.TabIndex = 9;
            this.unpost_btn.Text = "   Cancel";
            this.unpost_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unpost_btn.UseVisualStyleBackColor = false;
            this.unpost_btn.Click += new System.EventHandler(this.unpost_btn_Click);
            // 
            // issued_btn
            // 
            this.issued_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issued_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.issued_btn.FlatAppearance.BorderSize = 0;
            this.issued_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issued_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issued_btn.ForeColor = System.Drawing.Color.White;
            this.issued_btn.Image = ((System.Drawing.Image)(resources.GetObject("issued_btn.Image")));
            this.issued_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issued_btn.Location = new System.Drawing.Point(283, 6);
            this.issued_btn.Name = "issued_btn";
            this.issued_btn.Size = new System.Drawing.Size(99, 28);
            this.issued_btn.TabIndex = 8;
            this.issued_btn.Text = "   Issued";
            this.issued_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.issued_btn.UseVisualStyleBackColor = false;
            this.issued_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // txtIssuedby
            // 
            this.txtIssuedby.BackColor = System.Drawing.Color.White;
            this.txtIssuedby.Location = new System.Drawing.Point(119, 35);
            this.txtIssuedby.Name = "txtIssuedby";
            this.txtIssuedby.ReadOnly = true;
            this.txtIssuedby.Size = new System.Drawing.Size(257, 21);
            this.txtIssuedby.TabIndex = 1;
            this.btxMsg.SetText(this.txtIssuedby, "Issued by cannot be blank");
            this.btxMsg.SetTitle(this.txtIssuedby, null);
            // 
            // txtIssuedto
            // 
            this.txtIssuedto.BackColor = System.Drawing.Color.White;
            this.txtIssuedto.Location = new System.Drawing.Point(119, 62);
            this.txtIssuedto.Name = "txtIssuedto";
            this.txtIssuedto.ReadOnly = true;
            this.txtIssuedto.Size = new System.Drawing.Size(257, 21);
            this.txtIssuedto.TabIndex = 3;
            this.btxMsg.SetText(this.txtIssuedto, "Issued to cannot be blank");
            this.btxMsg.SetTitle(this.txtIssuedto, null);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(120, 116);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(354, 144);
            this.txtRemarks.TabIndex = 7;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBarcode.Location = new System.Drawing.Point(119, 89);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(127, 21);
            this.txtBarcode.TabIndex = 5;
            this.btxMsg.SetText(this.txtBarcode, "Purchased by cannot be blank");
            this.btxMsg.SetTitle(this.txtBarcode, null);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescription.Location = new System.Drawing.Point(249, 89);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(225, 21);
            this.txtDescription.TabIndex = 6;
            this.btxMsg.SetText(this.txtDescription, "Purchased by cannot be blank");
            this.btxMsg.SetTitle(this.txtDescription, null);
            // 
            // btn_issuedby
            // 
            this.btn_issuedby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_issuedby.FlatAppearance.BorderSize = 0;
            this.btn_issuedby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issuedby.ForeColor = System.Drawing.Color.White;
            this.btn_issuedby.Image = ((System.Drawing.Image)(resources.GetObject("btn_issuedby.Image")));
            this.btn_issuedby.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issuedby.Location = new System.Drawing.Point(378, 35);
            this.btn_issuedby.Name = "btn_issuedby";
            this.btn_issuedby.Size = new System.Drawing.Size(96, 21);
            this.btn_issuedby.TabIndex = 2;
            this.btn_issuedby.Text = "      Search";
            this.btn_issuedby.UseVisualStyleBackColor = false;
            this.btn_issuedby.Click += new System.EventHandler(this.btn_issuedby_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(49, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 868;
            this.label10.Text = "Issued by :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssued.Location = new System.Drawing.Point(119, 12);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(127, 21);
            this.dtpDateIssued.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 867;
            this.label2.Text = "Date Issued :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_issuedto
            // 
            this.btn_issuedto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_issuedto.FlatAppearance.BorderSize = 0;
            this.btn_issuedto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issuedto.ForeColor = System.Drawing.Color.White;
            this.btn_issuedto.Image = ((System.Drawing.Image)(resources.GetObject("btn_issuedto.Image")));
            this.btn_issuedto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_issuedto.Location = new System.Drawing.Point(378, 62);
            this.btn_issuedto.Name = "btn_issuedto";
            this.btn_issuedto.Size = new System.Drawing.Size(96, 21);
            this.btn_issuedto.TabIndex = 4;
            this.btn_issuedto.Text = "      Search";
            this.btn_issuedto.UseVisualStyleBackColor = false;
            this.btn_issuedto.Click += new System.EventHandler(this.btn_issuedto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 871;
            this.label1.Text = "Issued to :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(56, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 879;
            this.label11.Text = "Remarks :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 881;
            this.label3.Text = "Asset info. :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IssuedRequestform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 367);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIssuedto);
            this.Controls.Add(this.btn_issuedto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIssuedby);
            this.Controls.Add(this.btn_issuedby);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDateIssued);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "IssuedRequestform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issued Request";
            this.Load += new System.EventHandler(this.IssuedRequestform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IssuedRequestform_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button unpost_btn;
        private System.Windows.Forms.Button issued_btn;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.TextBox txtIssuedby;
        private System.Windows.Forms.Button btn_issuedby;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateIssued;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIssuedto;
        private System.Windows.Forms.Button btn_issuedto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
    }
}