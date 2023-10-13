using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using AMSLogic.Model;
using AMSLogic.Transaction;
using AMS.Inquiry;
using AMSLogic.Transaction.Repository;

namespace AMS.Transaction.Issuance
{
    
    public partial class AssetIssuanceForm : Form
    {
        INV_ASSET _asset;
        public AssetIssuanceForm(INV_ASSET _Asset)
        {
            InitializeComponent();

            _asset = _Asset;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssetIssuanceForm_Load(object sender, EventArgs e)
        {
            DisplayAsset();
        //    label4.Text = _asset.id.ToString();
        }

        void DisplayAsset()
        {
            try
            {
                if (_asset != null)
                {
                    txtBarcode.Text = _asset.barcode;
                    txtAssetInfo.Text = _asset.model_description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void btn_issuedby_Click(object sender, EventArgs e)
        {

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtIssuedBy.Text = _obj.employee_name;
                txtIssuedBy.Tag = _obj.id;
            }
        }

        private void btn_issuedto_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "EMPLOYEE";
            _Searchform.ShowDialog();

            EMP_EMPLOYEE _obj = _Searchform.ReturnSearchEmployee;
            if (_obj != null)
            {
                txtIssuedTo.Text = _obj.lastname + ", " + _obj.firstname ;
                txtIssuedTo.Tag = _obj.id;
            }
        }

        private void AssetIssuanceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void txtIssuedTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_issuedto.PerformClick(); }
        }

        private void txtIssuedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_issuedby.PerformClick(); }
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (txtIssuedTo.Text == "")
            {
                btxMsg.ShowBalloon(txtIssuedTo);
                txtIssuedTo.Focus();
                return;
            }

            if (txtIssuedBy.Text == "")
            {
                btxMsg.ShowBalloon(txtIssuedBy);
                txtIssuedBy.Focus();
                return;
            }

            if (MessageBox.Show("Proceed on issuing this asset, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageAsset();
        }

        void ManageAsset()
        {
            IssuanceRepository _i = new IssuanceRepository();
            try
            {
                INV_ISSUANCE _issuance = new INV_ISSUANCE();
                _issuance.id = 0;
                _issuance.date_issued = dtpDateIssue.Value;
                _issuance.issued_by = int.Parse(txtIssuedBy.Tag.ToString());
                _issuance.emp_id = int.Parse(txtIssuedTo.Tag.ToString());
                _issuance.asset_id = _asset.id;
                _issuance.remarks = txtRemarks.Text;
                _issuance.date_pullout = null;
                _issuance.pullout_by = 0;
              
                _i.ManageIssuance(_issuance, 0);


                MessageBox.Show("Asset successfully issued to " + txtIssuedTo.Text + ".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
