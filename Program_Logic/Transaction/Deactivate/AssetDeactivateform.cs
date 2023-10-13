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


namespace AMS.Transaction.Deactivate
{
    public partial class AssetDeactivateform : Form
    {
       // int _mode = 0;
        int _deactivate_id = 0;
        INV_ASSET _asset;
        string _class = "DEACTIVATION";
        public AssetDeactivateform(INV_ASSET _Asset)
        {
            InitializeComponent();

            //_mode = _Mode;
          //_deactivate_id = _Deactivate_Id;
            _asset = _Asset;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AssetDeactivateform_Load(object sender, EventArgs e)
        {
         
            DisplayRecord();
        }

        void DisplayRecord()
        {
           
            try
            {
                if (_asset !=null)
    
                txtBarcode.Text = _asset.barcode;
                txtAssetInfo.Text = _asset.model_description;
                 //dtpdeactivate.Value = DateTime.Now;
               

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageDeactivate()
        {
            AssetRepository _deact = new AssetRepository();
            try

            {
                INV_ASSET_DEACTIVATION _obj = new INV_ASSET_DEACTIVATION();

                _obj.id = _deactivate_id;
                _obj.asset_id = _asset.id;
                _obj.date_deactivate = dtpdeactivate.Value;
                _obj.reason_id = int.Parse(txtReason.Tag.ToString());
                _obj.remarks = txtRemarks.Text;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;

                _deact.DeactivationAsset(_obj, 0);

                MessageBox.Show("Asset successfully Deactivated " , "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deactivate_Click(object sender, EventArgs e)
        {
            if (txtReason.Text == "")
            {
                btxMsg.ShowBalloon(txtReason);
                txtReason.Focus();
                return;
            }
        
            if (MessageBox.Show("Deactivate this asset, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManageDeactivate();
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

        private void AssetDeactivation_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
    
}
