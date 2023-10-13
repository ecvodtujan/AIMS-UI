using AMS.Inquiry;
using AMSLogic.Admin;
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
using AMSLogic.Master.Repository;
using AMSLogic.Admin;

namespace AMS.Transaction.Request
{
    public partial class PurchaseRequestform : Form
    {
        int _id = 0;
        int _poid = 0;
        int _mode = 0;
        int _selected_index = 0;
        bool _det_loading = false;

        public PurchaseRequestform(int _Id, DateTime _dateneeded)
        {
            InitializeComponent();

            AdminRepository _i = new AdminRepository();
            _i.FillcboPaymentType(cboPaymentType);

            _id = _Id;
            cboPaymentType.SelectedIndex = 0;
            //dtpDateNeeded.Value = _dateneeded;
        }

        private void btn_purchased_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtPurchaseBy.Text = _obj.employee_name;
                txtPurchaseBy.Tag = _obj.id;
            }
        }

        private void unpost_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseRequestform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
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

        private void post_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateText(txtPurchaseno)) { return; }
            if (!ValidateText(txtTerms)) { return; }
            //if (!ValidateText(txtCompanyName)) { return; }
            if (!ValidateText(txtSupplier)) { return; }
            if (!ValidateText(txtPurchaseBy)) { return; }

            if (MessageBox.Show("Proceed on tagging this request as Purchased, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            try
            {
                ManageRecord();                         //update request status
                ManagePurchaseHd(1);                    //add to INV_PURCHASE_HD
                //ManagePurchaseDet();                    //ADD TO INV_PURCHASE_DET
                //ManagePurchaseHd(3);                    //POST INV_PURCHASE_HD

                MessageBox.Show("Request successfully tagged as Purchased!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManagePurchaseHd(int _mode)
        {
            PurchaseOrderRepository _repo = new PurchaseOrderRepository();
            INV_PURCHASE_HD _obj = new INV_PURCHASE_HD();
           // INV_REQUEST_FOR_PAYMENT _ir = new 

            try
            {
                _obj.id = 0;
                _obj.request_id = _id;;
                _obj.po_no = txtPurchaseno.Text;
                _obj.po_date = dtpPurchasedate.Value;
                //_obj.date_needed = dtpDateNeeded.Value;
                //_obj.company_id = int.Parse(txtCompanyName.Tag.ToString()) ;
                _obj.supplier_id = int.Parse(txtSupplier.Tag.ToString());
                _obj.purchased_by = int.Parse(txtPurchaseBy.Tag.ToString());
                _obj.terms = int.Parse( txtTerms.Text);
                _obj.check_no = txtCheckno.Text;
                _obj.remarks = txtRemarks.Text;
                _obj.payment_type_id = int.Parse(cboPaymentType.SelectedValue.ToString());
                //_obj.file_status = true;
                //_obj.posted = true;
                //_obj.date_posted = DateTime.Now;
                
                _poid = _repo.ManagePurchaseHd(_obj, _mode);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //void ManagePurchaseDet()
        //{
        //    PurchaseOrderRepository _repo   = new PurchaseOrderRepository();
        //    int _detid                      = 0;

        //    try
        //    {
        //        for (int i = 0; i < lsvDetails.Items.Count; i++)                //loop tru listview item
        //        {
        //            INV_PURCHASE_DET _obj   = new INV_PURCHASE_DET();
        //            _obj.id                 = 0;
        //            _obj.po_id              = _poid;
        //            _obj.item_description   = lsvDetails.Items[i].Text;
        //            _obj.qty                = decimal.Parse(lsvDetails.Items[i].SubItems[1].Text);
        //            _obj.unit               = lsvDetails.Items[i].SubItems[2].Text;
        //            _obj.unit_price         = decimal.Parse( lsvDetails.Items[i].SubItems[3].Text);
        //            _obj.amount             = decimal.Parse( lsvDetails.Items[i].SubItems[4].Text);
        //            _obj.remarks            = lsvDetails.Items[i].SubItems[5].Text;

        //            _detid                  = _repo.ManagePurchaseDet(_obj, 0);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        // public void GeneratePO()
        //{
        //    POPrintRepository _po = new POPrintRepository();
        //    _po.GeneratePurchaseOrder(_poid, 3);

        //}
        void ManageRecord()
        {
            RequestRepository _repo = new RequestRepository();
            INV_REQUEST _obj = new INV_REQUEST();

            try
            {
                _obj.id = _id;
                _obj.request_no = "";
                _obj.date_requested = DateTime.Now;
                _obj.requested_by = 0;
                _obj.date_needed = DateTime.Now;
                //_obj.itemtype_id = 0;
                //_obj.brand_id = 0;
                //_obj.model_description = "";
                _obj.purpose = "";
                //_obj.recommendation = "";
                _obj.remarks = "";
                //_obj.estimated_cost = 0;
                _obj.purchased_by = int.Parse(txtPurchaseBy.Tag.ToString());
                _obj.purchased_date = dtpPurchasedate.Value;
                _obj.received_by = 0;
                _obj.received_date = null;
                _obj.received_remarks = "";
                //_obj.issued_by = 0;
                //_obj.issued_date = null;
                //_obj.issued_remarks = "";
                _obj.cancelled_by = 0;
                _obj.date_cancelled = null;
                _obj.cancelled_remarks = "";

                _id = _repo.ManageRequest(_obj, 3);

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  panDetails.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
        //    panDetails.Visible = true;
            Initialize();

          //  btn_save.Text = "Add";
         //   btn_delete.Visible = false;
         //   txtDescription.Focus();
        }

        void Initialize()
        {
            //txtDescription.Text = "";
            //txtQty.Text = "1";
            //txtUnit.Text = "Pcs";
            //txtUnitPrice.Text = "0.00";
            //txtAmount.Text = "0.00";
            //txtDetRemarks.Text = "";
        }

        private void PurchaseRequestform_Load(object sender, EventArgs e)
        {
            //  GeneratePONO();

            //txtPurchaseno.Focus();
            PurchaseOrderRepository _purchase = new PurchaseOrderRepository();
            DisplayPurchaseOrder(_purchase.GetPurchaseHD(_id, "hello"));
        }

        void DisplayPurchaseOrder(INV_PURCHASE_HD _iobj)
        {
            PurchaseOrderRepository _repo = new PurchaseOrderRepository();
            RequestRepository _re = new RequestRepository();
          
            try
            {
                INV_PURCHASE_HD _obj = _repo.GetPurchaseHD(_id, "hello");
                INV_REQUEST_FOR_PAYMENT _ir = _re.GetPayment(_id);
                if (_obj != null)
                {
                    _mode = 1;
                    txtPurchaseno.Text = _obj.po_no;
                    dtpPurchasedate.Value = DateTime.Now;
                    cboPaymentType.Text = _obj.payment_type_id.ToString();
                    txtTerms.Text = _obj.terms.ToString();
                    txtSupplier.Tag = _obj.supplier_id.ToString();
                    txtSupplier.Text = _obj.SYS_SUPPLIER.supplier_name;
                    txtPurchaseBy.Tag = _obj.user_id.ToString();
                    txtPurchaseBy.Text = _obj.SYS_USER.employee_name;
                    txtRemarks.Text = _obj.remarks;
                    txtCheckno.Text = _ir.check_no;


                    //txtPurchaseno.Text
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            //Searchform _Searchform = new Searchform();
            //_Searchform._searchby = "COMPANY";
            //_Searchform.ShowDialog();

            //SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            //if (_obj != null)
            //{
            //    txtCompanyName.Text = _obj.description;
            //    txtCompanyName.Tag = _obj.id;
            //}
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "SUPPLIER";
            _Searchform.ShowDialog();

            SYS_SUPPLIER _obj = _Searchform.ReturnSearchSupplier;
            if (_obj != null)
            {
                txtSupplier.Text = _obj.supplier_name;
                txtSupplier.Tag = _obj.id;
            }
        }

        private void itemlsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvDetails.SelectedItems.Count == 0) { return; }
            //_selected_index = lsvDetails.FocusedItem.Index;
        }

        private void lsvDetails_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            //    panDetails.Visible = true;
            //    btn_save.Text = "Save";
            //    btn_delete.Visible = true;
             
            //    DisplayDetails(lsvDetails.SelectedItems[0].Text,
            //        decimal.Parse(lsvDetails.SelectedItems[0].SubItems[0].Text),
            //        lsvDetails.SelectedItems[0].SubItems[2].Text,
            //        decimal.Parse(lsvDetails.SelectedItems[0].SubItems[3].Text),
            //        decimal.Parse(lsvDetails.SelectedItems[0].SubItems[4].Text),
            //        lsvDetails.SelectedItems[0].SubItems[5].Text);

            //    txtDescription.Focus();
            //}
            //catch (Exception ex)
            //{

            //}
        }

        void DisplayDetails(string _description, decimal _qty, string _unit, decimal _unit_price, decimal _amount, string _remarks)
        {
            _det_loading = true;

            //txtDescription.Text = _description;
            //txtQty.Text = _qty.ToString();
            //txtUnit.Text = _unit;
            //txtUnitPrice.Text = _unit_price.ToString("N", new CultureInfo("en-US"));
            //txtAmount.Text = _amount.ToString("N", new CultureInfo("en-US"));
            //txtDetRemarks.Text = _remarks;

            _det_loading = false;
        }

        private void btn_purchaseno_Click(object sender, EventArgs e)
        {
           // GeneratePONO();
        }

        void GeneratePONO()
        {
            AdminRepository _rep = new AdminRepository();

            int _dept_id = 0;
            if (LoginUser.usertype == "User" || LoginUser.usertype == "Admin")
            { _dept_id = 30; }
            
            txtPurchaseno.Text = _rep.GenerateSeries("PURCHASE" ,_dept_id);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            //if (_det_loading ) { return; }
           
            //ComputeAMount();
        }

        //void ComputeAMount()
        //{
        //    try
        //    {
        //        if (txtUnitPrice.Text.Length == 0) { txtAmount.Text = "0.00"; return; }
        //        if (txtQty.Text.Length == 0) { txtAmount.Text = "0.00"; return; }

        //        decimal _qty = decimal.Parse(txtQty.Text) ;
        //        decimal _unit_price = decimal.Parse(txtUnitPrice.Text);

        //        decimal _amount = _qty * _unit_price;
        //        txtAmount.Text = _amount.ToString("N", new CultureInfo("en-US"));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            //if (_det_loading) { return; }
            
            //ComputeAMount();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //if (!ValidateText(txtDescription)) { return; }
            //if (!ValidateText(txtQty)) { return; }
            //if (!ValidateText(txtUnit)) { return; }
            //if (!ValidateText(txtUnitPrice)) { return; }

            //try
            //{
            //    ListViewItem _item = new ListViewItem(txtDescription.Text);
            //    _item.SubItems.Add(txtQty.Text);
            //    _item.SubItems.Add(txtUnit.Text );
            //    _item.SubItems.Add(txtUnitPrice.Text);
            //    _item.SubItems.Add(txtAmount.Text);
            //    _item.SubItems.Add(txtDetRemarks.Text);

            //    lsvDetails.Items.Add(_item);

            //    ComputeTOtal();
            //    panDetails.Visible = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void ComputeTOtal()
        {
            //decimal _qty = 0;
            //decimal _unit_price = 0;
            //decimal _amount = 0;
            //try
            //{
            //    foreach (ListViewItem eachItem in lsvDetails.Items)
            //    {
            //        _qty = _qty + decimal.Parse(eachItem.SubItems[1].Text);
            //        _unit_price = _unit_price + decimal.Parse(eachItem.SubItems[3].Text);
            //        _amount = _amount + decimal.Parse(eachItem.SubItems[4].Text);
            //    }

            //    txtTotalQty.Text = _qty.ToString("N", new CultureInfo("en-US"));
            //    txtTotalUnitPrice.Text = _unit_price.ToString("N", new CultureInfo("en-US"));
            //    txtTotalAmount.Text = _amount.ToString("N", new CultureInfo("en-US"));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Remove selected details, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            //try
            //{
            //    lsvDetails.Items[_selected_index].Remove();
            //    ComputeTOtal();
            //    panDetails.Visible = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_supplier.PerformClick(); }
        }

        private void txtPurchaseBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_purchase.PerformClick(); }
        }

        private void txtTerms_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
