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
using AMS.Inquiry;

using AMS.Report;
using AMS.Admin;

namespace AMS.MasterFile
{
    public partial class PrintAccountabilityform : Form

    {
        int _id = 0;
        int _mode = 0;
        int _emp_id = 0;

        EmployeeNewMasterform _parent;

        public PrintAccountabilityform(int _Emp_Id)
        {
            InitializeComponent();
            _emp_id = _Emp_Id;
        }

        private void dept_add_btn_Click(object sender, EventArgs e)
        {
            //_mode = 0;
            //EnableForm(true);
            //EnableSaveButton(true);
            //InitializeForm();
            //txtdeptCode.Focus();
        }

        void DisplayRecords()
        {
            EmployeeRepository _iemp = new EmployeeRepository();
            ItemTypeRepository _type = new ItemTypeRepository();
            BrandRepository _brand = new BrandRepository();
            AssetRepository _asset = new AssetRepository();
            dgvPrintEmpList.RowCount = 0;
            int n = 0;
            try
            {
                List<INV_ISSUANCE> _issuances = _iemp.GetEmployeeAssetHistort(_emp_id);
                if (_issuances.Count != 0)
                {
                    foreach (INV_ISSUANCE _list in _issuances)
                        if (_list.emp_id == _emp_id)
                        {
                            n = dgvPrintEmpList.Rows.Add();
                            dgvPrintEmpList.Rows[n].Cells[0].Value = _list.id.ToString();
                            dgvPrintEmpList.Rows[n].Cells[1].Value = "Print";
                            dgvPrintEmpList.Rows[n].Cells[2].Value = _list.date_issued.ToShortDateString();
                            dgvPrintEmpList.Rows[n].Cells[3].Value = _type.GetitemType(int.Parse(_list.INV_ASSET.inv_type_id.ToString())).description;
                            dgvPrintEmpList.Rows[n].Cells[4].Value = _brand.GetBrand(int.Parse(_list.INV_ASSET.brand_id.ToString())).description;
                            dgvPrintEmpList.Rows[n].Cells[5].Value = _list.INV_ASSET.specification;
                            dgvPrintEmpList.Rows[n].Cells[6].Value = _list.INV_ASSET.serial_no;
                            dgvPrintEmpList.Rows[n].Cells[7].Value = _list.remarks;

                            if (_list.is_history) { dgvPrintEmpList.Rows[n].Cells[8].Value = "Pullout"; }
                            else { dgvPrintEmpList.Rows[n].Cells[8].Value = "Current Owner"; }

                            if (_list.issued_by != 0)
                            {
                                UserRepository _iuser = new UserRepository();
                                dgvPrintEmpList.Rows[n].Cells[9].Value = _iuser.GetUser(int.Parse(_list.issued_by.ToString())).employee_name;
                            }
                            else { dgvPrintEmpList.Rows[n].Cells[9].Value = "-"; }

                            dgvPrintEmpList.Rows[n].Cells[10].Value = _list.asset_id;
                        }
                }
                else
                {
                    MessageBox.Show("No record found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        void DisplayRecord(INV_DEPARTMENT _obj)
        {
            DepartmentRepository _deptrepo = new DepartmentRepository();
            try
            {
                INV_DEPARTMENT _dobj = new INV_DEPARTMENT();
                _dobj = _deptrepo.GetDept(_id);

                if (_dobj != null)
                {
                    _id = _dobj.id;
                    //txtdeptCode.Text = _dobj.department;
                    //txtCompany.Text = _dobj.SYS_COMPANY.description;
                    //txtCompany.Tag = int.Parse(_dobj.company_id.ToString());
                    //txtStatus.Text = _dobj.status ? "Active" : "Inactive";
                    //txtUsercreated.Text = _dobj.SYS_USER.username;
                    //txtDatecreated.Text = _dobj.date_created.ToShortDateString();

                }
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DepartmentMasterfile_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            DepartmentRepository _ideptrepo = new DepartmentRepository();
            DisplayRecord(_ideptrepo.GetDept(_id));
        }

        private void deptLsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (dgvEmpList.SelectedItems.Count == 0) { return; }
            //try
            //{
            //    _id = int.Parse(dgvEmpList.SelectedItems[0].Text);
            //    DepartmentRepository _ideptrepo = new DepartmentRepository();
            //    DisplayRecord(_ideptrepo.GetDept(_id));
            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
          ReportViewerform _report = new ReportViewerform("ACCOUNTABILITY PRINT OUT");
           _report._emp_id = _parent._emp_id;
           _report.BringToFront();
           _report.Show();

        }
        void InitializeForm()
        {
            //txtdeptCode.Text = "";
            //txtCompany.Text = "";
            //txtStatus.Text = "";
            //txtUsercreated.Text = "";
            //txtDatecreated.Text = "";
        }

        void EnableForm(bool _dept)

        {
           // txtdeptCode.ReadOnly = !_dept;
           //// txtCompany.ReadOnly = !_dept;
           // txtStatus.ReadOnly = !_dept;
           // txtUsercreated.ReadOnly = !_dept;
           // txtDatecreated.ReadOnly = !_dept;
           // deptLsvList.Enabled = !_dept;
        }
        void EnableSaveButton(bool _dept)
        {
            //dept_save_btn.Enabled = _dept;
            //dept_cancel_btn.Enabled = _dept;
            //dept_add_btn.Enabled = !_dept;
            //dept_edit_btn.Enabled = !_dept;
            //dept_deactivate_btn.Enabled = !_dept;
            //dept_activate_btn.Enabled = !_dept;
            //dept_print_btn.Enabled = !_dept;
            //dept_search_btn.Enabled = _dept;
        }

        void ManageRecord()
        {
            DepartmentRepository _deptrepo = new DepartmentRepository();
            INV_DEPARTMENT _obj = new INV_DEPARTMENT();

            try
            {
                //_obj.id = _id;
                //_obj.department = txtdeptCode.Text;
                //_obj.company_id = int.Parse(txtCompany.Tag.ToString());
                //_obj.status = true;
                //_obj.user_id = LoginUser.userid;
                //_obj.date_created = DateTime.Now;
                //_id = _deptrepo.ManageDept(_obj, _mode);

                //if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, "Record Saved Successfully"); }
                //else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Deactivated!"); }
                //else if (_mode == 3) { ToolsControl.CallShowNotification(this, _mode, "Record successfully Activated!"); }

                ////if (_mode == 0) { MessageBox.Show("Record successfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                ////else if (_mode == 1) { MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                ////else if (_mode == 2) { MessageBox.Show("Record successfully Deactivated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                ////else if (_mode == 3) { MessageBox.Show("Record successfully Activated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                //Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void Cancel()
        {
            DepartmentRepository _deptrepo = new DepartmentRepository();
            EnableSaveButton(false);
            EnableForm(false);
            DisplayRecord(_deptrepo.GetDept(_id));
            DisplayRecords();
        }

        private void dept_Save_btn_click(object sender, EventArgs e)
        {
            //if (txtdeptCode.Text == "")
            //{
            //    btxMsg.ShowBalloon(txtdeptCode);
            //    txtdeptCode.Focus();
            //    return;
            //}
            //ManageRecord();
        }

        private void panFoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dept_edit_btn_Click(object sender, EventArgs e)
        {
            //_mode = 1;
            // EnableForm(true);
            //EnableSaveButton(true);
            //txtdeptCode.Focus();
        }

        private void dept_deactivate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on deactivating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
        System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 2;
            ManageRecord();
        }

        private void dept_activate_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed on activating this record, Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
              System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            _mode = 3;
            ManageRecord();
        }

        private void dept_print_btn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Comming soon","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReportViewerform _report = new ReportViewerform("DEPARTMENT MASTER FILE");
            _report.BringToFront();
            _report.Show();
        }

        private void dept_cancel_btn_Click(object sender, EventArgs e)
        {
            EnableSaveButton(false);
            EnableForm(false);
        }

        private void txtCompany_Keydwn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                printAll_btn.PerformClick();
            }
        }

        private void department_keydown(object sender, KeyEventArgs e)
        {

        }

        private void departmentMasterform_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDepartmentfilter(object sender, EventArgs e)
     

           { /*DisplayRecords(); */}

        private void txtDepartment_Keydown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Return)
            {
                DisplayRecords();
            }
        }

        private void dgvEmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printAll_Click(object sender, EventArgs e)
        {
            try
            {
                ReportViewerform _report = new ReportViewerform("ACCOUNTABILITY PRINT OUT");
                _report._asset_id = 0;
                _report._emp_id = _emp_id;
                _report.BringToFront();
                _report.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //ReportViewerform _report = new ReportViewerform("ACCOUNTABILITY PRINT OUT");
            //_report._asset_id = 0;
            //_report._emp_id = _emp_id;
            //_report.BringToFront();
            //_report.Show();
        }

        private void dgvPrintEmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int _asset_id = int.Parse(dgvPrintEmpList.Rows[e.RowIndex].Cells[10].Value.ToString());
            if (e.ColumnIndex == 1)
                {
                    ReportViewerform _report = new ReportViewerform("ACCOUNTABILITY PRINT OUT");
                    _report._asset_id = _asset_id;
                    _report._emp_id = _emp_id;
                    _report.BringToFront();
                    _report.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
