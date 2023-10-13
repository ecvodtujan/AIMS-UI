namespace AMS.Inquiry
{
    partial class Searchform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searchform));
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lsvList = new System.Windows.Forms.ListView();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeyword.Location = new System.Drawing.Point(0, 0);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(558, 21);
            this.txtKeyword.TabIndex = 1077;
            this.txtKeyword.Text = "Enter Keyword here";
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.GotFocus += new System.EventHandler(this.txtkeyword_GotFocus);
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            this.txtKeyword.LostFocus += new System.EventHandler(this.txtkeyword_LostFocus);
            // 
            // lsvList
            // 
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 21);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(558, 448);
            this.lsvList.TabIndex = 1078;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            this.lsvList.DoubleClick += new System.EventHandler(this.lsvList_DoubleClick);
            this.lsvList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvList_KeyDown);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label3);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 444);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(558, 25);
            this.panFoot.TabIndex = 1079;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 23);
            this.label3.TabIndex = 849;
            this.label3.Text = "Press F1 to Add Record  /  Press Esc to close this form";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 469);
            this.Controls.Add(this.panFoot);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.txtKeyword);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Searchform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Searchform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Searchform_KeyDown);
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        internal System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label3;
    }
}