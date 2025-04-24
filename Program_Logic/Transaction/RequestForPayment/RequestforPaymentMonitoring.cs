using AMSLogic.Transaction.Repository;
using AMSLogic.Model;
using AIMS.Inquiry;
using AMS.Inquiry;

using AMSLogic.Master.Repository;
using AMS.MasterFile;

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

        public void filter_btn_Click(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        public void RefreshGrid()
        {
            DisplayRecord();
            //_received.Close();
            //MessageBox.Show("Request for payment successfully sent Approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       public void DisplayRecord()
        {
            RequestRepository _i = new RequestRepository();
            dgvRequest.RowCount = 0;
            int n = 0;
            try
            {
                List<UDSP_GET_REQUEST_FOR_PAYMENT_MONITORINGResult> _lists = _i.GetRequestForPaymentMonitoring(chkCompany.Checked,int.Parse(txtCompany.Tag.ToString()),chkByDate.Checked,dtpYearFrom.Value,dtpYearTo.Value,txtKeyword.Text);
                if (_lists.Count != 0)
                {
                    foreach (UDSP_GET_REQUEST_FOR_PAYMENT_MONITORINGResult _list in _lists)
                    {
                        //prb.Value = prb.Value + 1;

                        n = dgvRequest.Rows.Add();
                        dgvRequest.Rows[n].Cells[0].Value = _list.id.ToString();
                        dgvRequest.Rows[n].Cells[1].Value = _list.request_id.ToString();
                        dgvRequest.Rows[n].Cells[2].Value = _list.request_no;
                        dgvRequest.Rows[n].Cells[3].Value = _list.request_date;
                        dgvRequest.Rows[n].Cells[4].Value = _list.supplier;
                        dgvRequest.Rows[n].Cells[5].Value = _list.reason;
                        dgvRequest.Rows[n].Cells[6].Value = _list.request_amount;
                        dgvRequest.Rows[n].Cells[7].Value = _list.employee_name;

                        if (_list.received_date != null) { dgvRequest.Rows[n].Cells[8].Value = _list.received_date.Value.ToShortDateString(); }
                        else { dgvRequest.Rows[n].Cells[8].Value = ""; }

                        if (_list.reply_date != null) { dgvRequest.Rows[n].Cells[9].Value = _list.reply_date.Value.ToShortDateString(); }
                        else { dgvRequest.Rows[n].Cells[9].Value = ""; }


                        dgvRequest.Rows[n].Cells[10].Value = _list.status;

                        dgvRequest.Rows[n].Cells[11].Value = _list.check_no;
                        dgvRequest.Rows[n].Cells[12].Value = _list.remarks;
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

        void Initializeform()
        {

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
                    _selected_status = dgvRequest.Rows[rowIndex].Cells[10].Value.ToString();
                    _selected_request_id = Convert.ToInt32( dgvRequest.Rows[rowIndex].Cells[1].Value.ToString());

                    _selected_request_no = dgvRequest.Rows[rowIndex].Cells[2].Value.ToString();

                    if (_selected_status == "Pending")
                    {
                        tsmReceive.Enabled = true;
                        tsmApprove.Enabled = false;
                    }
                    //}
                    //else if (_selected_status != "Pending")
                    //{
                    //    tsmReceive.Enabled = false;
                    //    tsmApprove.Enabled = true;
                    //}

                    else if (_selected_status == "Received")
                    {
                        tsmReceive.Enabled = false;
                        tsmApprove.Enabled = true;
                    }
                    //else if (_selected_status == "Approved" || _selected_status == "approved")
                    //{
                    //    tsmReceive.Enabled = false;
                    //    tsmApprove.Enabled = false;
                    //}
                    //else if (_selected_status == "Approved")
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
        RequestforPaymentReceiveform _recv;
        private void tsmReceive_Click(object sender, EventArgs e)
        {
            _recv = new RequestforPaymentReceiveform(_selected_id, _selected_request_id, this);
            _recv.BringToFront();
            _recv.ShowDialog();
        }

        RequestforPayementApprovalform _received;
        private void tsmApprove_Click(object sender, EventArgs e)
        {
            _received = new RequestforPayementApprovalform(_selected_id, _selected_request_id, this);
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

        private void btn_company_Click(object sender, EventArgs e)
        {
            if (!chkCompany.Checked) { return; }
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtCompany.Text = _obj.description;
                txtCompany.Tag = _obj.id;
            }
        }

        private void dtpYearTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByDate.Checked == true)
            {
                dtpYearFrom.Enabled = true;
                dtpYearTo.Enabled = true;

            }
            else
            {
                dtpYearFrom.Enabled = false;
                dtpYearTo.Enabled = false;
                dtpYearFrom.Value = DateTime.Now;
                dtpYearTo.Value = DateTime.Now;
            }

        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompany.Checked == true)
            {
                btn_company.Enabled = true;
            }
            else
            {
                btn_company.Enabled = false;
                txtCompany.Clear();
            }
        }
    }
}
