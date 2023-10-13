using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.Inquiry;
using AMSLogic.Admin;
using AMSLogic.Model;
using AMSLogic.Transaction.Repository;
using AMSLogic.Master.Repository;



namespace AIMS.Transaction.Request
{
    public partial class PurchaseOrderform : Form
    {
        int _id = 0;
        int _poid = 0;
        int _mode = 2;
        int _purchase_id = 0;
        string _any;
        int _dept_id = 30;
      
        public PurchaseOrderform(int _Id)
        {
            InitializeComponent();
            _id = _Id;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTerms_TextChanged(object sender, EventArgs e)
        {

        }
        void DisplayRecord(INV_PURCHASE_HD _obj)
        {
       
            PurchaseOrderRepository _po = new PurchaseOrderRepository();
            try
            {
                INV_PURCHASE_HD _ip = _po.GetPurchaseHD(_id,_any );
                if (_ip != null)
                {

                    _mode = 3;
                    _purchase_id = _ip.id;
                    txtPurchaseno.Text = _ip.po_no;
                    cboPaymentTerms.Text = _ip.terms.ToString();
                    txtSupplier.Tag = int.Parse(_ip.supplier_id.ToString());
                    txtSupplier.Text = _ip.SYS_SUPPLIER.supplier_name;
                    txtPurchaseBy.Tag = int.Parse(_ip.user_id.ToString());
                    txtPurchaseBy.Text = _ip.SYS_USER.employee_name;
                    txtRemarks.Text = _ip.remarks;

                    btn_purchaseno.Enabled = false;
                }
                else
                {
                    btn_purchaseno.Enabled = true;
                    cboPaymentTerms.SelectedIndex = 0;
                   // _mode = 2;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManagePurchaseHD(int _mode)
        {
            PurchaseOrderRepository _repo = new PurchaseOrderRepository();
            INV_PURCHASE_HD _obj = new INV_PURCHASE_HD();
            try
            {
                _obj.id = _purchase_id;
                _obj.request_id = _id; 
                _obj.po_no = txtPurchaseno.Text;
                _obj.supplier_id = int.Parse(txtSupplier.Tag.ToString());
                _obj.purchased_by = int.Parse(txtPurchaseBy.Tag.ToString());
                _obj.terms = int.Parse(cboPaymentTerms.Text.ToString());
                _obj.remarks = txtRemarks.Text;

                //  _obj.check_no = txtCheckno.Text;


                _poid = _repo.ManagePurchaseHd(_obj, _mode);
                DisplayRecord(_repo.GetPurchaseHD(_id, _any));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btn_purchaseno_Click(object sender, EventArgs e)
        {
            GeneratePONO();
        }

        void GeneratePONO()
        {
            AdminRepository _rep = new AdminRepository();
            txtPurchaseno.Text = _rep.GenerateSeries("PORDER",_dept_id);
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_supplier.PerformClick(); }
        }

        private void txtPreparedby_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_purchase.PerformClick(); }
        }

        private void btn_printPO_Click(object sender, EventArgs e)
        {
          try
          { 
            RequestRepository _rr = new RequestRepository();
            PurchaseOrderRepository _por = new PurchaseOrderRepository();
            INV_PURCHASE_HD _ip = _por.GetPurchaseHD(_id, _any);
            INV_REQUEST _request = _rr.GetRequest(_id);
            POPrintRepository _po = new POPrintRepository();

                if (_ip != null)
                {
                    if (_request.company_id == 1)
                    {
                        _po._company = "ZMG";

                    }
                    else if (_request.company_id == 3)
                    {
                        _po._company = "APW";
                    }
                    else if (_request.company_id == 7)
                    {
                        _po._company = "APS";
                    }
                    else if (_request.company_id == 8)
                    {
                        _po._company = "ASI";
                    }

                   
                    _po.GeneratePurchaseOrder(_purchase_id, _id);

                  
                }

                else
                {
                    MessageBox.Show("Please fill out & save the data first before printing the PO", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

       //bool Validate(ComboBox _combo)
       // {
       //     bool _return = true;
       //     if (_combo.Text == "")
       //     {
       //         btxMsg.ShowBalloon(_combo);
       //         _textbox.Focus();
       //         _return = false;
       //     }
       //     return _return;
        //}

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (!ValidateText(txtPurchaseno)) { return; }
            if (!ValidateText(txtPurchaseBy)) { return; }
            if (!ValidateText(txtSupplier)) { return; }
            //if(cboPaymentTerms.Text == null)
            //{
            //    btxMsg.ShowBalloon(txtTerms);
            //    cboPaymentTerms.Focus();
            //    return;
            //}
            try
            {
                ManagePurchaseHD(_mode);

                MessageBox.Show("Request successfully Saved!, you can now generate the PO form", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PurchaseOrderform_Load(object sender, EventArgs e)
        {
           PurchaseOrderRepository _repo = new PurchaseOrderRepository();
           DisplayRecord(_repo.GetPurchaseHD(_id, _any));

            btn_purchaseno.PerformClick();
            txtPurchaseno.Focus();
        }

        void EnableButton()
        {
            btn_printPO.Enabled = false;
        }
       
    }
}
