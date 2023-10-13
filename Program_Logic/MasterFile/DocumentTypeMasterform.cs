using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMS.Report;
using AMS.Admin;

namespace AMS.MasterFile
{
    public partial class DocumentTypeMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public DocumentTypeMasterform()
        {
            InitializeComponent();
        }

        private void DocumentTypeMasterform_Load(object sender, EventArgs e)
        {
            DocumentTypeRepository _repo = new DocumentTypeRepository();
            DisplayRecord(_repo.GetDocumentType(_id));
            DisplayRecords();
        }

        void DisplayRecords()
        {
            //AMSLogic.Master.Repository.BrandRepository _brandrepo = new AMSLogic.Master.Repository.BrandRepository();
            DocumentTypeRepository _repor = new DocumentTypeRepository();
            lsvList.Items.Clear();
            try
            {
                List<SYS_DOCUMENT_TYPE> _brands = new List<SYS_DOCUMENT_TYPE>();
                _brands = _repor.GetDocumentTypes(txtBrandFilter.Text);
                foreach (SYS_DOCUMENT_TYPE _x in _brands)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.document_name);
                    _item.SubItems.Add(_x.status ? "Active" : "Inactive");
                    _item.SubItems.Add(_x.SYS_USER.username);
                    _item.SubItems.Add(_x.date_created.ToShortDateString());

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(SYS_DOCUMENT_TYPE _obj)
        {
            
            try
            {

                if (_obj != null)
                {
                    _id = _obj.id;
                    txtDocumentType.Text = _obj.document_name;
                    txtStatus.Text = _obj.status ? "Active" : "Inactive";            //IIF

                    txtUsercreated.Text = _obj.SYS_USER.username;
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

            DocumentTypeRepository _repo = new DocumentTypeRepository();
            try
            {
                _id = int.Parse(lsvList.SelectedItems[0].Text);
               
                DisplayRecord(_repo.GetDocumentType(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);

            txtDocumentType.Focus();
        }

        void EnableForm(bool _condition)
        {
            txtDocumentType.ReadOnly = !_condition;
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
            txtDocumentType.Text = "";
            txtStatus.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);

            txtDocumentType.Focus();
        }

        private void deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on de-activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 2;
            ManageRecord();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);

            DocumentTypeRepository _repo = new DocumentTypeRepository();
            DisplayRecord(_repo.GetDocumentType(_id));
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtDocumentType.Text == "")
            {
                btxMsg.ShowBalloon(txtDocumentType);
                txtDocumentType.Focus();
                return;
            }

            ManageRecord();
        }

        void ManageRecord()
        {
            DocumentTypeRepository _repo = new DocumentTypeRepository();
            SYS_DOCUMENT_TYPE _obj = new SYS_DOCUMENT_TYPE();
            try
            {
                _obj.id = _id;
                _obj.document_name = txtDocumentType.Text;
                _obj.status = true;
                _obj.date_created = DateTime.Now;
                _obj.user_id = LoginUser.userid;                   //galing dapat sa login details

                _id = _repo.ManageDocumentType(_obj, _mode);


                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
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
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            DocumentTypeRepository _repo = new DocumentTypeRepository();
            DisplayRecord(_repo.GetDocumentType(_id));
        }

        private void activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 3;
            ManageRecord();
        }

        private void DocumentTypeMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("DOCUMENT TYPE MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void txtBrandFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }
    }
}
