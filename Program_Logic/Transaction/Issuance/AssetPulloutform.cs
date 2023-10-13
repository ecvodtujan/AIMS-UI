using AMS.Inquiry;
using AMSLogic.Master.Repository;
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

namespace AMS.Transaction.Issuance
{
    public partial class AssetPulloutform : Form
    {
        int _mode = 0;
        int _issuance_id = 0;
        int _asset_id = 0;
        string _class = "PULL OUT";

        public AssetPulloutform(int _Mode, int _Issuance_Id, int _Asset_id)
        {
            InitializeComponent();

            _mode = _Mode;
            _issuance_id = _Issuance_Id;
            _asset_id = _Asset_id;
        }

        private void AssetPulloutform_Load(object sender, EventArgs e)
        {
            IssuanceRepository _i = new IssuanceRepository();
            DisplayIssuance(_i.GetIssuance(_issuance_id));

            dtpPullout.Focus();

            label8.Text = _issuance_id.ToString();
        }

        void DisplayIssuance(INV_ISSUANCE _obj)
        {
            UserRepository _iuser = new UserRepository();

            try
            {
                txtBarcode.Text = _obj.INV_ASSET.barcode;
                txtAssetInfo.Text = _obj.INV_ASSET.model_description;

                txtDateIssued.Text = _obj.date_issued.ToShortDateString();
                txtIssuedTo.Text = _obj.EMP_EMPLOYEE.lastname + ", " + _obj.EMP_EMPLOYEE.firstname;

                if (_obj.pullout_by.ToString() != "0")
                {
                    txtPulloutby.Tag = int.Parse(_obj.pullout_by.ToString());
                    txtPulloutby.Text = _iuser.GetUser(int.Parse(_obj.pullout_by.ToString())).employee_name;
                }
                else
                {
                    txtPulloutby.Tag = 0;
                    txtPulloutby.Text = "";
                }

                if (_obj.date_pullout != null)
                { dtpPullout.Value = _obj.date_pullout.Value; }
                else
                { dtpPullout.Value = DateTime.Now; }
                

                txtPulloutRemarks.Text = _obj.pullout_remarks;

                //txtpulloutReason.Text = _obj.SYS_REASON.reaseon_description;
                //txtpulloutReason.Tag = _obj.reason_id;
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageIssuance()
        {
            IssuanceRepository _i = new IssuanceRepository();
            try
            {
                INV_ISSUANCE _issuance = new INV_ISSUANCE();

                _issuance.id = _issuance_id;
                _issuance.date_issued = DateTime.Now;
                _issuance.issued_by = 0;
                _issuance.emp_id = 0;
                _issuance.asset_id = _asset_id;
                _issuance.remarks = "";
                _issuance.date_pullout = dtpPullout.Value ;
                _issuance.pullout_by = int.Parse(txtPulloutby.Tag.ToString());
                _issuance.pullout_remarks = txtPulloutRemarks.Text;
                _issuance.reason_id = int.Parse(txtpulloutReason.Tag.ToString());
                

                _i.ManageIssuance(_issuance, _mode);


                MessageBox.Show("Asset successfully pullout.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void btn_issuedto_Click(object sender, EventArgs e)
        {

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtPulloutby.Text = _obj.employee_name;
                txtPulloutby.Tag = _obj.id;
            }
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (txtPulloutby.Text == "")
            {
                btxMsg.ShowBalloon(txtPulloutby);
                txtPulloutby.Focus();
                return;
            }

            if (MessageBox.Show("Pullout this asset, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManageIssuance();
        }

        private void AssetPulloutform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void btn_pulloutReason_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._class = _class;
            _Searchform._searchby = "REASON BY CLASS";
            _Searchform.ShowDialog();

            SYS_REASON _obj = _Searchform.ReturnSearchReason;
            if (_obj != null)
            {
                txtpulloutReason.Text = _obj.reaseon_description;
                txtpulloutReason.Tag = _obj.id;
            }
        }
    }
}
