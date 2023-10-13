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
    public partial class PlanInclusivecontrol : UserControl
    {
        PlanMasterform _parent;
        int _id = 0;
        int _mode = 0;

        public PlanInclusivecontrol(PlanMasterform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
        void InitializeForm()
        {
            txtDescription.Text = "";
            txtDateCreated.Text = "";
            txtUser.Text = "";

        }
        void EnableForm(bool _inclu)
        {
            txtDescription.ReadOnly = !_inclu;

        }
        void EnableSaveButton(bool _inclu)
        {
            inclusive_save_btn.Enabled = !_inclu;
            inclusive_cancel_btn.Enabled = !_inclu;

            inclusive_add_btn.Enabled = _inclu;
            inclusive_edit_btn.Enabled = _inclu;
        }
        void Cancel()
        {
            PlanRepository _inclurepo = new PlanRepository();
            EnableSaveButton(false);
            EnableForm(false);
            // DisplayRecord(_inclurepo.GetSysInclusive(_id));
            //  DisplayRecords();
        }

        void DisplayRecord(SYS_PLAN_INCLUSIVE _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _id = _obj.id;
                   // _parent._id = _obj.plan_id;
                    txtDescription.Text = _obj.inclusive_description;
                    txtUser.Text = _obj.SYS_USER.username;
                    txtDateCreated.Text = _obj.date_created.ToShortDateString();

                 //   lbl4.Text = _parent._id.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecords()
        {
            PlanRepository _inclusiverepo = new PlanRepository();
            inclusiveLsvList.Items.Clear();
            try
            {
                List<SYS_PLAN_INCLUSIVE> _inclu = new List<SYS_PLAN_INCLUSIVE>();
                _inclu = (from d in _inclusiverepo.GetSysInclusives(_parent._id) orderby d.inclusive_description select d).ToList();
                foreach (SYS_PLAN_INCLUSIVE _d in _inclu)
                {
                    ListViewItem _inclusive = new ListViewItem(_d.id.ToString());
                    _inclusive.SubItems.Add(_d.plan_id.ToString());
                    _inclusive.SubItems.Add(_d.inclusive_description);
                    _inclusive.SubItems.Add(_d.SYS_USER.username);
                    _inclusive.SubItems.Add(_d.date_created.ToShortDateString());
                    inclusiveLsvList.Items.Add(_inclusive);
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

      }

        void ManageRecord()
        {

        }

        private void inclusive_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
            InitializeForm();
        }

        private void inclusive_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtDescription.Focus();
        }

        private void inclusive_save_btn_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                btxMsg.ShowBalloon(txtDescription);
                txtDescription.Focus();
                return;
            }
            ManageRecord();
        }

        private void inclusive_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            PlanRepository _inclusiverepo = new PlanRepository();
            DisplayRecord(_inclusiverepo.GetSysInclusive(_id));
        }

        private void inclusiveLsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inclusiveLsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(inclusiveLsvList.SelectedItems[0].Text);
                PlanRepository _inclusiverepo = new PlanRepository();
                DisplayRecord(_inclusiverepo.GetSysInclusive(_id));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PlanInclusivecontrol_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            PlanRepository _inclusiverepo = new PlanRepository();
            DisplayRecord(_inclusiverepo.GetSysInclusive(_id));

        }
    }
}
