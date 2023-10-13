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
    public partial class LocationMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public LocationMasterform()
        {
            InitializeComponent();
        }
        private void LocationMasterform_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            LocationRepository _locrepo = new LocationRepository();
            DisplayRecord(_locrepo.GetLocation(_id));
        }
        void DisplayRecords()
        {
            LocationRepository _locrepo = new LocationRepository();
            loclsvList.Items.Clear();
            try
            {
                List<SYS_LOCATION> _loc = new List<SYS_LOCATION>();
                _loc = (from d in _locrepo.GetLocations(txtLocFilter.Text) orderby d.location select d).ToList();
                foreach (SYS_LOCATION _d in _loc)
                {
                    ListViewItem _locs = new ListViewItem(_d.id.ToString());
                    _locs.SubItems.Add(_d.location);
                    _locs.SubItems.Add(_d.SYS_USER.username);
                    _locs.SubItems.Add(_d.date_created.ToShortDateString());
                    loclsvList.Items.Add(_locs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayRecord(SYS_LOCATION _obj)
        {
            LocationRepository _locrepo = new LocationRepository();
            try
            {
                SYS_LOCATION _pobj = new SYS_LOCATION();
                _pobj = _locrepo.GetLocation(_id);

                if (_pobj != null)
                {
                    _id = _obj.id;
                    txtLocation.Text = _obj.location;
                    txtUsercreated.Text = _pobj.SYS_USER.username;
                    txtDatecreated.Text = _pobj.date_created.ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void InitializeForm()
        {
            txtLocation.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
        }
        void EnableForm(bool _loc)
        {
            txtLocation.ReadOnly = !_loc;
           // txtDatecreated.ReadOnly = !_loc;
           // txtUsercreated.ReadOnly = !_loc;
        }
        void EnableSaveButton(bool _loc)
        {
            loc_save_btn.Enabled = _loc;
            loc_cancel_btn.Enabled = _loc;
            loc_add_btn.Enabled = !_loc;
            loc_edit_btn.Enabled = !_loc;
            loc_print_btn.Enabled = !_loc;
        }
        
        void ManageRecord()
        {
            LocationRepository _locrepo = new LocationRepository();
            SYS_LOCATION _obj = new SYS_LOCATION();
            try
            {
                _obj.id = _id;
                _obj.location = txtLocation.Text;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;
                _id = _locrepo.ManageLocation(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                Cancel();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Cancel()
        {
            LocationRepository _locrepo = new LocationRepository();
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecord(_locrepo.GetLocation(_id));
            DisplayRecords();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loclsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loclsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(loclsvList.SelectedItems[0].Text);
                LocationRepository _locrepo = new LocationRepository();
                DisplayRecord(_locrepo.GetLocation(_id));

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void loc_save_btn_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text == "")
            {
                btxMsg.ShowBalloon(txtLocation);
                txtLocation.Focus();
                return;
            }
            ManageRecord();
        }

        private void loc_print_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( "Coming Soon","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReportViewerform _report = new ReportViewerform("LOCATION MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void loc_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableForm(true);
            EnableSaveButton(true);
            txtLocation.Focus();
        }

        private void LocationMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void loc_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            EnableForm(true);
            EnableSaveButton(true);
            txtLocation.Focus();
            InitializeForm();
        }

        private void txtLocFilter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }

        private void loc_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            LocationRepository _locrepo = new LocationRepository();
            DisplayRecord(_locrepo.GetLocation(_id));
        }

        private void txtLocFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
