namespace AMS.MasterFile.Asset
{
    partial class GenerateQRcodeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateQRcodeform));
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btn_itemtype = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.White;
            this.picQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.picQR.Location = new System.Drawing.Point(0, 0);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(301, 297);
            this.picQR.TabIndex = 1;
            this.picQR.TabStop = false;
            // 
            // btn_itemtype
            // 
            this.btn_itemtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_itemtype.FlatAppearance.BorderSize = 0;
            this.btn_itemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemtype.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemtype.ForeColor = System.Drawing.Color.White;
            this.btn_itemtype.Image = ((System.Drawing.Image)(resources.GetObject("btn_itemtype.Image")));
            this.btn_itemtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemtype.Location = new System.Drawing.Point(27, 303);
            this.btn_itemtype.Name = "btn_itemtype";
            this.btn_itemtype.Size = new System.Drawing.Size(119, 37);
            this.btn_itemtype.TabIndex = 4;
            this.btn_itemtype.Text = "           Generate QR code";
            this.btn_itemtype.UseVisualStyleBackColor = false;
            this.btn_itemtype.Click += new System.EventHandler(this.btn_itemtype_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(160, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "        Print QR code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label5);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 348);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(301, 25);
            this.panFoot.TabIndex = 1081;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 849;
            this.label5.Text = "      Press Esc to close this form";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenerateQRcodeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 373);
            this.Controls.Add(this.panFoot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_itemtype);
            this.Controls.Add(this.picQR);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GenerateQRcodeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate QR code";
            this.Load += new System.EventHandler(this.GenerateQRcodeform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenerateQRcodeform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button btn_itemtype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label5;
    }
}