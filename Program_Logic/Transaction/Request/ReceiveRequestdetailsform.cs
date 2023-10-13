using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic.Model;
using AMSLogic.Master;
using AMS.Inquiry;

namespace AMS.Transaction.Request
{
    public partial class ReceiveRequestdetailsform : Form
    {
        ReceivedDetail _detail = new ReceivedDetail();
        ReceiveRequestform _parent;

        public ReceiveRequestdetailsform(ReceiveRequestform _Parent, ReceivedDetail _Detail)
        {
            InitializeComponent();

            _parent = _Parent;
            _detail = _Detail;

        }

        private void ReceiveRequestdetailsform_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        void DisplayRecord()
        {
            try
            {
                if (_detail != null)
                {
                    txtBarcode.Text = "SYSTEM GENERATED";
                    txtitemno.Text = _detail._itemno.ToString();
                    txtBarcode.Text = _detail._barcode;
                    txtDescription.Text = _detail._description;

                    txtItemtype.Tag = _detail._itemtypeid.ToString();
                    txtItemtype.Text = _detail._itemtype;

                    txtBrand.Tag = _detail._brandid.ToString();
                    txtBrand.Text = _detail._brandname;
                   
                    txtSerialno.Text = _detail._serialno;
                    txtCost.Text = _detail._cost.ToString();
                    txtSpecification.Text = _detail._specification;

                    //check if not null
                    if (_detail._warrantydate != null)  { dtpWarrantyDate.Checked = true; dtpWarrantyDate.Value = DateTime.Parse( _detail._warrantydate.ToString()); }
                    else { dtpWarrantyDate.Checked = false; }

                    if (_detail._mfgdate != null) { dtpMfgDate.Checked = true; dtpMfgDate.Value = DateTime.Parse( _detail._mfgdate.ToString()); }
                    else { dtpMfgDate.Checked = false; }
                    
                    txtRemarks.Text = _detail._remarks;
                }
                else
                {
                    MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateText(txtDescription)) { return; }
            if (!ValidateText(txtitemno)) { return; }
            if (!ValidateText(txtBrand)) { return; }
            if (!ValidateText(txtSerialno)) { return; }

            if (MessageBox.Show("Proceed in updating the detial information, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _detail._barcode = txtBarcode.Text;
            _detail._description = txtDescription.Text;
            _detail._itemtypeid = int.Parse(txtItemtype.Tag.ToString());

            _detail._itemtype = txtItemtype.Text;

            _detail._brandid = int.Parse(txtBrand.Tag.ToString());
            _detail._brandname = txtBrand.Text;

            _detail._serialno = txtSerialno.Text;
            _detail._cost = decimal.Parse(txtCost.Text);
            _detail._specification = txtSpecification.Text;

            //to allow null warranty date and manufacturing date
            if (dtpWarrantyDate.Checked) { _detail._warrantydate = dtpWarrantyDate.Value; }
            else { _detail._warrantydate = null; }

            if (dtpMfgDate.Checked) { _detail._mfgdate = dtpMfgDate.Value; }
            else { _detail._mfgdate = null; }
            
          
            _detail._remarks = txtRemarks.Text;

            _parent.UpdateRecord(_detail);
            this.Close();

        }

        private void ReceiveRequestdetailsform_KeyDown(object sender, KeyEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
