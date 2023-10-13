using AMSLogic.Transaction.Repository;
using AMSLogic.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.Admin;
using AMS.Transaction.Request;

namespace AMS.Transaction.RequestForPayment
{
    public partial class RequestforPaymentMonitoring : Form
    {
        int _selected_id = 0;
        int _selected_request_id = 0;
        string _selected_status = "";
        string _selected_request_no = "";

        public RequestforPaymentMonitoring()
        {
            InitializeComponent();
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        void DisplayRecord()
        {
            RequestRepository _i = new RequestRepository();
            dgvRequest.RowCount = 0;
            int n = 0;
            try
            {
                List<UDSP_GET_REQUEST_FOR_PAYMENT_MONITORINGResult> _lists = _i.GetRequestForPaymentMonitoring();
                if (_lists.Count != 0)
                {
                    foreach (UDSP_GET_REQUEST_FOR_PAYMENT_MONITORINGResult _list in _lists)
                    {
                        //prb.Value = prb.Value + 1;

                        n = dgvRequest.Rows.Add();
                        dgvRequest.Rows[n].Cells[0].Value = _list.ID.ToString();
                        dgvRequest.Rows[n].Cells[1].Value = _list.request_id.ToString();
                        dgvRequest.Rows[n].Cells[2].Value = _list.request_no;
                        dgvRequest.Rows[n].Cells[3].Value = _list.request_date.ToShortDateString();
                        dgvRequest.Rows[n].Cells[4].Value = _list.reason;
                        dgvRequest.Rows[n].Cells[5].Value = _list.Request_amount;
                        dgvRequest.Rows[n].Cells[6].Value = _list.RequestBy;

                        if (_list.received_date != null) { dgvRequest.Rows[n].Cells[7].Value = _list.received_date.Value.ToShortDateString(); }
                        else { dgvRequest.Rows[n].Cells[7].Value = ""; }

                        if (_list.reply_date != null) { dgvRequest.Rows[n].Cells[8].Value = _list.reply_date.Value.ToShortDateString(); }
                        else { dgvRequest.Rows[n].Cells[8].Value = ""; }


                        dgvRequest.Rows[n].Cells[9].Value = _list.status;

                        dgvRequest.Rows[n].Cells[10].Value = _list.check_no;
                        dgvRequest.Rows[n].Cells[11].Value = _list.Remarks;
                    }
                }
                else
                {
                    //MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ToolsControl.CallPopMessage(this, "", "No record found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestforPaymentMonitoring_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        private void dgvRequest_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    int rowIndex = dgvRequest.HitTest(e.X, e.Y).RowIndex;

                    if (rowIndex == -1) { return; }

                    string _request_status = dgvRequest.Rows[rowIndex].Cells[8].Value.ToString();

                    _selected_id = Convert.ToInt32(dgvRequest.Rows[rowIndex].Cells[0].Value);
                    _selected_status = dgvRequest.Rows[rowIndex].Cells[9].Value.ToString();
                    _selected_request_id = Convert.ToInt32( dgvRequest.Rows[rowIndex].Cells[1].Value.ToString());

                    _selected_request_no = dgvRequest.Rows[rowIndex].Cells[2].Value.ToString();

                    if (_selected_status == "Pending")
                    {
                        tsmReceive.Enabled = true;
                        tsmApprove.Enabled = false;
                    }
                    else if (_selected_status != "Pending")
                    {
                        tsmReceive.Enabled = false;
                        tsmApprove.Enabled = true;
                    }
                    //else if (_selected_status == "Approved" || _selected_status == "approved")
                    //{
                    //    tsmReceive.Enabled = false;
                    //    tsmApprove.Enabled = false;
                    //}
                    else 
                    {
                        tsmReceive.Enabled = false;
                        tsmApprove.Enabled = false;
                    }

                    dgvRequest.ContextMenuStrip = cmsEmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvRequest_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void tsmReceive_Click(object sender, EventArgs e)
        {
            RequestforPaymentReceiveform _received = new RequestforPaymentReceiveform(_selected_id, _selected_request_id);
            _received.BringToFront();
            _received.ShowDialog();
        }

        private void tsmApprove_Click(object sender, EventArgs e)
        {
            RequestforPayementApprovalform _received = new RequestforPayementApprovalform(_selected_id, _selected_request_id);
            _received.BringToFront();
            _received.ShowDialog();
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            try
            {
                if (e.ColumnIndex == 2)
                {
                    int _id = int.Parse(dgvRequest.Rows[e.RowIndex].Cells[1].Value.ToString());

                    Requestform _form = new Requestform(_id);
                    _form.Tag = _id.ToString();
                    _form.BringToFront();
                    _form.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Requestform _form = new Requestform(_selected_request_id);
            _form.Tag = _selected_request_id.ToString();
            _form.BringToFront();
            _form.Show();
        }

        private void cmsEmp_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
