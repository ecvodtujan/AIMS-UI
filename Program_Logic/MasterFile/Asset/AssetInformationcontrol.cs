using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.Inquiry;
using AMSLogic.Model;
using AMSLogic.Master;
using AMSLogic.Master.Repository;
using AMSLogic.Admin;
using AMS.Report;
using AMSLogic.Transaction.Repository;
using System.Globalization;
using AMS.Admin;

namespace AMS.MasterFile.Asset
{
    public partial class AssetInformationcontrol : UserControl
    {
       
        AssetMasterform _parent;
        int _mode = 0;
        int company_id = 0;
        
       

        public AssetInformationcontrol(AssetMasterform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;

        }
        private void asst_save_btn_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
            {
                btxMsg.ShowBalloon(txtBarcode);
                txtBarcode.Focus();
                return;
            }

            if (txtItemType.Text == "")
            {
                btxMsg.ShowBalloon(txtItemType);
                txtItemType.Focus();
                return;
            }

            if (txtBrand  .Text == "")
            {
                btxMsg.ShowBalloon(txtBrand);
                txtBrand.Focus();
                return;
            }

            ManageRecord();
        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            // if (!chkItemType.Checked) { return; }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "ITEM TYPE";
            _Searchform.ShowDialog();

            INV_TYPE _obj = _Searchform.ReturnSearchItemtype;
            if (_obj != null)
            {
                txtItemType.Text = _obj.description;
                txtItemType.Tag = _obj.id;

                GenerateCode();
            }
        }

        private void AssetInformationcontrol_Load(object sender, EventArgs e)
        {
            AssetRepository _iAsset = new AssetRepository();
            DisplayRecord(_iAsset.GetAsset(_parent._asset_id));
            //DisplayRecord(_iAsset.GetAsset(16));
            //   _parent._test_variable = 0;
            //  _parent.testpublic();
            var _asset = _iAsset.GetAsset(_parent._asset_id);
            {
                if (_asset != null)
                {
                    if (_asset.status == false)
                    {
                        toolStrip1.Enabled = false;
                        btn_QR.Enabled = false;
                    }
                }
            }
            // DisplayRecord2();
        }
        void DisplayRecord2()
        {
            //AssetRepository _iAsset = new AssetRepository();
            //try
            //{
            //    INV_ASSET _obj = _iAsset.GetAsset(_parent._asset_id);
            //    if (_obj != null)
            //    { }
            //    else { }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
        }

        void DisplayRecord(INV_ASSET _obj)
        {
            try
            {
                if (_obj != null)
                {
                    //display information
                    _parent._asset_id = _obj.id;
                    txtBarcode.Text = _obj.barcode;
                    txtInvoiceNo.Text = _obj.invoice_no;
                    txtItemType.Text = _obj.INV_TYPE.description;
                    txtItemType.Tag = int.Parse(_obj.inv_type_id.ToString());
                    txtBrand.Text = _obj.SYS_BRAND.description;
                    txtBrand.Tag = int.Parse(_obj.brand_id.ToString());
                    txtModel.Text = _obj.model_description;
                    txtSerialno.Text = _obj.serial_no;
                    txtSpecipication.Text = _obj.specification;
                    txtCost.Text =  _obj.cost.ToString("N", new CultureInfo("en-US"));

                    if (_obj.mfg_date == null) { dtDateofMfg.Checked = false; }
                    else {
                        dtDateofMfg.Checked = true;
                        dtDateofMfg.Value = _obj.mfg_date.Value;
                    }

                    if (_obj.date_purchase == null) { dtpPurchaseDate.Checked = false; }
                    else {
                        dtpPurchaseDate.Checked = true;
                        dtpPurchaseDate.Value = _obj.date_purchase.Value;
                    }

                    if (_obj.date_warranty == null) { dtpDateWarranty.Checked = false; }
                    else {
                        dtpDateWarranty.Checked = true;
                        dtpDateWarranty.Value = _obj.date_warranty.Value;
                    }
                    

                    txtRemarks.Text = _obj.remarks;
                    txtStatus.Text = (_obj.status ? "Active" : "Inactive");
                    dtEncode.Text = _obj.date_created.ToShortDateString();
                    txtEncodeby.Text = _obj.SYS_USER.username;
                    txtIssued.Text = (_obj.issued_status ? "Issued" : "Available");
                    txtOfficialno.Text = _obj.official_receipt_no;
                    txtHostname.Text = _obj.host_name;
                    txtGuid.Text = _obj.guid;
                 //   chkQRStat.Checked = _obj.qr_status;
                    txtQRStatus.Text = (_obj.qr_status ? "Stickered" : "Unstickered");
                    if (txtQRStatus.Text == "Stickered")
                    {  txtQRStatus.BackColor = Color.LightGray;
                       txtQRStatus.ForeColor = Color.White;
                        btn_QRStatus.Enabled = false;
                    }
                    else
                    {
                        txtQRStatus.BackColor = Color.Red;
                        txtQRStatus.ForeColor = Color.White;
                        btn_QRStatus.Enabled = true;
                    }
                   
                   
                    //txtOwner.Text = _obj.EM_EMP  
                    // dtDeployed.Tex

                    //display current owner--------------------------------------------------------
                    IssuanceRepository _iIssuance = new IssuanceRepository();
                    INV_ISSUANCE _issuance = _iIssuance.GetCurrentOwner(_parent._asset_id);
                    if (_issuance != null)
                    {
                        txtOwner.Text = _issuance.EMP_EMPLOYEE.lastname + ", " + _issuance.EMP_EMPLOYEE.firstname;
                        dtDeployed.Text = _issuance.date_issued.ToShortDateString();
                    }
                    //display current owner--------------------------------------------------------


                    //display request information--------------------------------------------------------
                    RequestRepository _iRequest = new RequestRepository();
                    INV_REQUEST_LINK_ASSET _link = _iRequest.GetRequestLink(_parent._asset_id);
                    if (_link != null)
                    {
                        txtRequestno.Text = _link.INV_REQUEST_DET.INV_REQUEST.request_no;
                        txtDateRequested.Text = _link.INV_REQUEST_DET.INV_REQUEST.date_requested.ToShortDateString();
                    }
                    else
                    {
                        txtRequestno.Text = "Manually Encoded";
                    }


                    //display request information--------------------------------------------------------

                    EnableForm(true);
                }
                else
                {
                    //initialize code here [call add button code]
                    //call add button click event
                    add_btn.PerformClick();
                    //InitializeForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManageRecord()
        {


            AssetRepository _iAsset = new AssetRepository();

            INV_ASSET _asset = new INV_ASSET();
            try
            {
                _asset.id = _parent._asset_id;
                _asset.barcode = txtBarcode.Text;
                _asset.inv_type_id = int.Parse(txtItemType.Tag.ToString());
                _asset.brand_id = int.Parse(txtBrand.Tag.ToString());
                _asset.model_description = txtModel.Text;
                _asset.serial_no = txtSerialno.Text;
                _asset.specification = txtSpecipication.Text;
                _asset.cost = decimal.Parse(txtCost.Text);

                if (dtDateofMfg.Checked) { _asset.mfg_date = dtDateofMfg.Value; }
                else { _asset.mfg_date = null; }

                if (dtpPurchaseDate.Checked) { _asset.date_purchase = dtpPurchaseDate.Value; }
                else { _asset.date_purchase = null; }

                if (dtpDateWarranty.Checked) { _asset.date_warranty = dtpDateWarranty.Value; }
                else { _asset.date_warranty = null; }

                _asset.invoice_no = txtInvoiceNo.Text;
                _asset.remarks = txtRemarks.Text;
                _asset.issued_status = false;
                _asset.status = true;
                _asset.user_id = LoginUser.userid;
                _asset.date_created = DateTime.Now;
                _asset.official_receipt_no = txtOfficialno.Text;
                _asset.host_name = txtHostname.Text;


                _parent._asset_id = _iAsset.ManageAsset(_asset, _mode, company_id);

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
        public void EnableForm(bool _add)

        {
            txtBarcode.ReadOnly = _add;
            txtInvoiceNo.ReadOnly = _add;
            //txtItemType.ReadOnly = _add;
            //txtBrand.ReadOnly = _add;
            txtModel.ReadOnly = _add;
            txtSerialno.ReadOnly = _add;
            txtSpecipication.ReadOnly = _add;
            txtCost.ReadOnly = _add;
            txtRemarks.ReadOnly = _add;
            txtStatus.ReadOnly = _add;
           
            dtEncode.ReadOnly = _add;
            txtEncodeby.ReadOnly = _add;
            txtIssued.ReadOnly = _add;
            txtOwner.ReadOnly = _add;
            dtDeployed.ReadOnly = _add;

            txtHostname.ReadOnly = _add;
            txtOfficialno.ReadOnly = _add;

            btn_itemtype.Enabled = !_add;
            btn_brand.Enabled = !_add;
            dtpPurchaseDate.Enabled = !_add;
            dtpDateWarranty.Enabled = !_add;
            dtDateofMfg.Enabled = !_add;

          //  chkQRStat.Enabled = _add;
        }

        private void asst_add_btn_Click(object sender, EventArgs e)
        {
            //initial code here....
            InitializeForm();
            //GenerateCode();
            EnableSaveButton(true);
            txtBarcode.Focus();
            EnableForm(false);
        }

        void GenerateCode()
        {
            AdminRepository _rep = new AdminRepository();
            txtBarcode.Text = _rep.GenerateSeries(10, int.Parse(txtItemType.Tag.ToString()) );
        }

        void InitializeForm()
        {
            txtBarcode.Focus();
            txtBarcode.Text = "";
            txtInvoiceNo.Text = "";
            txtItemType.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtSerialno.Text = "";
            txtSpecipication.Text = "";
            txtCost.Text = "0.00";
            dtDateofMfg.Text = "";
            dtpDateWarranty.Text = "";
            dtpDateWarranty.Text = "";
            txtRemarks.Text = "";
            txtStatus.Text = "";
            dtEncode.Text = "";
            txtEncodeby.Text = "";
            txtIssued.Text = "";
            txtOwner.Text = "";
            dtDeployed.Text = "";
            txtOfficialno.Text = "";
            txtHostname.Text = "";

            txtRequestno.Text = "";
            txtDateRequested.Text = "";
        }

        void EnableSaveButton(bool _cond)
        {
            add_btn.Enabled = !_cond;
            edit_btn.Enabled = !_cond;
            deactivate_btn.Enabled = !_cond;
            //activate_btn.Enabled = !_cond;
            print_btn.Enabled = !_cond;

            save_btn.Enabled = _cond;
            cancel_btn.Enabled = _cond;
        }

        private void asst_edit_btn_Click(object sender, EventArgs e)
        {
            {
                if (_parent._asset_id != 0)
                {
                    _mode = 1;
                    EnableSaveButton(true);
                    EnableForm(false);
                    txtBarcode.Focus();
                   
                }

                else
                {
                    MessageBox.Show("No Record to Edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        void Cancel()
        {

            AssetRepository _iAsset = new AssetRepository();
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecord(_iAsset.GetAsset(_parent._asset_id));
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "BRAND";
            _Searchform.ShowDialog();

            SYS_BRAND _obj = _Searchform.ReturnSearchBrand;
            if (_obj != null)
            {
                txtBrand.Text = _obj.description;
                txtBrand.Tag = _obj.id;
            }
        }

        private void deactivate_btn_Click(object sender, EventArgs e)
        {
            if (_parent._asset_id !=0)
        { 
                if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
          System.Windows.Forms.DialogResult.No)
                { 
                    return;
                }
                _mode = 2;
                ManageRecord();
                }
            else

            {
                MessageBox.Show("No Record to Deactivate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void activate_btn_Click(object sender, EventArgs e)
        {
            if (_parent._asset_id != 0)
            {
                if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                _mode = 3;
                ManageRecord();
            }
            else

            {
                MessageBox.Show("No Record to Activate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("ASSET MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }
        private void itemtype(object sender, MouseEventArgs e)
        {
           // btn_itemtype.PerformClick();
        }

        private void brand(object sender, MouseEventArgs e)
        {
          //  btn_brand.PerformClick();
        }

        private void itemkeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_itemtype.PerformClick();
            }
        }

        private void brandkeydown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    btn_brand.PerformClick();
                }
            }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssetQRInformation _qrinformation = new AssetQRInformation();
         ////   _qrinformation._asset_id = _parent._asset_id;
         //   _qrinformation._asset_code = txtBarcode.Text;
         //  // _qrinformation._item_type = txtItemType.Text;
         //   _qrinformation._brand_name = txtModel.Text;
         // //  _qrinformation._model = txtModel.Text;
         //   _qrinformation._serial_no = txtSerialno.Text;
         // //  _qrinformation._host_name = txtHostname.Text;
         // //  _qrinformation._manufacturing_date = dtDateofMfg.Checked ? dtDateofMfg.Value.ToShortDateString() : "N/A";
         // //  _qrinformation._purchase_date = dtpPurchaseDate.Checked ? dtpPurchaseDate.Value.ToShortDateString() : "N/A";
         //   _qrinformation._warranty_date = dtpDateWarranty.Checked ? dtpDateWarranty.Value.ToShortDateString() : "N/A";
         //   // _qrinformation._current_owner = txtOwner.Text;
         //   //   _qrinformation._date_issued = dtDeployed.Text == "" ? dtDeployed.Text : "N/A";
         //   //  _qrinformation._date_generated = DateTime.Now.ToShortDateString() ;
         //   //   _qrinformation._time_generated = DateTime.Now.ToShortTimeString();
            _qrinformation._guid = txtGuid.Text;

        GenerateQRcodeform _qrcode = new GenerateQRcodeform(_qrinformation);
            _qrcode.BringToFront();
            _qrcode.ShowDialog();
        }

        private void chkQRStat_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_QRStatus_Click_1(object sender, EventArgs e)
        {
            if (_parent._asset_id != 0)
            {
                if (MessageBox.Show("Proceed on Changing the QR Status of this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                _mode = 6;
                ManageRecord();
            }
            else

            {
                MessageBox.Show("No Record to Change", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
