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
using AMSLogic.Master.Repository;

namespace AMS.Transaction.Decommission
{
    
    public partial class AssetDecommissionForm : Form
    {
        //INV_DECOMMISION_HD _decomm;
        int _decomid;
        public AssetDecommissionForm(int _DecomId)
        {
            InitializeComponent();

            _decomid = _DecomId;
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
            //try
            //{
            //    if (_asset != null)
            //    {
            //        txtBarcode.Text = _asset.barcode;
            //        txtAssetInfo.Text = _asset.model_description;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}     
        }

        private void btn_issuedby_Click(object sender, EventArgs e)
        {

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "USER";
            _Searchform.ShowDialog();

            SYS_USER _obj = _Searchform.ReturnSearchUser;
            if (_obj != null)
            {
                txtRequesttype.Text = _obj.employee_name;
                txtRequesttype.Tag = _obj.id;
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
                txtRequestedby.Text = _obj.lastname + ", " + _obj.firstname ;
                txtRequestedby.Tag = _obj.id;
            }
        }

        private void AssetIssuanceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void txtIssuedTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_requestedby.PerformClick(); }
        }

        private void txtIssuedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_requesttype.PerformClick(); }
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            if (txtRequestedby.Text == "")
            {
                btxMsg.ShowBalloon(txtRequestedby);
                txtRequestedby.Focus();
                return;
            }

            if (txtRequesttype.Text == "")
            {
                btxMsg.ShowBalloon(txtRequesttype);
                txtRequesttype.Focus();
                return;
            }

            if (MessageBox.Show("Proceed on Saving this asset, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageDecomm();
        }

        void ManageDecomm()
        {
            DecommissionRepository _i = new DecommissionRepository();
            try
            {
                INV_DECOMMISION_HD _decomm = new INV_DECOMMISION_HD();
                _decomm.id = 0;
                _decomm.decom_no = txtDecomm.Text;
                _decomm.date_effective = dtpDateEffective.Value;
                _decomm.request_type_id = int.Parse(txtRequesttype.Tag.ToString());
                _decomm.requested_by = int.Parse(txtRequestedby.Tag.ToString());
                _decomm.approved_by = 0;
                _decomm.location_id = int.Parse(txtLocation.Tag.ToString());
                _decomm.user_id = LoginUser.userid;

                _i.ManageDecommissionHD(_decomm, 0);


                MessageBox.Show("Record Successfully Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
