
using AMS.Inquiry;
using AMS.Report;
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
using AMS.Admin;
using AMS.Transaction.RequestForPayment;
using AIMS.Transaction.Request;


namespace AMS.Transaction.Request
{
    public partial class Requestform : Form
    {
        public int _id = 0;
        int _mode = 0;

        bool _filestatus = false;
        bool _posted = false;
        int _status = 1;
        int _dept_id = 30;
        bool _request = false;
        public Requestform(int _Id)
        {
            InitializeComponent();

            _id = _Id;
        }

        void SetHighlight(System.Windows.Forms.Button _btn)
        {
            SidePanel.Top = _btn.Top;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SetHighlight(add_btn);

            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);

            btn_generate_series.PerformClick();
            txtRequestno.Focus();
        }

        void EnableForm(bool _condition)
        {
            //  txtModel.ReadOnly = !_condition;
            txtPurpose.ReadOnly = !_condition;
            // txtRecommendation.ReadOnly = !_condition;
            txtRemarks.ReadOnly = !_condition;

            dtpDateRquested.Enabled = _condition;
            dtpDateNeeded.Enabled = _condition;
            // txtEstimatedCost.ReadOnly = !_condition;
        }

        void EnableSaveButton(bool _condition)
        {
            save_btn.Enabled = _condition;
            cancel_btn.Enabled = _condition;

            add_btn.Enabled = !_condition;
            edit_btn.Enabled = !_condition;
            refresh_btn.Enabled = !_condition;
            delete_btn.Enabled = !_condition;

            add_detail_btn.Enabled = !_condition;
            purchase_btn.Enabled = !_condition;
            receive_btn.Enabled = !_condition;
            issue_btn.Enabled = !_condition;
            print_btn.Enabled = !_condition;
            post_btn.Enabled = !_condition;
            unpost_btn.Enabled = !_condition;
            document_btn.Enabled = !_condition;
            request_for_payment_btn.Enabled = !_condition;
            purchaseOrder_btn.Enabled = !_condition;


        }

        void InitializeForm()
        {
            _id = 0;

            txtRequestno.Text = "";
            lblRequestid.Text = "Request id : 0";

            txtRequestedby.Text = ""; txtRequestedby.Tag = 0;
            //txtItemtype.Text = ""; txtItemtype.Tag = 0;
            //txtBrand.Text = ""; txtBrand.Tag = 0;
            //txtModel.Text = "";
            txtPurpose.Text = "";
            //txtRecommendation.Text = "";
            txtRemarks.Text = "";
            txtCompanyName.Text = "";
            txtdepartment.Text = "";

            dtpDateRquested.Value = DateTime.Now;
            dtpDateNeeded.Value = DateTime.Now;

            //txtEstimatedCost.Text = "0.00";

            txtPurchaseby.Text = "";
            txtPurchaseDate.Text = "";
            txtReceivedBy.Text = "";

            txtOfficialreceipt.Text = "";
            txtInvoiceno.Text = "";
            txtTotalAmount.Text = "0.00";
            txtReceivedDate.Text = "";
            txtCancelledby.Text = "";
            txtCancelledDate.Text = "";

            txtStatus.Text = "";
            txtCreatedby.Text = "";
        }

        private void btn_generate_series_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            AdminRepository _rep = new AdminRepository();
            txtRequestno.Text = _rep.GenerateSeries("REQUEST", _dept_id);
        }

        private void btn_requestedby_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "EMPLOYEE";
            _Searchform.ShowDialog();

            EMP_EMPLOYEE _obj = _Searchform.ReturnSearchEmployee;
            if (_obj != null)
            {
                txtRequestedby.Text = _obj.lastname + ", " + _obj.firstname;
                txtRequestedby.Tag = _obj.id;

                //txtCompanyName.Text = _obj.SYS_COMPANY.description;
                //txtCompanyName.Tag = _obj.company_id.ToString();

                //txtdepartment.Text = _obj.INV_DEPARTMENT.department;
                //txtdepartment.Tag = _obj.department_id.ToString();
            }

        }

        //private void btn_itemtype_Click(object sender, EventArgs e)
        //{
        //    if (add_btn.Enabled) { return; }

        //    Searchform _Searchform = new Searchform();
        //    _Searchform._searchby = "ITEM TYPE";
        //    _Searchform.ShowDialog();

        //    INV_TYPE _obj = _Searchform.ReturnSearchItemtype;
        //    if (_obj != null)
        //    {
        //        txtItemtype.Text = _obj.description;
        //        txtItemtype.Tag = _obj.id;
        //    }
        //}

        //private void btn_brand_Click(object sender, EventArgs e)
        //{
        //    if (add_btn.Enabled) { return; }

        //    Searchform _Searchform = new Searchform();
        //    _Searchform._searchby = "BRAND";
        //    _Searchform.ShowDialog();

        //    SYS_BRAND _obj = _Searchform.ReturnSearchBrand;
        //    if (_obj != null)
        //    {
        //        txtBrand.Text = _obj.description;
        //        txtBrand.Tag = _obj.id;
        //    }
        //    if (add_btn.Enabled) { return; }
        //}

        private void purchase_btn_Click(object sender, EventArgs e)
        {
            if (!_filestatus)
            {
                MessageBox.Show("Request is already cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!_posted)
            {
                MessageBox.Show("Kindly post first the request before tagging the request as Purchased.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_status != 6)
            {
                MessageBox.Show("Request cannot be process for purchased. Please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SetHighlight(purchase_btn);

            PurchaseRequestform _form = new PurchaseRequestform(_id, dtpDateNeeded.Value);
            _form.BringToFront();
            _form.ShowDialog();

            refresh_btn.PerformClick();                 //refresh display
        }

        private void receive_btn_Click(object sender, EventArgs e)
        {
            if (!_posted)
            {
                MessageBox.Show("Kindly post first the request before tagging as Purchased.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (_status != 2)
            {
                MessageBox.Show("Request cannot be process as recieved when its not yet purchased. Please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SetHighlight(receive_btn);

            ReceiveRequestform _form = new ReceiveRequestform(_id, DateTime.Parse(txtPurchaseDate.Text));
            _form.BringToFront();
            _form.ShowDialog();

            refresh_btn.PerformClick();
        }

        private void Requestform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            SetHighlight(edit_btn);

            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);

            txtRequestno.Focus();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            SetHighlight(cancel_btn);
            cancel();
        }

        void cancel()
        {
            EnableSaveButton(false);
            EnableForm(false);

            RequestRepository _repo = new RequestRepository();
            DisplayRecord(_repo.GetRequest(_id));
        }
        void DisplayRecord(INV_REQUEST _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _id = _obj.id;

                    txtRequestno.Text = _obj.request_no;
                    lblRequestid.Text = "Request id : " + _obj.id.ToString();

                    txtRequestedby.Text = _obj.EMP_EMPLOYEE.lastname + ", " + _obj.EMP_EMPLOYEE.firstname;
                    txtRequestedby.Tag = _obj.requested_by;

                    txtCompanyName.Text = _obj.SYS_COMPANY.description;
                    txtCompanyName.Tag = _obj.company_id.ToString();

                    txtdepartment.Text = _obj.INV_DEPARTMENT.department;
                    txtdepartment.Tag = _obj.department_id.ToString();
                    //txtItemtype.Text = _obj.INV_TYPE.description;
                    //  txtItemtype.Tag = _obj.itemtype_id;

                    //txtBrand.Text = _obj.SYS_BRAND.description;
                    //txtBrand.Tag = _obj.brand_id;

                    //txtModel.Text = _obj.model_description;
                    txtPurpose.Text = _obj.purpose;
                    //txtRecommendation.Text = _obj.recommendation;
                    txtRemarks.Text = _obj.remarks;

                    dtpDateRquested.Value = _obj.date_requested;
                    dtpDateNeeded.Value = _obj.date_needed;
                    //txtEstimatedCost.Text = _obj.estimated_cost.ToString("N", new CultureInfo("en-US"));

                    txtInvoiceno.Text = _obj.invoice_no;
                    txtOfficialreceipt.Text = _obj.official_receipt;

                    UserRepository _iuser = new UserRepository();
                    EmployeeRepository _iEmployee = new EmployeeRepository();


                    if (_obj.purchased_by.ToString() != "")
                    {
                        txtPurchaseby.Text = _iuser.GetUser(int.Parse(_obj.purchased_by.ToString())).employee_name;
                        txtPurchaseDate.Text = _obj.purchased_date.Value.ToShortDateString();
                    }

                    if (_obj.received_by.ToString() != "")
                    {
                        txtReceivedBy.Text = _iuser.GetUser(int.Parse(_obj.received_by.ToString())).employee_name;
                        txtReceivedDate.Text = _obj.received_date.Value.ToShortDateString();
                    }

                    if (_obj.cancelled_by.ToString() != "")
                    {
                        txtCancelledby.Text = _iuser.GetUser(int.Parse(_obj.cancelled_by.ToString())).employee_name;
                        txtCancelledDate.Text = _obj.date_cancelled.Value.ToShortDateString();
                    }


                    if (_obj.file_status) { txtStatus.Text = "Valid"; }
                    else { txtStatus.Text = "Cancelled"; }

                    txtCreatedby.Text = _obj.SYS_USER.username;

                    _filestatus = _obj.file_status;
                    _posted = _obj.posted;
                    _status = _obj.status;

                    ConfigureButtons(_obj.posted, _obj.file_status, _obj.status);
                }
                else
                {
                    //MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    add_btn.PerformClick();
                }

                DisplayDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayDetails()
        {
            int n = 0;
            dgvRequest.RowCount = 0;
            decimal _total = 0;

            try
            {
                RequestRepository _i = new RequestRepository();
                List<INV_REQUEST_DET> _obj = _i.GetRequestDetails(_id, true);
                if (_obj.Count != 0)
                {
                    foreach (INV_REQUEST_DET _list in _obj)
                    {
                        int _x = 0;
                        n = dgvRequest.Rows.Add();
                        dgvRequest.Rows[n].Cells[_x].Value = _list.id.ToString(); _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = "Edit"; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = "Delete"; _x++;

                        dgvRequest.Rows[n].Cells[_x].Value = _list.description; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.SYS_BRAND.description; _x++;

                        dgvRequest.Rows[n].Cells[_x].Value = _list.INV_TYPE.description; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.qty; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.unit; _x++;

                        dgvRequest.Rows[n].Cells[_x].Value = _list.unit_price.ToString("N", new CultureInfo("en-US")); ; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.amount.ToString("N", new CultureInfo("en-US")); ; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.remarks; _x++;

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

        void ConfigureButtons(bool _posted, bool _filestatus, int _status)
        {
            if (_filestatus)            //valid
            {
                if (_posted)
                {
                    edit_btn.Enabled = false;
                    delete_btn.Enabled = false;
                    save_btn.Enabled = false;
                    cancel_btn.Enabled = false;

                    post_btn.Enabled = false;
                    unpost_btn.Enabled = true;
                }

                //if (_status == 4)           //issued
                //{
                //    unpost_btn.Enabled = false;
                //    purchase_btn.Enabled = false;
                //    receive_btn.Enabled = false;
                //    issue_btn.Enabled = false;
                //}
                if (_status == 3)      //received
                {
                    add_detail_btn.Enabled = false;
                    unpost_btn.Enabled = false;

                    purchaseOrder_btn.Enabled = false;
                    request_for_payment_btn.Enabled = false;
                    purchase_btn.Enabled = false;
                    receive_btn.Enabled = false;
                    issue_btn.Enabled = true;
                }

                else if (_status == 6) // payment request has been approved
                {
                    add_detail_btn.Enabled = false;
                    unpost_btn.Enabled = false;

                    purchaseOrder_btn.Enabled = true;
                    request_for_payment_btn.Enabled = false;
                    purchase_btn.Enabled = true;
                    receive_btn.Enabled = false;
                    issue_btn.Enabled = false;
                   
                }
                else if (_status == 5)// payment request has been received
                {
                    add_detail_btn.Enabled = false;
                    unpost_btn.Enabled = false;

                    purchaseOrder_btn.Enabled = true;
                    request_for_payment_btn.Enabled = true;
                    purchase_btn.Enabled = false;
                    receive_btn.Enabled = false;
                    issue_btn.Enabled = false;
                }
                else if (_status == 4) // Payment request has been posted
                {
                    add_detail_btn.Enabled = false;
                    unpost_btn.Enabled = false;
                    purchaseOrder_btn.Enabled = true;

                    request_for_payment_btn.Enabled = true;
                    purchase_btn.Enabled = false;
                    receive_btn.Enabled = false;
                    issue_btn.Enabled = false;
                }


                else if (_status == 2)      //purchased
                {
                    add_detail_btn.Enabled = false;
                    unpost_btn.Enabled = false;

                    purchaseOrder_btn.Enabled = true;
                    request_for_payment_btn.Enabled = false;
                    purchase_btn.Enabled = false;
                    receive_btn.Enabled = true;
                    issue_btn.Enabled = false;
                }
                else if (_status == 1)      //draft
                {
                    add_detail_btn.Enabled = true;


                    purchaseOrder_btn.Enabled = true;
                    request_for_payment_btn.Enabled = true;
                    purchase_btn.Enabled = false;
                    receive_btn.Enabled = false;
                    issue_btn.Enabled = false;


                }


                else
                {
                    add_detail_btn.Enabled = true;
                    post_btn.Enabled = true;
                    unpost_btn.Enabled = false;

                    purchaseOrder_btn.Enabled = false;
                    request_for_payment_btn.Enabled = true;
                  
                    purchase_btn.Enabled = false;
                    receive_btn.Enabled = false;
                    issue_btn.Enabled = false;
                }

            }

            else
            {
                edit_btn.Enabled = false;
                delete_btn.Enabled = false;
                refresh_btn.Enabled = false;
                save_btn.Enabled = false;
                cancel_btn.Enabled = false;

                post_btn.Enabled = false;
                unpost_btn.Enabled = false;

                add_detail_btn.Enabled = false;


                purchaseOrder_btn.Enabled = false;
                request_for_payment_btn.Enabled = false;
                purchase_btn.Enabled = false;
                receive_btn.Enabled = false;
                issue_btn.Enabled = false;
            }

        
        
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            //   if (!add_btn.Enabled) { return; }
            SetHighlight(refresh_btn);

            RequestRepository _repo = new RequestRepository();
            DisplayRecord(_repo.GetRequest(_id));
        }

        private void Requestform_Load(object sender, EventArgs e)
        {
            RequestRepository _repo = new RequestRepository();
            DisplayRecord(_repo.GetRequest(_id));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SetHighlight(delete_btn);

            if (MessageBox.Show("Proceed on Voiding this Request, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 2;
            ManageRecord();
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            SetHighlight(save_btn);

            if (!ValidateText(txtRequestno)) { return; }
            if (!ValidateText(txtRequestedby)) { return; }
            if (!ValidateText(txtCompanyName)) { return; }
            if (!ValidateText(txtdepartment)) { return; }
            //if (!ValidateText(txtItemtype)) { return; }
            //if (!ValidateText(txtBrand)) { return; }

            ManageRecord();
        }

        void ManageRecord()
        {
            RequestRepository _repo = new RequestRepository();
            INV_REQUEST _obj = new INV_REQUEST();

            try
            {
                _obj.id = _id;
                _obj.request_no = txtRequestno.Text;
                _obj.date_requested = dtpDateRquested.Value;
                _obj.requested_by = int.Parse(txtRequestedby.Tag.ToString());
                _obj.company_id = int.Parse(txtCompanyName.Tag.ToString());
                //   _obj.department_id = int.Parse(txtdepartment.Tag.ToString());
                _obj.date_needed = dtpDateNeeded.Value;
                //_obj.itemtype_id = int.Parse(txtItemtype.Tag.ToString());
                //_obj.brand_id = int.Parse(txtBrand.Tag.ToString());
                //_obj.model_description = txtModel.Text;
                _obj.purpose = txtPurpose.Text;
                //_obj.recommendation = txtRecommendation.Text;
                _obj.remarks = txtRemarks.Text;
                //_obj.estimated_cost = decimal.Parse(txtEstimatedCost.Text);
                _obj.purchased_by = 0;
                _obj.purchased_date = null;
                _obj.received_by = 0;
                _obj.received_date = null;
                _obj.received_remarks = "";
                //_obj.issued_by = 0;
                //_obj.issued_date = null;
                //_obj.issued_remarks = "";
                _obj.cancelled_by = 0;
                _obj.date_cancelled = null;
                _obj.cancelled_remarks = "";
                _obj.department_id = int.Parse(txtdepartment.Tag.ToString());
                _id = _repo.ManageRequest(_obj, _mode);

                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully void!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                if (_mode == 0) { ToolsControl.CallShowNotification(this, _mode, "Record successfully created"); }
                else if (_mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully updated!"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully void!"); }

                cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            if (dgvRequest.Rows.Count == 0)
            {
                MessageBox.Show("Cannot post this request, no details found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            if (MessageBox.Show("Proceed on Posting this Request, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 6;
            ManageRecord();

            refresh_btn.PerformClick();
        }

        private void unpost_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Unposting this Request, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 7;
            ManageRecord();

            refresh_btn.PerformClick();
        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            //if (!_posted)
            //{
            //    MessageBox.Show("Kindly post first the request before tagging as Purchased.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}


            //if (_status != 3)
            //{
            //    MessageBox.Show("Request cannot be tagged as issued when its not yet received. Please check.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //SetHighlight(issue_btn);

            //IssuedRequestform _form = new IssuedRequestform(_id);
            //_form.BringToFront();
            //_form.ShowDialog();

            //refresh_btn.PerformClick();
        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtCompanyName.Text = _obj.description;
                txtCompanyName.Tag = _obj.id;
            }
        }

        private void add_detail_btn_Click(object sender, EventArgs e)
        {
            if (_posted)
            {
                MessageBox.Show("You cannot add details once Request is already Posted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RequestDetailform _detail = new RequestDetailform(this, 0);
            _detail.BringToFront();
            _detail.ShowDialog();

            RequestRepository _i = new RequestRepository();
            DisplayRecord(_i.GetRequest(_id));
        }

        public void ManageDetailRecord(INV_REQUEST_DET _obj, int _mode)
        {
            RequestRepository _i = new RequestRepository();
            try
            {
                int _detid = _i.ManageRequestdetails(_obj, _mode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            try
            {
                if (_posted)
                {
                    MessageBox.Show("You cannot edit/delete an request once its already Posted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!_filestatus)
                {
                    MessageBox.Show("You cannot edit/delete an request once its file status is already cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int _det_id = int.Parse(dgvRequest.Rows[e.RowIndex].Cells[0].Value.ToString());
                RequestRepository _i = new RequestRepository();

                INV_REQUEST_DET _obj = new INV_REQUEST_DET();

                if (e.ColumnIndex == 2)                 //delete
                {
                    if (MessageBox.Show("Delete this selected details, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    _obj.id = _det_id;
                    _obj.request_id = 0;
                    _obj.item_type_id = 0;
                    _obj.brand_id = 0;
                    _obj.qty = 0;
                    _obj.description = "";
                    _obj.remarks = "";
                    _obj.unit = "";
                    _obj.unit_price = 0;
                    _obj.amount = 0;
                    _obj.status = false;

                    ManageDetailRecord(_obj, 2);
                    MessageBox.Show("Detail successfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DisplayRecord(_i.GetRequest(_id));
                }
                else if (e.ColumnIndex == 1)            //edit
                {
                    RequestDetailform _detail = new RequestDetailform(this, _det_id);
                    _detail.BringToFront();
                    _detail.ShowDialog();


                    DisplayRecord(_i.GetRequest(_id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            string _any = "";

            RequestRepository _re = new RequestRepository();
            PurchaseOrderRepository _po = new PurchaseOrderRepository();
            INV_PURCHASE_HD _purch = _po.GetPurchaseHD(_id,_any);
            INV_REQUEST _req = _re.GetRequest(_id);
          

            ReportViewerform _report = new ReportViewerform("REQUEST PRINT OUT");
            _report._emp_id = _req.requested_by;
            _report._request_id = _id;
            _report._supplier = _purch.SYS_SUPPLIER.supplier_name;
            _report._total = txtTotalAmount.Text;
            _report.BringToFront();
            _report.Show();
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled)
            { return; }

            //Searchform _Searchform = new Searchform();
            //_Searchform._searchby = "DEPARTMENT";
            //_Searchform.ShowDialog();

            //INV_DEPARTMENT _obj = _Searchform.ReturnSearchDepartment;
            //if (_obj != null)
            //{
            //    txtdepartment.Text = _obj.department;
            //    txtdepartment.Tag = _obj.id;
            //}


            if (txtCompanyName.Text == "") {
                btxMsg.ShowBalloon(txtCompanyName);
                txtCompanyName.Focus();
                return;
            }

            Searchform _Searchform = new Searchform();
            _Searchform._companyid = int.Parse(txtCompanyName.Tag.ToString());
            _Searchform._searchby = "DEPARTMENT BY COMPANY";
            _Searchform.ShowDialog();

            INV_DEPARTMENT _obj = _Searchform.ReturnSearchDepartment;
            if (_obj != null)
            {
                txtdepartment.Text = _obj.department;
                txtdepartment.Tag = _obj.id;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void document_btn_Click(object sender, EventArgs e)
        {
            RequestDocumentform _document = new RequestDocumentform(this);
            _document.BringToFront();
            _document.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void request_for_payment_btn_Click(object sender, EventArgs e)
        {

            if (!_posted)
            {
                MessageBox.Show("Kindly post first the request!.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RequestRepository _rr = new RequestRepository();
            INV_REQUEST_FOR_PAYMENT _ir = _rr.GetPayment(_id);

            if (_ir != null)
            {
                if (_ir.status == "Pending")
                {
                    MessageBox.Show("Your payment request has been already forwarded to accounting ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

          
                
            }
            RequestforPaymentform _payment = new RequestforPaymentform(_id);
            _payment.BringToFront();
            _payment.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void purchaseOrder_btn_Click(object sender, EventArgs e)
        {
            //if (_posted)
            //{
            //    MessageBox.Show("You cannot generate PO form once Request is already Posted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            PurchaseOrderform _purchase = new PurchaseOrderform(_id);
            _purchase.BringToFront();
            _purchase.ShowDialog();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
