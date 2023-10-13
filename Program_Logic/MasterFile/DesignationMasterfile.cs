using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Model;
using AMS.Inquiry;
using AMSLogic.Master.Repository;

using AMS.Admin;
using AMS.Report;

namespace AMS.MasterFile
{
    public partial class DesignationMasterfile : Form
    {

        int _id = 0;
        int _mode = 0;
        public DesignationMasterfile()
        {
            InitializeComponent();
        }

        private void PositionMasterfile_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            PositionRepository _postrepo = new PositionRepository();
            DisplayRecord(_postrepo.GetPosition(_id));
        }

        void DisplayRecords()
        {
            PositionRepository _postrepo = new PositionRepository();
            postlsvList.Items.Clear();
            try
            {
                List<SYS_POSITION> _post = new List<SYS_POSITION>();
                _post = (from d in _postrepo.GetPositions(txtpostFilter.Text) orderby d.description select d).ToList();
                foreach ( SYS_POSITION _p in _post )
                {
                    ListViewItem _item = new ListViewItem(_p.id.ToString());
                    _item.SubItems.Add(_p.description);
                    _item.SubItems.Add(_p.status ? "Active" : "Inactive");
                    
                    _item.SubItems.Add(_p.SYS_USER.username);
                    _item.SubItems.Add(_p.date_created.ToShortDateString());
                    postlsvList.Items.Add(_item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void DisplayRecord(SYS_POSITION _obj)
        {
            PositionRepository _postrepo = new PositionRepository();
            try
            {
                SYS_POSITION _pobj = new SYS_POSITION();
                _pobj = _postrepo.GetPosition(_id);
                    
                    if (_pobj != null)
                {
                    _id = _pobj.id;
                    txtPosDesc.Text = _pobj.description;
                    txtStatus.Text = _pobj.status ? "Active" : "Inactive";
                    txtUsercreated.Text = _pobj.SYS_USER.username;
                    txtDatecreated.Text = _pobj.date_created.ToShortDateString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void InitializeForm()
        {
            txtPosDesc.Text = "";
            txtStatus.Text = "";
            txtDatecreated.Text = "";
            txtUsercreated.Text = "";
        }

        void EnableForm(bool _post)
        {
            txtPosDesc.ReadOnly = !_post;
            txtStatus.ReadOnly = !_post;
            txtUsercreated.ReadOnly = !_post;
            txtDatecreated.ReadOnly = !_post;
            postlsvList.Enabled = !_post;
        }
        void EnableSaveButton(bool _post)
        {
            pos_save_btn.Enabled = _post;
            pos_cancel_btn.Enabled = _post;

            pos_activate_btn.Enabled = !_post;
            pos_deactivate_btn.Enabled = !_post;
            pos_edit_btn.Enabled = !_post;
            pos_add_btn.Enabled = !_post;

        }

        void ManageRecord()

        {
            PositionRepository _postrepo = new PositionRepository();
            SYS_POSITION _post = new SYS_POSITION();

            try
            {
                _post.id = _id;
                _post.description = txtPosDesc.Text;
                _post.status = true;
                _post.user_id = LoginUser.userid;
                _post.date_created = DateTime.Now;
                _id = _postrepo.ManagePosition(_post, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                Cancel();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void Cancel()
        {
            EnableForm(false);
            EnableSaveButton(false);
            DisplayRecords();
            PositionRepository _postrepo = new PositionRepository();
            DisplayRecord(_postrepo.GetPosition(_id));
        }
        
        private void postLsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (postlsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(postlsvList.SelectedItems[0].Text);
                PositionRepository _postrepo = new PositionRepository();
                DisplayRecord(_postrepo.GetPosition(_id));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pos_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            InitializeForm();
            txtPosDesc.Focus();
        }

        private void pos_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtPosDesc.Focus();
        }

        private void pos_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
        System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 2;
            ManageRecord();
        }

        private void pos_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
              System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 3;
            ManageRecord();
        }

        private void pos_print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("POSITION MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void pos_save_btn_Click(object sender, EventArgs e)
        {
            if (txtPosDesc.Text == "")
            {
                btxMsg.ShowBalloon(txtPosDesc);
                txtPosDesc.Focus();
                return;
            }
            ManageRecord();
        }

        private void PositionMasterform_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pos_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
        }

        private void txtPostFilter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }
    }
}
