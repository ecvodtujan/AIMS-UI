using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMSLogic.Model;
using AMSLogic.Transaction;
using AMSLogic.Master.Repository;
using AMS.MasterFile.Employee;


namespace AMS.MasterFile.Employee
{
    public partial class EmployeeAssetHistory : UserControl
    {
        EmployeeNewMasterform _parent;
       // int _issuance_id = 0;
        public EmployeeAssetHistory(EmployeeNewMasterform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
        }
        private void EmployeeAssetHistory_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }
        void DisplayRecords()
        {
           EmployeeRepository _iemp = new EmployeeRepository();
            ItemTypeRepository _type = new ItemTypeRepository();
            BrandRepository _brand = new BrandRepository();
            AssetRepository _asset = new AssetRepository();
            dgvEmpHistory.RowCount = 0;
            int n = 0;
            try
            {
                List<INV_ISSUANCE> _issuances = _iemp.GetEmployeeAssetHistort(_parent._emp_id);
                if (_issuances.Count != 0)
                {
                    foreach (INV_ISSUANCE _list in _issuances)
                        if(_list.emp_id == _parent._emp_id)
                    {
                        n = dgvEmpHistory.Rows.Add();
                        dgvEmpHistory.Rows[n].Cells[0].Value = _list.id.ToString();
                        dgvEmpHistory.Rows[n].Cells[1].Value = _list.date_issued.ToShortDateString();
                        dgvEmpHistory.Rows[n].Cells[2].Value = _type.GetitemType(int.Parse(_list.INV_ASSET.inv_type_id.ToString())).description;
                        dgvEmpHistory.Rows[n].Cells[3].Value = _brand.GetBrand(int.Parse(_list.INV_ASSET.brand_id.ToString())).description;
                        dgvEmpHistory.Rows[n].Cells[4].Value = _list.INV_ASSET.specification;
                        dgvEmpHistory.Rows[n].Cells[5].Value = _list.INV_ASSET.serial_no;
                        dgvEmpHistory.Rows[n].Cells[6].Value = _list.remarks;

                          if (_list.is_history) { dgvEmpHistory.Rows[n].Cells[7].Value = "Pullout"; }
                        else { dgvEmpHistory.Rows[n].Cells[7].Value = "Current Owner"; }

                            if (_list.issued_by != 0)
                            {
                                UserRepository _iuser = new UserRepository();
                                dgvEmpHistory.Rows[n].Cells[8].Value = _iuser.GetUser(int.Parse(_list.issued_by.ToString())).employee_name;
                            }
                            else { dgvEmpHistory.Rows[n].Cells[8].Value = "-"; }
                             if (_list.date_pullout != null)
                        {
                            dgvEmpHistory.Rows[n].Cells[9].Value = _list.date_pullout.Value.ToShortDateString();
                        }
                        else
                        {
                            dgvEmpHistory.Rows[n].Cells[9].Value = "-";
                        }

                        if (_list.pullout_by != 0)
                        {
                            UserRepository _iuser = new UserRepository();
                            dgvEmpHistory.Rows[n].Cells[10].Value = _iuser.GetUser(int.Parse(_list.pullout_by.ToString())).employee_name;
                        }
                        else { dgvEmpHistory.Rows[n].Cells[10].Value = "-"; }
         
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

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}