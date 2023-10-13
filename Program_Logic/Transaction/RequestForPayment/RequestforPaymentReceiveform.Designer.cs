namespace AMS.Transaction.RequestForPayment
{
    partial class RequestforPaymentReceiveform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestforPaymentReceiveform));
            this.post_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestno = new System.Windows.Forms.TextBox();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.post_btn.Location = new System.Drawing.Point(12, 78);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(354, 42);
            this.post_btn.TabIndex = 1081;
            this.post_btn.Text = "Receive Request for Payment";
            this.post_btn.UseVisualStyleBackColor = false;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1082;
            this.label1.Text = "Request no. :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRequestno
            // 
            this.txtRequestno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRequestno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRequestno.Location = new System.Drawing.Point(12, 31);
            this.txtRequestno.Name = "txtRequestno";
            this.txtRequestno.ReadOnly = true;
            this.txtRequestno.Size = new System.Drawing.Size(98, 21);
            this.txtRequestno.TabIndex = 1077;
            this.txtRequestno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceivedDate.Location = new System.Drawing.Point(239, 31);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(127, 21);
            this.dtpReceivedDate.TabIndex = 1078;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(236, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1083;
            this.label2.Text = "Date received :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 24);
            this.label3.TabIndex = 1084;
            this.label3.Text = "      Press Escape key to close";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RequestforPaymentReceiveform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.post_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequestno);
            this.Controls.Add(this.dtpReceivedDate);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "RequestforPaymentReceiveform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receive Request for Payment";
            this.Load += new System.EventHandler(this.RequestforPaymentReceiveform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RequestforPaymentReceiveform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestno;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}