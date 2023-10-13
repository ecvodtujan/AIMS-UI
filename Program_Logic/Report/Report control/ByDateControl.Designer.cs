namespace AIMS.Report.Report_control
{
    partial class ByDateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByDateControl));
            this.post_btn = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.dtpYearTo = new System.Windows.Forms.DateTimePicker();
            this.dtpYearFrom = new System.Windows.Forms.DateTimePicker();
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
            this.post_btn.TabIndex = 913;
            this.post_btn.Text = "Print Report";
            this.post_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.post_btn.UseVisualStyleBackColor = false;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Enabled = false;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "Warranty Date",
            "Purchase Date",
            "Manufacturing Date",
            "All"});
            this.cboYear.Location = new System.Drawing.Point(109, 40);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(157, 21);
            this.cboYear.TabIndex = 1090;
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.BackColor = System.Drawing.Color.Transparent;
            this.chkYear.ForeColor = System.Drawing.Color.Transparent;
            this.chkYear.Location = new System.Drawing.Point(34, 44);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(69, 17);
            this.chkYear.TabIndex = 1091;
            this.chkYear.Text = "By Year :";
            this.chkYear.UseVisualStyleBackColor = false;
            // 
            // dtpYearTo
            // 
            this.dtpYearTo.CustomFormat = "yyyy";
            this.dtpYearTo.Enabled = false;
            this.dtpYearTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearTo.Location = new System.Drawing.Point(192, 67);
            this.dtpYearTo.Name = "dtpYearTo";
            this.dtpYearTo.ShowUpDown = true;
            this.dtpYearTo.Size = new System.Drawing.Size(74, 20);
            this.dtpYearTo.TabIndex = 1093;
            // 
            // dtpYearFrom
            // 
            this.dtpYearFrom.CustomFormat = "yyyy";
            this.dtpYearFrom.Enabled = false;
            this.dtpYearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearFrom.Location = new System.Drawing.Point(110, 67);
            this.dtpYearFrom.Name = "dtpYearFrom";
            this.dtpYearFrom.ShowUpDown = true;
            this.dtpYearFrom.Size = new System.Drawing.Size(74, 20);
            this.dtpYearFrom.TabIndex = 1092;
            // 
            // ByDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dtpYearTo);
            this.Controls.Add(this.dtpYearFrom);
            this.Controls.Add(this.chkYear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.post_btn);
            this.Name = "ByDateControl";
            this.Size = new System.Drawing.Size(403, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.DateTimePicker dtpYearTo;
        private System.Windows.Forms.DateTimePicker dtpYearFrom;
    }
}
