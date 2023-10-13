using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AMSLogic.Model;
using AMSLogic.Master.Repository;
using AMS.Report;
using AMSLogic;
using AMS.Admin;
using System.Linq;


namespace AMS.MasterFile
    
{
    public partial class SupplierMasterform : Form

    {
        int _id = 0;
       int _mode = 0;

        public SupplierMasterform()
        {
            InitializeComponent();
        }
        private void supplsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (supplsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(supplsvList.SelectedItems[0].Text);
                SupplierRepository _supprepo = new SupplierRepository();
                DisplayRecord(_supprepo.GetSupplier(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void SupplierMasterform_Load(object sender, EventArgs e)
        {
            SupplierRepository _supprepo = new SupplierRepository();
           DisplayRecord(_supprepo.GetSupplier(_id));
            DisplayRecords();
        }

        void DisplayRecords()

        {
            SupplierRepository _supprepo = new SupplierRepository();
            supplsvList.Items.Clear();
            {
                List<SYS_SUPPLIER> _supp = new List<SYS_SUPPLIER>();
                _supp = (from d in _supprepo.GetSuppliers(txtSuppFilter.Text)orderby d.supplier_name select d).ToList() ;
                foreach (SYS_SUPPLIER _i in _supp)
                {
                    ListViewItem _sup = new ListViewItem(_i.id.ToString());
                    _sup.SubItems.Add(_i.supplier_name);
                    _sup.SubItems.Add(_i.address);
                    _sup.SubItems.Add(_i.tin);
                    _sup.SubItems.Add(_i.contact_no);
                    _sup.SubItems.Add(_i.contact_person);
                    _sup.SubItems.Add(_i.status ? "Active" : "Inactive");
                    _sup.SubItems.Add(_i.SYS_USER.username);
                    _sup.SubItems.Add(_i.date_created.ToShortDateString());
                    supplsvList.Items.Add(_sup);
                }
            }
        }
        private List<SYS_SUPPLIER> GetSuppliers()
       {
          throw new NotImplementedException();
       }
        void DisplayRecord(SYS_SUPPLIER _obj)

        {
            SupplierRepository _supprepo = new SupplierRepository();
            {
                SYS_SUPPLIER _supp = _supprepo.GetSupplier(_id);
                try
                {
                    if (_supp != null)
                    {
                        _id = _supp.id;
                        txtsuppName.Text = _supp.supplier_name;
                        txtsuppAdd.Text = _supp.address;
                        txtsuppTin.Text = _supp.tin;
                        txtsuppCon.Text = _supp.contact_no;
                        txtsuppConp.Text = _supp.contact_person;
                        txtStatus.Text = _supp.status ? "Active" : "Inactive";
                        txtUsercreated.Text = _supp.SYS_USER.username;
                        txtDatecreated.Text = _supp.date_created.ToShortDateString();
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
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void panFoot_Paint(object sender, PaintEventArgs e)
        {
        }
        private void supp_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);
            txtsuppName.Focus();
        }
        void EnableForm(bool _supp)

        {
            //txtsuppName.Text = _supp.supplier_name;
            //txtsuppAdd.Text = _supp.address;
            //txtsuppTin.Text = _supp.tin;
            //txtsuppCon.Text = _supp.contact_no;
            //txtsuppConp.Text = _supp.contact_person;
            txtsuppName.ReadOnly = !_supp;
            txtsuppAdd.ReadOnly = !_supp;
            txtsuppTin.ReadOnly = !_supp;
            txtsuppCon.ReadOnly = !_supp;
            txtsuppConp.ReadOnly = !_supp;
            supplsvList.Enabled = !_supp;

            //     DisplayRecord();
            //  DisplayRecords();
        }

        void EnableSaveButton(bool _supp)
        {
            supp_save_btn.Enabled = _supp;
            supp_cancel_btn.Enabled = _supp;
            supp_add_btn.Enabled = !_supp;
            supp_activate_btn.Enabled = !_supp;
            supp_edit_btn.Enabled = !_supp;
            supp_deactivate_btn.Enabled = !_supp;
            supp_print_btn.Enabled = !_supp;
        }
        void InitializeForm()

        {
            txtsuppName.Text = "";
            txtsuppAdd.Text = "";
            txtsuppTin.Text = "";
            txtsuppCon.Text = "";
            txtsuppConp.Text = "";
            txtStatus.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
        }
        private void supp_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);
            txtsuppName.Focus();
        }

        private void supp_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            txtsuppName.Clear();
            txtsuppAdd.Clear();
            txtsuppTin.Clear();
            txtsuppCon.Clear();
            txtsuppConp.Clear();
        }
        private void supp_print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("SUPPLIER MASTER FILE");
            _report.BringToFront();
            _report.Show();
            //if (MessageBox.Show("This feature is not yet available ") ==
            //                System.Windows.Forms.DialogResult.No)
            //{
            //    return;
            //}
            //EnableForm(true);
        }

        private void supp_save_btn_Click(object sender, EventArgs e)
        {
            if (txtsuppName.Text == "")
            {
                btxMsg.ShowBalloon(txtsuppName);
                txtsuppName.Focus();
                return;
            }
            ManageRecord();
            //EnableSaveButton(false);
            //EnableForm(false);
            //txtsuppName.Clear();
            //txtsuppAdd.Clear();
            //txtsuppTin.Clear();
            //txtsuppCon.Clear();
            //txtsuppConp.Clear();
           // DisplayRecord();
        }
        void ManageRecord()

        {
            SupplierRepository _supprepo = new SupplierRepository();
            SYS_SUPPLIER _obj = new SYS_SUPPLIER();
            try
            {
                _obj.id = _id;
                _obj.supplier_name = txtsuppName.Text;
                _obj.address = txtsuppAdd.Text;
                _obj.tin = txtsuppTin.Text;
                _obj.contact_no = txtsuppCon.Text;
                _obj.contact_person = txtsuppConp.Text;
                _obj.status = true;
                _obj.user_id = LoginUser.userid;
               _obj.date_created = DateTime.Now;

                _id = _supprepo.ManageSupplier(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }


                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                // ManageRecord();
                Cancel();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cancel()

        {
           // SupplierRepository _supprepo = new SupplierRepository();
            EnableSaveButton(false);
            EnableForm(false);
         //   DisplayRecord(_supprepo.GetSupplier(_id));
            DisplayRecords();
            SupplierRepository _supprepo = new SupplierRepository();
            DisplayRecord(_supprepo.GetSupplier(_id));
        }
        private void supp_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
   System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 2;
            ManageRecord();
        }

        private void supp_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 3;
            ManageRecord();
        }
        private void SupplierMenu_Keydown(object sender, KeyEventArgs e)
        {

        }
        private void SupplierMasterform_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtSuppFilter_Keydown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Return)

            {
                DisplayRecords();
            }
        }
    }
}
