using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.Report;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMS.Admin;


namespace AMS.MasterFile
{
    public partial class UserMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public UserMasterform()
        {
            InitializeComponent();
        }

        private void usr_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);

            txtUsername.Focus();
        }

        private void Userform_Load(object sender, EventArgs e)
        {
           
            DisplayRecords();
            UserRepository _repo = new UserRepository();
            DisplayRecord(_repo.GetUser(_id));
        }

        void DisplayRecords()
        {
            //AMSLogic.Master.Repository.BrandRepository _brandrepo = new AMSLogic.Master.Repository.BrandRepository();
            UserRepository _repo = new UserRepository();
            lsvList.Items.Clear();
            try
            {
                List<SYS_USER> _objs = new List<SYS_USER>();
                _objs = (from d in _repo.Getusers() orderby d.username select d).ToList();
                foreach (SYS_USER _x in _objs)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.username);
                    _item.SubItems.Add(_x.user_type);
                    _item.SubItems.Add(_x.status ? "Active" : "Inactive");
                    _item.SubItems.Add(_x.date_created.ToShortDateString());

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(SYS_USER _user)
        {
            UserRepository _repo = new UserRepository();
            try
            {
                SYS_USER _obj = new SYS_USER();
                _obj = _repo.GetUser(_id);

                //same lang yan sa taas
                //SYS_BRAND _brand = _brandrepo.GetBrand(_id);

                if (_obj != null)
                {
                    _id = _obj.id;
                    txtUsername.Text = _obj.username;
                    txtPassword.Text = _obj.password;
                    cboUsertype.Text = _obj.user_type;
                    txtEmployeename.Text = _obj.employee_name;
                    txtStatus.Text = _obj.status ? "Active" : "Inactive";            //IIF

                    txtUsercreated.Text = _repo.GetUser(_obj.user_id).username;
                    txtDatecreated.Text = _obj.date_created.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsvList.SelectedItems.Count == 0) { return; }

            try
            {
                _id = int.Parse(lsvList.SelectedItems[0].Text);
                UserRepository _repo = new UserRepository();
                DisplayRecord(_repo.GetUser(_id));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void EnableForm(bool _condition)
        {
            txtUsername.ReadOnly = !_condition;
            txtPassword.ReadOnly = !_condition;
            txtEmployeename.ReadOnly = !_condition;
            cboUsertype.Enabled = _condition;
            lsvList.Enabled = !_condition;
        }

        void EnableSaveButton(bool _condition)
        {
            save_btn.Enabled = _condition;
            cancel_btn.Enabled = _condition;

            add_btn.Enabled = !_condition;
            edit_btn.Enabled = !_condition;
            deactivate_btn.Enabled = !_condition;
            activate_btn.Enabled = !_condition;
            print_btn.Enabled = !_condition;
        }

        void InitializeForm()
        {
            //_id = 0;
            txtUsername.Text = "";
            txtPassword.Text = "";
            cboUsertype.SelectedIndex = 0;
            txtStatus.Text = "";
            txtEmployeename.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
        }

        private void usr_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);

            txtUsername.Focus();
        }

        private void usr_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 3;
            ManageRecord();
            
        }

        private void usr_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            UserRepository _repo = new UserRepository();
            DisplayRecord(_repo.GetUser(_id));
         //   txtUsername.Clear();
        }

        private void usr_save_btn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                //MessageBox.Show("Brand name cannot be blank", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btxMsg.ShowBalloon(txtUsername);
                txtUsername.Focus();
                return;
            }

            if (txtUsername.Text == "")
            {
                //MessageBox.Show("Brand name cannot be blank", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btxMsg.ShowBalloon(txtUsername);
                txtUsername.Focus();
                return;
            }

            if (txtEmployeename.Text == "")
            {
                //MessageBox.Show("Brand name cannot be blank", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btxMsg.ShowBalloon(txtEmployeename);
                txtEmployeename.Focus();
                return;

            }

            ManageRecord();
            EnableSaveButton(false);
            EnableForm(false);
        }

        void ManageRecord()
        {
            UserRepository _repo = new UserRepository();
            SYS_USER _obj = new SYS_USER();
            try
            {
                _obj.id = _id;
                _obj.username = txtUsername.Text;
                _obj.password = txtPassword.Text;
                _obj.status = true;
                _obj.user_type = cboUsertype.Text;
                _obj.date_created = DateTime.Now;
                _obj.employee_name = txtEmployeename.Text;
                _obj.user_id = LoginUser.userid;                   //galing dapat sa login details

                _id = _repo.ManageUser(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                Cancel();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cancel()
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            UserRepository _repo = new UserRepository();
            DisplayRecord(_repo.GetUser(_id));

        }

        private void usr_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on de-activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 2;
            ManageRecord();
        }
        private void UserMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
        private void print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("USER MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }
    }
}
