using AMS.MasterFile;
using AMSLogic.Master.Repository;
using AMSLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.MasterFile.Asset;
using AMS.Transaction.Issuance;
using AMSLogic.Transaction.Repository;
using AIMS.Transaction.Reactivate;
using AMS.Transaction.Deactivate;
using AIMS.Report;


namespace AMS.Inquiry

{
    public partial class AssetMonitoringform : Form
    {
        int _id = 0;
        int _mode = 0;
        int _company_id = 0;
      //  int _status = 0;
       // int _d_id = 0;

        public AssetMonitoringform()
        {
            InitializeComponent();
        }

        private void AssetMonitoringform_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            //lblStatus.Text = _status.ToString();
            cboCompany.SelectedIndex = 4;
            cboYear.SelectedIndex = 3;
            cboStatus.SelectedIndex = 2;
            cmbQRStatus.SelectedIndex = 2;    

        }

        private void button1_Click(object sender, EventArgs e)
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
                txtKeyword.Text, 1,chkCompany.Checked,cboCompany.Text,chkYear.Checked,cboYear.Text,dtpYearFrom.Value,dtpYearTo.Value,chkStatus.Checked,cboStatus.Text,chkQR.Checked,cmbQRStatus.Text);

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

                            if (_list.qr_status == true)
                            {
                                dgvAsset.Rows[n].Cells[16].Value = AIMS.Properties.Resources.check;
                            }
                            else
                            {
                                dgvAsset.Rows[n].Cells[16].Value = AIMS.Properties.Resources.dash;
                            }
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
                            if (_list.qr_status == false)
                            {
                                dgvAsset.Rows[n].DefaultCellStyle.BackColor = Color.LightPink;
                            }
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

        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DisplayRecords();
            SetHightlight(refresh_btn);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AssetMasterform _form = new AssetMasterform(0);
            _form.BringToFront();
            _form.Show();
            SetHightlight(add_btn);
        }
        private void btn_filter_Click(object sender, EventArgs e)
        {
            DisplayRecords();

            //  dgvAsset = 

        }

        private void dgvAsset_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dgvAsset.HitTest(e.X, e.Y).RowIndex;

                //if datagridview row is less than 0, exit 
                if (rowIndex == -1) { return; }

                _id = int.Parse(dgvAsset.Rows[rowIndex].Cells[0].Value.ToString());         //get id in the datagridview

                //get asset, condition status and issued status to enable/disable menu's
                AssetRepository _i = new AssetRepository();
                INV_ASSET _asset = _i.GetAsset(_id);
                if (_asset != null)
                {
                    if (_asset.status)
                    {
                        actAsset.Enabled = false;
                        deactAsset.Enabled = true;
                    }
                    else
                    {
                        actAsset.Enabled = true;
                        deactAsset.Enabled = false;
                      // issAsset.Enabled = false;
                    }

                    if (_asset.issued_status)
                    {
                        issAsset.Enabled = false;
                        pullAsset.Enabled = true;
                        deactAsset.Enabled = false;
                    }
                    else
                    {
                        issAsset.Enabled = true;
                        pullAsset.Enabled = false;
                    }

                    if (!_asset.status && !_asset.issued_status)
                    {
                        actAsset.Enabled = true;
                        deactAsset.Enabled = false;
                        issAsset.Enabled = false;
                        pullAsset.Enabled = false;
                    } 

                    else
                    {
                        actAsset.Enabled = false;
                    }
                    //if(!_asset.status)
                    //{
                    //    actAsset.Enabled = true;
                    //    deactAsset.Enabled = false;
                    //}
                }


                //attadched cntxMenu to datagrid contextmenustrip
                dgvAsset.ContextMenuStrip = cntxMenu;
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            //   label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            // label1.ForeColor = Color.Black;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {


        }

        private void actAsset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (MessageBox.Show("Are you sure you want to Activate this asset?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            //try
            //{
            //    ManageAsset(5);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //AssetRepository _r = new AssetRepository();
            //try
            //{
            //    INV_ASSET _react = _r.GetAsset(_id);
            //    AssetReactivateform _reactivate = new AssetReactivateform(_react);
            //    _reactivate.BringToFront();
            //    _reactivate.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void ManageRecord()

        {
            //AssetRepository _asset = new AssetRepository();
            //INV_ASSET _iAsset = new INV_ASSET();
            //{
            //     _iAsset.id = _id;
            //    _iAsset.status = true;
            //    _assetM._id = _asset.ManageAsset(_iAsset, _mode);
            //    if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            //    else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            //}
        }

        private void deactAsset_click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to Deactivate this asset?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            AssetRepository _d = new AssetRepository();
            try
            {
            
                INV_ASSET _deact = _d.GetAsset(_id);

          

                AssetDeactivateform _deactivate = new AssetDeactivateform(_deact);
                _deactivate.BringToFront();
                _deactivate.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void issAsset_Click(object sender, EventArgs e)
        {
            AssetRepository _i = new AssetRepository();
            try
            {
                INV_ASSET _asset = _i.GetAsset(_id);

                AssetIssuanceForm _issuance = new AssetIssuanceForm(_asset);
                _issuance.BringToFront();
                _issuance.ShowDialog();

                //MessageBox.Show("Asset successfully issued!","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pullAsset_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to Pullout this asset?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }


            try
            {
                int _issuance_id = 0;
                IssuanceRepository _i = new IssuanceRepository();
                INV_ISSUANCE _issuance = _i.GetCurrentOwner(_id);
                if (_issuance != null)
                {
                    _issuance_id = _issuance.id;
                }

                AssetPulloutform _pullout = new AssetPulloutform(5, _issuance_id, _id);
                _pullout.BringToFront();
                _pullout.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageAsset(int _mode)
        {
            AssetRepository _i = new AssetRepository();
            try
            {
                INV_ASSET _asset = new INV_ASSET();
                _asset.id = _id;
                _asset.barcode = "";
                _asset.inv_type_id = 0;
                _asset.brand_id = 0;
                _asset.model_description = "";
                _asset.serial_no = "";
                _asset.specification = "";
                // _asset.cost = "0.00";
                _asset.date_purchase = DateTime.Now;
                _asset.date_warranty = DateTime.Now;
                _asset.invoice_no = "";
                _asset.remarks = "";

                _id = _i.ManageAsset(_asset, _mode, _company_id);

                if (_mode == 2) { MessageBox.Show("Asset successfully Deactivated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (_mode == 5) { MessageBox.Show("Asset successfully Activated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else if (_mode == 4) { MessageBox.Show("Asset successfully pullout.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cntxMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btn_filter.PerformClick(); }
        }

        private void txtBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (chkBrand.Checked) { btn_brand.PerformClick(); }
            }
        }

        private void txtItemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (chkItemType.Checked) { btn_itemtype.PerformClick(); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetHightlight(Button _btn)
        {
            SidePanel.Top = _btn.Top;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkItemType_CheckedChange(object sender, EventArgs e)
        {
            if (!chkItemType.Checked)

            {
                txtItemType.Text = "";
            }
          
        }

        private void chkBrand_Change(object sender, EventArgs e)
        {
            if (!chkBrand.Checked)
            {
                txtBrand.Text = "";
            }

     
        }

        private void txtItemType_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chkYearChanged(object sender, EventArgs e)
        {
            if (!chkYear.Checked)
            {
                cboYear.Enabled = false;
                dtpYearFrom.Enabled = false;
                dtpYearTo.Enabled = false;
                btnDate.Enabled = false;

                cboYear.SelectedIndex = 3;
                dtpYearFrom.Value = DateTime.Now;
                dtpYearTo.Value = DateTime.Now;

            }
            else
            {
                cboYear.Enabled = true;
                dtpYearFrom.Enabled = true;
                dtpYearTo.Enabled = true;
                btnDate.Enabled = true;
            }
        }

        private void chkCompanyChange(object sender, EventArgs e)
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

        private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void printContextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            //  GenerateReport.ContextMenuStrip = printContextMenu;

            // printContextMenu.Show();

            ReportForm _form = new ReportForm();
            _form.Show();
            _form.BringToFront();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmpContext_Click(object sender, EventArgs e)
        {
            ReportForm _form = new ReportForm();
            _form.Show();
            _form.BringToFront();
        }

        private void chkStatus_CheckChanged(object sender, EventArgs e)
        {
            if (!chkStatus.Checked)
            {
                cboStatus.Enabled = false;
            }

            else
            {
                cboStatus.Enabled = true;
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void chkQR_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkQR.Checked)
            {
                cmbQRStatus.Enabled = false;
                cmbQRStatus.SelectedIndex = 2;
            }
            else
            {
                cmbQRStatus.Enabled = true;
            }
        }
    
    }
}
//        private void txtCompany_Keydown(object sender, KeyEventArgs e)
//        {
//            if (!chkCompany.Checked)
//            {
//                txtCompany.Text = "";
//            }
//        }

//        private void btnCompany_Click(object sender, EventArgs e)
//        {
//            if (!chkCompany.Checked)
//            { return; }

//            Searchform _Searchform = new Searchform();
//            _Searchform._searchby = "COMPANY";
//            _Searchform.ShowDialog();

//            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
//            if (_obj != null)
//            {
//                txtCompany.Text = _obj.description;
//                txtCompany.Tag = _obj.id;
//            }

//            DisplayRecords();
//        }
//    }
//}
