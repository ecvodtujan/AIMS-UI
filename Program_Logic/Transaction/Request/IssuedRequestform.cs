using AMS.Inquiry;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMSLogic.Transaction.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AMS.Transaction.Request
{
    public partial class IssuedRequestform : Form
    {
        int _request_id = 0;
        int _asset_id = 0;

        public IssuedRequestform(int _Requestid)
        {
            InitializeComponent();

            _request_id = _Requestid;
        }

        private void unpost_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssuedRequestform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            if (txtIssuedby.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtIssuedby);
                txtIssuedby.Focus();
                return;
            }

            if (txtIssuedto.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtIssuedto);
                txtIssuedto.Focus();
                return;
            }

            if (MessageBox.Show("Proceed on tagging this request as Issued, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageRecord();
        }

        void ManageRecord()
        {
            try
            {
                //==========================================================================================================
                //insert into issuace
                IssuanceRepository _iIssuance = new IssuanceRepository();
                INV_ISSUANCE _issuance = new INV_ISSUANCE();
                int _issuance_id = 0;

                _issuance.id = 0;
                _issuance.date_issued = dtpDateIssued.Value;
                _issuance.issued_by = int.Parse(txtIssuedby.Tag.ToString());
                _issuance.emp_id = int.Parse(txtIssuedto.Tag.ToString());
                _issuance.asset_id = _asset_id;
                _issuance.remarks = txtRemarks.Text;

                _issuance_id = _iIssuance.ManageIssuance(_issuance, 0);                     //insert

                _issuance.id = _issuance_id;
                _issuance_id = _iIssuance.ManageIssuance(_issuance, 3);                     //post issuance record
                                                                                            //==========================================================================================================


                //==========================================================================================================
                //update inv_request issued information
                RequestRepository _iRequest = new RequestRepository();
                INV_REQUEST _request = new INV_REQUEST();
                _request.id = _request_id;
                _request.request_no = "";
                _request.date_requested = DateTime.Now;
                _request.requested_by = 0;
                _request.date_needed = DateTime.Now;
                //_request.itemtype_id = 0;
                //_request.brand_id = 0;
                //_request.model_description = "";
                _request.purpose = "";
                //_request.recommendation = "";
                _request.remarks = "";
                //_request.estimated_cost = 0;
                _request.purchased_by = 0;
                _request.purchased_date = null;
                _request.received_by = 0;
                _request.received_date = null;
                _request.received_remarks = "";
                //_request.issued_by = int.Parse(txtIssuedby.Tag.ToString());
                //_request.issued_date = dtpDateIssued.Value;
                //_request.issued_remarks = txtRemarks.Text;
                //_request.issued_to = int.Parse(txtIssuedto.Tag.ToString());
                _request.cancelled_by = 0;
                _request.date_cancelled = null;
                _request.cancelled_remarks = "";

                _request_id = _iRequest.ManageRequest(_request, 5);

                //==========================================================================================================

                MessageBox.Show("Request successfully tagged as Issued!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IssuedRequestform_Load(object sender, EventArgs e)
        {
            GetRequestLink();
            DisplayAssetInformation();
        }

        void GetRequestLink()
        {
            //GET THE ASSET ID CONNECTED TO THIS REQUEST
            RequestRepository _iRequest = new RequestRepository();
            try
            {
                INV_REQUEST_LINK_ASSET _link = _iRequest.GetRequestAssetLink(_request_id);
                if (_link != null)
                {
                    _asset_id = _link.asset_id;

                    //CHECK IF ASSET IS NOT YET ISSUED (TO DOUBLE CHECK ONLY)
                    if (_link.INV_ASSET.issued_status)
                    {
                        MessageBox.Show("Asset connected to this request is already issued. Please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        issued_btn.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayAssetInformation()
        {
            AssetRepository _iAsset = new AssetRepository();
            try
            {
                INV_ASSET _obj = _iAsset.GetAsset(_asset_id);
                if (_obj != null)
                {
                    txtBarcode.Text = _obj.barcode;
                    txtDescription.Text = _obj.INV_TYPE.description + " " + _obj.SYS_BRAND.description + " : " + _obj.model_description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btn_issuedby_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtIssuedby.Text = _obj.username;
                txtIssuedby.Tag = _obj.id;
            }
        }

        private void btn_issuedto_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "EMPLOYEE";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtIssuedto.Text = _obj.username;
                txtIssuedto.Tag = _obj.id;
            }
        }
    }
}
