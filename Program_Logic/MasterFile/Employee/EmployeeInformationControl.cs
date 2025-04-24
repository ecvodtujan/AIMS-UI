using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMS.Admin;
using AMSLogic.Model;
using AMS.Inquiry;
using AMSLogic.Admin;
using AMSLogic.Master;
using AMSLogic.Master.Repository;
using AMS.Report;
using AMSLogic.Transaction.Repository;

namespace AMS.MasterFile.Employee
{
    public partial class EmployeeInformationControl : UserControl
    {
        EmployeeNewMasterform _parent;
        int _mode = 0;
        public EmployeeInformationControl(EmployeeNewMasterform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void EmployeeInformationControl_Load(object sender, EventArgs e)
        {
            EmployeeRepository _iEmp = new EmployeeRepository();
            DisplayRecord(_iEmp.GetEmployee(_parent._emp_id));

            if (txtStatus.Text == "Inactive")
            {
                lblStatus.Text = "Employee is Inactive";
            }

            else
                lblStatus.Visible = false;
        }

        void DisplayRecord(EMP_EMPLOYEE _obj)
        {
            try
            {
                if (_obj != null)
                {
                    _parent._emp_id = _obj.id;
                    txtfname.Text = _obj.firstname;
                    txtmname.Text = _obj.middlename;
                    txtlname.Text = _obj.lastname;
                    txtCompanyName.Text = _obj.SYS_COMPANY.description;
                    txtCompanyName.Tag = int.Parse(_obj.company_id.ToString());
                    txtDepartment.Text = _obj.INV_DEPARTMENT.department;
                    txtDepartment.Tag = int.Parse(_obj.department_id.ToString());
                    txtAddress.Text = _obj.address;
                    txtEmailAddress.Text = _obj.email_address;
                    txtPosition.Text = _obj.SYS_POSITION.description;
                    txtPosition.Tag = int.Parse(_obj.position_id.ToString());
                    txtStatus.Text = _obj.status ? "Active" : "Inactive";
                    txtUsercreated.Text = _obj.SYS_USER.username;
                    txtDatecreated.Text = _obj.date_created.ToShortDateString();
                }
                else
                {
                    emp_add_btn.PerformClick();
                }

            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        void InitializeForm()
        {
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtCompanyName.Text = "";
            txtDepartment.Text = "";
            txtAddress.Text = "";
            txtPosition.Text = "";
            txtEmailAddress.Text = "";
            
            txtStatus.Text = "";
            txtUsercreated.Text = "";
            txtDatecreated.Text = "";
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
        void EnableForm(bool _emp)
        {
            txtfname.ReadOnly = !_emp;
            txtmname.ReadOnly = !_emp;
            txtlname.ReadOnly = !_emp;
            txtAddress.ReadOnly = !_emp;
            txtEmailAddress.ReadOnly = !_emp;
           // txtCompanyName.ReadOnly = !_emp;
           // txtDepartment.ReadOnly = !_emp;
        }
        void SearchButton(bool _emp)
        {
            btn_company.Enabled = _emp;
            btn_department.Enabled = _emp;
            btn_position.Enabled = _emp;
        }

        private void emp_edit_btn_Click(object sender, EventArgs e)
        {
            {
                if (_parent._emp_id != 0)
                {
                    _mode = 1;
                    EnableSaveButton(true);
                    EnableForm(true);
                    txtfname.Focus();
                    SearchButton(true);
                }
                else
                {
                    MessageBox.Show("No Record to Edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void emp_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (_parent._emp_id != 0)
            {
                if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
      System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                _mode = 2;
                ManageRecord();
            }
            else
            {
                MessageBox.Show("No Record to Deactivate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void emp_save_btn_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                btxMsg.ShowBalloon(txtfname);
                txtfname.Focus();
                return;
            }

          else  if (txtmname.Text == "")
            {
                btxMsg.ShowBalloon(txtmname);
                txtmname.Focus();
                return;
            }

           if (txtlname.Text == "")
            {
                btxMsg.ShowBalloon(txtlname);
                txtlname.Focus();
                return;
            }


           if (txtCompanyName.Text == "")
            {
                btxMsg.ShowBalloon(txtCompanyName);
                txtCompanyName.Focus();
                return;
            }


            if (txtDepartment.Text == "")
            {
                btxMsg.ShowBalloon(txtDepartment);
                txtDepartment.Focus();
                return;
            }

            if (txtPosition.Text == "")
            {
                btxMsg.ShowBalloon(txtPosition);
                txtPosition.Focus();
                return;
            }
            if (txtEmailAddress.Text == "")
            {
                btxMsg.ShowBalloon(txtEmailAddress);
                txtEmailAddress.Focus();
                return;
            }

            ManageRecord();
        }
        private void emp_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
        }
        void ManageRecord()
        {
            EmployeeRepository _emprepo = new EmployeeRepository();
            EMP_EMPLOYEE _obj = new EMP_EMPLOYEE();

            try
            {
                _obj.id = _parent._emp_id;
                _obj.firstname = txtfname.Text;
                _obj.middlename = txtmname.Text;
                _obj.lastname = txtlname.Text;
                _obj.company_id = int.Parse(txtCompanyName.Tag.ToString());
                _obj.department_id = int.Parse(txtDepartment.Tag.ToString());
                _obj.address = txtAddress.Text;
                _obj.email_address = txtEmailAddress.Text;
                _obj.position_id = int.Parse(txtPosition.Tag.ToString());
                _obj.status = true;
                _obj.user_id = LoginUser.userid;
                _obj.date_created = DateTime.Now;
                _parent._emp_id = _emprepo.ManageEmployee(_obj, _mode);


                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Successfully Saved"); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }


                //if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                Cancel();
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void Cancel()
        {
            EmployeeRepository _emprepo = new EmployeeRepository();
            EnableSaveButton(false);
            EnableForm(false);
            SearchButton(false);
            DisplayRecord(_emprepo.GetEmployee(_parent._emp_id));
        }

        private void txtCompanyName_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_company.PerformClick();
            }
        }


        private void btnCompany_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "COMPANY";
            _Searchform.ShowDialog();

            SYS_COMPANY _obj = _Searchform.ReturnSearchCompany;
            if (_obj != null)
            {
                txtCompanyName.Text = _obj.description;
                txtCompanyName.Tag = _obj.id;
            }
        }

        private void emp_activate_btn_Click(object sender, EventArgs e)
        {
            if (_parent._emp_id != 0)
            {
                if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
               System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                _mode = 3;
                ManageRecord();
            }
            else
            {
                MessageBox.Show("No Record to Activate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emp_print_btn_Click(object sender, EventArgs e)
        {
            //ReportViewerform _report = new ReportViewerform("EMPLOYEE MASTER FILE");
            //_report.BringToFront();
            //_report.Show();

          /*  ReportViewerform _report = new ReportViewerform("ACCOUNTABILITY PRINT OUT");
            _report._emp_id = _parent._emp_id;
            _report.BringToFront();
            _report.Show(); */


            PrintAccountabilityform _print = new PrintAccountabilityform(_parent._emp_id);
            _print.BringToFront();
            _print.ShowDialog();
            //_print.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Department_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "") { return; }
            Searchform _Searchform = new Searchform();
            _Searchform._companyid = int.Parse(txtCompanyName.Tag.ToString());
            _Searchform._searchby = "DEPARTMENT BY COMPANY";
            _Searchform.ShowDialog();

            INV_DEPARTMENT _obj = _Searchform.ReturnSearchDepartment;
            if (_obj != null)
            {
                txtDepartment.Text = _obj.department;
                txtDepartment.Tag = _obj.id;
            }
        }

        private void panFoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeInformationControl_keydown(object sender, KeyEventArgs e)
        {

        }

        private void txtDepartment_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_department.PerformClick();
            }
        }

        private void btn_position_Click(object sender, EventArgs e)
        {
            
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = "POSITION";
            _Searchform.ShowDialog();

            SYS_POSITION _obj = _Searchform.ReturnSearchPosition;
            if (_obj != null)
            {
                txtPosition.Text = _obj.description;
                txtPosition.Tag = _obj.id;
            }
        }

        private void txtPosition_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_position.PerformClick();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
