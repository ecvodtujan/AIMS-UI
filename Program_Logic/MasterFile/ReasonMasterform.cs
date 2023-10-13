using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Master.Repository;
using AMS.Inquiry;
using AMS.Admin;
using AMS.Report;
using AMSLogic.Model;

namespace AMS.MasterFile
{
    public partial class ReasonMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public ReasonMasterform()
        {
            InitializeComponent();
        }

        private void ReasonMasterform_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            ReasonRepository _reasrepo = new ReasonRepository();
            DisplayRecord(_reasrepo.GetReason(_id));
        }

        void DisplayRecords()
        {
            ReasonRepository _reasonrepo = new ReasonRepository();
            reasonlsvList.Items.Clear();
            try
            {
                List<SYS_REASON> _reason = new List<SYS_REASON>();
                _reason = (from d in _reasonrepo.GetReasons(txtClassFilter.Text) orderby d.reason_class select d).ToList();
                foreach(SYS_REASON _d in _reason)
                {
                    ListViewItem _reasons = new ListViewItem(_d.id.ToString());
                    _reasons.SubItems.Add(_d.reason_class);
                    _reasons.SubItems.Add(_d.reaseon_description);
                    _reasons.SubItems.Add(_d.SYS_USER.username);
                    _reasons.SubItems.Add(_d.date_created.ToShortDateString());

                    reasonlsvList.Items.Add(_reasons);
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(SYS_REASON _obj)
        {
            ReasonRepository _reasonrepo = new ReasonRepository();
            try
            {
                SYS_REASON _robj = new SYS_REASON();
                _robj = _reasonrepo.GetReason(_id);
                if (_robj != null)
                {
                    _id = _robj.id;
                    txtClass.Text = _robj.reason_class;
                    txtDesc.Text = _robj.reaseon_description;
                    txtUsercreated.Text = _robj.SYS_USER.username;
                    txtDatecreated.Text = _robj.date_created.ToShortDateString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeForm()
        {
            txtClass.Text = "";
            txtDesc.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";

        }

        void EnableForm(bool _reas)
        {
            txtClass.ReadOnly = !_reas;
            txtDesc.ReadOnly = !_reas;
            txtDatecreated.ReadOnly = !_reas;
            txtUsercreated.ReadOnly = !_reas;
        }

        void EnableSaveButton(bool _reas)
        {
            reas_add_btn.Enabled = !_reas;
            reas_edit_btn.Enabled = !_reas;
            reas_print_btn.Enabled = !_reas;
             
            reas_save_btn.Enabled = _reas;
            reas_cancel_btn.Enabled = _reas;
        }
        void ManageRecord()
        {
            ReasonRepository _reasonrepo = new ReasonRepository();
            SYS_REASON _obj = new SYS_REASON();
            try
            {
                _obj.id = _id;
                _obj.reason_class = txtClass.Text;
                _obj.reaseon_description = txtDesc.Text;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;
                _id = _reasonrepo.ManageReason(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                Cancel();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cancel()
        {
            EnableForm(false);
            DisplayRecords();
            EnableSaveButton(false);

            ReasonRepository _reasrepo = new ReasonRepository();
            DisplayRecord(_reasrepo.GetReason(_id));
        }

        private void reasonlsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reasonlsvList.SelectedItems.Count == 0) { return;  }
            try
            {
                _id = int.Parse(reasonlsvList.SelectedItems[0].Text);
                ReasonRepository _reasrepo = new ReasonRepository();
                DisplayRecord(_reasrepo.GetReason(_id));
             }
            catch(Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void reas_save_btn_Click(object sender, EventArgs e)
        {
            if (txtClass.Text == "")
            {
                btxMsg.ShowBalloon(txtClass);
                txtClass.Focus();
                return; 
            }

           //else if (txtDesc.Text == "")
           // {
           //     btxMsg.ShowBalloon(txtDesc);
           //     return;
            //}
            ManageRecord();
        }

        private void reas_print_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Coming Soon", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReportViewerform _report = new ReportViewerform("REASON MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void reas_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtClass.Focus();
        }

        private void ReasonMasterform_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void reas_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            txtClass.Focus();
            InitializeForm();
        }

        private void txtReasonFilter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }

        private void reas_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            ReasonRepository _reasonrepo = new ReasonRepository();
            DisplayRecord(_reasonrepo.GetReason(_id));
        }

        private void txtClassFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
