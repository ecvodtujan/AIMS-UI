using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMSLogic.Transaction.Repository;
using AMS.Inquiry;


namespace AIMS.Transaction.Reactivate
{
    public partial class AssetReactivateform : Form
    {
        INV_ASSET _asset;
        int _reactivate_id = 0;
        string _class = "REACTIVATION";
        public AssetReactivateform(INV_ASSET _Asset)
        {
            InitializeComponent();
            _asset = _Asset;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void DisplayRecord()
        {
            try
            {
                if (_asset != null)

                    txtBarcode.Text = _asset.barcode;
                txtAssetInfo.Text = _asset.model_description;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AssetReactivationform_(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        void ManageReactivate()

        {
            AssetRepository _react = new AssetRepository();
            try

            {
                INV_ASSET_REACTIVATION _obj = new INV_ASSET_REACTIVATION();

                _obj.id = _reactivate_id;
                _obj.asset_id = _asset.id;
                _obj.date_reactivate = dtpreactivate.Value;
                _obj.reason_id = int.Parse(txtReason.Tag.ToString());
                _obj.remarks = txtRemarks.Text;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;

                _react.ReactivationAsset(_obj, 0);

                MessageBox.Show("Asset successfully Reactivated ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_reactivate_Click(object sender, EventArgs e)
        {
            if (txtReason.Text == "")
            {
                btxMsg.ShowBalloon(txtReason);
                txtReason.Focus();
                return;
            }

            if (MessageBox.Show("Reactivate this Asset, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManageReactivate();
        }

        private void btn_reason_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._class = _class;
            _Searchform._searchby = "REASON BY CLASS";
            _Searchform.ShowDialog();

            SYS_REASON _obj = _Searchform.ReturnSearchReason;
            if (_obj != null)
            {
                txtReason.Text = _obj.reaseon_description;
                txtReason.Tag = _obj.id;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssetReactivation_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
