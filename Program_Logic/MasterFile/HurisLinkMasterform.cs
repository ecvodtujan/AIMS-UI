using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using AMSLogic.Master.Repository;
using AMSLogic.Model;
using AMS.Report;
using AMSLogic;
using AMS.Inquiry;
using AMS.Admin;
using AMSLogic.Master.Repository;


namespace AMS.MasterFile
{
    public partial class HurisLinkMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        HurisLinkRepository _link = new HurisLinkRepository();
        public HurisLinkMasterform()
        {
            InitializeComponent();
        }

        private void AssetTagSeries_Load(object sender, EventArgs e)
        {
            DisplayRecords();

           DisplayRecord(_link.GetHurisLink(_id));
            //DisplayRecord();

        }

        void InitializeForm()
        {
            txtEmployee.Text = "";
            txtHurisId.Text = "";
          

        }

        void EnableForm(bool _code)
        {
            txtHurisId.ReadOnly = !_code;
        }

        void EnableSaveButton(bool _code)
        {
            asst_save_btn.Enabled = _code;
            asst_cancel_btn.Enabled = _code;
            asst_add_btn.Enabled = !_code;
            asst_edit_btn.Enabled = !_code;
            asst_print_btn.Enabled = !_code;

            //btn_assetCode.Enabled = _code;
            btn_emp.Enabled = _code;
        }
        void Cancel()
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            
           DisplayRecord(_link.GetHurisLink(_id));
          //  DisplayRecord();
        }

        void ManageRecord()

        {
            
            INV_HURIS_LINK _obj = new INV_HURIS_LINK();
           ;
            try
            {
                _obj.id = _id;
                _obj.aims_emp_id = int.Parse(txtEmployee.Tag.ToString());
                _obj.huris_emp_id = int.Parse(txtHurisId.Text.ToString());
               

                _id = _link.ManageHurisLink(_obj, _mode);
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
         
            hurisLsvList.Items.Clear();
            {
                List<INV_HURIS_LINK>_series = (from d in _link.GetHurisLinks(txtFilter.Text) orderby d.EMP_EMPLOYEE.lastname ascending select d).ToList();
            
                foreach (INV_HURIS_LINK _s in _series)
                {
                    ListViewItem _item = new ListViewItem(_s.id.ToString());
                    _item.SubItems.Add(_s.EMP_EMPLOYEE.lastname + ", " + _s.EMP_EMPLOYEE.firstname);
                    _item.SubItems.Add(_s.huris_emp_id.ToString());
                    _item.SubItems.Add(_s.date_created.ToShortDateString());
                    hurisLsvList.Items.Add(_item);

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

        void DisplayRecord(INV_HURIS_LINK _obj)
        {
        

            try
            {
                INV_HURIS_LINK _huris = _link.GetHurisLink(_id);
                if (_huris != null)
                {
                    _id = _huris.id;
                    txtEmployee.Text = _huris.EMP_EMPLOYEE.firstname + " " + _huris.EMP_EMPLOYEE.lastname;
                    txtEmployee.Tag = int.Parse(_huris.aims_emp_id.ToString());
                    txtHurisId.Tag = int.Parse(_huris.huris_emp_id.ToString()); 

                }
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AssetTagSeries_Selectedindex(object sender, EventArgs e)
        {
            if (hurisLsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(hurisLsvList.SelectedItems[0].Text);

                DisplayRecord(_link.GetHurisLink (_id));
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
                btn_emp.PerformClick();
            }
        }

        private void assetItemCode_Keydown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    btn_assetCode.PerformClick();
            //}
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "EMPLOYEE";
            _Searchform.ShowDialog();

            EMP_EMPLOYEE _obj = _Searchform.ReturnSearchEmployee;
            if (_obj != null)
            {
                txtEmployee.Text = _obj.firstname + " " + _obj.lastname;
                txtEmployee.Tag = _obj.id;
            }
        }

        private void btn_assetCode_Click(object sender, EventArgs e)
        {
            //Searchform _Searchform = new Searchform();
            //_Searchform._searchby = "ITEM TYPE";
            //_Searchform.ShowDialog();

            //INV_TYPE _obj = _Searchform.ReturnSearchItemtype;
            //if (_obj != null)
            //{
            //    txtHurisId.Text = _obj.item_code;
            //    txtHurisId.Tag = _obj.id;
            //}
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
            if (txtEmployee.Text == "")
            {
                btxMsg.ShowBalloon(txtEmployee);
                txtEmployee.Focus();
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
