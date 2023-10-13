using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMS.Report;
using AMSLogic;
using AMS.Admin;

namespace AMS.MasterFile
{
    public partial class CompanyMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public CompanyMasterform()
        {
            InitializeComponent();
        }
        private void complsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (complsvList.SelectedItems.Count == 0) { return; }

            try
            {
                _id = int.Parse(complsvList.SelectedItems[0].Text);
                DisplayRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompanyMasterform_Load(object sender, EventArgs e)
          {
             DisplayRecord();
             DisplayRecords();
          }
        void DisplayRecords()
        {
            CompanyRepository _comprepo = new CompanyRepository();
            complsvList.Items.Clear();
            {
                List<SYS_COMPANY> _comp = new List<SYS_COMPANY>();
                _comp = (from d in _comprepo.GetCompanies()orderby d.code select d).ToList();
                foreach (SYS_COMPANY _i in _comp)
                {
                    ListViewItem _cmp = new ListViewItem(_i.id.ToString());
                    _cmp.SubItems.Add(_i.code);
                    _cmp.SubItems.Add(_i.description);
                    _cmp.SubItems.Add(_i.status ? "Active" : "Inactive");
                    _cmp.SubItems.Add(_i.SYS_USER.username);
                    _cmp.SubItems.Add(_i.date_created.ToShortDateString());
                    complsvList.Items.Add(_cmp);
                }
            }
        }
        void DisplayRecord()

        {
         CompanyRepository _comprepo = new CompanyRepository();
            {
               SYS_COMPANY _comp = _comprepo.GetCompany(_id);
                try
                {
                    if (_comp != null)

                    {
                         _id = _comp.id;
                        txtcompCode.Text = _comp.code;
                        txtcompName.Text = _comp.description;
                        txtStatus.Text = _comp.status ? "Active" : "Inactive";
                        txtUsercreated.Text = _comp.SYS_USER.username;
                        txtDatecreated.Text = _comp.date_created.ToShortDateString();
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

        }
        private void cmp_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;

            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);
            txtcompCode.Focus();
        } 
        void EnableForm(bool _comp)
        {
            txtcompCode.ReadOnly = !_comp;
            txtcompName.ReadOnly = !_comp;
            complsvList.Enabled = !_comp;
            //  DisplayRecord();
           //  DisplayRecords();
        }
        void EnableSaveButton(bool _comp)

             {
            cmp_save_btn.Enabled = _comp;
            cmp_cancel_btn.Enabled = _comp;
            cmp_add_btn.Enabled = !_comp;
            cmp_activate_btn.Enabled = !_comp;
            cmp_edit_btn.Enabled = !_comp;
            cmp_deactivate_btn.Enabled = !_comp;
            cmp_print_btn.Enabled = !_comp;    
              }
        void InitializeForm()
              {
                 txtcompCode.Text = "";
                txtcompName.Text = "";
                txtStatus.Text = "";
                txtUsercreated.Text = "";
                txtDatecreated.Text = "";
             }
        private void cmp_edit_btn_Click(object sender, EventArgs e)
             {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);
            txtcompCode.Focus();
              }
        private void cmp_cancel_btn_Click(object sender, EventArgs e)
            {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
          //  txtcompCode.Clear();
             }

        private void cmp_save_btn_Click(object sender, EventArgs e)
        {
            if (txtcompCode.Text == "")
            {
                btxMsg.ShowBalloon(txtcompCode);
                txtcompCode.Focus();
                return;
            }
            ManageRecord();
           // EnableSaveButton(false);
           // EnableForm(false);
           // txtcompCode.Clear();
          //  txtcompName.Clear();
        }
        void ManageRecord()

        { 
            CompanyRepository _comprepo = new CompanyRepository();
            SYS_COMPANY _obj = new SYS_COMPANY();
            try
            {
                _obj.id = _id;
                _obj.code = txtcompCode.Text;
                _obj.description = txtcompName.Text;
                _obj.status = true;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;

                _id = _comprepo.ManageCompany(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                //if (_mode ==0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                EnableSaveButton(false);
                EnableForm(false);
                DisplayRecords();     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmp_print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("COMPANY MASTER FILE");
            _report.BringToFront();
            _report.Show();
            //if (MessageBox.Show("This feature is not yet available ") ==
            //                System.Windows.Forms.DialogResult.No)
            //{
            //    return;
            //}
            //EnableForm(true);
        }
        private void CompanyMasterform_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void cmp_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
    System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 2;
            ManageRecord();
        }
        private void cmp_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 3;
            ManageRecord();
        }  
    }   
} 

