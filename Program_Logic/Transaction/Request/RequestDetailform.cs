using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Model;
using AMSLogic.Transaction.Repository;
using AMSLogic.Master.Repository;
using System.Globalization;
using AMS.Inquiry;

namespace AMS.Transaction.Request
{
    public partial class RequestDetailform : Form
    {
        Requestform _parent;
        int _id = 0;
        int _mode = 0;
        bool _loading = true;

        public RequestDetailform(Requestform _Parent, int _Id)
        {
            InitializeComponent();

            _parent = _Parent;
            _id = _Id;
        }

        private void RequestDetailform_Load(object sender, EventArgs e)
        {
            RequestRepository _i = new RequestRepository();
            DisplayRecord(_i.GetRequestDetail(_id));
        }

        void DisplayRecord(INV_REQUEST_DET _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _mode = 1;
                    txtDescription.Text = _obj.description;
                    txtItemtype.Text = _obj.INV_TYPE.description; txtItemtype.Tag = _obj.item_type_id.ToString();
                    txtBrand.Text = _obj.SYS_BRAND.description; txtBrand.Tag = _obj.brand_id.ToString();
                    txtQty.Text = _obj.qty.ToString() ;
                    txtUnit.Text = _obj.unit;
                    txtUnitPrice.Text = _obj.unit_price.ToString("N", new CultureInfo("en-US")); 
                    txtAmount.Text = _obj.amount.ToString("N", new CultureInfo("en-US"));
                    txtDetRemarks.Text = _obj.remarks;

                    btn_save.Text = "Update";
                    btn_delete.Visible = true;
                }
                else
                {
                    _mode = 0;
                    Initializeform();

                    btn_delete.Visible = false;
                }

                _loading = false;
            }
            catch (Exception ex)
            {
                _loading = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Initializeform()
        {
            txtDescription.Text = "";
            txtItemtype.Text = ""; txtItemtype.Tag = "0";
            txtBrand.Text = ""; txtBrand.Tag = "0";
            txtQty.Text = "1";
            txtUnit.Text = "pcs";
            txtUnitPrice.Text = "0.00";
            txtAmount.Text = "0.00";
            txtDetRemarks.Text = "";
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateText(txtDescription)) { return; }
            if (!ValidateText(txtItemtype)) { return; }
            if (!ValidateText(txtBrand)) { return; }
            if (!ValidateText(txtQty)) { return; }
            if (!ValidateText(txtUnitPrice)) { return; }

            try
            {
                ManageRecord();
                this.Close();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove selected details, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            try
            {
                _mode = 2;
                ManageRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageRecord()
        {
            INV_REQUEST_DET _obj = new INV_REQUEST_DET();
            _obj.id = _id;
            _obj.request_id = _parent._id;
            _obj.item_type_id = int.Parse(txtItemtype.Tag.ToString()); ;
            _obj.brand_id = int.Parse(txtBrand.Tag.ToString());
            _obj.qty = decimal.Parse(txtQty.Text);
            _obj.description = txtDescription.Text;
            _obj.remarks = txtDetRemarks.Text;
            _obj.unit = txtUnit.Text;
            _obj.unit_price = decimal.Parse(txtUnitPrice.Text);
            _obj.amount = decimal.Parse(txtAmount.Text);

            _parent.ManageDetailRecord(_obj, _mode);
        }

        void ComputeAMount()
        {
            try
            {
                if (txtUnitPrice.Text.Length == 0) { txtAmount.Text = "0.00"; return; }
                if (txtQty.Text.Length == 0) { txtAmount.Text = "0.00"; return; }

                decimal _qty = decimal.Parse(txtQty.Text);
                decimal _unit_price = decimal.Parse(txtUnitPrice.Text);

                decimal _amount = _qty * _unit_price;
                txtAmount.Text = _amount.ToString("N", new CultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (_loading) { return; }

            ComputeAMount();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (_loading) { return; }

            ComputeAMount();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestDetailform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "ITEM TYPE";
            _Searchform.ShowDialog();

            INV_TYPE _obj = _Searchform.ReturnSearchItemtype;
            if (_obj != null)
            {
                txtItemtype.Text = _obj.description;
                txtItemtype.Tag = _obj.id;
            }
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "BRAND";
            _Searchform.ShowDialog();

            SYS_BRAND _obj = _Searchform.ReturnSearchBrand;
            if (_obj != null)
            {
                txtBrand.Text = _obj.description;
                txtBrand.Tag = _obj.id;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtItemtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_itemtype.PerformClick(); }
        }

        private void txtBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_brand.PerformClick(); }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        //void ComputeTOtal()
        //{
        //    decimal _qty = 0;
        //    decimal _unit_price = 0;
        //    decimal _amount = 0;
        //    try
        //    {
        //        foreach (ListViewItem eachItem in lsvDetails.Items)
        //        {
        //            _qty = _qty + decimal.Parse(eachItem.SubItems[1].Text);
        //            _unit_price = _unit_price + decimal.Parse(eachItem.SubItems[3].Text);
        //            _amount = _amount + decimal.Parse(eachItem.SubItems[4].Text);
        //        }

        //        txtTotalQty.Text = _qty.ToString("N", new CultureInfo("en-US"));
        //        txtTotalUnitPrice.Text = _unit_price.ToString("N", new CultureInfo("en-US"));
        //        txtTotalAmount.Text = _amount.ToString("N", new CultureInfo("en-US"));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
