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
using AMS.Report;
using AMSLogic;
using AMS.Inquiry;
using AMS.Admin;


namespace AMS.MasterFile
{
    public partial class AssetTagSeriesMasterform : Form
    {
        int _id = 0;
        int _mode = 0;
        public AssetTagSeriesMasterform()
        {
            InitializeComponent();
        }

        private void AssetTagSeries_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            AssetCodeRepository _coderepo = new AssetCodeRepository();
            DisplayRecord(_coderepo.GetCode(_id));
            //DisplayRecord();

        }

        void InitializeForm()
        {
            txtAssetCC.Text = "";
            txtAssetCode.Text = "";
            txtAssetSeries.Text = "";

        }

        void EnableForm(bool _code)
        {
            txtAssetSeries.ReadOnly = !_code;
        }

        void EnableSaveButton(bool _code)
        {
            asst_save_btn.Enabled = _code;
            asst_cancel_btn.Enabled = _code;
            asst_add_btn.Enabled = !_code;
            asst_edit_btn.Enabled = !_code;
            asst_print_btn.Enabled = !_code;

            btn_assetCode.Enabled = _code;
            btn_company.Enabled = _code;
        }
        void Cancel()
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            AssetCodeRepository _coderepo = new AssetCodeRepository();
           DisplayRecord(_coderepo.GetCode(_id));
          //  DisplayRecord();
        }

        void ManageRecord()

        {
            AssetCodeRepository _coderepo = new AssetCodeRepository();
            INV_COMPANY_ASSET_SERy _obj = new INV_COMPANY_ASSET_SERy();
            try
            {
                _obj.id = _id;
                _obj.company_id = int.Parse(txtAssetCC.Tag.ToString());
                _obj.asset_type_id = int.Parse(txtAssetCode.Tag.ToString());
                _obj.series_no = int.Parse(txtAssetSeries.Text);

                _id = _coderepo.ManageCode(_obj, _mode);
                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecords()
        {
            AssetCodeRepository _coderepo = new AssetCodeRepository();
            assetCodeLsvList.Items.Clear();
            {
                List<INV_COMPANY_ASSET_SERy> _series = new List<INV_COMPANY_ASSET_SERy>();
                _series = (from d in _coderepo.GetCodes(txtTagFilter.Text)orderby d.SYS_COMPANY.code, d.INV_TYPE.description select d).ToList();
                foreach (INV_COMPANY_ASSET_SERy _s in _series)
                {
                    ListViewItem _item = new ListViewItem(_s.id.ToString());
                    _item.SubItems.Add(_s.SYS_COMPANY.code);
                    _item.SubItems.Add(_s.INV_TYPE.description);
                    _item.SubItems.Add(_s.series_no.ToString());
                    assetCodeLsvList.Items.Add(_item);

                }
            }
        }

        private void AssetTag_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        void DisplayRecord(INV_COMPANY_ASSET_SERy _obj)
        {
            AssetCodeRepository _coderepo = new AssetCodeRepository();

            try
            {
                INV_COMPANY_ASSET_SERy _series = new INV_COMPANY_ASSET_SERy();
                _series = _coderepo.GetCode(_id);
                if (_series != null)
                {
                    _id = _series.id;
                    txtAssetCC.Text = _series.SYS_COMPANY.code;
                    txtAssetCC.Tag = int.Parse(_series.company_id.ToString());
                    txtAssetCode.Text = _series.INV_TYPE.item_code;
                    txtAssetCode.Tag = int.Parse(_series.asset_type_id.ToString());
                    txtAssetSeries.Text = _series.series_no.ToString();

                }
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AssetTagSeries_Selectedindex(object sender, EventArgs e)
        {
            if (assetCodeLsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(assetCodeLsvList.SelectedItems[0].Text);
                AssetCodeRepository _coderepo = new AssetCodeRepository();
                DisplayRecord(_coderepo.GetCode(_id));
             //   DisplayRecord();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void asst_add_btn_Click(object sender, EventArgs e)
        {
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);
            _mode = 0;
        }

        private void assetCC_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_company.PerformClick();
            }
        }

        private void assetItemCode_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_assetCode.PerformClick();
            }
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtAssetCC.Text = _obj.code;
                txtAssetCC.Tag = _obj.id;
            }
        }

        private void btn_assetCode_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "ITEM TYPE";
            _Searchform.ShowDialog();

            INV_TYPE _obj = _Searchform.ReturnSearchItemtype;
            if (_obj != null)
            {
                txtAssetCode.Text = _obj.item_code;
                txtAssetCode.Tag = _obj.id;
            }
        }

        private void asst_edit_btn_Click(object sender, EventArgs e)
        {
           // InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);
            _mode = 1;
        }

        private void asst_print_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void asst_save_btn_Click(object sender, EventArgs e)
        {
            if (txtAssetCC.Text == "")
            {
                btxMsg.ShowBalloon(txtAssetCC);
                txtAssetCC.Focus();
                return;
            }
            ManageRecord();
        }

        private void asst_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
        }

        private void assetTag(object sender, EventArgs e)
        {

        }

        private void txtTagfilter(object sender, EventArgs e)
        {
           // DisplayRecords();
        }

        private void txtAssetCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTagFilter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }
    }
  }
