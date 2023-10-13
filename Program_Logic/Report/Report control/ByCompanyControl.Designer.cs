namespace AIMS.Report.Report_control
{
    partial class ByCompanyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByCompanyControl));
            this.post_btn = new System.Windows.Forms.Button();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // post_btn
            // 
            this.post_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.post_btn.FlatAppearance.BorderSize = 0;
            this.post_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.ForeColor = System.Drawing.Color.White;
            this.post_btn.Image = ((System.Drawing.Image)(resources.GetObject("post_btn.Image")));
            this.post_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.post_btn.Location = new System.Drawing.Point(281, 111);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(119, 37);
            this.post_btn.TabIndex = 912;
            this.post_btn.Text = "Print Report";
            this.post_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.post_btn.UseVisualStyleBackColor = false;
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Enabled = false;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Items.AddRange(new object[] {
            "ZMG",
            "APS",
            "ASI",
            "APW",
            "All"});
            this.cboCompany.Location = new System.Drawing.Point(158, 54);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(142, 21);
            this.cboCompany.TabIndex = 1087;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.BackColor = System.Drawing.Color.Transparent;
            this.chkCompany.ForeColor = System.Drawing.Color.Transparent;
            this.chkCompany.Location = new System.Drawing.Point(80, 57);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(76, 17);
            this.chkCompany.TabIndex = 1086;
            this.chkCompany.Text = "Company :";
            this.chkCompany.UseVisualStyleBackColor = false;
            // 
            // ByCompanyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.chkCompany);
            this.Controls.Add(this.post_btn);
            this.Name = "ByCompanyControl";
            this.Size = new System.Drawing.Size(403, 151);
            this.Load += new System.EventHandler(this.ByCompanyControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.CheckBox chkCompany;
    }
}
