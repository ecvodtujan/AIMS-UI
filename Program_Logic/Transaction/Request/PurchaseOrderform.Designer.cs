namespace AIMS.Transaction.Request
{
    partial class PurchaseOrderform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderform));
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPurchaseno = new System.Windows.Forms.TextBox();
            this.btn_purchaseno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_printPO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.txtPurchaseBy = new System.Windows.Forms.TextBox();
            this.btn_purchased = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPaymentTerms = new System.Windows.Forms.ComboBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(443, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 903;
            this.label7.Text = "Terms :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.Location = new System.Drawing.Point(128, 102);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(526, 74);
            this.txtRemarks.TabIndex = 896;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(66, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 902;
            this.label11.Text = "Remarks :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSupplier.Location = new System.Drawing.Point(127, 48);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(397, 20);
            this.txtSupplier.TabIndex = 892;
            this.btxMsg.SetText(this.txtSupplier, "Supplier cannot be blanked");
            this.btxMsg.SetTitle(this.txtSupplier, null);
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_Keydown);
            // 
            // btn_supplier
            // 
            this.btn_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_supplier.FlatAppearance.BorderSize = 0;
            this.btn_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplier.ForeColor = System.Drawing.Color.White;
            this.btn_supplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_supplier.Image")));
            this.btn_supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supplier.Location = new System.Drawing.Point(527, 48);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(96, 21);
            this.btn_supplier.TabIndex = 893;
            this.btn_supplier.Text = "      Search";
            this.btn_supplier.UseVisualStyleBackColor = false;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(42, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 901;
            this.label6.Text = "Supplier name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPurchaseno
            // 
            this.txtPurchaseno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchaseno.Location = new System.Drawing.Point(127, 15);
            this.txtPurchaseno.Name = "txtPurchaseno";
            this.txtPurchaseno.ReadOnly = true;
            this.txtPurchaseno.Size = new System.Drawing.Size(123, 20);
            this.txtPurchaseno.TabIndex = 886;
            this.btxMsg.SetText(this.txtPurchaseno, "Purchase No cannot be be blanked");
            this.txtPurchaseno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtPurchaseno, null);
            // 
            // btn_purchaseno
            // 
            this.btn_purchaseno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_purchaseno.FlatAppearance.BorderSize = 0;
            this.btn_purchaseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchaseno.ForeColor = System.Drawing.Color.White;
            this.btn_purchaseno.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchaseno.Image")));
            this.btn_purchaseno.Location = new System.Drawing.Point(254, 15);
            this.btn_purchaseno.Name = "btn_purchaseno";
            this.btn_purchaseno.Size = new System.Drawing.Size(27, 21);
            this.btn_purchaseno.TabIndex = 887;
            this.btn_purchaseno.UseVisualStyleBackColor = false;
            this.btn_purchaseno.Click += new System.EventHandler(this.btn_purchaseno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 900;
            this.label1.Text = "Purchase Order no :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btn_printPO);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 44);
            this.panel1.TabIndex = 899;
            // 
            // btn_printPO
            // 
            this.btn_printPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_printPO.BackColor = System.Drawing.Color.White;
            this.btn_printPO.FlatAppearance.BorderSize = 2;
            this.btn_printPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printPO.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printPO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_printPO.Image = ((System.Drawing.Image)(resources.GetObject("btn_printPO.Image")));
            this.btn_printPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_printPO.Location = new System.Drawing.Point(346, 8);
            this.btn_printPO.Name = "btn_printPO";
            this.btn_printPO.Size = new System.Drawing.Size(99, 28);
            this.btn_printPO.TabIndex = 851;
            this.btn_printPO.Text = "   Print PO";
            this.btn_printPO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_printPO.UseVisualStyleBackColor = false;
            this.btn_printPO.Click += new System.EventHandler(this.btn_printPO_Click);
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
            this.btn_close.Location = new System.Drawing.Point(550, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(99, 28);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "   Close";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchase.BackColor = System.Drawing.Color.White;
            this.btn_purchase.FlatAppearance.BorderSize = 2;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_purchase.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchase.Image")));
            this.btn_purchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchase.Location = new System.Drawing.Point(448, 8);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(99, 28);
            this.btn_purchase.TabIndex = 11;
            this.btn_purchase.Text = "   Save";
            this.btn_purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // txtPurchaseBy
            // 
            this.txtPurchaseBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurchaseBy.Location = new System.Drawing.Point(128, 75);
            this.txtPurchaseBy.Name = "txtPurchaseBy";
            this.txtPurchaseBy.ReadOnly = true;
            this.txtPurchaseBy.Size = new System.Drawing.Size(397, 20);
            this.txtPurchaseBy.TabIndex = 894;
            this.btxMsg.SetText(this.txtPurchaseBy, "Prepared by cannot be blanked");
            this.btxMsg.SetTitle(this.txtPurchaseBy, null);
            this.txtPurchaseBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreparedby_Keydown);
            // 
            // btn_purchased
            // 
            this.btn_purchased.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_purchased.FlatAppearance.BorderSize = 0;
            this.btn_purchased.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchased.ForeColor = System.Drawing.Color.White;
            this.btn_purchased.Image = ((System.Drawing.Image)(resources.GetObject("btn_purchased.Image")));
            this.btn_purchased.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_purchased.Location = new System.Drawing.Point(528, 75);
            this.btn_purchased.Name = "btn_purchased";
            this.btn_purchased.Size = new System.Drawing.Size(95, 21);
            this.btn_purchased.TabIndex = 895;
            this.btn_purchased.Text = "      Search";
            this.btn_purchased.UseVisualStyleBackColor = false;
            this.btn_purchased.Click += new System.EventHandler(this.btn_purchased_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(51, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 898;
            this.label10.Text = "Prepared By :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPaymentTerms
            // 
            this.cboPaymentTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentTerms.FormattingEnabled = true;
            this.cboPaymentTerms.Items.AddRange(new object[] {
            "15",
            "30",
            "60",
            "120"});
            this.cboPaymentTerms.Location = new System.Drawing.Point(492, 16);
            this.cboPaymentTerms.Name = "cboPaymentTerms";
            this.cboPaymentTerms.Size = new System.Drawing.Size(128, 21);
            this.cboPaymentTerms.TabIndex = 904;
            // 
            // txtTerms
            // 
            this.txtTerms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTerms.Location = new System.Drawing.Point(302, 17);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.ReadOnly = true;
            this.txtTerms.Size = new System.Drawing.Size(123, 20);
            this.txtTerms.TabIndex = 905;
            this.btxMsg.SetText(this.txtTerms, "Please select the Terms!");
            this.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtTerms, null);
            this.txtTerms.Visible = false;
            // 
            // PurchaseOrderform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 237);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.cboPaymentTerms);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PurchaseOrderform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.PurchaseOrderform_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPurchaseno;
        private System.Windows.Forms.Button btn_purchaseno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.TextBox txtPurchaseBy;
        private System.Windows.Forms.Button btn_purchased;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_printPO;
        private System.Windows.Forms.ComboBox cboPaymentTerms;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.TextBox txtTerms;
    }
}