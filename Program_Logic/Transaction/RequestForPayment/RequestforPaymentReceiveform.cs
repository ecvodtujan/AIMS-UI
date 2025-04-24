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

namespace AMS.Transaction.RequestForPayment
{
    public partial class RequestforPaymentReceiveform : Form
    {
        int _id = 0;
        int _requestid = 0;
        string _request_no = "";

        RequestforPaymentMonitoring _paymentmonitor;

        public RequestforPaymentReceiveform(int Id, int RequestId, RequestforPaymentMonitoring _Paymentmonitor)
        {
            InitializeComponent();

            _id = Id;
            _requestid = RequestId;
            _paymentmonitor = _Paymentmonitor;
        }

        private void RequestforPaymentReceiveform_Load(object sender, EventArgs e)
        {
            RequestRepository _i = new RequestRepository();
            DisplayRecord(_i.GetPayment(_requestid));
        }

        void DisplayRecord(INV_REQUEST_FOR_PAYMENT _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _id = _obj.id;
                    txtRequestno.Text = _obj.INV_REQUEST.request_no;
                 //   dtpReplyDate.Value = _obj.request_date;
                   // txtRemarks.Text = _obj.reason;

                }
                else
                {
                    _id = 0;
                    RequestRepository _i = new RequestRepository();
                    INV_REQUEST _request = _i.GetRequest(_requestid);
                    if (_request != null)
                    {
                        txtRequestno.Text = _request.request_no;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Receive this request, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageRecord();
        }

        void ManageRecord()
        {
            INV_REQUEST_FOR_PAYMENT _payment = new INV_REQUEST_FOR_PAYMENT();
            RequestRepository _i = new RequestRepository();
            try
            {
                _payment.id = _id;
                _payment.request_id = _requestid;
                _payment.request_date = DateTime.Now;
                _payment.requested_by = LoginUser.userid;
                _payment.reason = "";
                _payment.received_date = dtpReceivedDate.Value;
                _payment.reply_date = DateTime.Now;
                _payment.Remarks = "";
                _payment.check_no = "";

                _id = _i.ManageRequestforPayment(_payment, 6);

                MessageBox.Show("Request for payment successfully received by accounting.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                _paymentmonitor.RefreshGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestforPaymentReceiveform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
