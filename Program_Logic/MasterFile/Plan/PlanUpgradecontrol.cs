using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Master.Repository;
using AMSLogic.Model;
using System.Threading;
using System.Diagnostics;
using AMS.Admin;

namespace AMS.MasterFile.Plan
{
    public partial class PlanUpgradecontrol : UserControl
    {
        PlanMasterform _parent;
        int _id = 0;
        int _mode = 0;
        public PlanUpgradecontrol(PlanMasterform _Parent)

        {
            InitializeComponent();
            _parent = _Parent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlanUpgradecontrol_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            PlanRepository _plan = new PlanRepository();
            DisplayRecord(_plan.GetSysUpgrade(_id));
           
        }
        void InitializeForm()
        {
            txtDescription.Text = "";
            txtAmount.Text = "";
            txtUser.Text = "";
            txtDateCreated.Text = "";

        }

        void EnableForm(bool _upg)
        {
            txtDescription.ReadOnly = !_upg;
            txtAmount.ReadOnly = !_upg;

        }

        void EnableSaveButton(bool _upg)
        {
            upgrade_save_btn.Enabled = _upg;
            upgrade_cancel_btn.Enabled = _upg;

            upgrade_add_btn.Enabled = !_upg;
            upgrade_edit_btn.Enabled = !_upg;
            
        }

        void Cancel()
        {
            PlanRepository _upgraderepo = new PlanRepository();
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecord(_upgraderepo.GetSysUpgrade(_id));
            DisplayRecords();
        }
        void ManageRecord()
        {
            PlanRepository _upgraderepo = new PlanRepository();
            SYS_PLAN_UPGRADE _obj = new SYS_PLAN_UPGRADE();

            try
            {
                _obj.id = _id;
                _obj.plan_id = int.Parse(_parent._id.ToString());
                _obj.description = txtDescription.Text;
                _obj.amount = decimal.Parse(txtAmount.Text);
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;

                _id = _upgraderepo.ManageSysPlanUpgrade(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayRecord(SYS_PLAN_UPGRADE _obj)
        {
            try
            {
                if (_obj !=null)
                {
                    _id = _obj.id;
                    //_parent._id = _obj.plan_id;
                    txtAmount.Text = _obj.amount.ToString();
                    txtDescription.Text = _obj.description;
                    txtUser.Text = _obj.SYS_USER.username;
                    txtDateCreated.Text = _obj.date_created.ToShortDateString();

                   // lbl4.Text = _parent._id.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
         void DisplayRecords()
        {
            PlanRepository _planrepo = new PlanRepository();
            upgradeLsvList.Items.Clear();
            try
            {
                List<SYS_PLAN_UPGRADE> _upgr = new List<SYS_PLAN_UPGRADE>();
                _upgr = (from d in _planrepo.GetSysUpgrades(_parent._id) orderby d.description select d).ToList();
                foreach (SYS_PLAN_UPGRADE _d in _upgr)
              

                    {
                        ListViewItem _upgrade = new ListViewItem(_d.id.ToString());
                        _upgrade.SubItems.Add(_d.plan_id.ToString());
                        _upgrade.SubItems.Add(_d.description);
                        _upgrade.SubItems.Add(_d.amount.ToString());
                        _upgrade.SubItems.Add(_d.SYS_USER.username);
                        _upgrade.SubItems.Add(_d.date_created.ToShortDateString());
                        upgradeLsvList.Items.Add(_upgrade);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upgradelsvList_SelectedChanged(object sender, EventArgs e)
        {

        }

        private void upgradeLsvList_SelectedChanged(object sender, EventArgs e)
        {
            if (upgradeLsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(upgradeLsvList.SelectedItems[0].Text);
                PlanRepository _upgraderepo = new PlanRepository();
                DisplayRecord(_upgraderepo.GetSysUpgrade(_id));

            }
            
            catch (Exception ex)
                { MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        private void upgrade_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
            InitializeForm();
        }

        private void upgrade_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
        }

        private void upgrade_save_btn_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                btxMsg.ShowBalloon(txtDescription);
                txtDescription.Focus();
                return;
            }
            ManageRecord();
        }

        private void upgrade_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            PlanRepository _upgraderepo = new PlanRepository();
            DisplayRecord(_upgraderepo.GetSysUpgrade(_id));
        }
    }
    }
