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
using AMS.Transaction.RequestForPayment;

namespace AMS.Transaction.RequestForPayment
{
    public partial class RequestforPayementApprovalform : Form
    {
        int _request_id = 0;
        int _id = 0;

        RequestforPaymentMonitoring _paymentmonitor;
         

        public RequestforPayementApprovalform(int Id, int RequestId, RequestforPaymentMonitoring _Payment)
        {
            InitializeComponent();
            _id = Id;
            _request_id = RequestId;
            _paymentmonitor = _Payment;
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            if (txtCheckno.Text == "")
            {
                btxMsg.ShowBalloon(txtCheckno);
                txtCheckno.Focus();
                return;
            }

            if (MessageBox.Show("Approve this Request for payment, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageRecord();
        }

        void ManageRecord()
        {
            INV_REQUEST_FOR_PAYMENT _payment = new INV_REQUEST_FOR_PAYMENT();
            RequestRepository _i = new RequestRepository();
            try
            {
                _payment.id = _id;
                _payment.request_id = _request_id;
                _payment.request_date = dtpReplyDate.Value;
                _payment.requested_by = LoginUser.userid;
                _payment.reason = "";
                _payment.received_date = DateTime.Now;
                _payment.reply_date = dtpReplyDate.Value;
                _payment.Remarks = txtRemarks.Text; 
                _payment.check_no = txtCheckno.Text;
                _payment.cv_no = txtCVno.Text;

                _id = _i.ManageRequestforPayment(_payment, 3);

                MessageBox.Show("Request for payment successfully sent Approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _paymentmonitor.RefreshGrid();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestforPayementApprovalform_Load(object sender, EventArgs e)
        {
            RequestRepository _i = new RequestRepository();
            DisplayRecord(_i.GetPayment(_request_id));
        }

        void DisplayDetails()
        {
            int n = 0;
            decimal _total = 0;
            RequestRepository _i = new RequestRepository();
            try
            {
              
                List<INV_REQUEST_DET> _obj = _i.GetRequestDetails(_request_id, true);
                if (_obj.Count != 0)
                {
                    foreach (INV_REQUEST_DET _list in _obj)
                    {
                        _total = _total + decimal.Parse(_list.amount.ToString());
                    }
                }

                txtTotalAmount.Text = _total.ToString("N", new CultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        

        void DisplayRecord(INV_REQUEST_FOR_PAYMENT _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _id = _obj.id;
                    txtRequestno.Text = _obj.INV_REQUEST.request_no;
                    dtpReplyDate.Value = _obj.request_date;
                    txtPurpose.Text = _obj.reason;
                    txtRemarks.Text = _obj.Remarks;

                   
                }
                else
                {
                    _id = 0;
                    RequestRepository _i = new RequestRepository();
                    INV_REQUEST _request = _i.GetRequest(_request_id);
                    if (_request != null)
                    {
                        txtRequestno.Text = _request.request_no;
                    }
                }

                DisplayDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestforPayementApprovalform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
