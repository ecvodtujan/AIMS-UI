namespace AMS.Transaction.Request
{
    partial class PurchaseRequestform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseRequestform));
            this.dtpPurchasedate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPurchaseBy = new System.Windows.Forms.TextBox();
            this.btn_purchased = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtPurchaseno = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.txtCheckno = new System.Windows.Forms.TextBox();
            this.btn_purchaseno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPurchasedate
            // 
            this.dtpPurchasedate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPurchasedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchasedate.Location = new System.Drawing.Point(528, 12);
            this.dtpPurchasedate.Name = "dtpPurchasedate";
            this.dtpPurchasedate.Size = new System.Drawing.Size(127, 21);
            this.dtpPurchasedate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(431, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 856;
            this.label2.Text = "Date Purchased :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPurchaseBy
            // 
            this.txtPurchaseBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchaseBy.Location = new System.Drawing.Point(128, 123);
            this.txtPurchaseBy.Name = "txtPurchaseBy";
            this.txtPurchaseBy.ReadOnly = true;
            this.txtPurchaseBy.Size = new System.Drawing.Size(397, 21);
            this.txtPurchaseBy.TabIndex = 8;
            this.btxMsg.SetText(this.txtPurchaseBy, "Purchased by cannot be blank");
            this.btxMsg.SetTitle(this.txtPurchaseBy, null);
            this.txtPurchaseBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseBy_KeyDown);
            // 
            // btn_purchased
            // 
            this.btn_purchased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_purchased.FlatAppearance.BorderSize = 0;
            this.btn_purchased.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchased.ForeColor = System.Drawing.Color.White;
            this.btn_purchased.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchased.Image")));
            this.btn_purchased.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchased.Location = new System.Drawing.Point(528, 123);
            this.btn_purchased.Name = "btn_purchased";
            this.btn_purchased.Size = new System.Drawing.Size(95, 21);
            this.btn_purchased.TabIndex = 9;
            this.btn_purchased.Text = "      Search";
            this.btn_purchased.UseVisualStyleBackColor = false;
            this.btn_purchased.Click += new System.EventHandler(this.btn_purchased_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(48, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 858;
            this.label10.Text = "Purchase By :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchase.BackColor = System.Drawing.Color.White;
            this.btn_purchase.FlatAppearance.BorderSize = 2;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchase.Image")));
            this.btn_purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchase.Location = new System.Drawing.Point(423, 8);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(99, 28);
            this.btn_purchase.TabIndex = 11;
            this.btn_purchase.Text = "   Purchase";
            this.btn_purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 2;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(528, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(99, 28);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "   Cancel";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.unpost_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 44);
            this.panel1.TabIndex = 862;
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
            // txtPurchaseno
            // 
            this.txtPurchaseno.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPurchaseno.Location = new System.Drawing.Point(127, 12);
            this.txtPurchaseno.Name = "txtPurchaseno";
            this.txtPurchaseno.ReadOnly = true;
            this.txtPurchaseno.Size = new System.Drawing.Size(98, 21);
            this.txtPurchaseno.TabIndex = 0;
            this.btxMsg.SetText(this.txtPurchaseno, "Purchase no cannot be blank");
            this.txtPurchaseno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtPurchaseno, null);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSupplier.Location = new System.Drawing.Point(127, 96);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(397, 21);
            this.txtSupplier.TabIndex = 6;
            this.btxMsg.SetText(this.txtSupplier, "Supplier name cannot be blank");
            this.btxMsg.SetTitle(this.txtSupplier, null);
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(129, 150);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(526, 74);
            this.txtRemarks.TabIndex = 10;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // txtTerms
            // 
            this.txtTerms.BackColor = System.Drawing.Color.LightGray;
            this.txtTerms.Location = new System.Drawing.Point(127, 39);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.ReadOnly = true;
            this.txtTerms.Size = new System.Drawing.Size(127, 21);
            this.txtTerms.TabIndex = 3;
            this.btxMsg.SetText(this.txtTerms, "Terms cannot be blank");
            this.txtTerms.Text = "15";
            this.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtTerms, null);
            this.txtTerms.TextChanged += new System.EventHandler(this.txtTerms_TextChanged);
            // 
            // txtCheckno
            // 
            this.txtCheckno.BackColor = System.Drawing.Color.White;
            this.txtCheckno.Location = new System.Drawing.Point(127, 69);
            this.txtCheckno.Name = "txtCheckno";
            this.txtCheckno.Size = new System.Drawing.Size(127, 21);
            this.txtCheckno.TabIndex = 5;
            this.btxMsg.SetText(this.txtCheckno, "");
            this.txtCheckno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtCheckno, null);
            // 
            // btn_purchaseno
            // 
            this.btn_purchaseno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_purchaseno.FlatAppearance.BorderSize = 0;
            this.btn_purchaseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchaseno.ForeColor = System.Drawing.Color.White;
            this.btn_purchaseno.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchaseno.Image")));
            this.btn_purchaseno.Location = new System.Drawing.Point(227, 12);
            this.btn_purchaseno.Name = "btn_purchaseno";
            this.btn_purchaseno.Size = new System.Drawing.Size(27, 21);
            this.btn_purchaseno.TabIndex = 1;
            this.btn_purchaseno.UseVisualStyleBackColor = false;
            this.btn_purchaseno.Visible = false;
            this.btn_purchaseno.Click += new System.EventHandler(this.btn_purchaseno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 865;
            this.label1.Text = "Purchase Order  no. :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_supplier
            // 
            this.btn_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_supplier.FlatAppearance.BorderSize = 0;
            this.btn_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplier.ForeColor = System.Drawing.Color.White;
            this.btn_supplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_supplier.Image")));
            this.btn_supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplier.Location = new System.Drawing.Point(527, 96);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(96, 21);
            this.btn_supplier.TabIndex = 7;
            this.btn_supplier.Text = "      Search";
            this.btn_supplier.UseVisualStyleBackColor = false;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 874;
            this.label6.Text = "Supplier name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(66, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 881;
            this.label11.Text = "Remarks :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(77, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 882;
            this.label7.Text = "Terms :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(438, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 883;
            this.label3.Text = "Payment Type :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Location = new System.Drawing.Point(527, 37);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(128, 21);
            this.cboPaymentType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 885;
            this.label4.Text = "Check no. :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchaseRequestform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 284);
            this.Controls.Add(this.txtCheckno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPurchaseno);
            this.Controls.Add(this.btn_purchaseno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPurchaseBy);
            this.Controls.Add(this.btn_purchased);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpPurchasedate);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PurchaseRequestform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Request";
            this.Load += new System.EventHandler(this.PurchaseRequestform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseRequestform_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPurchasedate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPurchaseBy;
        private System.Windows.Forms.Button btn_purchased;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.TextBox txtPurchaseno;
        private System.Windows.Forms.Button btn_purchaseno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.TextBox txtCheckno;
        private System.Windows.Forms.Label label4;
    }
}