using AMS.Transaction.Request;
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
using System.Threading;
using AMS.Admin;

namespace AMS.Inquiry
{
    public partial class RequestMonitoringform : Form
    {
        public RequestMonitoringform()
        {
            InitializeComponent();
            dtpFrom.Value =DateTime.Parse(  "1/1/" + DateTime.Now.Year);
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Requestform _request = new Requestform(0);
            _request.BringToFront();
            _request.Show();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_requestor_Click(object sender, EventArgs e)
        {
            if (!chkReequestor.Checked) { return; }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtRequestedby.Text = _obj.employee_name;
                txtRequestedby.Tag = _obj.id;
            }

            DisplayRecords();
        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            if (!chkCompany.Checked) { return; }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY  _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtCompany.Text = _obj.description;
                txtCompany.Tag = _obj.id;
            }

            DisplayRecords();
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            //if (!chkBrand.Checked) { return; }

            //Searchform _Searchform = new Searchform();
            //_Searchform._searchby = "BRAND";
            //_Searchform.ShowDialog();

            //SYS_BRAND _obj = _Searchform.ReturnSearchBrand;
            //if (_obj != null)
            //{
            //    txtBrand.Text = _obj.description;
            //    txtBrand.Tag = _obj.id;
            //}
        }

        private void RequestMonitoringform_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        void DisplayRecords()
        {
            RequestRepository _repo = new RequestRepository();
            dgvRequest.RowCount = 0;
            prb.Value = 0;
            int n = 0;

            try
            {
                List<UDSP_I_GET_REQUEST_MONITORINGResult> _lists = _repo.GetRequestMonitoring(chkReequestor.Checked,
                    int.Parse(txtRequestedby.Tag.ToString()),
                    chkCompany.Checked,
                    int.Parse(txtCompany.Tag.ToString()),
                    chkDate.Checked,
                    dtpFrom.Value,
                    dtpTo.Value,
                    chkByStatus.Checked,
                    cboStatus.Text,
                    txtKeyword.Text,
                    chkCostCenter.Checked,
                    int.Parse(txtCostCenter.Tag.ToString())
                    );

                prb.Maximum = _lists.Count();

                if (_lists.Count != 0)
                {
                    foreach (UDSP_I_GET_REQUEST_MONITORINGResult _list in _lists)
                    {
                        prb.Value = prb.Value + 1;

                        n = dgvRequest.Rows.Add();
                        dgvRequest.Rows[n].Cells[0].Value = _list.ID.ToString();
                        dgvRequest.Rows[n].Cells[1].Value = _list.request_no;
                        dgvRequest.Rows[n].Cells[2].Value = _list.invoice_no;
                        dgvRequest.Rows[n].Cells[3].Value = _list.date_requested;
                        dgvRequest.Rows[n].Cells[4].Value = _list.Requestor;
                        dgvRequest.Rows[n].Cells[5].Value = _list.CostCenter;
                        dgvRequest.Rows[n].Cells[6].Value = _list.CompanyName;
                        dgvRequest.Rows[n].Cells[7].Value = _list.Purpose;

                        dgvRequest.Rows[n].Cells[8].Value = _list.file_status;

                        dgvRequest.Rows[n].Cells[9].Value = _list.username;
                        dgvRequest.Rows[n].Cells[10].Value = _list.date_created;
                    }
                }
                else
                {
                    //MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ToolsControl.CallPopMessage(this, "", "No record found!");
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            try
            {
                if (e.ColumnIndex == 1)                 //View SI
                {

                    int _id = int.Parse(dgvRequest.Rows[e.RowIndex].Cells[0].Value.ToString());

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

        private void txtRequestedby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (chkReequestor.Checked) { btn_requestor.PerformClick(); }
            }
        }

        private void txtCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (chkCompany.Checked) { btn_company.PerformClick(); }
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                filter_btn.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCostCenter_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                btn_CostCenter.PerformClick();
            }
        }

        private void btnCostCenter_click(object sender, EventArgs e)
        {
            if (!chkCostCenter.Checked) { return; }

            //Searchform _Searchform = new Searchform();
            //_Searchform._searchby = "DEPARTMENT";
            //_Searchform.ShowDialog();

            //INV_DEPARTMENT _obj = _Searchform.ReturnSearchDepartment;
            //if (_obj != null)
            //{
            //    txtCostCenter.Text = _obj.department;
            //    txtCostCenter.Tag = _obj.id;
            //}

            if (txtCompany.Text == "") { return; }
            Searchform _Searchform = new Searchform();
            _Searchform._companyid = int.Parse(txtCompany.Tag.ToString());
            _Searchform._searchby = "DEPARTMENT BY COMPANY";
            _Searchform.ShowDialog();

            INV_DEPARTMENT _obj = _Searchform.ReturnSearchDepartment;
            if (_obj != null)
            {
                txtCostCenter.Text = _obj.department;
                txtCostCenter.Tag = _obj.id;
            }
            DisplayRecords();
        }

        private void chkRequestor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkCostCenter_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void chkReequestor_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkReequestor.Checked)
            {
                txtRequestedby.Text = "";
            }
        }

        private void chkCompany_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chkCompany.Checked)
            {
                txtCompany.Text = "";
            }
        }

        private void chkCostCenter_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chkCostCenter.Checked)
            {
                txtCostCenter.Text = "";
            }
        }
    }
}
