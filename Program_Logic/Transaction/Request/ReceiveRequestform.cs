using AMS.Inquiry;
using AMSLogic.Admin;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMSLogic.Transaction.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.MasterFile;
using System.Threading;

namespace AMS.Transaction.Request
{
    public partial class ReceiveRequestform : Form
    {
        int _id = 0;
        int _item_no = 1;
        DateTime _purchase_date;

        public ReceiveRequestform(int _Id, DateTime _PurchaseDate)
        {
            InitializeComponent();

            _id = _Id;
            _purchase_date = _PurchaseDate;
        }

        private void ReceiveRequestform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_purchased_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtReceivedby.Text = _obj.username;
                txtReceivedby.Tag = _obj.id;
            }
        }

        bool ValidateText(TextBox _textbox)
        {
            bool _return = true;
            if (_textbox.Text == "")
            {
                btxMsg.ShowBalloon(_textbox);
                _textbox.Focus();
                _return = false;
            }
            return _return;
        }

        string ValidateDetails()
        {
            string  _return_value = "";

            //loop tru the grid
            foreach (DataGridViewRow _row in dgvRequest.Rows)
            {
                string _item_no = _row.Cells[2].Value.ToString();

                //check if required fields are not blank
                if (_row.Cells[4].Value.ToString() == "")               //description row
                {
                    _return_value = "Item # " + _item_no + " has a blank description. ";
                    return _return_value;
                }
                else if (_row.Cells[6].Value.ToString() == "")             //brand column
                {
                    _return_value = "Item # " + _item_no + " has a blank Brand. ";
                    return _return_value;
                }
                else if (_row.Cells[8].Value.ToString() == "")          //item type
                {
                    _return_value = "Item # " + _item_no + " has a blank Item type. ";
                    return _return_value;
                }
                else if (_row.Cells[9].Value.ToString() == "")          //serial no
                {
                    _return_value = "Item # " + _item_no + " has a blank Serial no. ";
                    return _return_value;
                }
                else if (_row.Cells[12].Value.ToString() == "")          //warranty date
                {
                    _return_value = "Item # " + _item_no + " has a blank warranty date. ";
                    return _return_value;
                }
                else if (_row.Cells[13].Value.ToString() == "")          //mfg date
                {
                    _return_value = "Item # " + _item_no + " has a blank manufacturing date. ";
                    return _return_value;
                }
            }

            return "";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateText(txtCheckVoucher)) { return; }
            if (!ValidateText(txtORnumber)) { return; }
            if (!ValidateText(txtReceivedby)) { return; }

            //validate first the details if required field are not blank
            string _check_grid = ValidateDetails();

            if (_check_grid != "")
            {
                MessageBox.Show(_check_grid + "Please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //proceed with the saving
            if (MessageBox.Show("Proceed on tagging this request transaction as Received, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageRecord();
        }

       

        void ManageRecord()
        {
            RequestRepository _iRequest = new RequestRepository();
            INV_REQUEST _obj = new INV_REQUEST();
            bool _with_receving_error = false;

            try
            {
                //update request status to RECIEVED
                _obj.id = _id;
                _obj.date_requested = DateTime.Now;
                _obj.requested_by = 0;
                _obj.remarks = "";
                _obj.purchased_by = 0;
                _obj.purchased_date = DateTime.Now;
                _obj.received_by = int.Parse(txtReceivedby.Tag.ToString());
                _obj.received_date = dtpReceivedDate.Value ;
                _obj.invoice_no = txtCheckVoucher.Text;
                _obj.official_receipt = txtORnumber.Text;
                _obj.cancelled_by = 0;
                _obj.date_cancelled = null;
                _obj.cancelled_remarks = "";

                _id = _iRequest.ManageRequest(_obj, 4);
                //update request status to RECIEVED

                //get company id from the request transaction
                INV_REQUEST _request = _iRequest.GetRequest(_id);
                int _company_id = 0;
                if (_request != null)
                {
                    _company_id = _request.company_id;
                }
                //get company id from the request transaction


                
                //insert data into INV_ASSET TABLE
                //LOOP IN THE GRID
                int X = 1;
                foreach (DataGridViewRow row in dgvRequest.Rows)
                {

                    string _received_status = "";

                    if (row.Cells[15].Value == null) { _received_status = ""; }
                    else { _received_status = row.Cells[15].Value.ToString(); }

                    //put the sub procedure in case there's an technical error encountered the process will still continue
                    //and will add a notes on the right side of the grid what is there error message or status.

                    //only process the item on the grid with not Received Status
                    if (_received_status != "Received")
                    {
                        if (!CheckandSaveAsset(row, _company_id)) { _with_receving_error = true; }
                    }

                    ThreadSleep();
                }
           


                //wag palitan yung message box nung pop up, lalo na pag important yung message.
                if (_with_receving_error)
                {
                    MessageBox.Show("Requested asset(s) were successfully tagged as Received with error encountered. Asset(s) is automatically encoded in the Asset Master file. Please check item(s) with error received status.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
                else
                {
                    //if received does not have error, close the form
                    MessageBox.Show("Requested asset(s) were successfully tagged as Received!. Asset(s) is automatically encoded in the Asset Master file.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool CheckandSaveAsset(DataGridViewRow _rows, int _company_id)
        {
            AssetRepository _iAsset = new AssetRepository();
            AdminRepository _rep = new AdminRepository();
            RequestRepository _iRequest = new RequestRepository();

            INV_ASSET _asset = new INV_ASSET();
            int _asset_id = 0;

            try
            {
                _asset.id = 0;

                //generate barcode based on the item type and company id
                _asset.barcode = _rep.GenerateSeries(_company_id, int.Parse(_rows.Cells[5].Value.ToString()));

                _asset.model_description = _rows.Cells[4].Value.ToString();
                _asset.inv_type_id = int.Parse(_rows.Cells[5].Value.ToString());
                _asset.brand_id = int.Parse(_rows.Cells[7].Value.ToString());
                _asset.serial_no = _rows.Cells[9].Value.ToString();
                _asset.cost = decimal.Parse(_rows.Cells[10].Value.ToString());
                _asset.specification = _rows.Cells[11].Value.ToString();
                _asset.date_purchase = DateTime.Parse(txtPurchaseDate.Text);
                _asset.invoice_no = txtCheckVoucher.Text;
                _asset.host_name = "BLANK-HN-" + DateTime.Now.ToString();

                if (_rows.Cells[12].Value.ToString() != "") { _asset.date_warranty = DateTime.Parse(_rows.Cells[12].Value.ToString()); }
                else { _asset.date_warranty = null; }

                if (_rows.Cells[13].Value.ToString() != "") { _asset.mfg_date = DateTime.Parse(_rows.Cells[13].Value.ToString()); }
                else { _asset.mfg_date = null; }
                
                _asset.remarks = _rows.Cells[14].Value.ToString();
                _asset.official_receipt_no = txtORnumber.Text;

                //create record in the inv_asset table
                _asset_id = _iAsset.ManageAsset(_asset, 0, _company_id);


                INV_REQUEST_LINK_ASSET _link = new INV_REQUEST_LINK_ASSET();
                int _request_det_id = int.Parse(_rows.Cells[0].Value.ToString());

                _link.id = 0;
                _link.request_det_id = _request_det_id;
                _link.asset_id = _asset_id;

                //create link between request & asset
                //to know whether asset came from request transaction or manually encoded
                _iRequest.ManageAssetLink(_link);

                _rows.Cells[15].Value = "Received";
                return true;
            }
            catch (Exception ex)
            {
                _rows.Cells[15].Value = ex.Message;
                return false;
            }
        }



        void DisplayRequestHeader()
        {
            RequestRepository _iRequest = new RequestRepository();
            
            try
            {
                INV_REQUEST _hd = _iRequest.GetRequest(_id);
                if (_hd != null)
                {
                    txtCheckVoucher.Text = _hd.invoice_no;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveRequestform_Load(object sender, EventArgs e)
        {
            //txtReceivedby.Text = LoginUser.username;
            //txtReceivedby.Tag = LoginUser.userid.ToString();
            txtPurchaseDate.Text = _purchase_date.ToShortDateString();
            DisplayRequestedItems();
            DisplayRequestHeader();
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            try
            {
                ReceivedDetail _obj = new ReceivedDetail();

                if (e.ColumnIndex == 1)            //edit
                {
                    _obj._index = e.RowIndex;
                    _obj._itemno = int.Parse(dgvRequest.Rows[e.RowIndex].Cells[2].Value.ToString()); 
                    _obj._barcode = dgvRequest.Rows[e.RowIndex].Cells[3].Value.ToString();
                    _obj._description = dgvRequest.Rows[e.RowIndex].Cells[4].Value.ToString();
                    _obj._itemtypeid = int.Parse(dgvRequest.Rows[e.RowIndex].Cells[5].Value.ToString());
                    _obj._itemtype = dgvRequest.Rows[e.RowIndex].Cells[6].Value.ToString();
                    _obj._brandid = int.Parse(dgvRequest.Rows[e.RowIndex].Cells[7].Value.ToString());
                    _obj._brandname = dgvRequest.Rows[e.RowIndex].Cells[8].Value.ToString();
                    _obj._serialno = dgvRequest.Rows[e.RowIndex].Cells[9].Value.ToString();
                    _obj._cost = decimal.Parse(dgvRequest.Rows[e.RowIndex].Cells[10].Value.ToString());
                    _obj._specification = dgvRequest.Rows[e.RowIndex].Cells[11].Value.ToString();
         
                    if (dgvRequest.Rows[e.RowIndex].Cells[12].Value.ToString() == "")
                    { _obj._warrantydate = DateTime.Now; }
                    else { _obj._warrantydate = DateTime.Parse(dgvRequest.Rows[e.RowIndex].Cells[12].Value.ToString()); }

                    if (dgvRequest.Rows[e.RowIndex].Cells[13].Value.ToString() == "")
                    { _obj._mfgdate = DateTime.Now; }
                    else { _obj._mfgdate= DateTime.Parse(dgvRequest.Rows[e.RowIndex].Cells[13].Value.ToString()); }


                    _obj._remarks = dgvRequest.Rows[e.RowIndex].Cells[14].Value.ToString();

                    ReceiveRequestdetailsform _detail = new ReceiveRequestdetailsform(this, _obj);
                    _detail.BringToFront();
                    _detail.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRequestedItems()
        {
            int n = 0;
            dgvRequest.RowCount = 0;

            try
            {
                RequestRepository _i = new RequestRepository();
                List<INV_REQUEST_DET> _obj = _i.GetRequestDetails(_id, true);
                if (_obj.Count != 0)
                {
                    foreach (INV_REQUEST_DET _list in _obj)
                    {
                        int _loop_qty = 0;

                        LOOP:

                        int _x = 0;
                       
                        //check if request qty is greater than 1, if greater than 1, multiply the display with qty
                        if (_loop_qty != _list.qty )
                        {
                            _loop_qty++;

                            //displaying data in the grid
                            n = dgvRequest.Rows.Add();
                            dgvRequest.Rows[n].Cells[_x].Value = _list.id.ToString(); _x++;
                            dgvRequest.Rows[n].Cells[_x].Value = "Edit"; _x++;

                            dgvRequest.Rows[n].Cells[_x].Value = _item_no; _x++;
                            dgvRequest.Rows[n].Cells[_x].Value = ""; _x++;
                            dgvRequest.Rows[n].Cells[_x].Value = _list.description; _x++;

                            dgvRequest.Rows[n].Cells[_x].Value = _list.item_type_id.ToString(); _x++;
                            dgvRequest.Rows[n].Cells[_x].Value = _list.INV_TYPE.description; _x++;

                            dgvRequest.Rows[n].Cells[_x].Value = _list.brand_id.ToString(); _x++;
                            dgvRequest.Rows[n].Cells[_x].Value = _list.SYS_BRAND.description; _x++;

                           

                            dgvRequest.Rows[n].Cells[_x].Value = ""; _x++;                          //serial no
                            dgvRequest.Rows[n].Cells[_x].Value = _list.unit_price.ToString("N", new CultureInfo("en-US")); _x++;
                            dgvRequest.Rows[n].Cells[_x].Value = ""; _x++;                          //specification

                            dgvRequest.Rows[n].Cells[_x].Value = ""; ; _x++;                        //warranty date
                            dgvRequest.Rows[n].Cells[_x].Value = ""; ; _x++;                        //mfgdate
                            dgvRequest.Rows[n].Cells[_x].Value = ""; ; _x++;                        //remarks

                            _item_no++;

                            //if _loop_qty is not equal with order qty make a loop (return to LOOP: line)
                            if (_loop_qty != _list.qty) { goto LOOP; }
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateRecord(ReceivedDetail _obj)
        {
            try
            {
                if (_obj != null)
                {
                    //update grid values coming from _obj
                    dgvRequest.Rows[_obj._index].Cells[2].Value = _obj._itemno;
                    dgvRequest.Rows[_obj._index].Cells[3].Value = _obj._barcode;
                    dgvRequest.Rows[_obj._index].Cells[4].Value = _obj._description;
                    dgvRequest.Rows[_obj._index].Cells[5].Value = _obj._itemtypeid;
                    dgvRequest.Rows[_obj._index].Cells[6].Value = _obj._itemtype;
                    dgvRequest.Rows[_obj._index].Cells[7].Value = _obj._brandid;
                    dgvRequest.Rows[_obj._index].Cells[8].Value = _obj._brandname;
                    dgvRequest.Rows[_obj._index].Cells[9].Value = _obj._serialno;
                    dgvRequest.Rows[_obj._index].Cells[10].Value = _obj._cost.ToString("N", new CultureInfo("en-US"));
                    dgvRequest.Rows[_obj._index].Cells[11].Value = _obj._specification;

                    if (_obj._warrantydate.ToString() != "") { dgvRequest.Rows[_obj._index].Cells[12].Value = _obj._warrantydate.Value.ToShortDateString(); }
                    else { dgvRequest.Rows[_obj._index].Cells[12].Value = ""; }

                    if (_obj._mfgdate.ToString() != "") { dgvRequest.Rows[_obj._index].Cells[13].Value = _obj._mfgdate.Value.ToShortDateString(); }
                    else { dgvRequest.Rows[_obj._index].Cells[13].Value = ""; }

                    dgvRequest.Rows[_obj._index].Cells[14].Value = _obj._remarks;
                }
                else
                {
                    MessageBox.Show("No record found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ThreadSleep()
        {
            //while (true)
            //{
                Thread.Sleep(1000);
            //}
        }

        private void txtPurchaseDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceivedby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_purchased.PerformClick(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void po_generate_Click(object sender, EventArgs e)
        {
            //POPrintRepository _po = new POPrintRepository();
            //_po.GeneratePurchaseOrder(22,_id);

        }
    }
}
