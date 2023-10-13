namespace AMS.Report
{
    partial class ReportViewerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewerform));
            this.CrysViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrysViewer
            // 
            this.CrysViewer.ActiveViewIndex = -1;
            this.CrysViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrysViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrysViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrysViewer.Location = new System.Drawing.Point(0, 0);
            this.CrysViewer.Name = "CrysViewer";
            this.CrysViewer.Size = new System.Drawing.Size(782, 486);
            this.CrysViewer.TabIndex = 6;
            this.CrysViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrysViewer.Load += new System.EventHandler(this.CrysViewer_Load);
            // 
            // ReportViewerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 486);
            this.Controls.Add(this.CrysViewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ReportViewerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewerform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportViewerform_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrysViewer;
    }
}