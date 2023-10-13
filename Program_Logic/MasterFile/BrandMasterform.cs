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
using AMS.Admin;

namespace AMS.MasterFile
{
    public partial class BrandMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public BrandMasterform()
        {
            InitializeComponent();
        }

        private void BrandMasterform_Load(object sender, EventArgs e)
        {
            BrandRepository _brandrepo = new BrandRepository();
            DisplayRecord(_brandrepo.GetBrand(_id));
            DisplayRecords();
        }

        void DisplayRecords()
        {
            //AMSLogic.Master.Repository.BrandRepository _brandrepo = new AMSLogic.Master.Repository.BrandRepository();
            BrandRepository _brandrepo = new BrandRepository();
            lsvList.Items.Clear();
            try
            {
                List<SYS_BRAND> _brands = new List<SYS_BRAND>();
                _brands = (from d in _brandrepo.GetBrands(txtBrandFilter.Text)orderby d.description select d).ToList();
                foreach (SYS_BRAND _x in _brands)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.description);
                    _item.SubItems.Add(_x.status ? "Active" : "Inactive");
                    _item.SubItems.Add(_x.SYS_USER.username);
                    _item.SubItems.Add(_x.date_created.ToShortDateString());

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(SYS_BRAND _sysbrand)
        {
            BrandRepository _brandrepo = new BrandRepository();
            try
            { 
                SYS_BRAND _brand = new SYS_BRAND();
                _brand = _brandrepo.GetBrand(_id);

                //same lang yan sa taas
                //SYS_BRAND _brand = _brandrepo.GetBrand(_id);

                if (_brand != null)
                {
                    _id = _brand.id;
                    txtBrandname.Text = _brand.description;
                    txtStatus.Text = _brand.status ? "Active" : "Inactive";            //IIF

                    //if (_brand.status == true)                    //long way ng IF statement
                    //{ txtStatus.Text = "Active"; }
                    //else
                    //{ txtStatus.Text = "Inactive"; }

                    txtUsercreated.Text = _brand.SYS_USER.username;

                    // List<INV_ASSET> _assets = (from d in  _brand.INV_ASSETs select d).ToList();

                    txtDatecreated.Text = _brand.date_created.ToShortDateString();

                 
                }
                else
                {
                    MessageBox.Show("No record found!","Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                _id = int.Parse(  lsvList.SelectedItems[0].Text);
                BrandRepository _brandrepo = new BrandRepository();
                DisplayRecord(_brandrepo.GetBrand(_id));
             //   txtBrandFilter.Clear();
             //   DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);

            txtBrandname.Focus();
        }

        void EnableForm(bool _condition)
        {
            txtBrandname.ReadOnly = !_condition;
            lsvList.Enabled = !_condition;
        }

        void EnableSaveButton(bool _condition)
        {
            save_btn.Enabled = _condition;
            cancel_btn.Enabled = _condition;

            add_btn.Enabled = !_condition;
            edit_btn.Enabled = !_condition;
            deactivate_btn.Enabled = !_condition;
            activate_btn.Enabled = !_condition;
            print_btn.Enabled = !_condition;
        }

        void InitializeForm()
        {
            //_id = 0;
            txtBrandname.Text = "";
            txtStatus.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);

            txtBrandname.Focus();
        }

        private void deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on de-activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 2;
            ManageRecord();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            BrandRepository _brandrepo = new BrandRepository();
            DisplayRecord(_brandrepo.GetBrand(_id));
           // txtBrandname.Clear();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (txtBrandname.Text == "")
            {
                //MessageBox.Show("Brand name cannot be blank", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btxMsg.ShowBalloon(txtBrandname);
                txtBrandname.Focus();
                return;
            }

            ManageRecord();
           
        }

        void ManageRecord()
        {
            BrandRepository _brandrepo = new BrandRepository();
            SYS_BRAND _obj = new SYS_BRAND();
            try
            {
                _obj.id = _id;
                _obj.description = txtBrandname.Text;
                _obj.status = true;
                _obj.date_created = DateTime.Now;
                _obj.user_id = LoginUser.userid;                   //galing dapat sa login details

                _id = _brandrepo.ManageBrand(_obj, _mode);


                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                Cancel();
                

                //if (_mode == 0)
                //{
                //    _obj.id = _id;
                //    _obj.description = txtBrandname.Text;
                //    _obj.status = true;
                //    _obj.date_created = DateTime.Now;
                //    _obj.user_id = 1;                   //galing sa login

                //    _id = _brandrepo.CreateBrand(_obj);

                //    MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    DisplayRecords();
                //}
                //else if (_mode == 1)
                //{
                //    _obj.id = _id;
                //    _obj.description = txtBrandname.Text;
                //    _obj.status = true;
                //    _obj.date_created = DateTime.Now;
                //    _obj.user_id = 1;

                //    _id = _brandrepo.UpdateBrand(_obj);

                //    MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    DisplayRecords();

                //}
                //else if (_mode == 2)
                //{
                //    _obj.id = _id;
                //    _obj.description = txtBrandname.Text;
                //    _obj.status = true;
                //    _obj.date_created = DateTime.Now;
                //    _obj.user_id = 1;

                //    _id = _brandrepo.DisableBrand(_obj);

                //    MessageBox.Show("Record successfully disabled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    DisplayRecords();
                //}

                //else if (_mode == 3)
                //{
                //    _obj.id = _id;
                //    _obj.description = txtBrandname.Text;
                //    _obj.status = true;
                //    _obj.date_created = DateTime.Now;
                //    _obj.user_id = 1;

                //    _id = _brandrepo.EnableBrand(_obj);

                //    MessageBox.Show("Record successfully enabled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    DisplayRecords();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cancel()
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            BrandRepository _brandrepo = new BrandRepository();
            DisplayRecord(_brandrepo.GetBrand(_id));
        }
        private void activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on Activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 3;
            ManageRecord();
        }

        private void BrandMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
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

        private void txtBrandFilter_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)

            {

                DisplayRecords();
                //  lsvList.Focus();
            }

        }
    }
}
