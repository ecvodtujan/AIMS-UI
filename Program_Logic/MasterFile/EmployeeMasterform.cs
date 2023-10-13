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
using AMS.Inquiry;
using AMS.Report;
using AMS.Admin;

namespace AMS.MasterFile
    
{
    public partial class EmployeeMasterform : Form
    { int _id = 0;
        int _mode = 0;
        //  int _company_id = 0;

        public EmployeeMasterform()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void EmployeeMasterform_Load(object sender, EventArgs e)
        {
            DisplayRecord();
            DisplayRecords();
        }
        void DisplayRecords()
        { EmployeeRepository _emprepo = new EmployeeRepository();
            emplsvList.Items.Clear();
            { List<EMP_EMPLOYEE> _emp = new List<EMP_EMPLOYEE>();
                _emp = _emprepo.GetEmployees();
                foreach (EMP_EMPLOYEE _i in _emp)
                {
                    ListViewItem _em = new ListViewItem(_i.id.ToString());
                    _em.SubItems.Add(_i.firstname);
                    _em.SubItems.Add(_i.middlename);
                    _em.SubItems.Add(_i.lastname);
                    _em.SubItems.Add(_i.SYS_COMPANY.description);
                    _em.SubItems.Add(_i.status ? "Active" : "Inactive");
                    _em.SubItems.Add(_i.SYS_USER.username);
                    _em.SubItems.Add(_i.date_created.ToShortDateString());
                    emplsvList.Items.Add(_em); }
            }
        }
        void DisplayRecord()
        { EmployeeRepository _emprepo = new EmployeeRepository();
            {
                EMP_EMPLOYEE _emp = _emprepo.GetEmployee(_id);
                try
                {
                    if (_emp != null)
                    {
                        _id = _emp.id;
                        txtfname.Text = _emp.firstname;
                        txtmname.Text = _emp.middlename;
                        txtlname.Text = _emp.lastname;
                        txtCompanyName.Text = _emp.SYS_COMPANY.description;
                        txtCompanyName.Tag = int.Parse(_emp.company_id.ToString());
                        //  _company_id = _emp.company_id;
                        txtStatus.Text = _emp.status ? "Active" : "Inactive";
                        txtUsercreated.Text = _emp.SYS_USER.username;
                        txtDatecreated.Text = _emp.date_created.ToShortDateString();
                    }
                    else
                    { MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        private void label4_Click(object sender, EventArgs e)
        { }
        private void emp_deactivate_btn_Click(object sender, EventArgs e)
        { if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
  System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 2;
            ManageRecord(); }
        private void EmployeeMasterform_Click(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Escape)
            { this.Close(); }
        }
        private void emplsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emplsvList.SelectedItems.Count == 0) { return; }
            try
            { _id = int.Parse(emplsvList.SelectedItems[0].Text);
                DisplayRecord(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btn_company_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtCompanyName.Text = _obj.description;
                txtCompanyName.Tag = _obj.id;
                //  _company_id = _obj.id;
            }
        }

        private void emp_add_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableSaveButton(true);
            EnableForm(true);
            txtfname.Focus();
            SearchButton(true);
        }

        void EnableForm(bool _emp)
        {
            txtfname.ReadOnly = !_emp;
            txtmname.ReadOnly = !_emp;
            txtlname.ReadOnly = !_emp;
            txtCompanyName.ReadOnly = !_emp;
            emplsvList.Enabled = !_emp;
        }
        void EnableSaveButton(bool _emp)

        {
            emp_save_btn.Enabled = _emp;
            emp_cancel_btn.Enabled = _emp;
            emp_add_btn.Enabled = !_emp;
            emp_activate_btn.Enabled = !_emp;
            emp_edit_btn.Enabled = !_emp;
            emp_deactivate_btn.Enabled = !_emp;
            emp_print_btn.Enabled = !_emp;
        }
        void InitializeForm()

        {
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtCompanyName.Text = "";
            txtStatus.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
        }

        void SearchButton(bool _emp)
         { 
            btn_company.Enabled = _emp;
         }
        private void emp_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecords();
            //txtfname.Clear();
            //txtmname.Clear();
            //txtlname.Clear();
            //txtCompanyName.Clear();
            //SearchButton(false);     
        }
        private void emp_edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            EnableSaveButton(true);
            EnableForm(true);
            txtfname.Focus();
            SearchButton(true);
        }
        private void emp_save_btn_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                btxMsg.ShowBalloon(txtfname);
                txtfname.Focus();
                return;
            }
            ManageRecord();
            //EnableSaveButton(false);
            //EnableForm(false);
            //txtfname.Clear();
            //txtmname.Clear();
            //txtlname.Clear();
            //txtCompanyName.Clear();
            //SearchButton(false);   
        }
        void ManageRecord()
        {
            EmployeeRepository _emprepo = new EmployeeRepository();
            EMP_EMPLOYEE _obj = new EMP_EMPLOYEE();

            try
            {
                _obj.id = _id;
                _obj.firstname = txtfname.Text;
                _obj.middlename = txtmname.Text;
                _obj.lastname = txtlname.Text;
                _obj.company_id = int.Parse(txtCompanyName.Tag.ToString());
               // _obj.company_id = _company_id
                _obj.status = true;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;
                _id = _emprepo.ManageEmployee(_obj, _mode);

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }


                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
           
                EnableSaveButton(false);
                EnableForm(false);
                SearchButton(false);
                DisplayRecords();
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   }
        }

        private void emp_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 3;
            ManageRecord();
        }
        private void emp_print_btn_Click(object sender, EventArgs e)
        {
            ReportViewerform _report = new ReportViewerform("EMPLOYEE MASTER FILE");
            _report.BringToFront();
            _report.Show();
            //if (MessageBox.Show("This feature is not yet available ") ==
            //               System.Windows.Forms.DialogResult.No)
            //{
            //    return;
            //}
            //EnableForm(true);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
