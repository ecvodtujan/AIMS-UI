using System;

namespace AMS.Admin
{
    partial class mdiMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.document_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.empMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.suppMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.assetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.assetTagSeriesMasterfile = new System.Windows.Forms.ToolStripMenuItem();
            this.deptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.positionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reasonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.planMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.locationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hurisLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.requestItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestForPaymentMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileSubscriptionMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.prepaidCardMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseMonitoringToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivatedAssetMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.decommissionMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolStripMenuItem2,
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.document_Menu,
            this.itemTypeMenu,
            this.empMenu,
            this.cmpMenu,
            this.suppMenu,
            this.toolStripSeparator3,
            this.userMenu,
            this.assetMenu,
            this.assetTagSeriesMasterfile,
            this.deptMenu,
            this.positionMenu,
            this.reasonMenu,
            this.planMenu,
            this.locationMenu,
            this.toolStripSeparator2,
            this.hurisLinkToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(76, 20);
            this.fileMenu.Text = "Master File";
            this.fileMenu.Click += new System.EventHandler(this.file_Menu_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newToolStripMenuItem.Text = "Brand";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // document_Menu
            // 
            this.document_Menu.Image = ((System.Drawing.Image)(resources.GetObject("document_Menu.Image")));
            this.document_Menu.Name = "document_Menu";
            this.document_Menu.Size = new System.Drawing.Size(157, 22);
            this.document_Menu.Text = "Document Type";
            this.document_Menu.Click += new System.EventHandler(this.document_Menu_Click);
            // 
            // itemTypeMenu
            // 
            this.itemTypeMenu.Image = ((System.Drawing.Image)(resources.GetObject("itemTypeMenu.Image")));
            this.itemTypeMenu.Name = "itemTypeMenu";
            this.itemTypeMenu.Size = new System.Drawing.Size(157, 22);
            this.itemTypeMenu.Text = "Item Type";
            this.itemTypeMenu.Click += new System.EventHandler(this.itemTypeMenu_Click);
            // 
            // empMenu
            // 
            this.empMenu.Image = ((System.Drawing.Image)(resources.GetObject("empMenu.Image")));
            this.empMenu.Name = "empMenu";
            this.empMenu.Size = new System.Drawing.Size(157, 22);
            this.empMenu.Text = "Employee";
            this.empMenu.Click += new System.EventHandler(this.empMenu_Click);
            // 
            // cmpMenu
            // 
            this.cmpMenu.Image = ((System.Drawing.Image)(resources.GetObject("cmpMenu.Image")));
            this.cmpMenu.Name = "cmpMenu";
            this.cmpMenu.Size = new System.Drawing.Size(157, 22);
            this.cmpMenu.Text = "Company";
            this.cmpMenu.Click += new System.EventHandler(this.cmpMenu_Click);
            // 
            // suppMenu
            // 
            this.suppMenu.Image = ((System.Drawing.Image)(resources.GetObject("suppMenu.Image")));
            this.suppMenu.Name = "suppMenu";
            this.suppMenu.Size = new System.Drawing.Size(157, 22);
            this.suppMenu.Text = "Supplier";
            this.suppMenu.Click += new System.EventHandler(this.suppMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // userMenu
            // 
            this.userMenu.Image = ((System.Drawing.Image)(resources.GetObject("userMenu.Image")));
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(157, 22);
            this.userMenu.Text = "User";
            this.userMenu.Click += new System.EventHandler(this.userMenu_Click_1);
            // 
            // assetMenu
            // 
            this.assetMenu.Image = ((System.Drawing.Image)(resources.GetObject("assetMenu.Image")));
            this.assetMenu.Name = "assetMenu";
            this.assetMenu.Size = new System.Drawing.Size(157, 22);
            this.assetMenu.Text = "Asset";
            this.assetMenu.Click += new System.EventHandler(this.asseMenu_Click);
            // 
            // assetTagSeriesMasterfile
            // 
            this.assetTagSeriesMasterfile.Image = ((System.Drawing.Image)(resources.GetObject("assetTagSeriesMasterfile.Image")));
            this.assetTagSeriesMasterfile.Name = "assetTagSeriesMasterfile";
            this.assetTagSeriesMasterfile.Size = new System.Drawing.Size(157, 22);
            this.assetTagSeriesMasterfile.Text = "Asset Tag Series";
            this.assetTagSeriesMasterfile.Click += new System.EventHandler(this.assetTagSeriesMasterfile_Click);
            // 
            // deptMenu
            // 
            this.deptMenu.Image = ((System.Drawing.Image)(resources.GetObject("deptMenu.Image")));
            this.deptMenu.Name = "deptMenu";
            this.deptMenu.Size = new System.Drawing.Size(157, 22);
            this.deptMenu.Text = "Department";
            this.deptMenu.Click += new System.EventHandler(this.deptMenu_Click_1);
            // 
            // positionMenu
            // 
            this.positionMenu.Image = ((System.Drawing.Image)(resources.GetObject("positionMenu.Image")));
            this.positionMenu.Name = "positionMenu";
            this.positionMenu.Size = new System.Drawing.Size(157, 22);
            this.positionMenu.Text = "Position";
            this.positionMenu.Click += new System.EventHandler(this.positionMenu_Click);
            // 
            // reasonMenu
            // 
            this.reasonMenu.Image = ((System.Drawing.Image)(resources.GetObject("reasonMenu.Image")));
            this.reasonMenu.Name = "reasonMenu";
            this.reasonMenu.Size = new System.Drawing.Size(157, 22);
            this.reasonMenu.Text = "Reason";
            this.reasonMenu.Click += new System.EventHandler(this.reasonMenu_Click);
            // 
            // planMenu
            // 
            this.planMenu.Image = ((System.Drawing.Image)(resources.GetObject("planMenu.Image")));
            this.planMenu.Name = "planMenu";
            this.planMenu.Size = new System.Drawing.Size(157, 22);
            this.planMenu.Text = "Plan";
            this.planMenu.Click += new System.EventHandler(this.planMenu_Click);
            // 
            // locationMenu
            // 
            this.locationMenu.Image = ((System.Drawing.Image)(resources.GetObject("locationMenu.Image")));
            this.locationMenu.Name = "locationMenu";
            this.locationMenu.Size = new System.Drawing.Size(157, 22);
            this.locationMenu.Text = "Location";
            this.locationMenu.Click += new System.EventHandler(this.locationMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // hurisLinkToolStripMenuItem
            // 
            this.hurisLinkToolStripMenuItem.Name = "hurisLinkToolStripMenuItem";
            this.hurisLinkToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hurisLinkToolStripMenuItem.Text = "Huris Link";
            this.hurisLinkToolStripMenuItem.Click += new System.EventHandler(this.hurisLinkToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestItemToolStripMenuItem,
            this.requestForPaymentMonitoringToolStripMenuItem,
            this.mobileSubscriptionMonitoringToolStripMenuItem,
            this.repairMonitoringToolStripMenuItem,
            this.toolStripSeparator4,
            this.prepaidCardMonitoringToolStripMenuItem,
            this.decommissionMonitoringToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem2.Text = "Transaction";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // requestItemToolStripMenuItem
            // 
            this.requestItemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("requestItemToolStripMenuItem.Image")));
            this.requestItemToolStripMenuItem.Name = "requestItemToolStripMenuItem";
            this.requestItemToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.requestItemToolStripMenuItem.Text = "Request Monitoring";
            this.requestItemToolStripMenuItem.Click += new System.EventHandler(this.requestItemToolStripMenuItem_Click);
            // 
            // requestForPaymentMonitoringToolStripMenuItem
            // 
            this.requestForPaymentMonitoringToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("requestForPaymentMonitoringToolStripMenuItem.Image")));
            this.requestForPaymentMonitoringToolStripMenuItem.Name = "requestForPaymentMonitoringToolStripMenuItem";
            this.requestForPaymentMonitoringToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.requestForPaymentMonitoringToolStripMenuItem.Text = "Request for Payment Monitoring";
            this.requestForPaymentMonitoringToolStripMenuItem.Click += new System.EventHandler(this.requestForPaymentMonitoringToolStripMenuItem_Click);
            // 
            // mobileSubscriptionMonitoringToolStripMenuItem
            // 
            this.mobileSubscriptionMonitoringToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mobileSubscriptionMonitoringToolStripMenuItem.Image")));
            this.mobileSubscriptionMonitoringToolStripMenuItem.Name = "mobileSubscriptionMonitoringToolStripMenuItem";
            this.mobileSubscriptionMonitoringToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.mobileSubscriptionMonitoringToolStripMenuItem.Text = "Mobile Subscription Monitoring";
            // 
            // repairMonitoringToolStripMenuItem
            // 
            this.repairMonitoringToolStripMenuItem.Name = "repairMonitoringToolStripMenuItem";
            this.repairMonitoringToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.repairMonitoringToolStripMenuItem.Text = "Repair Monitoring";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(248, 6);
            // 
            // prepaidCardMonitoringToolStripMenuItem
            // 
            this.prepaidCardMonitoringToolStripMenuItem.Name = "prepaidCardMonitoringToolStripMenuItem";
            this.prepaidCardMonitoringToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.prepaidCardMonitoringToolStripMenuItem.Text = "Prepaid Card Monitoring";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseMonitoringToolStripMenuItem1,
            this.deactivatedAssetMonitoringToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fileToolStripMenuItem.Text = "Inquiry";
            // 
            // purchaseMonitoringToolStripMenuItem1
            // 
            this.purchaseMonitoringToolStripMenuItem1.Name = "purchaseMonitoringToolStripMenuItem1";
            this.purchaseMonitoringToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.purchaseMonitoringToolStripMenuItem1.Text = "Purchase Monitoring";
            // 
            // deactivatedAssetMonitoringToolStripMenuItem
            // 
            this.deactivatedAssetMonitoringToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deactivatedAssetMonitoringToolStripMenuItem.Image")));
            this.deactivatedAssetMonitoringToolStripMenuItem.Name = "deactivatedAssetMonitoringToolStripMenuItem";
            this.deactivatedAssetMonitoringToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.deactivatedAssetMonitoringToolStripMenuItem.Text = "Deactivated Asset Monitoring";
            this.deactivatedAssetMonitoringToolStripMenuItem.Click += new System.EventHandler(this.deactivatedAssetMonitoringToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byCompanyToolStripMenuItem,
            this.byDateToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Reports";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // byCompanyToolStripMenuItem
            // 
            this.byCompanyToolStripMenuItem.Name = "byCompanyToolStripMenuItem";
            this.byCompanyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.byCompanyToolStripMenuItem.Text = "By Company";
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.byDateToolStripMenuItem.Text = "By Date";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(97, 20);
            this.windowsMenu.Text = "Arrange Forms";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogin,
            this.toolStripSeparator1,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem1});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLogin.Image")));
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(107, 22);
            this.tsmiLogin.Text = "Login";
            this.tsmiLogin.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Text = "About";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.toolStripSplitButton1,
            this.tsslUsername,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 571);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1108, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(129, 17);
            this.tsslStatus.Text = "Status : Not Connected";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(10, 17);
            this.toolStripSplitButton1.Text = "|";
            // 
            // tsslUsername
            // 
            this.tsslUsername.Name = "tsslUsername";
            this.tsslUsername.Size = new System.Drawing.Size(66, 17);
            this.tsslUsername.Text = "Username :";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // decommissionMonitoringToolStripMenuItem
            // 
            this.decommissionMonitoringToolStripMenuItem.Name = "decommissionMonitoringToolStripMenuItem";
            this.decommissionMonitoringToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.decommissionMonitoringToolStripMenuItem.Text = "Decommission Monitoring";
            this.decommissionMonitoringToolStripMenuItem.Click += new System.EventHandler(this.decommissionMonitoringToolStripMenuItem_Click);
            // 
            // mdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 593);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiMain";
            this.Text = "Asset Information and Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mdiMain_FormClosing);
            this.Load += new System.EventHandler(this.mdiMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsername;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem purchaseMonitoringToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem document_Menu;
        private System.Windows.Forms.ToolStripMenuItem itemTypeMenu;
        private System.Windows.Forms.ToolStripMenuItem empMenu;
        private System.Windows.Forms.ToolStripMenuItem cmpMenu;
        private System.Windows.Forms.ToolStripMenuItem suppMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem assetMenu;
        private System.Windows.Forms.ToolStripMenuItem assetTagSeriesMasterfile;
        private System.Windows.Forms.ToolStripMenuItem deptMenu;
        private System.Windows.Forms.ToolStripMenuItem positionMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem locationMenu;
        private System.Windows.Forms.ToolStripMenuItem reasonMenu;
        private System.Windows.Forms.ToolStripMenuItem planMenu;
        private System.Windows.Forms.ToolStripMenuItem requestForPaymentMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileSubscriptionMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem prepaidCardMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivatedAssetMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hurisLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decommissionMonitoringToolStripMenuItem;
    }
}



