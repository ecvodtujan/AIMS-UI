using AMS.MasterFile;
using AMS.Inquiry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using AMSLogic.Model;
using AMSLogic.Admin;
using AMS.Transaction.RequestForPayment;
using AIMS.Inquiry;

namespace AMS.Admin
  
{
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;

        private void mdiMain_Load(object sender, EventArgs e)
        {
            AdminRepository _i = new AdminRepository();
            this.Text = _i.GetAppName("AMS") + " Ver (" + _i.GetAppVersion("AMS") + ")";

            LoginForm _login = new LoginForm(this);
            _login.BringToFront();
            _login.ShowDialog();
        }

        public int ChildFormNumber
        {
            get
            {
                return ChildFormNumber2;
            }

            set
            {
                ChildFormNumber2 = value;
            }
        }

        public int ChildFormNumber1
        {
            get
            {
                return ChildFormNumber2;
            }

            set
            {
                ChildFormNumber2 = value;
            }
        }

        public int ChildFormNumber2
        {
            get
            {
                return childFormNumber;
            }

            set
            {
                childFormNumber = value;
            }
        }

        public mdiMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)*/;
                MessageNotification(0);
                return; }
            BrandMasterform _form = new BrandMasterform();
            _form.MdiParent = this;
            _form.BringToFront();            
            _form.Show();

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemTypeMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserAdmin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(1);
                return; }
            ItemTypeMasterform _itemForm = new ItemTypeMasterform();
            _itemForm.MdiParent = this;
            _itemForm.BringToFront();
            _itemForm.Show();
        }

        private void empMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return; }
            //EmployeeMasterform _empForm = new EmployeeMasterform();
            //_empForm.MdiParent = this;
            //_empForm.BringToFront();
            //_empForm.Show();

            EmployeeMonitoringform _empM = new EmployeeMonitoringform();
            _empM.MdiParent = this;
            _empM.BringToFront();
            _empM.Show();
        }

        private void cmpMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return; }
            CompanyMasterform _cmpForm = new CompanyMasterform();
            _cmpForm.MdiParent = this;
            _cmpForm.BringToFront();
            _cmpForm.Show(); 
        }

        private void assetMenu_Click(object sender, EventArgs e)
        {
            //if (!LoginUser.IsUserLogin()) { MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

            //AssetMonitoringform _asstMon = new AssetMonitoringform();
            //_asstMon.MdiParent = this;
            //_asstMon.BringToFront();
            //_asstMon.Show();
        
        }

        private void userMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(1);
                return; }
            UserMasterform _userForm = new UserMasterform();
            _userForm.MdiParent = this;
            _userForm.BringToFront();
            _userForm.Show();
        }

        private void asstMonFormClick(object sender, EventArgs e)
        {
            AssetMonitoringform _asstMon = new AssetMonitoringform();
            _asstMon.BringToFront();
            _asstMon.Show();
        }

        void ShowLogin()
        {
            LoginForm _form = new LoginForm(this);
            _form.BringToFront();
            _form.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (tsmiLogin.Text == "Login")
            {
                ShowLogin();
            }
            else
            {
                if (MessageBox.Show("Are you sure??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                LoginUser.ClearLogin();
                ClearStatus();

                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }

                MessageBox.Show("Successfully log out!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowLogin();
            }
        }

        public void ClearStatus()
        {
            tsmiLogin.Text = "Login";
            tsslStatus.Text = "Status : Not Connected";
            tsslUsername.Text = "Username :";
        }

        public void SetStatus(string _username)
        {
            tsmiLogin.Text = "Log out";
            tsslStatus.Text = "Status : Connected";
            tsslUsername.Text = "Username : " + _username;
        }

        private void mdiMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit Asset Monitoring System, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void requestItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (LoginUser.userid != 1)
            //{
            //    MessageBox.Show("Module under contstruction!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            RequestMonitoringform _monitoring = new RequestMonitoringform();
            _monitoring.MdiParent = this;
            _monitoring.BringToFront();
            _monitoring.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void suppMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return; }
            SupplierMasterform _suppForm = new SupplierMasterform();
            _suppForm.MdiParent = this;
            _suppForm.BringToFront();
            _suppForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void deptMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return; }
            DepartmentNewMasterform _deptForm = new DepartmentNewMasterform();
            _deptForm.MdiParent = this;
            _deptForm.BringToFront();
            _deptForm.Show();
        }

        private void asseMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return; }

            AssetMonitoringform _asstMon = new AssetMonitoringform();
            _asstMon.MdiParent = this;
            _asstMon.BringToFront();
            _asstMon.Show();
        }

        private void assetTagSeriesMasterfile_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/ 
                MessageNotification(0); return; }

            AssetTagSeriesMasterform _tag = new AssetTagSeriesMasterform();
            _tag.MdiParent = this;
            _tag.BringToFront();
            _tag.Show();

        }

        private void userMenu_Click_1(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin()) { /*MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return; }
            UserMasterform _userForm = new UserMasterform();
            _userForm.MdiParent = this;
            _userForm.BringToFront();
            _userForm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        void MessageNotification(int _type)
        {
            //MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           if (_type == 0)
            {
                ToolsControl.CallPopMessage(this, "", "Kindly login first!");
                Thread.Sleep(1000);
            }
            else if (_type == 1)

            {
                ToolsControl.CallPopMessage(this, "", "Not Authorized!");
                Thread.Sleep(1000);
            }


           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Aboutform _about = new Aboutform();
            _about.BringToFront();
            _about.ShowDialog();
        }

        private void deptMenu_Click_1(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return;
            }
            DepartmentNewMasterform _deptForm = new DepartmentNewMasterform();
            _deptForm.MdiParent = this;
            _deptForm.BringToFront();
            _deptForm.Show();
        }

        private void positionMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return;
            }
            DesignationMasterfile _post = new DesignationMasterfile();
            _post.MdiParent = this;
            _post.BringToFront();
            _post.Show();
        }

        private void locationMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return;
            }
            LocationMasterform _loc = new LocationMasterform();
            _loc.MdiParent = this;
            _loc.BringToFront();
            _loc.Show();
        }

        private void reasonMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserAdmin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(1);
                return;
            }
            ReasonMasterform _reas = new ReasonMasterform();
            _reas.MdiParent = this;
            _reas.BringToFront();
            _reas.Show();
        }

        private void planMenu_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(0);
                return;
            }
            PlanMasterform _plan = new PlanMasterform(0);
            _plan.MdiParent = this;
            _plan.BringToFront();
            _plan.Show();
        }

        private void requestForPaymentMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestforPaymentMonitoring _monitoring = new RequestforPaymentMonitoring();
            _monitoring.MdiParent = this;
            _monitoring.BringToFront();
            _monitoring.Show();
        }

        private void deactivatedAssetMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserLogin())
            { 
                MessageNotification(0);
                return;
            }

            DeactivatedAssetMonitoringform _dasstMon = new DeactivatedAssetMonitoringform();
            _dasstMon.MdiParent = this;
            _dasstMon.BringToFront();
            _dasstMon.Show();
        }

        private void file_Menu_Click(object sender, EventArgs e)
        {
            if(LoginUser.usertype != "admin")

            {
              //  document_Menu.Enabled = false;


            }
        }

        private void document_Menu_Click(object sender, EventArgs e)
        {
            //if (LoginUser.usertype == "admin")

            //{
            //    return;
            //}

            //else


            if (!LoginUser.IsUserAdmin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(1);
                return;
            }

           DocumentTypeMasterform _doc = new DocumentTypeMasterform();
            _doc.MdiParent = this;
            _doc.BringToFront();
            _doc.Show();

           

        

        }

        private void hurisLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoginUser.IsUserAdmin())
            {/* MessageBox.Show("Kindly login first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
                MessageNotification(1);
                return;
            }

            HurisLinkMasterform _doc = new HurisLinkMasterform();
            _doc.MdiParent = this;
            _doc.BringToFront();
            _doc.Show();

        }
    }
}
