using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIMS.Report;
using AIMS.Inquiry;
using AMSLogic.Model;
using AMS.Report;
using AMS.Inquiry;
using System.Globalization;

namespace AIMS.Report
{
    public partial class ReportForm : Form
    {

       public string _companyvalue = "";
       public string _yearvalue = "";
       public string _reportby = "";
    
     

 
        public ReportForm()
        {
            InitializeComponent();
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            if (chkCompany.Checked)
            {
                ReportViewerform _report = new ReportViewerform("ASSET REPORT BY COMPANY");
                {
                    _report._bycompany = chkCompany.Checked;
                    _report._company = cboCompany.Text;

                    _report.BringToFront();
                    _report.Show();
                }
            }
            else if (chkBrand.Checked)
            {
                ReportViewerform _report = new ReportViewerform("ASSET REPORT BY BRAND");
                {
                    _report._by_brand = chkBrand.Checked;
                    _report._brand_id = int.Parse(txtBrand.Tag.ToString());

                    _report.BringToFront();
                    _report.Show();
                }
            }
            
            else if (chkItemType.Checked)
            {
                ReportViewerform _report = new ReportViewerform("ASSET REPORT BY ITEMTYPE");
                {
                    _report._by_itemtype = chkItemType.Checked;
                    _report._itemtype_id = int.Parse(txtItemType.Tag.ToString());

                    _report.BringToFront();
                    _report.Show();
                }
            }
            else if (chkYear.Checked)
            {
                if (cboYear.SelectedIndex == 0 )
                {
                    ReportViewerform _report = new ReportViewerform("ASSET REPORT BY WARRANTY DATE");
                    {
                        _report._byyear = chkYear.Checked;
                        _report._datevalue = cboYear.Text;
                        _report._from = dtpYearFrom.Value;
                        _report._to = dtpYearTo.Value;

                        _report.BringToFront();
                        _report.Show();
                    }
                }
                else if (cboYear.SelectedIndex == 1)
                {
                    ReportViewerform _report = new ReportViewerform("ASSET REPORT BY PURCHASING DATE");
                    {
                        _report._byyear = chkYear.Checked;
                        _report._datevalue = cboYear.Text;
                        _report._from = dtpYearFrom.Value;
                        _report._to = dtpYearTo.Value;

                        _report.BringToFront();
                        _report.Show();
                    }
                }
                else if (cboYear.SelectedIndex == 2)
                {
                    ReportViewerform _report = new ReportViewerform("ASSET REPORT BY MANUFACTURING DATE");
                    {
                        _report._byyear = chkYear.Checked;
                        _report._datevalue = cboYear.Text;
                        _report._from = dtpYearFrom.Value;
                        _report._to = dtpYearTo.Value;

                        _report.BringToFront();
                        _report.Show();
                    }
                }
               
            }
            else
            {
                ReportViewerform _report = new ReportViewerform("ASSET REPORT BY ALL");
                {

                    _report.BringToFront();
                    _report.Show();
                }
            }




        }

        //void ClickByCompany()
        //{
        //    ClearPanel();
        //    var _control = new ByCompanyControl(this);
        //    AddControl(_control);
        //}
        //void ClearPanel()
        //{
        //    panExpan.Controls.Clear();
        //}
        //void AddControl(Control _control)
        //{
        //    _control.Dock = DockStyle.Fill;
        //    panExpan.Controls.Add(_control);
        //}

        void InitializeForm()
        {
            chkCompany.Checked = false;
            cboCompany.Enabled = false;
          
            chkYear.Checked = false;
            cboYear.Enabled = false;

            
            post_btn.Enabled = false;
        }

        private void chkCompany_checkedChange(object sender, EventArgs e)
        {
            if (!chkCompany.Checked)
            {
                cboCompany.Enabled = false;
                post_btn.Enabled = false;
            }

            else
            {
                cboCompany.Enabled = true;
                post_btn.Enabled = true;
            }
        }

        private void cbocompanyindexchange(object sender, EventArgs e)
        {
            //if (cboCompany.SelectedIndex == 0)

            //{
            //    txtBoxTest.Text = cboCompany.Text;

            //}

            //else if (cboCompany.SelectedIndex == 1)
            //{
            //    txtBoxTest.Text = "Asia PeopleSearch Inc.";
            //}
            //else if (cboCompany.SelectedIndex == 2)
            //{
            //    txtBoxTest.Text = "Asia Select Inc.";
            //}
            //else if (cboCompany.SelectedIndex == 3)
            //{
            //    txtBoxTest.Text = "Asia Peopleworks Inc.";
            //}
            //else
            //{
            //    txtBoxTest.Text = "";
            //}
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            cboCompany.SelectedIndex = 3;
            cboYear.SelectedIndex = 2;
            dtpYearTo.Value = DateTime.Parse("2022-01-01");
            dtpYearFrom.Value = DateTime.Parse("2022-12-31");
            cboreportby.SelectedIndex = 4;
        }

        private void txtBoxTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkYear_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkYear.Checked)
            {
                cboYear.Enabled = false;
                dtpYearFrom.Enabled = false;
                dtpYearFrom.Value = DateTime.Now;
                dtpYearTo.Value = DateTime.Now;
                dtpYearTo.Enabled = false;
            }
            else
            {
                cboYear.Enabled = true;
                dtpYearFrom.Enabled = true;
                dtpYearTo.Enabled = true;
            }
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
        }

        private void cboReportby_selectedchange(object sender, EventArgs e)
        {
            if (cboreportby.SelectedIndex == 0)
            {
                chkBrand.Enabled = false;
                chkCompany.Enabled = false;
                chkItemType.Enabled = true;
                chkYear.Enabled = false;
                txtBrand.Text = "";
               

            }
           else if (cboreportby.SelectedIndex == 1)
            {
                chkBrand.Enabled = true;
                chkCompany.Enabled = false;
                chkItemType.Enabled = false;
                chkYear.Enabled = false;
                txtItemType.Text = "";
                

            }
            else if (cboreportby.SelectedIndex == 2)
            {
                chkBrand.Enabled = false;
                chkCompany.Enabled = false;
                chkItemType.Enabled = false;
                chkYear.Enabled = true;
                txtBrand.Text = "";
                txtItemType.Text = "";


            }
            else if (cboreportby.SelectedIndex == 3)
            {
                chkBrand.Enabled = false;
                chkCompany.Enabled = true;
                chkItemType.Enabled = false;
                chkYear.Enabled = false;
                txtBrand.Text = "";
                txtItemType.Text = "";

            }
            else if (cboreportby.SelectedIndex == 4)
            {
                chkBrand.Enabled = false;
                chkCompany.Enabled = false;
                chkItemType.Enabled = false;
                chkYear.Enabled = false;
                txtBrand.Text = "";
                txtItemType.Text = "";

            }

        }

        private void chkItemtype_change(object sender, EventArgs e)
        {
            if (!chkItemType.Checked)
            {
                txtItemType.Text = "";
            }
            else
            {
                //ReportViewerform _report = new ReportViewerform("ASSET REPORT BY ITEMTYPE");
            }
        }

        private void chkBrand_change(object sender, EventArgs e)
        {

            if (!chkBrand.Checked)
            {
                txtBrand.Text = "";
            }
        }

        private void ReportForm_Leave(object sender, EventArgs e)
        {

        }
    }
}
