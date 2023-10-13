using AMS.MasterFile.Asset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.Inquiry;
using AMSLogic.Model;
using AMSLogic.Master;
using AMSLogic.Master.Repository;
using AMSLogic.Admin;
using AMS.Report;
using AMSLogic.Transaction.Repository;

namespace AMS.MasterFile
{
    public partial class AssetMasterform : Form
    {
        public int _asset_id = 0;
      //  public int _test_variable = 0;
   //   public bool _active = true;
   // test only 10132023
        public object AssetInformationcontrol { get; internal set; }

        public void testpublic()
        {
            //can be access outside this form
        }

        private void testprivate()
        {
            //only access inside this form
        }

        public AssetMasterform(int _Asset_Id)
        {
            InitializeComponent();
            _asset_id = _Asset_Id;


        }

        private void label4_Click(object sender, EventArgs e)
        {
            //panExpan.BackColor = Color.Red;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssetMasterform_Load(object sender, EventArgs e)
        {

            try
            {
                AssetRepository _repo = new AssetRepository();
                lblID.Text = _asset_id.ToString();
                ClickAssetInformation();
            
                    var _asset = _repo.GetAsset(_asset_id);
                {
                    if (_asset != null)
                    {

                        if (_asset.status == false)
                        {
                            //  _active = false;
                            panel1.BackColor = Color.Red;
                            // panelDeac.Visible = true;
                            DeactivatePanel();
                            document_btn.Enabled = false;
                            repair_btn.Enabled = false;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetHighlight(Button _btn)
        {
            SidePanel.Top = _btn.Top;
        }

        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            panExpan.Controls.Add(_control);
        }

        void ClearPanel()
        {
            panExpan.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetHighlight(info_btn);
            ClickAssetInformation();

        }

       void ClickAssetInformation()
        {
            ClearPanel();

            var _control = new AssetInformationcontrol(this);
            AddControl(_control);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearPanel();
            SetHighlight(history_btn);
            var _control = new AssetOwnerHistorycontrol(this);
            AddControl(_control);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void repair_btn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            SetHighlight(repair_btn);
            var _control = new AssetRepairHistorycontrol(this);
            AddControl(_control);
        }

        private void AssetMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearPanel();
            SetHighlight(document_btn);
            var _control = new AssetDocumentcontrol(this);
            AddControl(_control);
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            panelDeac.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        public void DeactivatePanel()
        {
            panelDeac.Visible = true;
            var _form = new AssetMasterform(_asset_id);
            _form.Enabled = false;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panelDeac.Visible == true)
            {
                if (lblAsset.ForeColor == Color.Silver)
                { lblAsset.ForeColor = Color.Gold; }
                else { lblAsset.ForeColor = Color.Silver; }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_btn_Click_1(object sender, EventArgs e)
        {
            panelDeac.Visible = false;
            var _form = new AssetMasterform(_asset_id);
            _form.Enabled = true;
        }

        private void panDeac_Keydown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    panelDeac.Visible = false;
               
            //}
        }
    }
}
