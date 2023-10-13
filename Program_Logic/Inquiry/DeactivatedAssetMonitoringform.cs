using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.MasterFile;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMS.MasterFile.Asset;
using AMS.Transaction.Issuance;
using AMSLogic.Transaction.Repository;
using AIMS.Transaction.Reactivate;
using AMS.Transaction.Deactivate;
using AMS.Inquiry;



namespace AIMS.Inquiry
{
    public partial class DeactivatedAssetMonitoringform : Form
    {
        int _id = 0;
        int _status = 0;
        bool _byyear = false;
        string _datevalue = "";
        DateTime _from = DateTime.Now;
        DateTime _to = DateTime.Now;
        string _company = "";
        bool _bycomppany = false;
        bool _byissuancestat = false;
        string _issuancestatus = "";
        bool _byqrstat = false;
        string _qrstat = "";
        public DeactivatedAssetMonitoringform()
        {
            InitializeComponent();
        }

        private void cntxMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) { return; }
            try
            {
                if (e.ColumnIndex == 1)                 //View at
                {
                    _id = int.Parse(dgvAsset.Rows[e.RowIndex].Cells[0].Value.ToString());

                    AssetMasterform _form = new AssetMasterform(_id);
                    _form.Tag = _id.ToString();
                    _form.BringToFront();
                    _form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void DisplayRecords()
        {
            AssetRepository _repo = new AssetRepository();
            IssuanceRepository _iss = new IssuanceRepository();
            //   EmployeeRepository _emp = new EmployeeRepository();
            //   INV_ISSUANCE _issu = new INV_ISSUANCE();
            dgvAsset.RowCount = 0;
            prb.Value = 0;
            int n = 0;




            try
            {
                List<UDSP_I_GET_ASSET_MONITORINGResult> _lists = _repo.GetAssets(chkItemType.Checked,
                int.Parse(txtItemType.Tag.ToString()),
                chkBrand.Checked,
                int.Parse(txtBrand.Tag.ToString()),
                txtKeyword.Text, _status,_bycomppany,_company,_byyear,_datevalue,_from,_to,_byissuancestat,_issuancestatus,_byqrstat,_qrstat);

                prb.Maximum = _lists.Count();
                if (_lists != null)
                {
                    if (_lists.Count != 0)

                    {
                        foreach (UDSP_I_GET_ASSET_MONITORINGResult _list in _lists)

                        {
                            prb.Value = prb.Value + 1;

                            n = dgvAsset.Rows.Add();
                            dgvAsset.Rows[n].Cells[0].Value = _list.id.ToString();
                            dgvAsset.Rows[n].Cells[1].Value = _list.barcode;
                            dgvAsset.Rows[n].Cells[2].Value = _list.itemType;
                            dgvAsset.Rows[n].Cells[3].Value = _list.brandname;
                            dgvAsset.Rows[n].Cells[4].Value = _list.model_description;
                            dgvAsset.Rows[n].Cells[5].Value = _list.serial_no;
                            dgvAsset.Rows[n].Cells[6].Value = _list.host_name;

                            if (_list.mfg_date == null) { dgvAsset.Rows[n].Cells[7].Value = null; }
                            else { dgvAsset.Rows[n].Cells[7].Value = _list.mfg_date.Value.ToShortDateString(); }

                            if (_list.date_purchase == null) { dgvAsset.Rows[n].Cells[8].Value = null; }
                            else { dgvAsset.Rows[n].Cells[8].Value = _list.date_purchase.Value.ToShortDateString(); }

                            if (_list.date_warranty == null) { dgvAsset.Rows[n].Cells[9].Value = null; }
                            else { dgvAsset.Rows[n].Cells[9].Value = _list.date_warranty.Value.ToShortDateString(); }

                            dgvAsset.Rows[n].Cells[10].Value = _list.CurrentOwner;
                            dgvAsset.Rows[n].Cells[11].Value = _list.Department;
                            dgvAsset.Rows[n].Cells[12].Value = _list.Company;
                            dgvAsset.Rows[n].Cells[13].Value = _list.status;
                            dgvAsset.Rows[n].Cells[14].Value = _list.username;
                            dgvAsset.Rows[n].Cells[15].Value = _list.date_created.Value.ToShortDateString();

                            //List<INV_ISSUANCE> _issuances = _repo.GetAssetOwnerHistory(_id);
                            //{
                            //    if (_issuances.Count != 0)
                            //    {
                            //        foreach (INV_ISSUANCE _issuance in _issuances)
                            //        {
                            //            dgvAsset.Rows[n].Cells[8].Value = _issuance.EMP_EMPLOYEE;
                            //        }
                            //    }
                            //}


                            int Rcount = dgvAsset.Rows.Count;
                            lblRcount.Text = Rcount.ToString();
                        }
                    }

                    else
                    {
                        MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeactivatedAssetMonitoring_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void btn_itemtype_Click(object sender, EventArgs e)
        {
            if (!chkItemType.Checked)
            { return; }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "ITEM TYPE";
            _Searchform.ShowDialog();

            INV_TYPE _obj = _Searchform.ReturnSearchItemtype;
            if (_obj != null)
            {
                txtItemType.Text = _obj.description;
                txtItemType.Tag = _obj.id;
            }

            DisplayRecords();
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            if (!chkBrand.Checked)

            {
                return;

            }
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "BRAND";
            _Searchform.ShowDialog();

            SYS_BRAND _brand = _Searchform.ReturnSearchBrand;
            if (_brand != null)
            {
                txtBrand.Text = _brand.description;
                txtBrand.Tag = _brand.id;
            }
            DisplayRecords();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            DisplayRecords();
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

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (chkBrand.Checked) { btn_brand.PerformClick(); }
            }
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemtype_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (chkItemType.Checked) { btn_itemtype.PerformClick(); }
            }
        }
    }

}
