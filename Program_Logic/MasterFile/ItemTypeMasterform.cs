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
using AMS.Admin;

namespace AMS.MasterFile
{
    public partial class ItemTypeMasterform : Form
    {
        int _id = 0;
        int _mode = 0;

        public ItemTypeMasterform()
        {
            InitializeComponent();
        }
        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemlsvList.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(itemlsvList.SelectedItems[0].Text);
                ItemTypeRepository _itemrepo = new ItemTypeRepository();
                DisplayRecord(_itemrepo.GetitemType(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {  }
  
        private void ItemTypeMasterform_Load(object sender, EventArgs e)
        {
            ItemTypeRepository _itemrepo = new ItemTypeRepository();
            DisplayRecord(_itemrepo.GetitemType(_id));
            DisplayRecords();
        }

        void DisplayRecords()
        {
            // AMSLogic.MasterFileMethods.ItemTypeRepository _itemrepo = new MasterFileMethods.ItemTypeRepository();
            //   itemlsvList.Items.Clear();
            ItemTypeRepository _itemrepo = new ItemTypeRepository();
            itemlsvList.Items.Clear();
            {
                List<INV_TYPE> _type = new List<INV_TYPE>();
                _type = (from d in _itemrepo.GetitemTypes(txtItemFilter.Text) orderby d.item_code select d).ToList();
                foreach (INV_TYPE _i in _type)
                {
                    ListViewItem _item = new ListViewItem(_i.id.ToString());
                    _item.SubItems.Add(_i.item_code);
                    _item.SubItems.Add(_i.description);
                    _item.SubItems.Add(_i.status ? "Active" : "Inactive");
                    _item.SubItems.Add(_i.SYS_USER.username);
                    _item.SubItems.Add(_i.date_created.ToShortDateString());
                    itemlsvList.Items.Add(_item);
                }
            }
        }
        void DisplayRecord(INV_TYPE  _obj)
        {
        //   AMSLogic.MasterFileMethods.ItemTypeRepository _itemrepo = new MasterFileMethods.ItemTypeRepository();
            ItemTypeRepository _itemrepo = new ItemTypeRepository();
           try
            {
                INV_TYPE _item = new INV_TYPE();
                _item = _itemrepo.GetitemType(_id);
                if (_item != null)
                {
                    _id = _item.id;
                   txtItemCode.Text = _item.item_code;
                    txtItmDesc.Text = _item.description;
                    txtItmStat.Text = _item.status ? "Active" : "Inactive";         
                    txtItmUCrtd.Text = _item.SYS_USER.username;
                    txtItmDCrtd.Text = _item.date_created.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void itm_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);
            txtItemCode.Focus();
        }
        void EnableSaveButton(bool _cond)
        {
            itm_save_btn.Enabled = _cond;
            itm_cancel_btn.Enabled = _cond;
            itm_add_btn.Enabled = !_cond;
            itm_edit_btn.Enabled = !_cond;
            itm_deactivate_btn.Enabled = !_cond;
            itm_print_btn.Enabled = !_cond;
            itm_activate_btn.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtItemCode.ReadOnly = !_cond;
            txtItmDesc.ReadOnly = !_cond;
            itemlsvList.Enabled = !_cond;
        }
        void InitializeForm()
        {
            txtItemCode.Text = "";
            txtItmDesc.Text = "";
            txtItmStat.Text = "";
            txtItmUCrtd.Text = "";
            txtItmDCrtd.Text = "";
        }

        private void itm_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);
            txtItemCode.Focus();
        }

        private void itm_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
          //  txtItmDesc.Clear();
        }

        private void itm_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.No)
            {
                return;
            }
              _mode = 2;
            ManageRecord();
        }

        private void itm_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 3;
            ManageRecord();
        }

        private void itm_print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("ITEM TYPE MASTER FILE");
            _report.BringToFront();
            _report.Show();
            //if (MessageBox.Show("This feature is not yet available ") ==
            //    System.Windows.Forms.DialogResult.No)
            //{
            //    return;
            //}
            //EnableForm(true);
        }

        private void itm_save_btn_Click(object sender, EventArgs e)
        {
            if (txtItemCode.Text == "")
            {
                btxMsg.ShowBalloon(txtItemCode);
                txtItemCode.Focus();
                return;
            }
            ManageRecord();
          //  EnableSaveButton(false);
           // EnableForm(false);
          //  txtItmDesc.Clear();
        }

        void ManageRecord()

        {

          //  AMSLogic.MasterFileMethods.ItemTypeRepository _itemrepo = new MasterFileMethods.ItemTypeRepository();

          //    itemlsvList.Items.Clear();
           ItemTypeRepository _itemrepo = new ItemTypeRepository();
           INV_TYPE _obj = new INV_TYPE();

            try

            {
                _obj.id = _id;
                _obj.item_code = txtItemCode.Text;
                _obj.description = txtItmDesc.Text;
                _obj.status = true;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;

                _id = _itemrepo.ManageItemType(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Saved!"); }
                else if (_mode ==2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                Cancel();
                
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
            ItemTypeRepository _itemrepo = new ItemTypeRepository();
            DisplayRecord(_itemrepo.GetitemType(_id));
        }
        private void ItemTypeMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void panFoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemFilter_Keydown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }

        private void txtItemFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
