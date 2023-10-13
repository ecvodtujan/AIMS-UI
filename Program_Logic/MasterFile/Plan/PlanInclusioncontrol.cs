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
    public partial class PlanInclusioncontrol : UserControl
    {
    //   public int _planid = 0;
       //  int _plan_id = 0;
        PlanMasterform _parent;
          int _id = 0;
            int _mode = 0;
      


        public PlanInclusioncontrol(PlanMasterform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
           // _planid = _PlanId;

            
        }

        private void PlanInclusioncontrol_Load(object sender, EventArgs e)
        {
            PlanRepository _plan = new PlanRepository();
            DisplayRecord(_plan.GetSysInclusion(_id));

            DisplayRecords();

           // _plan_id = _parent._id;

        }

        void InitializeForm()
        {
            txtDescription.Text = "";
            txtUser.Text = "";
            txtDateCreated.Text = "";

        }

        void EnableForm(bool _inclu)
        {
            txtDescription.ReadOnly = !_inclu;
        }

        void EnableSaveButton(bool _inclu)
            {
            inclusion_save_btn.Enabled = _inclu;
            inclusion_cancel_btn.Enabled = _inclu;

            inclusion_add_btn.Enabled = !_inclu;
            inclusion_edit_btn.Enabled = !_inclu;
        }

        void Cancel()
        {
            PlanRepository _inclusionrepo = new PlanRepository();
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecord(_inclusionrepo.GetSysInclusion(_id));
            DisplayRecords();
        }

        void ManageRecord()
        {
            PlanRepository _inclusionrepo = new PlanRepository();
            SYS_PLAN_INCLUSION _obj = new SYS_PLAN_INCLUSION();

            try
            {
                _obj.id = _id;
          //     _obj.plan_id = int.Parse(_parent._id.ToString());
                _obj.description = txtDescription.Text;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;

                _id = _inclusionrepo.ManageSysPlanInclusion(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayRecord(SYS_PLAN_INCLUSION _obj)
        { try
            { 
                if (_obj != null)
                    {
                        _id = _obj.id;
                       // _parent._plan_id = _obj.plan_id;
                        txtDescription.Text = _obj.description;
                        txtUser.Text = _obj.SYS_USER.username;
                        txtDateCreated.Text = _obj.date_created.ToShortDateString();
                    

                  //  lbl4.Text = _parent._id.ToString();
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
            inclusionlsvList.Items.Clear();
            try
            {
                     
                {
                    List<SYS_PLAN_INCLUSION> _inclu = new List<SYS_PLAN_INCLUSION>();
                    
                    _inclu = (from d in _planrepo.GetSysInclusions(_parent._id) orderby d.description select d).ToList();
                    foreach (SYS_PLAN_INCLUSION _d in _inclu)
                    {
                        ListViewItem _inclusion = new ListViewItem(_d.id.ToString());
                        _inclusion.SubItems.Add(_d.plan_id.ToString());
                        _inclusion.SubItems.Add(_d.description);
                        _inclusion.SubItems.Add(_d.SYS_USER.username);
                        _inclusion.SubItems.Add(_d.date_created.ToShortDateString());
                        inclusionlsvList.Items.Add(_inclusion);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void inclusionlsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inclusionlsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(inclusionlsvList.SelectedItems[0].Text);
                PlanRepository _inclusionrepo = new PlanRepository();
                DisplayRecord(_inclusionrepo.GetSysInclusion(_id));

            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void inclusion_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
            InitializeForm();
        }

        private void inclusion_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
        }

        private void inclusion_save_btn_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                btxMsg.ShowBalloon(txtDescription);
                txtDescription.Focus();
                return;
            }
            ManageRecord();
        }

        private void inclusion_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            PlanRepository _inclusionrepo = new PlanRepository();
            DisplayRecord(_inclusionrepo.GetSysInclusion(_id));
        }
    }
}
