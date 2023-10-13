namespace AMS.MasterFile.Employee
{
    partial class EmployeeInformationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInformationControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.emp_add_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_edit_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_deactivate_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_activate_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_print_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_save_btn = new System.Windows.Forms.ToolStripButton();
            this.emp_cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btn_company = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatecreated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsercreated = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_position = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_department = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.panFoot = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emp_add_btn,
            this.emp_edit_btn,
            this.emp_deactivate_btn,
            this.emp_activate_btn,
            this.emp_print_btn,
            this.emp_save_btn,
            this.emp_cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 39);
            this.toolStrip1.TabIndex = 1052;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // emp_add_btn
            // 
            this.emp_add_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_add_btn.Image")));
            this.emp_add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_add_btn.Name = "emp_add_btn";
            this.emp_add_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_add_btn.ToolTipText = "add record";
            this.emp_add_btn.Click += new System.EventHandler(this.emp_add_btn_Click);
            // 
            // emp_edit_btn
            // 
            this.emp_edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_edit_btn.Image")));
            this.emp_edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_edit_btn.Name = "emp_edit_btn";
            this.emp_edit_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_edit_btn.ToolTipText = "Edit record";
            this.emp_edit_btn.Click += new System.EventHandler(this.emp_edit_btn_Click);
            // 
            // emp_deactivate_btn
            // 
            this.emp_deactivate_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_deactivate_btn.Image")));
            this.emp_deactivate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_deactivate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_deactivate_btn.Name = "emp_deactivate_btn";
            this.emp_deactivate_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_deactivate_btn.ToolTipText = "Deactivate record";
            this.emp_deactivate_btn.Click += new System.EventHandler(this.emp_deactivate_btn_Click);
            // 
            // emp_activate_btn
            // 
            this.emp_activate_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_activate_btn.Image")));
            this.emp_activate_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_activate_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_activate_btn.Name = "emp_activate_btn";
            this.emp_activate_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_activate_btn.ToolTipText = "Activate record";
            this.emp_activate_btn.Click += new System.EventHandler(this.emp_activate_btn_Click);
            // 
            // emp_print_btn
            // 
            this.emp_print_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_print_btn.Image")));
            this.emp_print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_print_btn.Name = "emp_print_btn";
            this.emp_print_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_print_btn.ToolTipText = "Print record";
            this.emp_print_btn.Click += new System.EventHandler(this.emp_print_btn_Click);
            // 
            // emp_save_btn
            // 
            this.emp_save_btn.Enabled = false;
            this.emp_save_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_save_btn.Image")));
            this.emp_save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_save_btn.Name = "emp_save_btn";
            this.emp_save_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_save_btn.ToolTipText = "save record";
            this.emp_save_btn.Click += new System.EventHandler(this.emp_save_btn_Click);
            // 
            // emp_cancel_btn
            // 
            this.emp_cancel_btn.Enabled = false;
            this.emp_cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("emp_cancel_btn.Image")));
            this.emp_cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emp_cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emp_cancel_btn.Name = "emp_cancel_btn";
            this.emp_cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.emp_cancel_btn.ToolTipText = "cancel record";
            this.emp_cancel_btn.Click += new System.EventHandler(this.emp_cancel_btn_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(113, 137);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(259, 21);
            this.txtCompanyName.TabIndex = 1087;
            this.btxMsg.SetText(this.txtCompanyName, "Company cannot be blank");
            this.btxMsg.SetTitle(this.txtCompanyName, null);
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            this.txtCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyName_Keydown);
            // 
            // btn_company
            // 
            this.btn_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_company.Enabled = false;
            this.btn_company.FlatAppearance.BorderSize = 0;
            this.btn_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_company.ForeColor = System.Drawing.Color.White;
            this.btn_company.Image = ((System.Drawing.Image)(resources.GetObject("btn_company.Image")));
            this.btn_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company.Location = new System.Drawing.Point(376, 137);
            this.btn_company.Name = "btn_company";
            this.btn_company.Size = new System.Drawing.Size(96, 21);
            this.btn_company.TabIndex = 1088;
            this.btn_company.Text = "      Search";
            this.btn_company.UseVisualStyleBackColor = false;
            this.btn_company.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1096;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1095;
            this.label5.Text = "Date Created :";
            // 
            // txtDatecreated
            // 
            this.txtDatecreated.BackColor = System.Drawing.Color.Silver;
            this.txtDatecreated.Location = new System.Drawing.Point(115, 73);
            this.txtDatecreated.Name = "txtDatecreated";
            this.txtDatecreated.ReadOnly = true;
            this.txtDatecreated.Size = new System.Drawing.Size(102, 21);
            this.txtDatecreated.TabIndex = 1095;
            this.btxMsg.SetText(this.txtDatecreated, null);
            this.txtDatecreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtDatecreated, null);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1094;
            this.label7.Text = "User Created :";
            // 
            // txtUsercreated
            // 
            this.txtUsercreated.BackColor = System.Drawing.Color.Silver;
            this.txtUsercreated.Location = new System.Drawing.Point(115, 46);
            this.txtUsercreated.Name = "txtUsercreated";
            this.txtUsercreated.ReadOnly = true;
            this.txtUsercreated.Size = new System.Drawing.Size(102, 21);
            this.txtUsercreated.TabIndex = 1094;
            this.btxMsg.SetText(this.txtUsercreated, null);
            this.txtUsercreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtUsercreated, null);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Silver;
            this.txtStatus.Location = new System.Drawing.Point(115, 19);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(102, 21);
            this.txtStatus.TabIndex = 1093;
            this.btxMsg.SetText(this.txtStatus, null);
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btxMsg.SetTitle(this.txtStatus, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1093;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1092;
            this.label4.Text = "Company:";
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.White;
            this.txtlname.Location = new System.Drawing.Point(113, 84);
            this.txtlname.Name = "txtlname";
            this.txtlname.ReadOnly = true;
            this.txtlname.Size = new System.Drawing.Size(361, 21);
            this.txtlname.TabIndex = 1084;
            this.btxMsg.SetText(this.txtlname, "Lastname cannot be blank");
            this.btxMsg.SetTitle(this.txtlname, null);
            // 
            // txtmname
            // 
            this.txtmname.BackColor = System.Drawing.Color.White;
            this.txtmname.Location = new System.Drawing.Point(113, 57);
            this.txtmname.Name = "txtmname";
            this.txtmname.ReadOnly = true;
            this.txtmname.Size = new System.Drawing.Size(361, 21);
            this.txtmname.TabIndex = 1083;
            this.btxMsg.SetText(this.txtmname, "Middlename cannot be blank");
            this.btxMsg.SetTitle(this.txtmname, null);
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.White;
            this.txtfname.Location = new System.Drawing.Point(113, 30);
            this.txtfname.Name = "txtfname";
            this.txtfname.ReadOnly = true;
            this.txtfname.Size = new System.Drawing.Size(361, 21);
            this.txtfname.TabIndex = 1082;
            this.btxMsg.SetText(this.txtfname, "Firstname cannot be blanked");
            this.btxMsg.SetTitle(this.txtfname, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1091;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1090;
            this.label2.Text = "Middle Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1089;
            this.label1.Text = "First Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmailAddress);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_position);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_department);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtlname);
            this.panel1.Controls.Add(this.btn_company);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.txtmname);
            this.panel1.Controls.Add(this.txtfname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 289);
            this.panel1.TabIndex = 1099;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(114, 190);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(361, 21);
            this.txtEmailAddress.TabIndex = 1091;
            this.btxMsg.SetText(this.txtEmailAddress, "Lastname cannot be blank");
            this.btxMsg.SetTitle(this.txtEmailAddress, null);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 1102;
            this.label12.Text = "Email Address :";
            // 
            // btn_position
            // 
            this.btn_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_position.Enabled = false;
            this.btn_position.FlatAppearance.BorderSize = 0;
            this.btn_position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_position.ForeColor = System.Drawing.Color.White;
            this.btn_position.Image = ((System.Drawing.Image)(resources.GetObject("btn_position.Image")));
            this.btn_position.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_position.Location = new System.Drawing.Point(375, 111);
            this.btn_position.Name = "btn_position";
            this.btn_position.Size = new System.Drawing.Size(96, 21);
            this.btn_position.TabIndex = 1086;
            this.btn_position.Text = "      Search";
            this.btn_position.UseVisualStyleBackColor = false;
            this.btn_position.Click += new System.EventHandler(this.btn_position_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            this.txtPosition.Location = new System.Drawing.Point(113, 111);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(259, 21);
            this.txtPosition.TabIndex = 1085;
            this.btxMsg.SetText(this.txtPosition, "Company cannot be blank");
            this.btxMsg.SetTitle(this.txtPosition, null);
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_Keydown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 1100;
            this.label11.Text = "Position:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1097;
            this.label10.Text = "Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 1096;
            this.label9.Text = "Department :";
            // 
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_department.Enabled = false;
            this.btn_department.FlatAppearance.BorderSize = 0;
            this.btn_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_department.ForeColor = System.Drawing.Color.White;
            this.btn_department.Image = ((System.Drawing.Image)(resources.GetObject("btn_department.Image")));
            this.btn_department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_department.Location = new System.Drawing.Point(376, 161);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(96, 21);
            this.btn_department.TabIndex = 1090;
            this.btn_department.Text = "      Search";
            this.btn_department.UseVisualStyleBackColor = false;
            this.btn_department.Click += new System.EventHandler(this.btn_Department_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.White;
            this.txtDepartment.Location = new System.Drawing.Point(114, 162);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(259, 21);
            this.txtDepartment.TabIndex = 1089;
            this.btxMsg.SetText(this.txtDepartment, "Department cannot be blank");
            this.btxMsg.SetTitle(this.txtDepartment, null);
            this.txtDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepartment_Keydown);
            // 
            // txtAddress
            // 
            this.txtAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(115, 218);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(361, 62);
            this.txtAddress.TabIndex = 1092;
            this.btxMsg.SetText(this.txtAddress, null);
            this.btxMsg.SetTitle(this.txtAddress, null);
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDatecreated);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtUsercreated);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Location = new System.Drawing.Point(11, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 117);
            this.panel2.TabIndex = 1100;
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.Gray;
            this.panFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFoot.Controls.Add(this.label8);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 502);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(522, 25);
            this.panFoot.TabIndex = 1101;
            this.panFoot.Paint += new System.Windows.Forms.PaintEventHandler(this.panFoot_Paint);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 23);
            this.label8.TabIndex = 849;
            this.label8.Text = "Press Esc to close this form";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(11, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 18);
            this.lblStatus.TabIndex = 1102;
            this.lblStatus.Text = "label11";
            // 
            // EmployeeInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panFoot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeInformationControl";
            this.Size = new System.Drawing.Size(522, 527);
            this.Load += new System.EventHandler(this.EmployeeInformationControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeInformationControl_keydown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton emp_add_btn;
        private System.Windows.Forms.ToolStripButton emp_edit_btn;
        private System.Windows.Forms.ToolStripButton emp_deactivate_btn;
        private System.Windows.Forms.ToolStripButton emp_activate_btn;
        private System.Windows.Forms.ToolStripButton emp_print_btn;
        private System.Windows.Forms.ToolStripButton emp_save_btn;
        private System.Windows.Forms.ToolStripButton emp_cancel_btn;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btn_company;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatecreated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsercreated;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btn_position;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label12;
    }
}
