using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AMSLogic;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMS.Report;
using AMS.Inquiry;
using AIMS.Transaction.Request;

using AMS.Admin;

namespace AMS.Transaction.Decommission
{
    public partial class AddDecommissionDetails : Form
    {
        int _id = 0;
        int _mode = 0;
        int _parentid = 0;
        int _asset_id = 0;

        public AddDecommissionDetails(int _parentId)
        {
            InitializeComponent();
            _parentid = _parentId;
        }

      
        void DisplayRecords()
        {
            //AMSLogic.Master.Repository.BrandRepository _brandrepo = new AMSLogic.Master.Repository.BrandRepository();
            AssetRepository _repo = new AssetRepository();
            BrandRepository _brandrepo = new BrandRepository();
            lsvList.Items.Clear();
            try
            {
                List<UDSP_I_GET_ASSET_MONITORINGResult> _brands = _repo.GetAssets(chkItemType.Checked,
                int.Parse(txtItemType.Tag.ToString()),
                chkBrand.Checked,
                int.Parse(txtBrand.Tag.ToString()),
                txtKeyword.Text, 1, chkCompany.Checked, cboCompany.Text, false, "", DateTime.Now, DateTime.Now, true, "AVAILABLE", false, "");
                //_brands = (from d in _brandrepo.GetBrands(txtBrandFilter.Text)orderby d.description select d).ToList();
                foreach (UDSP_I_GET_ASSET_MONITORINGResult _x in _brands)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.barcode);
                    _item.SubItems.Add(_x.itemType);
                    _item.SubItems.Add(_x.brandname);
                    _item.SubItems.Add(_x.model_description);
                    _item.SubItems.Add(_x.date_purchase.ToString());

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            try
            {
                _asset_id = int.Parse( lsvList.SelectedItems[0].Text);
             //   BrandRepository _brandrepo = new BrandRepository();
             //   DisplayRecord(_brandrepo.GetBrand(_id));
             ////   txtBrandFilter.Clear();
             ////   DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageRecord()
        {
            
        }

      
        private void BrandMasterform_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("BRAND MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void panFoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_bfilter_Click(object sender, EventArgs e)
        {  
           
        }

       

        private void AddDecommissionDetails_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void AddDecommissionDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCompany.Checked)
            {
                cboCompany.Enabled = false;
                cboCompany.SelectedIndex = 4;
            }
            else
            {
                cboCompany.Enabled = true;
            }
        }

        private void lsvList_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on adding this details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            DecommissionRepository _repo = new DecommissionRepository(); 
            INV_DECOMMISSION_DET _det = new INV_DECOMMISSION_DET();
            try
            {
                _det.id = 0;
                _det.decomm_id = _parentid;
                _det.asset_id = _asset_id;

                _id = _repo.ManageDecommissionDet(_det, 0);

                this.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        private void chkItemType_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkItemType.Checked)

            {
                txtItemType.Text = "";
            }
        }

        private void chkBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBrand.Checked)
            {
                txtBrand.Text = "";
            }
        }
    }
}
