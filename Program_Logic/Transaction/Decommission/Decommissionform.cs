
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



namespace AMS.Transaction.Decommission
{
    public partial class Decommissionform : Form
    {
        public int _id = 0;
        int _mode = 0;

        bool _filestatus = false;
        bool _posted = false;
        int _status = 1;
        int _dept_id = 30;
        bool _request = false;
        public Decommissionform(int _Id)
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
            txtDecommNo.Focus();
        }

        void EnableForm(bool _condition)
        {

            dtpDateEffective.Enabled = _condition;
        
        }

        void EnableSaveButton(bool _condition)
        {
            save_btn.Enabled = _condition;
            cancel_btn.Enabled = _condition;

            add_btn.Enabled = !_condition;
            edit_btn.Enabled = !_condition;
            refresh_btn.Enabled = !_condition;
 

            add_detail_btn.Enabled = !_condition;
         
            Approve_btn.Enabled = !_condition;
            post_btn.Enabled = !_condition;
            unpost_btn.Enabled = !_condition;
            document_btn.Enabled = !_condition;
            

        }

        void InitializeForm()
        {
            _id = 0;

            txtDecommNo.Text = "";
            lblRequestid.Text = "Request id : 0";
            txtRequesttype.Text = "";
            txtRequesttype.Tag = 0;      
            txtRequestedby.Text = "";
            txtLocation.Text = "";
            dtpDateEffective.Value = DateTime.Now;
            txtDateCreated.Text = "";
            txtDateApprove.Text = "";
         
        }

        private void btn_generate_series_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            AdminRepository _rep = new AdminRepository();
            txtDecommNo.Text = _rep.GenerateSeries("DECOMM", 0);
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
                txtRequestedby.Text = _obj.lastname + ", " + _obj.firstname + _obj.middlename.Substring(0);
                txtRequestedby.Tag = _obj.id;

                //txtRequestedby.Text = _obj.SYS_COMPANY.description;
                //txtRequestedby.Tag = _obj.company_id.ToString();

                //txtLocation.Text = _obj.INV_DEPARTMENT.department;
                //txtLocation.Tag = _obj.department_id.ToString();
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
  
        }

        private void receive_btn_Click(object sender, EventArgs e)
        {
           
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

            txtDecommNo.Focus();
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

            DecommissionRepository _repo = new DecommissionRepository();
            
            //DisplayRecord(_repo.GetRequest(_id));
        }
        void DisplayRecord(INV_DECOMMISION_HD _obj)
        {
            int _approvedby = int.Parse(_obj.approved_by.ToString());
            UserRepository _repo = new UserRepository();
            //SYS_USER _user = _repo.GetUser(_approvedby);

            _id = _obj.id;
            txtDecommNo.Text = _obj.decom_no;
            txtRequestedby.Text = _obj.EMP_EMPLOYEE.lastname + ", " + _obj.EMP_EMPLOYEE.firstname + " " + _obj.EMP_EMPLOYEE.middlename.Substring(0, 1);
            txtRequestedby.Tag = int.Parse(_obj.requested_by.ToString());
            txtRequesttype.Text = _obj.INV_DECOMMISSION_REQUEST_TYPE.description;
            txtRequesttype.Tag = int.Parse(_obj.request_type_id.ToString());
            txtLocation.Text = _obj.SYS_LOCATION.location;
            txtLocation.Tag = int.Parse(_obj.location_id.ToString());
            dtpDateEffective.Value = _obj.date_effective;
            txtDateCreated.Text = _obj.date_created.ToShortDateString();
            txtDateApprove.Text = _obj.date_approved.ToString();
            txtApproveby.Tag = _obj.approved_by;
            SYS_USER _user = _repo.GetUser(int.Parse(txtApproveby.Tag.ToString()));
            txtApproveby.Text = _user.username;
           

        }

        void DisplayDetails()
        {
            int n = 0;
            dgvRequest.RowCount = 0;
            decimal _total = 0;

            try
            {
                DecommissionRepository _i = new DecommissionRepository();
                List<UDSP_I_GET_DECOMMISSIONDET_MONITORINGResult> _obj = _i.GetDecommissionDet(_id);
                if (_obj.Count != 0)
                {
                    foreach (UDSP_I_GET_DECOMMISSIONDET_MONITORINGResult _list in _obj)
                    {
                        int _x = 0;
                        n = dgvRequest.Rows.Add();
                        dgvRequest.Rows[n].Cells[_x].Value = _list.ID.ToString(); _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = "View"; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = "Delete"; _x++;

                        dgvRequest.Rows[n].Cells[_x].Value = _list.asset_no; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.brand; _x++;

                        dgvRequest.Rows[n].Cells[_x].Value = _list.itemtype; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.description; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.date_purchased; _x++;
                        dgvRequest.Rows[n].Cells[_x].Value = _list.cost; _x++;

                    }
                }
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

                    save_btn.Enabled = false;
                    cancel_btn.Enabled = false;

                    print_btn.Enabled = true;
                    Approve_btn.Enabled = true;

                    post_btn.Enabled = false;
                    unpost_btn.Enabled = true;
                }
                else
                {
                    edit_btn.Enabled = true;

                    save_btn.Enabled = false;
                    cancel_btn.Enabled = true;

                    print_btn.Enabled = true;
                    Approve_btn.Enabled = false;

                    post_btn.Enabled = true;
                    unpost_btn.Enabled = false;

                }

            }
            else
            {

                edit_btn.Enabled = false;

                save_btn.Enabled = false;
                cancel_btn.Enabled = false;

                print_btn.Enabled = false;
                Approve_btn.Enabled = false;

                post_btn.Enabled = false;
                unpost_btn.Enabled = false;

            }
               
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void Requestform_Load(object sender, EventArgs e)
        {
            DecommissionRepository _repo = new DecommissionRepository();
            DisplayRecord(_repo.GetDecommissionHD(_id));
            DisplayDetails();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //SetHighlight(delete_btn);

            //if (MessageBox.Show("Proceed on Voiding this Request, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            //_mode = 2;
            //ManageRecord();
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

            if (!ValidateText(txtDecommNo)) { return; }
            if (!ValidateText(txtRequesttype)) { return; }
            if (!ValidateText(txtRequestedby)) { return; }
            if (!ValidateText(txtLocation)) { return; }
            //if (!ValidateText(txtItemtype)) { return; }
            //if (!ValidateText(txtBrand)) { return; }

            ManageRecord();
        }

        void ManageRecord()
        {
            DecommissionRepository _repo = new DecommissionRepository();
            INV_DECOMMISION_HD _obj = new INV_DECOMMISION_HD();
            int _approver = 0;

            if (_mode == 3)
            {
                _approver = LoginUser.userid;
            }
            else
            {
                _approver = 0;
            }

            try
            {
                
                _obj.id = _id;
                _obj.decom_no = txtDecommNo.Text;
                _obj.date_effective = dtpDateEffective.Value;
                _obj.request_type_id = int.Parse(txtRequesttype.Tag.ToString());
                _obj.approved_by = _approver;
                _obj.requested_by = int.Parse(txtRequestedby.Tag.ToString());
                _obj.location_id = int.Parse(txtLocation.Tag.ToString());
            

                _id = _repo.ManageDecommissionHD(_obj, _mode);


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
                txtRequestedby.Text = _obj.description;
                txtRequestedby.Tag = _obj.id;
            }
        }

        private void add_detail_btn_Click(object sender, EventArgs e)
        {
            //if (_posted)
            //{
            //    MessageBox.Show("You cannot add details once Request is already Posted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            AddDecommissionDetails _detail = new AddDecommissionDetails(_id);
            _detail.BringToFront();
            _detail.ShowDialog();

            //RequestRepository _i = new RequestRepository();
            //DisplayRecord(_i.GetRequest(_id));
        }

        public void ManageDetailRecord(INV_DECOMMISSION_DET _obj, int _mode)
        {
            DecommissionRepository _i = new DecommissionRepository();
            try
            {
                int _detid = _i.ManageDecommissionDet(_obj, _mode);
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
                DecommissionRepository _i = new DecommissionRepository();

                INV_DECOMMISSION_DET _obj = new INV_DECOMMISSION_DET();

                if (e.ColumnIndex == 2)                 //delete
                {
                    if (MessageBox.Show("Delete this selected details, are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    _obj.id = _det_id;
                   

                    ManageDetailRecord(_obj, 2);
                    MessageBox.Show("Detail successfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DisplayRecord(_i.GetRequest(_id));
                }
                else if (e.ColumnIndex == 1)            //edit
                {
                    //RequestDetailform _detail = new RequestDetailform(this, _det_id);
                    //_detail.BringToFront();
                    //_detail.ShowDialog();


                    //DisplayRecord(_i.GetRequest(_id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_department_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void document_btn_Click(object sender, EventArgs e)
        {
            //RequestDocumentform _document = new RequestDocumentform(this);
            //_document.BringToFront();
            //_document.ShowDialog();
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

        private void print_btn_click(object sender, EventArgs e)
        {

        }

        private void approve_btn_Click(object sender, EventArgs e)
        {

        }

        private void btn_requesttype_Click(object sender, EventArgs e)
        {

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "DECOMMISSION REQUEST TYPE";
            _Searchform.ShowDialog();

            INV_DECOMMISSION_REQUEST_TYPE _obj = _Searchform.ReturnSearchRequesttype;
            if (_obj != null)
            {
                txtRequesttype.Text = _obj.description;
                txtRequesttype.Tag = _obj.id;
            }
        }

        private void btn_Locaton_click(object sender, EventArgs e)
        {
         
        }

        private void btn_Location_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "LOCATION";
            _Searchform.ShowDialog();

            SYS_LOCATION _obj = _Searchform.ReturnSearchLocation;
            if (_obj != null)
            {
                txtLocation.Text = _obj.location;
                txtLocation.Tag = _obj.id;
            }
        }

        private void refresh_btn_Click_1(object sender, EventArgs e)
        {
            DecommissionRepository _repo = new DecommissionRepository();
            DisplayRecord(_repo.GetDecommissionHD(_id));
            DisplayDetails();
           
        }
    }
}
